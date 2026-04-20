// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using Managed.Win32.Wfp.Native;
using static Managed.Win32.Wfp.Native.Methods;
using Guid = System.Guid;

namespace Xobex.Net.Routing;

public sealed unsafe class WfpConnectionMonitor : IDisposable
{
    private void* _engineHandle;
    private void* _subscriptionHandle;
    private GCHandle _instanceHandle;

    private readonly Lock _syncLock = new();
    private readonly Channel<uint> _eventChannel;
    private readonly CancellationTokenSource _cts;
    private readonly Guid _providerGuid = new("12345678-1234-1234-1234-123456789012");
    private readonly Guid _subLayerGuid = new("87654321-4321-4321-4321-210987654321");

    private IntPtr _sessionNamePtr;
    private IntPtr _providerNamePtr;
    private IntPtr _subLayerNamePtr;
    private IntPtr _filterNamePtr;

    public event Action<uint>? OnConnectionAttempt;

    public WfpConnectionMonitor()
    {
        _eventChannel = Channel.CreateBounded<uint>(new BoundedChannelOptions(10000)
        {
            SingleReader = true,
            SingleWriter = false,
            FullMode = BoundedChannelFullMode.DropOldest,
            AllowSynchronousContinuations = false
        });

        _cts = new CancellationTokenSource();
        _ = Task.Run(() => ProcessEventsAsync(_cts.Token));

        _sessionNamePtr = Marshal.StringToHGlobalUni("Bypass Monitor Session");
        _providerNamePtr = Marshal.StringToHGlobalUni("Routing Monitor Provider");
        _subLayerNamePtr = Marshal.StringToHGlobalUni("Routing Monitor SubLayer");
        _filterNamePtr = Marshal.StringToHGlobalUni("ALE Connect V4 Sensor");
    }

    private const uint RPC_C_AUTHN_DEFAULT = 0xFFFFFFFFu;
    private const uint FWPM_SESSION_FLAG_DYNAMIC = 0x00000001;

    public unsafe void Start()
    {
        lock (_syncLock)
        {
            if (_engineHandle != null)
            {
                return;
            }

            // Create a dynamic session for adding dynamic objects
            var sessionGuid = Guid.NewGuid();
            var session = new FWPM_SESSION0_
            {
                sessionKey = sessionGuid,
                displayData = new FWPM_DISPLAY_DATA0_
                {
                    name = (char*)_sessionNamePtr,
                    description = null
                },
                flags = FWPM_SESSION_FLAG_DYNAMIC,
                txnWaitTimeoutInMSec = 0,
                processId = 0,
                sid = null,
                username = null,
                kernelMode = 0
            };

            void* pEngine;
            var status = FwpmEngineOpen0(null, RPC_C_AUTHN_DEFAULT, null, &session, &pEngine);
            if (status != 0)
            {
                throw new InvalidOperationException($"FwpmEngineOpen0 failed with error code {status}. Ensure the application is running with administrator privileges and Windows Firewall service is running.");
            }
            _engineHandle = pEngine;

            //var value = new FWP_VALUE0_() { type = FWP_DATA_TYPE_.FWP_UINT32, uint32 = 1 };
            //status = FwpmEngineSetOption(_engineHandle, FWPM_ENGINE_OPTION_.FWPM_ENGINE_COLLECT_NET_EVENTS, &value);
            //if (status != 0)
            //{
            //    throw new InvalidOperationException($"FwpmEngineSetOption failed to enable net event collection with error code {status}.");
            //}

            try
            {
                Console.WriteLine("Opening WFP engine transaction...");
                FwpmTransactionBegin0(_engineHandle, 0);

                Console.WriteLine("Adding provider and sublayer...");
                AddProviderAndSubLayer();

                Console.WriteLine("Adding sensor filter...");
                AddSensorFilter();

                Console.WriteLine("Committing transaction...");
                var commitStatus = FwpmTransactionCommit0(_engineHandle);
                if (commitStatus != 0)
                {
                    throw new InvalidOperationException($"TransactionCommit failed: {commitStatus}");
                }

                Console.WriteLine("Transaction committed successfully.");
                Console.WriteLine("Waiting for events...");

                // Subscribe to events AFTER transaction is committed
                Console.WriteLine("Subscribing to network events...");
                SubscribeToNetEvents();

                SubscribeToConnections();

                Console.WriteLine("WFP engine initialized successfully.");
            }
            catch
            {
                if (_engineHandle != null)
                {
                    _ = FwpmTransactionAbort0(_engineHandle);
                    _ = FwpmEngineClose0(_engineHandle);
                    _engineHandle = null;
                }
                throw;
            }
        }
    }

