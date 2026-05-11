// <copyright file="Session.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.ComponentModel;
using System.Text;
using Managed.WinDivert.Native;
using static Managed.Win32.Native.Methods;
using static Managed.WinDivert.Native.Methods;

namespace Managed.WinDivert;

public unsafe class Session : IDisposable
{
    public static readonly ulong ParamQueueLengthDefault = WINDIVERT_PARAM_QUEUE_LENGTH_DEFAULT;
    public static readonly ulong ParamQueueLengthMin = WINDIVERT_PARAM_QUEUE_LENGTH_MIN;
    public static readonly ulong ParamQueueLengthMax = WINDIVERT_PARAM_QUEUE_LENGTH_MAX;

    public static readonly ulong ParamQueueTimeDefault = WINDIVERT_PARAM_QUEUE_TIME_DEFAULT;
    public static readonly ulong ParamQueueTimeMin = WINDIVERT_PARAM_QUEUE_TIME_MIN;
    public static readonly ulong ParamQueueTimeMax = WINDIVERT_PARAM_QUEUE_TIME_MAX;

    public static readonly ulong ParamQueueSizeDefault = WINDIVERT_PARAM_QUEUE_SIZE_DEFAULT;
    public static readonly ulong ParamQueueSizeMin = WINDIVERT_PARAM_QUEUE_SIZE_MIN;
    public static readonly ulong ParamQueueSizeMax = WINDIVERT_PARAM_QUEUE_SIZE_MAX;

    private SafeWinDivertHandle _handle;

    public Session()
    {
        _handle = new SafeWinDivertHandle();
        _handle.SetHandleAsInvalid();
    }

    public void Open(Layer layer = Layer.Network, short priority = 0, SessionFlags flags = SessionFlags.None)
    {
#pragma warning disable IDE0302 // Simplify collection initialization
        ReadOnlySpan<byte> defaultFilter = stackalloc byte[] { (byte)'t', (byte)'r', (byte)'u', (byte)'e', (byte)'\0' };
#pragma warning restore IDE0302 // Simplify collection initialization
        Open(defaultFilter, layer, priority, flags);
    }

    public void Open(string filter, Layer layer = Layer.Network, short priority = 0, SessionFlags flags = SessionFlags.None)
    {
        Span<byte> compiledFilter = stackalloc byte[filter.Length + 1];
        Utils.CompileFilter(filter, layer, compiledFilter);
        Open(compiledFilter, layer, priority, flags);
    }

    public void Open(ReadOnlySpan<byte> compiledFilter, Layer layer = Layer.Network, short priority = 0, SessionFlags flags = SessionFlags.None)
    {
        if (!SafeWinDivertHandle.TryOpen(compiledFilter, layer, priority, flags, out _handle))
        {
            ThrowWin32Error();
        }
    }

    public void SetParameterValue(SessionParameter parameter, ulong value)
    {
        ThrowIfWin32Error(!WinDivertSetParam(_handle, (WINDIVERT_PARAM)parameter, value));
    }

    public ulong GetParameterValue(SessionParameter parameter)
    {
        ulong value;
        ThrowIfWin32Error(!WinDivertGetParam(_handle, (WINDIVERT_PARAM)parameter, &value));
        return value;
    }

    public void Shutdown(ShutdownFlags flags = ShutdownFlags.Both)
    {
        ThrowIfWin32Error(!WinDivertShutdown(_handle, (WINDIVERT_SHUTDOWN)flags));
    }

    public void Close()
    {
        _handle.Close();
    }

    public int Receive(Span<byte> packet, ref Address address)
    {
        fixed (void* ptr = packet)
        fixed (Address* pAddress = &address)
        {
            uint recvLength = 0;
            var result = WinDivertRecv(_handle, ptr, unchecked((uint)packet.Length), &recvLength, pAddress);
            ThrowIfWin32Error(!result);
            return unchecked((int)recvLength);
        }
    }

    public int Send(ReadOnlySpan<byte> packet, ref Address address)
    {
        fixed (void* ptr = packet)
        fixed (Address* pAddress = &address)
        {
            uint sentLength = 0;
            var result = WinDivertSend(_handle, ptr, unchecked((uint)packet.Length), &sentLength, pAddress);
            ThrowIfWin32Error(!result);
            return unchecked((int)sentLength);
        }
    }

    public void Dispose()
    {
        if (!_handle.IsClosed && !_handle.IsInvalid)
        {
            Shutdown();
            Close();
        }
    }
}
