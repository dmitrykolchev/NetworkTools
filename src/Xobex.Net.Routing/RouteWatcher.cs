// <copyright file="WatchHandle.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Net.Sockets;
using System.Runtime.InteropServices;
using Managed.Wfp;
using Managed.Win32.IpHlpApi.Native;
using static Managed.Win32.IpHlpApi.Native.Methods;

namespace Xobex.Net.Routing;

public abstract unsafe class RouteWatcher : IDisposable
{
    private delegate void RouteChangeCallback(void* callerContext, _MIB_IPFORWARD_ROW2* row, _MIB_NOTIFICATION_TYPE type);
    private void* _handle;
    private readonly RouteChangeCallback _callback;

    public RouteWatcher()
    {
        _callback = InvokeRouteChange;
        GC.KeepAlive(_callback);
    }

    ~RouteWatcher()
    {
        Dispose();
    }

    public void Start(AddressFamily addressFamily = AddressFamily.Unspecified, bool initialNotification = false)
    {
        var rawPtr = Marshal.GetFunctionPointerForDelegate<RouteChangeCallback>(_callback);
        var unmanagedCallback = (delegate* unmanaged[Stdcall]<void*, _MIB_IPFORWARD_ROW2*, _MIB_NOTIFICATION_TYPE, void>)rawPtr;
        void* handle;
        var status = NotifyRouteChange2((ushort)addressFamily, unmanagedCallback, null, initialNotification ? (byte)1 : (byte)0, &handle);
        if (status != 0)
        {
            throw new InvalidOperationException($"Failed to start route watcher. Error code: {status}");
        }
        _handle = handle;
    }

    public void Stop()
    {
        Dispose();
    }

    protected abstract void OnRouteChange(RoutingTableEntry? row, NotificationType type);

    private void InvokeRouteChange(void* callerContext, _MIB_IPFORWARD_ROW2* row, _MIB_NOTIFICATION_TYPE type)
    {
        try
        {
            if (row == null)
            {
                OnRouteChange(null, (NotificationType)type);
            }
            else
            {
                var entry = new RoutingTableEntry(ref *row);
                OnRouteChange(entry, (NotificationType)type);
            }
        }
        catch (Exception ex)
        {
            // Логирование или обработка исключения
            Console.Error.WriteLine($"Error in route change callback: {ex}");
        }
    }

    public void Dispose()
    {
        if (_handle != null)
        {
            CancelMibChangeNotify2(_handle);
            _handle = null;
        }
        GC.SuppressFinalize(this);
    }
}