    private unsafe void AddProviderAndSubLayer()
    {
        var provider = new FWPM_PROVIDER0
        {
            providerKey = _providerGuid,
            displayData = new FWPM_DISPLAY_DATA0_
            {
                name = (char*)_providerNamePtr,
                description = null
            }
        };
        var providerStatus = FwpmProviderAdd0(_engineHandle, &provider, null);
        if (providerStatus != 0)
        {
            // Provider might already exist, ignore error
            Console.WriteLine($"Warning: FwpmProviderAdd0 returned {providerStatus}");
        }

        var providerKeyForSubLayer = _providerGuid;
        var subLayer = new FWPM_SUBLAYER0_
        {
            subLayerKey = _subLayerGuid,
            displayData = new FWPM_DISPLAY_DATA0_
            {
                name = (char*)_subLayerNamePtr,
                description = null
            },
            providerKey = &providerKeyForSubLayer,
            weight = 0xFFFF
        };
        var subLayerStatus = FwpmSubLayerAdd0(_engineHandle, &subLayer, null);
        if (subLayerStatus != 0)
        {
            // SubLayer might already exist, ignore error
            Console.WriteLine($"Warning: FwpmSubLayerAdd0 returned {subLayerStatus}");
        }
    }

    private unsafe void AddSensorFilter()
    {
        // FWPM_LAYER_ALE_AUTH_CONNECT_V4: c38d57d1-05a7-4c33-904f-7fbceee60e82
        var layerGuid = new Guid("c38d57d1-05a7-4c33-904f-7fbceee60e82");
        var providerKeyForFilter = _providerGuid;

        Console.WriteLine($"Adding filter to layer: {layerGuid}");

        var filter = new FWPM_FILTER0_
        {
            filterKey = Guid.NewGuid(),
            displayData = new FWPM_DISPLAY_DATA0_
            {
                name = (char*)_filterNamePtr,
                description = null
            },
            flags = FWPM_FILTER_FLAG_NONE,
            providerKey = &providerKeyForFilter,
            providerData = default,
            layerKey = layerGuid,
            subLayerKey = _subLayerGuid,
            //weight = new FWP_VALUE0_ { type = FWP_DATA_TYPE_.FWP_UINT16, uint16 = 65535 },
            weight = new FWP_VALUE0_ { type = FWP_DATA_TYPE_.FWP_UINT8, uint8 = 15 },
            numFilterConditions = 0,
            filterCondition = null,
            action = new FWPM_ACTION0_ { type = FWP_ACTION_PERMIT },
        };

        var status = FwpmFilterAdd0(_engineHandle, &filter, null, null);
        if (status != 0)
        {
            Console.Error.WriteLine($"FwpmFilterAdd0 failed: {status} (0x{status:X8})");
            Console.Error.WriteLine($"  Filter Key: {filter.filterKey}");
            Console.Error.WriteLine($"  Layer Key: {filter.layerKey}");
            Console.Error.WriteLine($"  SubLayer Key: {filter.subLayerKey}");
            throw new InvalidOperationException($"FwpmFilterAdd0 failed: {status}");
        }

        Console.WriteLine("Filter added successfully with PERMIT action.");
    }

