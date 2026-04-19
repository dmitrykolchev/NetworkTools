// <copyright file="InterfaceTable.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Collections;
using Managed.Win32.IpHlpApi.Native;
using static Managed.Win32.IpHlpApi.Native.Methods;

namespace Xobex.Net.Routing;

public class InterfaceTable : IEnumerable<InterfaceEntry>
{
    private InterfaceEntry[] _table;

    private InterfaceTable(InterfaceEntry[] table)
    {
        ArgumentNullException.ThrowIfNull(table);
        _table = table;
    }

    public int Count => _table.Length;

    public ref readonly InterfaceEntry this[int index] => ref _table[index];

    public static unsafe InterfaceTable GetInterfaceTable()
    {
        _MIB_IF_TABLE2* table = null;
        var status = GetIfTable2Ex(_MIB_IF_TABLE_LEVEL.MibIfTableNormal, &table);
        if (status != 0)
        {
            throw new InvalidOperationException($"GetIfTable2Ex failed with error code {status}");
        }
        try
        {
            if (table is null || table->NumEntries == 0)
            {
                return new InterfaceTable(Array.Empty<InterfaceEntry>());
            }
            // Выполняем копирование в управляемый массив сразу
            var entries = new InterfaceEntry[table->NumEntries];
            for (var i = 0; i < (int)table->NumEntries; i++)
            {
                entries[i] = new InterfaceEntry(ref table->Table[i]);
            }
            return new InterfaceTable(entries);
        }
        finally
        {
            if (table != null)
            {
                FreeMibTable(table);
            }
        }
    }

    public ReadOnlySpan<InterfaceEntry> AsSpan()
    {
        return _table.AsSpan();
    }

    public IEnumerator<InterfaceEntry> GetEnumerator()
    {
        return ((IEnumerable<InterfaceEntry>)_table).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return _table.GetEnumerator();
    }
}
