// <copyright file="InterfaceTable.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using Managed.Win32.IpHlpApi.Native;
using static Managed.Win32.IpHlpApi.Native.Methods;

namespace Xobex.Net.Routing;

public unsafe class InterfaceTable : IDisposable
{
    public _MIB_IF_TABLE2* _table;

    private InterfaceTable(_MIB_IF_TABLE2* table)
    {
        ArgumentNullException.ThrowIfNull(table);
        _table = table;
    }

    public int Count => (int)_table->NumEntries;

    private ref _MIB_IF_ROW2 GetRow(uint index)
    {
        if (index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), $"Index {index} is out of range. The routing table contains {Count} entries.");
        }
        return ref _table->Table[(int)index];
    }

    public static InterfaceTable GetInterfaceTable()
    {
        _MIB_IF_TABLE2* table;
        var status = GetIfTable2Ex(_MIB_IF_TABLE_LEVEL.MibIfTableNormal, &table);
        if (status != 0)
        {
            throw new InvalidOperationException($"GetIfTable2Ex failed with error code {status}");
        }
        return new InterfaceTable(table);
    }

    public IEnumerable<InterfaceEntry> GetEntires()
    {
        for (uint i = 0; i < Count; i++)
        {
            ref var row = ref GetRow(i);
            yield return new(ref row);
        }
    }

    public void Dispose()
    {
        if(_table != null)
        {
            FreeMibTable(_table);
            _table = null;
        }
    }
}
