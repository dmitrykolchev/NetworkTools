using Managed.Win32.IpHlpApi.Native;
using System.Net;
using System.Net.Sockets;
using TerraFX.Interop.Windows;
using static Managed.Win32.IpHlpApi.Native.Methods;

namespace Xobex.Net.Routing;

public class RoutingTable
{

    public unsafe void GetEntires()
    {
        _MIB_IPFORWARD_TABLE2* Table;
        uint status = GetIpForwardTable2((ushort)AddressFamily.Unspecified, &Table);
        if (status != 0)
        {
            throw new Exception($"GetIpForwardTable2 failed with error code {status}");
        }
        for(uint i=0; i< Table->NumEntries; i++)
        {
            ref _MIB_IPFORWARD_ROW2 row = ref Table->Table[(int)i];

            // Определяем адрес назначения
            if (row.DestinationPrefix.Prefix.Ipv4.sin_family == (ushort)AddressFamily.InterNetwork)
            {
                fixed (void* ptr = &row.DestinationPrefix.Prefix.Ipv4.sin_addr)
                {
                    IPAddress addr = new IPAddress(new Span<byte>(ptr, 4));
                    string prefix = $"{addr}/{row.DestinationPrefix.PrefixLength}";
                    Console.Write($"IPv4: {prefix,-20}");
                }
            }
            else
            {
                fixed (void* ptr = &row.DestinationPrefix.Prefix.Ipv6.sin6_addr)
                {
                    IPAddress addr = new IPAddress(new Span<byte>(ptr, sizeof(in6_addr)));
                    string prefix = $"{addr}/{row.DestinationPrefix.PrefixLength}";
                    Console.Write($"IPv6: {prefix,-20}");
                }
            }

            // Вывод шлюза (Next Hop)
            if (row.NextHop.Ipv4.sin_family == AF_INET)
            {
                fixed (void* ptr = &row.NextHop.Ipv4.sin_addr)
                {
                    IPAddress addr = new IPAddress(new Span<byte>(ptr, 4));
                    Console.Write($" NextHop: {addr,-20}");
                }
            }
            else
            {
                fixed (void* ptr = &row.NextHop.Ipv6.sin6_addr)
                {
                    IPAddress addr = new IPAddress(new Span<byte>(ptr, sizeof(in6_addr)));
                    Console.Write($" NextHop: {addr,-20}");
                }
            }

            Console.WriteLine($" IF: {row.InterfaceIndex,-4} METRIC: {row.Metric,-4}");
        }
        FreeMibTable(Table);
    }
}
