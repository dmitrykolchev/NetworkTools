// <copyright file="Utils.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Managed.WinDivert.Native;
using static Managed.Win32.Native.Methods;
using static Managed.WinDivert.Native.Methods;

namespace Managed.WinDivert;

public static unsafe class Utils
{
    public static bool CalcCheckSums(ReadOnlySpan<byte> buffer, ref Address address)
    {
        fixed (void* ptr = buffer)
        fixed (Address* pAddress = &address)
        {
            return WinDivertHelperCalcChecksums(ptr, unchecked((uint)buffer.Length), pAddress, 0) != FALSE;
        }
    }

    public static bool CalcCheckSums(ReadOnlySpan<byte> buffer)
    {
        fixed (void* ptr = buffer)
        {
            return WinDivertHelperCalcChecksums(ptr, unchecked((uint)buffer.Length), null, 0) != FALSE;
        }
    }

    public static void CompileFilter(string filter, Layer layer, Span<byte> compiledObject)
    {
        Span<byte> filterBytes = stackalloc byte[filter.Length + 1];
        Encoding.ASCII.GetBytes(filter, filterBytes);
        fixed (byte* pFilterBytes = filterBytes)
        fixed (byte* pCompiledObject = compiledObject)
        {
            sbyte* errorPtr;
            uint errorPos;
            if (WinDivertHelperCompileFilter(
                (sbyte*)pFilterBytes,
                (WINDIVERT_LAYER)layer,
                (sbyte*)pCompiledObject,
                unchecked((uint)compiledObject.Length),
                &errorPtr,
                &errorPos) == FALSE)
            {
                var error = Marshal.PtrToStringAnsi((nint)errorPtr);
                throw new InvalidOperationException($"{error} (error at position: {errorPos})");
            }
        }
    }

    public static bool ParsePacket(ReadOnlySpan<byte> packet, out ReadOnlySpan<IpV4Header> ipV4Header, out ReadOnlySpan<IpV6Header> ipV6Header)
    {
        IpV4Header* ipv4HeaderPtr;
        IpV6Header* ipv6HeaderPtr;
        byte protocol;
        IcmpV4Header* icmpv4HeaderPtr;
        IcmpV6Header* icmpv6HeaderPtr;
        TcpHeader* tcpHeaderPtr;
        UdpHeader* udpHeaderPtr;
        void* pData;
        uint dataLength;
        void* pNext;
        uint nextLength;
        
        fixed (void* pPacket = packet)
        {
            var result = WinDivertHelperParsePacket(
                pPacket, unchecked((uint)packet.Length),
                &ipv4HeaderPtr, &ipv6HeaderPtr,
                &protocol,
                &icmpv4HeaderPtr, &icmpv6HeaderPtr,
                &tcpHeaderPtr, &udpHeaderPtr,
                &pData, &dataLength,
                &pNext, &nextLength);
            if (result == FALSE)
            {
                ipV4Header = default;
                ipV6Header = default;
                return false;
            }
            ipV4Header = Get<IpV4Header>(packet, ipv4HeaderPtr, pPacket);
            ipV6Header = Get<IpV6Header>(packet, ipv6HeaderPtr, pPacket);
        }
        return true;
    }

    private static ReadOnlySpan<T> Get<T>(ReadOnlySpan<byte> packet, void* position, void* start) where T: unmanaged
    {
        if (position != null)
        {
            var offset = unchecked((int)((nint)position - (nint)start));
            return MemoryMarshal.Cast<byte, T>(packet.Slice(offset, sizeof(T)));
        }
        return default;
    }
}
