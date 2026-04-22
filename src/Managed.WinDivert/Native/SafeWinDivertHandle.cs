// <copyright file="SafeWinDivertHandle.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;
using static Managed.Win32.Native.Methods;
using static Managed.WinDivert.Native.Methods;

namespace Managed.WinDivert.Native;

internal sealed unsafe class SafeWinDivertHandle : SafeHandleMinusOneIsInvalid
{
    public SafeWinDivertHandle() : base(true)
    {
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static SafeWinDivertHandle Open(ReadOnlySpan<byte> compiledFilter, Layer layer, short priority, SessionFlags flags)
    {
        var handle = new SafeWinDivertHandle();
        fixed (byte* ptr = compiledFilter)
        {
            var session = WinDivertOpen((sbyte*)ptr, (WINDIVERT_LAYER)layer, priority, (ulong)flags);
            handle.SetHandle((nint)session);
            ThrowIfWin32Error(handle.IsInvalid);
        }
        return handle;
    }

    protected override bool ReleaseHandle()
    {
        return WinDivertClose(this);
    }
}
