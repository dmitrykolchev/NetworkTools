using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.WinDivert.Native
{
    public enum WINDIVERT_LAYER
    {
        WINDIVERT_LAYER_NETWORK = 0,
        WINDIVERT_LAYER_NETWORK_FORWARD = 1,
        WINDIVERT_LAYER_FLOW = 2,
        WINDIVERT_LAYER_SOCKET = 3,
        WINDIVERT_LAYER_REFLECT = 4,
    }

    public partial struct DataNetwork
    {
        [NativeTypeName("UINT32")]
        public uint IfIdx;

        [NativeTypeName("UINT32")]
        public uint SubIfIdx;
    }

    public partial struct DataFlow
    {
        [NativeTypeName("UINT64")]
        public ulong EndpointId;

        [NativeTypeName("UINT64")]
        public ulong ParentEndpointId;

        [NativeTypeName("UINT32")]
        public uint ProcessId;

        [NativeTypeName("UINT32[4]")]
        public _LocalAddr_e__FixedBuffer LocalAddr;

        [NativeTypeName("UINT32[4]")]
        public _RemoteAddr_e__FixedBuffer RemoteAddr;

        [NativeTypeName("UINT16")]
        public ushort LocalPort;

        [NativeTypeName("UINT16")]
        public ushort RemotePort;

        [NativeTypeName("UINT8")]
        public byte Protocol;

        [InlineArray(4)]
        public partial struct _LocalAddr_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(4)]
        public partial struct _RemoteAddr_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct DataSocket
    {
        [NativeTypeName("UINT64")]
        public ulong EndpointId;

        [NativeTypeName("UINT64")]
        public ulong ParentEndpointId;

        [NativeTypeName("UINT32")]
        public uint ProcessId;

        [NativeTypeName("UINT32[4]")]
        public _LocalAddr_e__FixedBuffer LocalAddr;

        [NativeTypeName("UINT32[4]")]
        public _RemoteAddr_e__FixedBuffer RemoteAddr;

        [NativeTypeName("UINT16")]
        public ushort LocalPort;

        [NativeTypeName("UINT16")]
        public ushort RemotePort;

        [NativeTypeName("UINT8")]
        public byte Protocol;

        [InlineArray(4)]
        public partial struct _LocalAddr_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(4)]
        public partial struct _RemoteAddr_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct DataReflect
    {
        [NativeTypeName("INT64")]
        public long Timestamp;

        [NativeTypeName("UINT32")]
        public uint ProcessId;

        public WINDIVERT_LAYER Layer;

        [NativeTypeName("UINT64")]
        public ulong Flags;

        [NativeTypeName("INT16")]
        public short Priority;
    }

    public partial struct Address
    {
        [NativeTypeName("INT64")]
        public long Timestamp;

        public uint _bitfield;

        [NativeTypeName("UINT32 : 8")]
        public uint Layer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return _bitfield & 0xFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu);
            }
        }

        [NativeTypeName("UINT32 : 8")]
        public uint Event
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 8) & 0xFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFu << 8)) | ((value & 0xFFu) << 8);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint Sniffed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 16) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint Outbound
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 17) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint Loopback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 18) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint Impostor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 19) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint IPv6
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 20) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint IPChecksum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 21) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint TCPChecksum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 22) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 22)) | ((value & 0x1u) << 22);
            }
        }

        [NativeTypeName("UINT32 : 1")]
        public uint UDPChecksum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 23) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 23)) | ((value & 0x1u) << 23);
            }
        }

        [NativeTypeName("UINT32 : 8")]
        public uint Reserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (_bitfield >> 24) & 0xFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
            }
        }

        [NativeTypeName("UINT32")]
        public uint Reserved2;

        [NativeTypeName("__AnonymousRecord_windivert_L157_C5")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref DataNetwork Network
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Network;
            }
        }

        [UnscopedRef]
        public ref DataFlow Flow
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Flow;
            }
        }

        [UnscopedRef]
        public ref DataSocket Socket
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Socket;
            }
        }

        [UnscopedRef]
        public ref DataReflect Reflect
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.Reflect;
            }
        }

        [UnscopedRef]
        public Span<byte> Reserved3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Reserved3;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("WINDIVERT_DATA_NETWORK")]
            public DataNetwork Network;

            [FieldOffset(0)]
            [NativeTypeName("WINDIVERT_DATA_FLOW")]
            public DataFlow Flow;

            [FieldOffset(0)]
            [NativeTypeName("WINDIVERT_DATA_SOCKET")]
            public DataSocket Socket;

            [FieldOffset(0)]
            [NativeTypeName("WINDIVERT_DATA_REFLECT")]
            public DataReflect Reflect;

            [FieldOffset(0)]
            [NativeTypeName("UINT8[64]")]
            public _Reserved3_e__FixedBuffer Reserved3;

            [InlineArray(64)]
            public partial struct _Reserved3_e__FixedBuffer
            {
                public byte e0;
            }
        }
    }

    public enum WINDIVERT_EVENT
    {
        WINDIVERT_EVENT_NETWORK_PACKET = 0,
        WINDIVERT_EVENT_FLOW_ESTABLISHED = 1,
        WINDIVERT_EVENT_FLOW_DELETED = 2,
        WINDIVERT_EVENT_SOCKET_BIND = 3,
        WINDIVERT_EVENT_SOCKET_CONNECT = 4,
        WINDIVERT_EVENT_SOCKET_LISTEN = 5,
        WINDIVERT_EVENT_SOCKET_ACCEPT = 6,
        WINDIVERT_EVENT_SOCKET_CLOSE = 7,
        WINDIVERT_EVENT_REFLECT_OPEN = 8,
        WINDIVERT_EVENT_REFLECT_CLOSE = 9,
    }

    public enum WINDIVERT_PARAM
    {
        WINDIVERT_PARAM_QUEUE_LENGTH = 0,
        WINDIVERT_PARAM_QUEUE_TIME = 1,
        WINDIVERT_PARAM_QUEUE_SIZE = 2,
        WINDIVERT_PARAM_VERSION_MAJOR = 3,
        WINDIVERT_PARAM_VERSION_MINOR = 4,
    }

    public enum WINDIVERT_SHUTDOWN
    {
        WINDIVERT_SHUTDOWN_RECV = 0x1,
        WINDIVERT_SHUTDOWN_SEND = 0x2,
        WINDIVERT_SHUTDOWN_BOTH = 0x3,
    }

    public partial struct IpV4Header
    {
        public byte _bitfield;

        [NativeTypeName("UINT8 : 4")]
        public byte HdrLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UINT8 : 4")]
        public byte Version
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield >> 4) & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (byte)((_bitfield & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }

        [NativeTypeName("UINT8")]
        public byte TOS;

        [NativeTypeName("UINT16")]
        public ushort Length;

        [NativeTypeName("UINT16")]
        public ushort Id;

        [NativeTypeName("UINT16")]
        public ushort FragOff0;

        [NativeTypeName("UINT8")]
        public byte TTL;

        [NativeTypeName("UINT8")]
        public byte Protocol;

        [NativeTypeName("UINT16")]
        public ushort Checksum;

        [NativeTypeName("UINT32")]
        public uint SrcAddr;

        [NativeTypeName("UINT32")]
        public uint DstAddr;
    }

    public partial struct IpV6Header
    {
        public byte _bitfield1;

        [NativeTypeName("UINT8 : 4")]
        public byte TrafficClass0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield1 & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (byte)((_bitfield1 & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UINT8 : 4")]
        public byte Version
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield1 >> 4) & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (byte)((_bitfield1 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }

        public byte _bitfield2;

        [NativeTypeName("UINT8 : 4")]
        public byte FlowLabel0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)(_bitfield2 & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (byte)((_bitfield2 & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UINT8 : 4")]
        public byte TrafficClass1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (byte)((_bitfield2 >> 4) & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (byte)((_bitfield2 & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }

        [NativeTypeName("UINT16")]
        public ushort FlowLabel1;

        [NativeTypeName("UINT16")]
        public ushort Length;

        [NativeTypeName("UINT8")]
        public byte NextHdr;

        [NativeTypeName("UINT8")]
        public byte HopLimit;

        [NativeTypeName("UINT32[4]")]
        public _SrcAddr_e__FixedBuffer SrcAddr;

        [NativeTypeName("UINT32[4]")]
        public _DstAddr_e__FixedBuffer DstAddr;

        [InlineArray(4)]
        public partial struct _SrcAddr_e__FixedBuffer
        {
            public uint e0;
        }

        [InlineArray(4)]
        public partial struct _DstAddr_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct IcmpV4Header
    {
        [NativeTypeName("UINT8")]
        public byte Type;

        [NativeTypeName("UINT8")]
        public byte Code;

        [NativeTypeName("UINT16")]
        public ushort Checksum;

        [NativeTypeName("UINT32")]
        public uint Body;
    }

    public partial struct IcmpV6Header
    {
        [NativeTypeName("UINT8")]
        public byte Type;

        [NativeTypeName("UINT8")]
        public byte Code;

        [NativeTypeName("UINT16")]
        public ushort Checksum;

        [NativeTypeName("UINT32")]
        public uint Body;
    }

    public partial struct TcpHeader
    {
        [NativeTypeName("UINT16")]
        public ushort SrcPort;

        [NativeTypeName("UINT16")]
        public ushort DstPort;

        [NativeTypeName("UINT32")]
        public uint SeqNum;

        [NativeTypeName("UINT32")]
        public uint AckNum;

        public ushort _bitfield;

        [NativeTypeName("UINT16 : 4")]
        public ushort Reserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)(_bitfield & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~0xFu) | (value & 0xFu));
            }
        }

        [NativeTypeName("UINT16 : 4")]
        public ushort HdrLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 4) & 0xFu);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0xFu << 4)) | ((value & 0xFu) << 4));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort Fin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 8) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort Syn
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 9) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 9)) | ((value & 0x1u) << 9));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort Rst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 10) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 10)) | ((value & 0x1u) << 10));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort Psh
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 11) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 11)) | ((value & 0x1u) << 11));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort Ack
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 12) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12));
            }
        }

        [NativeTypeName("UINT16 : 1")]
        public ushort Urg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 13) & 0x1u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13));
            }
        }

        [NativeTypeName("UINT16 : 2")]
        public ushort Reserved2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return (ushort)((_bitfield >> 14) & 0x3u);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (ushort)((_bitfield & ~(0x3u << 14)) | ((value & 0x3u) << 14));
            }
        }

        [NativeTypeName("UINT16")]
        public ushort Window;

        [NativeTypeName("UINT16")]
        public ushort Checksum;

        [NativeTypeName("UINT16")]
        public ushort UrgPtr;
    }

    public partial struct UdpHeader
    {
        [NativeTypeName("UINT16")]
        public ushort SrcPort;

        [NativeTypeName("UINT16")]
        public ushort DstPort;

        [NativeTypeName("UINT16")]
        public ushort Length;

        [NativeTypeName("UINT16")]
        public ushort Checksum;
    }

    public static unsafe partial class Methods
    {
        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern void* WinDivertOpen([NativeTypeName("const char *")] sbyte* filter, WINDIVERT_LAYER layer, [NativeTypeName("INT16")] short priority, [NativeTypeName("UINT64")] ulong flags);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertRecv([NativeTypeName("HANDLE")] void* handle, void* pPacket, uint packetLen, uint* pRecvLen, [NativeTypeName("WINDIVERT_ADDRESS *")] Address* pAddr);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertRecvEx([NativeTypeName("HANDLE")] void* handle, void* pPacket, uint packetLen, uint* pRecvLen, [NativeTypeName("UINT64")] ulong flags, [NativeTypeName("WINDIVERT_ADDRESS *")] Address* pAddr, uint* pAddrLen, [NativeTypeName("LPOVERLAPPED")] _OVERLAPPED* lpOverlapped);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertSend([NativeTypeName("HANDLE")] void* handle, [NativeTypeName("const void *")] void* pPacket, uint packetLen, uint* pSendLen, [NativeTypeName("const WINDIVERT_ADDRESS *")] Address* pAddr);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertSendEx([NativeTypeName("HANDLE")] void* handle, [NativeTypeName("const void *")] void* pPacket, uint packetLen, uint* pSendLen, [NativeTypeName("UINT64")] ulong flags, [NativeTypeName("const WINDIVERT_ADDRESS *")] Address* pAddr, uint addrLen, [NativeTypeName("LPOVERLAPPED")] _OVERLAPPED* lpOverlapped);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertShutdown([NativeTypeName("HANDLE")] void* handle, WINDIVERT_SHUTDOWN how);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertClose([NativeTypeName("HANDLE")] void* handle);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertSetParam([NativeTypeName("HANDLE")] void* handle, WINDIVERT_PARAM param1, [NativeTypeName("UINT64")] ulong value);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertGetParam([NativeTypeName("HANDLE")] void* handle, WINDIVERT_PARAM param1, [NativeTypeName("UINT64 *")] ulong* pValue);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("UINT64")]
        public static extern ulong WinDivertHelperHashPacket([NativeTypeName("const void *")] void* pPacket, uint packetLen, [NativeTypeName("UINT64")] ulong seed = 0);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperParsePacket([NativeTypeName("const void *")] void* pPacket, uint packetLen, [NativeTypeName("PWINDIVERT_IPHDR *")] IpV4Header** ppIpHdr, [NativeTypeName("PWINDIVERT_IPV6HDR *")] IpV6Header** ppIpv6Hdr, [NativeTypeName("UINT8 *")] byte* pProtocol, [NativeTypeName("PWINDIVERT_ICMPHDR *")] IcmpV4Header** ppIcmpHdr, [NativeTypeName("PWINDIVERT_ICMPV6HDR *")] IcmpV6Header** ppIcmpv6Hdr, [NativeTypeName("PWINDIVERT_TCPHDR *")] TcpHeader** ppTcpHdr, [NativeTypeName("PWINDIVERT_UDPHDR *")] UdpHeader** ppUdpHdr, [NativeTypeName("PVOID *")] void** ppData, uint* pDataLen, [NativeTypeName("PVOID *")] void** ppNext, uint* pNextLen);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperParseIPv4Address([NativeTypeName("const char *")] sbyte* addrStr, [NativeTypeName("UINT32 *")] uint* pAddr);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperParseIPv6Address([NativeTypeName("const char *")] sbyte* addrStr, [NativeTypeName("UINT32 *")] uint* pAddr);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperFormatIPv4Address([NativeTypeName("UINT32")] uint addr, [NativeTypeName("char *")] sbyte* buffer, uint bufLen);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperFormatIPv6Address([NativeTypeName("const UINT32 *")] uint* pAddr, [NativeTypeName("char *")] sbyte* buffer, uint bufLen);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperCalcChecksums(void* pPacket, uint packetLen, [NativeTypeName("WINDIVERT_ADDRESS *")] Address* pAddr, [NativeTypeName("UINT64")] ulong flags);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperDecrementTTL(void* pPacket, uint packetLen);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperCompileFilter([NativeTypeName("const char *")] sbyte* filter, WINDIVERT_LAYER layer, [NativeTypeName("char *")] sbyte* @object, uint objLen, [NativeTypeName("const char **")] sbyte** errorStr, uint* errorPos);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperEvalFilter([NativeTypeName("const char *")] sbyte* filter, [NativeTypeName("const void *")] void* pPacket, uint packetLen, [NativeTypeName("const WINDIVERT_ADDRESS *")] Address* pAddr);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int WinDivertHelperFormatFilter([NativeTypeName("const char *")] sbyte* filter, WINDIVERT_LAYER layer, [NativeTypeName("char *")] sbyte* buffer, uint bufLen);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("UINT16")]
        public static extern ushort WinDivertHelperNtohs([NativeTypeName("UINT16")] ushort x);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("UINT16")]
        public static extern ushort WinDivertHelperHtons([NativeTypeName("UINT16")] ushort x);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("UINT32")]
        public static extern uint WinDivertHelperNtohl([NativeTypeName("UINT32")] uint x);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("UINT32")]
        public static extern uint WinDivertHelperHtonl([NativeTypeName("UINT32")] uint x);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("UINT64")]
        public static extern ulong WinDivertHelperNtohll([NativeTypeName("UINT64")] ulong x);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("UINT64")]
        public static extern ulong WinDivertHelperHtonll([NativeTypeName("UINT64")] ulong x);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void WinDivertHelperNtohIPv6Address([NativeTypeName("const UINT *")] uint* inAddr, uint* outAddr);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void WinDivertHelperHtonIPv6Address([NativeTypeName("const UINT *")] uint* inAddr, uint* outAddr);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void WinDivertHelperNtohIpv6Address([NativeTypeName("const UINT *")] uint* inAddr, uint* outAddr);

        [DllImport("windivert", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void WinDivertHelperHtonIpv6Address([NativeTypeName("const UINT *")] uint* inAddr, uint* outAddr);

        [NativeTypeName("#define WINDIVERT_FLAG_SNIFF 0x0001")]
        public const int WINDIVERT_FLAG_SNIFF = 0x0001;

        [NativeTypeName("#define WINDIVERT_FLAG_DROP 0x0002")]
        public const int WINDIVERT_FLAG_DROP = 0x0002;

        [NativeTypeName("#define WINDIVERT_FLAG_RECV_ONLY 0x0004")]
        public const int WINDIVERT_FLAG_RECV_ONLY = 0x0004;

        [NativeTypeName("#define WINDIVERT_FLAG_READ_ONLY WINDIVERT_FLAG_RECV_ONLY")]
        public const int WINDIVERT_FLAG_READ_ONLY = 0x0004;

        [NativeTypeName("#define WINDIVERT_FLAG_SEND_ONLY 0x0008")]
        public const int WINDIVERT_FLAG_SEND_ONLY = 0x0008;

        [NativeTypeName("#define WINDIVERT_FLAG_WRITE_ONLY WINDIVERT_FLAG_SEND_ONLY")]
        public const int WINDIVERT_FLAG_WRITE_ONLY = 0x0008;

        [NativeTypeName("#define WINDIVERT_FLAG_NO_INSTALL 0x0010")]
        public const int WINDIVERT_FLAG_NO_INSTALL = 0x0010;

        [NativeTypeName("#define WINDIVERT_FLAG_FRAGMENTS 0x0020")]
        public const int WINDIVERT_FLAG_FRAGMENTS = 0x0020;

        [NativeTypeName("#define WINDIVERT_PARAM_MAX WINDIVERT_PARAM_VERSION_MINOR")]
        public const WINDIVERT_PARAM WINDIVERT_PARAM_MAX = WINDIVERT_PARAM.WINDIVERT_PARAM_VERSION_MINOR;

        [NativeTypeName("#define WINDIVERT_SHUTDOWN_MAX WINDIVERT_SHUTDOWN_BOTH")]
        public const WINDIVERT_SHUTDOWN WINDIVERT_SHUTDOWN_MAX = WINDIVERT_SHUTDOWN.WINDIVERT_SHUTDOWN_BOTH;

        [NativeTypeName("#define WINDIVERT_PRIORITY_HIGHEST 30000")]
        public const int WINDIVERT_PRIORITY_HIGHEST = 30000;

        [NativeTypeName("#define WINDIVERT_PRIORITY_LOWEST (-WINDIVERT_PRIORITY_HIGHEST)")]
        public const int WINDIVERT_PRIORITY_LOWEST = (-30000);

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_LENGTH_DEFAULT 4096")]
        public const int WINDIVERT_PARAM_QUEUE_LENGTH_DEFAULT = 4096;

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_LENGTH_MIN 32")]
        public const int WINDIVERT_PARAM_QUEUE_LENGTH_MIN = 32;

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_LENGTH_MAX 16384")]
        public const int WINDIVERT_PARAM_QUEUE_LENGTH_MAX = 16384;

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_TIME_DEFAULT 2000")]
        public const int WINDIVERT_PARAM_QUEUE_TIME_DEFAULT = 2000;

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_TIME_MIN 100")]
        public const int WINDIVERT_PARAM_QUEUE_TIME_MIN = 100;

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_TIME_MAX 16000")]
        public const int WINDIVERT_PARAM_QUEUE_TIME_MAX = 16000;

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_SIZE_DEFAULT 4194304")]
        public const int WINDIVERT_PARAM_QUEUE_SIZE_DEFAULT = 4194304;

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_SIZE_MIN 65535")]
        public const int WINDIVERT_PARAM_QUEUE_SIZE_MIN = 65535;

        [NativeTypeName("#define WINDIVERT_PARAM_QUEUE_SIZE_MAX 33554432")]
        public const int WINDIVERT_PARAM_QUEUE_SIZE_MAX = 33554432;

        [NativeTypeName("#define WINDIVERT_BATCH_MAX 0xFF")]
        public const int WINDIVERT_BATCH_MAX = 0xFF;

        [NativeTypeName("#define WINDIVERT_MTU_MAX (40 + 0xFFFF)")]
        public const int WINDIVERT_MTU_MAX = (40 + 0xFFFF);

        [NativeTypeName("#define WINDIVERT_HELPER_NO_IP_CHECKSUM 1")]
        public const int WINDIVERT_HELPER_NO_IP_CHECKSUM = 1;

        [NativeTypeName("#define WINDIVERT_HELPER_NO_ICMP_CHECKSUM 2")]
        public const int WINDIVERT_HELPER_NO_ICMP_CHECKSUM = 2;

        [NativeTypeName("#define WINDIVERT_HELPER_NO_ICMPV6_CHECKSUM 4")]
        public const int WINDIVERT_HELPER_NO_ICMPV6_CHECKSUM = 4;

        [NativeTypeName("#define WINDIVERT_HELPER_NO_TCP_CHECKSUM 8")]
        public const int WINDIVERT_HELPER_NO_TCP_CHECKSUM = 8;

        [NativeTypeName("#define WINDIVERT_HELPER_NO_UDP_CHECKSUM 16")]
        public const int WINDIVERT_HELPER_NO_UDP_CHECKSUM = 16;
    }
}
