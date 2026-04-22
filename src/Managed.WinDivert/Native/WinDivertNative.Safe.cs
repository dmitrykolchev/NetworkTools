// <copyright file="WinDivertNative.Safe.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.WinDivert.Native;

public static unsafe partial class Methods
{
    [LibraryImport("windivert", SetLastError = true)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    [return: NativeTypeName("BOOL")]
    internal static partial bool WinDivertRecv([NativeTypeName("HANDLE")] SafeWinDivertHandle handle, void* pPacket, uint packetLen, uint* pRecvLen, [NativeTypeName("WINDIVERT_ADDRESS *")] Address* pAddr);

    [LibraryImport("windivert", SetLastError = true)]
    [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
    [return: MarshalAs(UnmanagedType.Bool)]
    [return: NativeTypeName("BOOL")]
    internal static partial bool WinDivertRecvEx([NativeTypeName("HANDLE")] SafeWinDivertHandle handle, void* pPacket, uint packetLen, uint* pRecvLen, [NativeTypeName("UINT64")] ulong flags, [NativeTypeName("WINDIVERT_ADDRESS *")] Address* pAddr, uint* pAddrLen, [NativeTypeName("LPOVERLAPPED")] _OVERLAPPED* lpOverlapped);

    [LibraryImport("windivert", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    [return: NativeTypeName("BOOL")]
    internal static partial bool WinDivertSend([NativeTypeName("HANDLE")] SafeWinDivertHandle handle, [NativeTypeName("const void *")] void* pPacket, uint packetLen, uint* pSendLen, [NativeTypeName("const WINDIVERT_ADDRESS *")] Address* pAddr);

    [LibraryImport("windivert", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    [return: NativeTypeName("BOOL")]
    internal static partial bool WinDivertSendEx([NativeTypeName("HANDLE")] SafeWinDivertHandle handle, [NativeTypeName("const void *")] void* pPacket, uint packetLen, uint* pSendLen, [NativeTypeName("UINT64")] ulong flags, [NativeTypeName("const WINDIVERT_ADDRESS *")] Address* pAddr, uint addrLen, [NativeTypeName("LPOVERLAPPED")] _OVERLAPPED* lpOverlapped);

    [LibraryImport("windivert", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    [return: NativeTypeName("BOOL")]
    internal static partial bool WinDivertShutdown([NativeTypeName("HANDLE")] SafeWinDivertHandle handle, WINDIVERT_SHUTDOWN how);

    [LibraryImport("windivert", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    [return: NativeTypeName("BOOL")]
    internal static partial bool WinDivertClose([NativeTypeName("HANDLE")] SafeWinDivertHandle handle);

    [LibraryImport("windivert", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    [return: NativeTypeName("BOOL")]
    internal static partial bool WinDivertSetParam([NativeTypeName("HANDLE")] SafeWinDivertHandle handle, WINDIVERT_PARAM param1, [NativeTypeName("UINT64")] ulong value);

    [LibraryImport("windivert", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    [return: NativeTypeName("BOOL")]
    internal static partial bool WinDivertGetParam([NativeTypeName("HANDLE")] SafeWinDivertHandle handle, WINDIVERT_PARAM param1, [NativeTypeName("UINT64 *")] ulong* pValue);

}
