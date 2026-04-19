// <copyright file="RoutingTable.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Net.Sockets;
using Managed.Win32.IpHlpApi.Native;
using static Managed.Win32.IpHlpApi.Native.Methods;

namespace Xobex.Net.Routing;

public unsafe class RoutingTable : IDisposable
{
    private _MIB_IPFORWARD_TABLE2* _table;

    private RoutingTable(_MIB_IPFORWARD_TABLE2* table)
    {
        ArgumentNullException.ThrowIfNull(table);
        _table = table;
    }

    ~RoutingTable()
    {
        Dispose();
    }

    public void Dispose()
    {
        if (_table != null)
        {
            FreeMibTable(_table);
            _table = null;
        }
    }

    public int Count => (int)_table->NumEntries;

    public static RoutingTable GetRoutingTable()
    {
        _MIB_IPFORWARD_TABLE2* table;
        var status = GetIpForwardTable2((ushort)AddressFamily.Unspecified, &table);
        if (status != 0)
        {
            throw new InvalidOperationException($"GetIpForwardTable2 failed with error code {status}");
        }
        var routingTable = new RoutingTable(table);
        return routingTable;
    }

    private ref _MIB_IPFORWARD_ROW2 GetRow(uint index)
    {
        if (index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range. The routing table contains {Count} entries.");
        }
        return ref _table->Table[(int)index];
    }

    public IEnumerable<RoutingTableEntry> GetEntires()
    {
        for (uint i = 0; i < Count; i++)
        {
            ref var row = ref GetRow(i);
            yield return new(ref row);
        }
    }
}
