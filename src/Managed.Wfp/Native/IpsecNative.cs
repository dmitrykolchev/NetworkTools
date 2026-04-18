using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.Ipsec.Native
{
    public partial struct IPSEC_SA_LIFETIME0_
    {
        [NativeTypeName("UINT32")]
        public uint lifetimeSeconds;

        [NativeTypeName("UINT32")]
        public uint lifetimeKilobytes;

        [NativeTypeName("UINT32")]
        public uint lifetimePackets;
    }

    public enum IPSEC_TRANSFORM_TYPE_
    {
        IPSEC_TRANSFORM_AH = 1,
        IPSEC_TRANSFORM_ESP_AUTH = (IPSEC_TRANSFORM_AH + 1),
        IPSEC_TRANSFORM_ESP_CIPHER = (IPSEC_TRANSFORM_ESP_AUTH + 1),
        IPSEC_TRANSFORM_ESP_AUTH_AND_CIPHER = (IPSEC_TRANSFORM_ESP_CIPHER + 1),
        IPSEC_TRANSFORM_ESP_AUTH_FW = (IPSEC_TRANSFORM_ESP_AUTH_AND_CIPHER + 1),
        IPSEC_TRANSFORM_TYPE_MAX = (IPSEC_TRANSFORM_ESP_AUTH_FW + 1),
    }

    public enum IPSEC_AUTH_TYPE_
    {
        IPSEC_AUTH_MD5 = 0,
        IPSEC_AUTH_SHA_1 = (IPSEC_AUTH_MD5 + 1),
        IPSEC_AUTH_SHA_256 = (IPSEC_AUTH_SHA_1 + 1),
        IPSEC_AUTH_AES_128 = (IPSEC_AUTH_SHA_256 + 1),
        IPSEC_AUTH_AES_192 = (IPSEC_AUTH_AES_128 + 1),
        IPSEC_AUTH_AES_256 = (IPSEC_AUTH_AES_192 + 1),
        IPSEC_AUTH_MAX = (IPSEC_AUTH_AES_256 + 1),
    }

    public partial struct IPSEC_AUTH_TRANSFORM_ID0_
    {
        [NativeTypeName("IPSEC_AUTH_TYPE")]
        public IPSEC_AUTH_TYPE_ authType;

        [NativeTypeName("IPSEC_AUTH_CONFIG")]
        public byte authConfig;
    }

    public unsafe partial struct IPSEC_AUTH_TRANSFORM0_
    {
        [NativeTypeName("IPSEC_AUTH_TRANSFORM_ID0")]
        public IPSEC_AUTH_TRANSFORM_ID0_ authTransformId;

        [NativeTypeName("IPSEC_CRYPTO_MODULE_ID *")]
        public Guid* cryptoModuleId;
    }

    public enum IPSEC_CIPHER_TYPE_
    {
        IPSEC_CIPHER_TYPE_DES = 1,
        IPSEC_CIPHER_TYPE_3DES = (IPSEC_CIPHER_TYPE_DES + 1),
        IPSEC_CIPHER_TYPE_AES_128 = (IPSEC_CIPHER_TYPE_3DES + 1),
        IPSEC_CIPHER_TYPE_AES_192 = (IPSEC_CIPHER_TYPE_AES_128 + 1),
        IPSEC_CIPHER_TYPE_AES_256 = (IPSEC_CIPHER_TYPE_AES_192 + 1),
        IPSEC_CIPHER_TYPE_MAX = (IPSEC_CIPHER_TYPE_AES_256 + 1),
    }

    public partial struct IPSEC_CIPHER_TRANSFORM_ID0_
    {
        [NativeTypeName("IPSEC_CIPHER_TYPE")]
        public IPSEC_CIPHER_TYPE_ cipherType;

        [NativeTypeName("IPSEC_CIPHER_CONFIG")]
        public byte cipherConfig;
    }

    public unsafe partial struct IPSEC_CIPHER_TRANSFORM0_
    {
        [NativeTypeName("IPSEC_CIPHER_TRANSFORM_ID0")]
        public IPSEC_CIPHER_TRANSFORM_ID0_ cipherTransformId;

        [NativeTypeName("IPSEC_CRYPTO_MODULE_ID *")]
        public Guid* cryptoModuleId;
    }

    public partial struct IPSEC_AUTH_AND_CIPHER_TRANSFORM0_
    {
        [NativeTypeName("IPSEC_AUTH_TRANSFORM0")]
        public IPSEC_AUTH_TRANSFORM0_ authTransform;

        [NativeTypeName("IPSEC_CIPHER_TRANSFORM0")]
        public IPSEC_CIPHER_TRANSFORM0_ cipherTransform;
    }

    public unsafe partial struct IPSEC_SA_TRANSFORM0_
    {
        [NativeTypeName("IPSEC_TRANSFORM_TYPE")]
        public IPSEC_TRANSFORM_TYPE_ ipsecTransformType;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L167_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref IPSEC_AUTH_TRANSFORM0_* ahTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ahTransform;
            }
        }

        [UnscopedRef]
        public ref IPSEC_AUTH_TRANSFORM0_* espAuthTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.espAuthTransform;
            }
        }

        [UnscopedRef]
        public ref IPSEC_CIPHER_TRANSFORM0_* espCipherTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.espCipherTransform;
            }
        }

        [UnscopedRef]
        public ref IPSEC_AUTH_AND_CIPHER_TRANSFORM0_* espAuthAndCipherTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.espAuthAndCipherTransform;
            }
        }

        [UnscopedRef]
        public ref IPSEC_AUTH_TRANSFORM0_* espAuthFwTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.espAuthFwTransform;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_AUTH_TRANSFORM0 *")]
            public IPSEC_AUTH_TRANSFORM0_* ahTransform;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_AUTH_TRANSFORM0 *")]
            public IPSEC_AUTH_TRANSFORM0_* espAuthTransform;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_CIPHER_TRANSFORM0 *")]
            public IPSEC_CIPHER_TRANSFORM0_* espCipherTransform;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_AUTH_AND_CIPHER_TRANSFORM0 *")]
            public IPSEC_AUTH_AND_CIPHER_TRANSFORM0_* espAuthAndCipherTransform;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_AUTH_TRANSFORM0 *")]
            public IPSEC_AUTH_TRANSFORM0_* espAuthFwTransform;
        }
    }

    public enum IPSEC_PFS_GROUP_
    {
        IPSEC_PFS_NONE = 0,
        IPSEC_PFS_1 = (IPSEC_PFS_NONE + 1),
        IPSEC_PFS_2 = (IPSEC_PFS_1 + 1),
        IPSEC_PFS_2048 = (IPSEC_PFS_2 + 1),
        IPSEC_PFS_14 = IPSEC_PFS_2048,
        IPSEC_PFS_ECP_256 = (IPSEC_PFS_14 + 1),
        IPSEC_PFS_ECP_384 = (IPSEC_PFS_ECP_256 + 1),
        IPSEC_PFS_MM = (IPSEC_PFS_ECP_384 + 1),
        IPSEC_PFS_24 = (IPSEC_PFS_MM + 1),
        IPSEC_PFS_MAX = (IPSEC_PFS_24 + 1),
    }

    public unsafe partial struct IPSEC_PROPOSAL0_
    {
        [NativeTypeName("IPSEC_SA_LIFETIME0")]
        public IPSEC_SA_LIFETIME0_ lifetime;

        [NativeTypeName("UINT32")]
        public uint numSaTransforms;

        [NativeTypeName("IPSEC_SA_TRANSFORM0 *")]
        public IPSEC_SA_TRANSFORM0_* saTransforms;

        [NativeTypeName("IPSEC_PFS_GROUP")]
        public IPSEC_PFS_GROUP_ pfsGroup;
    }

    public partial struct IPSEC_SA_IDLE_TIMEOUT0_
    {
        [NativeTypeName("UINT32")]
        public uint idleTimeoutSeconds;

        [NativeTypeName("UINT32")]
        public uint idleTimeoutSecondsFailOver;
    }

    public partial struct IPSEC_TRAFFIC_SELECTOR0_
    {
        [NativeTypeName("UINT8")]
        public byte protocolId;

        [NativeTypeName("UINT16")]
        public ushort portStart;

        [NativeTypeName("UINT16")]
        public ushort portEnd;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L213_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L218_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [UnscopedRef]
        public ref uint startV4Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.startV4Address;
            }
        }

        [UnscopedRef]
        public Span<byte> startV6Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous1.startV6Address;
            }
        }

        [UnscopedRef]
        public ref uint endV4Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.endV4Address;
            }
        }

        [UnscopedRef]
        public Span<byte> endV6Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous2.endV6Address;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint startV4Address;

            [FieldOffset(0)]
            [NativeTypeName("UINT8[16]")]
            public _startV6Address_e__FixedBuffer startV6Address;

            [InlineArray(16)]
            public partial struct _startV6Address_e__FixedBuffer
            {
                public byte e0;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint endV4Address;

            [FieldOffset(0)]
            [NativeTypeName("UINT8[16]")]
            public _endV6Address_e__FixedBuffer endV6Address;

            [InlineArray(16)]
            public partial struct _endV6Address_e__FixedBuffer
            {
                public byte e0;
            }
        }
    }

    public unsafe partial struct IPSEC_TRAFFIC_SELECTOR_POLICY0_
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint numLocalTrafficSelectors;

        [NativeTypeName("IPSEC_TRAFFIC_SELECTOR0 *")]
        public IPSEC_TRAFFIC_SELECTOR0_* localTrafficSelectors;

        [NativeTypeName("UINT32")]
        public uint numRemoteTrafficSelectors;

        [NativeTypeName("IPSEC_TRAFFIC_SELECTOR0 *")]
        public IPSEC_TRAFFIC_SELECTOR0_* remoteTrafficSelectors;
    }

    public unsafe partial struct IPSEC_TRANSPORT_POLICY0_
    {
        [NativeTypeName("UINT32")]
        public uint numIpsecProposals;

        [NativeTypeName("IPSEC_PROPOSAL0 *")]
        public IPSEC_PROPOSAL0_* ipsecProposals;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint ndAllowClearTimeoutSeconds;

        [NativeTypeName("IPSEC_SA_IDLE_TIMEOUT0")]
        public IPSEC_SA_IDLE_TIMEOUT0_ saIdleTimeout;

        [NativeTypeName("IKEEXT_EM_POLICY0 *")]
        public IKEEXT_EM_POLICY0_* emPolicy;
    }

    public unsafe partial struct IPSEC_TRANSPORT_POLICY1_
    {
        [NativeTypeName("UINT32")]
        public uint numIpsecProposals;

        [NativeTypeName("IPSEC_PROPOSAL0 *")]
        public IPSEC_PROPOSAL0_* ipsecProposals;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint ndAllowClearTimeoutSeconds;

        [NativeTypeName("IPSEC_SA_IDLE_TIMEOUT0")]
        public IPSEC_SA_IDLE_TIMEOUT0_ saIdleTimeout;

        [NativeTypeName("IKEEXT_EM_POLICY1 *")]
        public IKEEXT_EM_POLICY1_* emPolicy;
    }

    public unsafe partial struct IPSEC_TRANSPORT_POLICY2_
    {
        [NativeTypeName("UINT32")]
        public uint numIpsecProposals;

        [NativeTypeName("IPSEC_PROPOSAL0 *")]
        public IPSEC_PROPOSAL0_* ipsecProposals;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint ndAllowClearTimeoutSeconds;

        [NativeTypeName("IPSEC_SA_IDLE_TIMEOUT0")]
        public IPSEC_SA_IDLE_TIMEOUT0_ saIdleTimeout;

        [NativeTypeName("IKEEXT_EM_POLICY2 *")]
        public IKEEXT_EM_POLICY2_* emPolicy;
    }

    public partial struct IPSEC_TUNNEL_ENDPOINTS0_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L298_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L303_C36")]
        public _Anonymous2_e__Union Anonymous2;

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

    public partial struct IPSEC_TUNNEL_ENDPOINT0_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L314_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref uint v4Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.v4Address;
            }
        }

        [UnscopedRef]
        public Span<byte> v6Address
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.v6Address;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint v4Address;

            [FieldOffset(0)]
            [NativeTypeName("UINT8[16]")]
            public _v6Address_e__FixedBuffer v6Address;

            [InlineArray(16)]
            public partial struct _v6Address_e__FixedBuffer
            {
                public byte e0;
            }
        }
    }

    public unsafe partial struct IPSEC_TUNNEL_ENDPOINTS2_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L324_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L329_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT64")]
        public ulong localIfLuid;

        [NativeTypeName("wchar_t *")]
        public char* remoteFqdn;

        [NativeTypeName("UINT32")]
        public uint numAddresses;

        [NativeTypeName("IPSEC_TUNNEL_ENDPOINT0 *")]
        public IPSEC_TUNNEL_ENDPOINT0_* remoteAddresses;

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

    public partial struct IPSEC_TUNNEL_ENDPOINTS1_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L345_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L350_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT64")]
        public ulong localIfLuid;

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

    public unsafe partial struct IPSEC_TUNNEL_POLICY0_
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint numIpsecProposals;

        [NativeTypeName("IPSEC_PROPOSAL0 *")]
        public IPSEC_PROPOSAL0_* ipsecProposals;

        [NativeTypeName("IPSEC_TUNNEL_ENDPOINTS0")]
        public IPSEC_TUNNEL_ENDPOINTS0_ tunnelEndpoints;

        [NativeTypeName("IPSEC_SA_IDLE_TIMEOUT0")]
        public IPSEC_SA_IDLE_TIMEOUT0_ saIdleTimeout;

        [NativeTypeName("IKEEXT_EM_POLICY0 *")]
        public IKEEXT_EM_POLICY0_* emPolicy;
    }

    public unsafe partial struct IPSEC_TUNNEL_POLICY1_
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint numIpsecProposals;

        [NativeTypeName("IPSEC_PROPOSAL0 *")]
        public IPSEC_PROPOSAL0_* ipsecProposals;

        [NativeTypeName("IPSEC_TUNNEL_ENDPOINTS1")]
        public IPSEC_TUNNEL_ENDPOINTS1_ tunnelEndpoints;

        [NativeTypeName("IPSEC_SA_IDLE_TIMEOUT0")]
        public IPSEC_SA_IDLE_TIMEOUT0_ saIdleTimeout;

        [NativeTypeName("IKEEXT_EM_POLICY1 *")]
        public IKEEXT_EM_POLICY1_* emPolicy;
    }

    public unsafe partial struct IPSEC_TUNNEL_POLICY2_
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint numIpsecProposals;

        [NativeTypeName("IPSEC_PROPOSAL0 *")]
        public IPSEC_PROPOSAL0_* ipsecProposals;

        [NativeTypeName("IPSEC_TUNNEL_ENDPOINTS2")]
        public IPSEC_TUNNEL_ENDPOINTS2_ tunnelEndpoints;

        [NativeTypeName("IPSEC_SA_IDLE_TIMEOUT0")]
        public IPSEC_SA_IDLE_TIMEOUT0_ saIdleTimeout;

        [NativeTypeName("IKEEXT_EM_POLICY2 *")]
        public IKEEXT_EM_POLICY2_* emPolicy;

        [NativeTypeName("UINT32")]
        public uint fwdPathSaLifetime;
    }

    public unsafe partial struct IPSEC_TUNNEL_POLICY3_
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint numIpsecProposals;

        [NativeTypeName("IPSEC_PROPOSAL0 *")]
        public IPSEC_PROPOSAL0_* ipsecProposals;

        [NativeTypeName("IPSEC_TUNNEL_ENDPOINTS2")]
        public IPSEC_TUNNEL_ENDPOINTS2_ tunnelEndpoints;

        [NativeTypeName("IPSEC_SA_IDLE_TIMEOUT0")]
        public IPSEC_SA_IDLE_TIMEOUT0_ saIdleTimeout;

        [NativeTypeName("IKEEXT_EM_POLICY2 *")]
        public IKEEXT_EM_POLICY2_* emPolicy;

        [NativeTypeName("UINT32")]
        public uint fwdPathSaLifetime;

        [NativeTypeName("UINT32")]
        public uint compartmentId;

        [NativeTypeName("UINT32")]
        public uint numTrafficSelectorPolicy;

        [NativeTypeName("IPSEC_TRAFFIC_SELECTOR_POLICY0 *")]
        public IPSEC_TRAFFIC_SELECTOR_POLICY0_* trafficSelectorPolicies;
    }

    public unsafe partial struct IPSEC_KEYING_POLICY0_
    {
        [NativeTypeName("UINT32")]
        public uint numKeyMods;

        public Guid* keyModKeys;
    }

    public unsafe partial struct IPSEC_KEYING_POLICY1_
    {
        [NativeTypeName("UINT32")]
        public uint numKeyMods;

        public Guid* keyModKeys;

        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public partial struct IPSEC_AGGREGATE_SA_STATISTICS0_
    {
        [NativeTypeName("UINT32")]
        public uint activeSas;

        [NativeTypeName("UINT32")]
        public uint pendingSaNegotiations;

        [NativeTypeName("UINT32")]
        public uint totalSasAdded;

        [NativeTypeName("UINT32")]
        public uint totalSasDeleted;

        [NativeTypeName("UINT32")]
        public uint successfulRekeys;

        [NativeTypeName("UINT32")]
        public uint activeTunnels;

        [NativeTypeName("UINT32")]
        public uint offloadedSas;
    }

    public partial struct IPSEC_ESP_DROP_PACKET_STATISTICS0_
    {
        [NativeTypeName("UINT32")]
        public uint invalidSpisOnInbound;

        [NativeTypeName("UINT32")]
        public uint decryptionFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint authenticationFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint replayCheckFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint saNotInitializedOnInbound;
    }

    public partial struct IPSEC_AH_DROP_PACKET_STATISTICS0_
    {
        [NativeTypeName("UINT32")]
        public uint invalidSpisOnInbound;

        [NativeTypeName("UINT32")]
        public uint authenticationFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint replayCheckFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint saNotInitializedOnInbound;
    }

    public partial struct IPSEC_AGGREGATE_DROP_PACKET_STATISTICS0_
    {
        [NativeTypeName("UINT32")]
        public uint invalidSpisOnInbound;

        [NativeTypeName("UINT32")]
        public uint decryptionFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint authenticationFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint udpEspValidationFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint replayCheckFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint invalidClearTextInbound;

        [NativeTypeName("UINT32")]
        public uint saNotInitializedOnInbound;

        [NativeTypeName("UINT32")]
        public uint receiveOverIncorrectSaInbound;

        [NativeTypeName("UINT32")]
        public uint secureReceivesNotMatchingFilters;
    }

    public partial struct IPSEC_AGGREGATE_DROP_PACKET_STATISTICS1_
    {
        [NativeTypeName("UINT32")]
        public uint invalidSpisOnInbound;

        [NativeTypeName("UINT32")]
        public uint decryptionFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint authenticationFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint udpEspValidationFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint replayCheckFailuresOnInbound;

        [NativeTypeName("UINT32")]
        public uint invalidClearTextInbound;

        [NativeTypeName("UINT32")]
        public uint saNotInitializedOnInbound;

        [NativeTypeName("UINT32")]
        public uint receiveOverIncorrectSaInbound;

        [NativeTypeName("UINT32")]
        public uint secureReceivesNotMatchingFilters;

        [NativeTypeName("UINT32")]
        public uint totalDropPacketsInbound;
    }

    public partial struct IPSEC_TRAFFIC_STATISTICS0_
    {
        [NativeTypeName("UINT64")]
        public ulong encryptedByteCount;

        [NativeTypeName("UINT64")]
        public ulong authenticatedAHByteCount;

        [NativeTypeName("UINT64")]
        public ulong authenticatedESPByteCount;

        [NativeTypeName("UINT64")]
        public ulong transportByteCount;

        [NativeTypeName("UINT64")]
        public ulong tunnelByteCount;

        [NativeTypeName("UINT64")]
        public ulong offloadByteCount;
    }

    public partial struct IPSEC_TRAFFIC_STATISTICS1_
    {
        [NativeTypeName("UINT64")]
        public ulong encryptedByteCount;

        [NativeTypeName("UINT64")]
        public ulong authenticatedAHByteCount;

        [NativeTypeName("UINT64")]
        public ulong authenticatedESPByteCount;

        [NativeTypeName("UINT64")]
        public ulong transportByteCount;

        [NativeTypeName("UINT64")]
        public ulong tunnelByteCount;

        [NativeTypeName("UINT64")]
        public ulong offloadByteCount;

        [NativeTypeName("UINT64")]
        public ulong totalSuccessfulPackets;
    }

    public partial struct IPSEC_STATISTICS0_
    {
        [NativeTypeName("IPSEC_AGGREGATE_SA_STATISTICS0")]
        public IPSEC_AGGREGATE_SA_STATISTICS0_ aggregateSaStatistics;

        [NativeTypeName("IPSEC_ESP_DROP_PACKET_STATISTICS0")]
        public IPSEC_ESP_DROP_PACKET_STATISTICS0_ espDropPacketStatistics;

        [NativeTypeName("IPSEC_AH_DROP_PACKET_STATISTICS0")]
        public IPSEC_AH_DROP_PACKET_STATISTICS0_ ahDropPacketStatistics;

        [NativeTypeName("IPSEC_AGGREGATE_DROP_PACKET_STATISTICS0")]
        public IPSEC_AGGREGATE_DROP_PACKET_STATISTICS0_ aggregateDropPacketStatistics;

        [NativeTypeName("IPSEC_TRAFFIC_STATISTICS0")]
        public IPSEC_TRAFFIC_STATISTICS0_ inboundTrafficStatistics;

        [NativeTypeName("IPSEC_TRAFFIC_STATISTICS0")]
        public IPSEC_TRAFFIC_STATISTICS0_ outboundTrafficStatistics;
    }

    public partial struct IPSEC_STATISTICS1_
    {
        [NativeTypeName("IPSEC_AGGREGATE_SA_STATISTICS0")]
        public IPSEC_AGGREGATE_SA_STATISTICS0_ aggregateSaStatistics;

        [NativeTypeName("IPSEC_ESP_DROP_PACKET_STATISTICS0")]
        public IPSEC_ESP_DROP_PACKET_STATISTICS0_ espDropPacketStatistics;

        [NativeTypeName("IPSEC_AH_DROP_PACKET_STATISTICS0")]
        public IPSEC_AH_DROP_PACKET_STATISTICS0_ ahDropPacketStatistics;

        [NativeTypeName("IPSEC_AGGREGATE_DROP_PACKET_STATISTICS1")]
        public IPSEC_AGGREGATE_DROP_PACKET_STATISTICS1_ aggregateDropPacketStatistics;

        [NativeTypeName("IPSEC_TRAFFIC_STATISTICS1")]
        public IPSEC_TRAFFIC_STATISTICS1_ inboundTrafficStatistics;

        [NativeTypeName("IPSEC_TRAFFIC_STATISTICS1")]
        public IPSEC_TRAFFIC_STATISTICS1_ outboundTrafficStatistics;
    }

    public partial struct IPSEC_SA_AUTH_INFORMATION0_
    {
        [NativeTypeName("IPSEC_AUTH_TRANSFORM0")]
        public IPSEC_AUTH_TRANSFORM0_ authTransform;

        public FWP_BYTE_BLOB authKey;
    }

    public partial struct IPSEC_SA_CIPHER_INFORMATION0_
    {
        [NativeTypeName("IPSEC_CIPHER_TRANSFORM0")]
        public IPSEC_CIPHER_TRANSFORM0_ cipherTransform;

        public FWP_BYTE_BLOB cipherKey;
    }

    public partial struct IPSEC_SA_AUTH_AND_CIPHER_INFORMATION0_
    {
        [NativeTypeName("IPSEC_SA_CIPHER_INFORMATION0")]
        public IPSEC_SA_CIPHER_INFORMATION0_ saCipherInformation;

        [NativeTypeName("IPSEC_SA_AUTH_INFORMATION0")]
        public IPSEC_SA_AUTH_INFORMATION0_ saAuthInformation;
    }

    public unsafe partial struct IPSEC_SA0_
    {
        [NativeTypeName("IPSEC_SA_SPI")]
        public uint spi;

        [NativeTypeName("IPSEC_TRANSFORM_TYPE")]
        public IPSEC_TRANSFORM_TYPE_ saTransformType;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L552_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref IPSEC_SA_AUTH_INFORMATION0_* ahInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ahInformation;
            }
        }

        [UnscopedRef]
        public ref IPSEC_SA_AUTH_INFORMATION0_* espAuthInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.espAuthInformation;
            }
        }

        [UnscopedRef]
        public ref IPSEC_SA_CIPHER_INFORMATION0_* espCipherInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.espCipherInformation;
            }
        }

        [UnscopedRef]
        public ref IPSEC_SA_AUTH_AND_CIPHER_INFORMATION0_* espAuthAndCipherInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.espAuthAndCipherInformation;
            }
        }

        [UnscopedRef]
        public ref IPSEC_SA_AUTH_INFORMATION0_* espAuthFwInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.espAuthFwInformation;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_SA_AUTH_INFORMATION0 *")]
            public IPSEC_SA_AUTH_INFORMATION0_* ahInformation;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_SA_AUTH_INFORMATION0 *")]
            public IPSEC_SA_AUTH_INFORMATION0_* espAuthInformation;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_SA_CIPHER_INFORMATION0 *")]
            public IPSEC_SA_CIPHER_INFORMATION0_* espCipherInformation;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_SA_AUTH_AND_CIPHER_INFORMATION0 *")]
            public IPSEC_SA_AUTH_AND_CIPHER_INFORMATION0_* espAuthAndCipherInformation;

            [FieldOffset(0)]
            [NativeTypeName("IPSEC_SA_AUTH_INFORMATION0 *")]
            public IPSEC_SA_AUTH_INFORMATION0_* espAuthFwInformation;
        }
    }

    public partial struct IPSEC_KEYMODULE_STATE0_
    {
        public Guid keyModuleKey;

        public FWP_BYTE_BLOB stateBlob;
    }

    public enum IPSEC_TOKEN_TYPE_
    {
        IPSEC_TOKEN_TYPE_MACHINE = 0,
        IPSEC_TOKEN_TYPE_IMPERSONATION = (IPSEC_TOKEN_TYPE_MACHINE + 1),
        IPSEC_TOKEN_TYPE_MAX = (IPSEC_TOKEN_TYPE_IMPERSONATION + 1),
    }

    public enum IPSEC_TOKEN_PRINCIPAL_
    {
        IPSEC_TOKEN_PRINCIPAL_LOCAL = 0,
        IPSEC_TOKEN_PRINCIPAL_PEER = (IPSEC_TOKEN_PRINCIPAL_LOCAL + 1),
        IPSEC_TOKEN_PRINCIPAL_MAX = (IPSEC_TOKEN_PRINCIPAL_PEER + 1),
    }

    public enum IPSEC_TOKEN_MODE_
    {
        IPSEC_TOKEN_MODE_MAIN = 0,
        IPSEC_TOKEN_MODE_EXTENDED = (IPSEC_TOKEN_MODE_MAIN + 1),
        IPSEC_TOKEN_MODE_MAX = (IPSEC_TOKEN_MODE_EXTENDED + 1),
    }

    public partial struct IPSEC_TOKEN0_
    {
        [NativeTypeName("IPSEC_TOKEN_TYPE")]
        public IPSEC_TOKEN_TYPE_ type;

        [NativeTypeName("IPSEC_TOKEN_PRINCIPAL")]
        public IPSEC_TOKEN_PRINCIPAL_ principal;

        [NativeTypeName("IPSEC_TOKEN_MODE")]
        public IPSEC_TOKEN_MODE_ mode;

        [NativeTypeName("IPSEC_TOKEN_HANDLE")]
        public ulong token;
    }

    public unsafe partial struct IPSEC_ID0_
    {
        [NativeTypeName("wchar_t *")]
        public char* mmTargetName;

        [NativeTypeName("wchar_t *")]
        public char* emTargetName;

        [NativeTypeName("UINT32")]
        public uint numTokens;

        [NativeTypeName("IPSEC_TOKEN0 *")]
        public IPSEC_TOKEN0_* tokens;

        [NativeTypeName("UINT64")]
        public ulong explicitCredentials;

        [NativeTypeName("UINT64")]
        public ulong logonId;
    }

    public unsafe partial struct IPSEC_SA_BUNDLE0_
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("IPSEC_SA_LIFETIME0")]
        public IPSEC_SA_LIFETIME0_ lifetime;

        [NativeTypeName("UINT32")]
        public uint idleTimeoutSeconds;

        [NativeTypeName("UINT32")]
        public uint ndAllowClearTimeoutSeconds;

        [NativeTypeName("IPSEC_ID0 *")]
        public IPSEC_ID0_* ipsecId;

        [NativeTypeName("UINT32")]
        public uint napContext;

        [NativeTypeName("UINT32")]
        public uint qmSaId;

        [NativeTypeName("UINT32")]
        public uint numSAs;

        [NativeTypeName("IPSEC_SA0 *")]
        public IPSEC_SA0_* saList;

        [NativeTypeName("IPSEC_KEYMODULE_STATE0 *")]
        public IPSEC_KEYMODULE_STATE0_* keyModuleState;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L662_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT64")]
        public ulong mmSaId;

        [NativeTypeName("IPSEC_PFS_GROUP")]
        public IPSEC_PFS_GROUP_ pfsGroup;

        [UnscopedRef]
        public ref uint peerV4PrivateAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.peerV4PrivateAddress;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint peerV4PrivateAddress;
        }
    }

    public unsafe partial struct IPSEC_SA_BUNDLE1_
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("IPSEC_SA_LIFETIME0")]
        public IPSEC_SA_LIFETIME0_ lifetime;

        [NativeTypeName("UINT32")]
        public uint idleTimeoutSeconds;

        [NativeTypeName("UINT32")]
        public uint ndAllowClearTimeoutSeconds;

        [NativeTypeName("IPSEC_ID0 *")]
        public IPSEC_ID0_* ipsecId;

        [NativeTypeName("UINT32")]
        public uint napContext;

        [NativeTypeName("UINT32")]
        public uint qmSaId;

        [NativeTypeName("UINT32")]
        public uint numSAs;

        [NativeTypeName("IPSEC_SA0 *")]
        public IPSEC_SA0_* saList;

        [NativeTypeName("IPSEC_KEYMODULE_STATE0 *")]
        public IPSEC_KEYMODULE_STATE0_* keyModuleState;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L685_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("UINT64")]
        public ulong mmSaId;

        [NativeTypeName("IPSEC_PFS_GROUP")]
        public IPSEC_PFS_GROUP_ pfsGroup;

        public Guid saLookupContext;

        [NativeTypeName("UINT64")]
        public ulong qmFilterId;

        [UnscopedRef]
        public ref uint peerV4PrivateAddress
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.peerV4PrivateAddress;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT32")]
            public uint peerV4PrivateAddress;
        }
    }

    public enum IPSEC_TRAFFIC_TYPE_
    {
        IPSEC_TRAFFIC_TYPE_TRANSPORT = 0,
        IPSEC_TRAFFIC_TYPE_TUNNEL = (IPSEC_TRAFFIC_TYPE_TRANSPORT + 1),
        IPSEC_TRAFFIC_TYPE_MAX = (IPSEC_TRAFFIC_TYPE_TUNNEL + 1),
    }

    public partial struct IPSEC_TRAFFIC0_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L708_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L713_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("IPSEC_TRAFFIC_TYPE")]
        public IPSEC_TRAFFIC_TYPE_ trafficType;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L719_C36")]
        public _Anonymous3_e__Union Anonymous3;

        [NativeTypeName("UINT16")]
        public ushort remotePort;

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

        [UnscopedRef]
        public ref ulong ipsecFilterId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.ipsecFilterId;
            }
        }

        [UnscopedRef]
        public ref ulong tunnelPolicyId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.tunnelPolicyId;
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

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT64")]
            public ulong ipsecFilterId;

            [FieldOffset(0)]
            [NativeTypeName("UINT64")]
            public ulong tunnelPolicyId;
        }
    }

    public partial struct IPSEC_TRAFFIC1_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L731_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L736_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("IPSEC_TRAFFIC_TYPE")]
        public IPSEC_TRAFFIC_TYPE_ trafficType;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L742_C36")]
        public _Anonymous3_e__Union Anonymous3;

        [NativeTypeName("UINT16")]
        public ushort remotePort;

        [NativeTypeName("UINT16")]
        public ushort localPort;

        [NativeTypeName("UINT8")]
        public byte ipProtocol;

        [NativeTypeName("UINT64")]
        public ulong localIfLuid;

        [NativeTypeName("UINT32")]
        public uint realIfProfileId;

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

        [UnscopedRef]
        public ref ulong ipsecFilterId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.ipsecFilterId;
            }
        }

        [UnscopedRef]
        public ref ulong tunnelPolicyId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous3.tunnelPolicyId;
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

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT64")]
            public ulong ipsecFilterId;

            [FieldOffset(0)]
            [NativeTypeName("UINT64")]
            public ulong tunnelPolicyId;
        }
    }

    public partial struct IPSEC_V4_UDP_ENCAPSULATION0_
    {
        [NativeTypeName("UINT16")]
        public ushort localUdpEncapPort;

        [NativeTypeName("UINT16")]
        public ushort remoteUdpEncapPort;
    }

    public unsafe partial struct IPSEC_GETSPI0_
    {
        [NativeTypeName("IPSEC_TRAFFIC0")]
        public IPSEC_TRAFFIC0_ inboundIpsecTraffic;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L765_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("IPSEC_CRYPTO_MODULE_ID *")]
        public Guid* rngCryptoModuleID;

        [UnscopedRef]
        public ref IPSEC_V4_UDP_ENCAPSULATION0_* inboundUdpEncapsulation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.inboundUdpEncapsulation;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_V4_UDP_ENCAPSULATION0 *")]
            public IPSEC_V4_UDP_ENCAPSULATION0_* inboundUdpEncapsulation;
        }
    }

    public unsafe partial struct IPSEC_GETSPI1_
    {
        [NativeTypeName("IPSEC_TRAFFIC1")]
        public IPSEC_TRAFFIC1_ inboundIpsecTraffic;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L778_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("IPSEC_CRYPTO_MODULE_ID *")]
        public Guid* rngCryptoModuleID;

        [UnscopedRef]
        public ref IPSEC_V4_UDP_ENCAPSULATION0_* inboundUdpEncapsulation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.inboundUdpEncapsulation;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_V4_UDP_ENCAPSULATION0 *")]
            public IPSEC_V4_UDP_ENCAPSULATION0_* inboundUdpEncapsulation;
        }
    }

    public unsafe partial struct IPSEC_SA_DETAILS0_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("FWP_DIRECTION")]
        public FWP_DIRECTION_ saDirection;

        [NativeTypeName("IPSEC_TRAFFIC0")]
        public IPSEC_TRAFFIC0_ traffic;

        [NativeTypeName("IPSEC_SA_BUNDLE0")]
        public IPSEC_SA_BUNDLE0_ saBundle;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L793_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("FWPM_FILTER0 *")]
        public FWPM_FILTER0_* transportFilter;

        [UnscopedRef]
        public ref IPSEC_V4_UDP_ENCAPSULATION0_* udpEncapsulation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.udpEncapsulation;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_V4_UDP_ENCAPSULATION0 *")]
            public IPSEC_V4_UDP_ENCAPSULATION0_* udpEncapsulation;
        }
    }

    public unsafe partial struct IPSEC_SA_DETAILS1_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("FWP_DIRECTION")]
        public FWP_DIRECTION_ saDirection;

        [NativeTypeName("IPSEC_TRAFFIC1")]
        public IPSEC_TRAFFIC1_ traffic;

        [NativeTypeName("IPSEC_SA_BUNDLE1")]
        public IPSEC_SA_BUNDLE1_ saBundle;

        [NativeTypeName("__AnonymousRecord_ipsectypes_L808_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("FWPM_FILTER0 *")]
        public FWPM_FILTER0_* transportFilter;

        [NativeTypeName("IPSEC_VIRTUAL_IF_TUNNEL_INFO0")]
        public IPSEC_VIRTUAL_IF_TUNNEL_INFO0_ virtualIfTunnelInfo;

        [UnscopedRef]
        public ref IPSEC_V4_UDP_ENCAPSULATION0_* udpEncapsulation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.udpEncapsulation;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_V4_UDP_ENCAPSULATION0 *")]
            public IPSEC_V4_UDP_ENCAPSULATION0_* udpEncapsulation;
        }
    }

    public unsafe partial struct IPSEC_SA_CONTEXT0_
    {
        [NativeTypeName("UINT64")]
        public ulong saContextId;

        [NativeTypeName("IPSEC_SA_DETAILS0 *")]
        public IPSEC_SA_DETAILS0_* inboundSa;

        [NativeTypeName("IPSEC_SA_DETAILS0 *")]
        public IPSEC_SA_DETAILS0_* outboundSa;
    }

    public unsafe partial struct IPSEC_SA_CONTEXT1_
    {
        [NativeTypeName("UINT64")]
        public ulong saContextId;

        [NativeTypeName("IPSEC_SA_DETAILS1 *")]
        public IPSEC_SA_DETAILS1_* inboundSa;

        [NativeTypeName("IPSEC_SA_DETAILS1 *")]
        public IPSEC_SA_DETAILS1_* outboundSa;
    }

    public partial struct IPSEC_SA_CONTEXT_ENUM_TEMPLATE0_
    {
        [NativeTypeName("FWP_CONDITION_VALUE0")]
        public FWP_CONDITION_VALUE0_ localSubNet;

        [NativeTypeName("FWP_CONDITION_VALUE0")]
        public FWP_CONDITION_VALUE0_ remoteSubNet;
    }

    public partial struct IPSEC_SA_ENUM_TEMPLATE0_
    {
        [NativeTypeName("FWP_DIRECTION")]
        public FWP_DIRECTION_ saDirection;
    }

    public unsafe partial struct IPSEC_SA_CONTEXT_SUBSCRIPTION0_
    {
        [NativeTypeName("IPSEC_SA_CONTEXT_ENUM_TEMPLATE0 *")]
        public IPSEC_SA_CONTEXT_ENUM_TEMPLATE0_* enumTemplate;

        [NativeTypeName("UINT32")]
        public uint flags;

        public Guid sessionKey;
    }

    public enum IPSEC_SA_CONTEXT_EVENT_TYPE0_
    {
        IPSEC_SA_CONTEXT_EVENT_ADD = 1,
        IPSEC_SA_CONTEXT_EVENT_DELETE = (IPSEC_SA_CONTEXT_EVENT_ADD + 1),
        IPSEC_SA_CONTEXT_EVENT_MAX = (IPSEC_SA_CONTEXT_EVENT_DELETE + 1),
    }

    public partial struct IPSEC_SA_CONTEXT_CHANGE0_
    {
        [NativeTypeName("IPSEC_SA_CONTEXT_EVENT_TYPE0")]
        public IPSEC_SA_CONTEXT_EVENT_TYPE0_ changeType;

        [NativeTypeName("UINT64")]
        public ulong saContextId;
    }

    public enum IPSEC_FAILURE_POINT_
    {
        IPSEC_FAILURE_NONE = 0,
        IPSEC_FAILURE_ME = (IPSEC_FAILURE_NONE + 1),
        IPSEC_FAILURE_PEER = (IPSEC_FAILURE_ME + 1),
        IPSEC_FAILURE_POINT_MAX = (IPSEC_FAILURE_PEER + 1),
    }

    public unsafe partial struct IPSEC_ADDRESS_INFO0_
    {
        [NativeTypeName("UINT32")]
        public uint numV4Addresses;

        [NativeTypeName("UINT32 *")]
        public uint* v4Addresses;

        [NativeTypeName("UINT32")]
        public uint numV6Addresses;

        [NativeTypeName("FWP_BYTE_ARRAY16 *")]
        public FWP_BYTE_ARRAY16_* v6Addresses;
    }

    public unsafe partial struct IPSEC_DOSP_OPTIONS0_
    {
        [NativeTypeName("UINT32")]
        public uint stateIdleTimeoutSeconds;

        [NativeTypeName("UINT32")]
        public uint perIPRateLimitQueueIdleTimeoutSeconds;

        [NativeTypeName("UINT8")]
        public byte ipV6IPsecUnauthDscp;

        [NativeTypeName("UINT32")]
        public uint ipV6IPsecUnauthRateLimitBytesPerSec;

        [NativeTypeName("UINT32")]
        public uint ipV6IPsecUnauthPerIPRateLimitBytesPerSec;

        [NativeTypeName("UINT8")]
        public byte ipV6IPsecAuthDscp;

        [NativeTypeName("UINT32")]
        public uint ipV6IPsecAuthRateLimitBytesPerSec;

        [NativeTypeName("UINT8")]
        public byte icmpV6Dscp;

        [NativeTypeName("UINT32")]
        public uint icmpV6RateLimitBytesPerSec;

        [NativeTypeName("UINT8")]
        public byte ipV6FilterExemptDscp;

        [NativeTypeName("UINT32")]
        public uint ipV6FilterExemptRateLimitBytesPerSec;

        [NativeTypeName("UINT8")]
        public byte defBlockExemptDscp;

        [NativeTypeName("UINT32")]
        public uint defBlockExemptRateLimitBytesPerSec;

        [NativeTypeName("UINT32")]
        public uint maxStateEntries;

        [NativeTypeName("UINT32")]
        public uint maxPerIPRateLimitQueues;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint numPublicIFLuids;

        [NativeTypeName("UINT64 *")]
        public ulong* publicIFLuids;

        [NativeTypeName("UINT32")]
        public uint numInternalIFLuids;

        [NativeTypeName("UINT64 *")]
        public ulong* internalIFLuids;

        [NativeTypeName("FWP_V6_ADDR_AND_MASK")]
        public FWP_V6_ADDR_AND_MASK_ publicV6AddrMask;

        [NativeTypeName("FWP_V6_ADDR_AND_MASK")]
        public FWP_V6_ADDR_AND_MASK_ internalV6AddrMask;
    }

    public partial struct IPSEC_DOSP_STATISTICS0_
    {
        [NativeTypeName("UINT64")]
        public ulong totalStateEntriesCreated;

        [NativeTypeName("UINT64")]
        public ulong currentStateEntries;

        [NativeTypeName("UINT64")]
        public ulong totalInboundAllowedIPv6IPsecUnauthPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundRatelimitDiscardedIPv6IPsecUnauthPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundPerIPRatelimitDiscardedIPv6IPsecUnauthPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundOtherDiscardedIPv6IPsecUnauthPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundAllowedIPv6IPsecAuthPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundRatelimitDiscardedIPv6IPsecAuthPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundOtherDiscardedIPv6IPsecAuthPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundAllowedICMPv6Pkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundRatelimitDiscardedICMPv6Pkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundAllowedIPv6FilterExemptPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundRatelimitDiscardedIPv6FilterExemptPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundDiscardedIPv6FilterBlockPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundAllowedDefBlockExemptPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundRatelimitDiscardedDefBlockExemptPkts;

        [NativeTypeName("UINT64")]
        public ulong totalInboundDiscardedDefBlockPkts;

        [NativeTypeName("UINT64")]
        public ulong currentInboundIPv6IPsecUnauthPerIPRateLimitQueues;
    }

    public partial struct IPSEC_DOSP_STATE0_
    {
        [NativeTypeName("UINT8[16]")]
        public _publicHostV6Addr_e__FixedBuffer publicHostV6Addr;

        [NativeTypeName("UINT8[16]")]
        public _internalHostV6Addr_e__FixedBuffer internalHostV6Addr;

        [NativeTypeName("UINT64")]
        public ulong totalInboundIPv6IPsecAuthPackets;

        [NativeTypeName("UINT64")]
        public ulong totalOutboundIPv6IPsecAuthPackets;

        [NativeTypeName("UINT32")]
        public uint durationSecs;

        [InlineArray(16)]
        public partial struct _publicHostV6Addr_e__FixedBuffer
        {
            public byte e0;
        }

        [InlineArray(16)]
        public partial struct _internalHostV6Addr_e__FixedBuffer
        {
            public byte e0;
        }
    }

    public partial struct IPSEC_DOSP_STATE_ENUM_TEMPLATE0_
    {
        [NativeTypeName("FWP_V6_ADDR_AND_MASK")]
        public FWP_V6_ADDR_AND_MASK_ publicV6AddrMask;

        [NativeTypeName("FWP_V6_ADDR_AND_MASK")]
        public FWP_V6_ADDR_AND_MASK_ internalV6AddrMask;
    }

    public partial struct _IPSEC_KEY_MANAGER0
    {
        public Guid keyManagerKey;

        [NativeTypeName("FWPM_DISPLAY_DATA0")]
        public FWPM_DISPLAY_DATA0_ displayData;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT8")]
        public byte keyDictationTimeoutHint;
    }

    public static partial class Methods
    {
        [NativeTypeName("#define IPSEC_AUTH_CONFIG_HMAC_MD5_96 (0)")]
        public const int IPSEC_AUTH_CONFIG_HMAC_MD5_96 = (0);

        [NativeTypeName("#define IPSEC_AUTH_CONFIG_HMAC_SHA_1_96 (1)")]
        public const int IPSEC_AUTH_CONFIG_HMAC_SHA_1_96 = (1);

        [NativeTypeName("#define IPSEC_AUTH_CONFIG_HMAC_SHA_256_128 (2)")]
        public const int IPSEC_AUTH_CONFIG_HMAC_SHA_256_128 = (2);

        [NativeTypeName("#define IPSEC_AUTH_CONFIG_GCM_AES_128 (3)")]
        public const int IPSEC_AUTH_CONFIG_GCM_AES_128 = (3);

        [NativeTypeName("#define IPSEC_AUTH_CONFIG_GCM_AES_192 (4)")]
        public const int IPSEC_AUTH_CONFIG_GCM_AES_192 = (4);

        [NativeTypeName("#define IPSEC_AUTH_CONFIG_GCM_AES_256 (5)")]
        public const int IPSEC_AUTH_CONFIG_GCM_AES_256 = (5);

        [NativeTypeName("#define IPSEC_AUTH_CONFIG_MAX (6)")]
        public const int IPSEC_AUTH_CONFIG_MAX = (6);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_CBC_DES (1)")]
        public const int IPSEC_CIPHER_CONFIG_CBC_DES = (1);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_CBC_3DES (2)")]
        public const int IPSEC_CIPHER_CONFIG_CBC_3DES = (2);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_CBC_AES_128 (3)")]
        public const int IPSEC_CIPHER_CONFIG_CBC_AES_128 = (3);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_CBC_AES_192 (4)")]
        public const int IPSEC_CIPHER_CONFIG_CBC_AES_192 = (4);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_CBC_AES_256 (5)")]
        public const int IPSEC_CIPHER_CONFIG_CBC_AES_256 = (5);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_GCM_AES_128 (6)")]
        public const int IPSEC_CIPHER_CONFIG_GCM_AES_128 = (6);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_GCM_AES_192 (7)")]
        public const int IPSEC_CIPHER_CONFIG_GCM_AES_192 = (7);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_GCM_AES_256 (8)")]
        public const int IPSEC_CIPHER_CONFIG_GCM_AES_256 = (8);

        [NativeTypeName("#define IPSEC_CIPHER_CONFIG_MAX (9)")]
        public const int IPSEC_CIPHER_CONFIG_MAX = (9);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_ND_SECURE (0x00000002)")]
        public const int IPSEC_POLICY_FLAG_ND_SECURE = (0x00000002);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_ND_BOUNDARY (0x00000004)")]
        public const int IPSEC_POLICY_FLAG_ND_BOUNDARY = (0x00000004);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_CLEAR_DF_ON_TUNNEL (0x00000008)")]
        public const int IPSEC_POLICY_FLAG_CLEAR_DF_ON_TUNNEL = (0x00000008);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_NAT_ENCAP_ALLOW_PEER_BEHIND_NAT (0x00000010)")]
        public const int IPSEC_POLICY_FLAG_NAT_ENCAP_ALLOW_PEER_BEHIND_NAT = (0x00000010);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_NAT_ENCAP_ALLOW_GENERAL_NAT_TRAVERSAL (0x00000020)")]
        public const int IPSEC_POLICY_FLAG_NAT_ENCAP_ALLOW_GENERAL_NAT_TRAVERSAL = (0x00000020);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_DONT_NEGOTIATE_SECOND_LIFETIME (0x00000040)")]
        public const int IPSEC_POLICY_FLAG_DONT_NEGOTIATE_SECOND_LIFETIME = (0x00000040);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_DONT_NEGOTIATE_BYTE_LIFETIME (0x00000080)")]
        public const int IPSEC_POLICY_FLAG_DONT_NEGOTIATE_BYTE_LIFETIME = (0x00000080);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_ENABLE_V6_IN_V4_TUNNELING (0x00000100)")]
        public const int IPSEC_POLICY_FLAG_ENABLE_V6_IN_V4_TUNNELING = (0x00000100);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_ENABLE_SERVER_ADDR_ASSIGNMENT (0x00000200)")]
        public const int IPSEC_POLICY_FLAG_ENABLE_SERVER_ADDR_ASSIGNMENT = (0x00000200);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_TUNNEL_ALLOW_OUTBOUND_CLEAR_CONNECTION (0x00000400)")]
        public const int IPSEC_POLICY_FLAG_TUNNEL_ALLOW_OUTBOUND_CLEAR_CONNECTION = (0x00000400);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_TUNNEL_BYPASS_ALREADY_SECURE_CONNECTION (0x00000800)")]
        public const int IPSEC_POLICY_FLAG_TUNNEL_BYPASS_ALREADY_SECURE_CONNECTION = (0x00000800);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_TUNNEL_BYPASS_ICMPV6 (0x00001000)")]
        public const int IPSEC_POLICY_FLAG_TUNNEL_BYPASS_ICMPV6 = (0x00001000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_KEY_MANAGER_ALLOW_DICTATE_KEY (0x00002000)")]
        public const int IPSEC_POLICY_FLAG_KEY_MANAGER_ALLOW_DICTATE_KEY = (0x00002000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_KEY_MANAGER_ALLOW_NOTIFY_KEY (0x00004000)")]
        public const int IPSEC_POLICY_FLAG_KEY_MANAGER_ALLOW_NOTIFY_KEY = (0x00004000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_RESERVED1 (0x00008000)")]
        public const int IPSEC_POLICY_FLAG_RESERVED1 = (0x00008000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_SITE_TO_SITE_TUNNEL (0x00010000)")]
        public const int IPSEC_POLICY_FLAG_SITE_TO_SITE_TUNNEL = (0x00010000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_POINT_TO_SITE_TUNNEL (0x00020000)")]
        public const int IPSEC_POLICY_FLAG_POINT_TO_SITE_TUNNEL = (0x00020000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_BANDWIDTH1 (0x10000000)")]
        public const int IPSEC_POLICY_FLAG_BANDWIDTH1 = (0x10000000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_BANDWIDTH2 (0x20000000)")]
        public const int IPSEC_POLICY_FLAG_BANDWIDTH2 = (0x20000000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_BANDWIDTH3 (0x40000000)")]
        public const int IPSEC_POLICY_FLAG_BANDWIDTH3 = (0x40000000);

        [NativeTypeName("#define IPSEC_POLICY_FLAG_BANDWIDTH4 (0x80000000)")]
        public const uint IPSEC_POLICY_FLAG_BANDWIDTH4 = (0x80000000);

        [NativeTypeName("#define IPSEC_KEYING_POLICY_FLAG_TERMINATING_MATCH (0x00000001)")]
        public const int IPSEC_KEYING_POLICY_FLAG_TERMINATING_MATCH = (0x00000001);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_ND_SECURE (0x00000001)")]
        public const int IPSEC_SA_BUNDLE_FLAG_ND_SECURE = (0x00000001);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_ND_BOUNDARY (0x00000002)")]
        public const int IPSEC_SA_BUNDLE_FLAG_ND_BOUNDARY = (0x00000002);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_ND_PEER_NAT_BOUNDARY (0x00000004)")]
        public const int IPSEC_SA_BUNDLE_FLAG_ND_PEER_NAT_BOUNDARY = (0x00000004);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_GUARANTEE_ENCRYPTION (0x00000008)")]
        public const int IPSEC_SA_BUNDLE_FLAG_GUARANTEE_ENCRYPTION = (0x00000008);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_NLB (0x00000010)")]
        public const int IPSEC_SA_BUNDLE_FLAG_NLB = (0x00000010);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_NO_MACHINE_LUID_VERIFY (0x00000020)")]
        public const int IPSEC_SA_BUNDLE_FLAG_NO_MACHINE_LUID_VERIFY = (0x00000020);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_NO_IMPERSONATION_LUID_VERIFY (0x00000040)")]
        public const int IPSEC_SA_BUNDLE_FLAG_NO_IMPERSONATION_LUID_VERIFY = (0x00000040);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_NO_EXPLICIT_CRED_MATCH (0x00000080)")]
        public const int IPSEC_SA_BUNDLE_FLAG_NO_EXPLICIT_CRED_MATCH = (0x00000080);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_ALLOW_NULL_TARGET_NAME_MATCH (0x00000200)")]
        public const int IPSEC_SA_BUNDLE_FLAG_ALLOW_NULL_TARGET_NAME_MATCH = (0x00000200);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_CLEAR_DF_ON_TUNNEL (0x00000400)")]
        public const int IPSEC_SA_BUNDLE_FLAG_CLEAR_DF_ON_TUNNEL = (0x00000400);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_ASSUME_UDP_CONTEXT_OUTBOUND (0x00000800)")]
        public const int IPSEC_SA_BUNDLE_FLAG_ASSUME_UDP_CONTEXT_OUTBOUND = (0x00000800);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_ND_PEER_BOUNDARY (0x00001000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_ND_PEER_BOUNDARY = (0x00001000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_SUPPRESS_DUPLICATE_DELETION (0x00002000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_SUPPRESS_DUPLICATE_DELETION = (0x00002000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_PEER_SUPPORTS_GUARANTEE_ENCRYPTION (0x00004000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_PEER_SUPPORTS_GUARANTEE_ENCRYPTION = (0x00004000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_FORCE_INBOUND_CONNECTIONS (0x00008000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_FORCE_INBOUND_CONNECTIONS = (0x00008000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_FORCE_OUTBOUND_CONNECTIONS (0x00010000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_FORCE_OUTBOUND_CONNECTIONS = (0x00010000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_FORWARD_PATH_INITIATOR (0x00020000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_FORWARD_PATH_INITIATOR = (0x00020000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_ENABLE_OPTIONAL_ASYMMETRIC_IDLE (0x0040000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_ENABLE_OPTIONAL_ASYMMETRIC_IDLE = (0x0040000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_USING_DICTATED_KEYS (0x00080000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_USING_DICTATED_KEYS = (0x00080000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_LOCALLY_DICTATED_KEYS (0x00100000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_LOCALLY_DICTATED_KEYS = (0x00100000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_SA_OFFLOADED (0x00200000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_SA_OFFLOADED = (0x00200000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_IP_IN_IP_PKT (0x00400000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_IP_IN_IP_PKT = (0x00400000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_LOW_POWER_MODE_SUPPORT (0x00800000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_LOW_POWER_MODE_SUPPORT = (0x00800000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_TUNNEL_BANDWIDTH1 (0x10000000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_TUNNEL_BANDWIDTH1 = (0x10000000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_TUNNEL_BANDWIDTH2 (0x20000000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_TUNNEL_BANDWIDTH2 = (0x20000000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_TUNNEL_BANDWIDTH3 (0x40000000)")]
        public const int IPSEC_SA_BUNDLE_FLAG_TUNNEL_BANDWIDTH3 = (0x40000000);

        [NativeTypeName("#define IPSEC_SA_BUNDLE_FLAG_TUNNEL_BANDWIDTH4 (0x80000000)")]
        public const uint IPSEC_SA_BUNDLE_FLAG_TUNNEL_BANDWIDTH4 = (0x80000000);

        [NativeTypeName("#define IPSEC_DOSP_FLAG_ENABLE_IKEV1 (0x00000001)")]
        public const int IPSEC_DOSP_FLAG_ENABLE_IKEV1 = (0x00000001);

        [NativeTypeName("#define IPSEC_DOSP_FLAG_ENABLE_IKEV2 (0x00000002)")]
        public const int IPSEC_DOSP_FLAG_ENABLE_IKEV2 = (0x00000002);

        [NativeTypeName("#define IPSEC_DOSP_FLAG_DISABLE_AUTHIP (0x00000004)")]
        public const int IPSEC_DOSP_FLAG_DISABLE_AUTHIP = (0x00000004);

        [NativeTypeName("#define IPSEC_DOSP_FLAG_DISABLE_DEFAULT_BLOCK (0x00000008)")]
        public const int IPSEC_DOSP_FLAG_DISABLE_DEFAULT_BLOCK = (0x00000008);

        [NativeTypeName("#define IPSEC_DOSP_FLAG_FILTER_BLOCK (0x00000010)")]
        public const int IPSEC_DOSP_FLAG_FILTER_BLOCK = (0x00000010);

        [NativeTypeName("#define IPSEC_DOSP_FLAG_FILTER_EXEMPT (0x00000020)")]
        public const int IPSEC_DOSP_FLAG_FILTER_EXEMPT = (0x00000020);

        [NativeTypeName("#define IPSEC_DOSP_DSCP_DISABLE_VALUE (0xff)")]
        public const int IPSEC_DOSP_DSCP_DISABLE_VALUE = (0xff);

        [NativeTypeName("#define IPSEC_DOSP_RATE_LIMIT_DISABLE_VALUE (0)")]
        public const int IPSEC_DOSP_RATE_LIMIT_DISABLE_VALUE = (0);

        [NativeTypeName("#define IPSEC_KEY_MANAGER_FLAG_DICTATE_KEY (0x00000001)")]
        public const int IPSEC_KEY_MANAGER_FLAG_DICTATE_KEY = (0x00000001);
    }
}
