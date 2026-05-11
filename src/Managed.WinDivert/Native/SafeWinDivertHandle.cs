// <copyright file="SafeWinDivertHandle.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Microsoft.Win32.SafeHandles;
using static Managed.Win32.Native.Methods;
using static Managed.WinDivert.Native.Methods;

namespace Managed.WinDivert.Native;

internal sealed unsafe class SafeWinDivertHandle : SafeHandleMinusOneIsInvalid
{
    private const nint InvalidHandleValue = -1;

    public SafeWinDivertHandle() : base(true)
    {
    }

    public static bool TryOpen(ReadOnlySpan<byte> compiledFilter, Layer layer, short priority, SessionFlags flags, out SafeWinDivertHandle handle)
    {
        handle = new SafeWinDivertHandle();
        fixed (byte* ptr = compiledFilter)
        {
            // Здесь теоретически может возникать утечка, если WinDivertOpen() будет вызван
            // и после этого произойдет исключение, непонятно как его отловить, так как мы не
            // можем использовать try/catch внутри unsafe кода.
            var session = WinDivertOpen((sbyte*)ptr, (WINDIVERT_LAYER)layer, priority, (ulong)flags);
            if ((nint)session == InvalidHandleValue)
            {
                // SetHandleAsInvalid() must suppress handle finalizer
                handle.SetHandleAsInvalid();
                return false;
            }
            handle.SetHandle((nint)session);
            return true;
        }
    }

    protected override bool ReleaseHandle()
    {
        if (handle == InvalidHandleValue || handle == IntPtr.Zero)
        {
            return true;
        }
        return WinDivertClose((void*)handle) != FALSE;
    }
}
