// <copyright file="RouteWatcher.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using Managed.Wfp;
using Managed.Win32.IpHlpApi.Native;
using static Managed.Win32.IpHlpApi.Native.Methods;

namespace Xobex.Net.Routing;

public abstract class RouteWatcher : IDisposable
{
    private IntPtr _notifyHandle;
    private GCHandle _instanceHandle;
    private readonly Channel<RouteUpdate> _eventChannel;
    private readonly CancellationTokenSource _cts;

    protected RouteWatcher()
    {
        _eventChannel = Channel.CreateUnbounded<RouteUpdate>(new UnboundedChannelOptions
        {
            SingleReader = true,
            AllowSynchronousContinuations = false
        });
        _cts = new CancellationTokenSource();

        _ = Task.Run(() => ProcessEventsAsync(_cts.Token));
    }

    public unsafe void Start(AddressFamily addressFamily = AddressFamily.Unspecified, bool initialNotification = false)
    {
        if (_notifyHandle != IntPtr.Zero)
        {
            return;
        }

        _instanceHandle = GCHandle.Alloc(this);
        void* handle;

        var status = NotifyRouteChange2(
            (ushort)addressFamily,
            &NativeCallback,
            (void*)GCHandle.ToIntPtr(_instanceHandle),
            initialNotification ? (byte)1 : (byte)0,
            &handle);

        if (status != 0)
        {
            if (_instanceHandle.IsAllocated)
            {
                _instanceHandle.Free();
            }

            throw new InvalidOperationException($"Failed to start route watcher. Error code: {status}");
        }

        _notifyHandle = (IntPtr)handle;
    }

    [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
    private static unsafe void NativeCallback(void* callerContext, _MIB_IPFORWARD_ROW2* row, _MIB_NOTIFICATION_TYPE type)
    {
        if (callerContext == null)
        {
            return;
        }

        try
        {
            var handle = GCHandle.FromIntPtr((IntPtr)callerContext);
            if (handle.Target is RouteWatcher watcher)
            {
                RoutingTableEntry? entry = row != null ? new RoutingTableEntry(ref *row) : null;
                // Используем TryWrite, так как канал Unbounded и всегда готов к приему
                _ = watcher._eventChannel.Writer.TryWrite(new RouteUpdate(entry, (NotificationType)type));
            }
        }
        catch
        {
            // В UnmanagedCallersOnly нельзя допускать проброса исключений.
            // Здесь можно только записать в системный журнал или проигнорировать.
        }
    }

    private async Task ProcessEventsAsync(CancellationToken ct)
    {
        try
        {
            while (await _eventChannel.Reader.WaitToReadAsync(ct).ConfigureAwait(false))
            {
                while (_eventChannel.Reader.TryRead(out var update))
                {
                    try
                    {
                        OnRouteChange(update.Entry, update.Type);
                    }
                    catch (Exception ex)
                    {
                        // Защищаем цикл обработки от ошибок в пользовательском коде
                        ReportError(ex);
                    }
                }
            }
        }
        catch (OperationCanceledException) { }
    }

    protected abstract void OnRouteChange(RoutingTableEntry? row, NotificationType type);

    // Опционально: метод для логирования ошибок из OnRouteChange
    protected virtual void ReportError(Exception ex)
    {
        Console.Error.WriteLine(ex);
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        _cts.Cancel();

        unsafe
        {
            if (_notifyHandle != IntPtr.Zero)
            {
                // Вызов синхронный, после него новые колбэки не начнутся
                _ = CancelMibChangeNotify2(_notifyHandle.ToPointer());
                _notifyHandle = IntPtr.Zero;
            }
        }

        if (_instanceHandle.IsAllocated)
        {
            _instanceHandle.Free();
        }

        _cts.Dispose();
    }

    ~RouteWatcher() => Dispose();

    private record struct RouteUpdate(RoutingTableEntry? Entry, NotificationType Type);
}
