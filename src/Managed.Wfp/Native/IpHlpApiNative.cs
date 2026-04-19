using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.IpHlpApi.Native
{
    public partial struct in_addr
    {
        [NativeTypeName("__AnonymousRecord_inaddr_L26_C9")]
        public _S_un_e__Union S_un;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _S_un_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_inaddr_L27_C17")]
            public _S_un_b_e__Struct S_un_b;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_inaddr_L28_C17")]
            public _S_un_w_e__Struct S_un_w;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint S_addr;

            public partial struct _S_un_b_e__Struct
            {
                [NativeTypeName("UCHAR")]
                public byte s_b1;

                [NativeTypeName("UCHAR")]
                public byte s_b2;

                [NativeTypeName("UCHAR")]
                public byte s_b3;

                [NativeTypeName("UCHAR")]
                public byte s_b4;
            }

            public partial struct _S_un_w_e__Struct
            {
                public ushort s_w1;

                public ushort s_w2;
            }
        }
    }

    public partial struct sockaddr
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort sa_family;

        [NativeTypeName("CHAR[14]")]
        public _sa_data_e__FixedBuffer sa_data;

        [InlineArray(14)]
        public partial struct _sa_data_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct _SOCKET_ADDRESS
    {
        [NativeTypeName("LPSOCKADDR")]
        public sockaddr* lpSockaddr;

        public int iSockaddrLength;
    }

    public partial struct _SOCKET_ADDRESS_LIST
    {
        public int iAddressCount;

        [NativeTypeName("SOCKET_ADDRESS[1]")]
        public _Address_e__FixedBuffer Address;

        public partial struct _Address_e__FixedBuffer
        {
            public _SOCKET_ADDRESS e0;

            [UnscopedRef]
            public ref _SOCKET_ADDRESS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_SOCKET_ADDRESS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _CSADDR_INFO
    {
        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS LocalAddr;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS RemoteAddr;

        public int iSocketType;

        public int iProtocol;
    }

    public partial struct sockaddr_storage
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort ss_family;

        [NativeTypeName("CHAR[6]")]
        public ___ss_pad1_e__FixedBuffer __ss_pad1;

        [NativeTypeName("long long")]
        public long __ss_align;

        [NativeTypeName("CHAR[112]")]
        public ___ss_pad2_e__FixedBuffer __ss_pad2;

        [InlineArray(6)]
        public partial struct ___ss_pad1_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(112)]
        public partial struct ___ss_pad2_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public partial struct sockaddr_storage_xp
    {
        public short ss_family;

        [NativeTypeName("CHAR[6]")]
        public ___ss_pad1_e__FixedBuffer __ss_pad1;

        [NativeTypeName("long long")]
        public long __ss_align;

        [NativeTypeName("CHAR[112]")]
        public ___ss_pad2_e__FixedBuffer __ss_pad2;

        [InlineArray(6)]
        public partial struct ___ss_pad1_e__FixedBuffer
        {
            public sbyte e0;
        }

        [InlineArray(112)]
        public partial struct ___ss_pad2_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public enum IPPROTO
    {
        IPPROTO_HOPOPTS = 0,
        IPPROTO_ICMP = 1,
        IPPROTO_IGMP = 2,
        IPPROTO_GGP = 3,
        IPPROTO_IPV4 = 4,
        IPPROTO_ST = 5,
        IPPROTO_TCP = 6,
        IPPROTO_CBT = 7,
        IPPROTO_EGP = 8,
        IPPROTO_IGP = 9,
        IPPROTO_PUP = 12,
        IPPROTO_UDP = 17,
        IPPROTO_IDP = 22,
        IPPROTO_RDP = 27,
        IPPROTO_IPV6 = 41,
        IPPROTO_ROUTING = 43,
        IPPROTO_FRAGMENT = 44,
        IPPROTO_ESP = 50,
        IPPROTO_AH = 51,
        IPPROTO_ICMPV6 = 58,
        IPPROTO_NONE = 59,
        IPPROTO_DSTOPTS = 60,
        IPPROTO_ND = 77,
        IPPROTO_ICLFXBM = 78,
        IPPROTO_PIM = 103,
        IPPROTO_PGM = 113,
        IPPROTO_L2TP = 115,
        IPPROTO_SCTP = 132,
        IPPROTO_RAW = 255,
        IPPROTO_MAX = 256,
        IPPROTO_RESERVED_RAW = 257,
        IPPROTO_RESERVED_IPSEC = 258,
        IPPROTO_RESERVED_IPSECOFFLOAD = 259,
        IPPROTO_RESERVED_WNV = 260,
        IPPROTO_RESERVED_MAX = 261,
    }

    public enum SCOPE_LEVEL
    {
        ScopeLevelInterface = 1,
        ScopeLevelLink = 2,
        ScopeLevelSubnet = 3,
        ScopeLevelAdmin = 4,
        ScopeLevelSite = 5,
        ScopeLevelOrganization = 8,
        ScopeLevelGlobal = 14,
        ScopeLevelCount = 16,
    }

    public partial struct SCOPE_ID
    {
        [NativeTypeName("__AnonymousRecord_ws2def_L629_C5")]
        public _Anonymous_e__Union Anonymous;

        public uint Zone
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous.Zone;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.Zone = value;
            }
        }

        public uint Level
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous.Level;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.Level = value;
            }
        }

        [UnscopedRef]
        public ref uint Value
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_ws2def_L630_C9")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint Value;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("ULONG : 28")]
                public uint Zone
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0xFFFFFFFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0xFFFFFFFu) | (value & 0xFFFFFFFu);
                    }
                }

                [NativeTypeName("ULONG : 4")]
                public uint Level
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 28) & 0xFu;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0xFu << 28)) | ((value & 0xFu) << 28);
                    }
                }
            }
        }
    }

    public partial struct sockaddr_in
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort sin_family;

        public ushort sin_port;

        public in_addr sin_addr;

        [NativeTypeName("CHAR[8]")]
        public _sin_zero_e__FixedBuffer sin_zero;

        [InlineArray(8)]
        public partial struct _sin_zero_e__FixedBuffer
        {
            public sbyte e0;
        }
    }

    public unsafe partial struct _WSABUF
    {
        [NativeTypeName("ULONG")]
        public uint len;

        [NativeTypeName("CHAR *")]
        public sbyte* buf;
    }

    public unsafe partial struct _WSAMSG
    {
        [NativeTypeName("LPSOCKADDR")]
        public sockaddr* name;

        public int namelen;

        [NativeTypeName("LPWSABUF")]
        public _WSABUF* lpBuffers;

        [NativeTypeName("ULONG")]
        public uint dwBufferCount;

        [NativeTypeName("WSABUF")]
        public _WSABUF Control;

        [NativeTypeName("ULONG")]
        public uint dwFlags;
    }

    public partial struct cmsghdr
    {
        [NativeTypeName("SIZE_T")]
        public ulong cmsg_len;

        public int cmsg_level;

        public int cmsg_type;
    }

    public unsafe partial struct addrinfo
    {
        public int ai_flags;

        public int ai_family;

        public int ai_socktype;

        public int ai_protocol;

        [NativeTypeName("size_t")]
        public nuint ai_addrlen;

        [NativeTypeName("char *")]
        public sbyte* ai_canonname;

        [NativeTypeName("struct sockaddr *")]
        public sockaddr* ai_addr;

        [NativeTypeName("struct addrinfo *")]
        public addrinfo* ai_next;
    }

    public unsafe partial struct addrinfoW
    {
        public int ai_flags;

        public int ai_family;

        public int ai_socktype;

        public int ai_protocol;

        [NativeTypeName("size_t")]
        public nuint ai_addrlen;

        [NativeTypeName("PWSTR")]
        public char* ai_canonname;

        [NativeTypeName("struct sockaddr *")]
        public sockaddr* ai_addr;

        [NativeTypeName("struct addrinfoW *")]
        public addrinfoW* ai_next;
    }

    [Obsolete("ADDRINFOEXW")]
    public unsafe partial struct addrinfoexA
    {
        public int ai_flags;

        public int ai_family;

        public int ai_socktype;

        public int ai_protocol;

        [NativeTypeName("size_t")]
        public nuint ai_addrlen;

        [NativeTypeName("char *")]
        public sbyte* ai_canonname;

        [NativeTypeName("struct sockaddr *")]
        public sockaddr* ai_addr;

        public void* ai_blob;

        [NativeTypeName("size_t")]
        public nuint ai_bloblen;

        [NativeTypeName("LPGUID")]
        public Guid* ai_provider;

        [NativeTypeName("struct addrinfoexA *")]
        public addrinfoexA* ai_next;
    }

    public unsafe partial struct addrinfoexW
    {
        public int ai_flags;

        public int ai_family;

        public int ai_socktype;

        public int ai_protocol;

        [NativeTypeName("size_t")]
        public nuint ai_addrlen;

        [NativeTypeName("PWSTR")]
        public char* ai_canonname;

        [NativeTypeName("struct sockaddr *")]
        public sockaddr* ai_addr;

        public void* ai_blob;

        [NativeTypeName("size_t")]
        public nuint ai_bloblen;

        [NativeTypeName("LPGUID")]
        public Guid* ai_provider;

        [NativeTypeName("struct addrinfoexW *")]
        public addrinfoexW* ai_next;
    }

    public partial struct in6_addr
    {
        [NativeTypeName("__AnonymousRecord_in6addr_L26_C5")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UCHAR[16]")]
            public _Byte_e__FixedBuffer Byte;

            [FieldOffset(0)]
            [NativeTypeName("USHORT[8]")]
            public _Word_e__FixedBuffer Word;

            [InlineArray(16)]
            public partial struct _Byte_e__FixedBuffer
            {
                public byte e0;
            }

            [InlineArray(8)]
            public partial struct _Word_e__FixedBuffer
            {
                public ushort e0;
            }
        }
    }

    public partial struct sockaddr_in6_old
    {
        public short sin6_family;

        public ushort sin6_port;

        [NativeTypeName("ULONG")]
        public uint sin6_flowinfo;

        public in6_addr sin6_addr;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct sockaddr_gen
    {
        [FieldOffset(0)]
        [NativeTypeName("struct sockaddr")]
        public sockaddr Address;

        [FieldOffset(0)]
        [NativeTypeName("struct sockaddr_in")]
        public sockaddr_in AddressIn;

        [FieldOffset(0)]
        [NativeTypeName("struct sockaddr_in6_old")]
        public sockaddr_in6_old AddressIn6;
    }

    public partial struct _INTERFACE_INFO
    {
        [NativeTypeName("ULONG")]
        public uint iiFlags;

        public sockaddr_gen iiAddress;

        public sockaddr_gen iiBroadcastAddress;

        public sockaddr_gen iiNetmask;
    }

    public partial struct _INTERFACE_INFO_EX
    {
        [NativeTypeName("ULONG")]
        public uint iiFlags;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS iiAddress;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS iiBroadcastAddress;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS iiNetmask;
    }

    public enum _PMTUD_STATE
    {
        IP_PMTUDISC_NOT_SET,
        IP_PMTUDISC_DO,
        IP_PMTUDISC_DONT,
        IP_PMTUDISC_PROBE,
        IP_PMTUDISC_MAX,
    }

    public partial struct sockaddr_in6
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort sin6_family;

        public ushort sin6_port;

        [NativeTypeName("ULONG")]
        public uint sin6_flowinfo;

        public in6_addr sin6_addr;

        [NativeTypeName("__AnonymousRecord_ws2ipdef_L196_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref uint sin6_scope_id
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sin6_scope_id;
            }
        }

        [UnscopedRef]
        public ref SCOPE_ID sin6_scope_struct
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sin6_scope_struct;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint sin6_scope_id;

            [FieldOffset(0)]
            public SCOPE_ID sin6_scope_struct;
        }
    }

    public partial struct sockaddr_in6_w2ksp1
    {
        public short sin6_family;

        public ushort sin6_port;

        [NativeTypeName("ULONG")]
        public uint sin6_flowinfo;

        [NativeTypeName("struct in6_addr")]
        public in6_addr sin6_addr;

        [NativeTypeName("ULONG")]
        public uint sin6_scope_id;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _SOCKADDR_INET
    {
        [FieldOffset(0)]
        public sockaddr_in Ipv4;

        [FieldOffset(0)]
        public sockaddr_in6 Ipv6;

        [FieldOffset(0)]
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort si_family;
    }

    public unsafe partial struct _sockaddr_in6_pair
    {
        [NativeTypeName("PSOCKADDR_IN6")]
        public sockaddr_in6* SourceAddress;

        [NativeTypeName("PSOCKADDR_IN6")]
        public sockaddr_in6* DestinationAddress;
    }

    public enum MULTICAST_MODE_TYPE
    {
        MCAST_INCLUDE = 0,
        MCAST_EXCLUDE,
    }

    public partial struct ip_mreq
    {
        public in_addr imr_multiaddr;

        public in_addr imr_interface;
    }

    public partial struct ip_mreq_source
    {
        public in_addr imr_multiaddr;

        public in_addr imr_sourceaddr;

        public in_addr imr_interface;
    }

    public partial struct ip_msfilter
    {
        public in_addr imsf_multiaddr;

        public in_addr imsf_interface;

        public MULTICAST_MODE_TYPE imsf_fmode;

        [NativeTypeName("ULONG")]
        public uint imsf_numsrc;

        [NativeTypeName("IN_ADDR[1]")]
        public _imsf_slist_e__FixedBuffer imsf_slist;

        public partial struct _imsf_slist_e__FixedBuffer
        {
            public in_addr e0;

            [UnscopedRef]
            public ref in_addr this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<in_addr> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct ipv6_mreq
    {
        public in6_addr ipv6mr_multiaddr;

        [NativeTypeName("ULONG")]
        public uint ipv6mr_interface;
    }

    public partial struct group_req
    {
        [NativeTypeName("ULONG")]
        public uint gr_interface;

        public sockaddr_storage gr_group;
    }

    public partial struct group_source_req
    {
        [NativeTypeName("ULONG")]
        public uint gsr_interface;

        public sockaddr_storage gsr_group;

        public sockaddr_storage gsr_source;
    }

    public partial struct group_filter
    {
        [NativeTypeName("ULONG")]
        public uint gf_interface;

        public sockaddr_storage gf_group;

        public MULTICAST_MODE_TYPE gf_fmode;

        [NativeTypeName("ULONG")]
        public uint gf_numsrc;

        [NativeTypeName("SOCKADDR_STORAGE[1]")]
        public _gf_slist_e__FixedBuffer gf_slist;

        public partial struct _gf_slist_e__FixedBuffer
        {
            public sockaddr_storage e0;

            [UnscopedRef]
            public ref sockaddr_storage this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<sockaddr_storage> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct in_pktinfo
    {
        public in_addr ipi_addr;

        [NativeTypeName("ULONG")]
        public uint ipi_ifindex;
    }

    public partial struct in6_pktinfo
    {
        public in6_addr ipi6_addr;

        [NativeTypeName("ULONG")]
        public uint ipi6_ifindex;
    }

    public partial struct in_pktinfo_ex
    {
        public in_pktinfo pkt_info;

        public SCOPE_ID scope_id;
    }

    public partial struct in6_pktinfo_ex
    {
        public in6_pktinfo pkt_info;

        public SCOPE_ID scope_id;
    }

    public partial struct in_recverr
    {
        public IPPROTO protocol;

        [NativeTypeName("ULONG")]
        public uint info;

        [NativeTypeName("UINT8")]
        public byte type;

        [NativeTypeName("UINT8")]
        public byte code;
    }

    public partial struct icmp_error_info
    {
        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET srcaddress;

        public IPPROTO protocol;

        [NativeTypeName("UINT8")]
        public byte type;

        [NativeTypeName("UINT8")]
        public byte code;
    }

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

    public partial struct _MIB_TCP6ROW
    {
        public MIB_TCP_STATE State;

        public in6_addr LocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        public in6_addr RemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemoteScopeId;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;
    }

    public partial struct _MIB_TCP6TABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_TCP6ROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_TCP6ROW e0;

            [UnscopedRef]
            public ref _MIB_TCP6ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_TCP6ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_TCP6ROW2
    {
        public in6_addr LocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        public in6_addr RemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemoteScopeId;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        public MIB_TCP_STATE State;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        public TCP_CONNECTION_OFFLOAD_STATE dwOffloadState;
    }

    public partial struct _MIB_TCP6TABLE2
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_TCP6ROW2[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_TCP6ROW2 e0;

            [UnscopedRef]
            public ref _MIB_TCP6ROW2 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_TCP6ROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_TCP6ROW_OWNER_PID
    {
        [NativeTypeName("UCHAR[16]")]
        public _ucLocalAddr_e__FixedBuffer ucLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("UCHAR[16]")]
        public _ucRemoteAddr_e__FixedBuffer ucRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemoteScopeId;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        [InlineArray(16)]
        public partial struct _ucLocalAddr_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(16)]
        public partial struct _ucRemoteAddr_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _MIB_TCP6TABLE_OWNER_PID
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_TCP6ROW_OWNER_PID[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_TCP6ROW_OWNER_PID e0;

            [UnscopedRef]
            public ref _MIB_TCP6ROW_OWNER_PID this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_TCP6ROW_OWNER_PID> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_TCP6ROW_OWNER_MODULE
    {
        [NativeTypeName("UCHAR[16]")]
        public _ucLocalAddr_e__FixedBuffer ucLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("UCHAR[16]")]
        public _ucRemoteAddr_e__FixedBuffer ucRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemoteScopeId;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        [NativeTypeName("LARGE_INTEGER")]
        public long liCreateTimestamp;

        [NativeTypeName("ULONGLONG[16]")]
        public _OwningModuleInfo_e__FixedBuffer OwningModuleInfo;

        [InlineArray(16)]
        public partial struct _ucLocalAddr_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(16)]
        public partial struct _ucRemoteAddr_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(16)]
        public partial struct _OwningModuleInfo_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public partial struct _MIB_TCP6TABLE_OWNER_MODULE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_TCP6ROW_OWNER_MODULE[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_TCP6ROW_OWNER_MODULE e0;

            [UnscopedRef]
            public ref _MIB_TCP6ROW_OWNER_MODULE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_TCP6ROW_OWNER_MODULE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
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

    public partial struct _MIB_UDP6ROW
    {
        public in6_addr dwLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;
    }

    public partial struct _MIB_UDP6TABLE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_UDP6ROW[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_UDP6ROW e0;

            [UnscopedRef]
            public ref _MIB_UDP6ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UDP6ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_UDP6ROW_OWNER_PID
    {
        [NativeTypeName("UCHAR[16]")]
        public _ucLocalAddr_e__FixedBuffer ucLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        [InlineArray(16)]
        public partial struct _ucLocalAddr_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _MIB_UDP6TABLE_OWNER_PID
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_UDP6ROW_OWNER_PID[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_UDP6ROW_OWNER_PID e0;

            [UnscopedRef]
            public ref _MIB_UDP6ROW_OWNER_PID this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UDP6ROW_OWNER_PID> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_UDP6ROW_OWNER_MODULE
    {
        [NativeTypeName("UCHAR[16]")]
        public _ucLocalAddr_e__FixedBuffer ucLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        [NativeTypeName("LARGE_INTEGER")]
        public long liCreateTimestamp;

        [NativeTypeName("__AnonymousRecord_udpmib_L153_C5")]
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
            [NativeTypeName("__AnonymousRecord_udpmib_L154_C9")]
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
        public partial struct _ucLocalAddr_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(16)]
        public partial struct _OwningModuleInfo_e__FixedBuffer
        {
            public ulong e0;
        }
    }

    public partial struct _MIB_UDP6TABLE_OWNER_MODULE
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_UDP6ROW_OWNER_MODULE[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_UDP6ROW_OWNER_MODULE e0;

            [UnscopedRef]
            public ref _MIB_UDP6ROW_OWNER_MODULE this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UDP6ROW_OWNER_MODULE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_UDP6ROW2
    {
        [NativeTypeName("UCHAR[16]")]
        public _ucLocalAddr_e__FixedBuffer ucLocalAddr;

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        [NativeTypeName("LARGE_INTEGER")]
        public long liCreateTimestamp;

        [NativeTypeName("__AnonymousRecord_udpmib_L177_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ULONGLONG[16]")]
        public _OwningModuleInfo_e__FixedBuffer OwningModuleInfo;

        [NativeTypeName("UCHAR[16]")]
        public _ucRemoteAddr_e__FixedBuffer ucRemoteAddr;

        [NativeTypeName("DWORD")]
        public uint dwRemoteScopeId;

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
            [NativeTypeName("__AnonymousRecord_udpmib_L178_C9")]
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
        public partial struct _ucLocalAddr_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(16)]
        public partial struct _OwningModuleInfo_e__FixedBuffer
        {
            public ulong e0;
        }

        [InlineArray(16)]
        public partial struct _ucRemoteAddr_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _MIB_UDP6TABLE2
    {
        [NativeTypeName("DWORD")]
        public uint dwNumEntries;

        [NativeTypeName("MIB_UDP6ROW2[1]")]
        public _table_e__FixedBuffer table;

        public partial struct _table_e__FixedBuffer
        {
            public _MIB_UDP6ROW2 e0;

            [UnscopedRef]
            public ref _MIB_UDP6ROW2 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UDP6ROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
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

    public unsafe partial struct _IP_ADAPTER_UNICAST_ADDRESS_LH
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L114_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_UNICAST_ADDRESS_LH *")]
        public _IP_ADAPTER_UNICAST_ADDRESS_LH* Next;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Address;

        [NativeTypeName("IP_PREFIX_ORIGIN")]
        public NL_PREFIX_ORIGIN PrefixOrigin;

        [NativeTypeName("IP_SUFFIX_ORIGIN")]
        public NL_SUFFIX_ORIGIN SuffixOrigin;

        [NativeTypeName("IP_DAD_STATE")]
        public NL_DAD_STATE DadState;

        [NativeTypeName("ULONG")]
        public uint ValidLifetime;

        [NativeTypeName("ULONG")]
        public uint PreferredLifetime;

        [NativeTypeName("ULONG")]
        public uint LeaseLifetime;

        [NativeTypeName("UINT8")]
        public byte OnLinkPrefixLength;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Flags;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L116_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Flags;
            }
        }
    }

    public unsafe partial struct _IP_ADAPTER_UNICAST_ADDRESS_XP
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L136_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_UNICAST_ADDRESS_XP *")]
        public _IP_ADAPTER_UNICAST_ADDRESS_XP* Next;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Address;

        [NativeTypeName("IP_PREFIX_ORIGIN")]
        public NL_PREFIX_ORIGIN PrefixOrigin;

        [NativeTypeName("IP_SUFFIX_ORIGIN")]
        public NL_SUFFIX_ORIGIN SuffixOrigin;

        [NativeTypeName("IP_DAD_STATE")]
        public NL_DAD_STATE DadState;

        [NativeTypeName("ULONG")]
        public uint ValidLifetime;

        [NativeTypeName("ULONG")]
        public uint PreferredLifetime;

        [NativeTypeName("ULONG")]
        public uint LeaseLifetime;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Flags;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L138_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Flags;
            }
        }
    }

    public unsafe partial struct _IP_ADAPTER_ANYCAST_ADDRESS_XP
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L170_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_ANYCAST_ADDRESS_XP *")]
        public _IP_ADAPTER_ANYCAST_ADDRESS_XP* Next;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Address;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Flags;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L172_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Flags;
            }
        }
    }

    public unsafe partial struct _IP_ADAPTER_MULTICAST_ADDRESS_XP
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L186_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_MULTICAST_ADDRESS_XP *")]
        public _IP_ADAPTER_MULTICAST_ADDRESS_XP* Next;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Address;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Flags;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L188_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Flags;
            }
        }
    }

    public unsafe partial struct _IP_ADAPTER_DNS_SERVER_ADDRESS_XP
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L202_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_DNS_SERVER_ADDRESS_XP *")]
        public _IP_ADAPTER_DNS_SERVER_ADDRESS_XP* Next;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Address;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Reserved;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L204_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Reserved;
            }
        }
    }

    public unsafe partial struct _IP_ADAPTER_WINS_SERVER_ADDRESS_LH
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L218_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_WINS_SERVER_ADDRESS_LH *")]
        public _IP_ADAPTER_WINS_SERVER_ADDRESS_LH* Next;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Address;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Reserved;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L220_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Reserved;
            }
        }
    }

    public unsafe partial struct _IP_ADAPTER_GATEWAY_ADDRESS_LH
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L235_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_GATEWAY_ADDRESS_LH *")]
        public _IP_ADAPTER_GATEWAY_ADDRESS_LH* Next;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Address;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Reserved;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L237_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Reserved;
            }
        }
    }

    public unsafe partial struct _IP_ADAPTER_PREFIX_XP
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L251_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_PREFIX_XP *")]
        public _IP_ADAPTER_PREFIX_XP* Next;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Address;

        [NativeTypeName("ULONG")]
        public uint PrefixLength;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Flags;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L253_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Flags;
            }
        }
    }

    public unsafe partial struct _IP_ADAPTER_DNS_SUFFIX
    {
        [NativeTypeName("struct _IP_ADAPTER_DNS_SUFFIX *")]
        public _IP_ADAPTER_DNS_SUFFIX* Next;

        [NativeTypeName("WCHAR[256]")]
        public _String_e__FixedBuffer String;

        [InlineArray(256)]
        public partial struct _String_e__FixedBuffer
        {
            public char e0;
        }
    }

    public unsafe partial struct _IP_ADAPTER_ADDRESSES_LH
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L287_C5")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("struct _IP_ADAPTER_ADDRESSES_LH *")]
        public _IP_ADAPTER_ADDRESSES_LH* Next;

        [NativeTypeName("PCHAR")]
        public sbyte* AdapterName;

        [NativeTypeName("PIP_ADAPTER_UNICAST_ADDRESS_LH")]
        public _IP_ADAPTER_UNICAST_ADDRESS_LH* FirstUnicastAddress;

        [NativeTypeName("PIP_ADAPTER_ANYCAST_ADDRESS_XP")]
        public _IP_ADAPTER_ANYCAST_ADDRESS_XP* FirstAnycastAddress;

        [NativeTypeName("PIP_ADAPTER_MULTICAST_ADDRESS_XP")]
        public _IP_ADAPTER_MULTICAST_ADDRESS_XP* FirstMulticastAddress;

        [NativeTypeName("PIP_ADAPTER_DNS_SERVER_ADDRESS_XP")]
        public _IP_ADAPTER_DNS_SERVER_ADDRESS_XP* FirstDnsServerAddress;

        [NativeTypeName("PWCHAR")]
        public char* DnsSuffix;

        [NativeTypeName("PWCHAR")]
        public char* Description;

        [NativeTypeName("PWCHAR")]
        public char* FriendlyName;

        [NativeTypeName("BYTE[8]")]
        public _PhysicalAddress_e__FixedBuffer PhysicalAddress;

        [NativeTypeName("ULONG")]
        public uint PhysicalAddressLength;

        [NativeTypeName("__AnonymousRecord_iptypes_L305_C5")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("ULONG")]
        public uint Mtu;

        [NativeTypeName("IFTYPE")]
        public uint IfType;

        public IF_OPER_STATUS OperStatus;

        [NativeTypeName("IF_INDEX")]
        public uint Ipv6IfIndex;

        [NativeTypeName("ULONG[16]")]
        public _ZoneIndices_e__FixedBuffer ZoneIndices;

        [NativeTypeName("PIP_ADAPTER_PREFIX_XP")]
        public _IP_ADAPTER_PREFIX_XP* FirstPrefix;

        [NativeTypeName("ULONG64")]
        public ulong TransmitLinkSpeed;

        [NativeTypeName("ULONG64")]
        public ulong ReceiveLinkSpeed;

        [NativeTypeName("PIP_ADAPTER_WINS_SERVER_ADDRESS_LH")]
        public _IP_ADAPTER_WINS_SERVER_ADDRESS_LH* FirstWinsServerAddress;

        [NativeTypeName("PIP_ADAPTER_GATEWAY_ADDRESS_LH")]
        public _IP_ADAPTER_GATEWAY_ADDRESS_LH* FirstGatewayAddress;

        [NativeTypeName("ULONG")]
        public uint Ipv4Metric;

        [NativeTypeName("ULONG")]
        public uint Ipv6Metric;

        [NativeTypeName("IF_LUID")]
        public _NET_LUID_LH Luid;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Dhcpv4Server;

        [NativeTypeName("NET_IF_COMPARTMENT_ID")]
        public uint CompartmentId;

        [NativeTypeName("NET_IF_NETWORK_GUID")]
        public Guid NetworkGuid;

        [NativeTypeName("NET_IF_CONNECTION_TYPE")]
        public _NET_IF_CONNECTION_TYPE ConnectionType;

        public TUNNEL_TYPE TunnelType;

        [NativeTypeName("SOCKET_ADDRESS")]
        public _SOCKET_ADDRESS Dhcpv6Server;

        [NativeTypeName("BYTE[130]")]
        public _Dhcpv6ClientDuid_e__FixedBuffer Dhcpv6ClientDuid;

        [NativeTypeName("ULONG")]
        public uint Dhcpv6ClientDuidLength;

        [NativeTypeName("ULONG")]
        public uint Dhcpv6Iaid;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint IfIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous.IfIndex;
            }
        }

        [UnscopedRef]
        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Flags;
            }
        }

        public uint DdnsEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.DdnsEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.DdnsEnabled = value;
            }
        }

        public uint RegisterAdapterSuffix
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.RegisterAdapterSuffix;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.RegisterAdapterSuffix = value;
            }
        }

        public uint Dhcpv4Enabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.Dhcpv4Enabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Dhcpv4Enabled = value;
            }
        }

        public uint ReceiveOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.ReceiveOnly;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.ReceiveOnly = value;
            }
        }

        public uint NoMulticast
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.NoMulticast;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.NoMulticast = value;
            }
        }

        public uint Ipv6OtherStatefulConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.Ipv6OtherStatefulConfig;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Ipv6OtherStatefulConfig = value;
            }
        }

        public uint NetbiosOverTcpipEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.NetbiosOverTcpipEnabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.NetbiosOverTcpipEnabled = value;
            }
        }

        public uint Ipv4Enabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.Ipv4Enabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Ipv4Enabled = value;
            }
        }

        public uint Ipv6Enabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.Ipv6Enabled;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Ipv6Enabled = value;
            }
        }

        public uint Ipv6ManagedAddressConfigurationSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous2.Anonymous.Ipv6ManagedAddressConfigurationSupported;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous2.Anonymous.Ipv6ManagedAddressConfigurationSupported = value;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L289_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("IF_INDEX")]
                public uint IfIndex;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint Flags;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L307_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public uint _bitfield;

                [NativeTypeName("ULONG : 1")]
                public uint DdnsEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return _bitfield & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint RegisterAdapterSuffix
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Dhcpv4Enabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 2) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint ReceiveOnly
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 3) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint NoMulticast
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 4) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Ipv6OtherStatefulConfig
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 5) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint NetbiosOverTcpipEnabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 6) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Ipv4Enabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 7) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Ipv6Enabled
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 8) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
                    }
                }

                [NativeTypeName("ULONG : 1")]
                public uint Ipv6ManagedAddressConfigurationSupported
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    readonly get
                    {
                        return (_bitfield >> 9) & 0x1u;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9);
                    }
                }
            }
        }

        [InlineArray(8)]
        public partial struct _PhysicalAddress_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(16)]
        public partial struct _ZoneIndices_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(130)]
        public partial struct _Dhcpv6ClientDuid_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public unsafe partial struct _IP_ADAPTER_ADDRESSES_XP
    {
        [NativeTypeName("__AnonymousRecord_iptypes_L353_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_ADDRESSES_XP *")]
        public _IP_ADAPTER_ADDRESSES_XP* Next;

        [NativeTypeName("PCHAR")]
        public sbyte* AdapterName;

        [NativeTypeName("PIP_ADAPTER_UNICAST_ADDRESS_XP")]
        public _IP_ADAPTER_UNICAST_ADDRESS_XP* FirstUnicastAddress;

        [NativeTypeName("PIP_ADAPTER_ANYCAST_ADDRESS_XP")]
        public _IP_ADAPTER_ANYCAST_ADDRESS_XP* FirstAnycastAddress;

        [NativeTypeName("PIP_ADAPTER_MULTICAST_ADDRESS_XP")]
        public _IP_ADAPTER_MULTICAST_ADDRESS_XP* FirstMulticastAddress;

        [NativeTypeName("PIP_ADAPTER_DNS_SERVER_ADDRESS_XP")]
        public _IP_ADAPTER_DNS_SERVER_ADDRESS_XP* FirstDnsServerAddress;

        [NativeTypeName("PWCHAR")]
        public char* DnsSuffix;

        [NativeTypeName("PWCHAR")]
        public char* Description;

        [NativeTypeName("PWCHAR")]
        public char* FriendlyName;

        [NativeTypeName("BYTE[8]")]
        public _PhysicalAddress_e__FixedBuffer PhysicalAddress;

        [NativeTypeName("DWORD")]
        public uint PhysicalAddressLength;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint Mtu;

        [NativeTypeName("DWORD")]
        public uint IfType;

        public IF_OPER_STATUS OperStatus;

        [NativeTypeName("DWORD")]
        public uint Ipv6IfIndex;

        [NativeTypeName("DWORD[16]")]
        public _ZoneIndices_e__FixedBuffer ZoneIndices;

        [NativeTypeName("PIP_ADAPTER_PREFIX_XP")]
        public _IP_ADAPTER_PREFIX_XP* FirstPrefix;

        [UnscopedRef]
        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Alignment;
            }
        }

        [UnscopedRef]
        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.Length;
            }
        }

        [UnscopedRef]
        public ref uint IfIndex
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Anonymous.IfIndex;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iptypes_L355_C9")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint IfIndex;
            }
        }

        [InlineArray(8)]
        public partial struct _PhysicalAddress_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(16)]
        public partial struct _ZoneIndices_e__FixedBuffer
        {
            public uint e0;
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

    public enum NET_ADDRESS_FORMAT_
    {
        NET_ADDRESS_FORMAT_UNSPECIFIED = 0,
        NET_ADDRESS_DNS_NAME,
        NET_ADDRESS_IPV4,
        NET_ADDRESS_IPV6,
    }

    public enum _MIB_NOTIFICATION_TYPE
    {
        MibParameterNotification,
        MibAddInstance,
        MibDeleteInstance,
        MibInitialNotification,
    }

    public partial struct _MIB_IF_ROW2
    {
        [NativeTypeName("NET_LUID")]
        public _NET_LUID_LH InterfaceLuid;

        [NativeTypeName("NET_IFINDEX")]
        public uint InterfaceIndex;

        public Guid InterfaceGuid;

        [NativeTypeName("WCHAR[257]")]
        public _Alias_e__FixedBuffer Alias;

        [NativeTypeName("WCHAR[257]")]
        public _Description_e__FixedBuffer Description;

        [NativeTypeName("ULONG")]
        public uint PhysicalAddressLength;

        [NativeTypeName("UCHAR[32]")]
        public _PhysicalAddress_e__FixedBuffer PhysicalAddress;

        [NativeTypeName("UCHAR[32]")]
        public _PermanentPhysicalAddress_e__FixedBuffer PermanentPhysicalAddress;

        [NativeTypeName("ULONG")]
        public uint Mtu;

        [NativeTypeName("IFTYPE")]
        public uint Type;

        public TUNNEL_TYPE TunnelType;

        [NativeTypeName("NDIS_MEDIUM")]
        public int MediaType;

        [NativeTypeName("NDIS_PHYSICAL_MEDIUM")]
        public int PhysicalMediumType;

        [NativeTypeName("NET_IF_ACCESS_TYPE")]
        public _NET_IF_ACCESS_TYPE AccessType;

        [NativeTypeName("NET_IF_DIRECTION_TYPE")]
        public _NET_IF_DIRECTION_TYPE DirectionType;

        [NativeTypeName("__AnonymousRecord_netioapi_L178_C5")]
        public _InterfaceAndOperStatusFlags_e__Struct InterfaceAndOperStatusFlags;

        public IF_OPER_STATUS OperStatus;

        [NativeTypeName("NET_IF_ADMIN_STATUS")]
        public _NET_IF_ADMIN_STATUS AdminStatus;

        [NativeTypeName("NET_IF_MEDIA_CONNECT_STATE")]
        public _NET_IF_MEDIA_CONNECT_STATE MediaConnectState;

        [NativeTypeName("NET_IF_NETWORK_GUID")]
        public Guid NetworkGuid;

        [NativeTypeName("NET_IF_CONNECTION_TYPE")]
        public _NET_IF_CONNECTION_TYPE ConnectionType;

        [NativeTypeName("ULONG64")]
        public ulong TransmitLinkSpeed;

        [NativeTypeName("ULONG64")]
        public ulong ReceiveLinkSpeed;

        [NativeTypeName("ULONG64")]
        public ulong InOctets;

        [NativeTypeName("ULONG64")]
        public ulong InUcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong InNUcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong InDiscards;

        [NativeTypeName("ULONG64")]
        public ulong InErrors;

        [NativeTypeName("ULONG64")]
        public ulong InUnknownProtos;

        [NativeTypeName("ULONG64")]
        public ulong InUcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong InMulticastOctets;

        [NativeTypeName("ULONG64")]
        public ulong InBroadcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong OutOctets;

        [NativeTypeName("ULONG64")]
        public ulong OutUcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong OutNUcastPkts;

        [NativeTypeName("ULONG64")]
        public ulong OutDiscards;

        [NativeTypeName("ULONG64")]
        public ulong OutErrors;

        [NativeTypeName("ULONG64")]
        public ulong OutUcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong OutMulticastOctets;

        [NativeTypeName("ULONG64")]
        public ulong OutBroadcastOctets;

        [NativeTypeName("ULONG64")]
        public ulong OutQLen;

        public partial struct _InterfaceAndOperStatusFlags_e__Struct
        {
            public byte _bitfield;

            [NativeTypeName("BOOLEAN : 1")]
            public byte HardwareInterface
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
            public byte FilterInterface
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
            public byte ConnectorPresent
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
            public byte NotAuthenticated
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
            public byte NotMediaConnected
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
            public byte Paused
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
            public byte LowPower
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
            public byte EndPointInterface
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

        [InlineArray(257)]
        public partial struct _Alias_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(257)]
        public partial struct _Description_e__FixedBuffer
        {
            public char e0;
        }

        [InlineArray(32)]
        public partial struct _PhysicalAddress_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(32)]
        public partial struct _PermanentPhysicalAddress_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _MIB_IF_TABLE2
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_IF_ROW2[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_IF_ROW2 e0;

            [UnscopedRef]
            public ref _MIB_IF_ROW2 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IF_ROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public enum _MIB_IF_TABLE_LEVEL
    {
        MibIfTableNormal,
        MibIfTableRaw,
    }

    public partial struct _MIB_IPINTERFACE_ROW
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort Family;

        [NativeTypeName("NET_LUID")]
        public _NET_LUID_LH InterfaceLuid;

        [NativeTypeName("NET_IFINDEX")]
        public uint InterfaceIndex;

        [NativeTypeName("ULONG")]
        public uint MaxReassemblySize;

        [NativeTypeName("ULONG64")]
        public ulong InterfaceIdentifier;

        [NativeTypeName("ULONG")]
        public uint MinRouterAdvertisementInterval;

        [NativeTypeName("ULONG")]
        public uint MaxRouterAdvertisementInterval;

        [NativeTypeName("BOOLEAN")]
        public byte AdvertisingEnabled;

        [NativeTypeName("BOOLEAN")]
        public byte ForwardingEnabled;

        [NativeTypeName("BOOLEAN")]
        public byte WeakHostSend;

        [NativeTypeName("BOOLEAN")]
        public byte WeakHostReceive;

        [NativeTypeName("BOOLEAN")]
        public byte UseAutomaticMetric;

        [NativeTypeName("BOOLEAN")]
        public byte UseNeighborUnreachabilityDetection;

        [NativeTypeName("BOOLEAN")]
        public byte ManagedAddressConfigurationSupported;

        [NativeTypeName("BOOLEAN")]
        public byte OtherStatefulConfigurationSupported;

        [NativeTypeName("BOOLEAN")]
        public byte AdvertiseDefaultRoute;

        [NativeTypeName("NL_ROUTER_DISCOVERY_BEHAVIOR")]
        public _NL_ROUTER_DISCOVERY_BEHAVIOR RouterDiscoveryBehavior;

        [NativeTypeName("ULONG")]
        public uint DadTransmits;

        [NativeTypeName("ULONG")]
        public uint BaseReachableTime;

        [NativeTypeName("ULONG")]
        public uint RetransmitTime;

        [NativeTypeName("ULONG")]
        public uint PathMtuDiscoveryTimeout;

        [NativeTypeName("NL_LINK_LOCAL_ADDRESS_BEHAVIOR")]
        public _NL_LINK_LOCAL_ADDRESS_BEHAVIOR LinkLocalAddressBehavior;

        [NativeTypeName("ULONG")]
        public uint LinkLocalAddressTimeout;

        [NativeTypeName("ULONG[16]")]
        public _ZoneIndices_e__FixedBuffer ZoneIndices;

        [NativeTypeName("ULONG")]
        public uint SitePrefixLength;

        [NativeTypeName("ULONG")]
        public uint Metric;

        [NativeTypeName("ULONG")]
        public uint NlMtu;

        [NativeTypeName("BOOLEAN")]
        public byte Connected;

        [NativeTypeName("BOOLEAN")]
        public byte SupportsWakeUpPatterns;

        [NativeTypeName("BOOLEAN")]
        public byte SupportsNeighborDiscovery;

        [NativeTypeName("BOOLEAN")]
        public byte SupportsRouterDiscovery;

        [NativeTypeName("ULONG")]
        public uint ReachableTime;

        [NativeTypeName("NL_INTERFACE_OFFLOAD_ROD")]
        public _NL_INTERFACE_OFFLOAD_ROD TransmitOffload;

        [NativeTypeName("NL_INTERFACE_OFFLOAD_ROD")]
        public _NL_INTERFACE_OFFLOAD_ROD ReceiveOffload;

        [NativeTypeName("BOOLEAN")]
        public byte DisableDefaultRoutes;

        [InlineArray(16)]
        public partial struct _ZoneIndices_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct _MIB_IPINTERFACE_TABLE
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_IPINTERFACE_ROW[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_IPINTERFACE_ROW e0;

            [UnscopedRef]
            public ref _MIB_IPINTERFACE_ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPINTERFACE_ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_IFSTACK_ROW
    {
        [NativeTypeName("NET_IFINDEX")]
        public uint HigherLayerInterfaceIndex;

        [NativeTypeName("NET_IFINDEX")]
        public uint LowerLayerInterfaceIndex;
    }

    public partial struct _MIB_INVERTEDIFSTACK_ROW
    {
        [NativeTypeName("NET_IFINDEX")]
        public uint LowerLayerInterfaceIndex;

        [NativeTypeName("NET_IFINDEX")]
        public uint HigherLayerInterfaceIndex;
    }

    public partial struct _MIB_IFSTACK_TABLE
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_IFSTACK_ROW[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_IFSTACK_ROW e0;

            [UnscopedRef]
            public ref _MIB_IFSTACK_ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IFSTACK_ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_INVERTEDIFSTACK_TABLE
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_INVERTEDIFSTACK_ROW[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_INVERTEDIFSTACK_ROW e0;

            [UnscopedRef]
            public ref _MIB_INVERTEDIFSTACK_ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_INVERTEDIFSTACK_ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_IP_NETWORK_CONNECTION_BANDWIDTH_ESTIMATES
    {
        [NativeTypeName("NL_BANDWIDTH_INFORMATION")]
        public _NL_BANDWIDTH_INFORMATION InboundBandwidthInformation;

        [NativeTypeName("NL_BANDWIDTH_INFORMATION")]
        public _NL_BANDWIDTH_INFORMATION OutboundBandwidthInformation;
    }

    public partial struct _MIB_UNICASTIPADDRESS_ROW
    {
        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET Address;

        [NativeTypeName("NET_LUID")]
        public _NET_LUID_LH InterfaceLuid;

        [NativeTypeName("NET_IFINDEX")]
        public uint InterfaceIndex;

        public NL_PREFIX_ORIGIN PrefixOrigin;

        public NL_SUFFIX_ORIGIN SuffixOrigin;

        [NativeTypeName("ULONG")]
        public uint ValidLifetime;

        [NativeTypeName("ULONG")]
        public uint PreferredLifetime;

        [NativeTypeName("UINT8")]
        public byte OnLinkPrefixLength;

        [NativeTypeName("BOOLEAN")]
        public byte SkipAsSource;

        public NL_DAD_STATE DadState;

        public SCOPE_ID ScopeId;

        [NativeTypeName("LARGE_INTEGER")]
        public long CreationTimeStamp;
    }

    public partial struct _MIB_UNICASTIPADDRESS_TABLE
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_UNICASTIPADDRESS_ROW[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_UNICASTIPADDRESS_ROW e0;

            [UnscopedRef]
            public ref _MIB_UNICASTIPADDRESS_ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_UNICASTIPADDRESS_ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_ANYCASTIPADDRESS_ROW
    {
        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET Address;

        [NativeTypeName("NET_LUID")]
        public _NET_LUID_LH InterfaceLuid;

        [NativeTypeName("NET_IFINDEX")]
        public uint InterfaceIndex;

        public SCOPE_ID ScopeId;
    }

    public partial struct _MIB_ANYCASTIPADDRESS_TABLE
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_ANYCASTIPADDRESS_ROW[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_ANYCASTIPADDRESS_ROW e0;

            [UnscopedRef]
            public ref _MIB_ANYCASTIPADDRESS_ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_ANYCASTIPADDRESS_ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_MULTICASTIPADDRESS_ROW
    {
        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET Address;

        [NativeTypeName("NET_IFINDEX")]
        public uint InterfaceIndex;

        [NativeTypeName("NET_LUID")]
        public _NET_LUID_LH InterfaceLuid;

        public SCOPE_ID ScopeId;
    }

    public partial struct _MIB_MULTICASTIPADDRESS_TABLE
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_MULTICASTIPADDRESS_ROW[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_MULTICASTIPADDRESS_ROW e0;

            [UnscopedRef]
            public ref _MIB_MULTICASTIPADDRESS_ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_MULTICASTIPADDRESS_ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _IP_ADDRESS_PREFIX
    {
        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET Prefix;

        [NativeTypeName("UINT8")]
        public byte PrefixLength;
    }

    public partial struct _MIB_IPFORWARD_ROW2
    {
        [NativeTypeName("NET_LUID")]
        public _NET_LUID_LH InterfaceLuid;

        [NativeTypeName("NET_IFINDEX")]
        public uint InterfaceIndex;

        [NativeTypeName("IP_ADDRESS_PREFIX")]
        public _IP_ADDRESS_PREFIX DestinationPrefix;

        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET NextHop;

        [NativeTypeName("UCHAR")]
        public byte SitePrefixLength;

        [NativeTypeName("ULONG")]
        public uint ValidLifetime;

        [NativeTypeName("ULONG")]
        public uint PreferredLifetime;

        [NativeTypeName("ULONG")]
        public uint Metric;

        public NL_ROUTE_PROTOCOL Protocol;

        [NativeTypeName("BOOLEAN")]
        public byte Loopback;

        [NativeTypeName("BOOLEAN")]
        public byte AutoconfigureAddress;

        [NativeTypeName("BOOLEAN")]
        public byte Publish;

        [NativeTypeName("BOOLEAN")]
        public byte Immortal;

        [NativeTypeName("ULONG")]
        public uint Age;

        [NativeTypeName("NL_ROUTE_ORIGIN")]
        public _NL_ROUTE_ORIGIN Origin;
    }

    public partial struct _MIB_IPFORWARD_TABLE2
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_IPFORWARD_ROW2[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_IPFORWARD_ROW2 e0;

            [UnscopedRef]
            public ref _MIB_IPFORWARD_ROW2 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPFORWARD_ROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_IPPATH_ROW
    {
        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET Source;

        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET Destination;

        [NativeTypeName("NET_LUID")]
        public _NET_LUID_LH InterfaceLuid;

        [NativeTypeName("NET_IFINDEX")]
        public uint InterfaceIndex;

        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET CurrentNextHop;

        [NativeTypeName("ULONG")]
        public uint PathMtu;

        [NativeTypeName("ULONG")]
        public uint RttMean;

        [NativeTypeName("ULONG")]
        public uint RttDeviation;

        [NativeTypeName("__AnonymousRecord_netioapi_L1792_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("BOOLEAN")]
        public byte IsReachable;

        [NativeTypeName("ULONG64")]
        public ulong LinkTransmitSpeed;

        [NativeTypeName("ULONG64")]
        public ulong LinkReceiveSpeed;

        [UnscopedRef]
        public ref uint LastReachable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.LastReachable;
            }
        }

        [UnscopedRef]
        public ref uint LastUnreachable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.LastUnreachable;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint LastReachable;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint LastUnreachable;
        }
    }

    public partial struct _MIB_IPPATH_TABLE
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_IPPATH_ROW[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_IPPATH_ROW e0;

            [UnscopedRef]
            public ref _MIB_IPPATH_ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPPATH_ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public partial struct _MIB_IPNET_ROW2
    {
        [NativeTypeName("SOCKADDR_INET")]
        public _SOCKADDR_INET Address;

        [NativeTypeName("NET_IFINDEX")]
        public uint InterfaceIndex;

        [NativeTypeName("NET_LUID")]
        public _NET_LUID_LH InterfaceLuid;

        [NativeTypeName("UCHAR[32]")]
        public _PhysicalAddress_e__FixedBuffer PhysicalAddress;

        [NativeTypeName("ULONG")]
        public uint PhysicalAddressLength;

        [NativeTypeName("NL_NEIGHBOR_STATE")]
        public _NL_NEIGHBOR_STATE State;

        [NativeTypeName("__AnonymousRecord_netioapi_L1939_C5")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("__AnonymousRecord_netioapi_L1947_C5")]
        public _ReachabilityTime_e__Union ReachabilityTime;

        public byte IsRouter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous.IsRouter;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.IsRouter = value;
            }
        }

        public byte IsUnreachable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Anonymous.IsUnreachable;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.IsUnreachable = value;
            }
        }

        [UnscopedRef]
        public ref byte Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Flags;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_netioapi_L1940_C9")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("UCHAR")]
            public byte Flags;

            public partial struct _Anonymous_e__Struct
            {
                public byte _bitfield;

                [NativeTypeName("BOOLEAN : 1")]
                public byte IsRouter
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
                public byte IsUnreachable
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
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _ReachabilityTime_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint LastReachable;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint LastUnreachable;
        }

        [InlineArray(32)]
        public partial struct _PhysicalAddress_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct _MIB_IPNET_TABLE2
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_IPNET_ROW2[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_IPNET_ROW2 e0;

            [UnscopedRef]
            public ref _MIB_IPNET_ROW2 this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_IPNET_ROW2> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }

    public unsafe partial struct _DNS_SETTINGS
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("ULONG64")]
        public ulong Flags;

        [NativeTypeName("PWSTR")]
        public char* Hostname;

        [NativeTypeName("PWSTR")]
        public char* Domain;

        [NativeTypeName("PWSTR")]
        public char* SearchList;
    }

    public unsafe partial struct _DNS_SETTINGS2
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("ULONG64")]
        public ulong Flags;

        [NativeTypeName("PWSTR")]
        public char* Hostname;

        [NativeTypeName("PWSTR")]
        public char* Domain;

        [NativeTypeName("PWSTR")]
        public char* SearchList;

        [NativeTypeName("ULONG64")]
        public ulong SettingFlags;
    }

    public unsafe partial struct _DNS_DOH_SERVER_SETTINGS
    {
        [NativeTypeName("PWSTR")]
        public char* Template;

        [NativeTypeName("ULONG64")]
        public ulong Flags;
    }

    public unsafe partial struct _DNS_DOT_SERVER_SETTINGS
    {
        [NativeTypeName("PWSTR")]
        public char* Hostname;

        [NativeTypeName("ULONG64")]
        public ulong Flags;

        public ushort Port;
    }

    public enum _DNS_SERVER_PROPERTY_TYPE
    {
        DnsServerInvalidProperty = 0,
        DnsServerDohProperty,
        DnsServerDotProperty,
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _DNS_SERVER_PROPERTY_TYPES
    {
        [FieldOffset(0)]
        [NativeTypeName("DNS_DOH_SERVER_SETTINGS *")]
        public _DNS_DOH_SERVER_SETTINGS* DohSettings;

        [FieldOffset(0)]
        [NativeTypeName("DNS_DOT_SERVER_SETTINGS *")]
        public _DNS_DOT_SERVER_SETTINGS* DotSettings;
    }

    public partial struct _DNS_SERVER_PROPERTY
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("ULONG")]
        public uint ServerIndex;

        [NativeTypeName("DNS_SERVER_PROPERTY_TYPE")]
        public _DNS_SERVER_PROPERTY_TYPE Type;

        [NativeTypeName("DNS_SERVER_PROPERTY_TYPES")]
        public _DNS_SERVER_PROPERTY_TYPES Property;
    }

    public unsafe partial struct _DNS_INTERFACE_SETTINGS
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("ULONG64")]
        public ulong Flags;

        [NativeTypeName("PWSTR")]
        public char* Domain;

        [NativeTypeName("PWSTR")]
        public char* NameServer;

        [NativeTypeName("PWSTR")]
        public char* SearchList;

        [NativeTypeName("ULONG")]
        public uint RegistrationEnabled;

        [NativeTypeName("ULONG")]
        public uint RegisterAdapterName;

        [NativeTypeName("ULONG")]
        public uint EnableLLMNR;

        [NativeTypeName("ULONG")]
        public uint QueryAdapterName;

        [NativeTypeName("PWSTR")]
        public char* ProfileNameServer;
    }

    public unsafe partial struct _DNS_INTERFACE_SETTINGS_EX
    {
        [NativeTypeName("DNS_INTERFACE_SETTINGS")]
        public _DNS_INTERFACE_SETTINGS SettingsV1;

        [NativeTypeName("ULONG")]
        public uint DisableUnconstrainedQueries;

        [NativeTypeName("PWSTR")]
        public char* SupplementalSearchList;
    }

    public unsafe partial struct _DNS_INTERFACE_SETTINGS3
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("ULONG64")]
        public ulong Flags;

        [NativeTypeName("PWSTR")]
        public char* Domain;

        [NativeTypeName("PWSTR")]
        public char* NameServer;

        [NativeTypeName("PWSTR")]
        public char* SearchList;

        [NativeTypeName("ULONG")]
        public uint RegistrationEnabled;

        [NativeTypeName("ULONG")]
        public uint RegisterAdapterName;

        [NativeTypeName("ULONG")]
        public uint EnableLLMNR;

        [NativeTypeName("ULONG")]
        public uint QueryAdapterName;

        [NativeTypeName("PWSTR")]
        public char* ProfileNameServer;

        [NativeTypeName("ULONG")]
        public uint DisableUnconstrainedQueries;

        [NativeTypeName("PWSTR")]
        public char* SupplementalSearchList;

        [NativeTypeName("ULONG")]
        public uint cServerProperties;

        [NativeTypeName("DNS_SERVER_PROPERTY *")]
        public _DNS_SERVER_PROPERTY* ServerProperties;

        [NativeTypeName("ULONG")]
        public uint cProfileServerProperties;

        [NativeTypeName("DNS_SERVER_PROPERTY *")]
        public _DNS_SERVER_PROPERTY* ProfileServerProperties;
    }

    public unsafe partial struct _DNS_INTERFACE_SETTINGS4
    {
        [NativeTypeName("ULONG")]
        public uint Version;

        [NativeTypeName("ULONG64")]
        public ulong Flags;

        [NativeTypeName("PWSTR")]
        public char* Domain;

        [NativeTypeName("PWSTR")]
        public char* NameServer;

        [NativeTypeName("PWSTR")]
        public char* SearchList;

        [NativeTypeName("ULONG")]
        public uint RegistrationEnabled;

        [NativeTypeName("ULONG")]
        public uint RegisterAdapterName;

        [NativeTypeName("ULONG")]
        public uint EnableLLMNR;

        [NativeTypeName("ULONG")]
        public uint QueryAdapterName;

        [NativeTypeName("PWSTR")]
        public char* ProfileNameServer;

        [NativeTypeName("ULONG")]
        public uint DisableUnconstrainedQueries;

        [NativeTypeName("PWSTR")]
        public char* SupplementalSearchList;

        [NativeTypeName("ULONG")]
        public uint cServerProperties;

        [NativeTypeName("DNS_SERVER_PROPERTY *")]
        public _DNS_SERVER_PROPERTY* ServerProperties;

        [NativeTypeName("ULONG")]
        public uint cProfileServerProperties;

        [NativeTypeName("DNS_SERVER_PROPERTY *")]
        public _DNS_SERVER_PROPERTY* ProfileServerProperties;

        [NativeTypeName("ULONG")]
        public uint EncryptedDnsAdapterFlags;
    }

    public enum _NET_FL_VIRTUAL_INTERFACE_ORIGIN
    {
        NetFlVirtualInterfaceOriginOid,
        NetFlVirtualInterfaceOriginApi,
        NetFlVirtualInterfaceOriginDefault,
    }

    public enum _NET_FL_ISOLATION_MODE
    {
        NetFlIsolationModeNone,
        NetFlIsolationModeVlan,
        NetFlIsolationModeVsid,
    }

    public partial struct _MIB_FL_VIRTUAL_INTERFACE_ROW
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort Family;

        [NativeTypeName("IF_LUID")]
        public _NET_LUID_LH IfLuid;

        [NativeTypeName("ULONG")]
        public uint VirtualIfId;

        public Guid CompartmentGuid;

        [NativeTypeName("NET_FL_ISOLATION_MODE")]
        public _NET_FL_ISOLATION_MODE IsolationMode;

        [NativeTypeName("NET_FL_VIRTUAL_INTERFACE_ORIGIN")]
        public _NET_FL_VIRTUAL_INTERFACE_ORIGIN Origin;

        [NativeTypeName("IF_LUID")]
        public _NET_LUID_LH VirtualIfLuid;

        [NativeTypeName("IF_INDEX")]
        public uint VirtualIfIndex;

        [NativeTypeName("BOOLEAN")]
        public byte AllowLocalNd;

        [NativeTypeName("ULONG")]
        public uint AttachedFlsnpiClients;

        [NativeTypeName("ULONG")]
        public uint FlsnpiClientConfigErrors;

        [NativeTypeName("ULONG64")]
        public ulong FlsnpiClientInjectErrors;

        [NativeTypeName("ULONG64")]
        public ulong FlsnpiClientCloneErrors;

        [NativeTypeName("ULONG64")]
        public ulong InFlsnpiIndicatedPackets;

        [NativeTypeName("ULONG64")]
        public ulong InFlsnpiClientReturnedPackets;

        [NativeTypeName("ULONG64")]
        public ulong InFlsnpiClientSilentlyDroppedPackets;

        [NativeTypeName("ULONG64")]
        public ulong InFlsnpiClientDroppedPackets;

        [NativeTypeName("ULONG64")]
        public ulong InFlsnpiClientInjectedPackets;

        [NativeTypeName("ULONG64")]
        public ulong InFlsnpiClientClonedPackets;

        [NativeTypeName("ULONG64")]
        public ulong OutFlsnpiIndicatedPackets;

        [NativeTypeName("ULONG64")]
        public ulong OutFlsnpiClientReturnedPackets;

        [NativeTypeName("ULONG64")]
        public ulong OutFlsnpiClientDroppedPackets;

        [NativeTypeName("ULONG64")]
        public ulong OutFlsnpiClientSilentlyDroppedPackets;

        [NativeTypeName("ULONG64")]
        public ulong OutFlsnpiClientInjectedPackets;

        [NativeTypeName("ULONG64")]
        public ulong OutFlsnpiClientClonedPackets;

        [NativeTypeName("ULONG64")]
        public ulong OutFlsnpiClientClonedPacketsForNbSplit;
    }

    public partial struct _MIB_FL_VIRTUAL_INTERFACE_TABLE
    {
        [NativeTypeName("ULONG")]
        public uint NumEntries;

        [NativeTypeName("MIB_FL_VIRTUAL_INTERFACE_ROW[1]")]
        public _Table_e__FixedBuffer Table;

        public partial struct _Table_e__FixedBuffer
        {
            public _MIB_FL_VIRTUAL_INTERFACE_ROW e0;

            [UnscopedRef]
            public ref _MIB_FL_VIRTUAL_INTERFACE_ROW this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref Unsafe.Add(ref e0, index);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<_MIB_FL_VIRTUAL_INTERFACE_ROW> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
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

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetTcp6Table([NativeTypeName("PMIB_TCP6TABLE")] _MIB_TCP6TABLE* TcpTable, [NativeTypeName("PULONG")] uint* SizePointer, [NativeTypeName("BOOL")] int Order);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetTcp6Table2([NativeTypeName("PMIB_TCP6TABLE2")] _MIB_TCP6TABLE2* TcpTable, [NativeTypeName("PULONG")] uint* SizePointer, [NativeTypeName("BOOL")] int Order);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetPerTcpConnectionEStats([NativeTypeName("PMIB_TCPROW")] _MIB_TCPROW_LH* Row, [NativeTypeName("TCP_ESTATS_TYPE")] int EstatsType, [NativeTypeName("PUCHAR")] byte* Rw, [NativeTypeName("ULONG")] uint RwVersion, [NativeTypeName("ULONG")] uint RwSize, [NativeTypeName("PUCHAR")] byte* Ros, [NativeTypeName("ULONG")] uint RosVersion, [NativeTypeName("ULONG")] uint RosSize, [NativeTypeName("PUCHAR")] byte* Rod, [NativeTypeName("ULONG")] uint RodVersion, [NativeTypeName("ULONG")] uint RodSize);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint SetPerTcpConnectionEStats([NativeTypeName("PMIB_TCPROW")] _MIB_TCPROW_LH* Row, [NativeTypeName("TCP_ESTATS_TYPE")] int EstatsType, [NativeTypeName("PUCHAR")] byte* Rw, [NativeTypeName("ULONG")] uint RwVersion, [NativeTypeName("ULONG")] uint RwSize, [NativeTypeName("ULONG")] uint Offset);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetPerTcp6ConnectionEStats([NativeTypeName("PMIB_TCP6ROW")] _MIB_TCP6ROW* Row, [NativeTypeName("TCP_ESTATS_TYPE")] int EstatsType, [NativeTypeName("PUCHAR")] byte* Rw, [NativeTypeName("ULONG")] uint RwVersion, [NativeTypeName("ULONG")] uint RwSize, [NativeTypeName("PUCHAR")] byte* Ros, [NativeTypeName("ULONG")] uint RosVersion, [NativeTypeName("ULONG")] uint RosSize, [NativeTypeName("PUCHAR")] byte* Rod, [NativeTypeName("ULONG")] uint RodVersion, [NativeTypeName("ULONG")] uint RodSize);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint SetPerTcp6ConnectionEStats([NativeTypeName("PMIB_TCP6ROW")] _MIB_TCP6ROW* Row, [NativeTypeName("TCP_ESTATS_TYPE")] int EstatsType, [NativeTypeName("PUCHAR")] byte* Rw, [NativeTypeName("ULONG")] uint RwVersion, [NativeTypeName("ULONG")] uint RwSize, [NativeTypeName("ULONG")] uint Offset);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetOwnerModuleFromTcp6Entry([NativeTypeName("PMIB_TCP6ROW_OWNER_MODULE")] _MIB_TCP6ROW_OWNER_MODULE* pTcpEntry, [NativeTypeName("TCPIP_OWNER_MODULE_INFO_CLASS")] _TCPIP_OWNER_MODULE_INFO_CLASS Class, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("PDWORD")] uint* pdwSize);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint GetUdp6Table([NativeTypeName("PMIB_UDP6TABLE")] _MIB_UDP6TABLE* Udp6Table, [NativeTypeName("PULONG")] uint* SizePointer, [NativeTypeName("BOOL")] int Order);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetOwnerModuleFromUdp6Entry([NativeTypeName("PMIB_UDP6ROW_OWNER_MODULE")] _MIB_UDP6ROW_OWNER_MODULE* pUdpEntry, [NativeTypeName("TCPIP_OWNER_MODULE_INFO_CLASS")] _TCPIP_OWNER_MODULE_INFO_CLASS Class, [NativeTypeName("PVOID")] void* pBuffer, [NativeTypeName("PDWORD")] uint* pdwSize);

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
        [return: NativeTypeName("ULONG")]
        public static extern uint GetAdaptersAddresses([NativeTypeName("ULONG")] uint Family, [NativeTypeName("ULONG")] uint Flags, [NativeTypeName("PVOID")] void* Reserved, [NativeTypeName("PIP_ADAPTER_ADDRESSES")] _IP_ADAPTER_ADDRESSES_LH* AdapterAddresses, [NativeTypeName("PULONG")] uint* SizePointer);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetPerAdapterInfo([NativeTypeName("ULONG")] uint IfIndex, [NativeTypeName("PIP_PER_ADAPTER_INFO")] _IP_PER_ADAPTER_INFO_W2KSP1* pPerAdapterInfo, [NativeTypeName("PULONG")] uint* pOutBufLen);

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
        public static extern uint ResolveNeighbor(sockaddr* NetworkAddress, [NativeTypeName("PVOID")] void* PhysicalAddress, [NativeTypeName("PULONG")] uint* PhysicalAddressLength);

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

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIfEntry2([NativeTypeName("PMIB_IF_ROW2")] _MIB_IF_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIfTable2([NativeTypeName("PMIB_IF_TABLE2 *")] _MIB_IF_TABLE2** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIfTable2Ex([NativeTypeName("MIB_IF_TABLE_LEVEL")] _MIB_IF_TABLE_LEVEL Level, [NativeTypeName("PMIB_IF_TABLE2 *")] _MIB_IF_TABLE2** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIfStackTable([NativeTypeName("PMIB_IFSTACK_TABLE *")] _MIB_IFSTACK_TABLE** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetInvertedIfStackTable([NativeTypeName("PMIB_INVERTEDIFSTACK_TABLE *")] _MIB_INVERTEDIFSTACK_TABLE** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpInterfaceEntry([NativeTypeName("PMIB_IPINTERFACE_ROW")] _MIB_IPINTERFACE_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpInterfaceTable([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_IPINTERFACE_TABLE *")] _MIB_IPINTERFACE_TABLE** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void InitializeIpInterfaceEntry([NativeTypeName("PMIB_IPINTERFACE_ROW")] _MIB_IPINTERFACE_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyIpInterfaceChange([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PIPINTERFACE_CHANGE_CALLBACK")] delegate* unmanaged[Stdcall]<void*, _MIB_IPINTERFACE_ROW*, _MIB_NOTIFICATION_TYPE, void> Callback, [NativeTypeName("PVOID")] void* CallerContext, [NativeTypeName("BOOLEAN")] byte InitialNotification, [NativeTypeName("HANDLE *")] void** NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIpInterfaceEntry([NativeTypeName("PMIB_IPINTERFACE_ROW")] _MIB_IPINTERFACE_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpNetworkConnectionBandwidthEstimates([NativeTypeName("NET_IFINDEX")] uint InterfaceIndex, [NativeTypeName("ADDRESS_FAMILY")] ushort AddressFamily, [NativeTypeName("PMIB_IP_NETWORK_CONNECTION_BANDWIDTH_ESTIMATES")] _MIB_IP_NETWORK_CONNECTION_BANDWIDTH_ESTIMATES* BandwidthEstimates);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateUnicastIpAddressEntry([NativeTypeName("const MIB_UNICASTIPADDRESS_ROW *")] _MIB_UNICASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteUnicastIpAddressEntry([NativeTypeName("const MIB_UNICASTIPADDRESS_ROW *")] _MIB_UNICASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetUnicastIpAddressEntry([NativeTypeName("PMIB_UNICASTIPADDRESS_ROW")] _MIB_UNICASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetUnicastIpAddressTable([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_UNICASTIPADDRESS_TABLE *")] _MIB_UNICASTIPADDRESS_TABLE** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void InitializeUnicastIpAddressEntry([NativeTypeName("PMIB_UNICASTIPADDRESS_ROW")] _MIB_UNICASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyUnicastIpAddressChange([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PUNICAST_IPADDRESS_CHANGE_CALLBACK")] delegate* unmanaged[Stdcall]<void*, _MIB_UNICASTIPADDRESS_ROW*, _MIB_NOTIFICATION_TYPE, void> Callback, [NativeTypeName("PVOID")] void* CallerContext, [NativeTypeName("BOOLEAN")] byte InitialNotification, [NativeTypeName("HANDLE *")] void** NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyStableUnicastIpAddressTable([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_UNICASTIPADDRESS_TABLE *")] _MIB_UNICASTIPADDRESS_TABLE** Table, [NativeTypeName("PSTABLE_UNICAST_IPADDRESS_TABLE_CALLBACK")] delegate* unmanaged[Stdcall]<void*, _MIB_UNICASTIPADDRESS_TABLE*, void> CallerCallback, [NativeTypeName("PVOID")] void* CallerContext, [NativeTypeName("HANDLE *")] void** NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetUnicastIpAddressEntry([NativeTypeName("const MIB_UNICASTIPADDRESS_ROW *")] _MIB_UNICASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateAnycastIpAddressEntry([NativeTypeName("const MIB_ANYCASTIPADDRESS_ROW *")] _MIB_ANYCASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteAnycastIpAddressEntry([NativeTypeName("const MIB_ANYCASTIPADDRESS_ROW *")] _MIB_ANYCASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetAnycastIpAddressEntry([NativeTypeName("PMIB_ANYCASTIPADDRESS_ROW")] _MIB_ANYCASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetAnycastIpAddressTable([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_ANYCASTIPADDRESS_TABLE *")] _MIB_ANYCASTIPADDRESS_TABLE** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMulticastIpAddressEntry([NativeTypeName("PMIB_MULTICASTIPADDRESS_ROW")] _MIB_MULTICASTIPADDRESS_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetMulticastIpAddressTable([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_MULTICASTIPADDRESS_TABLE *")] _MIB_MULTICASTIPADDRESS_TABLE** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateIpForwardEntry2([NativeTypeName("const MIB_IPFORWARD_ROW2 *")] _MIB_IPFORWARD_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteIpForwardEntry2([NativeTypeName("const MIB_IPFORWARD_ROW2 *")] _MIB_IPFORWARD_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetBestRoute2([NativeTypeName("NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("NET_IFINDEX")] uint InterfaceIndex, [NativeTypeName("const SOCKADDR_INET *")] _SOCKADDR_INET* SourceAddress, [NativeTypeName("const SOCKADDR_INET *")] _SOCKADDR_INET* DestinationAddress, [NativeTypeName("ULONG")] uint AddressSortOptions, [NativeTypeName("PMIB_IPFORWARD_ROW2")] _MIB_IPFORWARD_ROW2* BestRoute, [NativeTypeName("SOCKADDR_INET *")] _SOCKADDR_INET* BestSourceAddress);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpForwardEntry2([NativeTypeName("PMIB_IPFORWARD_ROW2")] _MIB_IPFORWARD_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpForwardTable2([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_IPFORWARD_TABLE2 *")] _MIB_IPFORWARD_TABLE2** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void InitializeIpForwardEntry([NativeTypeName("PMIB_IPFORWARD_ROW2")] _MIB_IPFORWARD_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyRouteChange2([NativeTypeName("ADDRESS_FAMILY")] ushort AddressFamily, [NativeTypeName("PIPFORWARD_CHANGE_CALLBACK")] delegate* unmanaged[Stdcall]<void*, _MIB_IPFORWARD_ROW2*, _MIB_NOTIFICATION_TYPE, void> Callback, [NativeTypeName("PVOID")] void* CallerContext, [NativeTypeName("BOOLEAN")] byte InitialNotification, [NativeTypeName("HANDLE *")] void** NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIpForwardEntry2([NativeTypeName("const MIB_IPFORWARD_ROW2 *")] _MIB_IPFORWARD_ROW2* Route);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FlushIpPathTable([NativeTypeName("ADDRESS_FAMILY")] ushort Family);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpPathEntry([NativeTypeName("PMIB_IPPATH_ROW")] _MIB_IPPATH_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpPathTable([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_IPPATH_TABLE *")] _MIB_IPPATH_TABLE** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateIpNetEntry2([NativeTypeName("const MIB_IPNET_ROW2 *")] _MIB_IPNET_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteIpNetEntry2([NativeTypeName("const MIB_IPNET_ROW2 *")] _MIB_IPNET_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FlushIpNetTable2([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("NET_IFINDEX")] uint InterfaceIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpNetEntry2([NativeTypeName("PMIB_IPNET_ROW2")] _MIB_IPNET_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetIpNetTable2([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_IPNET_TABLE2 *")] _MIB_IPNET_TABLE2** Table);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ResolveIpNetEntry2([NativeTypeName("PMIB_IPNET_ROW2")] _MIB_IPNET_ROW2* Row, [NativeTypeName("const SOCKADDR_INET *")] _SOCKADDR_INET* SourceAddress);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetIpNetEntry2([NativeTypeName("PMIB_IPNET_ROW2")] _MIB_IPNET_ROW2* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyTeredoPortChange([NativeTypeName("PTEREDO_PORT_CHANGE_CALLBACK")] delegate* unmanaged[Stdcall]<void*, ushort, _MIB_NOTIFICATION_TYPE, void> Callback, [NativeTypeName("PVOID")] void* CallerContext, [NativeTypeName("BOOLEAN")] byte InitialNotification, [NativeTypeName("HANDLE *")] void** NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetTeredoPort(ushort* Port);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CancelMibChangeNotify2([NativeTypeName("HANDLE")] void* NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void FreeMibTable([NativeTypeName("PVOID")] void* Memory);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateSortedAddressPairs([NativeTypeName("const PSOCKADDR_IN6")] sockaddr_in6* SourceAddressList, [NativeTypeName("ULONG")] uint SourceAddressCount, [NativeTypeName("const PSOCKADDR_IN6")] sockaddr_in6* DestinationAddressList, [NativeTypeName("ULONG")] uint DestinationAddressCount, [NativeTypeName("ULONG")] uint AddressSortOptions, [NativeTypeName("PSOCKADDR_IN6_PAIR *")] _sockaddr_in6_pair** SortedAddressPairList, [NativeTypeName("ULONG *")] uint* SortedAddressPairCount);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertCompartmentGuidToId([NativeTypeName("const GUID *")] Guid* CompartmentGuid, [NativeTypeName("PNET_IF_COMPARTMENT_ID")] uint* CompartmentId);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertCompartmentIdToGuid([NativeTypeName("NET_IF_COMPARTMENT_ID")] uint CompartmentId, Guid* CompartmentGuid);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceNameToLuidA([NativeTypeName("const CHAR *")] sbyte* InterfaceName, [NativeTypeName("NET_LUID *")] _NET_LUID_LH* InterfaceLuid);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceNameToLuidW([NativeTypeName("const WCHAR *")] char* InterfaceName, [NativeTypeName("NET_LUID *")] _NET_LUID_LH* InterfaceLuid);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceLuidToNameA([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PSTR")] sbyte* InterfaceName, [NativeTypeName("SIZE_T")] ulong Length);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceLuidToNameW([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PWSTR")] char* InterfaceName, [NativeTypeName("SIZE_T")] ulong Length);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceLuidToIndex([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PNET_IFINDEX")] uint* InterfaceIndex);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceIndexToLuid([NativeTypeName("NET_IFINDEX")] uint InterfaceIndex, [NativeTypeName("PNET_LUID")] _NET_LUID_LH* InterfaceLuid);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceLuidToAlias([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, [NativeTypeName("PWSTR")] char* InterfaceAlias, [NativeTypeName("SIZE_T")] ulong Length);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceAliasToLuid([NativeTypeName("const WCHAR *")] char* InterfaceAlias, [NativeTypeName("PNET_LUID")] _NET_LUID_LH* InterfaceLuid);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceLuidToGuid([NativeTypeName("const NET_LUID *")] _NET_LUID_LH* InterfaceLuid, Guid* InterfaceGuid);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertInterfaceGuidToLuid([NativeTypeName("const GUID *")] Guid* InterfaceGuid, [NativeTypeName("PNET_LUID")] _NET_LUID_LH* InterfaceLuid);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("NET_IFINDEX")]
        public static extern uint if_nametoindex([NativeTypeName("PCSTR")] sbyte* InterfaceName);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("PCHAR")]
        public static extern sbyte* if_indextoname([NativeTypeName("NET_IFINDEX")] uint InterfaceIndex, [NativeTypeName("PCHAR")] sbyte* InterfaceName);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("NET_IF_COMPARTMENT_ID")]
        public static extern uint GetCurrentThreadCompartmentId();

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetCurrentThreadCompartmentId([NativeTypeName("NET_IF_COMPARTMENT_ID")] uint CompartmentId);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void GetCurrentThreadCompartmentScope([NativeTypeName("PNET_IF_COMPARTMENT_SCOPE")] uint* CompartmentScope, [NativeTypeName("PNET_IF_COMPARTMENT_ID")] uint* CompartmentId);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetCurrentThreadCompartmentScope([NativeTypeName("NET_IF_COMPARTMENT_SCOPE")] uint CompartmentScope);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("NET_IF_COMPARTMENT_ID")]
        public static extern uint GetJobCompartmentId([NativeTypeName("HANDLE")] void* JobHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetJobCompartmentId([NativeTypeName("HANDLE")] void* JobHandle, [NativeTypeName("NET_IF_COMPARTMENT_ID")] uint CompartmentId);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("NET_IF_COMPARTMENT_ID")]
        public static extern uint GetSessionCompartmentId([NativeTypeName("ULONG")] uint SessionId);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetSessionCompartmentId([NativeTypeName("ULONG")] uint SessionId, [NativeTypeName("NET_IF_COMPARTMENT_ID")] uint CompartmentId);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("NET_IF_COMPARTMENT_ID")]
        public static extern uint GetDefaultCompartmentId();

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetNetworkInformation([NativeTypeName("const NET_IF_NETWORK_GUID *")] Guid* NetworkGuid, [NativeTypeName("PNET_IF_COMPARTMENT_ID")] uint* CompartmentId, [NativeTypeName("PULONG")] uint* SiteId, [NativeTypeName("PWCHAR")] char* NetworkName, [NativeTypeName("ULONG")] uint Length);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetNetworkInformation([NativeTypeName("const NET_IF_NETWORK_GUID *")] Guid* NetworkGuid, [NativeTypeName("NET_IF_COMPARTMENT_ID")] uint CompartmentId, [NativeTypeName("const WCHAR *")] char* NetworkName);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertLengthToIpv4Mask([NativeTypeName("ULONG")] uint MaskLength, [NativeTypeName("PULONG")] uint* Mask);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint ConvertIpv4MaskToLength([NativeTypeName("ULONG")] uint Mask, [NativeTypeName("PUINT8")] byte* MaskLength);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetDnsSettings([NativeTypeName("DNS_SETTINGS *")] _DNS_SETTINGS* Settings);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void FreeDnsSettings([NativeTypeName("DNS_SETTINGS *")] _DNS_SETTINGS* Settings);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetDnsSettings([NativeTypeName("const DNS_SETTINGS *")] _DNS_SETTINGS* Settings);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetInterfaceDnsSettings(Guid Interface, [NativeTypeName("DNS_INTERFACE_SETTINGS *")] _DNS_INTERFACE_SETTINGS* Settings);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void FreeInterfaceDnsSettings([NativeTypeName("DNS_INTERFACE_SETTINGS *")] _DNS_INTERFACE_SETTINGS* Settings);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetInterfaceDnsSettings(Guid Interface, [NativeTypeName("const DNS_INTERFACE_SETTINGS *")] _DNS_INTERFACE_SETTINGS* Settings);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetNetworkConnectivityHint([NativeTypeName("NL_NETWORK_CONNECTIVITY_HINT *")] _NL_NETWORK_CONNECTIVITY_HINT* ConnectivityHint);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetNetworkConnectivityHintForInterface([NativeTypeName("NET_IFINDEX")] uint InterfaceIndex, [NativeTypeName("NL_NETWORK_CONNECTIVITY_HINT *")] _NL_NETWORK_CONNECTIVITY_HINT* ConnectivityHint);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint NotifyNetworkConnectivityHintChange([NativeTypeName("PNETWORK_CONNECTIVITY_HINT_CHANGE_CALLBACK")] delegate* unmanaged[Stdcall]<void*, _NL_NETWORK_CONNECTIVITY_HINT, void> Callback, [NativeTypeName("PVOID")] void* CallerContext, [NativeTypeName("BOOLEAN")] byte InitialNotification, [NativeTypeName("PHANDLE")] void** NotificationHandle);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CreateFlVirtualInterface([NativeTypeName("const MIB_FL_VIRTUAL_INTERFACE_ROW *")] _MIB_FL_VIRTUAL_INTERFACE_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint DeleteFlVirtualInterface([NativeTypeName("const MIB_FL_VIRTUAL_INTERFACE_ROW *")] _MIB_FL_VIRTUAL_INTERFACE_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void InitializeFlVirtualInterfaceEntry([NativeTypeName("PMIB_FL_VIRTUAL_INTERFACE_ROW")] _MIB_FL_VIRTUAL_INTERFACE_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SetFlVirtualInterface([NativeTypeName("const MIB_FL_VIRTUAL_INTERFACE_ROW *")] _MIB_FL_VIRTUAL_INTERFACE_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFlVirtualInterface([NativeTypeName("PMIB_FL_VIRTUAL_INTERFACE_ROW")] _MIB_FL_VIRTUAL_INTERFACE_ROW* Row);

        [DllImport("iphlpapi", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetFlVirtualInterfaceTable([NativeTypeName("ADDRESS_FAMILY")] ushort Family, [NativeTypeName("PMIB_FL_VIRTUAL_INTERFACE_TABLE *")] _MIB_FL_VIRTUAL_INTERFACE_TABLE** Table);

        [NativeTypeName("#define AF_UNSPEC 0")]
        public const int AF_UNSPEC = 0;

        [NativeTypeName("#define AF_UNIX 1")]
        public const int AF_UNIX = 1;

        [NativeTypeName("#define AF_INET 2")]
        public const int AF_INET = 2;

        [NativeTypeName("#define AF_IMPLINK 3")]
        public const int AF_IMPLINK = 3;

        [NativeTypeName("#define AF_PUP 4")]
        public const int AF_PUP = 4;

        [NativeTypeName("#define AF_CHAOS 5")]
        public const int AF_CHAOS = 5;

        [NativeTypeName("#define AF_NS 6")]
        public const int AF_NS = 6;

        [NativeTypeName("#define AF_IPX AF_NS")]
        public const int AF_IPX = 6;

        [NativeTypeName("#define AF_ISO 7")]
        public const int AF_ISO = 7;

        [NativeTypeName("#define AF_OSI AF_ISO")]
        public const int AF_OSI = 7;

        [NativeTypeName("#define AF_ECMA 8")]
        public const int AF_ECMA = 8;

        [NativeTypeName("#define AF_DATAKIT 9")]
        public const int AF_DATAKIT = 9;

        [NativeTypeName("#define AF_CCITT 10")]
        public const int AF_CCITT = 10;

        [NativeTypeName("#define AF_SNA 11")]
        public const int AF_SNA = 11;

        [NativeTypeName("#define AF_DECnet 12")]
        public const int AF_DECnet = 12;

        [NativeTypeName("#define AF_DLI 13")]
        public const int AF_DLI = 13;

        [NativeTypeName("#define AF_LAT 14")]
        public const int AF_LAT = 14;

        [NativeTypeName("#define AF_HYLINK 15")]
        public const int AF_HYLINK = 15;

        [NativeTypeName("#define AF_APPLETALK 16")]
        public const int AF_APPLETALK = 16;

        [NativeTypeName("#define AF_NETBIOS 17")]
        public const int AF_NETBIOS = 17;

        [NativeTypeName("#define AF_VOICEVIEW 18")]
        public const int AF_VOICEVIEW = 18;

        [NativeTypeName("#define AF_FIREFOX 19")]
        public const int AF_FIREFOX = 19;

        [NativeTypeName("#define AF_UNKNOWN1 20")]
        public const int AF_UNKNOWN1 = 20;

        [NativeTypeName("#define AF_BAN 21")]
        public const int AF_BAN = 21;

        [NativeTypeName("#define AF_ATM 22")]
        public const int AF_ATM = 22;

        [NativeTypeName("#define AF_INET6 23")]
        public const int AF_INET6 = 23;

        [NativeTypeName("#define AF_CLUSTER 24")]
        public const int AF_CLUSTER = 24;

        [NativeTypeName("#define AF_12844 25")]
        public const int AF_12844 = 25;

        [NativeTypeName("#define AF_IRDA 26")]
        public const int AF_IRDA = 26;

        [NativeTypeName("#define AF_NETDES 28")]
        public const int AF_NETDES = 28;

        [NativeTypeName("#define AF_TCNPROCESS 29")]
        public const int AF_TCNPROCESS = 29;

        [NativeTypeName("#define AF_TCNMESSAGE 30")]
        public const int AF_TCNMESSAGE = 30;

        [NativeTypeName("#define AF_ICLFXBM 31")]
        public const int AF_ICLFXBM = 31;

        [NativeTypeName("#define AF_BTH 32")]
        public const int AF_BTH = 32;

        [NativeTypeName("#define AF_MAX 33")]
        public const int AF_MAX = 33;

        [NativeTypeName("#define SOCK_STREAM 1")]
        public const int SOCK_STREAM = 1;

        [NativeTypeName("#define SOCK_DGRAM 2")]
        public const int SOCK_DGRAM = 2;

        [NativeTypeName("#define SOCK_RAW 3")]
        public const int SOCK_RAW = 3;

        [NativeTypeName("#define SOCK_RDM 4")]
        public const int SOCK_RDM = 4;

        [NativeTypeName("#define SOCK_SEQPACKET 5")]
        public const int SOCK_SEQPACKET = 5;

        [NativeTypeName("#define SOL_SOCKET 0xffff")]
        public const int SOL_SOCKET = 0xffff;

        [NativeTypeName("#define SOL_IP (SOL_SOCKET-4)")]
        public const int SOL_IP = (0xffff - 4);

        [NativeTypeName("#define SOL_IPV6 (SOL_SOCKET-5)")]
        public const int SOL_IPV6 = (0xffff - 5);

        [NativeTypeName("#define SO_DEBUG 0x0001")]
        public const int SO_DEBUG = 0x0001;

        [NativeTypeName("#define SO_ACCEPTCONN 0x0002")]
        public const int SO_ACCEPTCONN = 0x0002;

        [NativeTypeName("#define SO_REUSEADDR 0x0004")]
        public const int SO_REUSEADDR = 0x0004;

        [NativeTypeName("#define SO_KEEPALIVE 0x0008")]
        public const int SO_KEEPALIVE = 0x0008;

        [NativeTypeName("#define SO_DONTROUTE 0x0010")]
        public const int SO_DONTROUTE = 0x0010;

        [NativeTypeName("#define SO_BROADCAST 0x0020")]
        public const int SO_BROADCAST = 0x0020;

        [NativeTypeName("#define SO_USELOOPBACK 0x0040")]
        public const int SO_USELOOPBACK = 0x0040;

        [NativeTypeName("#define SO_LINGER 0x0080")]
        public const int SO_LINGER = 0x0080;

        [NativeTypeName("#define SO_OOBINLINE 0x0100")]
        public const int SO_OOBINLINE = 0x0100;

        [NativeTypeName("#define SO_DONTLINGER (int)(~SO_LINGER)")]
        public const int SO_DONTLINGER = (int)(~0x0080);

        [NativeTypeName("#define SO_EXCLUSIVEADDRUSE ((int)(~SO_REUSEADDR))")]
        public const int SO_EXCLUSIVEADDRUSE = ((int)(~0x0004));

        [NativeTypeName("#define SO_SNDBUF 0x1001")]
        public const int SO_SNDBUF = 0x1001;

        [NativeTypeName("#define SO_RCVBUF 0x1002")]
        public const int SO_RCVBUF = 0x1002;

        [NativeTypeName("#define SO_SNDLOWAT 0x1003")]
        public const int SO_SNDLOWAT = 0x1003;

        [NativeTypeName("#define SO_RCVLOWAT 0x1004")]
        public const int SO_RCVLOWAT = 0x1004;

        [NativeTypeName("#define SO_SNDTIMEO 0x1005")]
        public const int SO_SNDTIMEO = 0x1005;

        [NativeTypeName("#define SO_RCVTIMEO 0x1006")]
        public const int SO_RCVTIMEO = 0x1006;

        [NativeTypeName("#define SO_ERROR 0x1007")]
        public const int SO_ERROR = 0x1007;

        [NativeTypeName("#define SO_TYPE 0x1008")]
        public const int SO_TYPE = 0x1008;

        [NativeTypeName("#define SO_BSP_STATE 0x1009")]
        public const int SO_BSP_STATE = 0x1009;

        [NativeTypeName("#define SO_GROUP_ID 0x2001")]
        public const int SO_GROUP_ID = 0x2001;

        [NativeTypeName("#define SO_GROUP_PRIORITY 0x2002")]
        public const int SO_GROUP_PRIORITY = 0x2002;

        [NativeTypeName("#define SO_MAX_MSG_SIZE 0x2003")]
        public const int SO_MAX_MSG_SIZE = 0x2003;

        [NativeTypeName("#define SO_CONDITIONAL_ACCEPT 0x3002")]
        public const int SO_CONDITIONAL_ACCEPT = 0x3002;

        [NativeTypeName("#define SO_PAUSE_ACCEPT 0x3003")]
        public const int SO_PAUSE_ACCEPT = 0x3003;

        [NativeTypeName("#define SO_COMPARTMENT_ID 0x3004")]
        public const int SO_COMPARTMENT_ID = 0x3004;

        [NativeTypeName("#define SO_RANDOMIZE_PORT 0x3005")]
        public const int SO_RANDOMIZE_PORT = 0x3005;

        [NativeTypeName("#define SO_PORT_SCALABILITY 0x3006")]
        public const int SO_PORT_SCALABILITY = 0x3006;

        [NativeTypeName("#define SO_REUSE_UNICASTPORT 0x3007")]
        public const int SO_REUSE_UNICASTPORT = 0x3007;

        [NativeTypeName("#define SO_REUSE_MULTICASTPORT 0x3008")]
        public const int SO_REUSE_MULTICASTPORT = 0x3008;

        [NativeTypeName("#define SO_ORIGINAL_DST 0x300F")]
        public const int SO_ORIGINAL_DST = 0x300F;

        [NativeTypeName("#define IP6T_SO_ORIGINAL_DST SO_ORIGINAL_DST")]
        public const int IP6T_SO_ORIGINAL_DST = 0x300F;

        [NativeTypeName("#define WSK_SO_BASE 0x4000")]
        public const int WSK_SO_BASE = 0x4000;

        [NativeTypeName("#define TCP_NODELAY 0x0001")]
        public const int TCP_NODELAY = 0x0001;

        [NativeTypeName("#define _SS_MAXSIZE 128")]
        public const int _SS_MAXSIZE = 128;

        [NativeTypeName("#define _SS_ALIGNSIZE (sizeof(__int64))")]
        public const ulong _SS_ALIGNSIZE = (8);

        [NativeTypeName("#define _SS_PAD1SIZE (_SS_ALIGNSIZE - sizeof(USHORT))")]
        public const ulong _SS_PAD1SIZE = ((8) - 2);

        [NativeTypeName("#define _SS_PAD2SIZE (_SS_MAXSIZE - (sizeof(USHORT) + _SS_PAD1SIZE + _SS_ALIGNSIZE))")]
        public const ulong _SS_PAD2SIZE = (128 - (2 + ((8) - 2) + (8)));

        [NativeTypeName("#define IOC_UNIX 0x00000000")]
        public const int IOC_UNIX = 0x00000000;

        [NativeTypeName("#define IOC_WS2 0x08000000")]
        public const int IOC_WS2 = 0x08000000;

        [NativeTypeName("#define IOC_PROTOCOL 0x10000000")]
        public const int IOC_PROTOCOL = 0x10000000;

        [NativeTypeName("#define IOC_VENDOR 0x18000000")]
        public const int IOC_VENDOR = 0x18000000;

        [NativeTypeName("#define IOC_WSK (IOC_WS2|0x07000000)")]
        public const int IOC_WSK = (0x08000000 | 0x07000000);

        [NativeTypeName("#define SIO_ASSOCIATE_HANDLE _WSAIOW(IOC_WS2,1)")]
        public const uint SIO_ASSOCIATE_HANDLE = (0x80000000 | (0x08000000) | (1));

        [NativeTypeName("#define SIO_ENABLE_CIRCULAR_QUEUEING _WSAIO(IOC_WS2,2)")]
        public const int SIO_ENABLE_CIRCULAR_QUEUEING = (0x20000000 | (0x08000000) | (2));

        [NativeTypeName("#define SIO_FIND_ROUTE _WSAIOR(IOC_WS2,3)")]
        public const int SIO_FIND_ROUTE = (0x40000000 | (0x08000000) | (3));

        [NativeTypeName("#define SIO_FLUSH _WSAIO(IOC_WS2,4)")]
        public const int SIO_FLUSH = (0x20000000 | (0x08000000) | (4));

        [NativeTypeName("#define SIO_GET_BROADCAST_ADDRESS _WSAIOR(IOC_WS2,5)")]
        public const int SIO_GET_BROADCAST_ADDRESS = (0x40000000 | (0x08000000) | (5));

        [NativeTypeName("#define SIO_GET_EXTENSION_FUNCTION_POINTER _WSAIORW(IOC_WS2,6)")]
        public const uint SIO_GET_EXTENSION_FUNCTION_POINTER = ((0x80000000 | 0x40000000) | (0x08000000) | (6));

        [NativeTypeName("#define SIO_GET_QOS _WSAIORW(IOC_WS2,7)")]
        public const uint SIO_GET_QOS = ((0x80000000 | 0x40000000) | (0x08000000) | (7));

        [NativeTypeName("#define SIO_GET_GROUP_QOS _WSAIORW(IOC_WS2,8)")]
        public const uint SIO_GET_GROUP_QOS = ((0x80000000 | 0x40000000) | (0x08000000) | (8));

        [NativeTypeName("#define SIO_MULTIPOINT_LOOPBACK _WSAIOW(IOC_WS2,9)")]
        public const uint SIO_MULTIPOINT_LOOPBACK = (0x80000000 | (0x08000000) | (9));

        [NativeTypeName("#define SIO_MULTICAST_SCOPE _WSAIOW(IOC_WS2,10)")]
        public const uint SIO_MULTICAST_SCOPE = (0x80000000 | (0x08000000) | (10));

        [NativeTypeName("#define SIO_SET_QOS _WSAIOW(IOC_WS2,11)")]
        public const uint SIO_SET_QOS = (0x80000000 | (0x08000000) | (11));

        [NativeTypeName("#define SIO_SET_GROUP_QOS _WSAIOW(IOC_WS2,12)")]
        public const uint SIO_SET_GROUP_QOS = (0x80000000 | (0x08000000) | (12));

        [NativeTypeName("#define SIO_TRANSLATE_HANDLE _WSAIORW(IOC_WS2,13)")]
        public const uint SIO_TRANSLATE_HANDLE = ((0x80000000 | 0x40000000) | (0x08000000) | (13));

        [NativeTypeName("#define SIO_ROUTING_INTERFACE_QUERY _WSAIORW(IOC_WS2,20)")]
        public const uint SIO_ROUTING_INTERFACE_QUERY = ((0x80000000 | 0x40000000) | (0x08000000) | (20));

        [NativeTypeName("#define SIO_ROUTING_INTERFACE_CHANGE _WSAIOW(IOC_WS2,21)")]
        public const uint SIO_ROUTING_INTERFACE_CHANGE = (0x80000000 | (0x08000000) | (21));

        [NativeTypeName("#define SIO_ADDRESS_LIST_QUERY _WSAIOR(IOC_WS2,22)")]
        public const int SIO_ADDRESS_LIST_QUERY = (0x40000000 | (0x08000000) | (22));

        [NativeTypeName("#define SIO_ADDRESS_LIST_CHANGE _WSAIO(IOC_WS2,23)")]
        public const int SIO_ADDRESS_LIST_CHANGE = (0x20000000 | (0x08000000) | (23));

        [NativeTypeName("#define SIO_QUERY_TARGET_PNP_HANDLE _WSAIOR(IOC_WS2,24)")]
        public const int SIO_QUERY_TARGET_PNP_HANDLE = (0x40000000 | (0x08000000) | (24));

        [NativeTypeName("#define SIO_QUERY_RSS_PROCESSOR_INFO _WSAIOR(IOC_WS2,37)")]
        public const int SIO_QUERY_RSS_PROCESSOR_INFO = (0x40000000 | (0x08000000) | (37));

        [NativeTypeName("#define SIO_ADDRESS_LIST_SORT _WSAIORW(IOC_WS2,25)")]
        public const uint SIO_ADDRESS_LIST_SORT = ((0x80000000 | 0x40000000) | (0x08000000) | (25));

        [NativeTypeName("#define SIO_RESERVED_1 _WSAIOW(IOC_WS2,26)")]
        public const uint SIO_RESERVED_1 = (0x80000000 | (0x08000000) | (26));

        [NativeTypeName("#define SIO_RESERVED_2 _WSAIOW(IOC_WS2,33)")]
        public const uint SIO_RESERVED_2 = (0x80000000 | (0x08000000) | (33));

        [NativeTypeName("#define SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER _WSAIORW(IOC_WS2,36)")]
        public const uint SIO_GET_MULTIPLE_EXTENSION_FUNCTION_POINTER = ((0x80000000 | 0x40000000) | (0x08000000) | (36));

        [NativeTypeName("#define IPPROTO_IP 0")]
        public const int IPPROTO_IP = 0;

        [NativeTypeName("#define IPPORT_TCPMUX 1")]
        public const int IPPORT_TCPMUX = 1;

        [NativeTypeName("#define IPPORT_ECHO 7")]
        public const int IPPORT_ECHO = 7;

        [NativeTypeName("#define IPPORT_DISCARD 9")]
        public const int IPPORT_DISCARD = 9;

        [NativeTypeName("#define IPPORT_SYSTAT 11")]
        public const int IPPORT_SYSTAT = 11;

        [NativeTypeName("#define IPPORT_DAYTIME 13")]
        public const int IPPORT_DAYTIME = 13;

        [NativeTypeName("#define IPPORT_NETSTAT 15")]
        public const int IPPORT_NETSTAT = 15;

        [NativeTypeName("#define IPPORT_QOTD 17")]
        public const int IPPORT_QOTD = 17;

        [NativeTypeName("#define IPPORT_MSP 18")]
        public const int IPPORT_MSP = 18;

        [NativeTypeName("#define IPPORT_CHARGEN 19")]
        public const int IPPORT_CHARGEN = 19;

        [NativeTypeName("#define IPPORT_FTP_DATA 20")]
        public const int IPPORT_FTP_DATA = 20;

        [NativeTypeName("#define IPPORT_FTP 21")]
        public const int IPPORT_FTP = 21;

        [NativeTypeName("#define IPPORT_TELNET 23")]
        public const int IPPORT_TELNET = 23;

        [NativeTypeName("#define IPPORT_SMTP 25")]
        public const int IPPORT_SMTP = 25;

        [NativeTypeName("#define IPPORT_TIMESERVER 37")]
        public const int IPPORT_TIMESERVER = 37;

        [NativeTypeName("#define IPPORT_NAMESERVER 42")]
        public const int IPPORT_NAMESERVER = 42;

        [NativeTypeName("#define IPPORT_WHOIS 43")]
        public const int IPPORT_WHOIS = 43;

        [NativeTypeName("#define IPPORT_MTP 57")]
        public const int IPPORT_MTP = 57;

        [NativeTypeName("#define IPPORT_TFTP 69")]
        public const int IPPORT_TFTP = 69;

        [NativeTypeName("#define IPPORT_RJE 77")]
        public const int IPPORT_RJE = 77;

        [NativeTypeName("#define IPPORT_FINGER 79")]
        public const int IPPORT_FINGER = 79;

        [NativeTypeName("#define IPPORT_TTYLINK 87")]
        public const int IPPORT_TTYLINK = 87;

        [NativeTypeName("#define IPPORT_SUPDUP 95")]
        public const int IPPORT_SUPDUP = 95;

        [NativeTypeName("#define IPPORT_POP3 110")]
        public const int IPPORT_POP3 = 110;

        [NativeTypeName("#define IPPORT_NTP 123")]
        public const int IPPORT_NTP = 123;

        [NativeTypeName("#define IPPORT_EPMAP 135")]
        public const int IPPORT_EPMAP = 135;

        [NativeTypeName("#define IPPORT_NETBIOS_NS 137")]
        public const int IPPORT_NETBIOS_NS = 137;

        [NativeTypeName("#define IPPORT_NETBIOS_DGM 138")]
        public const int IPPORT_NETBIOS_DGM = 138;

        [NativeTypeName("#define IPPORT_NETBIOS_SSN 139")]
        public const int IPPORT_NETBIOS_SSN = 139;

        [NativeTypeName("#define IPPORT_IMAP 143")]
        public const int IPPORT_IMAP = 143;

        [NativeTypeName("#define IPPORT_SNMP 161")]
        public const int IPPORT_SNMP = 161;

        [NativeTypeName("#define IPPORT_SNMP_TRAP 162")]
        public const int IPPORT_SNMP_TRAP = 162;

        [NativeTypeName("#define IPPORT_IMAP3 220")]
        public const int IPPORT_IMAP3 = 220;

        [NativeTypeName("#define IPPORT_LDAP 389")]
        public const int IPPORT_LDAP = 389;

        [NativeTypeName("#define IPPORT_HTTPS 443")]
        public const int IPPORT_HTTPS = 443;

        [NativeTypeName("#define IPPORT_MICROSOFT_DS 445")]
        public const int IPPORT_MICROSOFT_DS = 445;

        [NativeTypeName("#define IPPORT_EXECSERVER 512")]
        public const int IPPORT_EXECSERVER = 512;

        [NativeTypeName("#define IPPORT_LOGINSERVER 513")]
        public const int IPPORT_LOGINSERVER = 513;

        [NativeTypeName("#define IPPORT_CMDSERVER 514")]
        public const int IPPORT_CMDSERVER = 514;

        [NativeTypeName("#define IPPORT_EFSSERVER 520")]
        public const int IPPORT_EFSSERVER = 520;

        [NativeTypeName("#define IPPORT_BIFFUDP 512")]
        public const int IPPORT_BIFFUDP = 512;

        [NativeTypeName("#define IPPORT_WHOSERVER 513")]
        public const int IPPORT_WHOSERVER = 513;

        [NativeTypeName("#define IPPORT_ROUTESERVER 520")]
        public const int IPPORT_ROUTESERVER = 520;

        [NativeTypeName("#define IPPORT_RESERVED 1024")]
        public const int IPPORT_RESERVED = 1024;

        [NativeTypeName("#define IPPORT_REGISTERED_MIN IPPORT_RESERVED")]
        public const int IPPORT_REGISTERED_MIN = 1024;

        [NativeTypeName("#define IPPORT_REGISTERED_MAX 0xbfff")]
        public const int IPPORT_REGISTERED_MAX = 0xbfff;

        [NativeTypeName("#define IPPORT_DYNAMIC_MIN 0xc000")]
        public const int IPPORT_DYNAMIC_MIN = 0xc000;

        [NativeTypeName("#define IPPORT_DYNAMIC_MAX 0xffff")]
        public const int IPPORT_DYNAMIC_MAX = 0xffff;

        [NativeTypeName("#define IN_CLASSA_NET 0xff000000")]
        public const uint IN_CLASSA_NET = 0xff000000;

        [NativeTypeName("#define IN_CLASSA_NSHIFT 24")]
        public const int IN_CLASSA_NSHIFT = 24;

        [NativeTypeName("#define IN_CLASSA_HOST 0x00ffffff")]
        public const int IN_CLASSA_HOST = 0x00ffffff;

        [NativeTypeName("#define IN_CLASSA_MAX 128")]
        public const int IN_CLASSA_MAX = 128;

        [NativeTypeName("#define IN_CLASSB_NET 0xffff0000")]
        public const uint IN_CLASSB_NET = 0xffff0000;

        [NativeTypeName("#define IN_CLASSB_NSHIFT 16")]
        public const int IN_CLASSB_NSHIFT = 16;

        [NativeTypeName("#define IN_CLASSB_HOST 0x0000ffff")]
        public const int IN_CLASSB_HOST = 0x0000ffff;

        [NativeTypeName("#define IN_CLASSB_MAX 65536")]
        public const int IN_CLASSB_MAX = 65536;

        [NativeTypeName("#define IN_CLASSC_NET 0xffffff00")]
        public const uint IN_CLASSC_NET = 0xffffff00;

        [NativeTypeName("#define IN_CLASSC_NSHIFT 8")]
        public const int IN_CLASSC_NSHIFT = 8;

        [NativeTypeName("#define IN_CLASSC_HOST 0x000000ff")]
        public const int IN_CLASSC_HOST = 0x000000ff;

        [NativeTypeName("#define IN_CLASSD_NET 0xf0000000")]
        public const uint IN_CLASSD_NET = 0xf0000000;

        [NativeTypeName("#define IN_CLASSD_NSHIFT 28")]
        public const int IN_CLASSD_NSHIFT = 28;

        [NativeTypeName("#define IN_CLASSD_HOST 0x0fffffff")]
        public const int IN_CLASSD_HOST = 0x0fffffff;

        [NativeTypeName("#define INADDR_ANY (ULONG)0x00000000")]
        public const uint INADDR_ANY = (uint)(0x00000000);

        [NativeTypeName("#define INADDR_LOOPBACK 0x7f000001")]
        public const int INADDR_LOOPBACK = 0x7f000001;

        [NativeTypeName("#define INADDR_BROADCAST (ULONG)0xffffffff")]
        public const uint INADDR_BROADCAST = (uint)(0xffffffff);

        [NativeTypeName("#define INADDR_NONE 0xffffffff")]
        public const uint INADDR_NONE = 0xffffffff;

        [NativeTypeName("#define IOCPARM_MASK 0x7f")]
        public const int IOCPARM_MASK = 0x7f;

        [NativeTypeName("#define IOC_VOID 0x20000000")]
        public const int IOC_VOID = 0x20000000;

        [NativeTypeName("#define IOC_OUT 0x40000000")]
        public const int IOC_OUT = 0x40000000;

        [NativeTypeName("#define IOC_IN 0x80000000")]
        public const uint IOC_IN = 0x80000000;

        [NativeTypeName("#define IOC_INOUT (IOC_IN|IOC_OUT)")]
        public const uint IOC_INOUT = (0x80000000 | 0x40000000);

        [NativeTypeName("#define MSG_TRUNC 0x0100")]
        public const int MSG_TRUNC = 0x0100;

        [NativeTypeName("#define MSG_CTRUNC 0x0200")]
        public const int MSG_CTRUNC = 0x0200;

        [NativeTypeName("#define MSG_BCAST 0x0400")]
        public const int MSG_BCAST = 0x0400;

        [NativeTypeName("#define MSG_MCAST 0x0800")]
        public const int MSG_MCAST = 0x0800;

        [NativeTypeName("#define MSG_ERRQUEUE 0x1000")]
        public const int MSG_ERRQUEUE = 0x1000;

        [NativeTypeName("#define AI_PASSIVE 0x00000001")]
        public const int AI_PASSIVE = 0x00000001;

        [NativeTypeName("#define AI_CANONNAME 0x00000002")]
        public const int AI_CANONNAME = 0x00000002;

        [NativeTypeName("#define AI_NUMERICHOST 0x00000004")]
        public const int AI_NUMERICHOST = 0x00000004;

        [NativeTypeName("#define AI_NUMERICSERV 0x00000008")]
        public const int AI_NUMERICSERV = 0x00000008;

        [NativeTypeName("#define AI_DNS_ONLY 0x00000010")]
        public const int AI_DNS_ONLY = 0x00000010;

        [NativeTypeName("#define AI_FORCE_CLEAR_TEXT 0x00000020")]
        public const int AI_FORCE_CLEAR_TEXT = 0x00000020;

        [NativeTypeName("#define AI_BYPASS_DNS_CACHE 0x00000040")]
        public const int AI_BYPASS_DNS_CACHE = 0x00000040;

        [NativeTypeName("#define AI_RETURN_TTL 0x00000080")]
        public const int AI_RETURN_TTL = 0x00000080;

        [NativeTypeName("#define AI_ALL 0x00000100")]
        public const int AI_ALL = 0x00000100;

        [NativeTypeName("#define AI_ADDRCONFIG 0x00000400")]
        public const int AI_ADDRCONFIG = 0x00000400;

        [NativeTypeName("#define AI_V4MAPPED 0x00000800")]
        public const int AI_V4MAPPED = 0x00000800;

        [NativeTypeName("#define AI_NON_AUTHORITATIVE 0x00004000")]
        public const int AI_NON_AUTHORITATIVE = 0x00004000;

        [NativeTypeName("#define AI_SECURE 0x00008000")]
        public const int AI_SECURE = 0x00008000;

        [NativeTypeName("#define AI_RETURN_PREFERRED_NAMES 0x00010000")]
        public const int AI_RETURN_PREFERRED_NAMES = 0x00010000;

        [NativeTypeName("#define AI_FQDN 0x00020000")]
        public const int AI_FQDN = 0x00020000;

        [NativeTypeName("#define AI_FILESERVER 0x00040000")]
        public const int AI_FILESERVER = 0x00040000;

        [NativeTypeName("#define AI_DISABLE_IDN_ENCODING 0x00080000")]
        public const int AI_DISABLE_IDN_ENCODING = 0x00080000;

        [NativeTypeName("#define AI_SECURE_WITH_FALLBACK 0x00100000")]
        public const int AI_SECURE_WITH_FALLBACK = 0x00100000;

        [NativeTypeName("#define AI_EXCLUSIVE_CUSTOM_SERVERS 0x00200000")]
        public const int AI_EXCLUSIVE_CUSTOM_SERVERS = 0x00200000;

        [NativeTypeName("#define AI_RETURN_RESPONSE_FLAGS 0x10000000")]
        public const int AI_RETURN_RESPONSE_FLAGS = 0x10000000;

        [NativeTypeName("#define AI_REQUIRE_SECURE 0x20000000")]
        public const int AI_REQUIRE_SECURE = 0x20000000;

        [NativeTypeName("#define AI_RESOLUTION_HANDLE 0x40000000")]
        public const int AI_RESOLUTION_HANDLE = 0x40000000;

        [NativeTypeName("#define AI_EXTENDED 0x80000000")]
        public const uint AI_EXTENDED = 0x80000000;

        [NativeTypeName("#define NS_ALL (0)")]
        public const int NS_ALL = (0);

        [NativeTypeName("#define NS_SAP (1)")]
        public const int NS_SAP = (1);

        [NativeTypeName("#define NS_NDS (2)")]
        public const int NS_NDS = (2);

        [NativeTypeName("#define NS_PEER_BROWSE (3)")]
        public const int NS_PEER_BROWSE = (3);

        [NativeTypeName("#define NS_SLP (5)")]
        public const int NS_SLP = (5);

        [NativeTypeName("#define NS_DHCP (6)")]
        public const int NS_DHCP = (6);

        [NativeTypeName("#define NS_TCPIP_LOCAL (10)")]
        public const int NS_TCPIP_LOCAL = (10);

        [NativeTypeName("#define NS_TCPIP_HOSTS (11)")]
        public const int NS_TCPIP_HOSTS = (11);

        [NativeTypeName("#define NS_DNS (12)")]
        public const int NS_DNS = (12);

        [NativeTypeName("#define NS_NETBT (13)")]
        public const int NS_NETBT = (13);

        [NativeTypeName("#define NS_WINS (14)")]
        public const int NS_WINS = (14);

        [NativeTypeName("#define NS_NLA (15)")]
        public const int NS_NLA = (15);

        [NativeTypeName("#define NS_BTH (16)")]
        public const int NS_BTH = (16);

        [NativeTypeName("#define NS_NBP (20)")]
        public const int NS_NBP = (20);

        [NativeTypeName("#define NS_MS (30)")]
        public const int NS_MS = (30);

        [NativeTypeName("#define NS_STDA (31)")]
        public const int NS_STDA = (31);

        [NativeTypeName("#define NS_NTDS (32)")]
        public const int NS_NTDS = (32);

        [NativeTypeName("#define NS_EMAIL (37)")]
        public const int NS_EMAIL = (37);

        [NativeTypeName("#define NS_PNRPNAME (38)")]
        public const int NS_PNRPNAME = (38);

        [NativeTypeName("#define NS_PNRPCLOUD (39)")]
        public const int NS_PNRPCLOUD = (39);

        [NativeTypeName("#define NS_X500 (40)")]
        public const int NS_X500 = (40);

        [NativeTypeName("#define NS_NIS (41)")]
        public const int NS_NIS = (41);

        [NativeTypeName("#define NS_NISPLUS (42)")]
        public const int NS_NISPLUS = (42);

        [NativeTypeName("#define NS_WRQ (50)")]
        public const int NS_WRQ = (50);

        [NativeTypeName("#define NS_NETDES (60)")]
        public const int NS_NETDES = (60);

        [NativeTypeName("#define NI_NOFQDN 0x01")]
        public const int NI_NOFQDN = 0x01;

        [NativeTypeName("#define NI_NUMERICHOST 0x02")]
        public const int NI_NUMERICHOST = 0x02;

        [NativeTypeName("#define NI_NAMEREQD 0x04")]
        public const int NI_NAMEREQD = 0x04;

        [NativeTypeName("#define NI_NUMERICSERV 0x08")]
        public const int NI_NUMERICSERV = 0x08;

        [NativeTypeName("#define NI_DGRAM 0x10")]
        public const int NI_DGRAM = 0x10;

        [NativeTypeName("#define NI_MAXHOST 1025")]
        public const int NI_MAXHOST = 1025;

        [NativeTypeName("#define NI_MAXSERV 32")]
        public const int NI_MAXSERV = 32;

        [NativeTypeName("#define IFF_UP 0x00000001")]
        public const int IFF_UP = 0x00000001;

        [NativeTypeName("#define IFF_BROADCAST 0x00000002")]
        public const int IFF_BROADCAST = 0x00000002;

        [NativeTypeName("#define IFF_LOOPBACK 0x00000004")]
        public const int IFF_LOOPBACK = 0x00000004;

        [NativeTypeName("#define IFF_POINTTOPOINT 0x00000008")]
        public const int IFF_POINTTOPOINT = 0x00000008;

        [NativeTypeName("#define IFF_MULTICAST 0x00000010")]
        public const int IFF_MULTICAST = 0x00000010;

        [NativeTypeName("#define IP_OPTIONS 1")]
        public const int IP_OPTIONS = 1;

        [NativeTypeName("#define IP_HDRINCL 2")]
        public const int IP_HDRINCL = 2;

        [NativeTypeName("#define IP_TOS 3")]
        public const int IP_TOS = 3;

        [NativeTypeName("#define IP_TTL 4")]
        public const int IP_TTL = 4;

        [NativeTypeName("#define IP_MULTICAST_IF 9")]
        public const int IP_MULTICAST_IF = 9;

        [NativeTypeName("#define IP_MULTICAST_TTL 10")]
        public const int IP_MULTICAST_TTL = 10;

        [NativeTypeName("#define IP_MULTICAST_LOOP 11")]
        public const int IP_MULTICAST_LOOP = 11;

        [NativeTypeName("#define IP_ADD_MEMBERSHIP 12")]
        public const int IP_ADD_MEMBERSHIP = 12;

        [NativeTypeName("#define IP_DROP_MEMBERSHIP 13")]
        public const int IP_DROP_MEMBERSHIP = 13;

        [NativeTypeName("#define IP_DONTFRAGMENT 14")]
        public const int IP_DONTFRAGMENT = 14;

        [NativeTypeName("#define IP_ADD_SOURCE_MEMBERSHIP 15")]
        public const int IP_ADD_SOURCE_MEMBERSHIP = 15;

        [NativeTypeName("#define IP_DROP_SOURCE_MEMBERSHIP 16")]
        public const int IP_DROP_SOURCE_MEMBERSHIP = 16;

        [NativeTypeName("#define IP_BLOCK_SOURCE 17")]
        public const int IP_BLOCK_SOURCE = 17;

        [NativeTypeName("#define IP_UNBLOCK_SOURCE 18")]
        public const int IP_UNBLOCK_SOURCE = 18;

        [NativeTypeName("#define IP_PKTINFO 19")]
        public const int IP_PKTINFO = 19;

        [NativeTypeName("#define IP_HOPLIMIT 21")]
        public const int IP_HOPLIMIT = 21;

        [NativeTypeName("#define IP_RECVTTL 21")]
        public const int IP_RECVTTL = 21;

        [NativeTypeName("#define IP_RECEIVE_BROADCAST 22")]
        public const int IP_RECEIVE_BROADCAST = 22;

        [NativeTypeName("#define IP_RECVIF 24")]
        public const int IP_RECVIF = 24;

        [NativeTypeName("#define IP_RECVDSTADDR 25")]
        public const int IP_RECVDSTADDR = 25;

        [NativeTypeName("#define IP_IFLIST 28")]
        public const int IP_IFLIST = 28;

        [NativeTypeName("#define IP_ADD_IFLIST 29")]
        public const int IP_ADD_IFLIST = 29;

        [NativeTypeName("#define IP_DEL_IFLIST 30")]
        public const int IP_DEL_IFLIST = 30;

        [NativeTypeName("#define IP_UNICAST_IF 31")]
        public const int IP_UNICAST_IF = 31;

        [NativeTypeName("#define IP_RTHDR 32")]
        public const int IP_RTHDR = 32;

        [NativeTypeName("#define IP_GET_IFLIST 33")]
        public const int IP_GET_IFLIST = 33;

        [NativeTypeName("#define IP_RECVRTHDR 38")]
        public const int IP_RECVRTHDR = 38;

        [NativeTypeName("#define IP_TCLASS 39")]
        public const int IP_TCLASS = 39;

        [NativeTypeName("#define IP_RECVTCLASS 40")]
        public const int IP_RECVTCLASS = 40;

        [NativeTypeName("#define IP_RECVTOS 40")]
        public const int IP_RECVTOS = 40;

        [NativeTypeName("#define IP_ORIGINAL_ARRIVAL_IF 47")]
        public const int IP_ORIGINAL_ARRIVAL_IF = 47;

        [NativeTypeName("#define IP_ECN 50")]
        public const int IP_ECN = 50;

        [NativeTypeName("#define IP_RECVECN 50")]
        public const int IP_RECVECN = 50;

        [NativeTypeName("#define IP_PKTINFO_EX 51")]
        public const int IP_PKTINFO_EX = 51;

        [NativeTypeName("#define IP_WFP_REDIRECT_RECORDS 60")]
        public const int IP_WFP_REDIRECT_RECORDS = 60;

        [NativeTypeName("#define IP_WFP_REDIRECT_CONTEXT 70")]
        public const int IP_WFP_REDIRECT_CONTEXT = 70;

        [NativeTypeName("#define IP_MTU_DISCOVER 71")]
        public const int IP_MTU_DISCOVER = 71;

        [NativeTypeName("#define IP_MTU 73")]
        public const int IP_MTU = 73;

        [NativeTypeName("#define IP_NRT_INTERFACE 74")]
        public const int IP_NRT_INTERFACE = 74;

        [NativeTypeName("#define IP_RECVERR 75")]
        public const int IP_RECVERR = 75;

        [NativeTypeName("#define IP_USER_MTU 76")]
        public const int IP_USER_MTU = 76;

        [NativeTypeName("#define IP_UNSPECIFIED_TYPE_OF_SERVICE -1")]
        public const int IP_UNSPECIFIED_TYPE_OF_SERVICE = -1;

        [NativeTypeName("#define IPV6_ADDRESS_BITS RTL_BITS_OF(IN6_ADDR)")]
        public const ulong IPV6_ADDRESS_BITS = (16 * 8);

        [NativeTypeName("#define IN6ADDR_LINKLOCALPREFIX_LENGTH 64")]
        public const int IN6ADDR_LINKLOCALPREFIX_LENGTH = 64;

        [NativeTypeName("#define IN6ADDR_MULTICASTPREFIX_LENGTH 8")]
        public const int IN6ADDR_MULTICASTPREFIX_LENGTH = 8;

        [NativeTypeName("#define IN6ADDR_SOLICITEDNODEMULTICASTPREFIX_LENGTH 104")]
        public const int IN6ADDR_SOLICITEDNODEMULTICASTPREFIX_LENGTH = 104;

        [NativeTypeName("#define IN6ADDR_V4MAPPEDPREFIX_LENGTH 96")]
        public const int IN6ADDR_V4MAPPEDPREFIX_LENGTH = 96;

        [NativeTypeName("#define IN6ADDR_6TO4PREFIX_LENGTH 16")]
        public const int IN6ADDR_6TO4PREFIX_LENGTH = 16;

        [NativeTypeName("#define IN6ADDR_TEREDOPREFIX_LENGTH 32")]
        public const int IN6ADDR_TEREDOPREFIX_LENGTH = 32;

        [NativeTypeName("#define SIO_GET_INTERFACE_LIST _IOR('t', 127, ULONG)")]
        public const int SIO_GET_INTERFACE_LIST = (0x40000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (127));

        [NativeTypeName("#define SIO_GET_INTERFACE_LIST_EX _IOR('t', 126, ULONG)")]
        public const int SIO_GET_INTERFACE_LIST_EX = (0x40000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (126));

        [NativeTypeName("#define SIO_SET_MULTICAST_FILTER _IOW('t', 125, ULONG)")]
        public const uint SIO_SET_MULTICAST_FILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (125));

        [NativeTypeName("#define SIO_GET_MULTICAST_FILTER _IOW('t', 124 | IOC_IN, ULONG)")]
        public const uint SIO_GET_MULTICAST_FILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (124 | 0x80000000));

        [NativeTypeName("#define SIOCSIPMSFILTER SIO_SET_MULTICAST_FILTER")]
        public const uint SIOCSIPMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (125));

        [NativeTypeName("#define SIOCGIPMSFILTER SIO_GET_MULTICAST_FILTER")]
        public const uint SIOCGIPMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (124 | 0x80000000));

        [NativeTypeName("#define SIOCSMSFILTER _IOW('t', 126, ULONG)")]
        public const uint SIOCSMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (126));

        [NativeTypeName("#define SIOCGMSFILTER _IOW('t', 127 | IOC_IN, ULONG)")]
        public const uint SIOCGMSFILTER = unchecked(0x80000000 | (((int)(4) & 0x7f) << 16) | (((sbyte)('t')) << 8) | (127 | 0x80000000));

        [NativeTypeName("#define MCAST_JOIN_GROUP 41")]
        public const int MCAST_JOIN_GROUP = 41;

        [NativeTypeName("#define MCAST_LEAVE_GROUP 42")]
        public const int MCAST_LEAVE_GROUP = 42;

        [NativeTypeName("#define MCAST_BLOCK_SOURCE 43")]
        public const int MCAST_BLOCK_SOURCE = 43;

        [NativeTypeName("#define MCAST_UNBLOCK_SOURCE 44")]
        public const int MCAST_UNBLOCK_SOURCE = 44;

        [NativeTypeName("#define MCAST_JOIN_SOURCE_GROUP 45")]
        public const int MCAST_JOIN_SOURCE_GROUP = 45;

        [NativeTypeName("#define MCAST_LEAVE_SOURCE_GROUP 46")]
        public const int MCAST_LEAVE_SOURCE_GROUP = 46;

        [NativeTypeName("#define IPV6_HOPOPTS 1")]
        public const int IPV6_HOPOPTS = 1;

        [NativeTypeName("#define IPV6_HDRINCL 2")]
        public const int IPV6_HDRINCL = 2;

        [NativeTypeName("#define IPV6_UNICAST_HOPS 4")]
        public const int IPV6_UNICAST_HOPS = 4;

        [NativeTypeName("#define IPV6_MULTICAST_IF 9")]
        public const int IPV6_MULTICAST_IF = 9;

        [NativeTypeName("#define IPV6_MULTICAST_HOPS 10")]
        public const int IPV6_MULTICAST_HOPS = 10;

        [NativeTypeName("#define IPV6_MULTICAST_LOOP 11")]
        public const int IPV6_MULTICAST_LOOP = 11;

        [NativeTypeName("#define IPV6_ADD_MEMBERSHIP 12")]
        public const int IPV6_ADD_MEMBERSHIP = 12;

        [NativeTypeName("#define IPV6_JOIN_GROUP IPV6_ADD_MEMBERSHIP")]
        public const int IPV6_JOIN_GROUP = 12;

        [NativeTypeName("#define IPV6_DROP_MEMBERSHIP 13")]
        public const int IPV6_DROP_MEMBERSHIP = 13;

        [NativeTypeName("#define IPV6_LEAVE_GROUP IPV6_DROP_MEMBERSHIP")]
        public const int IPV6_LEAVE_GROUP = 13;

        [NativeTypeName("#define IPV6_DONTFRAG 14")]
        public const int IPV6_DONTFRAG = 14;

        [NativeTypeName("#define IPV6_PKTINFO 19")]
        public const int IPV6_PKTINFO = 19;

        [NativeTypeName("#define IPV6_HOPLIMIT 21")]
        public const int IPV6_HOPLIMIT = 21;

        [NativeTypeName("#define IPV6_PROTECTION_LEVEL 23")]
        public const int IPV6_PROTECTION_LEVEL = 23;

        [NativeTypeName("#define IPV6_RECVIF 24")]
        public const int IPV6_RECVIF = 24;

        [NativeTypeName("#define IPV6_RECVDSTADDR 25")]
        public const int IPV6_RECVDSTADDR = 25;

        [NativeTypeName("#define IPV6_CHECKSUM 26")]
        public const int IPV6_CHECKSUM = 26;

        [NativeTypeName("#define IPV6_V6ONLY 27")]
        public const int IPV6_V6ONLY = 27;

        [NativeTypeName("#define IPV6_IFLIST 28")]
        public const int IPV6_IFLIST = 28;

        [NativeTypeName("#define IPV6_ADD_IFLIST 29")]
        public const int IPV6_ADD_IFLIST = 29;

        [NativeTypeName("#define IPV6_DEL_IFLIST 30")]
        public const int IPV6_DEL_IFLIST = 30;

        [NativeTypeName("#define IPV6_UNICAST_IF 31")]
        public const int IPV6_UNICAST_IF = 31;

        [NativeTypeName("#define IPV6_RTHDR 32")]
        public const int IPV6_RTHDR = 32;

        [NativeTypeName("#define IPV6_GET_IFLIST 33")]
        public const int IPV6_GET_IFLIST = 33;

        [NativeTypeName("#define IPV6_RECVRTHDR 38")]
        public const int IPV6_RECVRTHDR = 38;

        [NativeTypeName("#define IPV6_TCLASS 39")]
        public const int IPV6_TCLASS = 39;

        [NativeTypeName("#define IPV6_RECVTCLASS 40")]
        public const int IPV6_RECVTCLASS = 40;

        [NativeTypeName("#define IPV6_ECN 50")]
        public const int IPV6_ECN = 50;

        [NativeTypeName("#define IPV6_RECVECN 50")]
        public const int IPV6_RECVECN = 50;

        [NativeTypeName("#define IPV6_PKTINFO_EX 51")]
        public const int IPV6_PKTINFO_EX = 51;

        [NativeTypeName("#define IPV6_WFP_REDIRECT_RECORDS 60")]
        public const int IPV6_WFP_REDIRECT_RECORDS = 60;

        [NativeTypeName("#define IPV6_WFP_REDIRECT_CONTEXT 70")]
        public const int IPV6_WFP_REDIRECT_CONTEXT = 70;

        [NativeTypeName("#define IPV6_MTU_DISCOVER 71")]
        public const int IPV6_MTU_DISCOVER = 71;

        [NativeTypeName("#define IPV6_MTU 72")]
        public const int IPV6_MTU = 72;

        [NativeTypeName("#define IPV6_NRT_INTERFACE 74")]
        public const int IPV6_NRT_INTERFACE = 74;

        [NativeTypeName("#define IPV6_RECVERR 75")]
        public const int IPV6_RECVERR = 75;

        [NativeTypeName("#define IPV6_USER_MTU 76")]
        public const int IPV6_USER_MTU = 76;

        [NativeTypeName("#define IP_UNSPECIFIED_HOP_LIMIT -1")]
        public const int IP_UNSPECIFIED_HOP_LIMIT = -1;

        [NativeTypeName("#define IP_PROTECTION_LEVEL IPV6_PROTECTION_LEVEL")]
        public const int IP_PROTECTION_LEVEL = 23;

        [NativeTypeName("#define PROTECTION_LEVEL_UNRESTRICTED 10")]
        public const int PROTECTION_LEVEL_UNRESTRICTED = 10;

        [NativeTypeName("#define PROTECTION_LEVEL_EDGERESTRICTED 20")]
        public const int PROTECTION_LEVEL_EDGERESTRICTED = 20;

        [NativeTypeName("#define PROTECTION_LEVEL_RESTRICTED 30")]
        public const int PROTECTION_LEVEL_RESTRICTED = 30;

        [NativeTypeName("#define PROTECTION_LEVEL_DEFAULT ((UINT)-1)")]
        public const uint PROTECTION_LEVEL_DEFAULT = unchecked((uint)(-1));

        [NativeTypeName("#define INET_ADDRSTRLEN 22")]
        public const int INET_ADDRSTRLEN = 22;

        [NativeTypeName("#define INET6_ADDRSTRLEN 65")]
        public const int INET6_ADDRSTRLEN = 65;

        [NativeTypeName("#define TCP_OFFLOAD_NO_PREFERENCE 0")]
        public const int TCP_OFFLOAD_NO_PREFERENCE = 0;

        [NativeTypeName("#define TCP_OFFLOAD_NOT_PREFERRED 1")]
        public const int TCP_OFFLOAD_NOT_PREFERRED = 1;

        [NativeTypeName("#define TCP_OFFLOAD_PREFERRED 2")]
        public const int TCP_OFFLOAD_PREFERRED = 2;

        [NativeTypeName("#define TCP_EXPEDITED_1122 0x0002")]
        public const int TCP_EXPEDITED_1122 = 0x0002;

        [NativeTypeName("#define TCP_KEEPALIVE 3")]
        public const int TCP_KEEPALIVE = 3;

        [NativeTypeName("#define TCP_MAXSEG 4")]
        public const int TCP_MAXSEG = 4;

        [NativeTypeName("#define TCP_MAXRT 5")]
        public const int TCP_MAXRT = 5;

        [NativeTypeName("#define TCP_STDURG 6")]
        public const int TCP_STDURG = 6;

        [NativeTypeName("#define TCP_NOURG 7")]
        public const int TCP_NOURG = 7;

        [NativeTypeName("#define TCP_ATMARK 8")]
        public const int TCP_ATMARK = 8;

        [NativeTypeName("#define TCP_NOSYNRETRIES 9")]
        public const int TCP_NOSYNRETRIES = 9;

        [NativeTypeName("#define TCP_TIMESTAMPS 10")]
        public const int TCP_TIMESTAMPS = 10;

        [NativeTypeName("#define TCP_OFFLOAD_PREFERENCE 11")]
        public const int TCP_OFFLOAD_PREFERENCE = 11;

        [NativeTypeName("#define TCP_CONGESTION_ALGORITHM 12")]
        public const int TCP_CONGESTION_ALGORITHM = 12;

        [NativeTypeName("#define TCP_DELAY_FIN_ACK 13")]
        public const int TCP_DELAY_FIN_ACK = 13;

        [NativeTypeName("#define TCP_MAXRTMS 14")]
        public const int TCP_MAXRTMS = 14;

        [NativeTypeName("#define TCP_FASTOPEN 15")]
        public const int TCP_FASTOPEN = 15;

        [NativeTypeName("#define TCP_KEEPCNT 16")]
        public const int TCP_KEEPCNT = 16;

        [NativeTypeName("#define TCP_KEEPIDLE TCP_KEEPALIVE")]
        public const int TCP_KEEPIDLE = 3;

        [NativeTypeName("#define TCP_KEEPINTVL 17")]
        public const int TCP_KEEPINTVL = 17;

        [NativeTypeName("#define TCP_FAIL_CONNECT_ON_ICMP_ERROR 18")]
        public const int TCP_FAIL_CONNECT_ON_ICMP_ERROR = 18;

        [NativeTypeName("#define TCP_ICMP_ERROR_INFO 19")]
        public const int TCP_ICMP_ERROR_INFO = 19;

        [NativeTypeName("#define UDP_SEND_MSG_SIZE 2")]
        public const int UDP_SEND_MSG_SIZE = 2;

        [NativeTypeName("#define UDP_RECV_MAX_COALESCED_SIZE 3")]
        public const int UDP_RECV_MAX_COALESCED_SIZE = 3;

        [NativeTypeName("#define UDP_COALESCED_INFO 3")]
        public const int UDP_COALESCED_INFO = 3;

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

        [NativeTypeName("#define IP_ADAPTER_ADDRESS_DNS_ELIGIBLE 0x01")]
        public const int IP_ADAPTER_ADDRESS_DNS_ELIGIBLE = 0x01;

        [NativeTypeName("#define IP_ADAPTER_ADDRESS_TRANSIENT 0x02")]
        public const int IP_ADAPTER_ADDRESS_TRANSIENT = 0x02;

        [NativeTypeName("#define IP_ADAPTER_DDNS_ENABLED 0x00000001")]
        public const int IP_ADAPTER_DDNS_ENABLED = 0x00000001;

        [NativeTypeName("#define IP_ADAPTER_REGISTER_ADAPTER_SUFFIX 0x00000002")]
        public const int IP_ADAPTER_REGISTER_ADAPTER_SUFFIX = 0x00000002;

        [NativeTypeName("#define IP_ADAPTER_DHCP_ENABLED 0x00000004")]
        public const int IP_ADAPTER_DHCP_ENABLED = 0x00000004;

        [NativeTypeName("#define IP_ADAPTER_RECEIVE_ONLY 0x00000008")]
        public const int IP_ADAPTER_RECEIVE_ONLY = 0x00000008;

        [NativeTypeName("#define IP_ADAPTER_NO_MULTICAST 0x00000010")]
        public const int IP_ADAPTER_NO_MULTICAST = 0x00000010;

        [NativeTypeName("#define IP_ADAPTER_IPV6_OTHER_STATEFUL_CONFIG 0x00000020")]
        public const int IP_ADAPTER_IPV6_OTHER_STATEFUL_CONFIG = 0x00000020;

        [NativeTypeName("#define IP_ADAPTER_NETBIOS_OVER_TCPIP_ENABLED 0x00000040")]
        public const int IP_ADAPTER_NETBIOS_OVER_TCPIP_ENABLED = 0x00000040;

        [NativeTypeName("#define IP_ADAPTER_IPV4_ENABLED 0x00000080")]
        public const int IP_ADAPTER_IPV4_ENABLED = 0x00000080;

        [NativeTypeName("#define IP_ADAPTER_IPV6_ENABLED 0x00000100")]
        public const int IP_ADAPTER_IPV6_ENABLED = 0x00000100;

        [NativeTypeName("#define IP_ADAPTER_IPV6_MANAGE_ADDRESS_CONFIG 0x00000200")]
        public const int IP_ADAPTER_IPV6_MANAGE_ADDRESS_CONFIG = 0x00000200;

        [NativeTypeName("#define GAA_FLAG_SKIP_UNICAST 0x0001")]
        public const int GAA_FLAG_SKIP_UNICAST = 0x0001;

        [NativeTypeName("#define GAA_FLAG_SKIP_ANYCAST 0x0002")]
        public const int GAA_FLAG_SKIP_ANYCAST = 0x0002;

        [NativeTypeName("#define GAA_FLAG_SKIP_MULTICAST 0x0004")]
        public const int GAA_FLAG_SKIP_MULTICAST = 0x0004;

        [NativeTypeName("#define GAA_FLAG_SKIP_DNS_SERVER 0x0008")]
        public const int GAA_FLAG_SKIP_DNS_SERVER = 0x0008;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_PREFIX 0x0010")]
        public const int GAA_FLAG_INCLUDE_PREFIX = 0x0010;

        [NativeTypeName("#define GAA_FLAG_SKIP_FRIENDLY_NAME 0x0020")]
        public const int GAA_FLAG_SKIP_FRIENDLY_NAME = 0x0020;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_WINS_INFO 0x0040")]
        public const int GAA_FLAG_INCLUDE_WINS_INFO = 0x0040;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_GATEWAYS 0x0080")]
        public const int GAA_FLAG_INCLUDE_GATEWAYS = 0x0080;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_ALL_INTERFACES 0x0100")]
        public const int GAA_FLAG_INCLUDE_ALL_INTERFACES = 0x0100;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_ALL_COMPARTMENTS 0x0200")]
        public const int GAA_FLAG_INCLUDE_ALL_COMPARTMENTS = 0x0200;

        [NativeTypeName("#define GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER 0x0400")]
        public const int GAA_FLAG_INCLUDE_TUNNEL_BINDINGORDER = 0x0400;

        [NativeTypeName("#define GAA_FLAG_SKIP_DNS_INFO 0x0800")]
        public const int GAA_FLAG_SKIP_DNS_INFO = 0x0800;

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

        [NativeTypeName("#define MIB_INVALID_TEREDO_PORT_NUMBER 0")]
        public const int MIB_INVALID_TEREDO_PORT_NUMBER = 0;

        [NativeTypeName("#define IF_NAMESIZE NDIS_IF_MAX_STRING_SIZE")]
        public const int IF_NAMESIZE = 256;

        [NativeTypeName("#define DNS_SETTINGS_VERSION1 0x0001")]
        public const int DNS_SETTINGS_VERSION1 = 0x0001;

        [NativeTypeName("#define DNS_SETTINGS_VERSION2 0x0002")]
        public const int DNS_SETTINGS_VERSION2 = 0x0002;

        [NativeTypeName("#define DNS_INTERFACE_SETTINGS_VERSION1 0x0001")]
        public const int DNS_INTERFACE_SETTINGS_VERSION1 = 0x0001;

        [NativeTypeName("#define DNS_INTERFACE_SETTINGS_VERSION2 0x0002")]
        public const int DNS_INTERFACE_SETTINGS_VERSION2 = 0x0002;

        [NativeTypeName("#define DNS_INTERFACE_SETTINGS_VERSION3 0x0003")]
        public const int DNS_INTERFACE_SETTINGS_VERSION3 = 0x0003;

        [NativeTypeName("#define DNS_INTERFACE_SETTINGS_VERSION4 0x0004")]
        public const int DNS_INTERFACE_SETTINGS_VERSION4 = 0x0004;

        [NativeTypeName("#define DNS_SETTING_IPV6 0x0001")]
        public const int DNS_SETTING_IPV6 = 0x0001;

        [NativeTypeName("#define DNS_SETTING_NAMESERVER 0x0002")]
        public const int DNS_SETTING_NAMESERVER = 0x0002;

        [NativeTypeName("#define DNS_SETTING_SEARCHLIST 0x0004")]
        public const int DNS_SETTING_SEARCHLIST = 0x0004;

        [NativeTypeName("#define DNS_SETTING_REGISTRATION_ENABLED 0x0008")]
        public const int DNS_SETTING_REGISTRATION_ENABLED = 0x0008;

        [NativeTypeName("#define DNS_SETTING_REGISTER_ADAPTER_NAME 0x0010")]
        public const int DNS_SETTING_REGISTER_ADAPTER_NAME = 0x0010;

        [NativeTypeName("#define DNS_SETTING_DOMAIN 0x0020")]
        public const int DNS_SETTING_DOMAIN = 0x0020;

        [NativeTypeName("#define DNS_SETTING_HOSTNAME 0x0040")]
        public const int DNS_SETTING_HOSTNAME = 0x0040;

        [NativeTypeName("#define DNS_SETTINGS_ENABLE_LLMNR 0x0080")]
        public const int DNS_SETTINGS_ENABLE_LLMNR = 0x0080;

        [NativeTypeName("#define DNS_SETTINGS_QUERY_ADAPTER_NAME 0x0100")]
        public const int DNS_SETTINGS_QUERY_ADAPTER_NAME = 0x0100;

        [NativeTypeName("#define DNS_SETTING_PROFILE_NAMESERVER 0x0200")]
        public const int DNS_SETTING_PROFILE_NAMESERVER = 0x0200;

        [NativeTypeName("#define DNS_SETTING_DISABLE_UNCONSTRAINED_QUERIES 0x0400")]
        public const int DNS_SETTING_DISABLE_UNCONSTRAINED_QUERIES = 0x0400;

        [NativeTypeName("#define DNS_SETTING_SUPPLEMENTAL_SEARCH_LIST 0x0800")]
        public const int DNS_SETTING_SUPPLEMENTAL_SEARCH_LIST = 0x0800;

        [NativeTypeName("#define DNS_SETTING_DOH 0x1000")]
        public const int DNS_SETTING_DOH = 0x1000;

        [NativeTypeName("#define DNS_SETTING_DOH_PROFILE 0x2000")]
        public const int DNS_SETTING_DOH_PROFILE = 0x2000;

        [NativeTypeName("#define DNS_SETTING_ENCRYPTED_DNS_ADAPTER_FLAGS 0x4000")]
        public const int DNS_SETTING_ENCRYPTED_DNS_ADAPTER_FLAGS = 0x4000;

        [NativeTypeName("#define DNS_SETTING_DDR 0x8000")]
        public const int DNS_SETTING_DDR = 0x8000;

        [NativeTypeName("#define DNS_SETTING_DOT 0x10000")]
        public const int DNS_SETTING_DOT = 0x10000;

        [NativeTypeName("#define DNS_SETTING_DOT_PROFILE 0x20000")]
        public const int DNS_SETTING_DOT_PROFILE = 0x20000;

        [NativeTypeName("#define DNS_ENABLE_DOH 0x0001")]
        public const int DNS_ENABLE_DOH = 0x0001;

        [NativeTypeName("#define DNS_DOH_POLICY_NOT_CONFIGURED 0x0004")]
        public const int DNS_DOH_POLICY_NOT_CONFIGURED = 0x0004;

        [NativeTypeName("#define DNS_DOH_POLICY_DISABLE 0x0008")]
        public const int DNS_DOH_POLICY_DISABLE = 0x0008;

        [NativeTypeName("#define DNS_DOH_POLICY_AUTO 0x0010")]
        public const int DNS_DOH_POLICY_AUTO = 0x0010;

        [NativeTypeName("#define DNS_DOH_POLICY_REQUIRED 0x0020")]
        public const int DNS_DOH_POLICY_REQUIRED = 0x0020;

        [NativeTypeName("#define DNS_ENCRYPTION_POLICY_NOT_CONFIGURED DNS_DOH_POLICY_NOT_CONFIGURED")]
        public const int DNS_ENCRYPTION_POLICY_NOT_CONFIGURED = 0x0004;

        [NativeTypeName("#define DNS_ENCRYPTION_POLICY_DISABLE DNS_DOH_POLICY_DISABLE")]
        public const int DNS_ENCRYPTION_POLICY_DISABLE = 0x0008;

        [NativeTypeName("#define DNS_ENCRYPTION_POLICY_AUTO DNS_DOH_POLICY_AUTO")]
        public const int DNS_ENCRYPTION_POLICY_AUTO = 0x0010;

        [NativeTypeName("#define DNS_ENCRYPTION_POLICY_REQUIRED DNS_DOH_POLICY_REQUIRED")]
        public const int DNS_ENCRYPTION_POLICY_REQUIRED = 0x0020;

        [NativeTypeName("#define DNS_ENABLE_DDR 0x0040")]
        public const int DNS_ENABLE_DDR = 0x0040;

        [NativeTypeName("#define DNS_ENABLE_DOT 0x0080")]
        public const int DNS_ENABLE_DOT = 0x0080;

        [NativeTypeName("#define DNS_DOT_POLICY_BLOCK 0x0100")]
        public const int DNS_DOT_POLICY_BLOCK = 0x0100;

        [NativeTypeName("#define DNS_DOH_POLICY_BLOCK 0x0200")]
        public const int DNS_DOH_POLICY_BLOCK = 0x0200;

        [NativeTypeName("#define DNS_ENABLE_DNR 0x0400")]
        public const int DNS_ENABLE_DNR = 0x0400;

        [NativeTypeName("#define DNS_SERVER_PROPERTY_VERSION1 0x0001")]
        public const int DNS_SERVER_PROPERTY_VERSION1 = 0x0001;

        [NativeTypeName("#define DNS_DOH_SERVER_SETTINGS_ENABLE_AUTO 0x0001")]
        public const int DNS_DOH_SERVER_SETTINGS_ENABLE_AUTO = 0x0001;

        [NativeTypeName("#define DNS_DOH_SERVER_SETTINGS_ENABLE 0x0002")]
        public const int DNS_DOH_SERVER_SETTINGS_ENABLE = 0x0002;

        [NativeTypeName("#define DNS_DOH_SERVER_SETTINGS_FALLBACK_TO_UDP 0x0004")]
        public const int DNS_DOH_SERVER_SETTINGS_FALLBACK_TO_UDP = 0x0004;

        [NativeTypeName("#define DNS_DOH_AUTO_UPGRADE_SERVER 0x0008")]
        public const int DNS_DOH_AUTO_UPGRADE_SERVER = 0x0008;

        [NativeTypeName("#define DNS_DOH_SERVER_SETTINGS_ENABLE_DDR 0x0010")]
        public const int DNS_DOH_SERVER_SETTINGS_ENABLE_DDR = 0x0010;

        [NativeTypeName("#define DNS_DOH_SERVER_SETTINGS_MAKE_DDR_NON_BLOCKING 0x0020")]
        public const int DNS_DOH_SERVER_SETTINGS_MAKE_DDR_NON_BLOCKING = 0x0020;

        [NativeTypeName("#define DNS_DOT_SERVER_SETTINGS_ENABLE 0x0001")]
        public const int DNS_DOT_SERVER_SETTINGS_ENABLE = 0x0001;

        [NativeTypeName("#define DNS_DOT_SERVER_SETTINGS_FALLBACK_TO_UDP 0x0002")]
        public const int DNS_DOT_SERVER_SETTINGS_FALLBACK_TO_UDP = 0x0002;

        [NativeTypeName("#define DNS_DOT_AUTO_UPGRADE_SERVER 0x0004")]
        public const int DNS_DOT_AUTO_UPGRADE_SERVER = 0x0004;

        [NativeTypeName("#define DNS_DOT_SERVER_SETTINGS_ENABLE_AUTO 0x0008")]
        public const int DNS_DOT_SERVER_SETTINGS_ENABLE_AUTO = 0x0008;

        [NativeTypeName("#define DNS_DOT_SERVER_SETTINGS_ENABLE_DDR 0x0010")]
        public const int DNS_DOT_SERVER_SETTINGS_ENABLE_DDR = 0x0010;

        [NativeTypeName("#define DNS_DOT_SERVER_SETTINGS_MAKE_DDR_NON_BLOCKING 0x0020")]
        public const int DNS_DOT_SERVER_SETTINGS_MAKE_DDR_NON_BLOCKING = 0x0020;

        [NativeTypeName("#define DNS_DDR_ADAPTER_ENABLE_DOH 0x0001")]
        public const int DNS_DDR_ADAPTER_ENABLE_DOH = 0x0001;

        [NativeTypeName("#define DNS_DDR_ADAPTER_ENABLE DNS_DDR_ADAPTER_ENABLE_DOH")]
        public const int DNS_DDR_ADAPTER_ENABLE = 0x0001;

        [NativeTypeName("#define DNS_DDR_ADAPTER_ENABLE_UDP_FALLBACK 0x0002")]
        public const int DNS_DDR_ADAPTER_ENABLE_UDP_FALLBACK = 0x0002;

        [NativeTypeName("#define DNS_DDR_ADAPTER_MAKE_DDR_NON_BLOCKING 0x0004")]
        public const int DNS_DDR_ADAPTER_MAKE_DDR_NON_BLOCKING = 0x0004;
    }
}
