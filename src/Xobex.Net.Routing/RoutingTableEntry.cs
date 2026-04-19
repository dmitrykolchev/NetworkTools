// <copyright file="RoutingTableEntry.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Net;
using System.Net.Sockets;
using Managed.Win32.IpHlpApi.Native;

namespace Xobex.Net.Routing;

public readonly record struct RoutingTableEntry
{
    internal unsafe RoutingTableEntry(ref _MIB_IPFORWARD_ROW2 row)
    {
        if (row.DestinationPrefix.Prefix.si_family == (ushort)AddressFamily.InterNetwork)
        {
            fixed (void* ptr = &row.DestinationPrefix.Prefix.Ipv4.sin_addr)
            {
                Prefix = new IPPrefix(new(new Span<byte>(ptr, sizeof(in_addr))), row.DestinationPrefix.PrefixLength);
            }
            fixed (void* ptr = &row.NextHop.Ipv4.sin_addr)
            {
                NextHop = new(new Span<byte>(ptr, sizeof(in_addr)));
            }
        }
        else if (row.DestinationPrefix.Prefix.si_family == (ushort)AddressFamily.InterNetworkV6)
        {
            fixed (void* ptr = &row.DestinationPrefix.Prefix.Ipv6.sin6_addr)
            {
                Prefix = new IPPrefix(new(new Span<byte>(ptr, sizeof(in6_addr))), row.DestinationPrefix.PrefixLength);
            }
            fixed (void* ptr = &row.NextHop.Ipv6.sin6_addr)
            {
                NextHop = new(new Span<byte>(ptr, sizeof(in6_addr)));
            }
        }
        else
        {
            throw new InvalidOperationException("unsupported address type");
        }
        InterfaceIndex = (int)row.InterfaceIndex;
        Metric = (int)row.Metric;
    }

    public IPPrefix Prefix { get; }
    public IPAddress NextHop { get; }
    public int InterfaceIndex { get; }
    public int Metric { get; }

    public InterfaceEntry GetInterface()
    {
        return InterfaceEntry.Get(InterfaceIndex);
    }

    public AddressFamily AddressFamily => Prefix.Address.AddressFamily;

    public bool IsIPv4 => AddressFamily == AddressFamily.InterNetwork;

    public bool IsIPv6 => AddressFamily == AddressFamily.InterNetworkV6;

    public string Type => IsIPv4 ? "IPv4" : "IPv6";

    public override string ToString()
    {
        return $"| {Type} | {Prefix,-40} | {NextHop,-36} | {InterfaceIndex,-3} | {Metric,-3} |";
    }
}
