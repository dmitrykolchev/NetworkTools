// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Wfp;
using Xobex.Net.Routing;

namespace Route;

internal class Program
{
    private static void Main(string[] args)
    {
        using var iTable = InterfaceTable.GetInterfaceTable();
        var rows = iTable.GetEntires()
            .Where(t => ((t.Flags & InterfaceFlags.FilterInterface) == 0))
            .ToArray();

        foreach (var row in rows)
        {
            Console.WriteLine($"| {row.Index,-3} | {row.PhysicalAddressString,17} | {row.InterfaceType} | {row.MediaConnectState} | {row.ConnectionType} | {row.Alias}");
        }

        using var table = RoutingTable.GetRoutingTable();
        var interfaceIndex = int.MinValue;
        foreach (var entry in table.GetEntires().OrderBy(t => t.Type).ThenBy(t => t.InterfaceIndex).ThenBy(t => t.Metric))
        {
            if (interfaceIndex != entry.InterfaceIndex)
            {
                interfaceIndex = entry.InterfaceIndex;
                var interfaceEntry = entry.GetInterface();
                Console.WriteLine("+" + new string('-', 100) + "+");
                Console.WriteLine($"{interfaceIndex}: {interfaceEntry.Alias}");
                Console.WriteLine("+" + new string('-', 100) + "+");
                Console.WriteLine($"| {"Type",-4} | {"Prefix",-40} | {"NextHop",-36} | {"If",-3} | {"Mtr",-3} |");
                Console.WriteLine("+" + new string('-', 100) + "+");
            }
            Console.WriteLine($"| {entry.Type} | {entry.Prefix,-40} | {entry.NextHop,-36} | {entry.InterfaceIndex,-3} | {entry.Metric,-3} |");
        }
    }
}
