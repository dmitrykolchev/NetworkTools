// <copyright file="RoutingTable.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Collections;
using System.Net.Sockets;
using Managed.Win32.IpHlpApi.Native;
using static Managed.Win32.IpHlpApi.Native.Methods;

namespace Xobex.Net.Routing;

public sealed class RoutingTable : IEnumerable<RoutingTableEntry>
{
    private readonly RoutingTableEntry[] _table;

    private RoutingTable(RoutingTableEntry[] table)
    {
        ArgumentNullException.ThrowIfNull(table);
        _table = table;
    }

    public int Count => _table.Length;

    public ref readonly RoutingTableEntry this[int index] => ref _table[index];

    public static unsafe RoutingTable GetRoutingTable()
    {
        _MIB_IPFORWARD_TABLE2* table = null;
        var status = GetIpForwardTable2((ushort)AddressFamily.Unspecified, &table);
        if (status != 0)
        {
            throw new InvalidOperationException($"GetIpForwardTable2 failed with error code {status}");
        }
        try
        {
            if (table is null || table->NumEntries == 0)
            {
                return new RoutingTable(Array.Empty<RoutingTableEntry>());
            }
            // Выполняем копирование в управляемый массив сразу
            var entries = new RoutingTableEntry[table->NumEntries];
            for (var i = 0; i < (int)table->NumEntries; i++)
            {
                entries[i] = new RoutingTableEntry(ref table->Table[i]);
            }
            return new RoutingTable(entries);
        }
        finally
        {
            if (table != null)
            {
                FreeMibTable(table);
            }
        }
    }

    public ReadOnlySpan<RoutingTableEntry> AsSpan()
    {
        return _table.AsSpan();
    }

    public IEnumerator<RoutingTableEntry> GetEnumerator()
    {
        return ((IEnumerable<RoutingTableEntry>)_table).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _table.GetEnumerator();
    }
}