    // Вставьте это в ваш класс WfpConnectionMonitor вместо методов SubscribeToNetEvents и NetEventCallback

    private unsafe void SubscribeToConnections()
    {
        _instanceHandle = GCHandle.Alloc(this);

        Console.WriteLine("Subscribing to ALE connections...");

        // Пустой шаблон (enumTemplate = null) означает, что мы хотим получать события 
        // обо ВСЕХ соединениях. При желании можно фильтровать по layerId / condition.
        var subscription = new FWPM_CONNECTION_SUBSCRIPTION0_
        {
            enumTemplate = null,
            flags = 0,
            sessionKey = Guid.Empty
        };

        fixed (void** pSubscription = &_subscriptionHandle)
        {
            // Вызов API подписки на соединения
            var status = FwpmConnectionSubscribe0(
                _engineHandle,
                &subscription,
                &ConnectionCallback,
                (void*)GCHandle.ToIntPtr(_instanceHandle),
                pSubscription);

            if (status != 0)
            {
                _instanceHandle.Free();
                Console.Error.WriteLine($"FwpmConnectionSubscribe0 failed: {status} (0x{status:X8})");
                throw new InvalidOperationException($"FwpmConnectionSubscribe0 failed: {status}");
            }
        }

        Console.WriteLine("Successfully subscribed to ALE connections.");
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
    private static unsafe void ConnectionCallback(
        void* context,
        FWPM_CONNECTION_EVENT_TYPE_ eventType,
        FWPM_CONNECTION0_* connection)
    {
        if (context == null || connection == null)
        {
            return;
        }

        try
        {
            Console.WriteLine($"[ConnectionCallback] Type: {eventType}");
            // Нас интересует только момент создания нового соединения (ADD).
            // Доступные типы: FWPM_CONNECTION_EVENT_ADD, FWPM_CONNECTION_EVENT_DELETE, FWPM_CONNECTION_EVENT_MATCH
            if (eventType == FWPM_CONNECTION_EVENT_TYPE_.FWPM_CONNECTION_EVENT_ADD)
            {
                // Проверяем, что это IPv4 (AF_INET = 2)
                // В структуре FWPM_CONNECTION0 IP-адреса могут лежать в union.
                // Зависит от того, как ваш CsWin32 сгенерировал структуру (возможно, через Anonymous).

                // Если у вас union раскрыт плоско (зависит от генератора P/Invoke):
                var remoteIp = connection->remoteV4Address;

                // Получаем IP в формате System.Net.IPAddress для логов (опционально)
                var ipAddr = new System.Net.IPAddress(remoteIp);

                // Для оптимизации вы можете сразу отсеивать Loopback (127.0.0.0/8)
                // и Broadcast адреса прямо здесь в нативном колбэке, чтобы не засорять канал
                var firstOctet = (byte)(remoteIp & 0xFF); // Учитываем Network Byte Order или Host Byte Order
                if (firstOctet == 127)
                {
                    return;
                }

                Console.WriteLine($"[Connection ADD] Remote IP: {ipAddr}");

                var handle = GCHandle.FromIntPtr((IntPtr)context);
                if (handle.Target is WfpConnectionMonitor monitor)
                {
                    // Закидываем IP в канал на асинхронную обработку
                    _ = monitor._eventChannel.Writer.TryWrite(remoteIp);
                }
            }
            else if (eventType == FWPM_CONNECTION_EVENT_TYPE_.FWPM_CONNECTION_EVENT_DELETE)
            {
                // Соединение закрыто (опционально для отладки)
                var remoteIp = connection->remoteV4Address;
                Console.WriteLine($"[Connection DELETE] Remote IP: {new System.Net.IPAddress(remoteIp)}");
            }
        }
        catch (Exception ex)
        {
            // Защита от FailFast при маршалинге или ошибках
            Console.Error.WriteLine($"[ConnectionCallback] Exception: {ex}");
        }
    }

    private unsafe void SubscribeToNetEvents()
    {
        _instanceHandle = GCHandle.Alloc(this);

        Console.WriteLine("Subscribing to network events...");

        var template = new FWPM_NET_EVENT_ENUM_TEMPLATE0_
        {
            startTime = default,
            endTime = default,
            numFilterConditions = 0,
            filterCondition = null
        };
        template.endTime.dwHighDateTime = 0xFFFFFFFFu;
        template.endTime.dwLowDateTime = 0xFFFFFFFFu;

        var subscription = new FWPM_NET_EVENT_SUBSCRIPTION0_
        {
            enumTemplate = &template,
            flags = 0,
            sessionKey = Guid.Empty
        };

        void* pSubscription;
        // Try FwpmNetEventSubscribe0 first
        var status = FwpmNetEventSubscribe0(
            _engineHandle,
            &subscription,
            &NetEventCallbackV0,
            (void*)GCHandle.ToIntPtr(_instanceHandle),
            &pSubscription);

        if (status != 0)
        {
            Console.WriteLine($"FwpmNetEventSubscribe0 failed: {status} (0x{status:X8}), trying FwpmNetEventSubscribe2...");

            // Fallback to FwpmNetEventSubscribe2
            status = Methods.FwpmNetEventSubscribe2(
                _engineHandle,
                &subscription,
                &NetEventCallback,
                (void*)GCHandle.ToIntPtr(_instanceHandle),
                &pSubscription);

            if (status != 0)
            {
                _instanceHandle.Free();
                Console.Error.WriteLine($"FwpmNetEventSubscribe2 also failed: {status} (0x{status:X8})");
                throw new InvalidOperationException($"FwpmNetEventSubscribe failed: {status}");
            }
        }
        _subscriptionHandle = pSubscription;

        Console.WriteLine("Successfully subscribed to network events.");
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
    private static unsafe void NetEventCallbackV0(void* context, FWPM_NET_EVENT1_* eventPtr)
    {
        if (context == null || eventPtr == null)
        {
            return;
        }

        try
        {
            Console.WriteLine($"[NetEventCallbackV0] Type: {eventPtr->type}");

            if (eventPtr->type == FWPM_NET_EVENT_TYPE_.FWPM_NET_EVENT_TYPE_CLASSIFY_ALLOW)
            {
                var remoteIp = eventPtr->header.Anonymous2.remoteAddrV4;
                Console.WriteLine($"[NetEventCallbackV0] CLASSIFY_ALLOW - Remote IP: {new System.Net.IPAddress(remoteIp)}");

                var handle = GCHandle.FromIntPtr((IntPtr)context);
                if (handle.Target is WfpConnectionMonitor monitor)
                {
                    _ = monitor._eventChannel.Writer.TryWrite(remoteIp);
                }
            }
            else if (eventPtr->type == FWPM_NET_EVENT_TYPE_.FWPM_NET_EVENT_TYPE_CLASSIFY_DROP)
            {
                var remoteIp = eventPtr->header.Anonymous2.remoteAddrV4;
                Console.WriteLine($"[NetEventCallbackV0] CLASSIFY_DROP - Remote IP: {new System.Net.IPAddress(remoteIp)}");
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[NetEventCallbackV0] Exception: {ex}");
        }
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
    private static unsafe void NetEventCallback(void* context, FWPM_NET_EVENT3_* eventPtr)
    {
        if (context == null || eventPtr == null)
        {
            return;
        }

        try
        {
            if (eventPtr->type == FWPM_NET_EVENT_TYPE_.FWPM_NET_EVENT_TYPE_CLASSIFY_ALLOW)
            {
                var remoteIp = eventPtr->header.Anonymous2.remoteAddrV4;
                Console.WriteLine($"[NetEventCallback] CLASSIFY_ALLOW - Remote IP: {new System.Net.IPAddress(remoteIp)}");

                var handle = GCHandle.FromIntPtr((IntPtr)context);
                if (handle.Target is WfpConnectionMonitor monitor)
                {
                    _ = monitor._eventChannel.Writer.TryWrite(remoteIp);
                }
            }
            else if (eventPtr->type == FWPM_NET_EVENT_TYPE_.FWPM_NET_EVENT_TYPE_CLASSIFY_DROP)
            {
                var remoteIp = eventPtr->header.Anonymous2.remoteAddrV4;
                Console.WriteLine($"[NetEventCallback] CLASSIFY_DROP - Remote IP: {new System.Net.IPAddress(remoteIp)}");
            }
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"[NetEventCallback] Exception: {ex}");
        }
    }

    private Task ProcessEventsAsync(CancellationToken ct)
    {
        return Task.Run(() => ProcessEventsSync(ct), ct);
    }

    private void ProcessEventsSync(CancellationToken ct)
    {
        try
        {
            while (!ct.IsCancellationRequested)
            {
                // Use blocking wait with timeout
                if (_eventChannel.Reader.WaitToReadAsync(ct).IsCompletedSuccessfully)
                {
                    while (_eventChannel.Reader.TryRead(out var remoteIp))
                    {
                        OnConnectionAttempt?.Invoke(remoteIp);
                    }
                }
                else
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
        catch (OperationCanceledException) { }
    }

    public void Dispose()
    {
        lock (_syncLock)
        {
            if (_engineHandle == null)
            {
                return;
            }

            _cts.Cancel();

            unsafe
            {
                if (_subscriptionHandle != null)
                {
                    _ = FwpmNetEventUnsubscribe0(_engineHandle, _subscriptionHandle);
                    _subscriptionHandle = null;
                }

                _ = FwpmEngineClose0(_engineHandle);
                _engineHandle = null;
            }

            if (_instanceHandle.IsAllocated)
            {
                _instanceHandle.Free();
            }

            if (_sessionNamePtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(_sessionNamePtr);
                _sessionNamePtr = IntPtr.Zero;
            }

            if (_providerNamePtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(_providerNamePtr);
                _providerNamePtr = IntPtr.Zero;
            }

            if (_subLayerNamePtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(_subLayerNamePtr);
                _subLayerNamePtr = IntPtr.Zero;
            }

            if (_filterNamePtr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(_filterNamePtr);
                _filterNamePtr = IntPtr.Zero;
            }

            _cts.Dispose();
            GC.SuppressFinalize(this);
        }
    }

    ~WfpConnectionMonitor() => Dispose();
}

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            _ = Process.Start(@"auditpol", @"/set /subcategory:""Filtering Platform Packet Drop"" /success:disable /failure:disable");
            _ = Process.Start(@"auditpol", @"/set /subcategory:""Filtering Platform Connection"" /success:disable /failure:disable");

            WfpConnectionMonitor monitor = new();
            monitor.OnConnectionAttempt += Monitor_OnConnectionAttempt;

            Console.WriteLine("Starting connection monitor...");
            Console.WriteLine("Note: This application requires administrator privileges to run.");
            Console.WriteLine();

            monitor.Start();

            Console.WriteLine("Monitoring outgoing connections. Press Enter to exit...");
            _ = Console.ReadLine();

            monitor.Dispose();
            Console.WriteLine("Monitor stopped.");
        }
        catch (InvalidOperationException ex)
        {
            Console.Error.WriteLine($"Error: {ex.Message}");
            Environment.Exit(1);
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine($"Unexpected error: {ex}");
            Environment.Exit(1);
        }
    }

    private static void Monitor_OnConnectionAttempt(uint obj)
    {
        Console.WriteLine($"Remote IP: {new System.Net.IPAddress(obj)}");
    }
}
