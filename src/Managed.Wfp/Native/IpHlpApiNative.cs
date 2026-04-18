using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.IpHlpApi.Native
{
    public enum _IF_ACCESS_TYPE
    {
        IF_ACCESS_LOOPBACK = 1,
        IF_ACCESS_BROADCAST = 2,
        IF_ACCESS_POINT_TO_POINT = 3,
        IF_ACCESS_POINTTOPOINT = 3,
        IF_ACCESS_POINT_TO_MULTI_POINT = 4,
        IF_ACCESS_POINTTOMULTIPOINT = 4,
    }

    public enum _INTERNAL_IF_OPER_STATUS
    {
        IF_OPER_STATUS_NON_OPERATIONAL = 0,
        IF_OPER_STATUS_UNREACHABLE = 1,
        IF_OPER_STATUS_DISCONNECTED = 2,
        IF_OPER_STATUS_CONNECTING = 3,
        IF_OPER_STATUS_CONNECTED = 4,
        IF_OPER_STATUS_OPERATIONAL = 5,
    }

    public partial struct _MIB_OPAQUE_QUERY
    {
        [NativeTypeName("DWORD")]
        public uint dwVarId;

        [NativeTypeName("DWORD[1]")]
        public _rgdwVarIndex_e__FixedBuffer rgdwVarIndex;

        public partial struct _rgdwVarIndex_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public enum _NET_IF_OPER_STATUS
    {
        NET_IF_OPER_STATUS_UP = 1,
        NET_IF_OPER_STATUS_DOWN = 2,
        NET_IF_OPER_STATUS_TESTING = 3,
        NET_IF_OPER_STATUS_UNKNOWN = 4,
        NET_IF_OPER_STATUS_DORMANT = 5,
        NET_IF_OPER_STATUS_NOT_PRESENT = 6,
        NET_IF_OPER_STATUS_LOWER_LAYER_DOWN = 7,
    }

    public enum _NET_IF_ADMIN_STATUS
    {
        NET_IF_ADMIN_STATUS_UP = 1,
        NET_IF_ADMIN_STATUS_DOWN = 2,
        NET_IF_ADMIN_STATUS_TESTING = 3,
    }

    public enum _NET_IF_RCV_ADDRESS_TYPE
    {
        NET_IF_RCV_ADDRESS_TYPE_OTHER = 1,
        NET_IF_RCV_ADDRESS_TYPE_VOLATILE = 2,
        NET_IF_RCV_ADDRESS_TYPE_NON_VOLATILE = 3,
    }

    public partial struct _NET_IF_RCV_ADDRESS_LH
    {
        [NativeTypeName("NET_IF_RCV_ADDRESS_TYPE")]
        public _NET_IF_RCV_ADDRESS_TYPE ifRcvAddressType;

        public ushort ifRcvAddressLength;

        public ushort ifRcvAddressOffset;
    }

    public partial struct _NET_IF_ALIAS_LH
    {
        public ushort ifAliasLength;

        public ushort ifAliasOffset;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _NET_LUID_LH
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONG64")]
        public ulong Value;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_ifdef_L121_C5")]
        public _Info_e__Struct Info;

        public partial struct _Info_e__Struct
        {
            public ulong _bitfield;

            [NativeTypeName("ULONG64 : 24")]
            public ulong Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return _bitfield & 0xFFFFFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFFFFFUL) | (value & 0xFFFFFFUL);
                }
            }

            [NativeTypeName("ULONG64 : 24")]
            public ulong NetLuidIndex
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 24) & 0xFFFFFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFFFFFUL << 24)) | ((value & 0xFFFFFFUL) << 24);
                }
            }

            [NativeTypeName("ULONG64 : 16")]
            public ulong IfType
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 48) & 0xFFFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFFFUL << 48)) | ((value & 0xFFFFUL) << 48);
                }
            }
        }
    }

    public enum _NET_IF_CONNECTION_TYPE
    {
        NET_IF_CONNECTION_DEDICATED = 1,
        NET_IF_CONNECTION_PASSIVE = 2,
        NET_IF_CONNECTION_DEMAND = 3,
        NET_IF_CONNECTION_MAXIMUM = 4,
    }

    public enum TUNNEL_TYPE
    {
        TUNNEL_TYPE_NONE = 0,
        TUNNEL_TYPE_OTHER = 1,
        TUNNEL_TYPE_DIRECT = 2,
        TUNNEL_TYPE_6TO4 = 11,
        TUNNEL_TYPE_ISATAP = 13,
        TUNNEL_TYPE_TEREDO = 14,
        TUNNEL_TYPE_IPHTTPS = 15,
    }

    public enum _NET_IF_ACCESS_TYPE
    {
        NET_IF_ACCESS_LOOPBACK = 1,
        NET_IF_ACCESS_BROADCAST = 2,
        NET_IF_ACCESS_POINT_TO_POINT = 3,
        NET_IF_ACCESS_POINT_TO_MULTI_POINT = 4,
        NET_IF_ACCESS_MAXIMUM = 5,
    }

    public enum _NET_IF_DIRECTION_TYPE
    {
        NET_IF_DIRECTION_SENDRECEIVE,
        NET_IF_DIRECTION_SENDONLY,
        NET_IF_DIRECTION_RECEIVEONLY,
        NET_IF_DIRECTION_MAXIMUM,
    }

    public enum _NET_IF_MEDIA_CONNECT_STATE
    {
        MediaConnectStateUnknown,
        MediaConnectStateConnected,
        MediaConnectStateDisconnected,
    }

    public enum _NET_IF_MEDIA_DUPLEX_STATE
    {
        MediaDuplexStateUnknown,
        MediaDuplexStateHalf,
        MediaDuplexStateFull,
    }

    public partial struct _NET_PHYSICAL_LOCATION_LH
    {
        [NativeTypeName("ULONG")]
        public uint BusNumber;

        [NativeTypeName("ULONG")]
        public uint SlotNumber;

        [NativeTypeName("ULONG")]
        public uint FunctionNumber;
    }

    public partial struct _IF_COUNTED_STRING_LH
    {
        public ushort Length;

        [NativeTypeName("WCHAR[257]")]
        public _String_e__FixedBuffer String;

        [InlineArray(257)]
        public partial struct _String_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct _IF_PHYSICAL_ADDRESS_LH
    {
        public ushort Length;

        [NativeTypeName("UCHAR[32]")]
        public _Address_e__FixedBuffer Address;

        [InlineArray(32)]
        public partial struct _Address_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public enum _IF_ADMINISTRATIVE_STATE
    {
        IF_ADMINISTRATIVE_DISABLED,
        IF_ADMINISTRATIVE_ENABLED,
        IF_ADMINISTRATIVE_DEMANDDIAL,
    }

    public enum IF_OPER_STATUS
    {
        IfOperStatusUp = 1,
        IfOperStatusDown,
        IfOperStatusTesting,
        IfOperStatusUnknown,
        IfOperStatusDormant,
        IfOperStatusNotPresent,
        IfOperStatusLowerLayerDown,
    }

    public partial struct _NDIS_INTERFACE_INFORMATION
    {
        [NativeTypeName("NET_IF_OPER_STATUS")]
        public _NET_IF_OPER_STATUS ifOperStatus;

        [NativeTypeName("ULONG")]
        public uint ifOperStatusFlags;

        [NativeTypeName("NET_IF_MEDIA_CONNECT_STATE")]
        public _NET_IF_MEDIA_CONNECT_STATE MediaConnectState;

        [NativeTypeName("NET_IF_MEDIA_DUPLEX_STATE")]
        public _NET_IF_MEDIA_DUPLEX_STATE MediaDuplexState;

        [NativeTypeName("ULONG")]
        public uint ifMtu;

        [NativeTypeName("BOOLEAN")]
        public byte ifPromiscuousMode;

        [NativeTypeName("BOOLEAN")]
        public byte ifDeviceWakeUpEnable;

        [NativeTypeName("ULONG64")]
        public ulong XmitLinkSpeed;

        [NativeTypeName("ULONG64")]
        public ulong RcvLinkSpeed;

        [NativeTypeName("ULONG64")]
        public ulong ifLastChange;

        [NativeTypeName("ULONG64")]
        public ulong ifCounterDiscontinuityTime;

        [NativeTypeName("ULONG64")]
        public ulong ifInUnknownProtos;

        [NativeTypeName("ULONG64")]
        public ulong ifInDiscards;

        [NativeTypeName("ULONG64")]
        public ulong ifInErrors;

        [NativeTypeName("ULONG64")]
        public ulong ifHCInOctets;

        [NativeTypeName("ULONG64")]
        public ulong ifHCInUcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong ifHCInMulticastPkts;

        [NativeTypeName("ULONG64")]
        public ulong ifHCInBroadcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong ifHCOutOctets;

        [NativeTypeName("ULONG64")]
        public ulong ifHCOutUcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong ifHCOutMulticastPkts;

        [NativeTypeName("ULONG64")]
        public ulong ifHCOutBroadcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong ifOutErrors;

        [NativeTypeName("ULONG64")]
        public ulong ifOutDiscards;

        [NativeTypeName("ULONG64")]
        public ulong ifHCInUcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong ifHCInMulticastOctets;

        [NativeTypeName("ULONG64")]
        public ulong ifHCInBroadcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong ifHCOutUcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong ifHCOutMulticastOctets;

        [NativeTypeName("ULONG64")]
        public ulong ifHCOutBroadcastOctets;

        [NativeTypeName("NET_IF_COMPARTMENT_ID")]
        public uint CompartmentId;

        [NativeTypeName("ULONG")]
        public uint SupportedStatistics;
    }

    public partial struct _MIB_IFNUMBER
    {
        [NativeTypeName("DWORD")]
        public uint dwValue;
    }

    public partial struct _MIB_IFROW
    {
        [NativeTypeName("WCHAR[256]")]
        public _wszName_e__FixedBuffer wszName;

        [NativeTypeName("IF_INDEX")]
        public uint dwIndex;

        [NativeTypeName("IFTYPE")]
        public uint dwType;

        [NativeTypeName("DWORD")]
        public uint dwMtu;

        [NativeTypeName("DWORD")]
        public uint dwSpeed;

        [NativeTypeName("DWORD")]
        public uint dwPhysAddrLen;

        [NativeTypeName("UCHAR[8]")]
        public _bPhysAddr_e__FixedBuffer bPhysAddr;

        [NativeTypeName("DWORD")]
        public uint dwAdminStatus;

        [NativeTypeName("INTERNAL_IF_OPER_STATUS")]
        public _INTERNAL_IF_OPER_STATUS dwOperStatus;

        [NativeTypeName("DWORD")]
        public uint dwLastChange;

        [NativeTypeName("DWORD")]
        public uint dwInOctets;

        [NativeTypeName("DWORD")]
        public uint dwInUcastPkts;

        [NativeTypeName("DWORD")]
        public uint dwInNUcastPkts;

        [NativeTypeName("DWORD")]
        public uint dwInDiscards;

        [NativeTypeName("DWORD")]
        public uint dwInErrors;

        [NativeTypeName("DWORD")]
        public uint dwInUnknownProtos;

        [NativeTypeName("DWORD")]
        public uint dwOutOctets;

        [NativeTypeName("DWORD")]
        public uint dwOutUcastPkts;

        [NativeTypeName("DWORD")]
        public uint dwOutNUcastPkts;

        [NativeTypeName("DWORD")]
        public uint dwOutDiscards;

        [NativeTypeName("DWORD")]
        public uint dwOutErrors;

        [NativeTypeName("DWORD")]
        public uint dwOutQLen;

        [NativeTypeName("DWORD")]
        public uint dwDescrLen;

        [NativeTypeName("UCHAR[256]")]
        public _bDescr_e__FixedBuffer bDescr;

        [InlineArray(256)]
        public partial struct _wszName_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(8)]
        public partial struct _bPhysAddr_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(256)]
        public partial struct _bDescr_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _MIB_IFTABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IFROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IFROW e0;

            [UnscopedRef]
            public ref _MIB_IFROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IFROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public enum NL_PREFIX_ORIGIN
    {
        IpPrefixOriginOther = 0,
        IpPrefixOriginManual,
        IpPrefixOriginWellKnown,
        IpPrefixOriginDhcp,
        IpPrefixOriginRouterAdvertisement,
        IpPrefixOriginUnchanged = 1 << 4,
    }

    public enum NL_SUFFIX_ORIGIN
    {
        NlsoOther = 0,
        NlsoManual,
        NlsoWellKnown,
        NlsoDhcp,
        NlsoLinkLayerAddress,
        NlsoRandom,
        IpSuffixOriginOther = 0,
        IpSuffixOriginManual,
        IpSuffixOriginWellKnown,
        IpSuffixOriginDhcp,
        IpSuffixOriginLinkLayerAddress,
        IpSuffixOriginRandom,
        IpSuffixOriginUnchanged = 1 << 4,
    }

    public enum NL_DAD_STATE
    {
        NldsInvalid,
        NldsTentative,
        NldsDuplicate,
        NldsDeprecated,
        NldsPreferred,
        IpDadStateInvalid = 0,
        IpDadStateTentative,
        IpDadStateDuplicate,
        IpDadStateDeprecated,
        IpDadStatePreferred,
    }

    public enum NL_ROUTE_PROTOCOL
    {
        RouteProtocolOther = 1,
        RouteProtocolLocal = 2,
        RouteProtocolNetMgmt = 3,
        RouteProtocolIcmp = 4,
        RouteProtocolEgp = 5,
        RouteProtocolGgp = 6,
        RouteProtocolHello = 7,
        RouteProtocolRip = 8,
        RouteProtocolIsIs = 9,
        RouteProtocolEsIs = 10,
        RouteProtocolCisco = 11,
        RouteProtocolBbn = 12,
        RouteProtocolOspf = 13,
        RouteProtocolBgp = 14,
        RouteProtocolIdpr = 15,
        RouteProtocolEigrp = 16,
        RouteProtocolDvmrp = 17,
        RouteProtocolRpl = 18,
        RouteProtocolDhcp = 19,
        MIB_IPPROTO_OTHER = 1,
        PROTO_IP_OTHER = 1,
        MIB_IPPROTO_LOCAL = 2,
        PROTO_IP_LOCAL = 2,
        MIB_IPPROTO_NETMGMT = 3,
        PROTO_IP_NETMGMT = 3,
        MIB_IPPROTO_ICMP = 4,
        PROTO_IP_ICMP = 4,
        MIB_IPPROTO_EGP = 5,
        PROTO_IP_EGP = 5,
        MIB_IPPROTO_GGP = 6,
        PROTO_IP_GGP = 6,
        MIB_IPPROTO_HELLO = 7,
        PROTO_IP_HELLO = 7,
        MIB_IPPROTO_RIP = 8,
        PROTO_IP_RIP = 8,
        MIB_IPPROTO_IS_IS = 9,
        PROTO_IP_IS_IS = 9,
        MIB_IPPROTO_ES_IS = 10,
        PROTO_IP_ES_IS = 10,
        MIB_IPPROTO_CISCO = 11,
        PROTO_IP_CISCO = 11,
        MIB_IPPROTO_BBN = 12,
        PROTO_IP_BBN = 12,
        MIB_IPPROTO_OSPF = 13,
        PROTO_IP_OSPF = 13,
        MIB_IPPROTO_BGP = 14,
        PROTO_IP_BGP = 14,
        MIB_IPPROTO_IDPR = 15,
        PROTO_IP_IDPR = 15,
        MIB_IPPROTO_EIGRP = 16,
        PROTO_IP_EIGRP = 16,
        MIB_IPPROTO_DVMRP = 17,
        PROTO_IP_DVMRP = 17,
        MIB_IPPROTO_RPL = 18,
        PROTO_IP_RPL = 18,
        MIB_IPPROTO_DHCP = 19,
        PROTO_IP_DHCP = 19,
        MIB_IPPROTO_NT_AUTOSTATIC = 10002,
        PROTO_IP_NT_AUTOSTATIC = 10002,
        MIB_IPPROTO_NT_STATIC = 10006,
        PROTO_IP_NT_STATIC = 10006,
        MIB_IPPROTO_NT_STATIC_NON_DOD = 10007,
        PROTO_IP_NT_STATIC_NON_DOD = 10007,
    }

    public enum NL_ADDRESS_TYPE
    {
        NlatUnspecified,
        NlatUnicast,
        NlatAnycast,
        NlatMulticast,
        NlatBroadcast,
        NlatInvalid,
    }

    public enum _NL_ROUTE_ORIGIN
    {
        NlroManual,
        NlroWellKnown,
        NlroDHCP,
        NlroRouterAdvertisement,
        Nlro6to4,
    }

    public enum _NL_NEIGHBOR_STATE
    {
        NlnsUnreachable,
        NlnsIncomplete,
        NlnsProbe,
        NlnsDelay,
        NlnsStale,
        NlnsReachable,
        NlnsPermanent,
        NlnsMaximum,
    }

    public enum _NL_LINK_LOCAL_ADDRESS_BEHAVIOR
    {
        LinkLocalAlwaysOff = 0,
        LinkLocalDelayed,
        LinkLocalAlwaysOn,
        LinkLocalUnchanged = -1,
    }

    public partial struct _NL_INTERFACE_OFFLOAD_ROD
    {
        public byte _bitfield;

        [NativeTypeName("BOOLEAN : 1")]
        public byte NlChecksumSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
            }
        }

        [NativeTypeName("BOOLEAN : 1")]
        public byte NlOptionsSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 1) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
            }
        }

        [NativeTypeName("BOOLEAN : 1")]
        public byte TlDatagramChecksumSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 2) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
            }
        }

        [NativeTypeName("BOOLEAN : 1")]
        public byte TlStreamChecksumSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 3) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3));
            }
        }

        [NativeTypeName("BOOLEAN : 1")]
        public byte TlStreamOptionsSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 4) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4));
            }
        }

        [NativeTypeName("BOOLEAN : 1")]
        public byte FastPathCompatible
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 5) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5));
            }
        }

        [NativeTypeName("BOOLEAN : 1")]
        public byte TlLargeSendOffloadSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 6) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6));
            }
        }

        [NativeTypeName("BOOLEAN : 1")]
        public byte TlGiantSendOffloadSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 7) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7));
            }
        }
    }

    public enum _NL_ROUTER_DISCOVERY_BEHAVIOR
    {
        RouterDiscoveryDisabled = 0,
        RouterDiscoveryEnabled,
        RouterDiscoveryDhcp,
        RouterDiscoveryUnchanged = -1,
    }

    public enum _NL_BANDWIDTH_FLAG
    {
        NlbwDisabled = 0,
        NlbwEnabled,
        NlbwUnchanged = -1,
    }

    public partial struct _NL_PATH_BANDWIDTH_ROD
    {
        [NativeTypeName("ULONG64")]
        public ulong Bandwidth;

        [NativeTypeName("ULONG64")]
        public ulong Instability;

        [NativeTypeName("BOOLEAN")]
        public byte BandwidthPeaked;
    }

    public enum _NL_NETWORK_CATEGORY
    {
        NetworkCategoryPublic,
        NetworkCategoryPrivate,
        NetworkCategoryDomainAuthenticated,
        NetworkCategoryUnchanged = -1,
        NetworkCategoryUnknown = -1,
    }

    public enum _NL_INTERFACE_NETWORK_CATEGORY_STATE
    {
        NlincCategoryUnknown = 0,
        NlincPublic = 1,
        NlincPrivate = 2,
        NlincDomainAuthenticated = 3,
        NlincCategoryStateMax,
    }

    public enum _NL_NETWORK_CONNECTIVITY_LEVEL_HINT
    {
        NetworkConnectivityLevelHintUnknown = 0,
        NetworkConnectivityLevelHintNone,
        NetworkConnectivityLevelHintLocalAccess,
        NetworkConnectivityLevelHintInternetAccess,
        NetworkConnectivityLevelHintConstrainedInternetAccess,
        NetworkConnectivityLevelHintHidden,
    }

    public enum _NL_NETWORK_CONNECTIVITY_COST_HINT
    {
        NetworkConnectivityCostHintUnknown = 0,
        NetworkConnectivityCostHintUnrestricted,
        NetworkConnectivityCostHintFixed,
        NetworkConnectivityCostHintVariable,
    }

    public partial struct _NL_NETWORK_CONNECTIVITY_HINT
    {
        [NativeTypeName("NL_NETWORK_CONNECTIVITY_LEVEL_HINT")]
        public _NL_NETWORK_CONNECTIVITY_LEVEL_HINT ConnectivityLevel;

        [NativeTypeName("NL_NETWORK_CONNECTIVITY_COST_HINT")]
        public _NL_NETWORK_CONNECTIVITY_COST_HINT ConnectivityCost;

        [NativeTypeName("BOOLEAN")]
        public byte ApproachingDataLimit;

        [NativeTypeName("BOOLEAN")]
        public byte OverDataLimit;

        [NativeTypeName("BOOLEAN")]
        public byte Roaming;
    }

    public partial struct _NL_BANDWIDTH_INFORMATION
    {
        [NativeTypeName("ULONG64")]
        public ulong Bandwidth;

        [NativeTypeName("ULONG64")]
        public ulong Instability;

        [NativeTypeName("BOOLEAN")]
        public byte BandwidthPeaked;
    }

    public partial struct _MIB_IPADDRROW_XP
    {
        [NativeTypeName("DWORD")]
        public uint dwAddr;

        [NativeTypeName("IF_INDEX")]
        public uint dwIndex;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwBCastAddr;

        [NativeTypeName("DWORD")]
        public uint dwReasmSize;

        [NativeTypeName("unsigned short")]
        public ushort unused1;

        [NativeTypeName("unsigned short")]
        public ushort wType;
    }

    public partial struct _MIB_IPADDRROW_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwAddr;

        [NativeTypeName("DWORD")]
        public uint dwIndex;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwBCastAddr;

        [NativeTypeName("DWORD")]
        public uint dwReasmSize;

        [NativeTypeName("unsigned short")]
        public ushort unused1;

        [NativeTypeName("unsigned short")]
        public ushort unused2;
    }

    public partial struct _MIB_IPADDRTABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IPADDRROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IPADDRROW_XP e0;

            [UnscopedRef]
            public ref _MIB_IPADDRROW_XP this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPADDRROW_XP> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_IPFORWARDNUMBER
    {
        [NativeTypeName("DWORD")]
        public uint dwValue;
    }

    public enum MIB_IPFORWARD_TYPE
    {
        MIB_IPROUTE_TYPE_OTHER = 1,
        MIB_IPROUTE_TYPE_INVALID = 2,
        MIB_IPROUTE_TYPE_DIRECT = 3,
        MIB_IPROUTE_TYPE_INDIRECT = 4,
    }

    public partial struct _MIB_IPFORWARDROW
    {
        [NativeTypeName("DWORD")]
        public uint dwForwardDest;

        [NativeTypeName("DWORD")]
        public uint dwForwardMask;

        [NativeTypeName("DWORD")]
        public uint dwForwardPolicy;

        [NativeTypeName("DWORD")]
        public uint dwForwardNextHop;

        [NativeTypeName("IF_INDEX")]
        public uint dwForwardIfIndex;

        [NativeTypeName("__AnonymousRecord_ipmib_L112_C5")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_ipmib_L116_C5")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("DWORD")]
        public uint dwForwardAge;

        [NativeTypeName("DWORD")]
        public uint dwForwardNextHopAS;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric1;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric2;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric3;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric4;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric5;

        [UnscopedRef]
        public ref uint dwForwardType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.dwForwardType;
            }
        }

        [UnscopedRef]
        public ref MIB_IPFORWARD_TYPE ForwardType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.ForwardType;
            }
        }

        [UnscopedRef]
        public ref uint dwForwardProto
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.dwForwardProto;
            }
        }

        [UnscopedRef]
        public ref NL_ROUTE_PROTOCOL ForwardProto
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.ForwardProto;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwForwardType;

            [FieldOffset(0)]
            public MIB_IPFORWARD_TYPE ForwardType;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwForwardProto;

            [FieldOffset(0)]
            [NativeTypeName("MIB_IPFORWARD_PROTO")]
            public NL_ROUTE_PROTOCOL ForwardProto;
        }
    }

    public partial struct _MIB_IPFORWARDTABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IPFORWARDROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IPFORWARDROW e0;

            [UnscopedRef]
            public ref _MIB_IPFORWARDROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPFORWARDROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public enum MIB_IPNET_TYPE
    {
        MIB_IPNET_TYPE_OTHER = 1,
        MIB_IPNET_TYPE_INVALID = 2,
        MIB_IPNET_TYPE_DYNAMIC = 3,
        MIB_IPNET_TYPE_STATIC = 4,
    }

    public partial struct _MIB_IPNETROW_LH
    {
        [NativeTypeName("IF_INDEX")]
        public uint dwIndex;

        [NativeTypeName("DWORD")]
        public uint dwPhysAddrLen;

        [NativeTypeName("UCHAR[8]")]
        public _bPhysAddr_e__FixedBuffer bPhysAddr;

        [NativeTypeName("DWORD")]
        public uint dwAddr;

        [NativeTypeName("__AnonymousRecord_ipmib_L159_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref uint dwType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dwType;
            }
        }

        [UnscopedRef]
        public ref MIB_IPNET_TYPE Type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Type;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwType;

            [FieldOffset(0)]
            public MIB_IPNET_TYPE Type;
        }

        [InlineArray(8)]
        public partial struct _bPhysAddr_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _MIB_IPNETROW_W2K
    {
        [NativeTypeName("IF_INDEX")]
        public uint dwIndex;

        [NativeTypeName("DWORD")]
        public uint dwPhysAddrLen;

        [NativeTypeName("UCHAR[8]")]
        public _bPhysAddr_e__FixedBuffer bPhysAddr;

        [NativeTypeName("DWORD")]
        public uint dwAddr;

        [NativeTypeName("DWORD")]
        public uint dwType;

        [InlineArray(8)]
        public partial struct _bPhysAddr_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _MIB_IPNETTABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IPNETROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IPNETROW_LH e0;

            [UnscopedRef]
            public ref _MIB_IPNETROW_LH this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPNETROW_LH> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public enum MIB_IPSTATS_FORWARDING
    {
        MIB_IP_FORWARDING = 1,
        MIB_IP_NOT_FORWARDING = 2,
    }

    public partial struct _MIB_IPSTATS_LH
    {
        [NativeTypeName("__AnonymousRecord_ipmib_L202_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint dwDefaultTTL;

        [NativeTypeName("DWORD")]
        public uint dwInReceives;

        [NativeTypeName("DWORD")]
        public uint dwInHdrErrors;

        [NativeTypeName("DWORD")]
        public uint dwInAddrErrors;

        [NativeTypeName("DWORD")]
        public uint dwForwDatagrams;

        [NativeTypeName("DWORD")]
        public uint dwInUnknownProtos;

        [NativeTypeName("DWORD")]
        public uint dwInDiscards;

        [NativeTypeName("DWORD")]
        public uint dwInDelivers;

        [NativeTypeName("DWORD")]
        public uint dwOutRequests;

        [NativeTypeName("DWORD")]
        public uint dwRoutingDiscards;

        [NativeTypeName("DWORD")]
        public uint dwOutDiscards;

        [NativeTypeName("DWORD")]
        public uint dwOutNoRoutes;

        [NativeTypeName("DWORD")]
        public uint dwReasmTimeout;

        [NativeTypeName("DWORD")]
        public uint dwReasmReqds;

        [NativeTypeName("DWORD")]
        public uint dwReasmOks;

        [NativeTypeName("DWORD")]
        public uint dwReasmFails;

        [NativeTypeName("DWORD")]
        public uint dwFragOks;

        [NativeTypeName("DWORD")]
        public uint dwFragFails;

        [NativeTypeName("DWORD")]
        public uint dwFragCreates;

        [NativeTypeName("DWORD")]
        public uint dwNumIf;

        [NativeTypeName("DWORD")]
        public uint dwNumAddr;

        [NativeTypeName("DWORD")]
        public uint dwNumRoutes;

        [UnscopedRef]
        public ref uint dwForwarding
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dwForwarding;
            }
        }

        [UnscopedRef]
        public ref MIB_IPSTATS_FORWARDING Forwarding
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Forwarding;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwForwarding;

            [FieldOffset(0)]
            public MIB_IPSTATS_FORWARDING Forwarding;
        }
    }

    public partial struct _MIB_IPSTATS_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwForwarding;

        [NativeTypeName("DWORD")]
        public uint dwDefaultTTL;

        [NativeTypeName("DWORD")]
        public uint dwInReceives;

        [NativeTypeName("DWORD")]
        public uint dwInHdrErrors;

        [NativeTypeName("DWORD")]
        public uint dwInAddrErrors;

        [NativeTypeName("DWORD")]
        public uint dwForwDatagrams;

        [NativeTypeName("DWORD")]
        public uint dwInUnknownProtos;

        [NativeTypeName("DWORD")]
        public uint dwInDiscards;

        [NativeTypeName("DWORD")]
        public uint dwInDelivers;

        [NativeTypeName("DWORD")]
        public uint dwOutRequests;

        [NativeTypeName("DWORD")]
        public uint dwRoutingDiscards;

        [NativeTypeName("DWORD")]
        public uint dwOutDiscards;

        [NativeTypeName("DWORD")]
        public uint dwOutNoRoutes;

        [NativeTypeName("DWORD")]
        public uint dwReasmTimeout;

        [NativeTypeName("DWORD")]
        public uint dwReasmReqds;

        [NativeTypeName("DWORD")]
        public uint dwReasmOks;

        [NativeTypeName("DWORD")]
        public uint dwReasmFails;

        [NativeTypeName("DWORD")]
        public uint dwFragOks;

        [NativeTypeName("DWORD")]
        public uint dwFragFails;

        [NativeTypeName("DWORD")]
        public uint dwFragCreates;

        [NativeTypeName("DWORD")]
        public uint dwNumIf;

        [NativeTypeName("DWORD")]
        public uint dwNumAddr;

        [NativeTypeName("DWORD")]
        public uint dwNumRoutes;
    }

    public partial struct _MIBICMPSTATS
    {
        [NativeTypeName("DWORD")]
        public uint dwMsgs;

        [NativeTypeName("DWORD")]
        public uint dwErrors;

        [NativeTypeName("DWORD")]
        public uint dwDestUnreachs;

        [NativeTypeName("DWORD")]
        public uint dwTimeExcds;

        [NativeTypeName("DWORD")]
        public uint dwParmProbs;

        [NativeTypeName("DWORD")]
        public uint dwSrcQuenchs;

        [NativeTypeName("DWORD")]
        public uint dwRedirects;

        [NativeTypeName("DWORD")]
        public uint dwEchos;

        [NativeTypeName("DWORD")]
        public uint dwEchoReps;

        [NativeTypeName("DWORD")]
        public uint dwTimestamps;

        [NativeTypeName("DWORD")]
        public uint dwTimestampReps;

        [NativeTypeName("DWORD")]
        public uint dwAddrMasks;

        [NativeTypeName("DWORD")]
        public uint dwAddrMaskReps;
    }

    public partial struct _MIBICMPINFO
    {
        [NativeTypeName("MIBICMPSTATS")]
        public _MIBICMPSTATS icmpInStats;

        [NativeTypeName("MIBICMPSTATS")]
        public _MIBICMPSTATS icmpOutStats;
    }

    public partial struct _MIB_ICMP
    {
        [NativeTypeName("MIBICMPINFO")]
        public _MIBICMPINFO stats;
    }

    public partial struct _MIBICMPSTATS_EX_XPSP1
    {
        [NativeTypeName("DWORD")]
        public uint dwMsgs;

        [NativeTypeName("DWORD")]
        public uint dwErrors;

        [NativeTypeName("DWORD[256]")]
        public _rgdwTypeCount_e__FixedBuffer rgdwTypeCount;

        [InlineArray(256)]
        public partial struct _rgdwTypeCount_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct _MIB_ICMP_EX_XPSP1
    {
        [NativeTypeName("MIBICMPSTATS_EX")]
        public _MIBICMPSTATS_EX_XPSP1 icmpInStats;

        [NativeTypeName("MIBICMPSTATS_EX")]
        public _MIBICMPSTATS_EX_XPSP1 icmpOutStats;
    }

    public enum ICMP6_TYPE
    {
        ICMP6_DST_UNREACH = 1,
        ICMP6_PACKET_TOO_BIG = 2,
        ICMP6_TIME_EXCEEDED = 3,
        ICMP6_PARAM_PROB = 4,
        ICMP6_ECHO_REQUEST = 128,
        ICMP6_ECHO_REPLY = 129,
        ICMP6_MEMBERSHIP_QUERY = 130,
        ICMP6_MEMBERSHIP_REPORT = 131,
        ICMP6_MEMBERSHIP_REDUCTION = 132,
        ND_ROUTER_SOLICIT = 133,
        ND_ROUTER_ADVERT = 134,
        ND_NEIGHBOR_SOLICIT = 135,
        ND_NEIGHBOR_ADVERT = 136,
        ND_REDIRECT = 137,
        ICMP6_V2_MEMBERSHIP_REPORT = 143,
    }

    public enum ICMP4_TYPE
    {
        ICMP4_ECHO_REPLY = 0,
        ICMP4_DST_UNREACH = 3,
        ICMP4_SOURCE_QUENCH = 4,
        ICMP4_REDIRECT = 5,
        ICMP4_ECHO_REQUEST = 8,
        ICMP4_ROUTER_ADVERT = 9,
        ICMP4_ROUTER_SOLICIT = 10,
        ICMP4_TIME_EXCEEDED = 11,
        ICMP4_PARAM_PROB = 12,
        ICMP4_TIMESTAMP_REQUEST = 13,
        ICMP4_TIMESTAMP_REPLY = 14,
        ICMP4_MASK_REQUEST = 17,
        ICMP4_MASK_REPLY = 18,
    }

    public partial struct _MIB_IPMCAST_OIF_XP
    {
        [NativeTypeName("DWORD")]
        public uint dwOutIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwNextHopAddr;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("DWORD")]
        public uint dwReserved1;
    }

    public unsafe partial struct _MIB_IPMCAST_OIF_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwOutIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwNextHopAddr;

        [NativeTypeName("PVOID")]
        public void* pvReserved;

        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }

    public partial struct _MIB_IPMCAST_MFE
    {
        [NativeTypeName("DWORD")]
        public uint dwGroup;

        [NativeTypeName("DWORD")]
        public uint dwSource;

        [NativeTypeName("DWORD")]
        public uint dwSrcMask;

        [NativeTypeName("DWORD")]
        public uint dwUpStrmNgbr;

        [NativeTypeName("DWORD")]
        public uint dwInIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwInIfProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRouteProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRouteNetwork;

        [NativeTypeName("DWORD")]
        public uint dwRouteMask;

        [NativeTypeName("ULONG")]
        public uint ulUpTime;

        [NativeTypeName("ULONG")]
        public uint ulExpiryTime;

        [NativeTypeName("ULONG")]
        public uint ulTimeOut;

        [NativeTypeName("ULONG")]
        public uint ulNumOutIf;

        [NativeTypeName("DWORD")]
        public uint fFlags;

        [NativeTypeName("DWORD")]
        public uint dwReserved;

        [NativeTypeName("MIB_IPMCAST_OIF[1]")]
        public _rgmioOutInfo_e__FixedBuffer rgmioOutInfo;

        public partial struct _rgmioOutInfo_e__FixedBuffer
        {
            public _MIB_IPMCAST_OIF_XP e0;

            [UnscopedRef]
            public ref _MIB_IPMCAST_OIF_XP this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPMCAST_OIF_XP> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_MFE_TABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IPMCAST_MFE[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IPMCAST_MFE e0;

            [UnscopedRef]
            public ref _MIB_IPMCAST_MFE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPMCAST_MFE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_IPMCAST_OIF_STATS_LH
    {
        [NativeTypeName("DWORD")]
        public uint dwOutIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwNextHopAddr;

        [NativeTypeName("DWORD")]
        public uint dwDialContext;

        [NativeTypeName("ULONG")]
        public uint ulTtlTooLow;

        [NativeTypeName("ULONG")]
        public uint ulFragNeeded;

        [NativeTypeName("ULONG")]
        public uint ulOutPackets;

        [NativeTypeName("ULONG")]
        public uint ulOutDiscards;
    }

    public unsafe partial struct _MIB_IPMCAST_OIF_STATS_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwOutIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwNextHopAddr;

        [NativeTypeName("PVOID")]
        public void* pvDialContext;

        [NativeTypeName("ULONG")]
        public uint ulTtlTooLow;

        [NativeTypeName("ULONG")]
        public uint ulFragNeeded;

        [NativeTypeName("ULONG")]
        public uint ulOutPackets;

        [NativeTypeName("ULONG")]
        public uint ulOutDiscards;
    }

    public partial struct _MIB_IPMCAST_MFE_STATS
    {
        [NativeTypeName("DWORD")]
        public uint dwGroup;

        [NativeTypeName("DWORD")]
        public uint dwSource;

        [NativeTypeName("DWORD")]
        public uint dwSrcMask;

        [NativeTypeName("DWORD")]
        public uint dwUpStrmNgbr;

        [NativeTypeName("DWORD")]
        public uint dwInIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwInIfProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRouteProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRouteNetwork;

        [NativeTypeName("DWORD")]
        public uint dwRouteMask;

        [NativeTypeName("ULONG")]
        public uint ulUpTime;

        [NativeTypeName("ULONG")]
        public uint ulExpiryTime;

        [NativeTypeName("ULONG")]
        public uint ulNumOutIf;

        [NativeTypeName("ULONG")]
        public uint ulInPkts;

        [NativeTypeName("ULONG")]
        public uint ulInOctets;

        [NativeTypeName("ULONG")]
        public uint ulPktsDifferentIf;

        [NativeTypeName("ULONG")]
        public uint ulQueueOverflow;

        [NativeTypeName("MIB_IPMCAST_OIF_STATS[1]")]
        public _rgmiosOutStats_e__FixedBuffer rgmiosOutStats;

        public partial struct _rgmiosOutStats_e__FixedBuffer
        {
            public _MIB_IPMCAST_OIF_STATS_LH e0;

            [UnscopedRef]
            public ref _MIB_IPMCAST_OIF_STATS_LH this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPMCAST_OIF_STATS_LH> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_MFE_STATS_TABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IPMCAST_MFE_STATS[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IPMCAST_MFE_STATS e0;

            [UnscopedRef]
            public ref _MIB_IPMCAST_MFE_STATS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPMCAST_MFE_STATS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_IPMCAST_MFE_STATS_EX_XP
    {
        [NativeTypeName("DWORD")]
        public uint dwGroup;

        [NativeTypeName("DWORD")]
        public uint dwSource;

        [NativeTypeName("DWORD")]
        public uint dwSrcMask;

        [NativeTypeName("DWORD")]
        public uint dwUpStrmNgbr;

        [NativeTypeName("DWORD")]
        public uint dwInIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwInIfProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRouteProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRouteNetwork;

        [NativeTypeName("DWORD")]
        public uint dwRouteMask;

        [NativeTypeName("ULONG")]
        public uint ulUpTime;

        [NativeTypeName("ULONG")]
        public uint ulExpiryTime;

        [NativeTypeName("ULONG")]
        public uint ulNumOutIf;

        [NativeTypeName("ULONG")]
        public uint ulInPkts;

        [NativeTypeName("ULONG")]
        public uint ulInOctets;

        [NativeTypeName("ULONG")]
        public uint ulPktsDifferentIf;

        [NativeTypeName("ULONG")]
        public uint ulQueueOverflow;

        [NativeTypeName("ULONG")]
        public uint ulUninitMfe;

        [NativeTypeName("ULONG")]
        public uint ulNegativeMfe;

        [NativeTypeName("ULONG")]
        public uint ulInDiscards;

        [NativeTypeName("ULONG")]
        public uint ulInHdrErrors;

        [NativeTypeName("ULONG")]
        public uint ulTotalOutPackets;

        [NativeTypeName("MIB_IPMCAST_OIF_STATS[1]")]
        public _rgmiosOutStats_e__FixedBuffer rgmiosOutStats;

        public partial struct _rgmiosOutStats_e__FixedBuffer
        {
            public _MIB_IPMCAST_OIF_STATS_LH e0;

            [UnscopedRef]
            public ref _MIB_IPMCAST_OIF_STATS_LH this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPMCAST_OIF_STATS_LH> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_MFE_STATS_TABLE_EX_XP
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("PMIB_IPMCAST_MFE_STATS_EX_XP[1]")]
        public _table_e__FixedBuffer table;

        public unsafe partial struct _table_e__FixedBuffer
        {
            public _MIB_IPMCAST_MFE_STATS_EX_XP* e0;

            public ref _MIB_IPMCAST_MFE_STATS_EX_XP* this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    fixed (_MIB_IPMCAST_MFE_STATS_EX_XP** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public partial struct _MIB_IPMCAST_GLOBAL
    {
        [NativeTypeName("DWORD")]
        public uint dwEnable;
    }

    public partial struct _MIB_IPMCAST_IF_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint dwIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwTtl;

        [NativeTypeName("DWORD")]
        public uint dwProtocol;

        [NativeTypeName("DWORD")]
        public uint dwRateLimit;

        [NativeTypeName("ULONG")]
        public uint ulInMcastOctets;

        [NativeTypeName("ULONG")]
        public uint ulOutMcastOctets;
    }

    public partial struct _MIB_IPMCAST_IF_TABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IPMCAST_IF_ENTRY[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IPMCAST_IF_ENTRY e0;

            [UnscopedRef]
            public ref _MIB_IPMCAST_IF_ENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPMCAST_IF_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public enum MIB_TCP_STATE
    {
        MIB_TCP_STATE_CLOSED = 1,
        MIB_TCP_STATE_LISTEN = 2,
        MIB_TCP_STATE_SYN_SENT = 3,
        MIB_TCP_STATE_SYN_RCVD = 4,
        MIB_TCP_STATE_ESTAB = 5,
        MIB_TCP_STATE_FIN_WAIT1 = 6,
        MIB_TCP_STATE_FIN_WAIT2 = 7,
        MIB_TCP_STATE_CLOSE_WAIT = 8,
        MIB_TCP_STATE_CLOSING = 9,
        MIB_TCP_STATE_LAST_ACK = 10,
        MIB_TCP_STATE_TIME_WAIT = 11,
        MIB_TCP_STATE_DELETE_TCB = 12,
        MIB_TCP_STATE_RESERVED = 100,
    }

    public enum TCP_CONNECTION_OFFLOAD_STATE
    {
        TcpConnectionOffloadStateInHost,
        TcpConnectionOffloadStateOffloading,
        TcpConnectionOffloadStateOffloaded,
        TcpConnectionOffloadStateUploading,
        TcpConnectionOffloadStateMax,
    }

    public partial struct _MIB_TCPROW_LH
    {
        [NativeTypeName("__AnonymousRecord_tcpmib_L69_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        [UnscopedRef]
        public ref uint dwState
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dwState;
            }
        }

        [UnscopedRef]
        public ref MIB_TCP_STATE State
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.State;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwState;

            [FieldOffset(0)]
            public MIB_TCP_STATE State;
        }
    }

    public partial struct _MIB_TCPROW_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;
    }

    public partial struct _MIB_TCPTABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_TCPROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_TCPROW_LH e0;

            [UnscopedRef]
            public ref _MIB_TCPROW_LH this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_TCPROW_LH> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_TCPROW2
    {
        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        public TCP_CONNECTION_OFFLOAD_STATE dwOffloadState;
    }

    public partial struct _MIB_TCPTABLE2
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_TCPROW2[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_TCPROW2 e0;

            [UnscopedRef]
            public ref _MIB_TCPROW2 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_TCPROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_TCPROW_OWNER_PID
    {
        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;
    }

    public partial struct _MIB_TCPTABLE_OWNER_PID
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_TCPROW_OWNER_PID[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_TCPROW_OWNER_PID e0;

            [UnscopedRef]
            public ref _MIB_TCPROW_OWNER_PID this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_TCPROW_OWNER_PID> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_TCPROW_OWNER_MODULE
    {
        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        [NativeTypeName("LARGE_INTEGER")]
        public long liCreateTimestamp;

        [NativeTypeName("ULONGLONG[16]")]
        public _OwningModuleInfo_e__FixedBuffer OwningModuleInfo;

        [InlineArray(16)]
        public partial struct _OwningModuleInfo_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public partial struct _MIB_TCPTABLE_OWNER_MODULE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_TCPROW_OWNER_MODULE[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_TCPROW_OWNER_MODULE e0;

            [UnscopedRef]
            public ref _MIB_TCPROW_OWNER_MODULE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_TCPROW_OWNER_MODULE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public enum TCP_RTO_ALGORITHM
    {
        TcpRtoAlgorithmOther = 1,
        TcpRtoAlgorithmConstant,
        TcpRtoAlgorithmRsre,
        TcpRtoAlgorithmVanj,
        MIB_TCP_RTO_OTHER = 1,
        MIB_TCP_RTO_CONSTANT = 2,
        MIB_TCP_RTO_RSRE = 3,
        MIB_TCP_RTO_VANJ = 4,
    }

    public partial struct _MIB_TCPSTATS_LH
    {
        [NativeTypeName("__AnonymousRecord_tcpmib_L273_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint dwRtoMin;

        [NativeTypeName("DWORD")]
        public uint dwRtoMax;

        [NativeTypeName("DWORD")]
        public uint dwMaxConn;

        [NativeTypeName("DWORD")]
        public uint dwActiveOpens;

        [NativeTypeName("DWORD")]
        public uint dwPassiveOpens;

        [NativeTypeName("DWORD")]
        public uint dwAttemptFails;

        [NativeTypeName("DWORD")]
        public uint dwEstabResets;

        [NativeTypeName("DWORD")]
        public uint dwCurrEstab;

        [NativeTypeName("DWORD")]
        public uint dwInSegs;

        [NativeTypeName("DWORD")]
        public uint dwOutSegs;

        [NativeTypeName("DWORD")]
        public uint dwRetransSegs;

        [NativeTypeName("DWORD")]
        public uint dwInErrs;

        [NativeTypeName("DWORD")]
        public uint dwOutRsts;

        [NativeTypeName("DWORD")]
        public uint dwNumConns;

        [UnscopedRef]
        public ref uint dwRtoAlgorithm
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dwRtoAlgorithm;
            }
        }

        [UnscopedRef]
        public ref TCP_RTO_ALGORITHM RtoAlgorithm
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.RtoAlgorithm;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwRtoAlgorithm;

            [FieldOffset(0)]
            public TCP_RTO_ALGORITHM RtoAlgorithm;
        }
    }

    public partial struct _MIB_TCPSTATS_W2K
    {
        [NativeTypeName("DWORD")]
        public uint dwRtoAlgorithm;

        [NativeTypeName("DWORD")]
        public uint dwRtoMin;

        [NativeTypeName("DWORD")]
        public uint dwRtoMax;

        [NativeTypeName("DWORD")]
        public uint dwMaxConn;

        [NativeTypeName("DWORD")]
        public uint dwActiveOpens;

        [NativeTypeName("DWORD")]
        public uint dwPassiveOpens;

        [NativeTypeName("DWORD")]
        public uint dwAttemptFails;

        [NativeTypeName("DWORD")]
        public uint dwEstabResets;

        [NativeTypeName("DWORD")]
        public uint dwCurrEstab;

        [NativeTypeName("DWORD")]
        public uint dwInSegs;

        [NativeTypeName("DWORD")]
        public uint dwOutSegs;

        [NativeTypeName("DWORD")]
        public uint dwRetransSegs;

        [NativeTypeName("DWORD")]
        public uint dwInErrs;

        [NativeTypeName("DWORD")]
        public uint dwOutRsts;

        [NativeTypeName("DWORD")]
        public uint dwNumConns;
    }

    public partial struct _MIB_TCPSTATS2
    {
        public TCP_RTO_ALGORITHM RtoAlgorithm;

        [NativeTypeName("DWORD")]
        public uint dwRtoMin;

        [NativeTypeName("DWORD")]
        public uint dwRtoMax;

        [NativeTypeName("DWORD")]
        public uint dwMaxConn;

        [NativeTypeName("DWORD")]
        public uint dwActiveOpens;

        [NativeTypeName("DWORD")]
        public uint dwPassiveOpens;

        [NativeTypeName("DWORD")]
        public uint dwAttemptFails;

        [NativeTypeName("DWORD")]
        public uint dwEstabResets;

        [NativeTypeName("DWORD")]
        public uint dwCurrEstab;

        [NativeTypeName("DWORD64")]
        public ulong dw64InSegs;

        [NativeTypeName("DWORD64")]
        public ulong dw64OutSegs;

        [NativeTypeName("DWORD")]
        public uint dwRetransSegs;

        [NativeTypeName("DWORD")]
        public uint dwInErrs;

        [NativeTypeName("DWORD")]
        public uint dwOutRsts;

        [NativeTypeName("DWORD")]
        public uint dwNumConns;
    }

    public partial struct _MIB_UDPROW
    {
        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;
    }

    public partial struct _MIB_UDPTABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_UDPROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_UDPROW e0;

            [UnscopedRef]
            public ref _MIB_UDPROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UDPROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_UDPROW_OWNER_PID
    {
        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;
    }

    public partial struct _MIB_UDPTABLE_OWNER_PID
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_UDPROW_OWNER_PID[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_UDPROW_OWNER_PID e0;

            [UnscopedRef]
            public ref _MIB_UDPROW_OWNER_PID this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UDPROW_OWNER_PID> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_UDPROW_OWNER_MODULE
    {
        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        [NativeTypeName("LARGE_INTEGER")]
        public long liCreateTimestamp;

        [NativeTypeName("__AnonymousRecord_udpmib_L69_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ULONGLONG[16]")]
        public _OwningModuleInfo_e__FixedBuffer OwningModuleInfo;

        public int SpecificPortBind
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous.SpecificPortBind;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.SpecificPortBind = value;
            }
        }

        [UnscopedRef]
        public ref int dwFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dwFlags;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_udpmib_L70_C9")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            public int dwFlags;

            public partial struct _Anonymous_e__Struct
            {
                public int _bitfield;

                [NativeTypeName("int : 1")]
                public int SpecificPortBind
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield << 31) >> 31;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1) | (value & 0x1);
                    }
                }
            }
        }

        [InlineArray(16)]
        public partial struct _OwningModuleInfo_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public partial struct _MIB_UDPTABLE_OWNER_MODULE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_UDPROW_OWNER_MODULE[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_UDPROW_OWNER_MODULE e0;

            [UnscopedRef]
            public ref _MIB_UDPROW_OWNER_MODULE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UDPROW_OWNER_MODULE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_UDPROW2
    {
        [NativeTypeName("DWORD")]
        public uint dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        [NativeTypeName("LARGE_INTEGER")]
        public long liCreateTimestamp;

        [NativeTypeName("__AnonymousRecord_udpmib_L92_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ULONGLONG[16]")]
        public _OwningModuleInfo_e__FixedBuffer OwningModuleInfo;

        [NativeTypeName("DWORD")]
        public uint dwRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        public int SpecificPortBind
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous.SpecificPortBind;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.SpecificPortBind = value;
            }
        }

        [UnscopedRef]
        public ref int dwFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dwFlags;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_udpmib_L93_C9")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            public int dwFlags;

            public partial struct _Anonymous_e__Struct
            {
                public int _bitfield;

                [NativeTypeName("int : 1")]
                public int SpecificPortBind
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield << 31) >> 31;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1) | (value & 0x1);
                    }
                }
            }
        }

        [InlineArray(16)]
        public partial struct _OwningModuleInfo_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public partial struct _MIB_UDPTABLE2
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_UDPROW2[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_UDPROW2 e0;

            [UnscopedRef]
            public ref _MIB_UDPROW2 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UDPROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_UDPSTATS
    {
        [NativeTypeName("DWORD")]
        public uint dwInDatagrams;

        [NativeTypeName("DWORD")]
        public uint dwNoPorts;

        [NativeTypeName("DWORD")]
        public uint dwInErrors;

        [NativeTypeName("DWORD")]
        public uint dwOutDatagrams;

        [NativeTypeName("DWORD")]
        public uint dwNumAddrs;
    }

    public partial struct _MIB_UDPSTATS2
    {
        [NativeTypeName("DWORD64")]
        public ulong dw64InDatagrams;

        [NativeTypeName("DWORD")]
        public uint dwNoPorts;

        [NativeTypeName("DWORD")]
        public uint dwInErrors;

        [NativeTypeName("DWORD64")]
        public ulong dw64OutDatagrams;

        [NativeTypeName("DWORD")]
        public uint dwNumAddrs;
    }

    public enum _TCP_TABLE_CLASS
    {
        TCP_TABLE_BASIC_LISTENER,
        TCP_TABLE_BASIC_CONNECTIONS,
        TCP_TABLE_BASIC_ALL,
        TCP_TABLE_OWNER_PID_LISTENER,
        TCP_TABLE_OWNER_PID_CONNECTIONS,
        TCP_TABLE_OWNER_PID_ALL,
        TCP_TABLE_OWNER_MODULE_LISTENER,
        TCP_TABLE_OWNER_MODULE_CONNECTIONS,
        TCP_TABLE_OWNER_MODULE_ALL,
    }

    public enum _UDP_TABLE_CLASS
    {
        UDP_TABLE_BASIC,
        UDP_TABLE_OWNER_PID,
        UDP_TABLE_OWNER_MODULE,
    }

    public enum _TCPIP_OWNER_MODULE_INFO_CLASS
    {
        TCPIP_OWNER_MODULE_INFO_BASIC,
    }

    public unsafe partial struct _TCPIP_OWNER_MODULE_BASIC_INFO
    {
        [NativeTypeName("PWCHAR")]
        public char* pModuleName;

        [NativeTypeName("PWCHAR")]
        public char* pModulePath;
    }

    public partial struct _MIB_IPMCAST_BOUNDARY
    {
        [NativeTypeName("DWORD")]
        public uint dwIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwGroupAddress;

        [NativeTypeName("DWORD")]
        public uint dwGroupMask;

        [NativeTypeName("DWORD")]
        public uint dwStatus;
    }

    public partial struct _MIB_IPMCAST_BOUNDARY_TABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IPMCAST_BOUNDARY[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IPMCAST_BOUNDARY e0;

            [UnscopedRef]
            public ref _MIB_IPMCAST_BOUNDARY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPMCAST_BOUNDARY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct MIB_BOUNDARYROW
    {
        [NativeTypeName("DWORD")]
        public uint dwGroupAddress;

        [NativeTypeName("DWORD")]
        public uint dwGroupMask;
    }

    public partial struct MIB_MCAST_LIMIT_ROW
    {
        [NativeTypeName("DWORD")]
        public uint dwTtl;

        [NativeTypeName("DWORD")]
        public uint dwRateLimit;
    }

    public partial struct _MIB_IPMCAST_SCOPE
    {
        [NativeTypeName("DWORD")]
        public uint dwGroupAddress;

        [NativeTypeName("DWORD")]
        public uint dwGroupMask;

        [NativeTypeName("SCOPE_NAME_BUFFER")]
        public _snNameBuffer_e__FixedBuffer snNameBuffer;

        [NativeTypeName("DWORD")]
        public uint dwStatus;

        [InlineArray(256)]
        public partial struct _snNameBuffer_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct _MIB_IPDESTROW
    {
        [NativeTypeName("MIB_IPFORWARDROW")]
        public _MIB_IPFORWARDROW ForwardRow;

        [NativeTypeName("DWORD")]
        public uint dwForwardPreference;

        [NativeTypeName("DWORD")]
        public uint dwForwardViewSet;
    }

    public partial struct _MIB_IPDESTTABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_IPDESTROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_IPDESTROW e0;

            [UnscopedRef]
            public ref _MIB_IPDESTROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPDESTROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_BEST_IF
    {
        [NativeTypeName("DWORD")]
        public uint dwDestAddr;

        [NativeTypeName("DWORD")]
        public uint dwIfIndex;
    }

    public partial struct _MIB_PROXYARP
    {
        [NativeTypeName("DWORD")]
        public uint dwAddress;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwIfIndex;
    }

    public partial struct _MIB_IFSTATUS
    {
        [NativeTypeName("DWORD")]
        public uint dwIfIndex;

        [NativeTypeName("DWORD")]
        public uint dwAdminStatus;

        [NativeTypeName("DWORD")]
        public uint dwOperationalStatus;

        [NativeTypeName("BOOL")]
        public int bMHbeatActive;

        [NativeTypeName("BOOL")]
        public int bMHbeatAlive;
    }

    public partial struct _MIB_ROUTESTATE
    {
        [NativeTypeName("BOOL")]
        public int bRoutesSetToStack;
    }

    public unsafe partial struct ip_option_information
    {
        [NativeTypeName("UCHAR")]
        public byte Ttl;

        [NativeTypeName("UCHAR")]
        public byte Tos;

        [NativeTypeName("UCHAR")]
        public byte Flags;

        [NativeTypeName("UCHAR")]
        public byte OptionsSize;

        [NativeTypeName("PUCHAR")]
        public byte* OptionsData;
    }

    public unsafe partial struct ip_option_information32
    {
        [NativeTypeName("UCHAR")]
        public byte Ttl;

        [NativeTypeName("UCHAR")]
        public byte Tos;

        [NativeTypeName("UCHAR")]
        public byte Flags;

        [NativeTypeName("UCHAR")]
        public byte OptionsSize;

        [NativeTypeName("UCHAR * __ptr32")]
        public byte* OptionsData;
    }

    public unsafe partial struct icmp_echo_reply
    {
        [NativeTypeName("IPAddr")]
        public uint Address;

        [NativeTypeName("ULONG")]
        public uint Status;

        [NativeTypeName("ULONG")]
        public uint RoundTripTime;

        public ushort DataSize;

        public ushort Reserved;

        [NativeTypeName("PVOID")]
        public void* Data;

        [NativeTypeName("struct ip_option_information")]
        public ip_option_information Options;
    }

    public unsafe partial struct icmp_echo_reply32
    {
        [NativeTypeName("IPAddr")]
        public uint Address;

        [NativeTypeName("ULONG")]
        public uint Status;

        [NativeTypeName("ULONG")]
        public uint RoundTripTime;

        public ushort DataSize;

        public ushort Reserved;

        [NativeTypeName("void * __ptr32")]
        public void* Data;

        [NativeTypeName("struct ip_option_information32")]
        public ip_option_information32 Options;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _IPV6_ADDRESS_EX
    {
        public ushort sin6_port;

        [NativeTypeName("ULONG")]
        public uint sin6_flowinfo;

        [NativeTypeName("USHORT[8]")]
        public _sin6_addr_e__FixedBuffer sin6_addr;

        [NativeTypeName("ULONG")]
        public uint sin6_scope_id;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        [InlineArray(8)]
        public partial struct _sin6_addr_e__FixedBuffer
        {
            public ushort e0;
        }
    }

    public partial struct icmpv6_echo_reply_lh
    {
        [NativeTypeName("IPV6_ADDRESS_EX")]
        public _IPV6_ADDRESS_EX Address;

        [NativeTypeName("ULONG")]
        public uint Status;

        [NativeTypeName("unsigned int")]
        public uint RoundTripTime;
    }

    public partial struct arp_send_reply
    {
        [NativeTypeName("IPAddr")]
        public uint DestAddress;

        [NativeTypeName("IPAddr")]
        public uint SrcAddress;
    }

    public partial struct tcp_reserve_port_range
    {
        public ushort UpperRange;

        public ushort LowerRange;
    }

    public partial struct _IP_ADAPTER_INDEX_MAP
    {
        [NativeTypeName("ULONG")]
        public uint Index;

        [NativeTypeName("WCHAR[128]")]
        public _Name_e__FixedBuffer Name;

        [InlineArray(128)]
        public partial struct _Name_e__FixedBuffer
        {
            public char e0;
        }
    }

    public partial struct _IP_INTERFACE_INFO
    {
        [NativeTypeName("LONG")]
        public int NumAdapters;

        [NativeTypeName("IP_ADAPTER_INDEX_MAP[1]")]
        public _Adapter_e__FixedBuffer Adapter;

        public partial struct _Adapter_e__FixedBuffer
        {
            public _IP_ADAPTER_INDEX_MAP e0;

            [UnscopedRef]
            public ref _IP_ADAPTER_INDEX_MAP this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_IP_ADAPTER_INDEX_MAP> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _IP_UNIDIRECTIONAL_ADAPTER_ADDRESS
    {
        [NativeTypeName("ULONG")]
        public uint NumAdapters;

        [NativeTypeName("IPAddr[1]")]
        public _Address_e__FixedBuffer Address;

        public partial struct _Address_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _IP_ADAPTER_ORDER_MAP
    {
        [NativeTypeName("ULONG")]
        public uint NumAdapters;

        [NativeTypeName("ULONG[1]")]
        public _AdapterOrder_e__FixedBuffer AdapterOrder;

        public partial struct _AdapterOrder_e__FixedBuffer
        {
            public uint e0;

            [UnscopedRef]
            public ref uint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _IP_MCAST_COUNTER_INFO
    {
        [NativeTypeName("ULONG64")]
        public ulong InMcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong OutMcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong InMcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong OutMcastPkts;
    }

    public partial struct IP_ADDRESS_STRING
    {
        [NativeTypeName("char[16]")]
        public _String_e__FixedBuffer String;

        [InlineArray(16)]
        public partial struct _String_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct _IP_ADDR_STRING
    {
        [NativeTypeName("struct _IP_ADDR_STRING *")]
        public _IP_ADDR_STRING* Next;

        public IP_ADDRESS_STRING IpAddress;

        [NativeTypeName("IP_MASK_STRING")]
        public IP_ADDRESS_STRING IpMask;

        [NativeTypeName("DWORD")]
        public uint Context;
    }

    public unsafe partial struct _IP_ADAPTER_INFO
    {
        [NativeTypeName("struct _IP_ADAPTER_INFO *")]
        public _IP_ADAPTER_INFO* Next;

        [NativeTypeName("DWORD")]
        public uint ComboIndex;

        [NativeTypeName("char[260]")]
        public _AdapterName_e__FixedBuffer AdapterName;

        [NativeTypeName("char[132]")]
        public _Description_e__FixedBuffer Description;

        public uint AddressLength;

        [NativeTypeName("BYTE[8]")]
        public _Address_e__FixedBuffer Address;

        [NativeTypeName("DWORD")]
        public uint Index;

        public uint Type;

        public uint DhcpEnabled;

        [NativeTypeName("PIP_ADDR_STRING")]
        public _IP_ADDR_STRING* CurrentIpAddress;

        [NativeTypeName("IP_ADDR_STRING")]
        public _IP_ADDR_STRING IpAddressList;

        [NativeTypeName("IP_ADDR_STRING")]
        public _IP_ADDR_STRING GatewayList;

        [NativeTypeName("IP_ADDR_STRING")]
        public _IP_ADDR_STRING DhcpServer;

        [NativeTypeName("BOOL")]
        public int HaveWins;

        [NativeTypeName("IP_ADDR_STRING")]
        public _IP_ADDR_STRING PrimaryWinsServer;

        [NativeTypeName("IP_ADDR_STRING")]
        public _IP_ADDR_STRING SecondaryWinsServer;

        [NativeTypeName("time_t")]
        public long LeaseObtained;

        [NativeTypeName("time_t")]
        public long LeaseExpires;

        [InlineArray(260)]
        public partial struct _AdapterName_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(132)]
        public partial struct _Description_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(8)]
        public partial struct _Address_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public unsafe partial struct _IP_PER_ADAPTER_INFO_W2KSP1
    {
        public uint AutoconfigEnabled;

        public uint AutoconfigActive;

        [NativeTypeName("PIP_ADDR_STRING")]
        public _IP_ADDR_STRING* CurrentDnsServer;

        [NativeTypeName("IP_ADDR_STRING")]
        public _IP_ADDR_STRING DnsServerList;
    }

    public unsafe partial struct FIXED_INFO_W2KSP1
    {
        [NativeTypeName("char[132]")]
        public _HostName_e__FixedBuffer HostName;

        [NativeTypeName("char[132]")]
        public _DomainName_e__FixedBuffer DomainName;

        [NativeTypeName("PIP_ADDR_STRING")]
        public _IP_ADDR_STRING* CurrentDnsServer;

        [NativeTypeName("IP_ADDR_STRING")]
        public _IP_ADDR_STRING DnsServerList;

        public uint NodeType;

        [NativeTypeName("char[260]")]
        public _ScopeId_e__FixedBuffer ScopeId;

        public uint EnableRouting;

        public uint EnableProxy;

        public uint EnableDns;

        [InlineArray(132)]
        public partial struct _HostName_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(132)]
        public partial struct _DomainName_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(260)]
        public partial struct _ScopeId_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct ip_interface_name_info_w2ksp1
    {
        [NativeTypeName("ULONG")]
        public uint Index;

        [NativeTypeName("ULONG")]
        public uint MediaType;

        [NativeTypeName("UCHAR")]
        public byte ConnectionType;

        [NativeTypeName("UCHAR")]
        public byte AccessType;

        public Guid DeviceGuid;

        public Guid InterfaceGuid;
    }

    public partial struct _INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES
    {
        [NativeTypeName("BOOLEAN")]
        public byte PtpV2OverUdpIPv4EventMessageReceive;

        [NativeTypeName("BOOLEAN")]
        public byte PtpV2OverUdpIPv4AllMessageReceive;

        [NativeTypeName("BOOLEAN")]
        public byte PtpV2OverUdpIPv4EventMessageTransmit;

        [NativeTypeName("BOOLEAN")]
        public byte PtpV2OverUdpIPv4AllMessageTransmit;

        [NativeTypeName("BOOLEAN")]
        public byte PtpV2OverUdpIPv6EventMessageReceive;

        [NativeTypeName("BOOLEAN")]
        public byte PtpV2OverUdpIPv6AllMessageReceive;

        [NativeTypeName("BOOLEAN")]
        public byte PtpV2OverUdpIPv6EventMessageTransmit;

        [NativeTypeName("BOOLEAN")]
        public byte PtpV2OverUdpIPv6AllMessageTransmit;

        [NativeTypeName("BOOLEAN")]
        public byte AllReceive;

        [NativeTypeName("BOOLEAN")]
        public byte AllTransmit;

        [NativeTypeName("BOOLEAN")]
        public byte TaggedTransmit;
    }

    public partial struct _INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES
    {
        [NativeTypeName("BOOLEAN")]
        public byte AllReceive;

        [NativeTypeName("BOOLEAN")]
        public byte AllTransmit;

        [NativeTypeName("BOOLEAN")]
        public byte TaggedTransmit;
    }

    public partial struct _INTERFACE_TIMESTAMP_CAPABILITIES
    {
        [NativeTypeName("ULONG64")]
        public ulong HardwareClockFrequencyHz;

        [NativeTypeName("BOOLEAN")]
        public byte SupportsCrossTimestamp;

        [NativeTypeName("INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES")]
        public _INTERFACE_HARDWARE_TIMESTAMP_CAPABILITIES HardwareCapabilities;

        [NativeTypeName("INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES")]
        public _INTERFACE_SOFTWARE_TIMESTAMP_CAPABILITIES SoftwareCapabilities;
    }

    public partial struct _INTERFACE_HARDWARE_CROSSTIMESTAMP
    {
        [NativeTypeName("ULONG64")]
        public ulong SystemTimestamp1;

        [NativeTypeName("ULONG64")]
        public ulong HardwareClockTimestamp;

        [NativeTypeName("ULONG64")]
        public ulong SystemTimestamp2;
    }

    public enum NET_ADDRESS_FORMAT_
    {
        NET_ADDRESS_FORMAT_UNSPECIFIED = 0,
        NET_ADDRESS_DNS_NAME,
        NET_ADDRESS_IPV4,
        NET_ADDRESS_IPV6,
    }

    public static unsafe partial class Methods
    {
        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetNumberOfInterfaces([NativeTypeName("PDWORD")] uint* pdwNumIf);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIfEntry([NativeTypeName("PMIB_IFROW")] _MIB_IFROW* pIfRow);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIfTable([NativeTypeName("PMIB_IFTABLE")] _MIB_IFTABLE* pIfTable, [NativeTypeName("PULONG")] uint* pdwSize, [NativeTypeName("BOOL")] int bOrder);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpAddrTable([NativeTypeName("PMIB_IPADDRTABLE")] _MIB_IPADDRTABLE* pIpAddrTable, [NativeTypeName("PULONG")] uint* pdwSize, [NativeTypeName("BOOL")] int bOrder);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetIpNetTable([NativeTypeName("PMIB_IPNETTABLE")] _MIB_IPNETTABLE* IpNetTable, [NativeTypeName("PULONG")] uint* SizePointer, [NativeTypeName("BOOL")] int Order);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpForwardTable([NativeTypeName("PMIB_IPFORWARDTABLE")] _MIB_IPFORWARDTABLE* pIpForwardTable, [NativeTypeName("PULONG")] uint* pdwSize, [NativeTypeName("BOOL")] int bOrder);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetTcpTable([NativeTypeName("PMIB_TCPTABLE")] _MIB_TCPTABLE* TcpTable, [NativeTypeName("PULONG")] uint* SizePointer, [NativeTypeName("BOOL")] int Order);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetExtendedTcpTable([NativeTypeName("PVOID")] void* pTcpTable, [NativeTypeName("PDWORD")] uint* pdwSize, [NativeTypeName("BOOL")] int bOrder, [NativeTypeName("ULONG")] uint ulAf, [NativeTypeName("TCP_TABLE_CLASS")] _TCP_TABLE_CLASS TableClass, [NativeTypeName("ULONG")] uint Reserved);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetOwnerModuleFromTcpEntry([NativeTypeName("PMIB_TCPROW_OWNER_MODULE")] _MIB_TCPROW_OWNER_MODULE* pTcpEntry, [NativeTypeName("TCPIP_OWNER_MODULE_INFO_CLASS")] _TCPIP_OWNER_MODULE_INFO_CLASS Class, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("PDWORD")] uint* pdwSize);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetUdpTable([NativeTypeName("PMIB_UDPTABLE")] _MIB_UDPTABLE* UdpTable, [NativeTypeName("PULONG")] uint* SizePointer, [NativeTypeName("BOOL")] int Order);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetExtendedUdpTable([NativeTypeName("PVOID")] void* pUdpTable, [NativeTypeName("PDWORD")] uint* pdwSize, [NativeTypeName("BOOL")] int bOrder, [NativeTypeName("ULONG")] uint ulAf, [NativeTypeName("UDP_TABLE_CLASS")] _UDP_TABLE_CLASS TableClass, [NativeTypeName("ULONG")] uint Reserved);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetOwnerModuleFromUdpEntry([NativeTypeName("PMIB_UDPROW_OWNER_MODULE")] _MIB_UDPROW_OWNER_MODULE* pUdpEntry, [NativeTypeName("TCPIP_OWNER_MODULE_INFO_CLASS")] _TCPIP_OWNER_MODULE_INFO_CLASS Class, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("PDWORD")] uint* pdwSize);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetTcpTable2([NativeTypeName("PMIB_TCPTABLE2")] _MIB_TCPTABLE2* TcpTable, [NativeTypeName("PULONG")] uint* SizePointer, [NativeTypeName("BOOL")] int Order);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetOwnerModuleFromPidAndInfo([NativeTypeName("ULONG")] uint ulPid, [NativeTypeName("ULONGLONG *")] ulong* pInfo, [NativeTypeName("TCPIP_OWNER_MODULE_INFO_CLASS")] _TCPIP_OWNER_MODULE_INFO_CLASS Class, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("PDWORD")] uint* pdwSize);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetIpStatistics([NativeTypeName("PMIB_IPSTATS")] _MIB_IPSTATS_LH* Statistics);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetIcmpStatistics([NativeTypeName("PMIB_ICMP")] _MIB_ICMP* Statistics);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetTcpStatistics([NativeTypeName("PMIB_TCPSTATS")] _MIB_TCPSTATS_LH* Statistics);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetUdpStatistics([NativeTypeName("PMIB_UDPSTATS")] _MIB_UDPSTATS* Stats);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint SetIpStatisticsEx([NativeTypeName("PMIB_IPSTATS")] _MIB_IPSTATS_LH* Statistics, [NativeTypeName("ULONG")] uint Family);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetIpStatisticsEx([NativeTypeName("PMIB_IPSTATS")] _MIB_IPSTATS_LH* Statistics, [NativeTypeName("ULONG")] uint Family);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetIcmpStatisticsEx([NativeTypeName("PMIB_ICMP_EX")] _MIB_ICMP_EX_XPSP1* Statistics, [NativeTypeName("ULONG")] uint Family);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetTcpStatisticsEx([NativeTypeName("PMIB_TCPSTATS")] _MIB_TCPSTATS_LH* Statistics, [NativeTypeName("ULONG")] uint Family);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetUdpStatisticsEx([NativeTypeName("PMIB_UDPSTATS")] _MIB_UDPSTATS* Statistics, [NativeTypeName("ULONG")] uint Family);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetTcpStatisticsEx2([NativeTypeName("PMIB_TCPSTATS2")] _MIB_TCPSTATS2* Statistics, [NativeTypeName("ULONG")] uint Family);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetUdpStatisticsEx2([NativeTypeName("PMIB_UDPSTATS2")] _MIB_UDPSTATS2* Statistics, [NativeTypeName("ULONG")] uint Family);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIfEntry([NativeTypeName("PMIB_IFROW")] _MIB_IFROW* pIfRow);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateIpForwardEntry([NativeTypeName("PMIB_IPFORWARDROW")] _MIB_IPFORWARDROW* pRoute);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIpForwardEntry([NativeTypeName("PMIB_IPFORWARDROW")] _MIB_IPFORWARDROW* pRoute);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteIpForwardEntry([NativeTypeName("PMIB_IPFORWARDROW")] _MIB_IPFORWARDROW* pRoute);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIpStatistics([NativeTypeName("PMIB_IPSTATS")] _MIB_IPSTATS_LH* pIpStats);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIpTTL(uint nTTL);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateIpNetEntry([NativeTypeName("PMIB_IPNETROW")] _MIB_IPNETROW_LH* pArpEntry);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIpNetEntry([NativeTypeName("PMIB_IPNETROW")] _MIB_IPNETROW_LH* pArpEntry);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteIpNetEntry([NativeTypeName("PMIB_IPNETROW")] _MIB_IPNETROW_LH* pArpEntry);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FlushIpNetTable([NativeTypeName("DWORD")] uint dwIfIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateProxyArpEntry([NativeTypeName("DWORD")] uint dwAddress, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwIfIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteProxyArpEntry([NativeTypeName("DWORD")] uint dwAddress, [NativeTypeName("DWORD")] uint dwMask, [NativeTypeName("DWORD")] uint dwIfIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetTcpEntry([NativeTypeName("PMIB_TCPROW")] _MIB_TCPROW_LH* pTcpRow);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetInterfaceInfo([NativeTypeName("PIP_INTERFACE_INFO")] _IP_INTERFACE_INFO* pIfTable, [NativeTypeName("PULONG")] uint* dwOutBufLen);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetUniDirectionalAdapterInfo([NativeTypeName("PIP_UNIDIRECTIONAL_ADAPTER_ADDRESS")] _IP_UNIDIRECTIONAL_ADAPTER_ADDRESS* pIPIfInfo, [NativeTypeName("PULONG")] uint* dwOutBufLen);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NhpAllocateAndGetInterfaceInfoFromStack([NativeTypeName("IP_INTERFACE_NAME_INFO **")] ip_interface_name_info_w2ksp1** ppTable, [NativeTypeName("PDWORD")] uint* pdwCount, [NativeTypeName("BOOL")] int bOrder, [NativeTypeName("HANDLE")] void* hHeap, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetBestInterface([NativeTypeName("IPAddr")] uint dwDestAddr, [NativeTypeName("PDWORD")] uint* pdwBestIfIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetBestInterfaceEx([NativeTypeName("struct sockaddr *")] sockaddr* pDestAddr, [NativeTypeName("PDWORD")] uint* pdwBestIfIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetBestRoute([NativeTypeName("DWORD")] uint dwDestAddr, [NativeTypeName("DWORD")] uint dwSourceAddr, [NativeTypeName("PMIB_IPFORWARDROW")] _MIB_IPFORWARDROW* pBestRoute);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyAddrChange([NativeTypeName("PHANDLE")] void** Handle, [NativeTypeName("LPOVERLAPPED")] _OVERLAPPED* overlapped);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyRouteChange([NativeTypeName("PHANDLE")] void** Handle, [NativeTypeName("LPOVERLAPPED")] _OVERLAPPED* overlapped);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CancelIPChangeNotify([NativeTypeName("LPOVERLAPPED")] _OVERLAPPED* notifyOverlapped);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetAdapterIndex([NativeTypeName("LPWSTR")] char* AdapterName, [NativeTypeName("PULONG")] uint* IfIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint AddIPAddress([NativeTypeName("IPAddr")] uint Address, [NativeTypeName("IPMask")] uint IpMask, [NativeTypeName("DWORD")] uint IfIndex, [NativeTypeName("PULONG")] uint* NTEContext, [NativeTypeName("PULONG")] uint* NTEInstance);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteIPAddress([NativeTypeName("ULONG")] uint NTEContext);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetNetworkParams([NativeTypeName("PFIXED_INFO")] FIXED_INFO_W2KSP1* pFixedInfo, [NativeTypeName("PULONG")] uint* pOutBufLen);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetAdaptersInfo([NativeTypeName("PIP_ADAPTER_INFO")] _IP_ADAPTER_INFO* AdapterInfo, [NativeTypeName("PULONG")] uint* SizePointer);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("PIP_ADAPTER_ORDER_MAP")]
        public static extern _IP_ADAPTER_ORDER_MAP* GetAdapterOrderMap();

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPerAdapterInfo([NativeTypeName("ULONG")] uint IfIndex, [NativeTypeName("PIP_PER_ADAPTER_INFO")] _IP_PER_ADAPTER_INFO_W2KSP1* pPerAdapterInfo, [NativeTypeName("PULONG")] uint* pOutBufLen);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetInterfaceActiveTimestampCapabilities([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PINTERFACE_TIMESTAMP_CAPABILITIES")] _INTERFACE_TIMESTAMP_CAPABILITIES* TimestampCapabilites);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetInterfaceSupportedTimestampCapabilities([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PINTERFACE_TIMESTAMP_CAPABILITIES")] _INTERFACE_TIMESTAMP_CAPABILITIES* TimestampCapabilites);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CaptureInterfaceHardwareCrossTimestamp([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PINTERFACE_HARDWARE_CROSSTIMESTAMP")] _INTERFACE_HARDWARE_CROSSTIMESTAMP* CrossTimestamp);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RegisterInterfaceTimestampConfigChange([NativeTypeName("PINTERFACE_TIMESTAMP_CONFIG_CHANGE_CALLBACK")] delegate* unmanaged[Stdcall]<void*, void> Callback, [NativeTypeName("PVOID")] void* CallerContext, [NativeTypeName("HIFTIMESTAMPCHANGE *")] void** NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void UnregisterInterfaceTimestampConfigChange([NativeTypeName("HIFTIMESTAMPCHANGE")] void* NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetInterfaceCurrentTimestampCapabilities([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PINTERFACE_TIMESTAMP_CAPABILITIES")] _INTERFACE_TIMESTAMP_CAPABILITIES* TimestampCapabilites);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetInterfaceHardwareTimestampCapabilities([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PINTERFACE_TIMESTAMP_CAPABILITIES")] _INTERFACE_TIMESTAMP_CAPABILITIES* TimestampCapabilites);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyIfTimestampConfigChange([NativeTypeName("PVOID")] void* CallerContext, [NativeTypeName("PINTERFACE_TIMESTAMP_CONFIG_CHANGE_CALLBACK")] delegate* unmanaged[Stdcall]<void*, void> Callback, [NativeTypeName("HIFTIMESTAMPCHANGE *")] void** NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void CancelIfTimestampConfigChange([NativeTypeName("HIFTIMESTAMPCHANGE")] void* NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IpReleaseAddress([NativeTypeName("PIP_ADAPTER_INDEX_MAP")] _IP_ADAPTER_INDEX_MAP* AdapterInfo);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IpRenewAddress([NativeTypeName("PIP_ADAPTER_INDEX_MAP")] _IP_ADAPTER_INDEX_MAP* AdapterInfo);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SendARP([NativeTypeName("IPAddr")] uint DestIP, [NativeTypeName("IPAddr")] uint SrcIP, [NativeTypeName("PVOID")] void* pMacAddr, [NativeTypeName("PULONG")] uint* PhyAddrLen);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int GetRTTAndHopCount([NativeTypeName("IPAddr")] uint DestIpAddress, [NativeTypeName("PULONG")] uint* HopCount, [NativeTypeName("ULONG")] uint MaxHops, [NativeTypeName("PULONG")] uint* RTT);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFriendlyIfIndex([NativeTypeName("DWORD")] uint IfIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint EnableRouter([NativeTypeName("HANDLE *")] void** pHandle, [NativeTypeName("OVERLAPPED *")] _OVERLAPPED* pOverlapped);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint UnenableRouter([NativeTypeName("OVERLAPPED *")] _OVERLAPPED* pOverlapped, [NativeTypeName("LPDWORD")] uint* lpdwEnableCount);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DisableMediaSense([NativeTypeName("HANDLE *")] void** pHandle, [NativeTypeName("OVERLAPPED *")] _OVERLAPPED* pOverLapped);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint RestoreMediaSense([NativeTypeName("OVERLAPPED *")] _OVERLAPPED* pOverlapped, [NativeTypeName("LPDWORD")] uint* lpdwEnableCount);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpErrorString([NativeTypeName("IP_STATUS")] uint ErrorCode, [NativeTypeName("PWSTR")] char* Buffer, [NativeTypeName("PDWORD")] uint* Size);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint CreatePersistentTcpPortReservation(ushort StartPort, ushort NumberOfPorts, [NativeTypeName("PULONG64")] ulong* Token);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint CreatePersistentUdpPortReservation(ushort StartPort, ushort NumberOfPorts, [NativeTypeName("PULONG64")] ulong* Token);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint DeletePersistentTcpPortReservation(ushort StartPort, ushort NumberOfPorts);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint DeletePersistentUdpPortReservation(ushort StartPort, ushort NumberOfPorts);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint LookupPersistentTcpPortReservation(ushort StartPort, ushort NumberOfPorts, [NativeTypeName("PULONG64")] ulong* Token);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint LookupPersistentUdpPortReservation(ushort StartPort, ushort NumberOfPorts, [NativeTypeName("PULONG64")] ulong* Token);

        [NativeTypeName("#define MIN_IF_TYPE 1")]
        public const int MIN_IF_TYPE = 1;

        [NativeTypeName("#define IF_TYPE_OTHER 1")]
        public const int IF_TYPE_OTHER = 1;

        [NativeTypeName("#define IF_TYPE_REGULAR_1822 2")]
        public const int IF_TYPE_REGULAR_1822 = 2;

        [NativeTypeName("#define IF_TYPE_HDH_1822 3")]
        public const int IF_TYPE_HDH_1822 = 3;

        [NativeTypeName("#define IF_TYPE_DDN_X25 4")]
        public const int IF_TYPE_DDN_X25 = 4;

        [NativeTypeName("#define IF_TYPE_RFC877_X25 5")]
        public const int IF_TYPE_RFC877_X25 = 5;

        [NativeTypeName("#define IF_TYPE_ETHERNET_CSMACD 6")]
        public const int IF_TYPE_ETHERNET_CSMACD = 6;

        [NativeTypeName("#define IF_TYPE_IS088023_CSMACD 7")]
        public const int IF_TYPE_IS088023_CSMACD = 7;

        [NativeTypeName("#define IF_TYPE_ISO88024_TOKENBUS 8")]
        public const int IF_TYPE_ISO88024_TOKENBUS = 8;

        [NativeTypeName("#define IF_TYPE_ISO88025_TOKENRING 9")]
        public const int IF_TYPE_ISO88025_TOKENRING = 9;

        [NativeTypeName("#define IF_TYPE_ISO88026_MAN 10")]
        public const int IF_TYPE_ISO88026_MAN = 10;

        [NativeTypeName("#define IF_TYPE_STARLAN 11")]
        public const int IF_TYPE_STARLAN = 11;

        [NativeTypeName("#define IF_TYPE_PROTEON_10MBIT 12")]
        public const int IF_TYPE_PROTEON_10MBIT = 12;

        [NativeTypeName("#define IF_TYPE_PROTEON_80MBIT 13")]
        public const int IF_TYPE_PROTEON_80MBIT = 13;

        [NativeTypeName("#define IF_TYPE_HYPERCHANNEL 14")]
        public const int IF_TYPE_HYPERCHANNEL = 14;

        [NativeTypeName("#define IF_TYPE_FDDI 15")]
        public const int IF_TYPE_FDDI = 15;

        [NativeTypeName("#define IF_TYPE_LAP_B 16")]
        public const int IF_TYPE_LAP_B = 16;

        [NativeTypeName("#define IF_TYPE_SDLC 17")]
        public const int IF_TYPE_SDLC = 17;

        [NativeTypeName("#define IF_TYPE_DS1 18")]
        public const int IF_TYPE_DS1 = 18;

        [NativeTypeName("#define IF_TYPE_E1 19")]
        public const int IF_TYPE_E1 = 19;

        [NativeTypeName("#define IF_TYPE_BASIC_ISDN 20")]
        public const int IF_TYPE_BASIC_ISDN = 20;

        [NativeTypeName("#define IF_TYPE_PRIMARY_ISDN 21")]
        public const int IF_TYPE_PRIMARY_ISDN = 21;

        [NativeTypeName("#define IF_TYPE_PROP_POINT2POINT_SERIAL 22")]
        public const int IF_TYPE_PROP_POINT2POINT_SERIAL = 22;

        [NativeTypeName("#define IF_TYPE_PPP 23")]
        public const int IF_TYPE_PPP = 23;

        [NativeTypeName("#define IF_TYPE_SOFTWARE_LOOPBACK 24")]
        public const int IF_TYPE_SOFTWARE_LOOPBACK = 24;

        [NativeTypeName("#define IF_TYPE_EON 25")]
        public const int IF_TYPE_EON = 25;

        [NativeTypeName("#define IF_TYPE_ETHERNET_3MBIT 26")]
        public const int IF_TYPE_ETHERNET_3MBIT = 26;

        [NativeTypeName("#define IF_TYPE_NSIP 27")]
        public const int IF_TYPE_NSIP = 27;

        [NativeTypeName("#define IF_TYPE_SLIP 28")]
        public const int IF_TYPE_SLIP = 28;

        [NativeTypeName("#define IF_TYPE_ULTRA 29")]
        public const int IF_TYPE_ULTRA = 29;

        [NativeTypeName("#define IF_TYPE_DS3 30")]
        public const int IF_TYPE_DS3 = 30;

        [NativeTypeName("#define IF_TYPE_SIP 31")]
        public const int IF_TYPE_SIP = 31;

        [NativeTypeName("#define IF_TYPE_FRAMERELAY 32")]
        public const int IF_TYPE_FRAMERELAY = 32;

        [NativeTypeName("#define IF_TYPE_RS232 33")]
        public const int IF_TYPE_RS232 = 33;

        [NativeTypeName("#define IF_TYPE_PARA 34")]
        public const int IF_TYPE_PARA = 34;

        [NativeTypeName("#define IF_TYPE_ARCNET 35")]
        public const int IF_TYPE_ARCNET = 35;

        [NativeTypeName("#define IF_TYPE_ARCNET_PLUS 36")]
        public const int IF_TYPE_ARCNET_PLUS = 36;

        [NativeTypeName("#define IF_TYPE_ATM 37")]
        public const int IF_TYPE_ATM = 37;

        [NativeTypeName("#define IF_TYPE_MIO_X25 38")]
        public const int IF_TYPE_MIO_X25 = 38;

        [NativeTypeName("#define IF_TYPE_SONET 39")]
        public const int IF_TYPE_SONET = 39;

        [NativeTypeName("#define IF_TYPE_X25_PLE 40")]
        public const int IF_TYPE_X25_PLE = 40;

        [NativeTypeName("#define IF_TYPE_ISO88022_LLC 41")]
        public const int IF_TYPE_ISO88022_LLC = 41;

        [NativeTypeName("#define IF_TYPE_LOCALTALK 42")]
        public const int IF_TYPE_LOCALTALK = 42;

        [NativeTypeName("#define IF_TYPE_SMDS_DXI 43")]
        public const int IF_TYPE_SMDS_DXI = 43;

        [NativeTypeName("#define IF_TYPE_FRAMERELAY_SERVICE 44")]
        public const int IF_TYPE_FRAMERELAY_SERVICE = 44;

        [NativeTypeName("#define IF_TYPE_V35 45")]
        public const int IF_TYPE_V35 = 45;

        [NativeTypeName("#define IF_TYPE_HSSI 46")]
        public const int IF_TYPE_HSSI = 46;

        [NativeTypeName("#define IF_TYPE_HIPPI 47")]
        public const int IF_TYPE_HIPPI = 47;

        [NativeTypeName("#define IF_TYPE_MODEM 48")]
        public const int IF_TYPE_MODEM = 48;

        [NativeTypeName("#define IF_TYPE_AAL5 49")]
        public const int IF_TYPE_AAL5 = 49;

        [NativeTypeName("#define IF_TYPE_SONET_PATH 50")]
        public const int IF_TYPE_SONET_PATH = 50;

        [NativeTypeName("#define IF_TYPE_SONET_VT 51")]
        public const int IF_TYPE_SONET_VT = 51;

        [NativeTypeName("#define IF_TYPE_SMDS_ICIP 52")]
        public const int IF_TYPE_SMDS_ICIP = 52;

        [NativeTypeName("#define IF_TYPE_PROP_VIRTUAL 53")]
        public const int IF_TYPE_PROP_VIRTUAL = 53;

        [NativeTypeName("#define IF_TYPE_PROP_MULTIPLEXOR 54")]
        public const int IF_TYPE_PROP_MULTIPLEXOR = 54;

        [NativeTypeName("#define IF_TYPE_IEEE80212 55")]
        public const int IF_TYPE_IEEE80212 = 55;

        [NativeTypeName("#define IF_TYPE_FIBRECHANNEL 56")]
        public const int IF_TYPE_FIBRECHANNEL = 56;

        [NativeTypeName("#define IF_TYPE_HIPPIINTERFACE 57")]
        public const int IF_TYPE_HIPPIINTERFACE = 57;

        [NativeTypeName("#define IF_TYPE_FRAMERELAY_INTERCONNECT 58")]
        public const int IF_TYPE_FRAMERELAY_INTERCONNECT = 58;

        [NativeTypeName("#define IF_TYPE_AFLANE_8023 59")]
        public const int IF_TYPE_AFLANE_8023 = 59;

        [NativeTypeName("#define IF_TYPE_AFLANE_8025 60")]
        public const int IF_TYPE_AFLANE_8025 = 60;

        [NativeTypeName("#define IF_TYPE_CCTEMUL 61")]
        public const int IF_TYPE_CCTEMUL = 61;

        [NativeTypeName("#define IF_TYPE_FASTETHER 62")]
        public const int IF_TYPE_FASTETHER = 62;

        [NativeTypeName("#define IF_TYPE_ISDN 63")]
        public const int IF_TYPE_ISDN = 63;

        [NativeTypeName("#define IF_TYPE_V11 64")]
        public const int IF_TYPE_V11 = 64;

        [NativeTypeName("#define IF_TYPE_V36 65")]
        public const int IF_TYPE_V36 = 65;

        [NativeTypeName("#define IF_TYPE_G703_64K 66")]
        public const int IF_TYPE_G703_64K = 66;

        [NativeTypeName("#define IF_TYPE_G703_2MB 67")]
        public const int IF_TYPE_G703_2MB = 67;

        [NativeTypeName("#define IF_TYPE_QLLC 68")]
        public const int IF_TYPE_QLLC = 68;

        [NativeTypeName("#define IF_TYPE_FASTETHER_FX 69")]
        public const int IF_TYPE_FASTETHER_FX = 69;

        [NativeTypeName("#define IF_TYPE_CHANNEL 70")]
        public const int IF_TYPE_CHANNEL = 70;

        [NativeTypeName("#define IF_TYPE_IEEE80211 71")]
        public const int IF_TYPE_IEEE80211 = 71;

        [NativeTypeName("#define IF_TYPE_IBM370PARCHAN 72")]
        public const int IF_TYPE_IBM370PARCHAN = 72;

        [NativeTypeName("#define IF_TYPE_ESCON 73")]
        public const int IF_TYPE_ESCON = 73;

        [NativeTypeName("#define IF_TYPE_DLSW 74")]
        public const int IF_TYPE_DLSW = 74;

        [NativeTypeName("#define IF_TYPE_ISDN_S 75")]
        public const int IF_TYPE_ISDN_S = 75;

        [NativeTypeName("#define IF_TYPE_ISDN_U 76")]
        public const int IF_TYPE_ISDN_U = 76;

        [NativeTypeName("#define IF_TYPE_LAP_D 77")]
        public const int IF_TYPE_LAP_D = 77;

        [NativeTypeName("#define IF_TYPE_IPSWITCH 78")]
        public const int IF_TYPE_IPSWITCH = 78;

        [NativeTypeName("#define IF_TYPE_RSRB 79")]
        public const int IF_TYPE_RSRB = 79;

        [NativeTypeName("#define IF_TYPE_ATM_LOGICAL 80")]
        public const int IF_TYPE_ATM_LOGICAL = 80;

        [NativeTypeName("#define IF_TYPE_DS0 81")]
        public const int IF_TYPE_DS0 = 81;

        [NativeTypeName("#define IF_TYPE_DS0_BUNDLE 82")]
        public const int IF_TYPE_DS0_BUNDLE = 82;

        [NativeTypeName("#define IF_TYPE_BSC 83")]
        public const int IF_TYPE_BSC = 83;

        [NativeTypeName("#define IF_TYPE_ASYNC 84")]
        public const int IF_TYPE_ASYNC = 84;

        [NativeTypeName("#define IF_TYPE_CNR 85")]
        public const int IF_TYPE_CNR = 85;

        [NativeTypeName("#define IF_TYPE_ISO88025R_DTR 86")]
        public const int IF_TYPE_ISO88025R_DTR = 86;

        [NativeTypeName("#define IF_TYPE_EPLRS 87")]
        public const int IF_TYPE_EPLRS = 87;

        [NativeTypeName("#define IF_TYPE_ARAP 88")]
        public const int IF_TYPE_ARAP = 88;

        [NativeTypeName("#define IF_TYPE_PROP_CNLS 89")]
        public const int IF_TYPE_PROP_CNLS = 89;

        [NativeTypeName("#define IF_TYPE_HOSTPAD 90")]
        public const int IF_TYPE_HOSTPAD = 90;

        [NativeTypeName("#define IF_TYPE_TERMPAD 91")]
        public const int IF_TYPE_TERMPAD = 91;

        [NativeTypeName("#define IF_TYPE_FRAMERELAY_MPI 92")]
        public const int IF_TYPE_FRAMERELAY_MPI = 92;

        [NativeTypeName("#define IF_TYPE_X213 93")]
        public const int IF_TYPE_X213 = 93;

        [NativeTypeName("#define IF_TYPE_ADSL 94")]
        public const int IF_TYPE_ADSL = 94;

        [NativeTypeName("#define IF_TYPE_RADSL 95")]
        public const int IF_TYPE_RADSL = 95;

        [NativeTypeName("#define IF_TYPE_SDSL 96")]
        public const int IF_TYPE_SDSL = 96;

        [NativeTypeName("#define IF_TYPE_VDSL 97")]
        public const int IF_TYPE_VDSL = 97;

        [NativeTypeName("#define IF_TYPE_ISO88025_CRFPRINT 98")]
        public const int IF_TYPE_ISO88025_CRFPRINT = 98;

        [NativeTypeName("#define IF_TYPE_MYRINET 99")]
        public const int IF_TYPE_MYRINET = 99;

        [NativeTypeName("#define IF_TYPE_VOICE_EM 100")]
        public const int IF_TYPE_VOICE_EM = 100;

        [NativeTypeName("#define IF_TYPE_VOICE_FXO 101")]
        public const int IF_TYPE_VOICE_FXO = 101;

        [NativeTypeName("#define IF_TYPE_VOICE_FXS 102")]
        public const int IF_TYPE_VOICE_FXS = 102;

        [NativeTypeName("#define IF_TYPE_VOICE_ENCAP 103")]
        public const int IF_TYPE_VOICE_ENCAP = 103;

        [NativeTypeName("#define IF_TYPE_VOICE_OVERIP 104")]
        public const int IF_TYPE_VOICE_OVERIP = 104;

        [NativeTypeName("#define IF_TYPE_ATM_DXI 105")]
        public const int IF_TYPE_ATM_DXI = 105;

        [NativeTypeName("#define IF_TYPE_ATM_FUNI 106")]
        public const int IF_TYPE_ATM_FUNI = 106;

        [NativeTypeName("#define IF_TYPE_ATM_IMA 107")]
        public const int IF_TYPE_ATM_IMA = 107;

        [NativeTypeName("#define IF_TYPE_PPPMULTILINKBUNDLE 108")]
        public const int IF_TYPE_PPPMULTILINKBUNDLE = 108;

        [NativeTypeName("#define IF_TYPE_IPOVER_CDLC 109")]
        public const int IF_TYPE_IPOVER_CDLC = 109;

        [NativeTypeName("#define IF_TYPE_IPOVER_CLAW 110")]
        public const int IF_TYPE_IPOVER_CLAW = 110;

        [NativeTypeName("#define IF_TYPE_STACKTOSTACK 111")]
        public const int IF_TYPE_STACKTOSTACK = 111;

        [NativeTypeName("#define IF_TYPE_VIRTUALIPADDRESS 112")]
        public const int IF_TYPE_VIRTUALIPADDRESS = 112;

        [NativeTypeName("#define IF_TYPE_MPC 113")]
        public const int IF_TYPE_MPC = 113;

        [NativeTypeName("#define IF_TYPE_IPOVER_ATM 114")]
        public const int IF_TYPE_IPOVER_ATM = 114;

        [NativeTypeName("#define IF_TYPE_ISO88025_FIBER 115")]
        public const int IF_TYPE_ISO88025_FIBER = 115;

        [NativeTypeName("#define IF_TYPE_TDLC 116")]
        public const int IF_TYPE_TDLC = 116;

        [NativeTypeName("#define IF_TYPE_GIGABITETHERNET 117")]
        public const int IF_TYPE_GIGABITETHERNET = 117;

        [NativeTypeName("#define IF_TYPE_HDLC 118")]
        public const int IF_TYPE_HDLC = 118;

        [NativeTypeName("#define IF_TYPE_LAP_F 119")]
        public const int IF_TYPE_LAP_F = 119;

        [NativeTypeName("#define IF_TYPE_V37 120")]
        public const int IF_TYPE_V37 = 120;

        [NativeTypeName("#define IF_TYPE_X25_MLP 121")]
        public const int IF_TYPE_X25_MLP = 121;

        [NativeTypeName("#define IF_TYPE_X25_HUNTGROUP 122")]
        public const int IF_TYPE_X25_HUNTGROUP = 122;

        [NativeTypeName("#define IF_TYPE_TRANSPHDLC 123")]
        public const int IF_TYPE_TRANSPHDLC = 123;

        [NativeTypeName("#define IF_TYPE_INTERLEAVE 124")]
        public const int IF_TYPE_INTERLEAVE = 124;

        [NativeTypeName("#define IF_TYPE_FAST 125")]
        public const int IF_TYPE_FAST = 125;

        [NativeTypeName("#define IF_TYPE_IP 126")]
        public const int IF_TYPE_IP = 126;

        [NativeTypeName("#define IF_TYPE_DOCSCABLE_MACLAYER 127")]
        public const int IF_TYPE_DOCSCABLE_MACLAYER = 127;

        [NativeTypeName("#define IF_TYPE_DOCSCABLE_DOWNSTREAM 128")]
        public const int IF_TYPE_DOCSCABLE_DOWNSTREAM = 128;

        [NativeTypeName("#define IF_TYPE_DOCSCABLE_UPSTREAM 129")]
        public const int IF_TYPE_DOCSCABLE_UPSTREAM = 129;

        [NativeTypeName("#define IF_TYPE_A12MPPSWITCH 130")]
        public const int IF_TYPE_A12MPPSWITCH = 130;

        [NativeTypeName("#define IF_TYPE_TUNNEL 131")]
        public const int IF_TYPE_TUNNEL = 131;

        [NativeTypeName("#define IF_TYPE_COFFEE 132")]
        public const int IF_TYPE_COFFEE = 132;

        [NativeTypeName("#define IF_TYPE_CES 133")]
        public const int IF_TYPE_CES = 133;

        [NativeTypeName("#define IF_TYPE_ATM_SUBINTERFACE 134")]
        public const int IF_TYPE_ATM_SUBINTERFACE = 134;

        [NativeTypeName("#define IF_TYPE_L2_VLAN 135")]
        public const int IF_TYPE_L2_VLAN = 135;

        [NativeTypeName("#define IF_TYPE_L3_IPVLAN 136")]
        public const int IF_TYPE_L3_IPVLAN = 136;

        [NativeTypeName("#define IF_TYPE_L3_IPXVLAN 137")]
        public const int IF_TYPE_L3_IPXVLAN = 137;

        [NativeTypeName("#define IF_TYPE_DIGITALPOWERLINE 138")]
        public const int IF_TYPE_DIGITALPOWERLINE = 138;

        [NativeTypeName("#define IF_TYPE_MEDIAMAILOVERIP 139")]
        public const int IF_TYPE_MEDIAMAILOVERIP = 139;

        [NativeTypeName("#define IF_TYPE_DTM 140")]
        public const int IF_TYPE_DTM = 140;

        [NativeTypeName("#define IF_TYPE_DCN 141")]
        public const int IF_TYPE_DCN = 141;

        [NativeTypeName("#define IF_TYPE_IPFORWARD 142")]
        public const int IF_TYPE_IPFORWARD = 142;

        [NativeTypeName("#define IF_TYPE_MSDSL 143")]
        public const int IF_TYPE_MSDSL = 143;

        [NativeTypeName("#define IF_TYPE_IEEE1394 144")]
        public const int IF_TYPE_IEEE1394 = 144;

        [NativeTypeName("#define IF_TYPE_IF_GSN 145")]
        public const int IF_TYPE_IF_GSN = 145;

        [NativeTypeName("#define IF_TYPE_DVBRCC_MACLAYER 146")]
        public const int IF_TYPE_DVBRCC_MACLAYER = 146;

        [NativeTypeName("#define IF_TYPE_DVBRCC_DOWNSTREAM 147")]
        public const int IF_TYPE_DVBRCC_DOWNSTREAM = 147;

        [NativeTypeName("#define IF_TYPE_DVBRCC_UPSTREAM 148")]
        public const int IF_TYPE_DVBRCC_UPSTREAM = 148;

        [NativeTypeName("#define IF_TYPE_ATM_VIRTUAL 149")]
        public const int IF_TYPE_ATM_VIRTUAL = 149;

        [NativeTypeName("#define IF_TYPE_MPLS_TUNNEL 150")]
        public const int IF_TYPE_MPLS_TUNNEL = 150;

        [NativeTypeName("#define IF_TYPE_SRP 151")]
        public const int IF_TYPE_SRP = 151;

        [NativeTypeName("#define IF_TYPE_VOICEOVERATM 152")]
        public const int IF_TYPE_VOICEOVERATM = 152;

        [NativeTypeName("#define IF_TYPE_VOICEOVERFRAMERELAY 153")]
        public const int IF_TYPE_VOICEOVERFRAMERELAY = 153;

        [NativeTypeName("#define IF_TYPE_IDSL 154")]
        public const int IF_TYPE_IDSL = 154;

        [NativeTypeName("#define IF_TYPE_COMPOSITELINK 155")]
        public const int IF_TYPE_COMPOSITELINK = 155;

        [NativeTypeName("#define IF_TYPE_SS7_SIGLINK 156")]
        public const int IF_TYPE_SS7_SIGLINK = 156;

        [NativeTypeName("#define IF_TYPE_PROP_WIRELESS_P2P 157")]
        public const int IF_TYPE_PROP_WIRELESS_P2P = 157;

        [NativeTypeName("#define IF_TYPE_FR_FORWARD 158")]
        public const int IF_TYPE_FR_FORWARD = 158;

        [NativeTypeName("#define IF_TYPE_RFC1483 159")]
        public const int IF_TYPE_RFC1483 = 159;

        [NativeTypeName("#define IF_TYPE_USB 160")]
        public const int IF_TYPE_USB = 160;

        [NativeTypeName("#define IF_TYPE_IEEE8023AD_LAG 161")]
        public const int IF_TYPE_IEEE8023AD_LAG = 161;

        [NativeTypeName("#define IF_TYPE_BGP_POLICY_ACCOUNTING 162")]
        public const int IF_TYPE_BGP_POLICY_ACCOUNTING = 162;

        [NativeTypeName("#define IF_TYPE_FRF16_MFR_BUNDLE 163")]
        public const int IF_TYPE_FRF16_MFR_BUNDLE = 163;

        [NativeTypeName("#define IF_TYPE_H323_GATEKEEPER 164")]
        public const int IF_TYPE_H323_GATEKEEPER = 164;

        [NativeTypeName("#define IF_TYPE_H323_PROXY 165")]
        public const int IF_TYPE_H323_PROXY = 165;

        [NativeTypeName("#define IF_TYPE_MPLS 166")]
        public const int IF_TYPE_MPLS = 166;

        [NativeTypeName("#define IF_TYPE_MF_SIGLINK 167")]
        public const int IF_TYPE_MF_SIGLINK = 167;

        [NativeTypeName("#define IF_TYPE_HDSL2 168")]
        public const int IF_TYPE_HDSL2 = 168;

        [NativeTypeName("#define IF_TYPE_SHDSL 169")]
        public const int IF_TYPE_SHDSL = 169;

        [NativeTypeName("#define IF_TYPE_DS1_FDL 170")]
        public const int IF_TYPE_DS1_FDL = 170;

        [NativeTypeName("#define IF_TYPE_POS 171")]
        public const int IF_TYPE_POS = 171;

        [NativeTypeName("#define IF_TYPE_DVB_ASI_IN 172")]
        public const int IF_TYPE_DVB_ASI_IN = 172;

        [NativeTypeName("#define IF_TYPE_DVB_ASI_OUT 173")]
        public const int IF_TYPE_DVB_ASI_OUT = 173;

        [NativeTypeName("#define IF_TYPE_PLC 174")]
        public const int IF_TYPE_PLC = 174;

        [NativeTypeName("#define IF_TYPE_NFAS 175")]
        public const int IF_TYPE_NFAS = 175;

        [NativeTypeName("#define IF_TYPE_TR008 176")]
        public const int IF_TYPE_TR008 = 176;

        [NativeTypeName("#define IF_TYPE_GR303_RDT 177")]
        public const int IF_TYPE_GR303_RDT = 177;

        [NativeTypeName("#define IF_TYPE_GR303_IDT 178")]
        public const int IF_TYPE_GR303_IDT = 178;

        [NativeTypeName("#define IF_TYPE_ISUP 179")]
        public const int IF_TYPE_ISUP = 179;

        [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_MACLAYER 180")]
        public const int IF_TYPE_PROP_DOCS_WIRELESS_MACLAYER = 180;

        [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_DOWNSTREAM 181")]
        public const int IF_TYPE_PROP_DOCS_WIRELESS_DOWNSTREAM = 181;

        [NativeTypeName("#define IF_TYPE_PROP_DOCS_WIRELESS_UPSTREAM 182")]
        public const int IF_TYPE_PROP_DOCS_WIRELESS_UPSTREAM = 182;

        [NativeTypeName("#define IF_TYPE_HIPERLAN2 183")]
        public const int IF_TYPE_HIPERLAN2 = 183;

        [NativeTypeName("#define IF_TYPE_PROP_BWA_P2MP 184")]
        public const int IF_TYPE_PROP_BWA_P2MP = 184;

        [NativeTypeName("#define IF_TYPE_SONET_OVERHEAD_CHANNEL 185")]
        public const int IF_TYPE_SONET_OVERHEAD_CHANNEL = 185;

        [NativeTypeName("#define IF_TYPE_DIGITAL_WRAPPER_OVERHEAD_CHANNEL 186")]
        public const int IF_TYPE_DIGITAL_WRAPPER_OVERHEAD_CHANNEL = 186;

        [NativeTypeName("#define IF_TYPE_AAL2 187")]
        public const int IF_TYPE_AAL2 = 187;

        [NativeTypeName("#define IF_TYPE_RADIO_MAC 188")]
        public const int IF_TYPE_RADIO_MAC = 188;

        [NativeTypeName("#define IF_TYPE_ATM_RADIO 189")]
        public const int IF_TYPE_ATM_RADIO = 189;

        [NativeTypeName("#define IF_TYPE_IMT 190")]
        public const int IF_TYPE_IMT = 190;

        [NativeTypeName("#define IF_TYPE_MVL 191")]
        public const int IF_TYPE_MVL = 191;

        [NativeTypeName("#define IF_TYPE_REACH_DSL 192")]
        public const int IF_TYPE_REACH_DSL = 192;

        [NativeTypeName("#define IF_TYPE_FR_DLCI_ENDPT 193")]
        public const int IF_TYPE_FR_DLCI_ENDPT = 193;

        [NativeTypeName("#define IF_TYPE_ATM_VCI_ENDPT 194")]
        public const int IF_TYPE_ATM_VCI_ENDPT = 194;

        [NativeTypeName("#define IF_TYPE_OPTICAL_CHANNEL 195")]
        public const int IF_TYPE_OPTICAL_CHANNEL = 195;

        [NativeTypeName("#define IF_TYPE_OPTICAL_TRANSPORT 196")]
        public const int IF_TYPE_OPTICAL_TRANSPORT = 196;

        [NativeTypeName("#define IF_TYPE_IEEE80216_WMAN 237")]
        public const int IF_TYPE_IEEE80216_WMAN = 237;

        [NativeTypeName("#define IF_TYPE_WWANPP 243")]
        public const int IF_TYPE_WWANPP = 243;

        [NativeTypeName("#define IF_TYPE_WWANPP2 244")]
        public const int IF_TYPE_WWANPP2 = 244;

        [NativeTypeName("#define IF_TYPE_IEEE802154 259")]
        public const int IF_TYPE_IEEE802154 = 259;

        [NativeTypeName("#define IF_TYPE_XBOX_WIRELESS 281")]
        public const int IF_TYPE_XBOX_WIRELESS = 281;

        [NativeTypeName("#define MAX_IF_TYPE 281")]
        public const int MAX_IF_TYPE = 281;

        [NativeTypeName("#define IF_CHECK_NONE 0x00")]
        public const int IF_CHECK_NONE = 0x00;

        [NativeTypeName("#define IF_CHECK_MCAST 0x01")]
        public const int IF_CHECK_MCAST = 0x01;

        [NativeTypeName("#define IF_CHECK_SEND 0x02")]
        public const int IF_CHECK_SEND = 0x02;

        [NativeTypeName("#define IF_CONNECTION_DEDICATED 1")]
        public const int IF_CONNECTION_DEDICATED = 1;

        [NativeTypeName("#define IF_CONNECTION_PASSIVE 2")]
        public const int IF_CONNECTION_PASSIVE = 2;

        [NativeTypeName("#define IF_CONNECTION_DEMAND 3")]
        public const int IF_CONNECTION_DEMAND = 3;

        [NativeTypeName("#define IF_ADMIN_STATUS_UP 1")]
        public const int IF_ADMIN_STATUS_UP = 1;

        [NativeTypeName("#define IF_ADMIN_STATUS_DOWN 2")]
        public const int IF_ADMIN_STATUS_DOWN = 2;

        [NativeTypeName("#define IF_ADMIN_STATUS_TESTING 3")]
        public const int IF_ADMIN_STATUS_TESTING = 3;

        [NativeTypeName("#define MIB_IF_TYPE_OTHER 1")]
        public const int MIB_IF_TYPE_OTHER = 1;

        [NativeTypeName("#define MIB_IF_TYPE_ETHERNET 6")]
        public const int MIB_IF_TYPE_ETHERNET = 6;

        [NativeTypeName("#define MIB_IF_TYPE_TOKENRING 9")]
        public const int MIB_IF_TYPE_TOKENRING = 9;

        [NativeTypeName("#define MIB_IF_TYPE_FDDI 15")]
        public const int MIB_IF_TYPE_FDDI = 15;

        [NativeTypeName("#define MIB_IF_TYPE_PPP 23")]
        public const int MIB_IF_TYPE_PPP = 23;

        [NativeTypeName("#define MIB_IF_TYPE_LOOPBACK 24")]
        public const int MIB_IF_TYPE_LOOPBACK = 24;

        [NativeTypeName("#define MIB_IF_TYPE_SLIP 28")]
        public const int MIB_IF_TYPE_SLIP = 28;

        [NativeTypeName("#define MIB_IF_ADMIN_STATUS_UP 1")]
        public const int MIB_IF_ADMIN_STATUS_UP = 1;

        [NativeTypeName("#define MIB_IF_ADMIN_STATUS_DOWN 2")]
        public const int MIB_IF_ADMIN_STATUS_DOWN = 2;

        [NativeTypeName("#define MIB_IF_ADMIN_STATUS_TESTING 3")]
        public const int MIB_IF_ADMIN_STATUS_TESTING = 3;

        [NativeTypeName("#define MIB_IF_OPER_STATUS_NON_OPERATIONAL IF_OPER_STATUS_NON_OPERATIONAL")]
        public const _INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_NON_OPERATIONAL = _INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_NON_OPERATIONAL;

        [NativeTypeName("#define MIB_IF_OPER_STATUS_UNREACHABLE IF_OPER_STATUS_UNREACHABLE")]
        public const _INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_UNREACHABLE = _INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_UNREACHABLE;

        [NativeTypeName("#define MIB_IF_OPER_STATUS_DISCONNECTED IF_OPER_STATUS_DISCONNECTED")]
        public const _INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_DISCONNECTED = _INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_DISCONNECTED;

        [NativeTypeName("#define MIB_IF_OPER_STATUS_CONNECTING IF_OPER_STATUS_CONNECTING")]
        public const _INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_CONNECTING = _INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_CONNECTING;

        [NativeTypeName("#define MIB_IF_OPER_STATUS_CONNECTED IF_OPER_STATUS_CONNECTED")]
        public const _INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_CONNECTED = _INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_CONNECTED;

        [NativeTypeName("#define MIB_IF_OPER_STATUS_OPERATIONAL IF_OPER_STATUS_OPERATIONAL")]
        public const _INTERNAL_IF_OPER_STATUS MIB_IF_OPER_STATUS_OPERATIONAL = _INTERNAL_IF_OPER_STATUS.IF_OPER_STATUS_OPERATIONAL;

        [NativeTypeName("#define IPRTRMGR_PID 10000")]
        public const int IPRTRMGR_PID = 10000;

        [NativeTypeName("#define ANY_SIZE 1")]
        public const int ANY_SIZE = 1;

        [NativeTypeName("#define IF_NUMBER 0")]
        public const int IF_NUMBER = 0;

        [NativeTypeName("#define IF_TABLE (IF_NUMBER          + 1)")]
        public const int IF_TABLE = (0 + 1);

        [NativeTypeName("#define IF_ROW (IF_TABLE           + 1)")]
        public const int IF_ROW = ((0 + 1) + 1);

        [NativeTypeName("#define IP_STATS (IF_ROW             + 1)")]
        public const int IP_STATS = (((0 + 1) + 1) + 1);

        [NativeTypeName("#define IP_ADDRTABLE (IP_STATS           + 1)")]
        public const int IP_ADDRTABLE = ((((0 + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_ADDRROW (IP_ADDRTABLE       + 1)")]
        public const int IP_ADDRROW = (((((0 + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_FORWARDNUMBER (IP_ADDRROW         + 1)")]
        public const int IP_FORWARDNUMBER = ((((((0 + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_FORWARDTABLE (IP_FORWARDNUMBER   + 1)")]
        public const int IP_FORWARDTABLE = (((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_FORWARDROW (IP_FORWARDTABLE    + 1)")]
        public const int IP_FORWARDROW = ((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_NETTABLE (IP_FORWARDROW      + 1)")]
        public const int IP_NETTABLE = (((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP_NETROW (IP_NETTABLE        + 1)")]
        public const int IP_NETROW = ((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ICMP_STATS (IP_NETROW          + 1)")]
        public const int ICMP_STATS = (((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define TCP_STATS (ICMP_STATS         + 1)")]
        public const int TCP_STATS = ((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define TCP_TABLE (TCP_STATS          + 1)")]
        public const int TCP_TABLE = (((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define TCP_ROW (TCP_TABLE          + 1)")]
        public const int TCP_ROW = ((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define UDP_STATS (TCP_ROW            + 1)")]
        public const int UDP_STATS = (((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define UDP_TABLE (UDP_STATS          + 1)")]
        public const int UDP_TABLE = ((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define UDP_ROW (UDP_TABLE          + 1)")]
        public const int UDP_ROW = (((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_MFE (UDP_ROW            + 1)")]
        public const int MCAST_MFE = ((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_MFE_STATS (MCAST_MFE          + 1)")]
        public const int MCAST_MFE_STATS = (((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define BEST_IF (MCAST_MFE_STATS    + 1)")]
        public const int BEST_IF = ((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define BEST_ROUTE (BEST_IF            + 1)")]
        public const int BEST_ROUTE = (((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define PROXY_ARP (BEST_ROUTE         + 1)")]
        public const int PROXY_ARP = ((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_IF_ENTRY (PROXY_ARP          + 1)")]
        public const int MCAST_IF_ENTRY = (((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_GLOBAL (MCAST_IF_ENTRY     + 1)")]
        public const int MCAST_GLOBAL = ((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IF_STATUS (MCAST_GLOBAL       + 1)")]
        public const int IF_STATUS = (((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_BOUNDARY (IF_STATUS          + 1)")]
        public const int MCAST_BOUNDARY = ((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_SCOPE (MCAST_BOUNDARY     + 1)")]
        public const int MCAST_SCOPE = (((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define DEST_MATCHING (MCAST_SCOPE        + 1)")]
        public const int DEST_MATCHING = ((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define DEST_LONGER (DEST_MATCHING      + 1)")]
        public const int DEST_LONGER = (((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define DEST_SHORTER (DEST_LONGER        + 1)")]
        public const int DEST_SHORTER = ((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ROUTE_MATCHING (DEST_SHORTER       + 1)")]
        public const int ROUTE_MATCHING = (((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ROUTE_LONGER (ROUTE_MATCHING     + 1)")]
        public const int ROUTE_LONGER = ((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ROUTE_SHORTER (ROUTE_LONGER       + 1)")]
        public const int ROUTE_SHORTER = (((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define ROUTE_STATE (ROUTE_SHORTER      + 1)")]
        public const int ROUTE_STATE = ((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define MCAST_MFE_STATS_EX (ROUTE_STATE        + 1)")]
        public const int MCAST_MFE_STATS_EX = (((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define IP6_STATS (MCAST_MFE_STATS_EX + 1)")]
        public const int IP6_STATS = ((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define UDP6_STATS (IP6_STATS          + 1)")]
        public const int UDP6_STATS = (((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define TCP6_STATS (UDP6_STATS         + 1)")]
        public const int TCP6_STATS = ((((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define NUMBER_OF_EXPORTED_VARIABLES (TCP6_STATS + 1)")]
        public const int NUMBER_OF_EXPORTED_VARIABLES = (((((((((((((((((((((((((((((((((((((((0 + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1) + 1);

        [NativeTypeName("#define NET_IF_COMPARTMENT_ID_UNSPECIFIED (NET_IF_COMPARTMENT_ID)0")]
        public const uint NET_IF_COMPARTMENT_ID_UNSPECIFIED = (uint)(0);

        [NativeTypeName("#define NET_IF_COMPARTMENT_ID_PRIMARY (NET_IF_COMPARTMENT_ID)1")]
        public const uint NET_IF_COMPARTMENT_ID_PRIMARY = (uint)(1);

        [NativeTypeName("#define NET_IF_OPER_STATUS_DOWN_NOT_AUTHENTICATED 0x00000001")]
        public const int NET_IF_OPER_STATUS_DOWN_NOT_AUTHENTICATED = 0x00000001;

        [NativeTypeName("#define NET_IF_OPER_STATUS_DOWN_NOT_MEDIA_CONNECTED 0x00000002")]
        public const int NET_IF_OPER_STATUS_DOWN_NOT_MEDIA_CONNECTED = 0x00000002;

        [NativeTypeName("#define NET_IF_OPER_STATUS_DORMANT_PAUSED 0x00000004")]
        public const int NET_IF_OPER_STATUS_DORMANT_PAUSED = 0x00000004;

        [NativeTypeName("#define NET_IF_OPER_STATUS_DORMANT_LOW_POWER 0x00000008")]
        public const int NET_IF_OPER_STATUS_DORMANT_LOW_POWER = 0x00000008;

        [NativeTypeName("#define NET_IF_COMPARTMENT_SCOPE_UNSPECIFIED (NET_IF_COMPARTMENT_SCOPE)0")]
        public const uint NET_IF_COMPARTMENT_SCOPE_UNSPECIFIED = (uint)(0);

        [NativeTypeName("#define NET_IF_COMPARTMENT_SCOPE_ALL ((NET_IF_COMPARTMENT_SCOPE)-1)")]
        public const uint NET_IF_COMPARTMENT_SCOPE_ALL = unchecked((uint)(-1));

        [NativeTypeName("#define NET_IF_OID_IF_ALIAS 0x00000001")]
        public const int NET_IF_OID_IF_ALIAS = 0x00000001;

        [NativeTypeName("#define NET_IF_OID_COMPARTMENT_ID 0x00000002")]
        public const int NET_IF_OID_COMPARTMENT_ID = 0x00000002;

        [NativeTypeName("#define NET_IF_OID_NETWORK_GUID 0x00000003")]
        public const int NET_IF_OID_NETWORK_GUID = 0x00000003;

        [NativeTypeName("#define NET_IF_OID_IF_ENTRY 0x00000004")]
        public const int NET_IF_OID_IF_ENTRY = 0x00000004;

        [NativeTypeName("#define NET_SITEID_UNSPECIFIED (0)")]
        public const int NET_SITEID_UNSPECIFIED = (0);

        [NativeTypeName("#define NET_SITEID_MAXUSER (0x07ffffff)")]
        public const int NET_SITEID_MAXUSER = (0x07ffffff);

        [NativeTypeName("#define NET_SITEID_MAXSYSTEM (0x0fffffff)")]
        public const int NET_SITEID_MAXSYSTEM = (0x0fffffff);

        [NativeTypeName("#define NET_IFINDEX_UNSPECIFIED (NET_IFINDEX)(0)")]
        public const uint NET_IFINDEX_UNSPECIFIED = (uint)(0);

        [NativeTypeName("#define NET_IFLUID_UNSPECIFIED (0)")]
        public const int NET_IFLUID_UNSPECIFIED = (0);

        [NativeTypeName("#define IFI_UNSPECIFIED NET_IFINDEX_UNSPECIFIED")]
        public const uint IFI_UNSPECIFIED = (uint)(0);

        [NativeTypeName("#define NIIF_HARDWARE_INTERFACE 0x00000001")]
        public const int NIIF_HARDWARE_INTERFACE = 0x00000001;

        [NativeTypeName("#define NIIF_FILTER_INTERFACE 0x00000002")]
        public const int NIIF_FILTER_INTERFACE = 0x00000002;

        [NativeTypeName("#define NIIF_NDIS_RESERVED1 0x00000004")]
        public const int NIIF_NDIS_RESERVED1 = 0x00000004;

        [NativeTypeName("#define NIIF_NDIS_RESERVED2 0x00000008")]
        public const int NIIF_NDIS_RESERVED2 = 0x00000008;

        [NativeTypeName("#define NIIF_NDIS_RESERVED3 0x00000010")]
        public const int NIIF_NDIS_RESERVED3 = 0x00000010;

        [NativeTypeName("#define NIIF_NDIS_WDM_INTERFACE 0x00000020")]
        public const int NIIF_NDIS_WDM_INTERFACE = 0x00000020;

        [NativeTypeName("#define NIIF_NDIS_ENDPOINT_INTERFACE 0x00000040")]
        public const int NIIF_NDIS_ENDPOINT_INTERFACE = 0x00000040;

        [NativeTypeName("#define NIIF_NDIS_ISCSI_INTERFACE 0x00000080")]
        public const int NIIF_NDIS_ISCSI_INTERFACE = 0x00000080;

        [NativeTypeName("#define NIIF_NDIS_RESERVED4 0x00000100")]
        public const int NIIF_NDIS_RESERVED4 = 0x00000100;

        [NativeTypeName("#define NIIF_WAN_TUNNEL_TYPE_UNKNOWN ((ULONG)(-1))")]
        public const uint NIIF_WAN_TUNNEL_TYPE_UNKNOWN = unchecked((uint)(-1));

        [NativeTypeName("#define NET_IF_LINK_SPEED_UNKNOWN ((ULONG64)(-1))")]
        public const ulong NET_IF_LINK_SPEED_UNKNOWN = unchecked((ulong)(-1));

        [NativeTypeName("#define NIIF_BUS_NUMBER_UNKNOWN ((ULONG)(-1))")]
        public const uint NIIF_BUS_NUMBER_UNKNOWN = unchecked((uint)(-1));

        [NativeTypeName("#define NIIF_SLOT_NUMBER_UNKNOWN ((ULONG)(-1))")]
        public const uint NIIF_SLOT_NUMBER_UNKNOWN = unchecked((uint)(-1));

        [NativeTypeName("#define NIIF_FUNCTION_NUMBER_UNKNOWN ((ULONG)(-1))")]
        public const uint NIIF_FUNCTION_NUMBER_UNKNOWN = unchecked((uint)(-1));

        [NativeTypeName("#define IF_MAX_STRING_SIZE 256")]
        public const int IF_MAX_STRING_SIZE = 256;

        [NativeTypeName("#define IF_MAX_PHYS_ADDRESS_LENGTH 32")]
        public const int IF_MAX_PHYS_ADDRESS_LENGTH = 32;

        [NativeTypeName("#define MAXLEN_PHYSADDR 8")]
        public const int MAXLEN_PHYSADDR = 8;

        [NativeTypeName("#define MAXLEN_IFDESCR 256")]
        public const int MAXLEN_IFDESCR = 256;

        [NativeTypeName("#define MAX_INTERFACE_NAME_LEN 256")]
        public const int MAX_INTERFACE_NAME_LEN = 256;

        [NativeTypeName("#define NlpoOther IpPrefixOriginOther")]
        public const NL_PREFIX_ORIGIN NlpoOther = NL_PREFIX_ORIGIN.IpPrefixOriginOther;

        [NativeTypeName("#define NlpoManual IpPrefixOriginManual")]
        public const NL_PREFIX_ORIGIN NlpoManual = NL_PREFIX_ORIGIN.IpPrefixOriginManual;

        [NativeTypeName("#define NlpoWellKnown IpPrefixOriginWellKnown")]
        public const NL_PREFIX_ORIGIN NlpoWellKnown = NL_PREFIX_ORIGIN.IpPrefixOriginWellKnown;

        [NativeTypeName("#define NlpoDhcp IpPrefixOriginDhcp")]
        public const NL_PREFIX_ORIGIN NlpoDhcp = NL_PREFIX_ORIGIN.IpPrefixOriginDhcp;

        [NativeTypeName("#define NlpoRouterAdvertisement IpPrefixOriginRouterAdvertisement")]
        public const NL_PREFIX_ORIGIN NlpoRouterAdvertisement = NL_PREFIX_ORIGIN.IpPrefixOriginRouterAdvertisement;

        [NativeTypeName("#define NL_MAX_METRIC_COMPONENT ((((ULONG) 1) << 31) - 1)")]
        public const uint NL_MAX_METRIC_COMPONENT = ((((uint)(1)) << 31) - 1);

        [NativeTypeName("#define NET_IF_CURRENT_SESSION ((ULONG)-1)")]
        public const uint NET_IF_CURRENT_SESSION = unchecked((uint)(-1));

        [NativeTypeName("#define MIB_IPADDR_PRIMARY 0x0001")]
        public const int MIB_IPADDR_PRIMARY = 0x0001;

        [NativeTypeName("#define MIB_IPADDR_DYNAMIC 0x0004")]
        public const int MIB_IPADDR_DYNAMIC = 0x0004;

        [NativeTypeName("#define MIB_IPADDR_DISCONNECTED 0x0008")]
        public const int MIB_IPADDR_DISCONNECTED = 0x0008;

        [NativeTypeName("#define MIB_IPADDR_DELETED 0x0040")]
        public const int MIB_IPADDR_DELETED = 0x0040;

        [NativeTypeName("#define MIB_IPADDR_TRANSIENT 0x0080")]
        public const int MIB_IPADDR_TRANSIENT = 0x0080;

        [NativeTypeName("#define MIB_IPADDR_DNS_ELIGIBLE 0X0100")]
        public const int MIB_IPADDR_DNS_ELIGIBLE = 0X0100;

        [NativeTypeName("#define MIB_IPROUTE_TYPE_OTHER 1")]
        public const int MIB_IPROUTE_TYPE_OTHER = 1;

        [NativeTypeName("#define MIB_IPROUTE_TYPE_INVALID 2")]
        public const int MIB_IPROUTE_TYPE_INVALID = 2;

        [NativeTypeName("#define MIB_IPROUTE_TYPE_DIRECT 3")]
        public const int MIB_IPROUTE_TYPE_DIRECT = 3;

        [NativeTypeName("#define MIB_IPROUTE_TYPE_INDIRECT 4")]
        public const int MIB_IPROUTE_TYPE_INDIRECT = 4;

        [NativeTypeName("#define MIB_IPROUTE_METRIC_UNUSED (DWORD)-1")]
        public const uint MIB_IPROUTE_METRIC_UNUSED = unchecked((uint)(-1));

        [NativeTypeName("#define MIB_USE_CURRENT_TTL ((DWORD)-1)")]
        public const uint MIB_USE_CURRENT_TTL = unchecked((uint)(-1));

        [NativeTypeName("#define MIB_USE_CURRENT_FORWARDING ((DWORD)-1)")]
        public const uint MIB_USE_CURRENT_FORWARDING = unchecked((uint)(-1));

        [NativeTypeName("#define ICMP6_INFOMSG_MASK 0x80")]
        public const int ICMP6_INFOMSG_MASK = 0x80;

        [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE, rgmioOutInfo[0]))")]
        public static uint SIZEOF_BASIC_MIB_MFE => unchecked((uint)(((int)(Marshal.OffsetOf<_MIB_IPMCAST_MFE>("rgmioOutInfo")))));

        [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE_STATS (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE_STATS, rgmiosOutStats[0]))")]
        public static uint SIZEOF_BASIC_MIB_MFE_STATS => unchecked((uint)(((int)(Marshal.OffsetOf<_MIB_IPMCAST_MFE_STATS>("rgmiosOutStats")))));

        [NativeTypeName("#define SIZEOF_BASIC_MIB_MFE_STATS_EX (ULONG)(FIELD_OFFSET(MIB_IPMCAST_MFE_STATS_EX, rgmiosOutStats[0]))")]
        public static uint SIZEOF_BASIC_MIB_MFE_STATS_EX => unchecked((uint)(((int)(Marshal.OffsetOf<_MIB_IPMCAST_MFE_STATS_EX_XP>("rgmiosOutStats")))));

        [NativeTypeName("#define TCPIP_OWNING_MODULE_SIZE 16")]
        public const int TCPIP_OWNING_MODULE_SIZE = 16;

        [NativeTypeName("#define MIB_TCP_MAXCONN_DYNAMIC ((ULONG)-1)")]
        public const uint MIB_TCP_MAXCONN_DYNAMIC = unchecked((uint)(-1));

        [NativeTypeName("#define MAX_SCOPE_NAME_LEN 255")]
        public const int MAX_SCOPE_NAME_LEN = 255;

        [NativeTypeName("#define MAX_MIB_OFFSET 8")]
        public const int MAX_MIB_OFFSET = 8;

        [NativeTypeName("#define IP_EXPORT_INCLUDED 1")]
        public const int IP_EXPORT_INCLUDED = 1;

        [NativeTypeName("#define MAX_ADAPTER_NAME 128")]
        public const int MAX_ADAPTER_NAME = 128;

        [NativeTypeName("#define IP_STATUS_BASE 11000")]
        public const int IP_STATUS_BASE = 11000;

        [NativeTypeName("#define IP_SUCCESS 0")]
        public const int IP_SUCCESS = 0;

        [NativeTypeName("#define IP_BUF_TOO_SMALL (IP_STATUS_BASE + 1)")]
        public const int IP_BUF_TOO_SMALL = (11000 + 1);

        [NativeTypeName("#define IP_DEST_NET_UNREACHABLE (IP_STATUS_BASE + 2)")]
        public const int IP_DEST_NET_UNREACHABLE = (11000 + 2);

        [NativeTypeName("#define IP_DEST_HOST_UNREACHABLE (IP_STATUS_BASE + 3)")]
        public const int IP_DEST_HOST_UNREACHABLE = (11000 + 3);

        [NativeTypeName("#define IP_DEST_PROT_UNREACHABLE (IP_STATUS_BASE + 4)")]
        public const int IP_DEST_PROT_UNREACHABLE = (11000 + 4);

        [NativeTypeName("#define IP_DEST_PORT_UNREACHABLE (IP_STATUS_BASE + 5)")]
        public const int IP_DEST_PORT_UNREACHABLE = (11000 + 5);

        [NativeTypeName("#define IP_NO_RESOURCES (IP_STATUS_BASE + 6)")]
        public const int IP_NO_RESOURCES = (11000 + 6);

        [NativeTypeName("#define IP_BAD_OPTION (IP_STATUS_BASE + 7)")]
        public const int IP_BAD_OPTION = (11000 + 7);

        [NativeTypeName("#define IP_HW_ERROR (IP_STATUS_BASE + 8)")]
        public const int IP_HW_ERROR = (11000 + 8);

        [NativeTypeName("#define IP_PACKET_TOO_BIG (IP_STATUS_BASE + 9)")]
        public const int IP_PACKET_TOO_BIG = (11000 + 9);

        [NativeTypeName("#define IP_REQ_TIMED_OUT (IP_STATUS_BASE + 10)")]
        public const int IP_REQ_TIMED_OUT = (11000 + 10);

        [NativeTypeName("#define IP_BAD_REQ (IP_STATUS_BASE + 11)")]
        public const int IP_BAD_REQ = (11000 + 11);

        [NativeTypeName("#define IP_BAD_ROUTE (IP_STATUS_BASE + 12)")]
        public const int IP_BAD_ROUTE = (11000 + 12);

        [NativeTypeName("#define IP_TTL_EXPIRED_TRANSIT (IP_STATUS_BASE + 13)")]
        public const int IP_TTL_EXPIRED_TRANSIT = (11000 + 13);

        [NativeTypeName("#define IP_TTL_EXPIRED_REASSEM (IP_STATUS_BASE + 14)")]
        public const int IP_TTL_EXPIRED_REASSEM = (11000 + 14);

        [NativeTypeName("#define IP_PARAM_PROBLEM (IP_STATUS_BASE + 15)")]
        public const int IP_PARAM_PROBLEM = (11000 + 15);

        [NativeTypeName("#define IP_SOURCE_QUENCH (IP_STATUS_BASE + 16)")]
        public const int IP_SOURCE_QUENCH = (11000 + 16);

        [NativeTypeName("#define IP_OPTION_TOO_BIG (IP_STATUS_BASE + 17)")]
        public const int IP_OPTION_TOO_BIG = (11000 + 17);

        [NativeTypeName("#define IP_BAD_DESTINATION (IP_STATUS_BASE + 18)")]
        public const int IP_BAD_DESTINATION = (11000 + 18);

        [NativeTypeName("#define IP_DEST_NO_ROUTE (IP_STATUS_BASE + 2)")]
        public const int IP_DEST_NO_ROUTE = (11000 + 2);

        [NativeTypeName("#define IP_DEST_ADDR_UNREACHABLE (IP_STATUS_BASE + 3)")]
        public const int IP_DEST_ADDR_UNREACHABLE = (11000 + 3);

        [NativeTypeName("#define IP_DEST_PROHIBITED (IP_STATUS_BASE + 4)")]
        public const int IP_DEST_PROHIBITED = (11000 + 4);

        [NativeTypeName("#define IP_HOP_LIMIT_EXCEEDED (IP_STATUS_BASE + 13)")]
        public const int IP_HOP_LIMIT_EXCEEDED = (11000 + 13);

        [NativeTypeName("#define IP_REASSEMBLY_TIME_EXCEEDED (IP_STATUS_BASE + 14)")]
        public const int IP_REASSEMBLY_TIME_EXCEEDED = (11000 + 14);

        [NativeTypeName("#define IP_PARAMETER_PROBLEM (IP_STATUS_BASE + 15)")]
        public const int IP_PARAMETER_PROBLEM = (11000 + 15);

        [NativeTypeName("#define IP_DEST_UNREACHABLE (IP_STATUS_BASE + 40)")]
        public const int IP_DEST_UNREACHABLE = (11000 + 40);

        [NativeTypeName("#define IP_TIME_EXCEEDED (IP_STATUS_BASE + 41)")]
        public const int IP_TIME_EXCEEDED = (11000 + 41);

        [NativeTypeName("#define IP_BAD_HEADER (IP_STATUS_BASE + 42)")]
        public const int IP_BAD_HEADER = (11000 + 42);

        [NativeTypeName("#define IP_UNRECOGNIZED_NEXT_HEADER (IP_STATUS_BASE + 43)")]
        public const int IP_UNRECOGNIZED_NEXT_HEADER = (11000 + 43);

        [NativeTypeName("#define IP_ICMP_ERROR (IP_STATUS_BASE + 44)")]
        public const int IP_ICMP_ERROR = (11000 + 44);

        [NativeTypeName("#define IP_DEST_SCOPE_MISMATCH (IP_STATUS_BASE + 45)")]
        public const int IP_DEST_SCOPE_MISMATCH = (11000 + 45);

        [NativeTypeName("#define IP_ADDR_DELETED (IP_STATUS_BASE + 19)")]
        public const int IP_ADDR_DELETED = (11000 + 19);

        [NativeTypeName("#define IP_SPEC_MTU_CHANGE (IP_STATUS_BASE + 20)")]
        public const int IP_SPEC_MTU_CHANGE = (11000 + 20);

        [NativeTypeName("#define IP_MTU_CHANGE (IP_STATUS_BASE + 21)")]
        public const int IP_MTU_CHANGE = (11000 + 21);

        [NativeTypeName("#define IP_UNLOAD (IP_STATUS_BASE + 22)")]
        public const int IP_UNLOAD = (11000 + 22);

        [NativeTypeName("#define IP_ADDR_ADDED (IP_STATUS_BASE + 23)")]
        public const int IP_ADDR_ADDED = (11000 + 23);

        [NativeTypeName("#define IP_MEDIA_CONNECT (IP_STATUS_BASE + 24)")]
        public const int IP_MEDIA_CONNECT = (11000 + 24);

        [NativeTypeName("#define IP_MEDIA_DISCONNECT (IP_STATUS_BASE + 25)")]
        public const int IP_MEDIA_DISCONNECT = (11000 + 25);

        [NativeTypeName("#define IP_BIND_ADAPTER (IP_STATUS_BASE + 26)")]
        public const int IP_BIND_ADAPTER = (11000 + 26);

        [NativeTypeName("#define IP_UNBIND_ADAPTER (IP_STATUS_BASE + 27)")]
        public const int IP_UNBIND_ADAPTER = (11000 + 27);

        [NativeTypeName("#define IP_DEVICE_DOES_NOT_EXIST (IP_STATUS_BASE + 28)")]
        public const int IP_DEVICE_DOES_NOT_EXIST = (11000 + 28);

        [NativeTypeName("#define IP_DUPLICATE_ADDRESS (IP_STATUS_BASE + 29)")]
        public const int IP_DUPLICATE_ADDRESS = (11000 + 29);

        [NativeTypeName("#define IP_INTERFACE_METRIC_CHANGE (IP_STATUS_BASE + 30)")]
        public const int IP_INTERFACE_METRIC_CHANGE = (11000 + 30);

        [NativeTypeName("#define IP_RECONFIG_SECFLTR (IP_STATUS_BASE + 31)")]
        public const int IP_RECONFIG_SECFLTR = (11000 + 31);

        [NativeTypeName("#define IP_NEGOTIATING_IPSEC (IP_STATUS_BASE + 32)")]
        public const int IP_NEGOTIATING_IPSEC = (11000 + 32);

        [NativeTypeName("#define IP_INTERFACE_WOL_CAPABILITY_CHANGE (IP_STATUS_BASE + 33)")]
        public const int IP_INTERFACE_WOL_CAPABILITY_CHANGE = (11000 + 33);

        [NativeTypeName("#define IP_DUPLICATE_IPADD (IP_STATUS_BASE + 34)")]
        public const int IP_DUPLICATE_IPADD = (11000 + 34);

        [NativeTypeName("#define IP_GENERAL_FAILURE (IP_STATUS_BASE + 50)")]
        public const int IP_GENERAL_FAILURE = (11000 + 50);

        [NativeTypeName("#define MAX_IP_STATUS IP_GENERAL_FAILURE")]
        public const int MAX_IP_STATUS = (11000 + 50);

        [NativeTypeName("#define IP_PENDING (IP_STATUS_BASE + 255)")]
        public const int IP_PENDING = (11000 + 255);

        [NativeTypeName("#define IP_FLAG_REVERSE 0x1")]
        public const int IP_FLAG_REVERSE = 0x1;

        [NativeTypeName("#define IP_FLAG_DF 0x2")]
        public const int IP_FLAG_DF = 0x2;

        [NativeTypeName("#define IP_OPT_EOL 0")]
        public const int IP_OPT_EOL = 0;

        [NativeTypeName("#define IP_OPT_NOP 1")]
        public const int IP_OPT_NOP = 1;

        [NativeTypeName("#define IP_OPT_SECURITY 0x82")]
        public const int IP_OPT_SECURITY = 0x82;

        [NativeTypeName("#define IP_OPT_LSRR 0x83")]
        public const int IP_OPT_LSRR = 0x83;

        [NativeTypeName("#define IP_OPT_SSRR 0x89")]
        public const int IP_OPT_SSRR = 0x89;

        [NativeTypeName("#define IP_OPT_RR 0x7")]
        public const int IP_OPT_RR = 0x7;

        [NativeTypeName("#define IP_OPT_TS 0x44")]
        public const int IP_OPT_TS = 0x44;

        [NativeTypeName("#define IP_OPT_SID 0x88")]
        public const int IP_OPT_SID = 0x88;

        [NativeTypeName("#define IP_OPT_ROUTER_ALERT 0x94")]
        public const int IP_OPT_ROUTER_ALERT = 0x94;

        [NativeTypeName("#define MAX_OPT_SIZE 40")]
        public const int MAX_OPT_SIZE = 40;

        [NativeTypeName("#define MAX_ADAPTER_DESCRIPTION_LENGTH 128")]
        public const int MAX_ADAPTER_DESCRIPTION_LENGTH = 128;

        [NativeTypeName("#define MAX_ADAPTER_NAME_LENGTH 256")]
        public const int MAX_ADAPTER_NAME_LENGTH = 256;

        [NativeTypeName("#define MAX_ADAPTER_ADDRESS_LENGTH 8")]
        public const int MAX_ADAPTER_ADDRESS_LENGTH = 8;

        [NativeTypeName("#define DEFAULT_MINIMUM_ENTITIES 32")]
        public const int DEFAULT_MINIMUM_ENTITIES = 32;

        [NativeTypeName("#define MAX_HOSTNAME_LEN 128")]
        public const int MAX_HOSTNAME_LEN = 128;

        [NativeTypeName("#define MAX_DOMAIN_NAME_LEN 128")]
        public const int MAX_DOMAIN_NAME_LEN = 128;

        [NativeTypeName("#define MAX_SCOPE_ID_LEN 256")]
        public const int MAX_SCOPE_ID_LEN = 256;

        [NativeTypeName("#define MAX_DHCPV6_DUID_LENGTH 130")]
        public const int MAX_DHCPV6_DUID_LENGTH = 130;

        [NativeTypeName("#define MAX_DNS_SUFFIX_STRING_LENGTH 256")]
        public const int MAX_DNS_SUFFIX_STRING_LENGTH = 256;

        [NativeTypeName("#define BROADCAST_NODETYPE 1")]
        public const int BROADCAST_NODETYPE = 1;

        [NativeTypeName("#define PEER_TO_PEER_NODETYPE 2")]
        public const int PEER_TO_PEER_NODETYPE = 2;

        [NativeTypeName("#define MIXED_NODETYPE 4")]
        public const int MIXED_NODETYPE = 4;

        [NativeTypeName("#define HYBRID_NODETYPE 8")]
        public const int HYBRID_NODETYPE = 8;

        [NativeTypeName("#define NET_STRING_IPV4_ADDRESS 0x00000001")]
        public const int NET_STRING_IPV4_ADDRESS = 0x00000001;

        [NativeTypeName("#define NET_STRING_IPV4_SERVICE 0x00000002")]
        public const int NET_STRING_IPV4_SERVICE = 0x00000002;

        [NativeTypeName("#define NET_STRING_IPV4_NETWORK 0x00000004")]
        public const int NET_STRING_IPV4_NETWORK = 0x00000004;

        [NativeTypeName("#define NET_STRING_IPV6_ADDRESS 0x00000008")]
        public const int NET_STRING_IPV6_ADDRESS = 0x00000008;

        [NativeTypeName("#define NET_STRING_IPV6_ADDRESS_NO_SCOPE 0x00000010")]
        public const int NET_STRING_IPV6_ADDRESS_NO_SCOPE = 0x00000010;

        [NativeTypeName("#define NET_STRING_IPV6_SERVICE 0x00000020")]
        public const int NET_STRING_IPV6_SERVICE = 0x00000020;

        [NativeTypeName("#define NET_STRING_IPV6_SERVICE_NO_SCOPE 0x00000040")]
        public const int NET_STRING_IPV6_SERVICE_NO_SCOPE = 0x00000040;

        [NativeTypeName("#define NET_STRING_IPV6_NETWORK 0x00000080")]
        public const int NET_STRING_IPV6_NETWORK = 0x00000080;

        [NativeTypeName("#define NET_STRING_NAMED_ADDRESS 0x00000100")]
        public const int NET_STRING_NAMED_ADDRESS = 0x00000100;

        [NativeTypeName("#define NET_STRING_NAMED_SERVICE 0x00000200")]
        public const int NET_STRING_NAMED_SERVICE = 0x00000200;

        [NativeTypeName("#define NET_STRING_IP_ADDRESS (NET_STRING_IPV4_ADDRESS   | \\\r\n                                           NET_STRING_IPV6_ADDRESS)")]
        public const int NET_STRING_IP_ADDRESS = (0x00000001 | 0x00000008);

        [NativeTypeName("#define NET_STRING_IP_ADDRESS_NO_SCOPE (NET_STRING_IPV4_ADDRESS   | \\\r\n                                           NET_STRING_IPV6_ADDRESS_NO_SCOPE)")]
        public const int NET_STRING_IP_ADDRESS_NO_SCOPE = (0x00000001 | 0x00000010);

        [NativeTypeName("#define NET_STRING_IP_SERVICE (NET_STRING_IPV4_SERVICE   | \\\r\n                                           NET_STRING_IPV6_SERVICE)")]
        public const int NET_STRING_IP_SERVICE = (0x00000002 | 0x00000020);

        [NativeTypeName("#define NET_STRING_IP_SERVICE_NO_SCOPE (NET_STRING_IPV4_SERVICE   | \\\r\n                                           NET_STRING_IPV6_SERVICE_NO_SCOPE)")]
        public const int NET_STRING_IP_SERVICE_NO_SCOPE = (0x00000002 | 0x00000040);

        [NativeTypeName("#define NET_STRING_IP_NETWORK (NET_STRING_IPV4_NETWORK   | \\\r\n                                           NET_STRING_IPV6_NETWORK)")]
        public const int NET_STRING_IP_NETWORK = (0x00000004 | 0x00000080);

        [NativeTypeName("#define NET_STRING_ANY_ADDRESS (NET_STRING_NAMED_ADDRESS  | \\\r\n                                           NET_STRING_IP_ADDRESS)")]
        public const int NET_STRING_ANY_ADDRESS = (0x00000100 | (0x00000001 | 0x00000008));

        [NativeTypeName("#define NET_STRING_ANY_ADDRESS_NO_SCOPE (NET_STRING_NAMED_ADDRESS  | \\\r\n                                           NET_STRING_IP_ADDRESS_NO_SCOPE)")]
        public const int NET_STRING_ANY_ADDRESS_NO_SCOPE = (0x00000100 | (0x00000001 | 0x00000010));

        [NativeTypeName("#define NET_STRING_ANY_SERVICE (NET_STRING_NAMED_SERVICE  | \\\r\n                                           NET_STRING_IP_SERVICE)")]
        public const int NET_STRING_ANY_SERVICE = (0x00000200 | (0x00000002 | 0x00000020));

        [NativeTypeName("#define NET_STRING_ANY_SERVICE_NO_SCOPE (NET_STRING_NAMED_SERVICE  | \\\r\n                                           NET_STRING_IP_SERVICE_NO_SCOPE)")]
        public const int NET_STRING_ANY_SERVICE_NO_SCOPE = (0x00000200 | (0x00000002 | 0x00000040));
    }
}
