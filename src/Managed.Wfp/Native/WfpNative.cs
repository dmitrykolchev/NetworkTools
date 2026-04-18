using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.Wfp.Native
{
    public enum FWP_DIRECTION_
    {
        FWP_DIRECTION_OUTBOUND = 0,
        FWP_DIRECTION_INBOUND = (FWP_DIRECTION_OUTBOUND + 1),
        FWP_DIRECTION_MAX = (FWP_DIRECTION_INBOUND + 1),
    }

    public enum FWP_IP_VERSION_
    {
        FWP_IP_VERSION_V4 = 0,
        FWP_IP_VERSION_V6 = (FWP_IP_VERSION_V4 + 1),
        FWP_IP_VERSION_NONE = (FWP_IP_VERSION_V6 + 1),
        FWP_IP_VERSION_MAX = (FWP_IP_VERSION_NONE + 1),
    }

    public enum FWP_NE_FAMILY_
    {
        FWP_AF_INET = FWP_IP_VERSION_.FWP_IP_VERSION_V4,
        FWP_AF_INET6 = FWP_IP_VERSION_.FWP_IP_VERSION_V6,
        FWP_AF_ETHER = FWP_IP_VERSION_.FWP_IP_VERSION_NONE,
        FWP_AF_NONE = (FWP_AF_ETHER + 1),
    }

    public enum FWP_ETHER_ENCAP_METHOD_
    {
        FWP_ETHER_ENCAP_METHOD_ETHER_V2 = 0,
        FWP_ETHER_ENCAP_METHOD_SNAP = 1,
        FWP_ETHER_ENCAP_METHOD_SNAP_W_OUI_ZERO = 3,
    }

    public enum FWP_DATA_TYPE_
    {
        FWP_EMPTY = 0,
        FWP_UINT8 = (FWP_EMPTY + 1),
        FWP_UINT16 = (FWP_UINT8 + 1),
        FWP_UINT32 = (FWP_UINT16 + 1),
        FWP_UINT64 = (FWP_UINT32 + 1),
        FWP_INT8 = (FWP_UINT64 + 1),
        FWP_INT16 = (FWP_INT8 + 1),
        FWP_INT32 = (FWP_INT16 + 1),
        FWP_INT64 = (FWP_INT32 + 1),
        FWP_FLOAT = (FWP_INT64 + 1),
        FWP_DOUBLE = (FWP_FLOAT + 1),
        FWP_BYTE_ARRAY16_TYPE = (FWP_DOUBLE + 1),
        FWP_BYTE_BLOB_TYPE = (FWP_BYTE_ARRAY16_TYPE + 1),
        FWP_SID = (FWP_BYTE_BLOB_TYPE + 1),
        FWP_SECURITY_DESCRIPTOR_TYPE = (FWP_SID + 1),
        FWP_TOKEN_INFORMATION_TYPE = (FWP_SECURITY_DESCRIPTOR_TYPE + 1),
        FWP_TOKEN_ACCESS_INFORMATION_TYPE = (FWP_TOKEN_INFORMATION_TYPE + 1),
        FWP_UNICODE_STRING_TYPE = (FWP_TOKEN_ACCESS_INFORMATION_TYPE + 1),
        FWP_BYTE_ARRAY6_TYPE = (FWP_UNICODE_STRING_TYPE + 1),
        FWP_SINGLE_DATA_TYPE_MAX = 0xff,
        FWP_V4_ADDR_MASK = (FWP_SINGLE_DATA_TYPE_MAX + 1),
        FWP_V6_ADDR_MASK = (FWP_V4_ADDR_MASK + 1),
        FWP_RANGE_TYPE = (FWP_V6_ADDR_MASK + 1),
        FWP_DATA_TYPE_MAX = (FWP_RANGE_TYPE + 1),
    }

    public partial struct FWP_BYTE_ARRAY6_
    {
        [NativeTypeName("UINT8[6]")]
        public _byteArray6_e__FixedBuffer byteArray6;

        [InlineArray(6)]
        public partial struct _byteArray6_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct FWP_BYTE_ARRAY16_
    {
        [NativeTypeName("UINT8[16]")]
        public _byteArray16_e__FixedBuffer byteArray16;

        [InlineArray(16)]
        public partial struct _byteArray16_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public unsafe partial struct FWP_BYTE_BLOB
    {
        [NativeTypeName("UINT32")]
        public uint size;

        [NativeTypeName("UINT8 *")]
        public byte* data;
    }

    public unsafe partial struct FWP_TOKEN_INFORMATION_
    {
        [NativeTypeName("ULONG")]
        public uint sidCount;

        [NativeTypeName("PSID_AND_ATTRIBUTES")]
        public SID_AND_ATTRIBUTES* sids;

        [NativeTypeName("ULONG")]
        public uint restrictedSidCount;

        [NativeTypeName("PSID_AND_ATTRIBUTES")]
        public SID_AND_ATTRIBUTES* restrictedSids;
    }

    public unsafe partial struct FWP_VALUE0_
    {
        [NativeTypeName("FWP_DATA_TYPE")]
        public FWP_DATA_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwptypes_L168_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref byte uint8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.uint8;
            }
        }

        [UnscopedRef]
        public ref ushort uint16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.uint16;
            }
        }

        [UnscopedRef]
        public ref uint uint32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.uint32;
            }
        }

        [UnscopedRef]
        public ref ulong* uint64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.uint64;
            }
        }

        [UnscopedRef]
        public ref sbyte int8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.int8;
            }
        }

        [UnscopedRef]
        public ref short int16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.int16;
            }
        }

        [UnscopedRef]
        public ref int int32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.int32;
            }
        }

        [UnscopedRef]
        public ref long* int64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.int64;
            }
        }

        [UnscopedRef]
        public ref float float32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.float32;
            }
        }

        [UnscopedRef]
        public ref double* double64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.double64;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_* byteArray16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.byteArray16;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* byteBlob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.byteBlob;
            }
        }

        [UnscopedRef]
        public ref SID* sid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sid;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* sd
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sd;
            }
        }

        [UnscopedRef]
        public ref FWP_TOKEN_INFORMATION_* tokenInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.tokenInformation;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* tokenAccessInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.tokenAccessInformation;
            }
        }

        [UnscopedRef]
        public ref char* unicodeString
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.unicodeString;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY6_* byteArray6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.byteArray6;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT8")]
            public byte uint8;

            [FieldOffset(0)]
            [NativeTypeName("UINT16")]
            public ushort uint16;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint uint32;

            [FieldOffset(0)]
            [NativeTypeName("UINT64 *")]
            public ulong* uint64;

            [FieldOffset(0)]
            [NativeTypeName("INT8")]
            public sbyte int8;

            [FieldOffset(0)]
            [NativeTypeName("INT16")]
            public short int16;

            [FieldOffset(0)]
            [NativeTypeName("INT32")]
            public int int32;

            [FieldOffset(0)]
            [NativeTypeName("INT64 *")]
            public long* int64;

            [FieldOffset(0)]
            public float float32;

            [FieldOffset(0)]
            public double* double64;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16 *")]
            public FWP_BYTE_ARRAY16_* byteArray16;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* byteBlob;

            [FieldOffset(0)]
            public SID* sid;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* sd;

            [FieldOffset(0)]
            [NativeTypeName("FWP_TOKEN_INFORMATION *")]
            public FWP_TOKEN_INFORMATION_* tokenInformation;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* tokenAccessInformation;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public char* unicodeString;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY6 *")]
            public FWP_BYTE_ARRAY6_* byteArray6;
        }
    }

    public enum FWP_MATCH_TYPE_
    {
        FWP_MATCH_EQUAL = 0,
        FWP_MATCH_GREATER = (FWP_MATCH_EQUAL + 1),
        FWP_MATCH_LESS = (FWP_MATCH_GREATER + 1),
        FWP_MATCH_GREATER_OR_EQUAL = (FWP_MATCH_LESS + 1),
        FWP_MATCH_LESS_OR_EQUAL = (FWP_MATCH_GREATER_OR_EQUAL + 1),
        FWP_MATCH_RANGE = (FWP_MATCH_LESS_OR_EQUAL + 1),
        FWP_MATCH_FLAGS_ALL_SET = (FWP_MATCH_RANGE + 1),
        FWP_MATCH_FLAGS_ANY_SET = (FWP_MATCH_FLAGS_ALL_SET + 1),
        FWP_MATCH_FLAGS_NONE_SET = (FWP_MATCH_FLAGS_ANY_SET + 1),
        FWP_MATCH_EQUAL_CASE_INSENSITIVE = (FWP_MATCH_FLAGS_NONE_SET + 1),
        FWP_MATCH_NOT_EQUAL = (FWP_MATCH_EQUAL_CASE_INSENSITIVE + 1),
        FWP_MATCH_PREFIX = (FWP_MATCH_NOT_EQUAL + 1),
        FWP_MATCH_NOT_PREFIX = (FWP_MATCH_PREFIX + 1),
        FWP_MATCH_TYPE_MAX = (FWP_MATCH_NOT_PREFIX + 1),
    }

    public partial struct FWP_V4_ADDR_AND_MASK_
    {
        [NativeTypeName("UINT32")]
        public uint addr;

        [NativeTypeName("UINT32")]
        public uint mask;
    }

    public partial struct FWP_V6_ADDR_AND_MASK_
    {
        [NativeTypeName("UINT8[16]")]
        public _addr_e__FixedBuffer addr;

        [NativeTypeName("UINT8")]
        public byte prefixLength;

        [InlineArray(16)]
        public partial struct _addr_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct FWP_RANGE0_
    {
        [NativeTypeName("FWP_VALUE0")]
        public FWP_VALUE0_ valueLow;

        [NativeTypeName("FWP_VALUE0")]
        public FWP_VALUE0_ valueHigh;
    }

    public unsafe partial struct FWP_CONDITION_VALUE0_
    {
        [NativeTypeName("FWP_DATA_TYPE")]
        public FWP_DATA_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwptypes_L235_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref byte uint8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.uint8;
            }
        }

        [UnscopedRef]
        public ref ushort uint16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.uint16;
            }
        }

        [UnscopedRef]
        public ref uint uint32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.uint32;
            }
        }

        [UnscopedRef]
        public ref ulong* uint64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.uint64;
            }
        }

        [UnscopedRef]
        public ref sbyte int8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.int8;
            }
        }

        [UnscopedRef]
        public ref short int16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.int16;
            }
        }

        [UnscopedRef]
        public ref int int32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.int32;
            }
        }

        [UnscopedRef]
        public ref long* int64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.int64;
            }
        }

        [UnscopedRef]
        public ref float float32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.float32;
            }
        }

        [UnscopedRef]
        public ref double* double64
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.double64;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_* byteArray16
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.byteArray16;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* byteBlob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.byteBlob;
            }
        }

        [UnscopedRef]
        public ref SID* sid
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sid;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* sd
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sd;
            }
        }

        [UnscopedRef]
        public ref FWP_TOKEN_INFORMATION_* tokenInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.tokenInformation;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* tokenAccessInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.tokenAccessInformation;
            }
        }

        [UnscopedRef]
        public ref char* unicodeString
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.unicodeString;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY6_* byteArray6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.byteArray6;
            }
        }

        [UnscopedRef]
        public ref FWP_V4_ADDR_AND_MASK_* v4AddrMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.v4AddrMask;
            }
        }

        [UnscopedRef]
        public ref FWP_V6_ADDR_AND_MASK_* v6AddrMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.v6AddrMask;
            }
        }

        [UnscopedRef]
        public ref FWP_RANGE0_* rangeValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.rangeValue;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT8")]
            public byte uint8;

            [FieldOffset(0)]
            [NativeTypeName("UINT16")]
            public ushort uint16;

            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint uint32;

            [FieldOffset(0)]
            [NativeTypeName("UINT64 *")]
            public ulong* uint64;

            [FieldOffset(0)]
            [NativeTypeName("INT8")]
            public sbyte int8;

            [FieldOffset(0)]
            [NativeTypeName("INT16")]
            public short int16;

            [FieldOffset(0)]
            [NativeTypeName("INT32")]
            public int int32;

            [FieldOffset(0)]
            [NativeTypeName("INT64 *")]
            public long* int64;

            [FieldOffset(0)]
            public float float32;

            [FieldOffset(0)]
            public double* double64;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16 *")]
            public FWP_BYTE_ARRAY16_* byteArray16;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* byteBlob;

            [FieldOffset(0)]
            public SID* sid;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* sd;

            [FieldOffset(0)]
            [NativeTypeName("FWP_TOKEN_INFORMATION *")]
            public FWP_TOKEN_INFORMATION_* tokenInformation;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* tokenAccessInformation;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public char* unicodeString;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY6 *")]
            public FWP_BYTE_ARRAY6_* byteArray6;

            [FieldOffset(0)]
            [NativeTypeName("FWP_V4_ADDR_AND_MASK *")]
            public FWP_V4_ADDR_AND_MASK_* v4AddrMask;

            [FieldOffset(0)]
            [NativeTypeName("FWP_V6_ADDR_AND_MASK *")]
            public FWP_V6_ADDR_AND_MASK_* v6AddrMask;

            [FieldOffset(0)]
            [NativeTypeName("FWP_RANGE0 *")]
            public FWP_RANGE0_* rangeValue;
        }
    }

    public enum FWP_NETWORK_CONNECTION_POLICY_SETTING_TYPE_
    {
        FWP_NETWORK_CONNECTION_POLICY_SOURCE_ADDRESS = 0,
        FWP_NETWORK_CONNECTION_POLICY_NEXT_HOP_INTERFACE = (FWP_NETWORK_CONNECTION_POLICY_SOURCE_ADDRESS + 1),
        FWP_NETWORK_CONNECTION_POLICY_NEXT_HOP = (FWP_NETWORK_CONNECTION_POLICY_NEXT_HOP_INTERFACE + 1),
        FWP_NETWORK_CONNECTION_POLICY_MAX = (FWP_NETWORK_CONNECTION_POLICY_NEXT_HOP + 1),
    }

    public enum FWP_CLASSIFY_OPTION_TYPE_
    {
        FWP_CLASSIFY_OPTION_MULTICAST_STATE = 0,
        FWP_CLASSIFY_OPTION_LOOSE_SOURCE_MAPPING = (FWP_CLASSIFY_OPTION_MULTICAST_STATE + 1),
        FWP_CLASSIFY_OPTION_UNICAST_LIFETIME = (FWP_CLASSIFY_OPTION_LOOSE_SOURCE_MAPPING + 1),
        FWP_CLASSIFY_OPTION_MCAST_BCAST_LIFETIME = (FWP_CLASSIFY_OPTION_UNICAST_LIFETIME + 1),
        FWP_CLASSIFY_OPTION_SECURE_SOCKET_SECURITY_FLAGS = (FWP_CLASSIFY_OPTION_MCAST_BCAST_LIFETIME + 1),
        FWP_CLASSIFY_OPTION_SECURE_SOCKET_AUTHIP_MM_POLICY_KEY = (FWP_CLASSIFY_OPTION_SECURE_SOCKET_SECURITY_FLAGS + 1),
        FWP_CLASSIFY_OPTION_SECURE_SOCKET_AUTHIP_QM_POLICY_KEY = (FWP_CLASSIFY_OPTION_SECURE_SOCKET_AUTHIP_MM_POLICY_KEY + 1),
        FWP_CLASSIFY_OPTION_LOCAL_ONLY_MAPPING = (FWP_CLASSIFY_OPTION_SECURE_SOCKET_AUTHIP_QM_POLICY_KEY + 1),
        FWP_CLASSIFY_OPTION_MAX = (FWP_CLASSIFY_OPTION_LOCAL_ONLY_MAPPING + 1),
    }

    public enum FWP_VSWITCH_NETWORK_TYPE_
    {
        FWP_VSWITCH_NETWORK_TYPE_UNKNOWN = 0,
        FWP_VSWITCH_NETWORK_TYPE_PRIVATE = (FWP_VSWITCH_NETWORK_TYPE_UNKNOWN + 1),
        FWP_VSWITCH_NETWORK_TYPE_INTERNAL = (FWP_VSWITCH_NETWORK_TYPE_PRIVATE + 1),
        FWP_VSWITCH_NETWORK_TYPE_EXTERNAL = (FWP_VSWITCH_NETWORK_TYPE_INTERNAL + 1),
    }

    public enum FWP_FILTER_ENUM_TYPE_
    {
        FWP_FILTER_ENUM_FULLY_CONTAINED = 0,
        FWP_FILTER_ENUM_OVERLAPPING = (FWP_FILTER_ENUM_FULLY_CONTAINED + 1),
        FWP_FILTER_ENUM_TYPE_MAX = (FWP_FILTER_ENUM_OVERLAPPING + 1),
    }

    public unsafe partial struct FWPM_DISPLAY_DATA0_
    {
        [NativeTypeName("wchar_t *")]
        public char* name;

        [NativeTypeName("wchar_t *")]
        public char* description;
    }

    public partial struct IPSEC_VIRTUAL_IF_TUNNEL_INFO0_
    {
        [NativeTypeName("UINT64")]
        public ulong virtualIfTunnelId;

        [NativeTypeName("UINT64")]
        public ulong trafficSelectorId;
    }

    public enum __MIDL___MIDL_itf_fwpmtypes_0000_0000_0001
    {
        DlUnicast = 0,
        DlMulticast = (DlUnicast + 1),
        DlBroadcast = (DlMulticast + 1),
    }

    public enum FWPM_CHANGE_TYPE_
    {
        FWPM_CHANGE_ADD = 1,
        FWPM_CHANGE_DELETE = (FWPM_CHANGE_ADD + 1),
        FWPM_CHANGE_TYPE_MAX = (FWPM_CHANGE_DELETE + 1),
    }

    public enum FWPM_SERVICE_STATE_
    {
        FWPM_SERVICE_STOPPED = 0,
        FWPM_SERVICE_START_PENDING = (FWPM_SERVICE_STOPPED + 1),
        FWPM_SERVICE_STOP_PENDING = (FWPM_SERVICE_START_PENDING + 1),
        FWPM_SERVICE_RUNNING = (FWPM_SERVICE_STOP_PENDING + 1),
        FWPM_SERVICE_STATE_MAX = (FWPM_SERVICE_RUNNING + 1),
    }

    public enum FWPM_ENGINE_OPTION_
    {
        FWPM_ENGINE_COLLECT_NET_EVENTS = 0,
        FWPM_ENGINE_NET_EVENT_MATCH_ANY_KEYWORDS = (FWPM_ENGINE_COLLECT_NET_EVENTS + 1),
        FWPM_ENGINE_NAME_CACHE = (FWPM_ENGINE_NET_EVENT_MATCH_ANY_KEYWORDS + 1),
        FWPM_ENGINE_MONITOR_IPSEC_CONNECTIONS = (FWPM_ENGINE_NAME_CACHE + 1),
        FWPM_ENGINE_PACKET_QUEUING = (FWPM_ENGINE_MONITOR_IPSEC_CONNECTIONS + 1),
        FWPM_ENGINE_TXN_WATCHDOG_TIMEOUT_IN_MSEC = (FWPM_ENGINE_PACKET_QUEUING + 1),
        FWPM_ENGINE_OPTION_MAX = (FWPM_ENGINE_TXN_WATCHDOG_TIMEOUT_IN_MSEC + 1),
    }

    public unsafe partial struct FWPM_SESSION0_
    {
        public Guid sessionKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint txnWaitTimeoutInMSec;

        [NativeTypeName("DWORD")]
        public uint processId;

        public SID* sid;

        [NativeTypeName("wchar_t *")]
        public char* username;

        [NativeTypeName("BOOL")]
        public int kernelMode;
    }

    public partial struct FWPM_SESSION_ENUM_TEMPLATE0_
    {
        [NativeTypeName("UINT64")]
        public ulong reserved;
    }

    public unsafe partial struct FWPM_PROVIDER0
    {
        public Guid providerKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        public FWP_BYTE_BLOB providerData;

        [NativeTypeName("wchar_t *")]
        public char* serviceName;
    }

    public partial struct FWPM_PROVIDER_ENUM_TEMPLATE0
    {
        [NativeTypeName("UINT64")]
        public ulong reserved;
    }

    public partial struct FWPM_PROVIDER_CHANGE0_
    {
        [NativeTypeName("FWPM_CHANGE_TYPE")]
        public FWPM_CHANGE_TYPE_ changeType;

        public Guid providerKey;
    }

    public unsafe partial struct FWPM_PROVIDER_SUBSCRIPTION0_
    {
        public FWPM_PROVIDER_ENUM_TEMPLATE0* enumTemplate;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public partial struct FWPM_CLASSIFY_OPTION0_
    {
        [NativeTypeName("FWP_CLASSIFY_OPTION_TYPE")]
        public FWP_CLASSIFY_OPTION_TYPE_ type;

        [NativeTypeName("FWP_VALUE0")]
        public FWP_VALUE0_ value;
    }

    public unsafe partial struct FWPM_CLASSIFY_OPTIONS0_
    {
        [NativeTypeName("UINT32")]
        public uint numOptions;

        [NativeTypeName("FWPM_CLASSIFY_OPTION0 *")]
        public FWPM_CLASSIFY_OPTION0_* options;
    }

    public partial struct FWPM_NETWORK_CONNECTION_POLICY_SETTING0_
    {
        [NativeTypeName("FWP_NETWORK_CONNECTION_POLICY_SETTING_TYPE")]
        public FWP_NETWORK_CONNECTION_POLICY_SETTING_TYPE_ type;

        [NativeTypeName("FWP_VALUE0")]
        public FWP_VALUE0_ value;
    }

    public unsafe partial struct FWPM_NETWORK_CONNECTION_POLICY_SETTINGS0_
    {
        [NativeTypeName("UINT32")]
        public uint numSettings;

        [NativeTypeName("FWPM_NETWORK_CONNECTION_POLICY_SETTING0 *")]
        public FWPM_NETWORK_CONNECTION_POLICY_SETTING0_* settings;
    }

    public enum FWPM_PROVIDER_CONTEXT_TYPE_
    {
        FWPM_IPSEC_KEYING_CONTEXT = 0,
        FWPM_IPSEC_IKE_QM_TRANSPORT_CONTEXT = (FWPM_IPSEC_KEYING_CONTEXT + 1),
        FWPM_IPSEC_IKE_QM_TUNNEL_CONTEXT = (FWPM_IPSEC_IKE_QM_TRANSPORT_CONTEXT + 1),
        FWPM_IPSEC_AUTHIP_QM_TRANSPORT_CONTEXT = (FWPM_IPSEC_IKE_QM_TUNNEL_CONTEXT + 1),
        FWPM_IPSEC_AUTHIP_QM_TUNNEL_CONTEXT = (FWPM_IPSEC_AUTHIP_QM_TRANSPORT_CONTEXT + 1),
        FWPM_IPSEC_IKE_MM_CONTEXT = (FWPM_IPSEC_AUTHIP_QM_TUNNEL_CONTEXT + 1),
        FWPM_IPSEC_AUTHIP_MM_CONTEXT = (FWPM_IPSEC_IKE_MM_CONTEXT + 1),
        FWPM_CLASSIFY_OPTIONS_CONTEXT = (FWPM_IPSEC_AUTHIP_MM_CONTEXT + 1),
        FWPM_GENERAL_CONTEXT = (FWPM_CLASSIFY_OPTIONS_CONTEXT + 1),
        FWPM_IPSEC_IKEV2_QM_TUNNEL_CONTEXT = (FWPM_GENERAL_CONTEXT + 1),
        FWPM_IPSEC_IKEV2_MM_CONTEXT = (FWPM_IPSEC_IKEV2_QM_TUNNEL_CONTEXT + 1),
        FWPM_IPSEC_DOSP_CONTEXT = (FWPM_IPSEC_IKEV2_MM_CONTEXT + 1),
        FWPM_IPSEC_IKEV2_QM_TRANSPORT_CONTEXT = (FWPM_IPSEC_DOSP_CONTEXT + 1),
        FWPM_NETWORK_CONNECTION_POLICY_CONTEXT = (FWPM_IPSEC_IKEV2_QM_TRANSPORT_CONTEXT + 1),
        FWPM_PROVIDER_CONTEXT_TYPE_MAX = (FWPM_NETWORK_CONNECTION_POLICY_CONTEXT + 1),
    }

    public unsafe partial struct FWPM_PROVIDER_CONTEXT0_
    {
        public Guid providerContextKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid* providerKey;

        public FWP_BYTE_BLOB providerData;

        [NativeTypeName("FWPM_PROVIDER_CONTEXT_TYPE")]
        public FWPM_PROVIDER_CONTEXT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L231_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT64")]
        public ulong providerContextId;

        [UnscopedRef]
        public ref IPSEC_KEYING_POLICY0_* keyingPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.keyingPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY0_* ikeQmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY0_* ikeQmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY0_* authipQmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authipQmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY0_* authipQmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authipQmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY0_* ikeMmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY0_* authIpMmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authIpMmPolicy;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* dataBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dataBuffer;
            }
        }

        [UnscopedRef]
        public ref FWPM_CLASSIFY_OPTIONS0_* classifyOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyOptions;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_KEYING_POLICY0 *")]
            public IPSEC_KEYING_POLICY0_* keyingPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY0 *")]
            public IPSEC_TRANSPORT_POLICY0_* ikeQmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY0 *")]
            public IPSEC_TUNNEL_POLICY0_* ikeQmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY0 *")]
            public IPSEC_TRANSPORT_POLICY0_* authipQmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY0 *")]
            public IPSEC_TUNNEL_POLICY0_* authipQmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY0 *")]
            public IKEEXT_POLICY0_* ikeMmPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY0 *")]
            public IKEEXT_POLICY0_* authIpMmPolicy;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* dataBuffer;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_CLASSIFY_OPTIONS0 *")]
            public FWPM_CLASSIFY_OPTIONS0_* classifyOptions;
        }
    }

    public unsafe partial struct FWPM_PROVIDER_CONTEXT1_
    {
        public Guid providerContextKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid* providerKey;

        public FWP_BYTE_BLOB providerData;

        [NativeTypeName("FWPM_PROVIDER_CONTEXT_TYPE")]
        public FWPM_PROVIDER_CONTEXT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L256_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT64")]
        public ulong providerContextId;

        [UnscopedRef]
        public ref IPSEC_KEYING_POLICY0_* keyingPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.keyingPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY1_* ikeQmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY1_* ikeQmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY1_* authipQmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authipQmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY1_* authipQmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authipQmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY1_* ikeMmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY1_* authIpMmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authIpMmPolicy;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* dataBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dataBuffer;
            }
        }

        [UnscopedRef]
        public ref FWPM_CLASSIFY_OPTIONS0_* classifyOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyOptions;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY1_* ikeV2QmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeV2QmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY1_* ikeV2MmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeV2MmPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_DOSP_OPTIONS0_* idpOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpOptions;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_KEYING_POLICY0 *")]
            public IPSEC_KEYING_POLICY0_* keyingPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY1 *")]
            public IPSEC_TRANSPORT_POLICY1_* ikeQmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY1 *")]
            public IPSEC_TUNNEL_POLICY1_* ikeQmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY1 *")]
            public IPSEC_TRANSPORT_POLICY1_* authipQmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY1 *")]
            public IPSEC_TUNNEL_POLICY1_* authipQmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY1 *")]
            public IKEEXT_POLICY1_* ikeMmPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY1 *")]
            public IKEEXT_POLICY1_* authIpMmPolicy;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* dataBuffer;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_CLASSIFY_OPTIONS0 *")]
            public FWPM_CLASSIFY_OPTIONS0_* classifyOptions;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY1 *")]
            public IPSEC_TUNNEL_POLICY1_* ikeV2QmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY1 *")]
            public IKEEXT_POLICY1_* ikeV2MmPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_DOSP_OPTIONS0 *")]
            public IPSEC_DOSP_OPTIONS0_* idpOptions;
        }
    }

    public unsafe partial struct FWPM_PROVIDER_CONTEXT2_
    {
        public Guid providerContextKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid* providerKey;

        public FWP_BYTE_BLOB providerData;

        [NativeTypeName("FWPM_PROVIDER_CONTEXT_TYPE")]
        public FWPM_PROVIDER_CONTEXT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L284_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT64")]
        public ulong providerContextId;

        [UnscopedRef]
        public ref IPSEC_KEYING_POLICY1_* keyingPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.keyingPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY2_* ikeQmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY2_* ikeQmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY2_* authipQmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authipQmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY2_* authipQmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authipQmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY2_* ikeMmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY2_* authIpMmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authIpMmPolicy;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* dataBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dataBuffer;
            }
        }

        [UnscopedRef]
        public ref FWPM_CLASSIFY_OPTIONS0_* classifyOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyOptions;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY2_* ikeV2QmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeV2QmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY2_* ikeV2QmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeV2QmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY2_* ikeV2MmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeV2MmPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_DOSP_OPTIONS0_* idpOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpOptions;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_KEYING_POLICY1 *")]
            public IPSEC_KEYING_POLICY1_* keyingPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY2 *")]
            public IPSEC_TRANSPORT_POLICY2_* ikeQmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY2 *")]
            public IPSEC_TUNNEL_POLICY2_* ikeQmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY2 *")]
            public IPSEC_TRANSPORT_POLICY2_* authipQmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY2 *")]
            public IPSEC_TUNNEL_POLICY2_* authipQmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY2 *")]
            public IKEEXT_POLICY2_* ikeMmPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY2 *")]
            public IKEEXT_POLICY2_* authIpMmPolicy;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* dataBuffer;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_CLASSIFY_OPTIONS0 *")]
            public FWPM_CLASSIFY_OPTIONS0_* classifyOptions;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY2 *")]
            public IPSEC_TUNNEL_POLICY2_* ikeV2QmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY2 *")]
            public IPSEC_TRANSPORT_POLICY2_* ikeV2QmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY2 *")]
            public IKEEXT_POLICY2_* ikeV2MmPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_DOSP_OPTIONS0 *")]
            public IPSEC_DOSP_OPTIONS0_* idpOptions;
        }
    }

    public unsafe partial struct FWPM_PROVIDER_CONTEXT3_
    {
        public Guid providerContextKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid* providerKey;

        public FWP_BYTE_BLOB providerData;

        [NativeTypeName("FWPM_PROVIDER_CONTEXT_TYPE")]
        public FWPM_PROVIDER_CONTEXT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L313_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT64")]
        public ulong providerContextId;

        [UnscopedRef]
        public ref IPSEC_KEYING_POLICY1_* keyingPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.keyingPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY2_* ikeQmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY3_* ikeQmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY2_* authipQmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authipQmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY3_* authipQmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authipQmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY2_* ikeMmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY2_* authIpMmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.authIpMmPolicy;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_BLOB* dataBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.dataBuffer;
            }
        }

        [UnscopedRef]
        public ref FWPM_CLASSIFY_OPTIONS0_* classifyOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyOptions;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TUNNEL_POLICY3_* ikeV2QmTunnelPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeV2QmTunnelPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_TRANSPORT_POLICY2_* ikeV2QmTransportPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeV2QmTransportPolicy;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_POLICY2_* ikeV2MmPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeV2MmPolicy;
            }
        }

        [UnscopedRef]
        public ref IPSEC_DOSP_OPTIONS0_* idpOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpOptions;
            }
        }

        [UnscopedRef]
        public ref FWPM_NETWORK_CONNECTION_POLICY_SETTINGS0_* networkConnectionPolicy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.networkConnectionPolicy;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_KEYING_POLICY1 *")]
            public IPSEC_KEYING_POLICY1_* keyingPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY2 *")]
            public IPSEC_TRANSPORT_POLICY2_* ikeQmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY3 *")]
            public IPSEC_TUNNEL_POLICY3_* ikeQmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY2 *")]
            public IPSEC_TRANSPORT_POLICY2_* authipQmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY3 *")]
            public IPSEC_TUNNEL_POLICY3_* authipQmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY2 *")]
            public IKEEXT_POLICY2_* ikeMmPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY2 *")]
            public IKEEXT_POLICY2_* authIpMmPolicy;

            [FieldOffset(0)]
            public FWP_BYTE_BLOB* dataBuffer;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_CLASSIFY_OPTIONS0 *")]
            public FWPM_CLASSIFY_OPTIONS0_* classifyOptions;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TUNNEL_POLICY3 *")]
            public IPSEC_TUNNEL_POLICY3_* ikeV2QmTunnelPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_TRANSPORT_POLICY2 *")]
            public IPSEC_TRANSPORT_POLICY2_* ikeV2QmTransportPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_POLICY2 *")]
            public IKEEXT_POLICY2_* ikeV2MmPolicy;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_DOSP_OPTIONS0 *")]
            public IPSEC_DOSP_OPTIONS0_* idpOptions;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NETWORK_CONNECTION_POLICY_SETTINGS0 *")]
            public FWPM_NETWORK_CONNECTION_POLICY_SETTINGS0_* networkConnectionPolicy;
        }
    }

    public unsafe partial struct FWPM_PROVIDER_CONTEXT_ENUM_TEMPLATE0_
    {
        public Guid* providerKey;

        [NativeTypeName("FWPM_PROVIDER_CONTEXT_TYPE")]
        public FWPM_PROVIDER_CONTEXT_TYPE_ providerContextType;
    }

    public partial struct FWPM_PROVIDER_CONTEXT_CHANGE0_
    {
        [NativeTypeName("FWPM_CHANGE_TYPE")]
        public FWPM_CHANGE_TYPE_ changeType;

        public Guid providerContextKey;

        [NativeTypeName("UINT64")]
        public ulong providerContextId;
    }

    public unsafe partial struct FWPM_PROVIDER_CONTEXT_SUBSCRIPTION0_
    {
        [NativeTypeName("FWPM_PROVIDER_CONTEXT_ENUM_TEMPLATE0 *")]
        public FWPM_PROVIDER_CONTEXT_ENUM_TEMPLATE0_* enumTemplate;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public unsafe partial struct FWPM_SUBLAYER0_
    {
        public Guid subLayerKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid* providerKey;

        public FWP_BYTE_BLOB providerData;

        [NativeTypeName("UINT16")]
        public ushort weight;
    }

    public unsafe partial struct FWPM_SUBLAYER_ENUM_TEMPLATE0_
    {
        public Guid* providerKey;
    }

    public partial struct FWPM_SUBLAYER_CHANGE0_
    {
        [NativeTypeName("FWPM_CHANGE_TYPE")]
        public FWPM_CHANGE_TYPE_ changeType;

        public Guid subLayerKey;
    }

    public unsafe partial struct FWPM_SUBLAYER_SUBSCRIPTION0_
    {
        [NativeTypeName("FWPM_SUBLAYER_ENUM_TEMPLATE0 *")]
        public FWPM_SUBLAYER_ENUM_TEMPLATE0_* enumTemplate;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public enum FWPM_FIELD_TYPE_
    {
        FWPM_FIELD_RAW_DATA = 0,
        FWPM_FIELD_IP_ADDRESS = (FWPM_FIELD_RAW_DATA + 1),
        FWPM_FIELD_FLAGS = (FWPM_FIELD_IP_ADDRESS + 1),
        FWPM_FIELD_TYPE_MAX = (FWPM_FIELD_FLAGS + 1),
    }

    public unsafe partial struct FWPM_FIELD0_
    {
        public Guid* fieldKey;

        [NativeTypeName("FWPM_FIELD_TYPE")]
        public FWPM_FIELD_TYPE_ type;

        [NativeTypeName("FWP_DATA_TYPE")]
        public FWP_DATA_TYPE_ dataType;
    }

    public unsafe partial struct FWPM_LAYER0_
    {
        public Guid layerKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint numFields;

        [NativeTypeName("FWPM_FIELD0 *")]
        public FWPM_FIELD0_* field;

        public Guid defaultSubLayerKey;

        [NativeTypeName("UINT16")]
        public ushort layerId;
    }

    public partial struct FWPM_LAYER_ENUM_TEMPLATE0_
    {
        [NativeTypeName("UINT64")]
        public ulong reserved;
    }

    public unsafe partial struct FWPM_CALLOUT0_
    {
        public Guid calloutKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid* providerKey;

        public FWP_BYTE_BLOB providerData;

        public Guid applicableLayer;

        [NativeTypeName("UINT32")]
        public uint calloutId;
    }

    public unsafe partial struct FWPM_CALLOUT_ENUM_TEMPLATE0_
    {
        public Guid* providerKey;

        public Guid layerKey;
    }

    public partial struct FWPM_CALLOUT_CHANGE0_
    {
        [NativeTypeName("FWPM_CHANGE_TYPE")]
        public FWPM_CHANGE_TYPE_ changeType;

        public Guid calloutKey;

        [NativeTypeName("UINT32")]
        public uint calloutId;
    }

    public unsafe partial struct FWPM_CALLOUT_SUBSCRIPTION0_
    {
        [NativeTypeName("FWPM_CALLOUT_ENUM_TEMPLATE0 *")]
        public FWPM_CALLOUT_ENUM_TEMPLATE0_* enumTemplate;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public partial struct FWPM_ACTION0_
    {
        [NativeTypeName("FWP_ACTION_TYPE")]
        public uint type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L456_C43")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref Guid filterType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.filterType;
            }
        }

        [UnscopedRef]
        public ref Guid calloutKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.calloutKey;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public Guid filterType;

            [FieldOffset(0)]
            public Guid calloutKey;
        }
    }

    public partial struct FWPM_FILTER_CONDITION0_
    {
        public Guid fieldKey;

        [NativeTypeName("FWP_MATCH_TYPE")]
        public FWP_MATCH_TYPE_ matchType;

        [NativeTypeName("FWP_CONDITION_VALUE0")]
        public FWP_CONDITION_VALUE0_ conditionValue;
    }

    public unsafe partial struct FWPM_FILTER0_
    {
        public Guid filterKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid* providerKey;

        public FWP_BYTE_BLOB providerData;

        public Guid layerKey;

        public Guid subLayerKey;

        [NativeTypeName("FWP_VALUE0")]
        public FWP_VALUE0_ weight;

        [NativeTypeName("UINT32")]
        public uint numFilterConditions;

        [NativeTypeName("FWPM_FILTER_CONDITION0 *")]
        public FWPM_FILTER_CONDITION0_* filterCondition;

        [NativeTypeName("FWPM_ACTION0")]
        public FWPM_ACTION0_ action;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L499_C43")]
        public _Anonymous_e__Union Anonymous;

        public Guid* reserved;

        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("FWP_VALUE0")]
        public FWP_VALUE0_ effectiveWeight;

        [UnscopedRef]
        public ref ulong rawContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.rawContext;
            }
        }

        [UnscopedRef]
        public ref Guid providerContextKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.providerContextKey;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT64")]
            public ulong rawContext;

            [FieldOffset(0)]
            public Guid providerContextKey;
        }
    }

    public unsafe partial struct FWPM_FILTER_ENUM_TEMPLATE0_
    {
        public Guid* providerKey;

        public Guid layerKey;

        [NativeTypeName("FWP_FILTER_ENUM_TYPE")]
        public FWP_FILTER_ENUM_TYPE_ enumType;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("FWPM_PROVIDER_CONTEXT_ENUM_TEMPLATE0 *")]
        public FWPM_PROVIDER_CONTEXT_ENUM_TEMPLATE0_* providerContextTemplate;

        [NativeTypeName("UINT32")]
        public uint numFilterConditions;

        [NativeTypeName("FWPM_FILTER_CONDITION0 *")]
        public FWPM_FILTER_CONDITION0_* filterCondition;

        [NativeTypeName("UINT32")]
        public uint actionMask;

        public Guid* calloutKey;
    }

    public partial struct FWPM_FILTER_CHANGE0_
    {
        [NativeTypeName("FWPM_CHANGE_TYPE")]
        public FWPM_CHANGE_TYPE_ changeType;

        public Guid filterKey;

        [NativeTypeName("UINT64")]
        public ulong filterId;
    }

    public unsafe partial struct FWPM_FILTER_SUBSCRIPTION0_
    {
        [NativeTypeName("FWPM_FILTER_ENUM_TEMPLATE0 *")]
        public FWPM_FILTER_ENUM_TEMPLATE0_* enumTemplate;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public partial struct FWPM_LAYER_STATISTICS0_
    {
        public Guid layerId;

        [NativeTypeName("UINT32")]
        public uint classifyPermitCount;

        [NativeTypeName("UINT32")]
        public uint classifyBlockCount;

        [NativeTypeName("UINT32")]
        public uint classifyVetoCount;

        [NativeTypeName("UINT32")]
        public uint numCacheEntries;
    }

    public partial struct FWPM_LAYER_STATISTICS1_
    {
        public Guid layerId;

        [NativeTypeName("UINT32")]
        public uint classifyPermitCount;

        [NativeTypeName("UINT32")]
        public uint classifyBlockCount;

        [NativeTypeName("UINT32")]
        public uint classifyVetoCount;

        [NativeTypeName("UINT32")]
        public uint numCacheEntries;

        [NativeTypeName("UINT32")]
        public uint filterCount;

        [NativeTypeName("UINT32")]
        public uint totalFilterSize;
    }

    public unsafe partial struct FWPM_STATISTICS0_
    {
        [NativeTypeName("UINT32")]
        public uint numLayerStatistics;

        [NativeTypeName("FWPM_LAYER_STATISTICS0 *")]
        public FWPM_LAYER_STATISTICS0_* layerStatistics;

        [NativeTypeName("UINT32")]
        public uint inboundAllowedConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint inboundBlockedConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint outboundAllowedConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint outboundBlockedConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint inboundAllowedConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint inboundBlockedConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint outboundAllowedConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint outboundBlockedConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint inboundActiveConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint outboundActiveConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint inboundActiveConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint outboundActiveConnectionsV6;

        [NativeTypeName("UINT64")]
        public ulong reauthDirInbound;

        [NativeTypeName("UINT64")]
        public ulong reauthDirOutbound;

        [NativeTypeName("UINT64")]
        public ulong reauthFamilyV4;

        [NativeTypeName("UINT64")]
        public ulong reauthFamilyV6;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoOther;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoIPv4;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoIPv6;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoICMP;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoICMP6;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoUDP;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoTCP;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonPolicyChange;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonNewArrivalInterface;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonNewNextHopInterface;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonProfileCrossing;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonClassifyCompletion;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonIPSecPropertiesChanged;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonMidStreamInspection;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonSocketPropertyChanged;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonNewInboundMCastBCastPacket;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonEDPPolicyChanged;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonProxyHandleChanged;
    }

    public unsafe partial struct FWPM_STATISTICS1_
    {
        [NativeTypeName("UINT32")]
        public uint numLayerStatistics;

        [NativeTypeName("FWPM_LAYER_STATISTICS1 *")]
        public FWPM_LAYER_STATISTICS1_* layerStatistics;

        [NativeTypeName("UINT32")]
        public uint inboundAllowedConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint inboundBlockedConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint outboundAllowedConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint outboundBlockedConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint inboundAllowedConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint inboundBlockedConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint outboundAllowedConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint outboundBlockedConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint inboundActiveConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint outboundActiveConnectionsV4;

        [NativeTypeName("UINT32")]
        public uint inboundActiveConnectionsV6;

        [NativeTypeName("UINT32")]
        public uint outboundActiveConnectionsV6;

        [NativeTypeName("UINT64")]
        public ulong reauthDirInbound;

        [NativeTypeName("UINT64")]
        public ulong reauthDirOutbound;

        [NativeTypeName("UINT64")]
        public ulong reauthFamilyV4;

        [NativeTypeName("UINT64")]
        public ulong reauthFamilyV6;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoOther;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoIPv4;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoIPv6;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoICMP;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoICMP6;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoUDP;

        [NativeTypeName("UINT64")]
        public ulong reauthProtoTCP;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonPolicyChange;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonNewArrivalInterface;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonNewNextHopInterface;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonProfileCrossing;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonClassifyCompletion;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonIPSecPropertiesChanged;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonMidStreamInspection;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonSocketPropertyChanged;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonNewInboundMCastBCastPacket;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonEDPPolicyChanged;

        [NativeTypeName("UINT64")]
        public ulong reauthReasonProxyHandleChanged;
    }

    public unsafe partial struct FWPM_NET_EVENT_HEADER0_
    {
        public FILETIME timeStamp;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("UINT8")]
        public byte ipProtocol;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L656_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L661_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT16")]
        public ushort localPort;

        [NativeTypeName("UINT16")]
        public ushort remotePort;

        [NativeTypeName("UINT32")]
        public uint scopeId;

        public FWP_BYTE_BLOB appId;

        public SID* userId;

        [UnscopedRef]
        public ref uint localAddrV4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localAddrV4;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_ localAddrV6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localAddrV6;
            }
        }

        [UnscopedRef]
        public ref uint remoteAddrV4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteAddrV4;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_ remoteAddrV6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteAddrV6;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint localAddrV4;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16")]
            public FWP_BYTE_ARRAY16_ localAddrV6;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint remoteAddrV4;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16")]
            public FWP_BYTE_ARRAY16_ remoteAddrV6;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT_HEADER1_
    {
        public FILETIME timeStamp;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("UINT8")]
        public byte ipProtocol;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L679_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L685_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT16")]
        public ushort localPort;

        [NativeTypeName("UINT16")]
        public ushort remotePort;

        [NativeTypeName("UINT32")]
        public uint scopeId;

        public FWP_BYTE_BLOB appId;

        public SID* userId;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L696_C36")]
        public _Anonymous3_e__Union Anonymous3;

        [UnscopedRef]
        public ref uint localAddrV4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localAddrV4;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_ localAddrV6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localAddrV6;
            }
        }

        [UnscopedRef]
        public ref uint remoteAddrV4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteAddrV4;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_ remoteAddrV6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteAddrV6;
            }
        }

        [UnscopedRef]
        public ref FWP_NE_FAMILY_ reserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.reserved1;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY6_ reserved2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved2;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY6_ reserved3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved3;
            }
        }

        [UnscopedRef]
        public ref uint reserved4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved4;
            }
        }

        [UnscopedRef]
        public ref uint reserved5
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved5;
            }
        }

        [UnscopedRef]
        public ref ushort reserved6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved6;
            }
        }

        [UnscopedRef]
        public ref uint reserved7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved7;
            }
        }

        [UnscopedRef]
        public ref uint reserved8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved8;
            }
        }

        [UnscopedRef]
        public ref ushort reserved9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved9;
            }
        }

        [UnscopedRef]
        public ref ulong reserved10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.Anonymous.Anonymous.Anonymous.reserved10;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint localAddrV4;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16")]
            public FWP_BYTE_ARRAY16_ localAddrV6;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint remoteAddrV4;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16")]
            public FWP_BYTE_ARRAY16_ remoteAddrV6;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_fwpmtypes_L698_C24")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("FWP_AF")]
                public FWP_NE_FAMILY_ reserved1;

                [NativeTypeName("__AnonymousRecord_fwpmtypes_L701_C44")]
                public _Anonymous_e__Union Anonymous;

                [StructLayout(LayoutKind.Explicit)]
                public partial struct _Anonymous_e__Union
                {
                    [FieldOffset(0)]
                    [NativeTypeName("__AnonymousRecord_fwpmtypes_L703_C32")]
                    public _Anonymous_e__Struct Anonymous;

                    public partial struct _Anonymous_e__Struct
                    {
                        [NativeTypeName("FWP_BYTE_ARRAY6")]
                        public FWP_BYTE_ARRAY6_ reserved2;

                        [NativeTypeName("FWP_BYTE_ARRAY6")]
                        public FWP_BYTE_ARRAY6_ reserved3;

                        [NativeTypeName("UINT32")]
                        public uint reserved4;

                        [NativeTypeName("UINT32")]
                        public uint reserved5;

                        [NativeTypeName("UINT16")]
                        public ushort reserved6;

                        [NativeTypeName("UINT32")]
                        public uint reserved7;

                        [NativeTypeName("UINT32")]
                        public uint reserved8;

                        [NativeTypeName("UINT16")]
                        public ushort reserved9;

                        [NativeTypeName("UINT64")]
                        public ulong reserved10;
                    }
                }
            }
        }
    }

    public unsafe partial struct FWPM_NET_EVENT_HEADER2_
    {
        public FILETIME timeStamp;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("UINT8")]
        public byte ipProtocol;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L728_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L734_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT16")]
        public ushort localPort;

        [NativeTypeName("UINT16")]
        public ushort remotePort;

        [NativeTypeName("UINT32")]
        public uint scopeId;

        public FWP_BYTE_BLOB appId;

        public SID* userId;

        [NativeTypeName("FWP_AF")]
        public FWP_NE_FAMILY_ addressFamily;

        public SID* packageSid;

        [UnscopedRef]
        public ref uint localAddrV4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localAddrV4;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_ localAddrV6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localAddrV6;
            }
        }

        [UnscopedRef]
        public ref uint remoteAddrV4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteAddrV4;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_ remoteAddrV6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteAddrV6;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint localAddrV4;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16")]
            public FWP_BYTE_ARRAY16_ localAddrV6;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint remoteAddrV4;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16")]
            public FWP_BYTE_ARRAY16_ remoteAddrV6;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT_HEADER3_
    {
        public FILETIME timeStamp;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("UINT8")]
        public byte ipProtocol;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L757_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L763_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT16")]
        public ushort localPort;

        [NativeTypeName("UINT16")]
        public ushort remotePort;

        [NativeTypeName("UINT32")]
        public uint scopeId;

        public FWP_BYTE_BLOB appId;

        public SID* userId;

        [NativeTypeName("FWP_AF")]
        public FWP_NE_FAMILY_ addressFamily;

        public SID* packageSid;

        [NativeTypeName("wchar_t *")]
        public char* enterpriseId;

        [NativeTypeName("UINT64")]
        public ulong policyFlags;

        public FWP_BYTE_BLOB effectiveName;

        [UnscopedRef]
        public ref uint localAddrV4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localAddrV4;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_ localAddrV6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localAddrV6;
            }
        }

        [UnscopedRef]
        public ref uint remoteAddrV4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteAddrV4;
            }
        }

        [UnscopedRef]
        public ref FWP_BYTE_ARRAY16_ remoteAddrV6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteAddrV6;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint localAddrV4;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16")]
            public FWP_BYTE_ARRAY16_ localAddrV6;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint remoteAddrV4;

            [FieldOffset(0)]
            [NativeTypeName("FWP_BYTE_ARRAY16")]
            public FWP_BYTE_ARRAY16_ remoteAddrV6;
        }
    }

    public enum FWPM_NET_EVENT_TYPE_
    {
        FWPM_NET_EVENT_TYPE_IKEEXT_MM_FAILURE = 0,
        FWPM_NET_EVENT_TYPE_IKEEXT_QM_FAILURE = (FWPM_NET_EVENT_TYPE_IKEEXT_MM_FAILURE + 1),
        FWPM_NET_EVENT_TYPE_IKEEXT_EM_FAILURE = (FWPM_NET_EVENT_TYPE_IKEEXT_QM_FAILURE + 1),
        FWPM_NET_EVENT_TYPE_CLASSIFY_DROP = (FWPM_NET_EVENT_TYPE_IKEEXT_EM_FAILURE + 1),
        FWPM_NET_EVENT_TYPE_IPSEC_KERNEL_DROP = (FWPM_NET_EVENT_TYPE_CLASSIFY_DROP + 1),
        FWPM_NET_EVENT_TYPE_IPSEC_DOSP_DROP = (FWPM_NET_EVENT_TYPE_IPSEC_KERNEL_DROP + 1),
        FWPM_NET_EVENT_TYPE_CLASSIFY_ALLOW = (FWPM_NET_EVENT_TYPE_IPSEC_DOSP_DROP + 1),
        FWPM_NET_EVENT_TYPE_CAPABILITY_DROP = (FWPM_NET_EVENT_TYPE_CLASSIFY_ALLOW + 1),
        FWPM_NET_EVENT_TYPE_CAPABILITY_ALLOW = (FWPM_NET_EVENT_TYPE_CAPABILITY_DROP + 1),
        FWPM_NET_EVENT_TYPE_CLASSIFY_DROP_MAC = (FWPM_NET_EVENT_TYPE_CAPABILITY_ALLOW + 1),
        FWPM_NET_EVENT_TYPE_LPM_PACKET_ARRIVAL = (FWPM_NET_EVENT_TYPE_CLASSIFY_DROP_MAC + 1),
        FWPM_NET_EVENT_TYPE_MAX = (FWPM_NET_EVENT_TYPE_LPM_PACKET_ARRIVAL + 1),
    }

    public partial struct FWPM_NET_EVENT_IKEEXT_MM_FAILURE0_
    {
        [NativeTypeName("UINT32")]
        public uint failureErrorCode;

        [NativeTypeName("IPSEC_FAILURE_POINT")]
        public IPSEC_FAILURE_POINT_ failurePoint;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyingModuleType;

        [NativeTypeName("IKEEXT_MM_SA_STATE")]
        public IKEEXT_MM_SA_STATE_ mmState;

        [NativeTypeName("IKEEXT_SA_ROLE")]
        public IKEEXT_SA_ROLE_ saRole;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ mmAuthMethod;

        [NativeTypeName("UINT8[20]")]
        public _endCertHash_e__FixedBuffer endCertHash;

        [NativeTypeName("UINT64")]
        public ulong mmId;

        [NativeTypeName("UINT64")]
        public ulong mmFilterId;

        [InlineArray(20)]
        public partial struct _endCertHash_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT_IKEEXT_MM_FAILURE1_
    {
        [NativeTypeName("UINT32")]
        public uint failureErrorCode;

        [NativeTypeName("IPSEC_FAILURE_POINT")]
        public IPSEC_FAILURE_POINT_ failurePoint;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyingModuleType;

        [NativeTypeName("IKEEXT_MM_SA_STATE")]
        public IKEEXT_MM_SA_STATE_ mmState;

        [NativeTypeName("IKEEXT_SA_ROLE")]
        public IKEEXT_SA_ROLE_ saRole;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ mmAuthMethod;

        [NativeTypeName("UINT8[20]")]
        public _endCertHash_e__FixedBuffer endCertHash;

        [NativeTypeName("UINT64")]
        public ulong mmId;

        [NativeTypeName("UINT64")]
        public ulong mmFilterId;

        [NativeTypeName("wchar_t *")]
        public char* localPrincipalNameForAuth;

        [NativeTypeName("wchar_t *")]
        public char* remotePrincipalNameForAuth;

        [NativeTypeName("UINT32")]
        public uint numLocalPrincipalGroupSids;

        [NativeTypeName("LPWSTR *")]
        public char** localPrincipalGroupSids;

        [NativeTypeName("UINT32")]
        public uint numRemotePrincipalGroupSids;

        [NativeTypeName("LPWSTR *")]
        public char** remotePrincipalGroupSids;

        [InlineArray(20)]
        public partial struct _endCertHash_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT_IKEEXT_MM_FAILURE2_
    {
        [NativeTypeName("UINT32")]
        public uint failureErrorCode;

        [NativeTypeName("IPSEC_FAILURE_POINT")]
        public IPSEC_FAILURE_POINT_ failurePoint;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyingModuleType;

        [NativeTypeName("IKEEXT_MM_SA_STATE")]
        public IKEEXT_MM_SA_STATE_ mmState;

        [NativeTypeName("IKEEXT_SA_ROLE")]
        public IKEEXT_SA_ROLE_ saRole;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ mmAuthMethod;

        [NativeTypeName("UINT8[20]")]
        public _endCertHash_e__FixedBuffer endCertHash;

        [NativeTypeName("UINT64")]
        public ulong mmId;

        [NativeTypeName("UINT64")]
        public ulong mmFilterId;

        [NativeTypeName("wchar_t *")]
        public char* localPrincipalNameForAuth;

        [NativeTypeName("wchar_t *")]
        public char* remotePrincipalNameForAuth;

        [NativeTypeName("UINT32")]
        public uint numLocalPrincipalGroupSids;

        [NativeTypeName("LPWSTR *")]
        public char** localPrincipalGroupSids;

        [NativeTypeName("UINT32")]
        public uint numRemotePrincipalGroupSids;

        [NativeTypeName("LPWSTR *")]
        public char** remotePrincipalGroupSids;

        public Guid* providerContextKey;

        [InlineArray(20)]
        public partial struct _endCertHash_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_
    {
        [NativeTypeName("UINT32")]
        public uint failureErrorCode;

        [NativeTypeName("IPSEC_FAILURE_POINT")]
        public IPSEC_FAILURE_POINT_ failurePoint;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyingModuleType;

        [NativeTypeName("IKEEXT_QM_SA_STATE")]
        public IKEEXT_QM_SA_STATE_ qmState;

        [NativeTypeName("IKEEXT_SA_ROLE")]
        public IKEEXT_SA_ROLE_ saRole;

        [NativeTypeName("IPSEC_TRAFFIC_TYPE")]
        public IPSEC_TRAFFIC_TYPE_ saTrafficType;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L869_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L874_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT64")]
        public ulong qmFilterId;

        [UnscopedRef]
        public ref FWP_CONDITION_VALUE0_ localSubNet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localSubNet;
            }
        }

        [UnscopedRef]
        public ref FWP_CONDITION_VALUE0_ remoteSubNet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteSubNet;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWP_CONDITION_VALUE0")]
            public FWP_CONDITION_VALUE0_ localSubNet;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWP_CONDITION_VALUE0")]
            public FWP_CONDITION_VALUE0_ remoteSubNet;
        }
    }

    public partial struct FWPM_NET_EVENT_IKEEXT_QM_FAILURE1_
    {
        [NativeTypeName("UINT32")]
        public uint failureErrorCode;

        [NativeTypeName("IPSEC_FAILURE_POINT")]
        public IPSEC_FAILURE_POINT_ failurePoint;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyingModuleType;

        [NativeTypeName("IKEEXT_QM_SA_STATE")]
        public IKEEXT_QM_SA_STATE_ qmState;

        [NativeTypeName("IKEEXT_SA_ROLE")]
        public IKEEXT_SA_ROLE_ saRole;

        [NativeTypeName("IPSEC_TRAFFIC_TYPE")]
        public IPSEC_TRAFFIC_TYPE_ saTrafficType;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L891_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L896_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT64")]
        public ulong qmFilterId;

        [NativeTypeName("UINT64")]
        public ulong mmSaLuid;

        public Guid mmProviderContextKey;

        [UnscopedRef]
        public ref FWP_CONDITION_VALUE0_ localSubNet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localSubNet;
            }
        }

        [UnscopedRef]
        public ref FWP_CONDITION_VALUE0_ remoteSubNet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteSubNet;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWP_CONDITION_VALUE0")]
            public FWP_CONDITION_VALUE0_ localSubNet;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWP_CONDITION_VALUE0")]
            public FWP_CONDITION_VALUE0_ remoteSubNet;
        }
    }

    public partial struct FWPM_NET_EVENT_IKEEXT_EM_FAILURE0_
    {
        [NativeTypeName("UINT32")]
        public uint failureErrorCode;

        [NativeTypeName("IPSEC_FAILURE_POINT")]
        public IPSEC_FAILURE_POINT_ failurePoint;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("IKEEXT_EM_SA_STATE")]
        public IKEEXT_EM_SA_STATE_ emState;

        [NativeTypeName("IKEEXT_SA_ROLE")]
        public IKEEXT_SA_ROLE_ saRole;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ emAuthMethod;

        [NativeTypeName("UINT8[20]")]
        public _endCertHash_e__FixedBuffer endCertHash;

        [NativeTypeName("UINT64")]
        public ulong mmId;

        [NativeTypeName("UINT64")]
        public ulong qmFilterId;

        [InlineArray(20)]
        public partial struct _endCertHash_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_
    {
        [NativeTypeName("UINT32")]
        public uint failureErrorCode;

        [NativeTypeName("IPSEC_FAILURE_POINT")]
        public IPSEC_FAILURE_POINT_ failurePoint;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("IKEEXT_EM_SA_STATE")]
        public IKEEXT_EM_SA_STATE_ emState;

        [NativeTypeName("IKEEXT_SA_ROLE")]
        public IKEEXT_SA_ROLE_ saRole;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ emAuthMethod;

        [NativeTypeName("UINT8[20]")]
        public _endCertHash_e__FixedBuffer endCertHash;

        [NativeTypeName("UINT64")]
        public ulong mmId;

        [NativeTypeName("UINT64")]
        public ulong qmFilterId;

        [NativeTypeName("wchar_t *")]
        public char* localPrincipalNameForAuth;

        [NativeTypeName("wchar_t *")]
        public char* remotePrincipalNameForAuth;

        [NativeTypeName("UINT32")]
        public uint numLocalPrincipalGroupSids;

        [NativeTypeName("LPWSTR *")]
        public char** localPrincipalGroupSids;

        [NativeTypeName("UINT32")]
        public uint numRemotePrincipalGroupSids;

        [NativeTypeName("LPWSTR *")]
        public char** remotePrincipalGroupSids;

        [NativeTypeName("IPSEC_TRAFFIC_TYPE")]
        public IPSEC_TRAFFIC_TYPE_ saTrafficType;

        [InlineArray(20)]
        public partial struct _endCertHash_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct FWPM_NET_EVENT_CLASSIFY_DROP0_
    {
        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("UINT16")]
        public ushort layerId;
    }

    public partial struct FWPM_NET_EVENT_CLASSIFY_DROP1_
    {
        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("UINT16")]
        public ushort layerId;

        [NativeTypeName("UINT32")]
        public uint reauthReason;

        [NativeTypeName("UINT32")]
        public uint originalProfile;

        [NativeTypeName("UINT32")]
        public uint currentProfile;

        [NativeTypeName("UINT32")]
        public uint msFwpDirection;

        [NativeTypeName("BOOL")]
        public int isLoopback;
    }

    public partial struct FWPM_NET_EVENT_CLASSIFY_DROP2_
    {
        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("UINT16")]
        public ushort layerId;

        [NativeTypeName("UINT32")]
        public uint reauthReason;

        [NativeTypeName("UINT32")]
        public uint originalProfile;

        [NativeTypeName("UINT32")]
        public uint currentProfile;

        [NativeTypeName("UINT32")]
        public uint msFwpDirection;

        [NativeTypeName("BOOL")]
        public int isLoopback;

        public FWP_BYTE_BLOB vSwitchId;

        [NativeTypeName("UINT32")]
        public uint vSwitchSourcePort;

        [NativeTypeName("UINT32")]
        public uint vSwitchDestinationPort;
    }

    public partial struct FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_
    {
        [NativeTypeName("FWP_BYTE_ARRAY6")]
        public FWP_BYTE_ARRAY6_ localMacAddr;

        [NativeTypeName("FWP_BYTE_ARRAY6")]
        public FWP_BYTE_ARRAY6_ remoteMacAddr;

        [NativeTypeName("UINT32")]
        public uint mediaType;

        [NativeTypeName("UINT32")]
        public uint ifType;

        [NativeTypeName("UINT16")]
        public ushort etherType;

        [NativeTypeName("UINT32")]
        public uint ndisPortNumber;

        [NativeTypeName("UINT32")]
        public uint reserved;

        [NativeTypeName("UINT16")]
        public ushort vlanTag;

        [NativeTypeName("UINT64")]
        public ulong ifLuid;

        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("UINT16")]
        public ushort layerId;

        [NativeTypeName("UINT32")]
        public uint reauthReason;

        [NativeTypeName("UINT32")]
        public uint originalProfile;

        [NativeTypeName("UINT32")]
        public uint currentProfile;

        [NativeTypeName("UINT32")]
        public uint msFwpDirection;

        [NativeTypeName("BOOL")]
        public int isLoopback;

        public FWP_BYTE_BLOB vSwitchId;

        [NativeTypeName("UINT32")]
        public uint vSwitchSourcePort;

        [NativeTypeName("UINT32")]
        public uint vSwitchDestinationPort;
    }

    public partial struct FWPM_NET_EVENT_CLASSIFY_ALLOW0
    {
        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("UINT16")]
        public ushort layerId;

        [NativeTypeName("UINT32")]
        public uint reauthReason;

        [NativeTypeName("UINT32")]
        public uint originalProfile;

        [NativeTypeName("UINT32")]
        public uint currentProfile;

        [NativeTypeName("UINT32")]
        public uint msFwpDirection;

        [NativeTypeName("BOOL")]
        public int isLoopback;
    }

    public partial struct FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_
    {
        [NativeTypeName("INT32")]
        public int failureStatus;

        [NativeTypeName("FWP_DIRECTION")]
        public FWP_DIRECTION_ direction;

        [NativeTypeName("IPSEC_SA_SPI")]
        public uint spi;

        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("UINT16")]
        public ushort layerId;
    }

    public partial struct FWPM_NET_EVENT_IPSEC_DOSP_DROP0_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1025_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1030_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("INT32")]
        public int failureStatus;

        [NativeTypeName("FWP_DIRECTION")]
        public FWP_DIRECTION_ direction;

        [UnscopedRef]
        public ref uint publicHostV4Addr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.publicHostV4Addr;
            }
        }

        [UnscopedRef]
        public Span<byte> publicHostV6Addr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous1.publicHostV6Addr;
            }
        }

        [UnscopedRef]
        public ref uint internalHostV4Addr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.internalHostV4Addr;
            }
        }

        [UnscopedRef]
        public Span<byte> internalHostV6Addr
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.internalHostV6Addr;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint publicHostV4Addr;

            [FieldOffset(0)]
            [NativeTypeName("UINT8[16]")]
            public _publicHostV6Addr_e__FixedBuffer publicHostV6Addr;

            [InlineArray(16)]
            public partial struct _publicHostV6Addr_e__FixedBuffer
            {
                public byte e0;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint internalHostV4Addr;

            [FieldOffset(0)]
            [NativeTypeName("UINT8[16]")]
            public _internalHostV6Addr_e__FixedBuffer internalHostV6Addr;

            [InlineArray(16)]
            public partial struct _internalHostV6Addr_e__FixedBuffer
            {
                public byte e0;
            }
        }
    }

    public enum FWPM_APPC_NETWORK_CAPABILITY_TYPE_
    {
        FWPM_APPC_NETWORK_CAPABILITY_INTERNET_CLIENT = 0,
        FWPM_APPC_NETWORK_CAPABILITY_INTERNET_CLIENT_SERVER = (FWPM_APPC_NETWORK_CAPABILITY_INTERNET_CLIENT + 1),
        FWPM_APPC_NETWORK_CAPABILITY_INTERNET_PRIVATE_NETWORK = (FWPM_APPC_NETWORK_CAPABILITY_INTERNET_CLIENT_SERVER + 1),
    }

    public partial struct FWPM_NET_EVENT_CAPABILITY_DROP0_
    {
        [NativeTypeName("FWPM_APPC_NETWORK_CAPABILITY_TYPE")]
        public FWPM_APPC_NETWORK_CAPABILITY_TYPE_ networkCapabilityId;

        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("BOOL")]
        public int isLoopback;
    }

    public partial struct FWPM_NET_EVENT_CAPABILITY_ALLOW0_
    {
        [NativeTypeName("FWPM_APPC_NETWORK_CAPABILITY_TYPE")]
        public FWPM_APPC_NETWORK_CAPABILITY_TYPE_ networkCapabilityId;

        [NativeTypeName("UINT64")]
        public ulong filterId;

        [NativeTypeName("BOOL")]
        public int isLoopback;
    }

    public partial struct FWPM_NET_EVENT_LPM_PACKET_ARRIVAL0_
    {
        [NativeTypeName("IPSEC_SA_SPI")]
        public uint spi;
    }

    public unsafe partial struct FWPM_NET_EVENT0_
    {
        [NativeTypeName("FWPM_NET_EVENT_HEADER0")]
        public FWPM_NET_EVENT_HEADER0_ header;

        [NativeTypeName("FWPM_NET_EVENT_TYPE")]
        public FWPM_NET_EVENT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1074_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_MM_FAILURE0_* ikeMmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_* ikeQmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_EM_FAILURE0_* ikeEmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeEmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP0_* classifyDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ipsecDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpDrop;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_MM_FAILURE0 *")]
            public FWPM_NET_EVENT_IKEEXT_MM_FAILURE0_* ikeMmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_QM_FAILURE0 *")]
            public FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_* ikeQmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_EM_FAILURE0 *")]
            public FWPM_NET_EVENT_IKEEXT_EM_FAILURE0_* ikeEmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP0 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP0_* classifyDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_KERNEL_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_DOSP_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT1_
    {
        [NativeTypeName("FWPM_NET_EVENT_HEADER1")]
        public FWPM_NET_EVENT_HEADER1_ header;

        [NativeTypeName("FWPM_NET_EVENT_TYPE")]
        public FWPM_NET_EVENT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1090_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_MM_FAILURE1_* ikeMmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_* ikeQmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeEmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP1_* classifyDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ipsecDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpDrop;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_MM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_MM_FAILURE1_* ikeMmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_QM_FAILURE0 *")]
            public FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_* ikeQmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_EM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP1 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP1_* classifyDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_KERNEL_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_DOSP_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT2_
    {
        [NativeTypeName("FWPM_NET_EVENT_HEADER2")]
        public FWPM_NET_EVENT_HEADER2_ header;

        [NativeTypeName("FWPM_NET_EVENT_TYPE")]
        public FWPM_NET_EVENT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1107_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_MM_FAILURE1_* ikeMmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_* ikeQmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeEmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP2_* classifyDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ipsecDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_ALLOW0* classifyAllow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyAllow;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CAPABILITY_DROP0_* capabilityDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.capabilityDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CAPABILITY_ALLOW0_* capabilityAllow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.capabilityAllow;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_* classifyDropMac
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDropMac;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_MM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_MM_FAILURE1_* ikeMmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_QM_FAILURE0 *")]
            public FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_* ikeQmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_EM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP2 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP2_* classifyDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_KERNEL_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_DOSP_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop;

            [FieldOffset(0)]
            public FWPM_NET_EVENT_CLASSIFY_ALLOW0* classifyAllow;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CAPABILITY_DROP0 *")]
            public FWPM_NET_EVENT_CAPABILITY_DROP0_* capabilityDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CAPABILITY_ALLOW0 *")]
            public FWPM_NET_EVENT_CAPABILITY_ALLOW0_* capabilityAllow;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP_MAC0 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_* classifyDropMac;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT3_
    {
        [NativeTypeName("FWPM_NET_EVENT_HEADER3")]
        public FWPM_NET_EVENT_HEADER3_ header;

        [NativeTypeName("FWPM_NET_EVENT_TYPE")]
        public FWPM_NET_EVENT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1128_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_MM_FAILURE1_* ikeMmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_* ikeQmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeEmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP2_* classifyDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ipsecDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_ALLOW0* classifyAllow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyAllow;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CAPABILITY_DROP0_* capabilityDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.capabilityDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CAPABILITY_ALLOW0_* capabilityAllow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.capabilityAllow;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_* classifyDropMac
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDropMac;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_MM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_MM_FAILURE1_* ikeMmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_QM_FAILURE0 *")]
            public FWPM_NET_EVENT_IKEEXT_QM_FAILURE0_* ikeQmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_EM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP2 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP2_* classifyDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_KERNEL_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_DOSP_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop;

            [FieldOffset(0)]
            public FWPM_NET_EVENT_CLASSIFY_ALLOW0* classifyAllow;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CAPABILITY_DROP0 *")]
            public FWPM_NET_EVENT_CAPABILITY_DROP0_* capabilityDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CAPABILITY_ALLOW0 *")]
            public FWPM_NET_EVENT_CAPABILITY_ALLOW0_* capabilityAllow;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP_MAC0 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_* classifyDropMac;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT4_
    {
        [NativeTypeName("FWPM_NET_EVENT_HEADER3")]
        public FWPM_NET_EVENT_HEADER3_ header;

        [NativeTypeName("FWPM_NET_EVENT_TYPE")]
        public FWPM_NET_EVENT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1149_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_MM_FAILURE2_* ikeMmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_QM_FAILURE1_* ikeQmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeEmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP2_* classifyDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ipsecDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_ALLOW0* classifyAllow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyAllow;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CAPABILITY_DROP0_* capabilityDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.capabilityDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CAPABILITY_ALLOW0_* capabilityAllow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.capabilityAllow;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_* classifyDropMac
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDropMac;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_MM_FAILURE2 *")]
            public FWPM_NET_EVENT_IKEEXT_MM_FAILURE2_* ikeMmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_QM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_QM_FAILURE1_* ikeQmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_EM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP2 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP2_* classifyDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_KERNEL_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_DOSP_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop;

            [FieldOffset(0)]
            public FWPM_NET_EVENT_CLASSIFY_ALLOW0* classifyAllow;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CAPABILITY_DROP0 *")]
            public FWPM_NET_EVENT_CAPABILITY_DROP0_* capabilityDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CAPABILITY_ALLOW0 *")]
            public FWPM_NET_EVENT_CAPABILITY_ALLOW0_* capabilityAllow;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP_MAC0 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_* classifyDropMac;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT5_
    {
        [NativeTypeName("FWPM_NET_EVENT_HEADER3")]
        public FWPM_NET_EVENT_HEADER3_ header;

        [NativeTypeName("FWPM_NET_EVENT_TYPE")]
        public FWPM_NET_EVENT_TYPE_ type;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1170_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_MM_FAILURE2_* ikeMmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeMmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_QM_FAILURE1_* ikeQmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeQmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ikeEmFailure;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP2_* classifyDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ipsecDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.idpDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_ALLOW0* classifyAllow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyAllow;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CAPABILITY_DROP0_* capabilityDrop
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.capabilityDrop;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CAPABILITY_ALLOW0_* capabilityAllow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.capabilityAllow;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_* classifyDropMac
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.classifyDropMac;
            }
        }

        [UnscopedRef]
        public ref FWPM_NET_EVENT_LPM_PACKET_ARRIVAL0_* lpmPacketArrival
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.lpmPacketArrival;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_MM_FAILURE2 *")]
            public FWPM_NET_EVENT_IKEEXT_MM_FAILURE2_* ikeMmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_QM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_QM_FAILURE1_* ikeQmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IKEEXT_EM_FAILURE1 *")]
            public FWPM_NET_EVENT_IKEEXT_EM_FAILURE1_* ikeEmFailure;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP2 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP2_* classifyDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_KERNEL_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_KERNEL_DROP0_* ipsecDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_IPSEC_DOSP_DROP0 *")]
            public FWPM_NET_EVENT_IPSEC_DOSP_DROP0_* idpDrop;

            [FieldOffset(0)]
            public FWPM_NET_EVENT_CLASSIFY_ALLOW0* classifyAllow;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CAPABILITY_DROP0 *")]
            public FWPM_NET_EVENT_CAPABILITY_DROP0_* capabilityDrop;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CAPABILITY_ALLOW0 *")]
            public FWPM_NET_EVENT_CAPABILITY_ALLOW0_* capabilityAllow;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_CLASSIFY_DROP_MAC0 *")]
            public FWPM_NET_EVENT_CLASSIFY_DROP_MAC0_* classifyDropMac;

            [FieldOffset(0)]
            [NativeTypeName("FWPM_NET_EVENT_LPM_PACKET_ARRIVAL0 *")]
            public FWPM_NET_EVENT_LPM_PACKET_ARRIVAL0_* lpmPacketArrival;
        }
    }

    public unsafe partial struct FWPM_NET_EVENT_ENUM_TEMPLATE0_
    {
        public FILETIME startTime;

        public FILETIME endTime;

        [NativeTypeName("UINT32")]
        public uint numFilterConditions;

        [NativeTypeName("FWPM_FILTER_CONDITION0 *")]
        public FWPM_FILTER_CONDITION0_* filterCondition;
    }

    public unsafe partial struct FWPM_NET_EVENT_SUBSCRIPTION0_
    {
        [NativeTypeName("FWPM_NET_EVENT_ENUM_TEMPLATE0 *")]
        public FWPM_NET_EVENT_ENUM_TEMPLATE0_* enumTemplate;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public enum FWPM_SYSTEM_PORT_TYPE_
    {
        FWPM_SYSTEM_PORT_RPC_EPMAP = 0,
        FWPM_SYSTEM_PORT_TEREDO = (FWPM_SYSTEM_PORT_RPC_EPMAP + 1),
        FWPM_SYSTEM_PORT_IPHTTPS_IN = (FWPM_SYSTEM_PORT_TEREDO + 1),
        FWPM_SYSTEM_PORT_IPHTTPS_OUT = (FWPM_SYSTEM_PORT_IPHTTPS_IN + 1),
        FWPM_SYSTEM_PORT_TYPE_MAX = (FWPM_SYSTEM_PORT_IPHTTPS_OUT + 1),
    }

    public unsafe partial struct FWPM_SYSTEM_PORTS_BY_TYPE0_
    {
        [NativeTypeName("FWPM_SYSTEM_PORT_TYPE")]
        public FWPM_SYSTEM_PORT_TYPE_ type;

        [NativeTypeName("UINT32")]
        public uint numPorts;

        [NativeTypeName("UINT16 *")]
        public ushort* ports;
    }

    public unsafe partial struct FWPM_SYSTEM_PORTS0_
    {
        [NativeTypeName("UINT32")]
        public uint numTypes;

        [NativeTypeName("FWPM_SYSTEM_PORTS_BY_TYPE0 *")]
        public FWPM_SYSTEM_PORTS_BY_TYPE0_* types;
    }

    public unsafe partial struct FWPM_CONNECTION0_
    {
        [NativeTypeName("UINT64")]
        public ulong connectionId;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1232_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1237_C36")]
        public _Anonymous2_e__Union Anonymous2;

        public Guid* providerKey;

        [NativeTypeName("IPSEC_TRAFFIC_TYPE")]
        public IPSEC_TRAFFIC_TYPE_ ipsecTrafficModeType;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyModuleType;

        [NativeTypeName("IKEEXT_PROPOSAL0")]
        public IKEEXT_PROPOSAL0_ mmCrypto;

        [NativeTypeName("IKEEXT_CREDENTIAL2")]
        public IKEEXT_CREDENTIAL2_ mmPeer;

        [NativeTypeName("IKEEXT_CREDENTIAL2")]
        public IKEEXT_CREDENTIAL2_ emPeer;

        [NativeTypeName("UINT64")]
        public ulong bytesTransferredIn;

        [NativeTypeName("UINT64")]
        public ulong bytesTransferredOut;

        [NativeTypeName("UINT64")]
        public ulong bytesTransferredTotal;

        public FILETIME startSysTime;

        [UnscopedRef]
        public ref uint localV4Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.localV4Address;
            }
        }

        [UnscopedRef]
        public Span<byte> localV6Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous1.localV6Address;
            }
        }

        [UnscopedRef]
        public ref uint remoteV4Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.remoteV4Address;
            }
        }

        [UnscopedRef]
        public Span<byte> remoteV6Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.remoteV6Address;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint localV4Address;

            [FieldOffset(0)]
            [NativeTypeName("UINT8[16]")]
            public _localV6Address_e__FixedBuffer localV6Address;

            [InlineArray(16)]
            public partial struct _localV6Address_e__FixedBuffer
            {
                public byte e0;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint remoteV4Address;

            [FieldOffset(0)]
            [NativeTypeName("UINT8[16]")]
            public _remoteV6Address_e__FixedBuffer remoteV6Address;

            [InlineArray(16)]
            public partial struct _remoteV6Address_e__FixedBuffer
            {
                public byte e0;
            }
        }
    }

    public partial struct FWPM_CONNECTION_ENUM_TEMPLATE0_
    {
        [NativeTypeName("UINT64")]
        public ulong connectionId;

        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public unsafe partial struct FWPM_CONNECTION_SUBSCRIPTION0_
    {
        [NativeTypeName("FWPM_CONNECTION_ENUM_TEMPLATE0 *")]
        public FWPM_CONNECTION_ENUM_TEMPLATE0_* enumTemplate;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public enum FWPM_CONNECTION_EVENT_TYPE_
    {
        FWPM_CONNECTION_EVENT_ADD = 0,
        FWPM_CONNECTION_EVENT_DELETE = (FWPM_CONNECTION_EVENT_ADD + 1),
        FWPM_CONNECTION_EVENT_MAX = (FWPM_CONNECTION_EVENT_DELETE + 1),
    }

    public enum FWPM_VSWITCH_EVENT_TYPE_
    {
        FWPM_VSWITCH_EVENT_FILTER_ADD_TO_INCOMPLETE_LAYER = 0,
        FWPM_VSWITCH_EVENT_FILTER_ENGINE_NOT_IN_REQUIRED_POSITION = (FWPM_VSWITCH_EVENT_FILTER_ADD_TO_INCOMPLETE_LAYER + 1),
        FWPM_VSWITCH_EVENT_ENABLED_FOR_INSPECTION = (FWPM_VSWITCH_EVENT_FILTER_ENGINE_NOT_IN_REQUIRED_POSITION + 1),
        FWPM_VSWITCH_EVENT_DISABLED_FOR_INSPECTION = (FWPM_VSWITCH_EVENT_ENABLED_FOR_INSPECTION + 1),
        FWPM_VSWITCH_EVENT_FILTER_ENGINE_REORDER = (FWPM_VSWITCH_EVENT_DISABLED_FOR_INSPECTION + 1),
        FWPM_VSWITCH_EVENT_MAX = (FWPM_VSWITCH_EVENT_FILTER_ENGINE_REORDER + 1),
    }

    public unsafe partial struct FWPM_VSWITCH_EVENT0_
    {
        [NativeTypeName("FWPM_VSWITCH_EVENT_TYPE")]
        public FWPM_VSWITCH_EVENT_TYPE_ eventType;

        [NativeTypeName("wchar_t *")]
        public char* vSwitchId;

        [NativeTypeName("__AnonymousRecord_fwpmtypes_L1291_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref _Anonymous_e__Union._positionInfo_e__Struct positionInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.positionInfo;
            }
        }

        [UnscopedRef]
        public ref _Anonymous_e__Union._reorderInfo_e__Struct reorderInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.reorderInfo;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_fwpmtypes_L1294_C24")]
            public _positionInfo_e__Struct positionInfo;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_fwpmtypes_L1299_C24")]
            public _reorderInfo_e__Struct reorderInfo;

            public unsafe partial struct _positionInfo_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint numvSwitchFilterExtensions;

                [NativeTypeName("LPWSTR *")]
                public char** vSwitchFilterExtensions;
            }

            public unsafe partial struct _reorderInfo_e__Struct
            {
                [NativeTypeName("BOOL")]
                public int inRequiredPosition;

                [NativeTypeName("ULONG")]
                public uint numvSwitchFilterExtensions;

                [NativeTypeName("LPWSTR *")]
                public char** vSwitchFilterExtensions;
            }
        }
    }

    public partial struct FWPM_VSWITCH_EVENT_SUBSCRIPTION0_
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public unsafe partial struct _IPSEC_KEY_MANAGER_CALLBACKS0
    {
        public Guid reserved;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("IPSEC_KEY_MANAGER_KEY_DICTATION_CHECK0")]
        public delegate* unmanaged[Stdcall]<IKEEXT_TRAFFIC0_*, int*, uint*, void> keyDictationCheck;

        [NativeTypeName("IPSEC_KEY_MANAGER_DICTATE_KEY0")]
        public delegate* unmanaged[Stdcall]<IPSEC_SA_DETAILS1_*, IPSEC_SA_DETAILS1_*, int*, uint> keyDictation;

        [NativeTypeName("IPSEC_KEY_MANAGER_NOTIFY_KEY0")]
        public delegate* unmanaged[Stdcall]<IPSEC_SA_DETAILS1_*, IPSEC_SA_DETAILS1_*, void> keyNotify;
    }

    public static unsafe partial class Methods
    {
        [NativeTypeName("const IPSEC_AUTH_TRANSFORM_ID0")]
        public static ref readonly IPSEC_AUTH_TRANSFORM_ID0_ IPSEC_AUTH_TRANSFORM_ID_HMAC_MD5_96
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x00, 0x00, 0x00, 0x00,
                    0x00
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_AUTH_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_AUTH_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_AUTH_TRANSFORM_ID0")]
        public static ref readonly IPSEC_AUTH_TRANSFORM_ID0_ IPSEC_AUTH_TRANSFORM_ID_HMAC_SHA_1_96
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x01, 0x00, 0x00, 0x00,
                    0x01
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_AUTH_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_AUTH_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_AUTH_TRANSFORM_ID0")]
        public static ref readonly IPSEC_AUTH_TRANSFORM_ID0_ IPSEC_AUTH_TRANSFORM_ID_HMAC_SHA_256_128
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x02, 0x00, 0x00, 0x00,
                    0x02
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_AUTH_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_AUTH_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_AUTH_TRANSFORM_ID0")]
        public static ref readonly IPSEC_AUTH_TRANSFORM_ID0_ IPSEC_AUTH_TRANSFORM_ID_GCM_AES_128
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x03, 0x00, 0x00, 0x00,
                    0x03
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_AUTH_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_AUTH_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_AUTH_TRANSFORM_ID0")]
        public static ref readonly IPSEC_AUTH_TRANSFORM_ID0_ IPSEC_AUTH_TRANSFORM_ID_GCM_AES_192
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x04, 0x00, 0x00, 0x00,
                    0x04
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_AUTH_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_AUTH_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_AUTH_TRANSFORM_ID0")]
        public static ref readonly IPSEC_AUTH_TRANSFORM_ID0_ IPSEC_AUTH_TRANSFORM_ID_GCM_AES_256
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x05, 0x00, 0x00, 0x00,
                    0x05
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_AUTH_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_AUTH_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_CIPHER_TRANSFORM_ID0")]
        public static ref readonly IPSEC_CIPHER_TRANSFORM_ID0_ IPSEC_CIPHER_TRANSFORM_ID_CBC_DES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x01, 0x00, 0x00, 0x00,
                    0x01
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_CIPHER_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_CIPHER_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_CIPHER_TRANSFORM_ID0")]
        public static ref readonly IPSEC_CIPHER_TRANSFORM_ID0_ IPSEC_CIPHER_TRANSFORM_ID_CBC_3DES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x02, 0x00, 0x00, 0x00,
                    0x02
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_CIPHER_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_CIPHER_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_CIPHER_TRANSFORM_ID0")]
        public static ref readonly IPSEC_CIPHER_TRANSFORM_ID0_ IPSEC_CIPHER_TRANSFORM_ID_AES_128
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x03, 0x00, 0x00, 0x00,
                    0x03
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_CIPHER_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_CIPHER_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_CIPHER_TRANSFORM_ID0")]
        public static ref readonly IPSEC_CIPHER_TRANSFORM_ID0_ IPSEC_CIPHER_TRANSFORM_ID_AES_192
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x04, 0x00, 0x00, 0x00,
                    0x04
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_CIPHER_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_CIPHER_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_CIPHER_TRANSFORM_ID0")]
        public static ref readonly IPSEC_CIPHER_TRANSFORM_ID0_ IPSEC_CIPHER_TRANSFORM_ID_AES_256
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x05, 0x00, 0x00, 0x00,
                    0x05
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_CIPHER_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_CIPHER_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_CIPHER_TRANSFORM_ID0")]
        public static ref readonly IPSEC_CIPHER_TRANSFORM_ID0_ IPSEC_CIPHER_TRANSFORM_ID_GCM_AES_128
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x03, 0x00, 0x00, 0x00,
                    0x06
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_CIPHER_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_CIPHER_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_CIPHER_TRANSFORM_ID0")]
        public static ref readonly IPSEC_CIPHER_TRANSFORM_ID0_ IPSEC_CIPHER_TRANSFORM_ID_GCM_AES_192
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x04, 0x00, 0x00, 0x00,
                    0x07
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_CIPHER_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_CIPHER_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IPSEC_CIPHER_TRANSFORM_ID0")]
        public static ref readonly IPSEC_CIPHER_TRANSFORM_ID0_ IPSEC_CIPHER_TRANSFORM_ID_GCM_AES_256
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = [
                    0x05, 0x00, 0x00, 0x00,
                    0x08
                ];

                Debug.Assert(data.Length == Unsafe.SizeOf<IPSEC_CIPHER_TRANSFORM_ID0_>());
                return ref Unsafe.As<byte, IPSEC_CIPHER_TRANSFORM_ID0_>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void FwpmFreeMemory0(void** p);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmEngineOpen0([NativeTypeName("const wchar_t *")] char* serverName, [NativeTypeName("UINT32")] uint authnService, SEC_WINNT_AUTH_IDENTITY_W* authIdentity, [NativeTypeName("const FWPM_SESSION0 *")] FWPM_SESSION0_* session, [NativeTypeName("HANDLE *")] void** engineHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmEngineClose0([NativeTypeName("HANDLE")] void* engineHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmEngineGetOption0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_ENGINE_OPTION")] FWPM_ENGINE_OPTION_ option, [NativeTypeName("FWP_VALUE0 **")] FWP_VALUE0_** value);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmEngineSetOption0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_ENGINE_OPTION")] FWPM_ENGINE_OPTION_ option, [NativeTypeName("const FWP_VALUE0 *")] FWP_VALUE0_* newValue);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmEngineGetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmEngineSetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSessionCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_SESSION_ENUM_TEMPLATE0 *")] FWPM_SESSION_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSessionEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_SESSION0 ***")] FWPM_SESSION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSessionDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmTransactionBegin0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT32")] uint flags);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmTransactionCommit0([NativeTypeName("HANDLE")] void* engineHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmTransactionAbort0([NativeTypeName("HANDLE")] void* engineHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderAdd0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER0 *")] FWPM_PROVIDER0* provider, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderDeleteByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderGetByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, FWPM_PROVIDER0** provider);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_ENUM_TEMPLATE0 *")] FWPM_PROVIDER_ENUM_TEMPLATE0* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, FWPM_PROVIDER0*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderGetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderSetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderSubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_SUBSCRIPTION0 *")] FWPM_PROVIDER_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_PROVIDER_CHANGE_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_PROVIDER_CHANGE0_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderUnsubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderSubscriptionsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_PROVIDER_SUBSCRIPTION0 ***")] FWPM_PROVIDER_SUBSCRIPTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextAdd0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_CONTEXT0 *")] FWPM_PROVIDER_CONTEXT0_* providerContext, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd, [NativeTypeName("UINT64 *")] ulong* id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextAdd1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_CONTEXT1 *")] FWPM_PROVIDER_CONTEXT1_* providerContext, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd, [NativeTypeName("UINT64 *")] ulong* id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextAdd2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_CONTEXT2 *")] FWPM_PROVIDER_CONTEXT2_* providerContext, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd, [NativeTypeName("UINT64 *")] ulong* id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextAdd3([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_CONTEXT3 *")] FWPM_PROVIDER_CONTEXT3_* providerContext, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd, [NativeTypeName("UINT64 *")] ulong* id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextDeleteById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextDeleteByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("FWPM_PROVIDER_CONTEXT0 **")] FWPM_PROVIDER_CONTEXT0_** providerContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetById1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("FWPM_PROVIDER_CONTEXT1 **")] FWPM_PROVIDER_CONTEXT1_** providerContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetById2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("FWPM_PROVIDER_CONTEXT2 **")] FWPM_PROVIDER_CONTEXT2_** providerContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetById3([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("FWPM_PROVIDER_CONTEXT3 **")] FWPM_PROVIDER_CONTEXT3_** providerContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("FWPM_PROVIDER_CONTEXT0 **")] FWPM_PROVIDER_CONTEXT0_** providerContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetByKey1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("FWPM_PROVIDER_CONTEXT1 **")] FWPM_PROVIDER_CONTEXT1_** providerContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetByKey2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("FWPM_PROVIDER_CONTEXT2 **")] FWPM_PROVIDER_CONTEXT2_** providerContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetByKey3([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("FWPM_PROVIDER_CONTEXT3 **")] FWPM_PROVIDER_CONTEXT3_** providerContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_CONTEXT_ENUM_TEMPLATE0 *")] FWPM_PROVIDER_CONTEXT_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_PROVIDER_CONTEXT0 ***")] FWPM_PROVIDER_CONTEXT0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextEnum1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_PROVIDER_CONTEXT1 ***")] FWPM_PROVIDER_CONTEXT1_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextEnum2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_PROVIDER_CONTEXT2 ***")] FWPM_PROVIDER_CONTEXT2_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextEnum3([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_PROVIDER_CONTEXT3 ***")] FWPM_PROVIDER_CONTEXT3_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextGetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextSetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextSubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_CONTEXT_SUBSCRIPTION0 *")] FWPM_PROVIDER_CONTEXT_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_PROVIDER_CONTEXT_CHANGE_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_PROVIDER_CONTEXT_CHANGE0_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextUnsubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmProviderContextSubscriptionsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_PROVIDER_CONTEXT_SUBSCRIPTION0 ***")] FWPM_PROVIDER_CONTEXT_SUBSCRIPTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerAdd0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_SUBLAYER0 *")] FWPM_SUBLAYER0_* subLayer, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerDeleteByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerGetByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("FWPM_SUBLAYER0 **")] FWPM_SUBLAYER0_** subLayer);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_SUBLAYER_ENUM_TEMPLATE0 *")] FWPM_SUBLAYER_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_SUBLAYER0 ***")] FWPM_SUBLAYER0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerGetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerSetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerSubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_SUBLAYER_SUBSCRIPTION0 *")] FWPM_SUBLAYER_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_SUBLAYER_CHANGE_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_SUBLAYER_CHANGE0_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerUnsubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSubLayerSubscriptionsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_SUBLAYER_SUBSCRIPTION0 ***")] FWPM_SUBLAYER_SUBSCRIPTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmLayerGetById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT16")] ushort id, [NativeTypeName("FWPM_LAYER0 **")] FWPM_LAYER0_** layer);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmLayerGetByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("FWPM_LAYER0 **")] FWPM_LAYER0_** layer);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmLayerCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_LAYER_ENUM_TEMPLATE0 *")] FWPM_LAYER_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmLayerEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_LAYER0 ***")] FWPM_LAYER0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmLayerDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmLayerGetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmLayerSetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutAdd0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_CALLOUT0 *")] FWPM_CALLOUT0_* callout, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd, [NativeTypeName("UINT32 *")] uint* id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutDeleteById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT32")] uint id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutDeleteByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutGetById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT32")] uint id, [NativeTypeName("FWPM_CALLOUT0 **")] FWPM_CALLOUT0_** callout);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutGetByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("FWPM_CALLOUT0 **")] FWPM_CALLOUT0_** callout);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_CALLOUT_ENUM_TEMPLATE0 *")] FWPM_CALLOUT_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_CALLOUT0 ***")] FWPM_CALLOUT0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutGetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutSetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutSubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_CALLOUT_SUBSCRIPTION0 *")] FWPM_CALLOUT_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_CALLOUT_CHANGE_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_CALLOUT_CHANGE0_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutUnsubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmCalloutSubscriptionsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_CALLOUT_SUBSCRIPTION0 ***")] FWPM_CALLOUT_SUBSCRIPTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterAdd0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_FILTER0 *")] FWPM_FILTER0_* filter, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd, [NativeTypeName("UINT64 *")] ulong* id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterDeleteById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterDeleteByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterGetById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("FWPM_FILTER0 **")] FWPM_FILTER0_** filter);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterGetByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("FWPM_FILTER0 **")] FWPM_FILTER0_** filter);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_FILTER_ENUM_TEMPLATE0 *")] FWPM_FILTER_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_FILTER0 ***")] FWPM_FILTER0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterGetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterSetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterSubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_FILTER_SUBSCRIPTION0 *")] FWPM_FILTER_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_FILTER_CHANGE_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_FILTER_CHANGE0_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterUnsubscribeChanges0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* changeHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmFilterSubscriptionsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_FILTER_SUBSCRIPTION0 ***")] FWPM_FILTER_SUBSCRIPTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmGetAppIdFromFileName0([NativeTypeName("PCWSTR")] char* fileName, FWP_BYTE_BLOB** appId);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmIPsecTunnelAdd0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT32")] uint flags, [NativeTypeName("const FWPM_PROVIDER_CONTEXT0 *")] FWPM_PROVIDER_CONTEXT0_* mainModePolicy, [NativeTypeName("const FWPM_PROVIDER_CONTEXT0 *")] FWPM_PROVIDER_CONTEXT0_* tunnelPolicy, [NativeTypeName("UINT32")] uint numFilterConditions, [NativeTypeName("const FWPM_FILTER_CONDITION0 *")] FWPM_FILTER_CONDITION0_* filterConditions, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmIPsecTunnelAdd1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT32")] uint flags, [NativeTypeName("const FWPM_PROVIDER_CONTEXT1 *")] FWPM_PROVIDER_CONTEXT1_* mainModePolicy, [NativeTypeName("const FWPM_PROVIDER_CONTEXT1 *")] FWPM_PROVIDER_CONTEXT1_* tunnelPolicy, [NativeTypeName("UINT32")] uint numFilterConditions, [NativeTypeName("const FWPM_FILTER_CONDITION0 *")] FWPM_FILTER_CONDITION0_* filterConditions, [NativeTypeName("const GUID *")] Guid* keyModKey, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmIPsecTunnelAdd2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT32")] uint flags, [NativeTypeName("const FWPM_PROVIDER_CONTEXT2 *")] FWPM_PROVIDER_CONTEXT2_* mainModePolicy, [NativeTypeName("const FWPM_PROVIDER_CONTEXT2 *")] FWPM_PROVIDER_CONTEXT2_* tunnelPolicy, [NativeTypeName("UINT32")] uint numFilterConditions, [NativeTypeName("const FWPM_FILTER_CONDITION0 *")] FWPM_FILTER_CONDITION0_* filterConditions, [NativeTypeName("const GUID *")] Guid* keyModKey, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmIPsecTunnelAdd3([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT32")] uint flags, [NativeTypeName("const FWPM_PROVIDER_CONTEXT3 *")] FWPM_PROVIDER_CONTEXT3_* mainModePolicy, [NativeTypeName("const FWPM_PROVIDER_CONTEXT3 *")] FWPM_PROVIDER_CONTEXT3_* tunnelPolicy, [NativeTypeName("UINT32")] uint numFilterConditions, [NativeTypeName("const FWPM_FILTER_CONDITION0 *")] FWPM_FILTER_CONDITION0_* filterConditions, [NativeTypeName("const GUID *")] Guid* keyModKey, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmIPsecTunnelDeleteByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecGetStatistics0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("IPSEC_STATISTICS0 *")] IPSEC_STATISTICS0_* ipsecStatistics);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecGetStatistics1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("IPSEC_STATISTICS1 *")] IPSEC_STATISTICS1_* ipsecStatistics);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextCreate0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const IPSEC_TRAFFIC0 *")] IPSEC_TRAFFIC0_* outboundTraffic, [NativeTypeName("UINT64 *")] ulong* inboundFilterId, [NativeTypeName("UINT64 *")] ulong* id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextCreate1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const IPSEC_TRAFFIC1 *")] IPSEC_TRAFFIC1_* outboundTraffic, [NativeTypeName("const IPSEC_VIRTUAL_IF_TUNNEL_INFO0 *")] IPSEC_VIRTUAL_IF_TUNNEL_INFO0_* virtualIfTunnelInfo, [NativeTypeName("UINT64 *")] ulong* inboundFilterId, [NativeTypeName("UINT64 *")] ulong* id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextDeleteById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextGetById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("IPSEC_SA_CONTEXT0 **")] IPSEC_SA_CONTEXT0_** saContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextGetById1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("IPSEC_SA_CONTEXT1 **")] IPSEC_SA_CONTEXT1_** saContext);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextGetSpi0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("const IPSEC_GETSPI0 *")] IPSEC_GETSPI0_* getSpi, [NativeTypeName("IPSEC_SA_SPI *")] uint* inboundSpi);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextGetSpi1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("const IPSEC_GETSPI1 *")] IPSEC_GETSPI1_* getSpi, [NativeTypeName("IPSEC_SA_SPI *")] uint* inboundSpi);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextSetSpi0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("const IPSEC_GETSPI1 *")] IPSEC_GETSPI1_* getSpi, [NativeTypeName("IPSEC_SA_SPI")] uint inboundSpi);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextAddInbound0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("const IPSEC_SA_BUNDLE0 *")] IPSEC_SA_BUNDLE0_* inboundBundle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextAddOutbound0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("const IPSEC_SA_BUNDLE0 *")] IPSEC_SA_BUNDLE0_* outboundBundle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextAddInbound1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("const IPSEC_SA_BUNDLE1 *")] IPSEC_SA_BUNDLE1_* inboundBundle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextAddOutbound1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("const IPSEC_SA_BUNDLE1 *")] IPSEC_SA_BUNDLE1_* outboundBundle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextExpire0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextUpdate0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong flags, [NativeTypeName("const IPSEC_SA_CONTEXT1 *")] IPSEC_SA_CONTEXT1_* newValues);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const IPSEC_SA_CONTEXT_ENUM_TEMPLATE0 *")] IPSEC_SA_CONTEXT_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("IPSEC_SA_CONTEXT0 ***")] IPSEC_SA_CONTEXT0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextEnum1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("IPSEC_SA_CONTEXT1 ***")] IPSEC_SA_CONTEXT1_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextSubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const IPSEC_SA_CONTEXT_SUBSCRIPTION0 *")] IPSEC_SA_CONTEXT_SUBSCRIPTION0_* subscription, [NativeTypeName("IPSEC_SA_CONTEXT_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, IPSEC_SA_CONTEXT_CHANGE0_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextUnsubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaContextSubscriptionsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("IPSEC_SA_CONTEXT_SUBSCRIPTION0 ***")] IPSEC_SA_CONTEXT_SUBSCRIPTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const IPSEC_SA_ENUM_TEMPLATE0 *")] IPSEC_SA_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("IPSEC_SA_DETAILS0 ***")] IPSEC_SA_DETAILS0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaEnum1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("IPSEC_SA_DETAILS1 ***")] IPSEC_SA_DETAILS1_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaDbGetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecSaDbSetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecDospGetStatistics0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("IPSEC_DOSP_STATISTICS0 *")] IPSEC_DOSP_STATISTICS0_* idpStatistics);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecDospStateCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const IPSEC_DOSP_STATE_ENUM_TEMPLATE0 *")] IPSEC_DOSP_STATE_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecDospStateEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("IPSEC_DOSP_STATE0 ***")] IPSEC_DOSP_STATE0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecDospStateDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecDospGetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecDospSetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecKeyManagerAddAndRegister0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const IPSEC_KEY_MANAGER0 *")] _IPSEC_KEY_MANAGER0* keyManager, [NativeTypeName("const IPSEC_KEY_MANAGER_CALLBACKS0 *")] _IPSEC_KEY_MANAGER_CALLBACKS0* keyManagerCallbacks, [NativeTypeName("HANDLE *")] void** keyMgmtHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecKeyManagerUnregisterAndDelete0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* keyMgmtHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecKeyManagersGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("IPSEC_KEY_MANAGER0 ***")] _IPSEC_KEY_MANAGER0*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecKeyManagerGetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const void *")] void* reserved, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IPsecKeyManagerSetSecurityInfoByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const void *")] void* reserved, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextGetStatistics0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("IKEEXT_STATISTICS0 *")] IKEEXT_STATISTICS0_* ikeextStatistics);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextGetStatistics1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("IKEEXT_STATISTICS1 *")] IKEEXT_STATISTICS1_* ikeextStatistics);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaDeleteById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaGetById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("IKEEXT_SA_DETAILS0 **")] IKEEXT_SA_DETAILS0_** sa);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaGetById1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, Guid* saLookupContext, [NativeTypeName("IKEEXT_SA_DETAILS1 **")] IKEEXT_SA_DETAILS1_** sa);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaGetById2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, Guid* saLookupContext, [NativeTypeName("IKEEXT_SA_DETAILS2 **")] IKEEXT_SA_DETAILS2_** sa);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const IKEEXT_SA_ENUM_TEMPLATE0 *")] IKEEXT_SA_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("IKEEXT_SA_DETAILS0 ***")] IKEEXT_SA_DETAILS0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaEnum1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("IKEEXT_SA_DETAILS1 ***")] IKEEXT_SA_DETAILS1_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaEnum2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("IKEEXT_SA_DETAILS2 ***")] IKEEXT_SA_DETAILS2_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaDbGetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint IkeextSaDbSetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_NET_EVENT_ENUM_TEMPLATE0 *")] FWPM_NET_EVENT_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_NET_EVENT0 ***")] FWPM_NET_EVENT0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventEnum1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_NET_EVENT1 ***")] FWPM_NET_EVENT1_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventEnum2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_NET_EVENT2 ***")] FWPM_NET_EVENT2_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventEnum3([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_NET_EVENT3 ***")] FWPM_NET_EVENT3_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventEnum4([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_NET_EVENT4 ***")] FWPM_NET_EVENT4_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventEnum5([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_NET_EVENT5 ***")] FWPM_NET_EVENT5_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventsGetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventsSetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventSubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_NET_EVENT_SUBSCRIPTION0 *")] FWPM_NET_EVENT_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_NET_EVENT_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_NET_EVENT1_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventUnsubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventSubscriptionsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_NET_EVENT_SUBSCRIPTION0 ***")] FWPM_NET_EVENT_SUBSCRIPTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventSubscribe1([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_NET_EVENT_SUBSCRIPTION0 *")] FWPM_NET_EVENT_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_NET_EVENT_CALLBACK1")] delegate* unmanaged[Stdcall]<void*, FWPM_NET_EVENT2_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventSubscribe2([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_NET_EVENT_SUBSCRIPTION0 *")] FWPM_NET_EVENT_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_NET_EVENT_CALLBACK2")] delegate* unmanaged[Stdcall]<void*, FWPM_NET_EVENT3_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventSubscribe3([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_NET_EVENT_SUBSCRIPTION0 *")] FWPM_NET_EVENT_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_NET_EVENT_CALLBACK3")] delegate* unmanaged[Stdcall]<void*, FWPM_NET_EVENT4_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmNetEventSubscribe4([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_NET_EVENT_SUBSCRIPTION0 *")] FWPM_NET_EVENT_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_NET_EVENT_CALLBACK4")] delegate* unmanaged[Stdcall]<void*, FWPM_NET_EVENT5_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmDynamicKeywordSubscribe0([NativeTypeName("DWORD")] uint flags, [NativeTypeName("FWPM_DYNAMIC_KEYWORD_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, void*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** subscriptionHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmDynamicKeywordUnsubscribe0([NativeTypeName("HANDLE")] void* subscriptionHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSystemPortsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_SYSTEM_PORTS0 **")] FWPM_SYSTEM_PORTS0_** sysPorts);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSystemPortsSubscribe0([NativeTypeName("HANDLE")] void* engineHandle, void* reserved, [NativeTypeName("FWPM_SYSTEM_PORTS_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_SYSTEM_PORTS0_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** sysPortsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmSystemPortsUnsubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* sysPortsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionGetById0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("UINT64")] ulong id, [NativeTypeName("FWPM_CONNECTION0 **")] FWPM_CONNECTION0_** connection);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionEnum0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle, [NativeTypeName("UINT32")] uint numEntriesRequested, [NativeTypeName("FWPM_CONNECTION0 ***")] FWPM_CONNECTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntriesReturned);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionCreateEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_CONNECTION_ENUM_TEMPLATE0 *")] FWPM_CONNECTION_ENUM_TEMPLATE0_* enumTemplate, [NativeTypeName("HANDLE *")] void** enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionDestroyEnumHandle0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* enumHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionGetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionSetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionSubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_CONNECTION_SUBSCRIPTION0 *")] FWPM_CONNECTION_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_CONNECTION_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_CONNECTION_EVENT_TYPE_, FWPM_CONNECTION0_*, void> callback, void* context, [NativeTypeName("HANDLE *")] void** eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionUnsubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* eventsHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionSubscriptionsGet0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("FWPM_CONNECTION_SUBSCRIPTION0 ***")] FWPM_CONNECTION_SUBSCRIPTION0_*** entries, [NativeTypeName("UINT32 *")] uint* numEntries);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmvSwitchEventSubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_VSWITCH_EVENT_SUBSCRIPTION0 *")] FWPM_VSWITCH_EVENT_SUBSCRIPTION0_* subscription, [NativeTypeName("FWPM_VSWITCH_EVENT_CALLBACK0")] delegate* unmanaged[Stdcall]<void*, FWPM_VSWITCH_EVENT0_*, uint> callback, void* context, [NativeTypeName("HANDLE *")] void** subscriptionHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmvSwitchEventUnsubscribe0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("HANDLE")] void* subscriptionHandle);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmvSwitchEventsGetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("PSID *")] void** sidOwner, [NativeTypeName("PSID *")] void** sidGroup, [NativeTypeName("PACL *")] ACL** dacl, [NativeTypeName("PACL *")] ACL** sacl, [NativeTypeName("PSECURITY_DESCRIPTOR *")] void** securityDescriptor);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmvSwitchEventsSetSecurityInfo0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("SECURITY_INFORMATION")] uint securityInfo, [NativeTypeName("const SID *")] SID* sidOwner, [NativeTypeName("const SID *")] SID* sidGroup, [NativeTypeName("const ACL *")] ACL* dacl, [NativeTypeName("const ACL *")] ACL* sacl);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionPolicyAdd0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const FWPM_PROVIDER_CONTEXT3 *")] FWPM_PROVIDER_CONTEXT3_* connectionPolicy, [NativeTypeName("FWP_IP_VERSION")] FWP_IP_VERSION_ ipVersion, [NativeTypeName("UINT64")] ulong weight, [NativeTypeName("UINT32")] uint numFilterConditions, [NativeTypeName("const FWPM_FILTER_CONDITION0 *")] FWPM_FILTER_CONDITION0_* filterConditions, [NativeTypeName("PSECURITY_DESCRIPTOR")] void* sd);

        [DllImport("fwpuclnt", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint FwpmConnectionPolicyDeleteByKey0([NativeTypeName("HANDLE")] void* engineHandle, [NativeTypeName("const GUID *")] Guid* key);

        [NativeTypeName("#define FWP_BYTEMAP_ARRAY64_SIZE 8")]
        public const int FWP_BYTEMAP_ARRAY64_SIZE = 8;

        [NativeTypeName("#define FWP_BYTE_ARRAY6_SIZE 6")]
        public const int FWP_BYTE_ARRAY6_SIZE = 6;

        [NativeTypeName("#define FWP_V6_ADDR_SIZE (16)")]
        public const int FWP_V6_ADDR_SIZE = (16);

        [NativeTypeName("#define FWP_ACTRL_MATCH_FILTER (0x00000001)")]
        public const int FWP_ACTRL_MATCH_FILTER = (0x00000001);

        [NativeTypeName("#define FWP_OPTION_VALUE_ALLOW_MULTICAST_STATE (0x00000000)")]
        public const int FWP_OPTION_VALUE_ALLOW_MULTICAST_STATE = (0x00000000);

        [NativeTypeName("#define FWP_OPTION_VALUE_DENY_MULTICAST_STATE (0x00000001)")]
        public const int FWP_OPTION_VALUE_DENY_MULTICAST_STATE = (0x00000001);

        [NativeTypeName("#define FWP_OPTION_VALUE_ALLOW_GLOBAL_MULTICAST_STATE (0x00000002)")]
        public const int FWP_OPTION_VALUE_ALLOW_GLOBAL_MULTICAST_STATE = (0x00000002);

        [NativeTypeName("#define FWP_OPTION_VALUE_DISABLE_LOOSE_SOURCE (0x00000000)")]
        public const int FWP_OPTION_VALUE_DISABLE_LOOSE_SOURCE = (0x00000000);

        [NativeTypeName("#define FWP_OPTION_VALUE_ENABLE_LOOSE_SOURCE (0x00000001)")]
        public const int FWP_OPTION_VALUE_ENABLE_LOOSE_SOURCE = (0x00000001);

        [NativeTypeName("#define FWP_OPTION_VALUE_DISABLE_LOCAL_ONLY_MAPPING (0x00000000)")]
        public const int FWP_OPTION_VALUE_DISABLE_LOCAL_ONLY_MAPPING = (0x00000000);

        [NativeTypeName("#define FWP_OPTION_VALUE_ENABLE_LOCAL_ONLY_MAPPING (0x00000001)")]
        public const int FWP_OPTION_VALUE_ENABLE_LOCAL_ONLY_MAPPING = (0x00000001);

        [NativeTypeName("#define FWP_ACTION_FLAG_TERMINATING (0x00001000)")]
        public const int FWP_ACTION_FLAG_TERMINATING = (0x00001000);

        [NativeTypeName("#define FWP_ACTION_FLAG_NON_TERMINATING (0x00002000)")]
        public const int FWP_ACTION_FLAG_NON_TERMINATING = (0x00002000);

        [NativeTypeName("#define FWP_ACTION_FLAG_CALLOUT (0x00004000)")]
        public const int FWP_ACTION_FLAG_CALLOUT = (0x00004000);

        [NativeTypeName("#define FWP_ACTION_BLOCK (0x00000001 | FWP_ACTION_FLAG_TERMINATING)")]
        public const int FWP_ACTION_BLOCK = (0x00000001 | (0x00001000));

        [NativeTypeName("#define FWP_ACTION_PERMIT (0x00000002 | FWP_ACTION_FLAG_TERMINATING)")]
        public const int FWP_ACTION_PERMIT = (0x00000002 | (0x00001000));

        [NativeTypeName("#define FWP_ACTION_CALLOUT_TERMINATING (0x00000003 | FWP_ACTION_FLAG_CALLOUT | FWP_ACTION_FLAG_TERMINATING)")]
        public const int FWP_ACTION_CALLOUT_TERMINATING = (0x00000003 | (0x00004000) | (0x00001000));

        [NativeTypeName("#define FWP_ACTION_CALLOUT_INSPECTION (0x00000004 | FWP_ACTION_FLAG_CALLOUT | FWP_ACTION_FLAG_NON_TERMINATING)")]
        public const int FWP_ACTION_CALLOUT_INSPECTION = (0x00000004 | (0x00004000) | (0x00002000));

        [NativeTypeName("#define FWP_ACTION_CALLOUT_UNKNOWN (0x00000005 | FWP_ACTION_FLAG_CALLOUT)")]
        public const int FWP_ACTION_CALLOUT_UNKNOWN = (0x00000005 | (0x00004000));

        [NativeTypeName("#define FWP_ACTION_CONTINUE (0x00000006 | FWP_ACTION_FLAG_NON_TERMINATING)")]
        public const int FWP_ACTION_CONTINUE = (0x00000006 | (0x00002000));

        [NativeTypeName("#define FWP_ACTION_NONE (0x00000007)")]
        public const int FWP_ACTION_NONE = (0x00000007);

        [NativeTypeName("#define FWP_ACTION_NONE_NO_MATCH (0x00000008)")]
        public const int FWP_ACTION_NONE_NO_MATCH = (0x00000008);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_LOOPBACK (0x00000001)")]
        public const int FWP_CONDITION_FLAG_IS_LOOPBACK = (0x00000001);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_IPSEC_SECURED (0x00000002)")]
        public const int FWP_CONDITION_FLAG_IS_IPSEC_SECURED = (0x00000002);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_REAUTHORIZE (0x00000004)")]
        public const int FWP_CONDITION_FLAG_IS_REAUTHORIZE = (0x00000004);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_WILDCARD_BIND (0x00000008)")]
        public const int FWP_CONDITION_FLAG_IS_WILDCARD_BIND = (0x00000008);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_RAW_ENDPOINT (0x00000010)")]
        public const int FWP_CONDITION_FLAG_IS_RAW_ENDPOINT = (0x00000010);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_FRAGMENT (0x00000020)")]
        public const int FWP_CONDITION_FLAG_IS_FRAGMENT = (0x00000020);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_FRAGMENT_GROUP (0x00000040)")]
        public const int FWP_CONDITION_FLAG_IS_FRAGMENT_GROUP = (0x00000040);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_IPSEC_NATT_RECLASSIFY (0x00000080)")]
        public const int FWP_CONDITION_FLAG_IS_IPSEC_NATT_RECLASSIFY = (0x00000080);

        [NativeTypeName("#define FWP_CONDITION_FLAG_REQUIRES_ALE_CLASSIFY (0x00000100)")]
        public const int FWP_CONDITION_FLAG_REQUIRES_ALE_CLASSIFY = (0x00000100);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_IMPLICIT_BIND (0x00000200)")]
        public const int FWP_CONDITION_FLAG_IS_IMPLICIT_BIND = (0x00000200);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_REASSEMBLED (0x00000400)")]
        public const int FWP_CONDITION_FLAG_IS_REASSEMBLED = (0x00000400);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_NAME_APP_SPECIFIED (0x00004000)")]
        public const int FWP_CONDITION_FLAG_IS_NAME_APP_SPECIFIED = (0x00004000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_PROMISCUOUS (0x00008000)")]
        public const int FWP_CONDITION_FLAG_IS_PROMISCUOUS = (0x00008000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_AUTH_FW (0x00010000)")]
        public const int FWP_CONDITION_FLAG_IS_AUTH_FW = (0x00010000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_RECLASSIFY (0x00020000)")]
        public const int FWP_CONDITION_FLAG_IS_RECLASSIFY = (0x00020000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_OUTBOUND_PASS_THRU (0x00040000)")]
        public const int FWP_CONDITION_FLAG_IS_OUTBOUND_PASS_THRU = (0x00040000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_INBOUND_PASS_THRU (0x00080000)")]
        public const int FWP_CONDITION_FLAG_IS_INBOUND_PASS_THRU = (0x00080000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_CONNECTION_REDIRECTED (0x00100000)")]
        public const int FWP_CONDITION_FLAG_IS_CONNECTION_REDIRECTED = (0x00100000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_PROXY_CONNECTION (0x00200000)")]
        public const int FWP_CONDITION_FLAG_IS_PROXY_CONNECTION = (0x00200000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_APPCONTAINER_LOOPBACK (0x00400000)")]
        public const int FWP_CONDITION_FLAG_IS_APPCONTAINER_LOOPBACK = (0x00400000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_NON_APPCONTAINER_LOOPBACK (0x00800000)")]
        public const int FWP_CONDITION_FLAG_IS_NON_APPCONTAINER_LOOPBACK = (0x00800000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_RESERVED (0x01000000)")]
        public const int FWP_CONDITION_FLAG_IS_RESERVED = (0x01000000);

        [NativeTypeName("#define FWP_CONDITION_FLAG_IS_HONORING_POLICY_AUTHORIZE (0x02000000)")]
        public const int FWP_CONDITION_FLAG_IS_HONORING_POLICY_AUTHORIZE = (0x02000000);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_POLICY_CHANGE (0x00000001)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_POLICY_CHANGE = (0x00000001);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_NEW_ARRIVAL_INTERFACE (0x00000002)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_NEW_ARRIVAL_INTERFACE = (0x00000002);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_NEW_NEXTHOP_INTERFACE (0x00000004)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_NEW_NEXTHOP_INTERFACE = (0x00000004);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_PROFILE_CROSSING (0x00000008)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_PROFILE_CROSSING = (0x00000008);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_CLASSIFY_COMPLETION (0x00000010)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_CLASSIFY_COMPLETION = (0x00000010);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_IPSEC_PROPERTIES_CHANGED (0x00000020)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_IPSEC_PROPERTIES_CHANGED = (0x00000020);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_MID_STREAM_INSPECTION (0x00000040)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_MID_STREAM_INSPECTION = (0x00000040);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_SOCKET_PROPERTY_CHANGED (0x00000080)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_SOCKET_PROPERTY_CHANGED = (0x00000080);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_NEW_INBOUND_MCAST_BCAST_PACKET (0x00000100)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_NEW_INBOUND_MCAST_BCAST_PACKET = (0x00000100);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_EDP_POLICY_CHANGED (0x00000200)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_EDP_POLICY_CHANGED = (0x00000200);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_PROXY_HANDLE_CHANGED (0x00004000)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_PROXY_HANDLE_CHANGED = (0x00004000);

        [NativeTypeName("#define FWP_CONDITION_REAUTHORIZE_REASON_CHECK_OFFLOAD (0x00010000)")]
        public const int FWP_CONDITION_REAUTHORIZE_REASON_CHECK_OFFLOAD = (0x00010000);

        [NativeTypeName("#define FWP_CONDITION_SOCKET_PROPERTY_FLAG_IS_SYSTEM_PORT_RPC (0x00000001)")]
        public const int FWP_CONDITION_SOCKET_PROPERTY_FLAG_IS_SYSTEM_PORT_RPC = (0x00000001);

        [NativeTypeName("#define FWP_CONDITION_SOCKET_PROPERTY_FLAG_ALLOW_EDGE_TRAFFIC (0x00000002)")]
        public const int FWP_CONDITION_SOCKET_PROPERTY_FLAG_ALLOW_EDGE_TRAFFIC = (0x00000002);

        [NativeTypeName("#define FWP_CONDITION_SOCKET_PROPERTY_FLAG_DENY_EDGE_TRAFFIC (0x00000004)")]
        public const int FWP_CONDITION_SOCKET_PROPERTY_FLAG_DENY_EDGE_TRAFFIC = (0x00000004);

        [NativeTypeName("#define FWP_CONDITION_L2_IS_NATIVE_ETHERNET (0x00000001)")]
        public const int FWP_CONDITION_L2_IS_NATIVE_ETHERNET = (0x00000001);

        [NativeTypeName("#define FWP_CONDITION_L2_IS_WIFI (0x00000002)")]
        public const int FWP_CONDITION_L2_IS_WIFI = (0x00000002);

        [NativeTypeName("#define FWP_CONDITION_L2_IS_MOBILE_BROADBAND (0x00000004)")]
        public const int FWP_CONDITION_L2_IS_MOBILE_BROADBAND = (0x00000004);

        [NativeTypeName("#define FWP_CONDITION_L2_IS_WIFI_DIRECT_DATA (0x00000008)")]
        public const int FWP_CONDITION_L2_IS_WIFI_DIRECT_DATA = (0x00000008);

        [NativeTypeName("#define FWP_CONDITION_L2_IS_VM2VM (0x00000010)")]
        public const int FWP_CONDITION_L2_IS_VM2VM = (0x00000010);

        [NativeTypeName("#define FWP_CONDITION_L2_IS_MALFORMED_PACKET (0x00000020)")]
        public const int FWP_CONDITION_L2_IS_MALFORMED_PACKET = (0x00000020);

        [NativeTypeName("#define FWP_CONDITION_L2_IS_IP_FRAGMENT_GROUP (0x00000040)")]
        public const int FWP_CONDITION_L2_IS_IP_FRAGMENT_GROUP = (0x00000040);

        [NativeTypeName("#define FWP_CONDITION_L2_IF_CONNECTOR_PRESENT (0x00000080)")]
        public const int FWP_CONDITION_L2_IF_CONNECTOR_PRESENT = (0x00000080);

        [NativeTypeName("#define FWP_FILTER_ENUM_FLAG_BEST_TERMINATING_MATCH (0x00000001)")]
        public const int FWP_FILTER_ENUM_FLAG_BEST_TERMINATING_MATCH = (0x00000001);

        [NativeTypeName("#define FWP_FILTER_ENUM_FLAG_SORTED (0x00000002)")]
        public const int FWP_FILTER_ENUM_FLAG_SORTED = (0x00000002);

        [NativeTypeName("#define FWP_FILTER_ENUM_FLAG_BOOTTIME_ONLY (0x00000004)")]
        public const int FWP_FILTER_ENUM_FLAG_BOOTTIME_ONLY = (0x00000004);

        [NativeTypeName("#define FWP_FILTER_ENUM_FLAG_INCLUDE_BOOTTIME (0x00000008)")]
        public const int FWP_FILTER_ENUM_FLAG_INCLUDE_BOOTTIME = (0x00000008);

        [NativeTypeName("#define FWP_FILTER_ENUM_FLAG_INCLUDE_DISABLED (0x00000010)")]
        public const int FWP_FILTER_ENUM_FLAG_INCLUDE_DISABLED = (0x00000010);

        [NativeTypeName("#define FWP_FILTER_ENUM_VALID_FLAGS (FWP_FILTER_ENUM_FLAG_BEST_TERMINATING_MATCH | FWP_FILTER_ENUM_FLAG_SORTED)")]
        public const int FWP_FILTER_ENUM_VALID_FLAGS = ((0x00000001) | (0x00000002));

        [NativeTypeName("#define FWP_FILTER_ENUM_FLAG_RESERVED1 (0x00000020)")]
        public const int FWP_FILTER_ENUM_FLAG_RESERVED1 = (0x00000020);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_CONDITIONAL_ON_FLOW (0x00000001)")]
        public const int FWP_CALLOUT_FLAG_CONDITIONAL_ON_FLOW = (0x00000001);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_ALLOW_OFFLOAD (0x00000002)")]
        public const int FWP_CALLOUT_FLAG_ALLOW_OFFLOAD = (0x00000002);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_ENABLE_COMMIT_ADD_NOTIFY (0x00000004)")]
        public const int FWP_CALLOUT_FLAG_ENABLE_COMMIT_ADD_NOTIFY = (0x00000004);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_ALLOW_MID_STREAM_INSPECTION (0x00000008)")]
        public const int FWP_CALLOUT_FLAG_ALLOW_MID_STREAM_INSPECTION = (0x00000008);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_ALLOW_RECLASSIFY (0x00000010)")]
        public const int FWP_CALLOUT_FLAG_ALLOW_RECLASSIFY = (0x00000010);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_RESERVED1 (0x00000020)")]
        public const int FWP_CALLOUT_FLAG_RESERVED1 = (0x00000020);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_ALLOW_RSC (0x00000040)")]
        public const int FWP_CALLOUT_FLAG_ALLOW_RSC = (0x00000040);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_ALLOW_L2_BATCH_CLASSIFY (0x00000080)")]
        public const int FWP_CALLOUT_FLAG_ALLOW_L2_BATCH_CLASSIFY = (0x00000080);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_ALLOW_USO (0x00000100)")]
        public const int FWP_CALLOUT_FLAG_ALLOW_USO = (0x00000100);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_ALLOW_URO (0x00000200)")]
        public const int FWP_CALLOUT_FLAG_ALLOW_URO = (0x00000200);

        [NativeTypeName("#define FWP_CALLOUT_FLAG_RESERVED2 (0x00000400)")]
        public const int FWP_CALLOUT_FLAG_RESERVED2 = (0x00000400);

        [NativeTypeName("#define FWPM_SUBSCRIPTION_FLAG_NOTIFY_ON_ADD (0x00000001)")]
        public const int FWPM_SUBSCRIPTION_FLAG_NOTIFY_ON_ADD = (0x00000001);

        [NativeTypeName("#define FWPM_SUBSCRIPTION_FLAG_NOTIFY_ON_DELETE (0x00000002)")]
        public const int FWPM_SUBSCRIPTION_FLAG_NOTIFY_ON_DELETE = (0x00000002);

        [NativeTypeName("#define FWPM_NET_EVENT_KEYWORD_INBOUND_MCAST (0x00000001)")]
        public const int FWPM_NET_EVENT_KEYWORD_INBOUND_MCAST = (0x00000001);

        [NativeTypeName("#define FWPM_NET_EVENT_KEYWORD_INBOUND_BCAST (0x00000002)")]
        public const int FWPM_NET_EVENT_KEYWORD_INBOUND_BCAST = (0x00000002);

        [NativeTypeName("#define FWPM_NET_EVENT_KEYWORD_CAPABILITY_DROP (0x00000004)")]
        public const int FWPM_NET_EVENT_KEYWORD_CAPABILITY_DROP = (0x00000004);

        [NativeTypeName("#define FWPM_NET_EVENT_KEYWORD_CAPABILITY_ALLOW (0x00000008)")]
        public const int FWPM_NET_EVENT_KEYWORD_CAPABILITY_ALLOW = (0x00000008);

        [NativeTypeName("#define FWPM_NET_EVENT_KEYWORD_CLASSIFY_ALLOW (0x00000010)")]
        public const int FWPM_NET_EVENT_KEYWORD_CLASSIFY_ALLOW = (0x00000010);

        [NativeTypeName("#define FWPM_NET_EVENT_KEYWORD_PORT_SCANNING_DROP (0x00000020)")]
        public const int FWPM_NET_EVENT_KEYWORD_PORT_SCANNING_DROP = (0x00000020);

        [NativeTypeName("#define FWPM_ENGINE_OPTION_PACKET_QUEUE_NONE (0x00000000)")]
        public const int FWPM_ENGINE_OPTION_PACKET_QUEUE_NONE = (0x00000000);

        [NativeTypeName("#define FWPM_ENGINE_OPTION_PACKET_QUEUE_INBOUND (0x00000001)")]
        public const int FWPM_ENGINE_OPTION_PACKET_QUEUE_INBOUND = (0x00000001);

        [NativeTypeName("#define FWPM_ENGINE_OPTION_PACKET_QUEUE_FORWARD (0x00000002)")]
        public const int FWPM_ENGINE_OPTION_PACKET_QUEUE_FORWARD = (0x00000002);

        [NativeTypeName("#define FWPM_ENGINE_OPTION_PACKET_BATCH_INBOUND (0x00000004)")]
        public const int FWPM_ENGINE_OPTION_PACKET_BATCH_INBOUND = (0x00000004);

        [NativeTypeName("#define FWPM_SESSION_FLAG_DYNAMIC (0x00000001)")]
        public const int FWPM_SESSION_FLAG_DYNAMIC = (0x00000001);

        [NativeTypeName("#define FWPM_SESSION_FLAG_RESERVED (0x10000000)")]
        public const int FWPM_SESSION_FLAG_RESERVED = (0x10000000);

        [NativeTypeName("#define FWPM_PROVIDER_FLAG_PERSISTENT (0x00000001)")]
        public const int FWPM_PROVIDER_FLAG_PERSISTENT = (0x00000001);

        [NativeTypeName("#define FWPM_PROVIDER_FLAG_DISABLED (0x00000010)")]
        public const int FWPM_PROVIDER_FLAG_DISABLED = (0x00000010);

        [NativeTypeName("#define FWPM_PROVIDER_CONTEXT_FLAG_PERSISTENT (0x00000001)")]
        public const int FWPM_PROVIDER_CONTEXT_FLAG_PERSISTENT = (0x00000001);

        [NativeTypeName("#define FWPM_PROVIDER_CONTEXT_FLAG_DOWNLEVEL (0x00000002)")]
        public const int FWPM_PROVIDER_CONTEXT_FLAG_DOWNLEVEL = (0x00000002);

        [NativeTypeName("#define FWPM_SUBLAYER_FLAG_PERSISTENT (0x00000001)")]
        public const int FWPM_SUBLAYER_FLAG_PERSISTENT = (0x00000001);

        [NativeTypeName("#define FWPM_LAYER_FLAG_KERNEL (0x00000001)")]
        public const int FWPM_LAYER_FLAG_KERNEL = (0x00000001);

        [NativeTypeName("#define FWPM_LAYER_FLAG_BUILTIN (0x00000002)")]
        public const int FWPM_LAYER_FLAG_BUILTIN = (0x00000002);

        [NativeTypeName("#define FWPM_LAYER_FLAG_CLASSIFY_MOSTLY (0x00000004)")]
        public const int FWPM_LAYER_FLAG_CLASSIFY_MOSTLY = (0x00000004);

        [NativeTypeName("#define FWPM_LAYER_FLAG_BUFFERED (0x00000008)")]
        public const int FWPM_LAYER_FLAG_BUFFERED = (0x00000008);

        [NativeTypeName("#define FWPM_CALLOUT_FLAG_PERSISTENT (0x00010000)")]
        public const int FWPM_CALLOUT_FLAG_PERSISTENT = (0x00010000);

        [NativeTypeName("#define FWPM_CALLOUT_FLAG_USES_PROVIDER_CONTEXT (0x00020000)")]
        public const int FWPM_CALLOUT_FLAG_USES_PROVIDER_CONTEXT = (0x00020000);

        [NativeTypeName("#define FWPM_CALLOUT_FLAG_REGISTERED (0x00040000)")]
        public const int FWPM_CALLOUT_FLAG_REGISTERED = (0x00040000);

        [NativeTypeName("#define FWPM_FILTER_FLAG_NONE (0x00000000)")]
        public const int FWPM_FILTER_FLAG_NONE = (0x00000000);

        [NativeTypeName("#define FWPM_FILTER_FLAG_PERSISTENT (0x00000001)")]
        public const int FWPM_FILTER_FLAG_PERSISTENT = (0x00000001);

        [NativeTypeName("#define FWPM_FILTER_FLAG_BOOTTIME (0x00000002)")]
        public const int FWPM_FILTER_FLAG_BOOTTIME = (0x00000002);

        [NativeTypeName("#define FWPM_FILTER_FLAG_HAS_PROVIDER_CONTEXT (0x00000004)")]
        public const int FWPM_FILTER_FLAG_HAS_PROVIDER_CONTEXT = (0x00000004);

        [NativeTypeName("#define FWPM_FILTER_FLAG_CLEAR_ACTION_RIGHT (0x00000008)")]
        public const int FWPM_FILTER_FLAG_CLEAR_ACTION_RIGHT = (0x00000008);

        [NativeTypeName("#define FWPM_FILTER_FLAG_PERMIT_IF_CALLOUT_UNREGISTERED (0x00000010)")]
        public const int FWPM_FILTER_FLAG_PERMIT_IF_CALLOUT_UNREGISTERED = (0x00000010);

        [NativeTypeName("#define FWPM_FILTER_FLAG_DISABLED (0x00000020)")]
        public const int FWPM_FILTER_FLAG_DISABLED = (0x00000020);

        [NativeTypeName("#define FWPM_FILTER_FLAG_INDEXED (0x00000040)")]
        public const int FWPM_FILTER_FLAG_INDEXED = (0x00000040);

        [NativeTypeName("#define FWPM_FILTER_FLAG_HAS_SECURITY_REALM_PROVIDER_CONTEXT (0x00000080)")]
        public const int FWPM_FILTER_FLAG_HAS_SECURITY_REALM_PROVIDER_CONTEXT = (0x00000080);

        [NativeTypeName("#define FWPM_FILTER_FLAG_SYSTEMOS_ONLY (0x00000100)")]
        public const int FWPM_FILTER_FLAG_SYSTEMOS_ONLY = (0x00000100);

        [NativeTypeName("#define FWPM_FILTER_FLAG_GAMEOS_ONLY (0x00000200)")]
        public const int FWPM_FILTER_FLAG_GAMEOS_ONLY = (0x00000200);

        [NativeTypeName("#define FWPM_FILTER_FLAG_SILENT_MODE (0x00000400)")]
        public const int FWPM_FILTER_FLAG_SILENT_MODE = (0x00000400);

        [NativeTypeName("#define FWPM_FILTER_FLAG_IPSEC_NO_ACQUIRE_INITIATE (0x00000800)")]
        public const int FWPM_FILTER_FLAG_IPSEC_NO_ACQUIRE_INITIATE = (0x00000800);

        [NativeTypeName("#define FWPM_FILTER_FLAG_RESERVED0 (0x00001000)")]
        public const int FWPM_FILTER_FLAG_RESERVED0 = (0x00001000);

        [NativeTypeName("#define FWPM_FILTER_FLAG_RESERVED1 (0x00002000)")]
        public const int FWPM_FILTER_FLAG_RESERVED1 = (0x00002000);

        [NativeTypeName("#define FWPM_FILTER_FLAG_RESERVED2 (0x00004000)")]
        public const int FWPM_FILTER_FLAG_RESERVED2 = (0x00004000);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_IP_PROTOCOL_SET (0x00000001)")]
        public const int FWPM_NET_EVENT_FLAG_IP_PROTOCOL_SET = (0x00000001);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_LOCAL_ADDR_SET (0x00000002)")]
        public const int FWPM_NET_EVENT_FLAG_LOCAL_ADDR_SET = (0x00000002);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_REMOTE_ADDR_SET (0x00000004)")]
        public const int FWPM_NET_EVENT_FLAG_REMOTE_ADDR_SET = (0x00000004);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_LOCAL_PORT_SET (0x00000008)")]
        public const int FWPM_NET_EVENT_FLAG_LOCAL_PORT_SET = (0x00000008);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_REMOTE_PORT_SET (0x00000010)")]
        public const int FWPM_NET_EVENT_FLAG_REMOTE_PORT_SET = (0x00000010);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_APP_ID_SET (0x00000020)")]
        public const int FWPM_NET_EVENT_FLAG_APP_ID_SET = (0x00000020);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_USER_ID_SET (0x00000040)")]
        public const int FWPM_NET_EVENT_FLAG_USER_ID_SET = (0x00000040);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_SCOPE_ID_SET (0x00000080)")]
        public const int FWPM_NET_EVENT_FLAG_SCOPE_ID_SET = (0x00000080);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_IP_VERSION_SET (0x00000100)")]
        public const int FWPM_NET_EVENT_FLAG_IP_VERSION_SET = (0x00000100);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_REAUTH_REASON_SET (0x00000200)")]
        public const int FWPM_NET_EVENT_FLAG_REAUTH_REASON_SET = (0x00000200);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_PACKAGE_ID_SET (0x00000400)")]
        public const int FWPM_NET_EVENT_FLAG_PACKAGE_ID_SET = (0x00000400);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_ENTERPRISE_ID_SET (0x00000800)")]
        public const int FWPM_NET_EVENT_FLAG_ENTERPRISE_ID_SET = (0x00000800);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_POLICY_FLAGS_SET (0x00001000)")]
        public const int FWPM_NET_EVENT_FLAG_POLICY_FLAGS_SET = (0x00001000);

        [NativeTypeName("#define FWPM_NET_EVENT_FLAG_EFFECTIVE_NAME_SET (0x00002000)")]
        public const int FWPM_NET_EVENT_FLAG_EFFECTIVE_NAME_SET = (0x00002000);

        [NativeTypeName("#define IKEEXT_CERT_HASH_LEN 20")]
        public const int IKEEXT_CERT_HASH_LEN = 20;

        [NativeTypeName("#define FWPM_NET_EVENT_IKEEXT_MM_FAILURE_FLAG_BENIGN (0x00000001)")]
        public const int FWPM_NET_EVENT_IKEEXT_MM_FAILURE_FLAG_BENIGN = (0x00000001);

        [NativeTypeName("#define FWPM_NET_EVENT_IKEEXT_MM_FAILURE_FLAG_MULTIPLE (0x00000002)")]
        public const int FWPM_NET_EVENT_IKEEXT_MM_FAILURE_FLAG_MULTIPLE = (0x00000002);

        [NativeTypeName("#define FWPM_NET_EVENT_IKEEXT_EM_FAILURE_FLAG_MULTIPLE (0x00000001)")]
        public const int FWPM_NET_EVENT_IKEEXT_EM_FAILURE_FLAG_MULTIPLE = (0x00000001);

        [NativeTypeName("#define FWPM_NET_EVENT_IKEEXT_EM_FAILURE_FLAG_BENIGN (0x00000002)")]
        public const int FWPM_NET_EVENT_IKEEXT_EM_FAILURE_FLAG_BENIGN = (0x00000002);

        [NativeTypeName("#define FWPM_CONNECTION_ENUM_FLAG_QUERY_BYTES_TRANSFERRED (0x00000001)")]
        public const int FWPM_CONNECTION_ENUM_FLAG_QUERY_BYTES_TRANSFERRED = (0x00000001);

        [NativeTypeName("#define FwpmFreeMemory FwpmFreeMemory0")]
        public static delegate*<void**, void> FwpmFreeMemory => &FwpmFreeMemory0;

        [NativeTypeName("#define FwpmEngineOpen FwpmEngineOpen0")]
        public static delegate*<char*, uint, SEC_WINNT_AUTH_IDENTITY_W*, FWPM_SESSION0_*, void**, uint> FwpmEngineOpen => &FwpmEngineOpen0;

        [NativeTypeName("#define FwpmEngineClose FwpmEngineClose0")]
        public static delegate*<void*, uint> FwpmEngineClose => &FwpmEngineClose0;

        [NativeTypeName("#define FwpmEngineGetOption FwpmEngineGetOption0")]
        public static delegate*<void*, FWPM_ENGINE_OPTION_, FWP_VALUE0_**, uint> FwpmEngineGetOption => &FwpmEngineGetOption0;

        [NativeTypeName("#define FwpmEngineSetOption FwpmEngineSetOption0")]
        public static delegate*<void*, FWPM_ENGINE_OPTION_, FWP_VALUE0_*, uint> FwpmEngineSetOption => &FwpmEngineSetOption0;

        [NativeTypeName("#define FwpmEngineGetSecurityInfo FwpmEngineGetSecurityInfo0")]
        public static delegate*<void*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmEngineGetSecurityInfo => &FwpmEngineGetSecurityInfo0;

        [NativeTypeName("#define FwpmEngineSetSecurityInfo FwpmEngineSetSecurityInfo0")]
        public static delegate*<void*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmEngineSetSecurityInfo => &FwpmEngineSetSecurityInfo0;

        [NativeTypeName("#define FwpmSessionCreateEnumHandle FwpmSessionCreateEnumHandle0")]
        public static delegate*<void*, FWPM_SESSION_ENUM_TEMPLATE0_*, void**, uint> FwpmSessionCreateEnumHandle => &FwpmSessionCreateEnumHandle0;

        [NativeTypeName("#define FwpmSessionEnum FwpmSessionEnum0")]
        public static delegate*<void*, void*, uint, FWPM_SESSION0_***, uint*, uint> FwpmSessionEnum => &FwpmSessionEnum0;

        [NativeTypeName("#define FwpmSessionDestroyEnumHandle FwpmSessionDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmSessionDestroyEnumHandle => &FwpmSessionDestroyEnumHandle0;

        [NativeTypeName("#define FwpmTransactionBegin FwpmTransactionBegin0")]
        public static delegate*<void*, uint, uint> FwpmTransactionBegin => &FwpmTransactionBegin0;

        [NativeTypeName("#define FwpmTransactionCommit FwpmTransactionCommit0")]
        public static delegate*<void*, uint> FwpmTransactionCommit => &FwpmTransactionCommit0;

        [NativeTypeName("#define FwpmTransactionAbort FwpmTransactionAbort0")]
        public static delegate*<void*, uint> FwpmTransactionAbort => &FwpmTransactionAbort0;

        [NativeTypeName("#define FwpmProviderAdd FwpmProviderAdd0")]
        public static delegate*<void*, FWPM_PROVIDER0*, void*, uint> FwpmProviderAdd => &FwpmProviderAdd0;

        [NativeTypeName("#define FwpmProviderDeleteByKey FwpmProviderDeleteByKey0")]
        public static delegate*<void*, Guid*, uint> FwpmProviderDeleteByKey => &FwpmProviderDeleteByKey0;

        [NativeTypeName("#define FwpmProviderGetByKey FwpmProviderGetByKey0")]
        public static delegate*<void*, Guid*, FWPM_PROVIDER0**, uint> FwpmProviderGetByKey => &FwpmProviderGetByKey0;

        [NativeTypeName("#define FwpmProviderCreateEnumHandle FwpmProviderCreateEnumHandle0")]
        public static delegate*<void*, FWPM_PROVIDER_ENUM_TEMPLATE0*, void**, uint> FwpmProviderCreateEnumHandle => &FwpmProviderCreateEnumHandle0;

        [NativeTypeName("#define FwpmProviderEnum FwpmProviderEnum0")]
        public static delegate*<void*, void*, uint, FWPM_PROVIDER0***, uint*, uint> FwpmProviderEnum => &FwpmProviderEnum0;

        [NativeTypeName("#define FwpmProviderDestroyEnumHandle FwpmProviderDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmProviderDestroyEnumHandle => &FwpmProviderDestroyEnumHandle0;

        [NativeTypeName("#define FwpmProviderGetSecurityInfoByKey FwpmProviderGetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmProviderGetSecurityInfoByKey => &FwpmProviderGetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmProviderSetSecurityInfoByKey FwpmProviderSetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmProviderSetSecurityInfoByKey => &FwpmProviderSetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmProviderSubscribeChanges FwpmProviderSubscribeChanges0")]
        public static delegate*<void*, FWPM_PROVIDER_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, FWPM_PROVIDER_CHANGE0_*, void>, void*, void**, uint> FwpmProviderSubscribeChanges => &FwpmProviderSubscribeChanges0;

        [NativeTypeName("#define FwpmProviderUnsubscribeChanges FwpmProviderUnsubscribeChanges0")]
        public static delegate*<void*, void*, uint> FwpmProviderUnsubscribeChanges => &FwpmProviderUnsubscribeChanges0;

        [NativeTypeName("#define FwpmProviderSubscriptionsGet FwpmProviderSubscriptionsGet0")]
        public static delegate*<void*, FWPM_PROVIDER_SUBSCRIPTION0_***, uint*, uint> FwpmProviderSubscriptionsGet => &FwpmProviderSubscriptionsGet0;

        [NativeTypeName("#define FwpmProviderContextAdd FwpmProviderContextAdd3")]
        public static delegate*<void*, FWPM_PROVIDER_CONTEXT3_*, void*, ulong*, uint> FwpmProviderContextAdd => &FwpmProviderContextAdd3;

        [NativeTypeName("#define FwpmProviderContextGetById FwpmProviderContextGetById3")]
        public static delegate*<void*, ulong, FWPM_PROVIDER_CONTEXT3_**, uint> FwpmProviderContextGetById => &FwpmProviderContextGetById3;

        [NativeTypeName("#define FwpmProviderContextGetByKey FwpmProviderContextGetByKey3")]
        public static delegate*<void*, Guid*, FWPM_PROVIDER_CONTEXT3_**, uint> FwpmProviderContextGetByKey => &FwpmProviderContextGetByKey3;

        [NativeTypeName("#define FwpmProviderContextEnum FwpmProviderContextEnum3")]
        public static delegate*<void*, void*, uint, FWPM_PROVIDER_CONTEXT3_***, uint*, uint> FwpmProviderContextEnum => &FwpmProviderContextEnum3;

        [NativeTypeName("#define FwpmProviderContextDeleteById FwpmProviderContextDeleteById0")]
        public static delegate*<void*, ulong, uint> FwpmProviderContextDeleteById => &FwpmProviderContextDeleteById0;

        [NativeTypeName("#define FwpmProviderContextDeleteByKey FwpmProviderContextDeleteByKey0")]
        public static delegate*<void*, Guid*, uint> FwpmProviderContextDeleteByKey => &FwpmProviderContextDeleteByKey0;

        [NativeTypeName("#define FwpmProviderContextCreateEnumHandle FwpmProviderContextCreateEnumHandle0")]
        public static delegate*<void*, FWPM_PROVIDER_CONTEXT_ENUM_TEMPLATE0_*, void**, uint> FwpmProviderContextCreateEnumHandle => &FwpmProviderContextCreateEnumHandle0;

        [NativeTypeName("#define FwpmProviderContextDestroyEnumHandle FwpmProviderContextDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmProviderContextDestroyEnumHandle => &FwpmProviderContextDestroyEnumHandle0;

        [NativeTypeName("#define FwpmProviderContextGetSecurityInfoByKey FwpmProviderContextGetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmProviderContextGetSecurityInfoByKey => &FwpmProviderContextGetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmProviderContextSetSecurityInfoByKey FwpmProviderContextSetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmProviderContextSetSecurityInfoByKey => &FwpmProviderContextSetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmProviderContextSubscribeChanges FwpmProviderContextSubscribeChanges0")]
        public static delegate*<void*, FWPM_PROVIDER_CONTEXT_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, FWPM_PROVIDER_CONTEXT_CHANGE0_*, void>, void*, void**, uint> FwpmProviderContextSubscribeChanges => &FwpmProviderContextSubscribeChanges0;

        [NativeTypeName("#define FwpmProviderContextUnsubscribeChanges FwpmProviderContextUnsubscribeChanges0")]
        public static delegate*<void*, void*, uint> FwpmProviderContextUnsubscribeChanges => &FwpmProviderContextUnsubscribeChanges0;

        [NativeTypeName("#define FwpmProviderContextSubscriptionsGet FwpmProviderContextSubscriptionsGet0")]
        public static delegate*<void*, FWPM_PROVIDER_CONTEXT_SUBSCRIPTION0_***, uint*, uint> FwpmProviderContextSubscriptionsGet => &FwpmProviderContextSubscriptionsGet0;

        [NativeTypeName("#define FwpmSubLayerAdd FwpmSubLayerAdd0")]
        public static delegate*<void*, FWPM_SUBLAYER0_*, void*, uint> FwpmSubLayerAdd => &FwpmSubLayerAdd0;

        [NativeTypeName("#define FwpmSubLayerDeleteByKey FwpmSubLayerDeleteByKey0")]
        public static delegate*<void*, Guid*, uint> FwpmSubLayerDeleteByKey => &FwpmSubLayerDeleteByKey0;

        [NativeTypeName("#define FwpmSubLayerGetByKey FwpmSubLayerGetByKey0")]
        public static delegate*<void*, Guid*, FWPM_SUBLAYER0_**, uint> FwpmSubLayerGetByKey => &FwpmSubLayerGetByKey0;

        [NativeTypeName("#define FwpmSubLayerCreateEnumHandle FwpmSubLayerCreateEnumHandle0")]
        public static delegate*<void*, FWPM_SUBLAYER_ENUM_TEMPLATE0_*, void**, uint> FwpmSubLayerCreateEnumHandle => &FwpmSubLayerCreateEnumHandle0;

        [NativeTypeName("#define FwpmSubLayerEnum FwpmSubLayerEnum0")]
        public static delegate*<void*, void*, uint, FWPM_SUBLAYER0_***, uint*, uint> FwpmSubLayerEnum => &FwpmSubLayerEnum0;

        [NativeTypeName("#define FwpmSubLayerDestroyEnumHandle FwpmSubLayerDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmSubLayerDestroyEnumHandle => &FwpmSubLayerDestroyEnumHandle0;

        [NativeTypeName("#define FwpmSubLayerGetSecurityInfoByKey FwpmSubLayerGetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmSubLayerGetSecurityInfoByKey => &FwpmSubLayerGetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmSubLayerSetSecurityInfoByKey FwpmSubLayerSetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmSubLayerSetSecurityInfoByKey => &FwpmSubLayerSetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmSubLayerSubscribeChanges FwpmSubLayerSubscribeChanges0")]
        public static delegate*<void*, FWPM_SUBLAYER_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, FWPM_SUBLAYER_CHANGE0_*, void>, void*, void**, uint> FwpmSubLayerSubscribeChanges => &FwpmSubLayerSubscribeChanges0;

        [NativeTypeName("#define FwpmSubLayerUnsubscribeChanges FwpmSubLayerUnsubscribeChanges0")]
        public static delegate*<void*, void*, uint> FwpmSubLayerUnsubscribeChanges => &FwpmSubLayerUnsubscribeChanges0;

        [NativeTypeName("#define FwpmSubLayerSubscriptionsGet FwpmSubLayerSubscriptionsGet0")]
        public static delegate*<void*, FWPM_SUBLAYER_SUBSCRIPTION0_***, uint*, uint> FwpmSubLayerSubscriptionsGet => &FwpmSubLayerSubscriptionsGet0;

        [NativeTypeName("#define FwpmLayerGetById FwpmLayerGetById0")]
        public static delegate*<void*, ushort, FWPM_LAYER0_**, uint> FwpmLayerGetById => &FwpmLayerGetById0;

        [NativeTypeName("#define FwpmLayerGetByKey FwpmLayerGetByKey0")]
        public static delegate*<void*, Guid*, FWPM_LAYER0_**, uint> FwpmLayerGetByKey => &FwpmLayerGetByKey0;

        [NativeTypeName("#define FwpmLayerCreateEnumHandle FwpmLayerCreateEnumHandle0")]
        public static delegate*<void*, FWPM_LAYER_ENUM_TEMPLATE0_*, void**, uint> FwpmLayerCreateEnumHandle => &FwpmLayerCreateEnumHandle0;

        [NativeTypeName("#define FwpmLayerEnum FwpmLayerEnum0")]
        public static delegate*<void*, void*, uint, FWPM_LAYER0_***, uint*, uint> FwpmLayerEnum => &FwpmLayerEnum0;

        [NativeTypeName("#define FwpmLayerDestroyEnumHandle FwpmLayerDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmLayerDestroyEnumHandle => &FwpmLayerDestroyEnumHandle0;

        [NativeTypeName("#define FwpmLayerGetSecurityInfoByKey FwpmLayerGetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmLayerGetSecurityInfoByKey => &FwpmLayerGetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmLayerSetSecurityInfoByKey FwpmLayerSetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmLayerSetSecurityInfoByKey => &FwpmLayerSetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmCalloutAdd FwpmCalloutAdd0")]
        public static delegate*<void*, FWPM_CALLOUT0_*, void*, uint*, uint> FwpmCalloutAdd => &FwpmCalloutAdd0;

        [NativeTypeName("#define FwpmCalloutDeleteById FwpmCalloutDeleteById0")]
        public static delegate*<void*, uint, uint> FwpmCalloutDeleteById => &FwpmCalloutDeleteById0;

        [NativeTypeName("#define FwpmCalloutDeleteByKey FwpmCalloutDeleteByKey0")]
        public static delegate*<void*, Guid*, uint> FwpmCalloutDeleteByKey => &FwpmCalloutDeleteByKey0;

        [NativeTypeName("#define FwpmCalloutGetById FwpmCalloutGetById0")]
        public static delegate*<void*, uint, FWPM_CALLOUT0_**, uint> FwpmCalloutGetById => &FwpmCalloutGetById0;

        [NativeTypeName("#define FwpmCalloutGetByKey FwpmCalloutGetByKey0")]
        public static delegate*<void*, Guid*, FWPM_CALLOUT0_**, uint> FwpmCalloutGetByKey => &FwpmCalloutGetByKey0;

        [NativeTypeName("#define FwpmCalloutCreateEnumHandle FwpmCalloutCreateEnumHandle0")]
        public static delegate*<void*, FWPM_CALLOUT_ENUM_TEMPLATE0_*, void**, uint> FwpmCalloutCreateEnumHandle => &FwpmCalloutCreateEnumHandle0;

        [NativeTypeName("#define FwpmCalloutEnum FwpmCalloutEnum0")]
        public static delegate*<void*, void*, uint, FWPM_CALLOUT0_***, uint*, uint> FwpmCalloutEnum => &FwpmCalloutEnum0;

        [NativeTypeName("#define FwpmCalloutDestroyEnumHandle FwpmCalloutDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmCalloutDestroyEnumHandle => &FwpmCalloutDestroyEnumHandle0;

        [NativeTypeName("#define FwpmCalloutGetSecurityInfoByKey FwpmCalloutGetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmCalloutGetSecurityInfoByKey => &FwpmCalloutGetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmCalloutSetSecurityInfoByKey FwpmCalloutSetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmCalloutSetSecurityInfoByKey => &FwpmCalloutSetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmCalloutSubscribeChanges FwpmCalloutSubscribeChanges0")]
        public static delegate*<void*, FWPM_CALLOUT_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, FWPM_CALLOUT_CHANGE0_*, void>, void*, void**, uint> FwpmCalloutSubscribeChanges => &FwpmCalloutSubscribeChanges0;

        [NativeTypeName("#define FwpmCalloutUnsubscribeChanges FwpmCalloutUnsubscribeChanges0")]
        public static delegate*<void*, void*, uint> FwpmCalloutUnsubscribeChanges => &FwpmCalloutUnsubscribeChanges0;

        [NativeTypeName("#define FwpmCalloutSubscriptionsGet FwpmCalloutSubscriptionsGet0")]
        public static delegate*<void*, FWPM_CALLOUT_SUBSCRIPTION0_***, uint*, uint> FwpmCalloutSubscriptionsGet => &FwpmCalloutSubscriptionsGet0;

        [NativeTypeName("#define FwpmFilterAdd FwpmFilterAdd0")]
        public static delegate*<void*, FWPM_FILTER0_*, void*, ulong*, uint> FwpmFilterAdd => &FwpmFilterAdd0;

        [NativeTypeName("#define FwpmFilterDeleteById FwpmFilterDeleteById0")]
        public static delegate*<void*, ulong, uint> FwpmFilterDeleteById => &FwpmFilterDeleteById0;

        [NativeTypeName("#define FwpmFilterDeleteByKey FwpmFilterDeleteByKey0")]
        public static delegate*<void*, Guid*, uint> FwpmFilterDeleteByKey => &FwpmFilterDeleteByKey0;

        [NativeTypeName("#define FwpmFilterGetById FwpmFilterGetById0")]
        public static delegate*<void*, ulong, FWPM_FILTER0_**, uint> FwpmFilterGetById => &FwpmFilterGetById0;

        [NativeTypeName("#define FwpmFilterGetByKey FwpmFilterGetByKey0")]
        public static delegate*<void*, Guid*, FWPM_FILTER0_**, uint> FwpmFilterGetByKey => &FwpmFilterGetByKey0;

        [NativeTypeName("#define FwpmFilterCreateEnumHandle FwpmFilterCreateEnumHandle0")]
        public static delegate*<void*, FWPM_FILTER_ENUM_TEMPLATE0_*, void**, uint> FwpmFilterCreateEnumHandle => &FwpmFilterCreateEnumHandle0;

        [NativeTypeName("#define FwpmFilterEnum FwpmFilterEnum0")]
        public static delegate*<void*, void*, uint, FWPM_FILTER0_***, uint*, uint> FwpmFilterEnum => &FwpmFilterEnum0;

        [NativeTypeName("#define FwpmFilterDestroyEnumHandle FwpmFilterDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmFilterDestroyEnumHandle => &FwpmFilterDestroyEnumHandle0;

        [NativeTypeName("#define FwpmFilterGetSecurityInfoByKey FwpmFilterGetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmFilterGetSecurityInfoByKey => &FwpmFilterGetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmFilterSetSecurityInfoByKey FwpmFilterSetSecurityInfoByKey0")]
        public static delegate*<void*, Guid*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmFilterSetSecurityInfoByKey => &FwpmFilterSetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmFilterSubscribeChanges FwpmFilterSubscribeChanges0")]
        public static delegate*<void*, FWPM_FILTER_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, FWPM_FILTER_CHANGE0_*, void>, void*, void**, uint> FwpmFilterSubscribeChanges => &FwpmFilterSubscribeChanges0;

        [NativeTypeName("#define FwpmFilterUnsubscribeChanges FwpmFilterUnsubscribeChanges0")]
        public static delegate*<void*, void*, uint> FwpmFilterUnsubscribeChanges => &FwpmFilterUnsubscribeChanges0;

        [NativeTypeName("#define FwpmFilterSubscriptionsGet FwpmFilterSubscriptionsGet0")]
        public static delegate*<void*, FWPM_FILTER_SUBSCRIPTION0_***, uint*, uint> FwpmFilterSubscriptionsGet => &FwpmFilterSubscriptionsGet0;

        [NativeTypeName("#define FwpmGetAppIdFromFileName FwpmGetAppIdFromFileName0")]
        public static delegate*<char*, FWP_BYTE_BLOB**, uint> FwpmGetAppIdFromFileName => &FwpmGetAppIdFromFileName0;

        [NativeTypeName("#define FwpmIPsecTunnelAdd FwpmIPsecTunnelAdd3")]
        public static delegate*<void*, uint, FWPM_PROVIDER_CONTEXT3_*, FWPM_PROVIDER_CONTEXT3_*, uint, FWPM_FILTER_CONDITION0_*, Guid*, void*, uint> FwpmIPsecTunnelAdd => &FwpmIPsecTunnelAdd3;

        [NativeTypeName("#define FwpmIPsecTunnelDeleteByKey FwpmIPsecTunnelDeleteByKey0")]
        public static delegate*<void*, Guid*, uint> FwpmIPsecTunnelDeleteByKey => &FwpmIPsecTunnelDeleteByKey0;

        [NativeTypeName("#define IPsecGetStatistics IPsecGetStatistics1")]
        public static delegate*<void*, IPSEC_STATISTICS1_*, uint> IPsecGetStatistics => &IPsecGetStatistics1;

        [NativeTypeName("#define IPsecSaContextCreate IPsecSaContextCreate1")]
        public static delegate*<void*, IPSEC_TRAFFIC1_*, IPSEC_VIRTUAL_IF_TUNNEL_INFO0_*, ulong*, ulong*, uint> IPsecSaContextCreate => &IPsecSaContextCreate1;

        [NativeTypeName("#define IPsecSaContextDeleteById IPsecSaContextDeleteById0")]
        public static delegate*<void*, ulong, uint> IPsecSaContextDeleteById => &IPsecSaContextDeleteById0;

        [NativeTypeName("#define IPsecSaContextGetById IPsecSaContextGetById1")]
        public static delegate*<void*, ulong, IPSEC_SA_CONTEXT1_**, uint> IPsecSaContextGetById => &IPsecSaContextGetById1;

        [NativeTypeName("#define IPsecSaContextGetSpi IPsecSaContextGetSpi1")]
        public static delegate*<void*, ulong, IPSEC_GETSPI1_*, uint*, uint> IPsecSaContextGetSpi => &IPsecSaContextGetSpi1;

        [NativeTypeName("#define IPsecSaContextSetSpi IPsecSaContextSetSpi0")]
        public static delegate*<void*, ulong, IPSEC_GETSPI1_*, uint, uint> IPsecSaContextSetSpi => &IPsecSaContextSetSpi0;

        [NativeTypeName("#define IPsecSaContextAddInbound IPsecSaContextAddInbound1")]
        public static delegate*<void*, ulong, IPSEC_SA_BUNDLE1_*, uint> IPsecSaContextAddInbound => &IPsecSaContextAddInbound1;

        [NativeTypeName("#define IPsecSaContextAddOutbound IPsecSaContextAddOutbound1")]
        public static delegate*<void*, ulong, IPSEC_SA_BUNDLE1_*, uint> IPsecSaContextAddOutbound => &IPsecSaContextAddOutbound1;

        [NativeTypeName("#define IPsecSaContextExpire IPsecSaContextExpire0")]
        public static delegate*<void*, ulong, uint> IPsecSaContextExpire => &IPsecSaContextExpire0;

        [NativeTypeName("#define IPsecSaContextUpdate IPsecSaContextUpdate0")]
        public static delegate*<void*, ulong, IPSEC_SA_CONTEXT1_*, uint> IPsecSaContextUpdate => &IPsecSaContextUpdate0;

        [NativeTypeName("#define IPsecSaContextCreateEnumHandle IPsecSaContextCreateEnumHandle0")]
        public static delegate*<void*, IPSEC_SA_CONTEXT_ENUM_TEMPLATE0_*, void**, uint> IPsecSaContextCreateEnumHandle => &IPsecSaContextCreateEnumHandle0;

        [NativeTypeName("#define IPsecSaContextEnum IPsecSaContextEnum1")]
        public static delegate*<void*, void*, uint, IPSEC_SA_CONTEXT1_***, uint*, uint> IPsecSaContextEnum => &IPsecSaContextEnum1;

        [NativeTypeName("#define IPsecSaContextDestroyEnumHandle IPsecSaContextDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> IPsecSaContextDestroyEnumHandle => &IPsecSaContextDestroyEnumHandle0;

        [NativeTypeName("#define IPsecSaCreateEnumHandle IPsecSaCreateEnumHandle0")]
        public static delegate*<void*, IPSEC_SA_ENUM_TEMPLATE0_*, void**, uint> IPsecSaCreateEnumHandle => &IPsecSaCreateEnumHandle0;

        [NativeTypeName("#define IPsecSaEnum IPsecSaEnum1")]
        public static delegate*<void*, void*, uint, IPSEC_SA_DETAILS1_***, uint*, uint> IPsecSaEnum => &IPsecSaEnum1;

        [NativeTypeName("#define IPsecSaDestroyEnumHandle IPsecSaDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> IPsecSaDestroyEnumHandle => &IPsecSaDestroyEnumHandle0;

        [NativeTypeName("#define IPsecSaDbGetSecurityInfo IPsecSaDbGetSecurityInfo0")]
        public static delegate*<void*, uint, void**, void**, ACL**, ACL**, void**, uint> IPsecSaDbGetSecurityInfo => &IPsecSaDbGetSecurityInfo0;

        [NativeTypeName("#define IPsecSaDbSetSecurityInfo IPsecSaDbSetSecurityInfo0")]
        public static delegate*<void*, uint, SID*, SID*, ACL*, ACL*, uint> IPsecSaDbSetSecurityInfo => &IPsecSaDbSetSecurityInfo0;

        [NativeTypeName("#define IPsecDospGetStatistics IPsecDospGetStatistics0")]
        public static delegate*<void*, IPSEC_DOSP_STATISTICS0_*, uint> IPsecDospGetStatistics => &IPsecDospGetStatistics0;

        [NativeTypeName("#define IPsecDospStateCreateEnumHandle IPsecDospStateCreateEnumHandle0")]
        public static delegate*<void*, IPSEC_DOSP_STATE_ENUM_TEMPLATE0_*, void**, uint> IPsecDospStateCreateEnumHandle => &IPsecDospStateCreateEnumHandle0;

        [NativeTypeName("#define IPsecDospStateEnum IPsecDospStateEnum0")]
        public static delegate*<void*, void*, uint, IPSEC_DOSP_STATE0_***, uint*, uint> IPsecDospStateEnum => &IPsecDospStateEnum0;

        [NativeTypeName("#define IPsecDospStateDestroyEnumHandle IPsecDospStateDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> IPsecDospStateDestroyEnumHandle => &IPsecDospStateDestroyEnumHandle0;

        [NativeTypeName("#define IPsecDospGetSecurityInfo IPsecDospGetSecurityInfo0")]
        public static delegate*<void*, uint, void**, void**, ACL**, ACL**, void**, uint> IPsecDospGetSecurityInfo => &IPsecDospGetSecurityInfo0;

        [NativeTypeName("#define IPsecDospSetSecurityInfo IPsecDospSetSecurityInfo0")]
        public static delegate*<void*, uint, SID*, SID*, ACL*, ACL*, uint> IPsecDospSetSecurityInfo => &IPsecDospSetSecurityInfo0;

        [NativeTypeName("#define IkeextGetStatistics IkeextGetStatistics1")]
        public static delegate*<void*, IKEEXT_STATISTICS1_*, uint> IkeextGetStatistics => &IkeextGetStatistics1;

        [NativeTypeName("#define IkeextSaDeleteById IkeextSaDeleteById0")]
        public static delegate*<void*, ulong, uint> IkeextSaDeleteById => &IkeextSaDeleteById0;

        [NativeTypeName("#define IkeextSaGetById IkeextSaGetById2")]
        public static delegate*<void*, ulong, Guid*, IKEEXT_SA_DETAILS2_**, uint> IkeextSaGetById => &IkeextSaGetById2;

        [NativeTypeName("#define IkeextSaCreateEnumHandle IkeextSaCreateEnumHandle0")]
        public static delegate*<void*, IKEEXT_SA_ENUM_TEMPLATE0_*, void**, uint> IkeextSaCreateEnumHandle => &IkeextSaCreateEnumHandle0;

        [NativeTypeName("#define IkeextSaEnum IkeextSaEnum2")]
        public static delegate*<void*, void*, uint, IKEEXT_SA_DETAILS2_***, uint*, uint> IkeextSaEnum => &IkeextSaEnum2;

        [NativeTypeName("#define IkeextSaDestroyEnumHandle IkeextSaDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> IkeextSaDestroyEnumHandle => &IkeextSaDestroyEnumHandle0;

        [NativeTypeName("#define IkeextSaDbGetSecurityInfo IkeextSaDbGetSecurityInfo0")]
        public static delegate*<void*, uint, void**, void**, ACL**, ACL**, void**, uint> IkeextSaDbGetSecurityInfo => &IkeextSaDbGetSecurityInfo0;

        [NativeTypeName("#define IkeextSaDbSetSecurityInfo IkeextSaDbSetSecurityInfo0")]
        public static delegate*<void*, uint, SID*, SID*, ACL*, ACL*, uint> IkeextSaDbSetSecurityInfo => &IkeextSaDbSetSecurityInfo0;

        [NativeTypeName("#define FwpmNetEventCreateEnumHandle FwpmNetEventCreateEnumHandle0")]
        public static delegate*<void*, FWPM_NET_EVENT_ENUM_TEMPLATE0_*, void**, uint> FwpmNetEventCreateEnumHandle => &FwpmNetEventCreateEnumHandle0;

        [NativeTypeName("#define FwpmNetEventEnum FwpmNetEventEnum5")]
        public static delegate*<void*, void*, uint, FWPM_NET_EVENT5_***, uint*, uint> FwpmNetEventEnum => &FwpmNetEventEnum5;

        [NativeTypeName("#define FwpmNetEventDestroyEnumHandle FwpmNetEventDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmNetEventDestroyEnumHandle => &FwpmNetEventDestroyEnumHandle0;

        [NativeTypeName("#define FwpmNetEventsGetSecurityInfo FwpmNetEventsGetSecurityInfo0")]
        public static delegate*<void*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmNetEventsGetSecurityInfo => &FwpmNetEventsGetSecurityInfo0;

        [NativeTypeName("#define FwpmNetEventsSetSecurityInfo FwpmNetEventsSetSecurityInfo0")]
        public static delegate*<void*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmNetEventsSetSecurityInfo => &FwpmNetEventsSetSecurityInfo0;

        [NativeTypeName("#define FwpmNetEventSubscribe FwpmNetEventSubscribe4")]
        public static delegate*<void*, FWPM_NET_EVENT_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, FWPM_NET_EVENT5_*, void>, void*, void**, uint> FwpmNetEventSubscribe => &FwpmNetEventSubscribe4;

        [NativeTypeName("#define FwpmNetEventUnsubscribe FwpmNetEventUnsubscribe0")]
        public static delegate*<void*, void*, uint> FwpmNetEventUnsubscribe => &FwpmNetEventUnsubscribe0;

        [NativeTypeName("#define FwpmNetEventSubscriptionsGet FwpmNetEventSubscriptionsGet0")]
        public static delegate*<void*, FWPM_NET_EVENT_SUBSCRIPTION0_***, uint*, uint> FwpmNetEventSubscriptionsGet => &FwpmNetEventSubscriptionsGet0;

        [NativeTypeName("#define FwpmSystemPortsGet FwpmSystemPortsGet0")]
        public static delegate*<void*, FWPM_SYSTEM_PORTS0_**, uint> FwpmSystemPortsGet => &FwpmSystemPortsGet0;

        [NativeTypeName("#define FwpmSystemPortsSubscribe FwpmSystemPortsSubscribe0")]
        public static delegate*<void*, void*, delegate* unmanaged[Stdcall]<void*, FWPM_SYSTEM_PORTS0_*, void>, void*, void**, uint> FwpmSystemPortsSubscribe => &FwpmSystemPortsSubscribe0;

        [NativeTypeName("#define FwpmSystemPortsUnsubscribe FwpmSystemPortsUnsubscribe0")]
        public static delegate*<void*, void*, uint> FwpmSystemPortsUnsubscribe => &FwpmSystemPortsUnsubscribe0;

        [NativeTypeName("#define FwpmDynamicKeywordSubscribe FwpmDynamicKeywordSubscribe0")]
        public static delegate*<uint, delegate* unmanaged[Stdcall]<void*, void*, void>, void*, void**, uint> FwpmDynamicKeywordSubscribe => &FwpmDynamicKeywordSubscribe0;

        [NativeTypeName("#define IPsecKeyManagerAddAndRegister IPsecKeyManagerAddAndRegister0")]
        public static delegate*<void*, _IPSEC_KEY_MANAGER0*, _IPSEC_KEY_MANAGER_CALLBACKS0*, void**, uint> IPsecKeyManagerAddAndRegister => &IPsecKeyManagerAddAndRegister0;

        [NativeTypeName("#define IPsecKeyManagerUnregisterAndDelete IPsecKeyManagerUnregisterAndDelete0")]
        public static delegate*<void*, void*, uint> IPsecKeyManagerUnregisterAndDelete => &IPsecKeyManagerUnregisterAndDelete0;

        [NativeTypeName("#define IPsecKeyManagersGet IPsecKeyManagersGet0")]
        public static delegate*<void*, _IPSEC_KEY_MANAGER0***, uint*, uint> IPsecKeyManagersGet => &IPsecKeyManagersGet0;

        [NativeTypeName("#define IPsecKeyManagerGetSecurityInfoByKey IPsecKeyManagerGetSecurityInfoByKey0")]
        public static delegate*<void*, void*, uint, void**, void**, ACL**, ACL**, void**, uint> IPsecKeyManagerGetSecurityInfoByKey => &IPsecKeyManagerGetSecurityInfoByKey0;

        [NativeTypeName("#define IPsecKeyManagerSetSecurityInfoByKey IPsecKeyManagerSetSecurityInfoByKey0")]
        public static delegate*<void*, void*, uint, SID*, SID*, ACL*, ACL*, uint> IPsecKeyManagerSetSecurityInfoByKey => &IPsecKeyManagerSetSecurityInfoByKey0;

        [NativeTypeName("#define FwpmConnectionSubscribe FwpmConnectionSubscribe0")]
        public static delegate*<void*, FWPM_CONNECTION_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, FWPM_CONNECTION_EVENT_TYPE_, FWPM_CONNECTION0_*, void>, void*, void**, uint> FwpmConnectionSubscribe => &FwpmConnectionSubscribe0;

        [NativeTypeName("#define FwpmConnectionUnsubscribe FwpmConnectionUnsubscribe0")]
        public static delegate*<void*, void*, uint> FwpmConnectionUnsubscribe => &FwpmConnectionUnsubscribe0;

        [NativeTypeName("#define FwpmConnectionGetById FwpmConnectionGetById0")]
        public static delegate*<void*, ulong, FWPM_CONNECTION0_**, uint> FwpmConnectionGetById => &FwpmConnectionGetById0;

        [NativeTypeName("#define FwpmConnectionEnum FwpmConnectionEnum0")]
        public static delegate*<void*, void*, uint, FWPM_CONNECTION0_***, uint*, uint> FwpmConnectionEnum => &FwpmConnectionEnum0;

        [NativeTypeName("#define FwpmConnectionCreateEnumHandle FwpmConnectionCreateEnumHandle0")]
        public static delegate*<void*, FWPM_CONNECTION_ENUM_TEMPLATE0_*, void**, uint> FwpmConnectionCreateEnumHandle => &FwpmConnectionCreateEnumHandle0;

        [NativeTypeName("#define FwpmConnectionDestroyEnumHandle FwpmConnectionDestroyEnumHandle0")]
        public static delegate*<void*, void*, uint> FwpmConnectionDestroyEnumHandle => &FwpmConnectionDestroyEnumHandle0;

        [NativeTypeName("#define FwpmConnectionSubscriptionsGet FwpmConnectionSubscriptionsGet0")]
        public static delegate*<void*, FWPM_CONNECTION_SUBSCRIPTION0_***, uint*, uint> FwpmConnectionSubscriptionsGet => &FwpmConnectionSubscriptionsGet0;

        [NativeTypeName("#define FwpmConnectionGetSecurityInfo FwpmConnectionGetSecurityInfo0")]
        public static delegate*<void*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmConnectionGetSecurityInfo => &FwpmConnectionGetSecurityInfo0;

        [NativeTypeName("#define FwpmConnectionSetSecurityInfo FwpmConnectionSetSecurityInfo0")]
        public static delegate*<void*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmConnectionSetSecurityInfo => &FwpmConnectionSetSecurityInfo0;

        [NativeTypeName("#define FwpmvSwitchEventSubscribe FwpmvSwitchEventSubscribe0")]
        public static delegate*<void*, FWPM_VSWITCH_EVENT_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, FWPM_VSWITCH_EVENT0_*, uint>, void*, void**, uint> FwpmvSwitchEventSubscribe => &FwpmvSwitchEventSubscribe0;

        [NativeTypeName("#define FwpmvSwitchEventUnsubscribe FwpmvSwitchEventUnsubscribe0")]
        public static delegate*<void*, void*, uint> FwpmvSwitchEventUnsubscribe => &FwpmvSwitchEventUnsubscribe0;

        [NativeTypeName("#define FwpmvSwitchEventsGetSecurityInfo FwpmvSwitchEventsGetSecurityInfo0")]
        public static delegate*<void*, uint, void**, void**, ACL**, ACL**, void**, uint> FwpmvSwitchEventsGetSecurityInfo => &FwpmvSwitchEventsGetSecurityInfo0;

        [NativeTypeName("#define FwpmvSwitchEventsSetSecurityInfo FwpmvSwitchEventsSetSecurityInfo0")]
        public static delegate*<void*, uint, SID*, SID*, ACL*, ACL*, uint> FwpmvSwitchEventsSetSecurityInfo => &FwpmvSwitchEventsSetSecurityInfo0;

        [NativeTypeName("#define IPsecSaContextSubscribe IPsecSaContextSubscribe0")]
        public static delegate*<void*, IPSEC_SA_CONTEXT_SUBSCRIPTION0_*, delegate* unmanaged[Stdcall]<void*, IPSEC_SA_CONTEXT_CHANGE0_*, void>, void*, void**, uint> IPsecSaContextSubscribe => &IPsecSaContextSubscribe0;

        [NativeTypeName("#define IPsecSaContextUnsubscribe IPsecSaContextUnsubscribe0")]
        public static delegate*<void*, void*, uint> IPsecSaContextUnsubscribe => &IPsecSaContextUnsubscribe0;

        [NativeTypeName("#define IPsecSaContextSubscriptionsGet IPsecSaContextSubscriptionsGet0")]
        public static delegate*<void*, IPSEC_SA_CONTEXT_SUBSCRIPTION0_***, uint*, uint> IPsecSaContextSubscriptionsGet => &IPsecSaContextSubscriptionsGet0;

        [NativeTypeName("#define FwpmConnectionPolicyAdd FwpmConnectionPolicyAdd0")]
        public static delegate*<void*, FWPM_PROVIDER_CONTEXT3_*, FWP_IP_VERSION_, ulong, uint, FWPM_FILTER_CONDITION0_*, void*, uint> FwpmConnectionPolicyAdd => &FwpmConnectionPolicyAdd0;

        [NativeTypeName("#define FwpmConnectionPolicyDeleteByKey FwpmConnectionPolicyDeleteByKey0")]
        public static delegate*<void*, Guid*, uint> FwpmConnectionPolicyDeleteByKey => &FwpmConnectionPolicyDeleteByKey0;

        [NativeTypeName("#define FWPM_AUTO_WEIGHT_BITS (60)")]
        public const int FWPM_AUTO_WEIGHT_BITS = (60);

        [NativeTypeName("#define FWPM_AUTO_WEIGHT_MAX (MAXUINT64 >> (64 - FWPM_AUTO_WEIGHT_BITS))")]
        public const ulong FWPM_AUTO_WEIGHT_MAX = (((ulong)(~((ulong)(0)))) >> (64 - (60)));

        [NativeTypeName("#define FWPM_WEIGHT_RANGE_MAX (MAXUINT64 >> FWPM_AUTO_WEIGHT_BITS)")]
        public const ulong FWPM_WEIGHT_RANGE_MAX = (((ulong)(~((ulong)(0)))) >> (60));

        [NativeTypeName("#define FWPM_WEIGHT_RANGE_IPSEC (0x0)")]
        public const int FWPM_WEIGHT_RANGE_IPSEC = (0x0);

        [NativeTypeName("#define FWPM_WEIGHT_RANGE_IKE_EXEMPTIONS (0xc)")]
        public const int FWPM_WEIGHT_RANGE_IKE_EXEMPTIONS = (0xc);

        [NativeTypeName("#define FWPM_CONTEXT_IPSEC_INBOUND_PASSTHRU (0x1ui64)")]
        public const ulong FWPM_CONTEXT_IPSEC_INBOUND_PASSTHRU = (0x1UL);

        [NativeTypeName("#define FWPM_CONTEXT_IPSEC_INBOUND_PERSIST_CONNECTION_SECURITY (0x2ui64)")]
        public const ulong FWPM_CONTEXT_IPSEC_INBOUND_PERSIST_CONNECTION_SECURITY = (0x2UL);

        [NativeTypeName("#define FWPM_CONTEXT_IPSEC_INBOUND_RESERVED (0xff00000000000000ui64)")]
        public const ulong FWPM_CONTEXT_IPSEC_INBOUND_RESERVED = (0xff00000000000000UL);

        [NativeTypeName("#define FWPM_CONTEXT_IPSEC_INBOUND_SECURITY_REALM_ID (0x4ui64)")]
        public const ulong FWPM_CONTEXT_IPSEC_INBOUND_SECURITY_REALM_ID = (0x4UL);

        [NativeTypeName("#define FWPM_CONTEXT_IPSEC_OUTBOUND_NEGOTIATE_DISCOVER (0x1ui64)")]
        public const ulong FWPM_CONTEXT_IPSEC_OUTBOUND_NEGOTIATE_DISCOVER = (0x1UL);

        [NativeTypeName("#define FWPM_CONTEXT_IPSEC_OUTBOUND_SUPPRESS_NEGOTIATION (0x2ui64)")]
        public const ulong FWPM_CONTEXT_IPSEC_OUTBOUND_SUPPRESS_NEGOTIATION = (0x2UL);

        [NativeTypeName("#define FWPM_CONTEXT_IPSEC_OUTBOUNDBOUND_SECURITY_REALM_ID (0x4ui64)")]
        public const ulong FWPM_CONTEXT_IPSEC_OUTBOUNDBOUND_SECURITY_REALM_ID = (0x4UL);

        [NativeTypeName("#define FWPM_CONTEXT_ALE_SET_CONNECTION_REQUIRE_IPSEC_SECURITY (0x2ui64)")]
        public const ulong FWPM_CONTEXT_ALE_SET_CONNECTION_REQUIRE_IPSEC_SECURITY = (0x2UL);

        [NativeTypeName("#define FWPM_CONTEXT_ALE_SET_CONNECTION_LAZY_SD_EVALUATION (0x4ui64)")]
        public const ulong FWPM_CONTEXT_ALE_SET_CONNECTION_LAZY_SD_EVALUATION = (0x4UL);

        [NativeTypeName("#define FWPM_CONTEXT_ALE_SET_CONNECTION_REQUIRE_IPSEC_ENCRYPTION (0x8ui64)")]
        public const ulong FWPM_CONTEXT_ALE_SET_CONNECTION_REQUIRE_IPSEC_ENCRYPTION = (0x8UL);

        [NativeTypeName("#define FWPM_CONTEXT_ALE_SET_CONNECTION_ALLOW_FIRST_INBOUND_PKT_UNENCRYPTED (0x10ui64)")]
        public const ulong FWPM_CONTEXT_ALE_SET_CONNECTION_ALLOW_FIRST_INBOUND_PKT_UNENCRYPTED = (0x10UL);

        [NativeTypeName("#define FWPM_CONTEXT_ALE_ALLOW_AUTH_FW (0x20ui64)")]
        public const ulong FWPM_CONTEXT_ALE_ALLOW_AUTH_FW = (0x20UL);

        [NativeTypeName("#define FWPM_CONTEXT_TCP_CHIMNEY_OFFLOAD_ENABLE (0x1ui64)")]
        public const ulong FWPM_CONTEXT_TCP_CHIMNEY_OFFLOAD_ENABLE = (0x1UL);

        [NativeTypeName("#define FWPM_CONTEXT_TCP_CHIMNEY_OFFLOAD_DISABLE (0x2ui64)")]
        public const ulong FWPM_CONTEXT_TCP_CHIMNEY_OFFLOAD_DISABLE = (0x2UL);

        [NativeTypeName("#define FWPM_CONTEXT_RPC_AUDIT_ENABLED (0x1ui64)")]
        public const ulong FWPM_CONTEXT_RPC_AUDIT_ENABLED = (0x1UL);

        [NativeTypeName("#define FWPM_CONTEXT_RPC_AUDIT_BUFFER_ENABLED (0x2ui64)")]
        public const ulong FWPM_CONTEXT_RPC_AUDIT_BUFFER_ENABLED = (0x2UL);

        [NativeTypeName("#define FWPM_ACTRL_ADD (0x00000001)")]
        public const int FWPM_ACTRL_ADD = (0x00000001);

        [NativeTypeName("#define FWPM_ACTRL_ADD_LINK (0x00000002)")]
        public const int FWPM_ACTRL_ADD_LINK = (0x00000002);

        [NativeTypeName("#define FWPM_ACTRL_BEGIN_READ_TXN (0x00000004)")]
        public const int FWPM_ACTRL_BEGIN_READ_TXN = (0x00000004);

        [NativeTypeName("#define FWPM_ACTRL_BEGIN_WRITE_TXN (0x00000008)")]
        public const int FWPM_ACTRL_BEGIN_WRITE_TXN = (0x00000008);

        [NativeTypeName("#define FWPM_ACTRL_CLASSIFY (0x00000010)")]
        public const int FWPM_ACTRL_CLASSIFY = (0x00000010);

        [NativeTypeName("#define FWPM_ACTRL_ENUM (0x00000020)")]
        public const int FWPM_ACTRL_ENUM = (0x00000020);

        [NativeTypeName("#define FWPM_ACTRL_OPEN (0x00000040)")]
        public const int FWPM_ACTRL_OPEN = (0x00000040);

        [NativeTypeName("#define FWPM_ACTRL_READ (0x00000080)")]
        public const int FWPM_ACTRL_READ = (0x00000080);

        [NativeTypeName("#define FWPM_ACTRL_READ_STATS (0x00000100)")]
        public const int FWPM_ACTRL_READ_STATS = (0x00000100);

        [NativeTypeName("#define FWPM_ACTRL_SUBSCRIBE (0x00000200)")]
        public const int FWPM_ACTRL_SUBSCRIBE = (0x00000200);

        [NativeTypeName("#define FWPM_ACTRL_WRITE (0x00000400)")]
        public const int FWPM_ACTRL_WRITE = (0x00000400);

        [NativeTypeName("#define FWPM_GENERIC_READ ( STANDARD_RIGHTS_READ       | \\\r\n        FWPM_ACTRL_BEGIN_READ_TXN  | \\\r\n        FWPM_ACTRL_CLASSIFY        | \\\r\n        FWPM_ACTRL_OPEN            | \\\r\n        FWPM_ACTRL_READ            | \\\r\n        FWPM_ACTRL_READ_STATS      )")]
        public const int FWPM_GENERIC_READ = (((0x00020000)) | (0x00000004) | (0x00000010) | (0x00000040) | (0x00000080) | (0x00000100));

        [NativeTypeName("#define FWPM_GENERIC_EXECUTE ( STANDARD_RIGHTS_EXECUTE    | \\\r\n        FWPM_ACTRL_ENUM            | \\\r\n        FWPM_ACTRL_SUBSCRIBE       )")]
        public const int FWPM_GENERIC_EXECUTE = (((0x00020000)) | (0x00000020) | (0x00000200));

        [NativeTypeName("#define FWPM_GENERIC_WRITE ( STANDARD_RIGHTS_WRITE      | \\\r\n        DELETE                     | \\\r\n        FWPM_ACTRL_ADD             | \\\r\n        FWPM_ACTRL_ADD_LINK        | \\\r\n        FWPM_ACTRL_BEGIN_WRITE_TXN | \\\r\n        FWPM_ACTRL_WRITE           )")]
        public const int FWPM_GENERIC_WRITE = (((0x00020000)) | (0x00010000) | (0x00000001) | (0x00000002) | (0x00000008) | (0x00000400));

        [NativeTypeName("#define FWPM_GENERIC_ALL ( STANDARD_RIGHTS_REQUIRED   | \\\r\n        FWPM_ACTRL_ADD             | \\\r\n        FWPM_ACTRL_ADD_LINK        | \\\r\n        FWPM_ACTRL_BEGIN_READ_TXN  | \\\r\n        FWPM_ACTRL_BEGIN_WRITE_TXN | \\\r\n        FWPM_ACTRL_CLASSIFY        | \\\r\n        FWPM_ACTRL_ENUM            | \\\r\n        FWPM_ACTRL_OPEN            | \\\r\n        FWPM_ACTRL_READ            | \\\r\n        FWPM_ACTRL_READ_STATS      | \\\r\n        FWPM_ACTRL_SUBSCRIBE       | \\\r\n        FWPM_ACTRL_WRITE           )")]
        public const int FWPM_GENERIC_ALL = ((0x000F0000) | (0x00000001) | (0x00000002) | (0x00000004) | (0x00000008) | (0x00000010) | (0x00000020) | (0x00000040) | (0x00000080) | (0x00000100) | (0x00000200) | (0x00000400));

        [NativeTypeName("#define FWPM_TXN_READ_ONLY (0x00000001)")]
        public const int FWPM_TXN_READ_ONLY = (0x00000001);

        [NativeTypeName("#define FWPM_TUNNEL_FLAG_POINT_TO_POINT (0x00000001)")]
        public const int FWPM_TUNNEL_FLAG_POINT_TO_POINT = (0x00000001);

        [NativeTypeName("#define FWPM_TUNNEL_FLAG_ENABLE_VIRTUAL_IF_TUNNELING (0x00000002)")]
        public const int FWPM_TUNNEL_FLAG_ENABLE_VIRTUAL_IF_TUNNELING = (0x00000002);

        [NativeTypeName("#define FWPM_TUNNEL_FLAG_RESERVED0 (0x00000004)")]
        public const int FWPM_TUNNEL_FLAG_RESERVED0 = (0x00000004);

        [NativeTypeName("#define IPSEC_SA_DETAILS_UPDATE_TRAFFIC (0x01ui64)")]
        public const ulong IPSEC_SA_DETAILS_UPDATE_TRAFFIC = (0x01UL);

        [NativeTypeName("#define IPSEC_SA_DETAILS_UPDATE_UDP_ENCAPSULATION (0x02ui64)")]
        public const ulong IPSEC_SA_DETAILS_UPDATE_UDP_ENCAPSULATION = (0x02UL);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_UPDATE_FLAGS (0x04ui64)")]
        public const ulong IPSEC_SA_BUNDLE_UPDATE_FLAGS = (0x04UL);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_UPDATE_NAP_CONTEXT (0x08ui64)")]
        public const ulong IPSEC_SA_BUNDLE_UPDATE_NAP_CONTEXT = (0x08UL);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_UPDATE_KEY_MODULE_STATE (0x10ui64)")]
        public const ulong IPSEC_SA_BUNDLE_UPDATE_KEY_MODULE_STATE = (0x10UL);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_UPDATE_PEER_V4_PRIVATE_ADDRESS (0x20ui64)")]
        public const ulong IPSEC_SA_BUNDLE_UPDATE_PEER_V4_PRIVATE_ADDRESS = (0x20UL);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_UPDATE_MM_SA_ID (0x40ui64)")]
        public const ulong IPSEC_SA_BUNDLE_UPDATE_MM_SA_ID = (0x40UL);

        [NativeTypeName("#define FWPM_NOTIFY_ADDRESSES_AUTO_RESOLVE 0x01ui64")]
        public const ulong FWPM_NOTIFY_ADDRESSES_AUTO_RESOLVE = 0x01UL;

        [NativeTypeName("#define FWPM_NOTIFY_ADDRESSES_NON_AUTO_RESOLVE 0x02ui64")]
        public const ulong FWPM_NOTIFY_ADDRESSES_NON_AUTO_RESOLVE = 0x02UL;

        [NativeTypeName("#define FWPM_NOTIFY_ADDRESSES_ALL (FWPM_NOTIFY_ADDRESSES_AUTO_RESOLVE | FWPM_NOTIFY_ADDRESSES_NON_AUTO_RESOLVE)")]
        public const ulong FWPM_NOTIFY_ADDRESSES_ALL = (0x01UL | 0x02UL);

        [NativeTypeName("#define FWPM_NOTIFY_GRANULAR 0x04ui64")]
        public const ulong FWPM_NOTIFY_GRANULAR = 0x04UL;
    }
}
