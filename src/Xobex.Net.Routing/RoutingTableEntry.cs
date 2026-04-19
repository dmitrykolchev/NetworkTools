using Managed.Win32.IpHlpApi.Native;
using System.Net;
using System.Net.Sockets;

namespace Xobex.Net.Routing;

public class RoutingTableEntry
{
    private readonly IPPrefix _prefix;
    private readonly IPAddress _nextHop;
    private readonly int _interfaceIndex;
    private readonly int _metric;

    internal unsafe RoutingTableEntry(ref _MIB_IPFORWARD_ROW2 row)
    {
        if (row.DestinationPrefix.Prefix.si_family == (ushort)AddressFamily.InterNetwork)
        {
            fixed (void* ptr = &row.DestinationPrefix.Prefix.Ipv4.sin_addr)
            {
                _prefix = new IPPrefix(new(new Span<byte>(ptr, sizeof(in_addr))), row.DestinationPrefix.PrefixLength);
            }
        }
        else if (row.DestinationPrefix.Prefix.si_family == (ushort)AddressFamily.InterNetworkV6)
        {
            fixed (void* ptr = &row.DestinationPrefix.Prefix.Ipv6.sin6_addr)
            {
                _prefix = new IPPrefix(new(new Span<byte>(ptr, sizeof(in6_addr))), row.DestinationPrefix.PrefixLength);
            }
        }
        else
        {
            throw new InvalidOperationException("unsupported address type");
        }

        // Вывод шлюза (Next Hop)
        if (row.NextHop.si_family == (ushort)AddressFamily.InterNetwork)
        {
            fixed (void* ptr = &row.NextHop.Ipv4.sin_addr)
            {
                _nextHop = new(new Span<byte>(ptr, sizeof(in_addr)));
            }
        }
        else if (row.NextHop.si_family == (ushort)AddressFamily.InterNetworkV6)
        {
            fixed (void* ptr = &row.NextHop.Ipv6.sin6_addr)
            {
                _nextHop = new(new Span<byte>(ptr, sizeof(in6_addr)));
            }
        }
        else
        {
            throw new InvalidOperationException("unsupported address type");
        }
        _interfaceIndex = (int)row.InterfaceIndex;
        _metric = (int)row.Metric;
    }

    public InterfaceEntry GetInterface()
    {
        return InterfaceEntry.Get(InterfaceIndex);
    }

    public AddressFamily AddressFamily => _prefix.Address.AddressFamily;

    public bool IPv4 => AddressFamily == AddressFamily.InterNetwork;

    public bool IPv6 => AddressFamily == AddressFamily.InterNetworkV6;

    public IPPrefix Prefix => _prefix;

    public IPAddress NextHop => _nextHop;

    public int InterfaceIndex => _interfaceIndex;

    public int Metric => _metric;

    public string Type => IPv4 ? "IPv4" : "IPv6";

    public override string ToString()
    {
        return $"| {Type} | {Prefix,-40} | {NextHop,-36} | {InterfaceIndex,-3} | {Metric,-3} |";
    }
}
