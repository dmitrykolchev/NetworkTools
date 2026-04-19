// <copyright file="InterfaceEntry.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Diagnostics;
using System.Globalization;
using Managed.Wfp;
using Managed.Win32.IpHlpApi.Native;
using static Managed.Win32.IpHlpApi.Native.Methods;

namespace Xobex.Net.Routing;

[Flags]
public enum InterfaceFlags : byte
{
    None = 0,
    HardwareInterface = 1 << 0,
    FilterInterface = 1 << 1,
    ConnectorPresent = 1 << 2,
    NotAuthenticated = 1 << 3,
    NotMediaConnected = 1 << 4,
    Paused = 1 << 5,
    LowPower = 1 << 6,
    EndPointInterface = 1 << 7,
}

[DebuggerDisplay("{Index}: {Alias}")]
public class InterfaceEntry
{
    private _MIB_IF_ROW2 _row;

    internal InterfaceEntry(ref _MIB_IF_ROW2 row)
    {
        _row = row;
    }
    public InterfaceFlags Flags => (InterfaceFlags)_row.InterfaceAndOperStatusFlags._bitfield;
    public int Index => (int)_row.InterfaceIndex;
    public Guid Guid => _row.InterfaceGuid;
    public Guid NetworkGuid => _row.NetworkGuid;
    public ulong TransmitLinkSpeed => _row.TransmitLinkSpeed;
    public ulong InOctets => _row.InOctets;
    public ulong InUcastPkts => _row.InUcastPkts;
    public ulong InNUcastPkts => _row.InNUcastPkts;
    public ulong InDiscards => _row.InDiscards;
    public ulong InErrors => _row.InErrors;
    public ulong InUnknownProtos => _row.InUnknownProtos;
    public ulong InUcastOctets => _row.InUcastOctets;
    public ulong InMulticastOctets => _row.InMulticastOctets;
    public ulong InBroadcastOctets => _row.InBroadcastOctets;
    public ulong OutOctets => _row.OutOctets;
    public ulong OutUcastPkts => _row.OutUcastPkts;
    public ulong OutNUcastPkts => _row.OutNUcastPkts;
    public ulong OutDiscards => _row.OutDiscards;
    public ulong OutErrors => _row.OutErrors;
    public ulong OutUcastOctets => _row.OutUcastOctets;
    public ulong OutMulticastOctets => _row.OutMulticastOctets;
    public ulong OutBroadcastOctets => _row.OutBroadcastOctets;
    public ulong OutQLen => _row.OutQLen;

    public byte[] PhysicalAddress
    {
        get
        {
            ReadOnlySpan<byte> buffer = _row.PhysicalAddress;
            return buffer[..(int)_row.PhysicalAddressLength].ToArray();
        }
    }

    public string PhysicalAddressString
    {
        get
        {
            ReadOnlySpan<byte> buffer = _row.PhysicalAddress;
            return string.Join(":", buffer[..(int)_row.PhysicalAddressLength].ToArray().Select(b => b.ToString("X2", CultureInfo.InvariantCulture)));
        }
    }

    public string Alias
    {
        get
        {
            ReadOnlySpan<char> buffer = _row.Alias;
            return buffer[..buffer.IndexOf('\0')].ToString();
        }
    }

    public string Description
    {
        get
        {
            ReadOnlySpan<char> buffer = _row.Description;
            return buffer[..buffer.IndexOf('\0')].ToString();
        }
    }

    public AccessType AccessType => (AccessType)_row.AccessType;

    public InterfaceType InterfaceType => (InterfaceType)_row.Type;

    public TunnelType TunnelType => (TunnelType)_row.TunnelType;

    public AdministrativeStatus AdministrativeStatus => (AdministrativeStatus)_row.AdminStatus;

    public OperationalStatus OperationalStatus => (OperationalStatus)_row.OperStatus;

    public MediaConnectState MediaConnectState => (MediaConnectState)_row.MediaConnectState;

    public ConnectionType ConnectionType => (ConnectionType)_row.ConnectionType;

    public int Mtu => (int)_row.Mtu;

    internal static unsafe InterfaceEntry Get(int interfaceIndex)
    {
        _MIB_IF_ROW2 row;
        row.InterfaceIndex = (uint)interfaceIndex;
        var status = GetIfEntry2(&row);
        if (status != 0)
        {
            throw new InvalidOperationException($"Failed to get IP interface entry for interface index {interfaceIndex} (status:{status}).");
        }
        return new InterfaceEntry(ref row);
    }
}
