// <copyright file="SafeWinDivertHandle.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using Managed.WinDivert.Native;
using Microsoft.Win32.SafeHandles;
using static Managed.Win32.Native.Methods;
using static Managed.WinDivert.Native.Methods;

namespace Managed.WinDivert;

internal sealed unsafe class SafeWinDivertHandle : SafeHandleMinusOneIsInvalid
{
    internal SafeWinDivertHandle() : base(false)
    {
    }

    private SafeWinDivertHandle(nint preexistingHandle, bool ownsHandle) : base(ownsHandle)
    {
        SetHandle(preexistingHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static SafeWinDivertHandle Open(ReadOnlySpan<byte> filterBytes, Layer layer, short priority, SessionFlags flags)
    {
        fixed (byte* ptr = filterBytes)
        {
            var session = WinDivertOpen((sbyte*)ptr, (WINDIVERT_LAYER)layer, priority, (ulong)flags);
            var handle = new SafeWinDivertHandle((nint)session, true);
            ThrowIfWin32Error(handle.IsInvalid);
            return handle;
        }
    }

    public void ThrowIfInvalid()
    {
        if(IsInvalid)
        {
            throw new InvalidOperationException("Session handle is invalid.");
        }
    }

    protected override bool ReleaseHandle()
    {
        return WinDivertClose(handle.ToPointer()) != FALSE;
    }
}
