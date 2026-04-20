// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Text;
using Managed.Wfp;
using Xobex.Net.Routing;

namespace Route;

internal class Program
{
    private static void Main()
    {
        var iTable = InterfaceTable.GetInterfaceTable();

        var table = RoutingTable.GetRoutingTable();
        var interfaceIndex = int.MinValue;
        List<InterfaceEntry> interfaces = [];
        var buffer = new StringBuilder();

        foreach (var entry in table.OrderBy(t => t.Type).ThenBy(t => t.InterfaceIndex).ThenBy(t => t.Metric))
        {
            if (interfaceIndex != entry.InterfaceIndex)
            {
                interfaceIndex = entry.InterfaceIndex;
                var interfaceEntry = iTable.FromInderfaceIndex(interfaceIndex);
                if (interfaces.Any(t => t.Index == interfaceIndex))
                {
                    continue;
                }
                interfaces.Add(interfaceEntry!);
                buffer.AppendLine("+" + new string('-', 100) + "+");
                buffer.AppendLine($"{interfaceIndex}: {interfaceEntry!.Description} / {interfaceEntry!.Alias}");
                buffer.AppendLine("+" + new string('-', 100) + "+");
                buffer.AppendLine($"| {"Type",-4} | {"Prefix",-40} | {"NextHop",-36} | {"If",3} | {"Mtr",3} |");
                buffer.AppendLine("+" + new string('-', 100) + "+");
            }
            buffer.AppendLine($"| {entry.Type} | {entry.Prefix,-40} | {entry.NextHop,-36} | {entry.InterfaceIndex,3} | {entry.Metric,3} |");
        }
        buffer.AppendLine("+" + new string('-', 100) + "+");
        Console.WriteLine("+" + new string('-', 100) + "+");
        foreach (var interfaceEntry in interfaces)
        {
            var name = $"{interfaceEntry.Description} / {interfaceEntry.Alias}";
            Console.WriteLine($"| {interfaceEntry.Index,3} | {interfaceEntry.PhysicalAddressString,-17} | {name,-72} |");
        }
        Console.WriteLine(buffer);

        using var watcher = new MyWatcher();
        watcher.Start();
        Console.WriteLine("Press Enter to stop watching for route changes...");
        Console.ReadLine();
    }
}

public class MyWatcher : RouteWatcher
{
    protected override void OnRouteChange(RoutingTableEntry? row, NotificationType type)
    {
        Console.WriteLine($"{type, -10} | {row}");
    }
}
