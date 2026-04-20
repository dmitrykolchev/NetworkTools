// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using Managed.Win32.Wfp.Native;
using static Managed.Win32.Wfp.Native.Methods;

namespace Xobex.Net.Routing;

public sealed unsafe class WfpConnectionMonitor : IDisposable
{
    private void* _engineHandle;
    private void* _subscriptionHandle;
    private GCHandle _instanceHandle;

    private readonly Lock _syncLock = new(); // .NET 9+ Lock
    private readonly Channel<uint> _eventChannel;
    private readonly CancellationTokenSource _cts;

    // GUIDs (генерация уникальных идентификаторов для вашего провайдера и субслоя)
    private readonly Guid _providerGuid = new("YOUR-PROVIDER-GUID-HERE");
    private readonly Guid _subLayerGuid = new("YOUR-SUBLAYER-GUID-HERE");

    public event Action<uint>? OnConnectionAttempt;

    public WfpConnectionMonitor()
    {
        // Канал с отбрасыванием старых событий при переполнении (опционально, для защиты памяти)
        _eventChannel = Channel.CreateBounded<uint>(new BoundedChannelOptions(10000)
        {
            SingleReader = true,
            SingleWriter = false,
            FullMode = BoundedChannelFullMode.DropOldest,
            AllowSynchronousContinuations = false
        });

        _cts = new CancellationTokenSource();
        _ = Task.Run(() => ProcessEventsAsync(_cts.Token));
    }

    public unsafe void Start()
    {
        lock (_syncLock)
        {
            if (_engineHandle != null)
            {
                return;
            }

            // 1. Открытие динамической сессии
            var session = new FWPM_SESSION0_
            {
                flags = FWPM_SESSION_FLAG_DYNAMIC,
                displayData = new FWPM_DISPLAY_DATA0_ { name = "Bypass Monitor Session" }
            };

            fixed (void** pEngine = &_engineHandle)
            {
                var status = FwpmEngineOpen0(null, FWPM_AUTH_NONE, null, &session, pEngine);
                if (status != 0)
                {
                    throw new InvalidOperationException($"FwpmEngineOpen0 failed: {status}");
                }
            }

            try
            {
                // Транзакция гарантирует атомарность применения правил
                FwpmTransactionBegin0(_engineHandle, 0);

                AddProviderAndSubLayer();
                AddSensorFilter();
                SubscribeToNetEvents();

                var commitStatus = FwpmTransactionCommit0(_engineHandle);
                if (commitStatus != 0)
                {
                    throw new InvalidOperationException($"TransactionCommit failed: {commitStatus}");
                }
            }
            catch
            {
                if (_engineHandle != null)
                {
                    FwpmTransactionAbort0(_engineHandle);
                    FwpmEngineClose0(_engineHandle);
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
            displayData = new FWPM_DISPLAY_DATA0_ { name = "Routing Monitor Provider" }
        };
        FwpmProviderAdd0(_engineHandle, &provider, null);

        var subLayer = new FWPM_SUBLAYER0_
        {
            subLayerKey = _subLayerGuid,
            displayData = new FWPM_DISPLAY_DATA0_ { name = "Routing Monitor SubLayer" },
            providerKey = &_providerGuid,
            weight = 0xFFFF // Максимальный вес в рамках слоя
        };
        FwpmSubLayerAdd0(_engineHandle, &subLayer, null);
    }

    private unsafe void AddSensorFilter()
    {
        var filter = new FWPM_FILTER0_
        {
            filterKey = Guid.NewGuid(),
            layerKey = FWPM_LAYER_ALE_AUTH_CONNECT_V4,
            subLayerKey = _subLayerGuid,
            providerKey = &_providerGuid,
            displayData = new FWPM_DISPLAY_DATA0_ { name = "ALE Connect V4 Sensor" },
            weight = new FWP_VALUE0_ { type = FWP_DATA_TYPE_.FWP_UINT8, uint8 = 15 },
            action = new FWPM_ACTION0_ { type = FWP_ACTION_PERMIT },

            // Фильтрация (опционально): Исключаем Loopback (127.0.0.0/8), чтобы не спамить события
            // В продакшене обязательно добавьте FWPM_FILTER_CONDITION0 для FWP_CONDITION_IP_REMOTE_ADDRESS
            numFilterConditions = 0,
            filterCondition = null
        };

        var status = FwpmFilterAdd0(_engineHandle, &filter, null, null);
        if (status != 0)
        {
            throw new InvalidOperationException($"FwpmFilterAdd0 failed: {status}");
        }
    }

    private unsafe void SubscribeToNetEvents()
    {
        _instanceHandle = GCHandle.Alloc(this);

        var template = new FWPM_NET_EVENT_ENUM_TEMPLATE0_
        {
            // Нам нужны только события классификации WFP
            // Обратите внимание на точные константы в ваших P/Invoke
            // enumType = FWPM_NET_EVENT_TYPE_CLASSIFY_ALLOW 
        };

        fixed (void** pSubscription = &_subscriptionHandle)
        {
            var status = FwpmNetEventSubscribe0(
                _engineHandle,
                &template,
                &NetEventCallback,
                (void*)GCHandle.ToIntPtr(_instanceHandle),
                pSubscription);

            if (status != 0)
            {
                _instanceHandle.Free();
                throw new InvalidOperationException($"FwpmNetEventSubscribe0 failed: {status}");
            }
        }
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
    private static unsafe void NetEventCallback(void* context, FWPM_NET_EVENT0_* eventPtr)
    {
        if (context == null || eventPtr == null)
        {
            return;
        }

        try
        {
            // Нас интересуют только события исходящих подключений
            if (eventPtr->type == FWPM_NET_EVENT_TYPE_.FWPM_NET_EVENT_TYPE_CLASSIFY_ALLOW)
            {
                // WFP возвращает IP-адреса в Host Byte Order (uint)
                uint remoteIp = eventPtr->classifyAllow->remoteAddrV4;

                var handle = GCHandle.FromIntPtr((IntPtr)context);
                if (handle.Target is WfpConnectionMonitor monitor)
                {
                    // Мгновенный сброс в канал (не блокируем WFP)
                    _ = monitor._eventChannel.Writer.TryWrite(remoteIp);
                }
            }
        }
        catch
        {
            // Fail-safe для UnmanagedCallersOnly
        }
    }

    private async Task ProcessEventsAsync(CancellationToken ct)
    {
        try
        {
            while (await _eventChannel.Reader.WaitToReadAsync(ct).ConfigureAwait(false))
            {
                while (_eventChannel.Reader.TryRead(out var remoteIp))
                {
                    // Передача IP-адреса в логику ASN Lookup
                    OnConnectionAttempt?.Invoke(remoteIp);
                }
            }
        }
        catch (OperationCanceledException) { }
    }

    public void Dispose()
    {
        lock (_syncLock)
        {
            if (_engineHandle == IntPtr.Zero)
            {
                return;
            }

            _cts.Cancel();

            unsafe
            {
                if (_subscriptionHandle != IntPtr.Zero)
                {
                    // Отписка синхронна, новые колбэки не придут
                    FwpmNetEventUnsubscribe0(_engineHandle, _subscriptionHandle);
                    _subscriptionHandle = IntPtr.Zero;
                }

                FwpmEngineClose0(_engineHandle);
                _engineHandle = IntPtr.Zero;
            }

            if (_instanceHandle.IsAllocated)
            {
                _instanceHandle.Free();
            }

            _cts.Dispose();
            GC.SuppressFinalize(this);
        }
    }

    ~WfpConnectionMonitor() => Dispose();
}
