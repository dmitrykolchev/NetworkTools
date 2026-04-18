using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Managed.Win32.Ike.Native
{
    public enum IKEEXT_KEY_MODULE_TYPE_
    {
        IKEEXT_KEY_MODULE_IKE = 0,
        IKEEXT_KEY_MODULE_AUTHIP = (IKEEXT_KEY_MODULE_IKE + 1),
        IKEEXT_KEY_MODULE_IKEV2 = (IKEEXT_KEY_MODULE_AUTHIP + 1),
        IKEEXT_KEY_MODULE_MAX = (IKEEXT_KEY_MODULE_IKEV2 + 1),
    }

    public enum IKEEXT_AUTHENTICATION_METHOD_TYPE_
    {
        IKEEXT_PRESHARED_KEY = 0,
        IKEEXT_CERTIFICATE = (IKEEXT_PRESHARED_KEY + 1),
        IKEEXT_KERBEROS = (IKEEXT_CERTIFICATE + 1),
        IKEEXT_ANONYMOUS = (IKEEXT_KERBEROS + 1),
        IKEEXT_SSL = (IKEEXT_ANONYMOUS + 1),
        IKEEXT_NTLM_V2 = (IKEEXT_SSL + 1),
        IKEEXT_IPV6_CGA = (IKEEXT_NTLM_V2 + 1),
        IKEEXT_CERTIFICATE_ECDSA_P256 = (IKEEXT_IPV6_CGA + 1),
        IKEEXT_CERTIFICATE_ECDSA_P384 = (IKEEXT_CERTIFICATE_ECDSA_P256 + 1),
        IKEEXT_SSL_ECDSA_P256 = (IKEEXT_CERTIFICATE_ECDSA_P384 + 1),
        IKEEXT_SSL_ECDSA_P384 = (IKEEXT_SSL_ECDSA_P256 + 1),
        IKEEXT_EAP = (IKEEXT_SSL_ECDSA_P384 + 1),
        IKEEXT_RESERVED = (IKEEXT_EAP + 1),
        IKEEXT_AUTHENTICATION_METHOD_TYPE_MAX = (IKEEXT_RESERVED + 1),
    }

    public enum IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_
    {
        IKEEXT_IMPERSONATION_NONE = 0,
        IKEEXT_IMPERSONATION_SOCKET_PRINCIPAL = (IKEEXT_IMPERSONATION_NONE + 1),
        IKEEXT_IMPERSONATION_MAX = (IKEEXT_IMPERSONATION_SOCKET_PRINCIPAL + 1),
    }

    public partial struct IKEEXT_PRESHARED_KEY_AUTHENTICATION0__
    {
        public FWP_BYTE_BLOB presharedKey;
    }

    public partial struct IKEEXT_PRESHARED_KEY_AUTHENTICATION1__
    {
        public FWP_BYTE_BLOB presharedKey;

        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public partial struct IKEEXT_CERT_ROOT_CONFIG0_
    {
        public FWP_BYTE_BLOB certData;

        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public enum IKEEXT_CERT_CONFIG_TYPE_
    {
        IKEEXT_CERT_CONFIG_EXPLICIT_TRUST_LIST = 0,
        IKEEXT_CERT_CONFIG_ENTERPRISE_STORE = (IKEEXT_CERT_CONFIG_EXPLICIT_TRUST_LIST + 1),
        IKEEXT_CERT_CONFIG_TRUSTED_ROOT_STORE = (IKEEXT_CERT_CONFIG_ENTERPRISE_STORE + 1),
        IKEEXT_CERT_CONFIG_UNSPECIFIED = (IKEEXT_CERT_CONFIG_TRUSTED_ROOT_STORE + 1),
        IKEEXT_CERT_CONFIG_TYPE_MAX = (IKEEXT_CERT_CONFIG_UNSPECIFIED + 1),
    }

    public unsafe partial struct IKEEXT_CERTIFICATE_AUTHENTICATION0_
    {
        [NativeTypeName("IKEEXT_CERT_CONFIG_TYPE")]
        public IKEEXT_CERT_CONFIG_TYPE_ inboundConfigType;

        [NativeTypeName("__AnonymousRecord_iketypes_L169_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("IKEEXT_CERT_CONFIG_TYPE")]
        public IKEEXT_CERT_CONFIG_TYPE_ outboundConfigType;

        [NativeTypeName("__AnonymousRecord_iketypes_L180_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT32")]
        public uint flags;

        [UnscopedRef]
        public ref uint inboundRootArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous.inboundRootArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* inboundRootArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous.inboundRootArray;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* inboundEnterpriseStoreConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.inboundEnterpriseStoreConfig;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* inboundTrustedRootStoreConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.inboundTrustedRootStoreConfig;
            }
        }

        [UnscopedRef]
        public ref uint outboundRootArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous.outboundRootArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* outboundRootArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous.outboundRootArray;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* outboundEnterpriseStoreConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.outboundEnterpriseStoreConfig;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* outboundTrustedRootStoreConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.outboundTrustedRootStoreConfig;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L171_C24")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
            public IKEEXT_CERT_ROOT_CONFIG0_* inboundEnterpriseStoreConfig;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
            public IKEEXT_CERT_ROOT_CONFIG0_* inboundTrustedRootStoreConfig;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint inboundRootArraySize;

                [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
                public IKEEXT_CERT_ROOT_CONFIG0_* inboundRootArray;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L182_C24")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
            public IKEEXT_CERT_ROOT_CONFIG0_* outboundEnterpriseStoreConfig;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
            public IKEEXT_CERT_ROOT_CONFIG0_* outboundTrustedRootStoreConfig;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint outboundRootArraySize;

                [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
                public IKEEXT_CERT_ROOT_CONFIG0_* outboundRootArray;
            }
        }
    }

    public unsafe partial struct IKEEXT_CERTIFICATE_AUTHENTICATION1_
    {
        [NativeTypeName("IKEEXT_CERT_CONFIG_TYPE")]
        public IKEEXT_CERT_CONFIG_TYPE_ inboundConfigType;

        [NativeTypeName("__AnonymousRecord_iketypes_L197_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("IKEEXT_CERT_CONFIG_TYPE")]
        public IKEEXT_CERT_CONFIG_TYPE_ outboundConfigType;

        [NativeTypeName("__AnonymousRecord_iketypes_L209_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT32")]
        public uint flags;

        public FWP_BYTE_BLOB localCertLocationUrl;

        [UnscopedRef]
        public ref uint inboundRootArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous.inboundRootArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* inboundRootArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous.inboundRootArray;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* inboundEnterpriseStoreConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.inboundEnterpriseStoreConfig;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* inboundTrustedRootStoreConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.inboundTrustedRootStoreConfig;
            }
        }

        [UnscopedRef]
        public ref uint outboundRootArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous.outboundRootArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* outboundRootArray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous.outboundRootArray;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* outboundEnterpriseStoreConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.outboundEnterpriseStoreConfig;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERT_ROOT_CONFIG0_* outboundTrustedRootStoreConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.outboundTrustedRootStoreConfig;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L199_C24")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
            public IKEEXT_CERT_ROOT_CONFIG0_* inboundEnterpriseStoreConfig;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
            public IKEEXT_CERT_ROOT_CONFIG0_* inboundTrustedRootStoreConfig;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint inboundRootArraySize;

                [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
                public IKEEXT_CERT_ROOT_CONFIG0_* inboundRootArray;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L211_C24")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
            public IKEEXT_CERT_ROOT_CONFIG0_* outboundEnterpriseStoreConfig;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
            public IKEEXT_CERT_ROOT_CONFIG0_* outboundTrustedRootStoreConfig;

            public unsafe partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint outboundRootArraySize;

                [NativeTypeName("IKEEXT_CERT_ROOT_CONFIG0 *")]
                public IKEEXT_CERT_ROOT_CONFIG0_* outboundRootArray;
            }
        }
    }

    public enum IKEEXT_CERT_CRITERIA_NAME_TYPE_
    {
        IKEEXT_CERT_CRITERIA_DNS = 0,
        IKEEXT_CERT_CRITERIA_UPN = (IKEEXT_CERT_CRITERIA_DNS + 1),
        IKEEXT_CERT_CRITERIA_RFC822 = (IKEEXT_CERT_CRITERIA_UPN + 1),
        IKEEXT_CERT_CRITERIA_CN = (IKEEXT_CERT_CRITERIA_RFC822 + 1),
        IKEEXT_CERT_CRITERIA_OU = (IKEEXT_CERT_CRITERIA_CN + 1),
        IKEEXT_CERT_CRITERIA_O = (IKEEXT_CERT_CRITERIA_OU + 1),
        IKEEXT_CERT_CRITERIA_DC = (IKEEXT_CERT_CRITERIA_O + 1),
        IKEEXT_CERT_CRITERIA_NAME_TYPE_MAX = (IKEEXT_CERT_CRITERIA_DC + 1),
    }

    public unsafe partial struct IKEEXT_CERT_EKUS0_
    {
        [NativeTypeName("ULONG")]
        public uint numEku;

        [NativeTypeName("LPSTR *")]
        public sbyte** eku;
    }

    public unsafe partial struct IKEEXT_CERT_NAME0_
    {
        [NativeTypeName("IKEEXT_CERT_CRITERIA_NAME_TYPE")]
        public IKEEXT_CERT_CRITERIA_NAME_TYPE_ nameType;

        [NativeTypeName("LPWSTR")]
        public char* certName;
    }

    public unsafe partial struct IKEEXT_CERTIFICATE_CRITERIA0_
    {
        public FWP_BYTE_BLOB certData;

        public FWP_BYTE_BLOB certHash;

        [NativeTypeName("IKEEXT_CERT_EKUS0 *")]
        public IKEEXT_CERT_EKUS0_* eku;

        [NativeTypeName("IKEEXT_CERT_NAME0 *")]
        public IKEEXT_CERT_NAME0_* name;

        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public unsafe partial struct IKEEXT_CERTIFICATE_AUTHENTICATION2_
    {
        [NativeTypeName("IKEEXT_CERT_CONFIG_TYPE")]
        public IKEEXT_CERT_CONFIG_TYPE_ inboundConfigType;

        [NativeTypeName("__AnonymousRecord_iketypes_L263_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("IKEEXT_CERT_CONFIG_TYPE")]
        public IKEEXT_CERT_CONFIG_TYPE_ outboundConfigType;

        [NativeTypeName("__AnonymousRecord_iketypes_L283_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT32")]
        public uint flags;

        public FWP_BYTE_BLOB localCertLocationUrl;

        [UnscopedRef]
        public ref uint inboundRootArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1.inboundRootArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CRITERIA0_* inboundRootCriteria
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous1.inboundRootCriteria;
            }
        }

        [UnscopedRef]
        public ref uint inboundEnterpriseStoreArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous2.inboundEnterpriseStoreArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CRITERIA0_* inboundEnterpriseStoreCriteria
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous2.inboundEnterpriseStoreCriteria;
            }
        }

        [UnscopedRef]
        public ref uint inboundRootStoreArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous3.inboundRootStoreArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CRITERIA0_* inboundTrustedRootStoreCriteria
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous1.Anonymous3.inboundTrustedRootStoreCriteria;
            }
        }

        [UnscopedRef]
        public ref uint outboundRootArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous1.outboundRootArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CRITERIA0_* outboundRootCriteria
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous1.outboundRootCriteria;
            }
        }

        [UnscopedRef]
        public ref uint outboundEnterpriseStoreArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous2.outboundEnterpriseStoreArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CRITERIA0_* outboundEnterpriseStoreCriteria
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous2.outboundEnterpriseStoreCriteria;
            }
        }

        [UnscopedRef]
        public ref uint outboundRootStoreArraySize
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous3.outboundRootStoreArraySize;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CRITERIA0_* outboundTrustedRootStoreCriteria
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous2.Anonymous3.outboundTrustedRootStoreCriteria;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L265_C24")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L270_C24")]
            public _Anonymous2_e__Struct Anonymous2;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L275_C24")]
            public _Anonymous3_e__Struct Anonymous3;

            public unsafe partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint inboundRootArraySize;

                [NativeTypeName("IKEEXT_CERTIFICATE_CRITERIA0 *")]
                public IKEEXT_CERTIFICATE_CRITERIA0_* inboundRootCriteria;
            }

            public unsafe partial struct _Anonymous2_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint inboundEnterpriseStoreArraySize;

                [NativeTypeName("IKEEXT_CERTIFICATE_CRITERIA0 *")]
                public IKEEXT_CERTIFICATE_CRITERIA0_* inboundEnterpriseStoreCriteria;
            }

            public unsafe partial struct _Anonymous3_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint inboundRootStoreArraySize;

                [NativeTypeName("IKEEXT_CERTIFICATE_CRITERIA0 *")]
                public IKEEXT_CERTIFICATE_CRITERIA0_* inboundTrustedRootStoreCriteria;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L285_C24")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L290_C24")]
            public _Anonymous2_e__Struct Anonymous2;

            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_iketypes_L295_C24")]
            public _Anonymous3_e__Struct Anonymous3;

            public unsafe partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint outboundRootArraySize;

                [NativeTypeName("IKEEXT_CERTIFICATE_CRITERIA0 *")]
                public IKEEXT_CERTIFICATE_CRITERIA0_* outboundRootCriteria;
            }

            public unsafe partial struct _Anonymous2_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint outboundEnterpriseStoreArraySize;

                [NativeTypeName("IKEEXT_CERTIFICATE_CRITERIA0 *")]
                public IKEEXT_CERTIFICATE_CRITERIA0_* outboundEnterpriseStoreCriteria;
            }

            public unsafe partial struct _Anonymous3_e__Struct
            {
                [NativeTypeName("UINT32")]
                public uint outboundRootStoreArraySize;

                [NativeTypeName("IKEEXT_CERTIFICATE_CRITERIA0 *")]
                public IKEEXT_CERTIFICATE_CRITERIA0_* outboundTrustedRootStoreCriteria;
            }
        }
    }

    public unsafe partial struct IKEEXT_IPV6_CGA_AUTHENTICATION0_
    {
        [NativeTypeName("wchar_t *")]
        public char* keyContainerName;

        [NativeTypeName("wchar_t *")]
        public char* cspName;

        [NativeTypeName("UINT32")]
        public uint cspType;

        [NativeTypeName("FWP_BYTE_ARRAY16")]
        public FWP_BYTE_ARRAY16_ cgaModifier;

        public byte cgaCollisionCount;
    }

    public partial struct IKEEXT_KERBEROS_AUTHENTICATION0__
    {
        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public unsafe partial struct IKEEXT_KERBEROS_AUTHENTICATION1__
    {
        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("wchar_t *")]
        public char* proxyServer;
    }

    public partial struct IKEEXT_RESERVED_AUTHENTICATION0__
    {
        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public partial struct IKEEXT_NTLM_V2_AUTHENTICATION0__
    {
        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public partial struct IKEEXT_EAP_AUTHENTICATION0__
    {
        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public partial struct IKEEXT_AUTHENTICATION_METHOD0_
    {
        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ authenticationMethodType;

        [NativeTypeName("__AnonymousRecord_iketypes_L356_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref IKEEXT_PRESHARED_KEY_AUTHENTICATION0__ presharedKeyAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.presharedKeyAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_AUTHENTICATION0_ certificateAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.certificateAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_KERBEROS_AUTHENTICATION0__ kerberosAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.kerberosAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_NTLM_V2_AUTHENTICATION0__ ntlmV2Authentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ntlmV2Authentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_AUTHENTICATION0_ sslAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sslAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_IPV6_CGA_AUTHENTICATION0_ cgaAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.cgaAuthentication;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_PRESHARED_KEY_AUTHENTICATION0")]
            public IKEEXT_PRESHARED_KEY_AUTHENTICATION0__ presharedKeyAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_AUTHENTICATION0")]
            public IKEEXT_CERTIFICATE_AUTHENTICATION0_ certificateAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_KERBEROS_AUTHENTICATION0")]
            public IKEEXT_KERBEROS_AUTHENTICATION0__ kerberosAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_NTLM_V2_AUTHENTICATION0")]
            public IKEEXT_NTLM_V2_AUTHENTICATION0__ ntlmV2Authentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_AUTHENTICATION0")]
            public IKEEXT_CERTIFICATE_AUTHENTICATION0_ sslAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_IPV6_CGA_AUTHENTICATION0")]
            public IKEEXT_IPV6_CGA_AUTHENTICATION0_ cgaAuthentication;
        }
    }

    public partial struct IKEEXT_AUTHENTICATION_METHOD1_
    {
        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ authenticationMethodType;

        [NativeTypeName("__AnonymousRecord_iketypes_L372_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref IKEEXT_PRESHARED_KEY_AUTHENTICATION1__ presharedKeyAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.presharedKeyAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_AUTHENTICATION1_ certificateAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.certificateAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_KERBEROS_AUTHENTICATION0__ kerberosAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.kerberosAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_NTLM_V2_AUTHENTICATION0__ ntlmV2Authentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ntlmV2Authentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_AUTHENTICATION1_ sslAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sslAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_IPV6_CGA_AUTHENTICATION0_ cgaAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.cgaAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_EAP_AUTHENTICATION0__ eapAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.eapAuthentication;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_PRESHARED_KEY_AUTHENTICATION1")]
            public IKEEXT_PRESHARED_KEY_AUTHENTICATION1__ presharedKeyAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_AUTHENTICATION1")]
            public IKEEXT_CERTIFICATE_AUTHENTICATION1_ certificateAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_KERBEROS_AUTHENTICATION0")]
            public IKEEXT_KERBEROS_AUTHENTICATION0__ kerberosAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_NTLM_V2_AUTHENTICATION0")]
            public IKEEXT_NTLM_V2_AUTHENTICATION0__ ntlmV2Authentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_AUTHENTICATION1")]
            public IKEEXT_CERTIFICATE_AUTHENTICATION1_ sslAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_IPV6_CGA_AUTHENTICATION0")]
            public IKEEXT_IPV6_CGA_AUTHENTICATION0_ cgaAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_EAP_AUTHENTICATION0")]
            public IKEEXT_EAP_AUTHENTICATION0__ eapAuthentication;
        }
    }

    public partial struct IKEEXT_AUTHENTICATION_METHOD2_
    {
        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ authenticationMethodType;

        [NativeTypeName("__AnonymousRecord_iketypes_L390_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref IKEEXT_PRESHARED_KEY_AUTHENTICATION1__ presharedKeyAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.presharedKeyAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_AUTHENTICATION2_ certificateAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.certificateAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_KERBEROS_AUTHENTICATION1__ kerberosAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.kerberosAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_RESERVED_AUTHENTICATION0__ reservedAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.reservedAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_NTLM_V2_AUTHENTICATION0__ ntlmV2Authentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.ntlmV2Authentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_AUTHENTICATION2_ sslAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.sslAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_IPV6_CGA_AUTHENTICATION0_ cgaAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.cgaAuthentication;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_EAP_AUTHENTICATION0__ eapAuthentication
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.eapAuthentication;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_PRESHARED_KEY_AUTHENTICATION1")]
            public IKEEXT_PRESHARED_KEY_AUTHENTICATION1__ presharedKeyAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_AUTHENTICATION2")]
            public IKEEXT_CERTIFICATE_AUTHENTICATION2_ certificateAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_KERBEROS_AUTHENTICATION1")]
            public IKEEXT_KERBEROS_AUTHENTICATION1__ kerberosAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_RESERVED_AUTHENTICATION0")]
            public IKEEXT_RESERVED_AUTHENTICATION0__ reservedAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_NTLM_V2_AUTHENTICATION0")]
            public IKEEXT_NTLM_V2_AUTHENTICATION0__ ntlmV2Authentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_AUTHENTICATION2")]
            public IKEEXT_CERTIFICATE_AUTHENTICATION2_ sslAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_IPV6_CGA_AUTHENTICATION0")]
            public IKEEXT_IPV6_CGA_AUTHENTICATION0_ cgaAuthentication;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_EAP_AUTHENTICATION0")]
            public IKEEXT_EAP_AUTHENTICATION0__ eapAuthentication;
        }
    }

    public enum IKEEXT_CIPHER_TYPE_
    {
        IKEEXT_CIPHER_DES = 0,
        IKEEXT_CIPHER_3DES = (IKEEXT_CIPHER_DES + 1),
        IKEEXT_CIPHER_AES_128 = (IKEEXT_CIPHER_3DES + 1),
        IKEEXT_CIPHER_AES_192 = (IKEEXT_CIPHER_AES_128 + 1),
        IKEEXT_CIPHER_AES_256 = (IKEEXT_CIPHER_AES_192 + 1),
        IKEEXT_CIPHER_AES_GCM_128_16ICV = (IKEEXT_CIPHER_AES_256 + 1),
        IKEEXT_CIPHER_AES_GCM_256_16ICV = (IKEEXT_CIPHER_AES_GCM_128_16ICV + 1),
        IKEEXT_CIPHER_TYPE_MAX = (IKEEXT_CIPHER_AES_GCM_256_16ICV + 1),
    }

    public partial struct IKEEXT_CIPHER_ALGORITHM0_
    {
        [NativeTypeName("IKEEXT_CIPHER_TYPE")]
        public IKEEXT_CIPHER_TYPE_ algoIdentifier;

        [NativeTypeName("UINT32")]
        public uint keyLen;

        [NativeTypeName("UINT32")]
        public uint rounds;
    }

    public enum IKEEXT_INTEGRITY_TYPE_
    {
        IKEEXT_INTEGRITY_MD5 = 0,
        IKEEXT_INTEGRITY_SHA1 = (IKEEXT_INTEGRITY_MD5 + 1),
        IKEEXT_INTEGRITY_SHA_256 = (IKEEXT_INTEGRITY_SHA1 + 1),
        IKEEXT_INTEGRITY_SHA_384 = (IKEEXT_INTEGRITY_SHA_256 + 1),
        IKEEXT_INTEGRITY_TYPE_MAX = (IKEEXT_INTEGRITY_SHA_384 + 1),
    }

    public partial struct IKEEXT_INTEGRITY_ALGORITHM0_
    {
        [NativeTypeName("IKEEXT_INTEGRITY_TYPE")]
        public IKEEXT_INTEGRITY_TYPE_ algoIdentifier;
    }

    public enum IKEEXT_DH_GROUP_
    {
        IKEEXT_DH_GROUP_NONE = 0,
        IKEEXT_DH_GROUP_1 = (IKEEXT_DH_GROUP_NONE + 1),
        IKEEXT_DH_GROUP_2 = (IKEEXT_DH_GROUP_1 + 1),
        IKEEXT_DH_GROUP_14 = (IKEEXT_DH_GROUP_2 + 1),
        IKEEXT_DH_GROUP_2048 = IKEEXT_DH_GROUP_14,
        IKEEXT_DH_ECP_256 = (IKEEXT_DH_GROUP_2048 + 1),
        IKEEXT_DH_ECP_384 = (IKEEXT_DH_ECP_256 + 1),
        IKEEXT_DH_GROUP_24 = (IKEEXT_DH_ECP_384 + 1),
        IKEEXT_DH_GROUP_MAX = (IKEEXT_DH_GROUP_24 + 1),
    }

    public partial struct IKEEXT_PROPOSAL0_
    {
        [NativeTypeName("IKEEXT_CIPHER_ALGORITHM0")]
        public IKEEXT_CIPHER_ALGORITHM0_ cipherAlgorithm;

        [NativeTypeName("IKEEXT_INTEGRITY_ALGORITHM0")]
        public IKEEXT_INTEGRITY_ALGORITHM0_ integrityAlgorithm;

        [NativeTypeName("UINT32")]
        public uint maxLifetimeSeconds;

        [NativeTypeName("IKEEXT_DH_GROUP")]
        public IKEEXT_DH_GROUP_ dhGroup;

        [NativeTypeName("UINT32")]
        public uint quickModeLimit;
    }

    public unsafe partial struct IKEEXT_POLICY0_
    {
        [NativeTypeName("UINT32")]
        public uint softExpirationTime;

        [NativeTypeName("UINT32")]
        public uint numAuthenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD0 *")]
        public IKEEXT_AUTHENTICATION_METHOD0_* authenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ initiatorImpersonationType;

        [NativeTypeName("UINT32")]
        public uint numIkeProposals;

        [NativeTypeName("IKEEXT_PROPOSAL0 *")]
        public IKEEXT_PROPOSAL0_* ikeProposals;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint maxDynamicFilters;
    }

    public unsafe partial struct IKEEXT_POLICY1_
    {
        [NativeTypeName("UINT32")]
        public uint softExpirationTime;

        [NativeTypeName("UINT32")]
        public uint numAuthenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD1 *")]
        public IKEEXT_AUTHENTICATION_METHOD1_* authenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ initiatorImpersonationType;

        [NativeTypeName("UINT32")]
        public uint numIkeProposals;

        [NativeTypeName("IKEEXT_PROPOSAL0 *")]
        public IKEEXT_PROPOSAL0_* ikeProposals;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint maxDynamicFilters;

        [NativeTypeName("UINT32")]
        public uint retransmitDurationSecs;
    }

    public unsafe partial struct IKEEXT_POLICY2_
    {
        [NativeTypeName("UINT32")]
        public uint softExpirationTime;

        [NativeTypeName("UINT32")]
        public uint numAuthenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD2 *")]
        public IKEEXT_AUTHENTICATION_METHOD2_* authenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ initiatorImpersonationType;

        [NativeTypeName("UINT32")]
        public uint numIkeProposals;

        [NativeTypeName("IKEEXT_PROPOSAL0 *")]
        public IKEEXT_PROPOSAL0_* ikeProposals;

        [NativeTypeName("UINT32")]
        public uint flags;

        [NativeTypeName("UINT32")]
        public uint maxDynamicFilters;

        [NativeTypeName("UINT32")]
        public uint retransmitDurationSecs;
    }

    public unsafe partial struct IKEEXT_EM_POLICY0_
    {
        [NativeTypeName("UINT32")]
        public uint numAuthenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD0 *")]
        public IKEEXT_AUTHENTICATION_METHOD0_* authenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ initiatorImpersonationType;
    }

    public unsafe partial struct IKEEXT_EM_POLICY1_
    {
        [NativeTypeName("UINT32")]
        public uint numAuthenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD1 *")]
        public IKEEXT_AUTHENTICATION_METHOD1_* authenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ initiatorImpersonationType;
    }

    public unsafe partial struct IKEEXT_EM_POLICY2_
    {
        [NativeTypeName("UINT32")]
        public uint numAuthenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD2 *")]
        public IKEEXT_AUTHENTICATION_METHOD2_* authenticationMethods;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ initiatorImpersonationType;
    }

    public partial struct IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS0_
    {
        [NativeTypeName("UINT32")]
        public uint currentActiveMainModes;

        [NativeTypeName("UINT32")]
        public uint totalMainModesStarted;

        [NativeTypeName("UINT32")]
        public uint totalSuccessfulMainModes;

        [NativeTypeName("UINT32")]
        public uint totalFailedMainModes;

        [NativeTypeName("UINT32")]
        public uint totalResponderMainModes;

        [NativeTypeName("UINT32")]
        public uint currentNewResponderMainModes;

        [NativeTypeName("UINT32")]
        public uint currentActiveQuickModes;

        [NativeTypeName("UINT32")]
        public uint totalQuickModesStarted;

        [NativeTypeName("UINT32")]
        public uint totalSuccessfulQuickModes;

        [NativeTypeName("UINT32")]
        public uint totalFailedQuickModes;

        [NativeTypeName("UINT32")]
        public uint totalAcquires;

        [NativeTypeName("UINT32")]
        public uint totalReinitAcquires;

        [NativeTypeName("UINT32")]
        public uint currentActiveExtendedModes;

        [NativeTypeName("UINT32")]
        public uint totalExtendedModesStarted;

        [NativeTypeName("UINT32")]
        public uint totalSuccessfulExtendedModes;

        [NativeTypeName("UINT32")]
        public uint totalFailedExtendedModes;

        [NativeTypeName("UINT32")]
        public uint totalImpersonationExtendedModes;

        [NativeTypeName("UINT32")]
        public uint totalImpersonationMainModes;
    }

    public partial struct IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS1_
    {
        [NativeTypeName("UINT32")]
        public uint currentActiveMainModes;

        [NativeTypeName("UINT32")]
        public uint totalMainModesStarted;

        [NativeTypeName("UINT32")]
        public uint totalSuccessfulMainModes;

        [NativeTypeName("UINT32")]
        public uint totalFailedMainModes;

        [NativeTypeName("UINT32")]
        public uint totalResponderMainModes;

        [NativeTypeName("UINT32")]
        public uint currentNewResponderMainModes;

        [NativeTypeName("UINT32")]
        public uint currentActiveQuickModes;

        [NativeTypeName("UINT32")]
        public uint totalQuickModesStarted;

        [NativeTypeName("UINT32")]
        public uint totalSuccessfulQuickModes;

        [NativeTypeName("UINT32")]
        public uint totalFailedQuickModes;

        [NativeTypeName("UINT32")]
        public uint totalAcquires;

        [NativeTypeName("UINT32")]
        public uint totalReinitAcquires;

        [NativeTypeName("UINT32")]
        public uint currentActiveExtendedModes;

        [NativeTypeName("UINT32")]
        public uint totalExtendedModesStarted;

        [NativeTypeName("UINT32")]
        public uint totalSuccessfulExtendedModes;

        [NativeTypeName("UINT32")]
        public uint totalFailedExtendedModes;

        [NativeTypeName("UINT32")]
        public uint totalImpersonationExtendedModes;

        [NativeTypeName("UINT32")]
        public uint totalImpersonationMainModes;
    }

    public partial struct IKEEXT_KEYMODULE_STATISTICS0_
    {
        [NativeTypeName("IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS0")]
        public IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS0_ v4Statistics;

        [NativeTypeName("IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS0")]
        public IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS0_ v6Statistics;

        [NativeTypeName("UINT32[97]")]
        public _errorFrequencyTable_e__FixedBuffer errorFrequencyTable;

        [NativeTypeName("UINT32")]
        public uint mainModeNegotiationTime;

        [NativeTypeName("UINT32")]
        public uint quickModeNegotiationTime;

        [NativeTypeName("UINT32")]
        public uint extendedModeNegotiationTime;

        [InlineArray(97)]
        public partial struct _errorFrequencyTable_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct IKEEXT_KEYMODULE_STATISTICS1_
    {
        [NativeTypeName("IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS1")]
        public IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS1_ v4Statistics;

        [NativeTypeName("IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS1")]
        public IKEEXT_IP_VERSION_SPECIFIC_KEYMODULE_STATISTICS1_ v6Statistics;

        [NativeTypeName("UINT32[97]")]
        public _errorFrequencyTable_e__FixedBuffer errorFrequencyTable;

        [NativeTypeName("UINT32")]
        public uint mainModeNegotiationTime;

        [NativeTypeName("UINT32")]
        public uint quickModeNegotiationTime;

        [NativeTypeName("UINT32")]
        public uint extendedModeNegotiationTime;

        [InlineArray(97)]
        public partial struct _errorFrequencyTable_e__FixedBuffer
        {
            public uint e0;
        }
    }

    public partial struct IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS0_
    {
        [NativeTypeName("UINT32")]
        public uint totalSocketReceiveFailures;

        [NativeTypeName("UINT32")]
        public uint totalSocketSendFailures;
    }

    public partial struct IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS1_
    {
        [NativeTypeName("UINT32")]
        public uint totalSocketReceiveFailures;

        [NativeTypeName("UINT32")]
        public uint totalSocketSendFailures;
    }

    public partial struct IKEEXT_COMMON_STATISTICS0_
    {
        [NativeTypeName("IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS0")]
        public IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS0_ v4Statistics;

        [NativeTypeName("IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS0")]
        public IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS0_ v6Statistics;

        [NativeTypeName("UINT32")]
        public uint totalPacketsReceived;

        [NativeTypeName("UINT32")]
        public uint totalInvalidPacketsReceived;

        [NativeTypeName("UINT32")]
        public uint currentQueuedWorkitems;
    }

    public partial struct IKEEXT_COMMON_STATISTICS1_
    {
        [NativeTypeName("IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS1")]
        public IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS1_ v4Statistics;

        [NativeTypeName("IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS1")]
        public IKEEXT_IP_VERSION_SPECIFIC_COMMON_STATISTICS1_ v6Statistics;

        [NativeTypeName("UINT32")]
        public uint totalPacketsReceived;

        [NativeTypeName("UINT32")]
        public uint totalInvalidPacketsReceived;

        [NativeTypeName("UINT32")]
        public uint currentQueuedWorkitems;
    }

    public partial struct IKEEXT_STATISTICS0_
    {
        [NativeTypeName("IKEEXT_KEYMODULE_STATISTICS0")]
        public IKEEXT_KEYMODULE_STATISTICS0_ ikeStatistics;

        [NativeTypeName("IKEEXT_KEYMODULE_STATISTICS0")]
        public IKEEXT_KEYMODULE_STATISTICS0_ authipStatistics;

        [NativeTypeName("IKEEXT_COMMON_STATISTICS0")]
        public IKEEXT_COMMON_STATISTICS0_ commonStatistics;
    }

    public partial struct IKEEXT_STATISTICS1_
    {
        [NativeTypeName("IKEEXT_KEYMODULE_STATISTICS1")]
        public IKEEXT_KEYMODULE_STATISTICS1_ ikeStatistics;

        [NativeTypeName("IKEEXT_KEYMODULE_STATISTICS1")]
        public IKEEXT_KEYMODULE_STATISTICS1_ authipStatistics;

        [NativeTypeName("IKEEXT_KEYMODULE_STATISTICS1")]
        public IKEEXT_KEYMODULE_STATISTICS1_ ikeV2Statistics;

        [NativeTypeName("IKEEXT_COMMON_STATISTICS1")]
        public IKEEXT_COMMON_STATISTICS1_ commonStatistics;
    }

    public partial struct IKEEXT_TRAFFIC0_
    {
        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_iketypes_L663_C36")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("__AnonymousRecord_iketypes_L668_C36")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("UINT64")]
        public ulong authIpFilterId;

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

    public partial struct IKEEXT_COOKIE_PAIR0_
    {
        [NativeTypeName("IKEEXT_COOKIE")]
        public ulong initiator;

        [NativeTypeName("IKEEXT_COOKIE")]
        public ulong responder;
    }

    public partial struct IKEEXT_CERTIFICATE_CREDENTIAL0_
    {
        public FWP_BYTE_BLOB subjectName;

        public FWP_BYTE_BLOB certHash;

        [NativeTypeName("UINT32")]
        public uint flags;
    }

    public unsafe partial struct IKEEXT_NAME_CREDENTIAL0_
    {
        [NativeTypeName("wchar_t *")]
        public char* principalName;
    }

    public unsafe partial struct IKEEXT_CREDENTIAL0_
    {
        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ authenticationMethodType;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ impersonationType;

        [NativeTypeName("__AnonymousRecord_iketypes_L701_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref IKEEXT_PRESHARED_KEY_AUTHENTICATION0__* presharedKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.presharedKey;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CREDENTIAL0_* certificate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.certificate;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_NAME_CREDENTIAL0_* name
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.name;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_PRESHARED_KEY_AUTHENTICATION0 *")]
            public IKEEXT_PRESHARED_KEY_AUTHENTICATION0__* presharedKey;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_CREDENTIAL0 *")]
            public IKEEXT_CERTIFICATE_CREDENTIAL0_* certificate;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_NAME_CREDENTIAL0 *")]
            public IKEEXT_NAME_CREDENTIAL0_* name;
        }
    }

    public partial struct IKEEXT_CREDENTIAL_PAIR0_
    {
        [NativeTypeName("IKEEXT_CREDENTIAL0")]
        public IKEEXT_CREDENTIAL0_ localCredentials;

        [NativeTypeName("IKEEXT_CREDENTIAL0")]
        public IKEEXT_CREDENTIAL0_ peerCredentials;
    }

    public unsafe partial struct IKEEXT_CREDENTIALS0_
    {
        [NativeTypeName("UINT32")]
        public uint numCredentials;

        [NativeTypeName("IKEEXT_CREDENTIAL_PAIR0 *")]
        public IKEEXT_CREDENTIAL_PAIR0_* credentials;
    }

    public unsafe partial struct IKEEXT_SA_DETAILS0_
    {
        [NativeTypeName("UINT64")]
        public ulong saId;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyModuleType;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_iketypes_L727_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("IKEEXT_TRAFFIC0")]
        public IKEEXT_TRAFFIC0_ ikeTraffic;

        [NativeTypeName("IKEEXT_PROPOSAL0")]
        public IKEEXT_PROPOSAL0_ ikeProposal;

        [NativeTypeName("IKEEXT_COOKIE_PAIR0")]
        public IKEEXT_COOKIE_PAIR0_ cookiePair;

        [NativeTypeName("IKEEXT_CREDENTIALS0")]
        public IKEEXT_CREDENTIALS0_ ikeCredentials;

        public Guid ikePolicyKey;

        [NativeTypeName("UINT64")]
        public ulong virtualIfTunnelId;

        [UnscopedRef]
        public ref IPSEC_V4_UDP_ENCAPSULATION0_* v4UdpEncapsulation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.v4UdpEncapsulation;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_V4_UDP_ENCAPSULATION0 *")]
            public IPSEC_V4_UDP_ENCAPSULATION0_* v4UdpEncapsulation;
        }
    }

    public partial struct IKEEXT_CERTIFICATE_CREDENTIAL1_
    {
        public FWP_BYTE_BLOB subjectName;

        public FWP_BYTE_BLOB certHash;

        [NativeTypeName("UINT32")]
        public uint flags;

        public FWP_BYTE_BLOB certificate;
    }

    public unsafe partial struct IKEEXT_CREDENTIAL1_
    {
        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ authenticationMethodType;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ impersonationType;

        [NativeTypeName("__AnonymousRecord_iketypes_L753_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref IKEEXT_PRESHARED_KEY_AUTHENTICATION1__* presharedKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.presharedKey;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CREDENTIAL1_* certificate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.certificate;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_NAME_CREDENTIAL0_* name
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.name;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_PRESHARED_KEY_AUTHENTICATION1 *")]
            public IKEEXT_PRESHARED_KEY_AUTHENTICATION1__* presharedKey;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_CREDENTIAL1 *")]
            public IKEEXT_CERTIFICATE_CREDENTIAL1_* certificate;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_NAME_CREDENTIAL0 *")]
            public IKEEXT_NAME_CREDENTIAL0_* name;
        }
    }

    public partial struct IKEEXT_CREDENTIAL_PAIR1_
    {
        [NativeTypeName("IKEEXT_CREDENTIAL1")]
        public IKEEXT_CREDENTIAL1_ localCredentials;

        [NativeTypeName("IKEEXT_CREDENTIAL1")]
        public IKEEXT_CREDENTIAL1_ peerCredentials;
    }

    public unsafe partial struct IKEEXT_CREDENTIALS1_
    {
        [NativeTypeName("UINT32")]
        public uint numCredentials;

        [NativeTypeName("IKEEXT_CREDENTIAL_PAIR1 *")]
        public IKEEXT_CREDENTIAL_PAIR1_* credentials;
    }

    public unsafe partial struct IKEEXT_SA_DETAILS1_
    {
        [NativeTypeName("UINT64")]
        public ulong saId;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyModuleType;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_iketypes_L779_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("IKEEXT_TRAFFIC0")]
        public IKEEXT_TRAFFIC0_ ikeTraffic;

        [NativeTypeName("IKEEXT_PROPOSAL0")]
        public IKEEXT_PROPOSAL0_ ikeProposal;

        [NativeTypeName("IKEEXT_COOKIE_PAIR0")]
        public IKEEXT_COOKIE_PAIR0_ cookiePair;

        [NativeTypeName("IKEEXT_CREDENTIALS1")]
        public IKEEXT_CREDENTIALS1_ ikeCredentials;

        public Guid ikePolicyKey;

        [NativeTypeName("UINT64")]
        public ulong virtualIfTunnelId;

        public FWP_BYTE_BLOB correlationKey;

        [UnscopedRef]
        public ref IPSEC_V4_UDP_ENCAPSULATION0_* v4UdpEncapsulation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.v4UdpEncapsulation;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_V4_UDP_ENCAPSULATION0 *")]
            public IPSEC_V4_UDP_ENCAPSULATION0_* v4UdpEncapsulation;
        }
    }

    public unsafe partial struct IKEEXT_CREDENTIAL2_
    {
        [NativeTypeName("IKEEXT_AUTHENTICATION_METHOD_TYPE")]
        public IKEEXT_AUTHENTICATION_METHOD_TYPE_ authenticationMethodType;

        [NativeTypeName("IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE")]
        public IKEEXT_AUTHENTICATION_IMPERSONATION_TYPE_ impersonationType;

        [NativeTypeName("__AnonymousRecord_iketypes_L799_C36")]
        public _Anonymous_e__Union Anonymous;

        [UnscopedRef]
        public ref IKEEXT_PRESHARED_KEY_AUTHENTICATION1__* presharedKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.presharedKey;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_CERTIFICATE_CREDENTIAL1_* certificate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.certificate;
            }
        }

        [UnscopedRef]
        public ref IKEEXT_NAME_CREDENTIAL0_* name
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.name;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_PRESHARED_KEY_AUTHENTICATION1 *")]
            public IKEEXT_PRESHARED_KEY_AUTHENTICATION1__* presharedKey;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_CERTIFICATE_CREDENTIAL1 *")]
            public IKEEXT_CERTIFICATE_CREDENTIAL1_* certificate;

            [FieldOffset(0)]
            [NativeTypeName("IKEEXT_NAME_CREDENTIAL0 *")]
            public IKEEXT_NAME_CREDENTIAL0_* name;
        }
    }

    public partial struct IKEEXT_CREDENTIAL_PAIR2_
    {
        [NativeTypeName("IKEEXT_CREDENTIAL2")]
        public IKEEXT_CREDENTIAL2_ localCredentials;

        [NativeTypeName("IKEEXT_CREDENTIAL2")]
        public IKEEXT_CREDENTIAL2_ peerCredentials;
    }

    public unsafe partial struct IKEEXT_CREDENTIALS2_
    {
        [NativeTypeName("UINT32")]
        public uint numCredentials;

        [NativeTypeName("IKEEXT_CREDENTIAL_PAIR2 *")]
        public IKEEXT_CREDENTIAL_PAIR2_* credentials;
    }

    public unsafe partial struct IKEEXT_SA_DETAILS2_
    {
        [NativeTypeName("UINT64")]
        public ulong saId;

        [NativeTypeName("IKEEXT_KEY_MODULE_TYPE")]
        public IKEEXT_KEY_MODULE_TYPE_ keyModuleType;

        [NativeTypeName("FWP_IP_VERSION")]
        public FWP_IP_VERSION_ ipVersion;

        [NativeTypeName("__AnonymousRecord_iketypes_L825_C36")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("IKEEXT_TRAFFIC0")]
        public IKEEXT_TRAFFIC0_ ikeTraffic;

        [NativeTypeName("IKEEXT_PROPOSAL0")]
        public IKEEXT_PROPOSAL0_ ikeProposal;

        [NativeTypeName("IKEEXT_COOKIE_PAIR0")]
        public IKEEXT_COOKIE_PAIR0_ cookiePair;

        [NativeTypeName("IKEEXT_CREDENTIALS2")]
        public IKEEXT_CREDENTIALS2_ ikeCredentials;

        public Guid ikePolicyKey;

        [NativeTypeName("UINT64")]
        public ulong virtualIfTunnelId;

        public FWP_BYTE_BLOB correlationKey;

        [UnscopedRef]
        public ref IPSEC_V4_UDP_ENCAPSULATION0_* v4UdpEncapsulation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Anonymous.v4UdpEncapsulation;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("IPSEC_V4_UDP_ENCAPSULATION0 *")]
            public IPSEC_V4_UDP_ENCAPSULATION0_* v4UdpEncapsulation;
        }
    }

    public partial struct IKEEXT_SA_ENUM_TEMPLATE0_
    {
        [NativeTypeName("FWP_CONDITION_VALUE0")]
        public FWP_CONDITION_VALUE0_ localSubNet;

        [NativeTypeName("FWP_CONDITION_VALUE0")]
        public FWP_CONDITION_VALUE0_ remoteSubNet;

        public FWP_BYTE_BLOB localMainModeCertHash;
    }

    public enum IKEEXT_MM_SA_STATE_
    {
        IKEEXT_MM_SA_STATE_NONE = 0,
        IKEEXT_MM_SA_STATE_SA_SENT = (IKEEXT_MM_SA_STATE_NONE + 1),
        IKEEXT_MM_SA_STATE_SSPI_SENT = (IKEEXT_MM_SA_STATE_SA_SENT + 1),
        IKEEXT_MM_SA_STATE_FINAL = (IKEEXT_MM_SA_STATE_SSPI_SENT + 1),
        IKEEXT_MM_SA_STATE_FINAL_SENT = (IKEEXT_MM_SA_STATE_FINAL + 1),
        IKEEXT_MM_SA_STATE_COMPLETE = (IKEEXT_MM_SA_STATE_FINAL_SENT + 1),
        IKEEXT_MM_SA_STATE_MAX = (IKEEXT_MM_SA_STATE_COMPLETE + 1),
    }

    public enum IKEEXT_QM_SA_STATE_
    {
        IKEEXT_QM_SA_STATE_NONE = 0,
        IKEEXT_QM_SA_STATE_INITIAL = (IKEEXT_QM_SA_STATE_NONE + 1),
        IKEEXT_QM_SA_STATE_FINAL = (IKEEXT_QM_SA_STATE_INITIAL + 1),
        IKEEXT_QM_SA_STATE_COMPLETE = (IKEEXT_QM_SA_STATE_FINAL + 1),
        IKEEXT_QM_SA_STATE_MAX = (IKEEXT_QM_SA_STATE_COMPLETE + 1),
    }

    public enum IKEEXT_EM_SA_STATE_
    {
        IKEEXT_EM_SA_STATE_NONE = 0,
        IKEEXT_EM_SA_STATE_SENT_ATTS = (IKEEXT_EM_SA_STATE_NONE + 1),
        IKEEXT_EM_SA_STATE_SSPI_SENT = (IKEEXT_EM_SA_STATE_SENT_ATTS + 1),
        IKEEXT_EM_SA_STATE_AUTH_COMPLETE = (IKEEXT_EM_SA_STATE_SSPI_SENT + 1),
        IKEEXT_EM_SA_STATE_FINAL = (IKEEXT_EM_SA_STATE_AUTH_COMPLETE + 1),
        IKEEXT_EM_SA_STATE_COMPLETE = (IKEEXT_EM_SA_STATE_FINAL + 1),
        IKEEXT_EM_SA_STATE_MAX = (IKEEXT_EM_SA_STATE_COMPLETE + 1),
    }

    public enum IKEEXT_SA_ROLE_
    {
        IKEEXT_SA_ROLE_INITIATOR = 0,
        IKEEXT_SA_ROLE_RESPONDER = (IKEEXT_SA_ROLE_INITIATOR + 1),
        IKEEXT_SA_ROLE_MAX = (IKEEXT_SA_ROLE_RESPONDER + 1),
    }

    public static partial class Methods
    {
        [NativeTypeName("#define IKEEXT_PSK_FLAG_LOCAL_AUTH_ONLY (0x00000001)")]
        public const int IKEEXT_PSK_FLAG_LOCAL_AUTH_ONLY = (0x00000001);

        [NativeTypeName("#define IKEEXT_PSK_FLAG_REMOTE_AUTH_ONLY (0x00000002)")]
        public const int IKEEXT_PSK_FLAG_REMOTE_AUTH_ONLY = (0x00000002);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_ENABLE_ACCOUNT_MAPPING (0x00000001)")]
        public const int IKEEXT_CERT_FLAG_ENABLE_ACCOUNT_MAPPING = (0x00000001);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_DISABLE_REQUEST_PAYLOAD (0x00000002)")]
        public const int IKEEXT_CERT_FLAG_DISABLE_REQUEST_PAYLOAD = (0x00000002);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_USE_NAP_CERTIFICATE (0x00000004)")]
        public const int IKEEXT_CERT_FLAG_USE_NAP_CERTIFICATE = (0x00000004);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_INTERMEDIATE_CA (0x00000008)")]
        public const int IKEEXT_CERT_FLAG_INTERMEDIATE_CA = (0x00000008);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_IGNORE_INIT_CERT_MAP_FAILURE (0x00000010)")]
        public const int IKEEXT_CERT_FLAG_IGNORE_INIT_CERT_MAP_FAILURE = (0x00000010);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_PREFER_NAP_CERTIFICATE_OUTBOUND (0x00000020)")]
        public const int IKEEXT_CERT_FLAG_PREFER_NAP_CERTIFICATE_OUTBOUND = (0x00000020);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_SELECT_NAP_CERTIFICATE (0x00000040)")]
        public const int IKEEXT_CERT_FLAG_SELECT_NAP_CERTIFICATE = (0x00000040);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_VERIFY_NAP_CERTIFICATE (0x00000080)")]
        public const int IKEEXT_CERT_FLAG_VERIFY_NAP_CERTIFICATE = (0x00000080);

        [NativeTypeName("#define IKEEXT_CERT_FLAG_FOLLOW_RENEWAL_CERTIFICATE (0x00000100)")]
        public const int IKEEXT_CERT_FLAG_FOLLOW_RENEWAL_CERTIFICATE = (0x00000100);

        [NativeTypeName("#define IKEEXT_CERT_AUTH_FLAG_SSL_ONE_WAY (0x00000001)")]
        public const int IKEEXT_CERT_AUTH_FLAG_SSL_ONE_WAY = (0x00000001);

        [NativeTypeName("#define IKEEXT_CERT_AUTH_FLAG_DISABLE_CRL_CHECK (0x00000002)")]
        public const int IKEEXT_CERT_AUTH_FLAG_DISABLE_CRL_CHECK = (0x00000002);

        [NativeTypeName("#define IKEEXT_CERT_AUTH_ENABLE_CRL_CHECK_STRONG (0x00000004)")]
        public const int IKEEXT_CERT_AUTH_ENABLE_CRL_CHECK_STRONG = (0x00000004);

        [NativeTypeName("#define IKEEXT_CERT_AUTH_DISABLE_SSL_CERT_VALIDATION (0x00000008)")]
        public const int IKEEXT_CERT_AUTH_DISABLE_SSL_CERT_VALIDATION = (0x00000008);

        [NativeTypeName("#define IKEEXT_CERT_AUTH_ALLOW_HTTP_CERT_LOOKUP (0x00000010)")]
        public const int IKEEXT_CERT_AUTH_ALLOW_HTTP_CERT_LOOKUP = (0x00000010);

        [NativeTypeName("#define IKEEXT_CERT_AUTH_URL_CONTAINS_BUNDLE (0x00000020)")]
        public const int IKEEXT_CERT_AUTH_URL_CONTAINS_BUNDLE = (0x00000020);

        [NativeTypeName("#define IKEEXT_CERT_AUTH_FLAG_DISABLE_REQUEST_PAYLOAD (0x00000040)")]
        public const int IKEEXT_CERT_AUTH_FLAG_DISABLE_REQUEST_PAYLOAD = (0x00000040);

        [NativeTypeName("#define IKEEXT_KERB_AUTH_DISABLE_INITIATOR_TOKEN_GENERATION (0x00000001)")]
        public const int IKEEXT_KERB_AUTH_DISABLE_INITIATOR_TOKEN_GENERATION = (0x00000001);

        [NativeTypeName("#define IKEEXT_KERB_AUTH_DONT_ACCEPT_EXPLICIT_CREDENTIALS (0x00000002)")]
        public const int IKEEXT_KERB_AUTH_DONT_ACCEPT_EXPLICIT_CREDENTIALS = (0x00000002);

        [NativeTypeName("#define IKEEXT_KERB_AUTH_FORCE_PROXY_ON_INITIATOR (0x00000004)")]
        public const int IKEEXT_KERB_AUTH_FORCE_PROXY_ON_INITIATOR = (0x00000004);

        [NativeTypeName("#define IKEEXT_RESERVED_AUTH_DISABLE_INITIATOR_TOKEN_GENERATION (0x00000001)")]
        public const int IKEEXT_RESERVED_AUTH_DISABLE_INITIATOR_TOKEN_GENERATION = (0x00000001);

        [NativeTypeName("#define IKEEXT_NTLM_V2_AUTH_DONT_ACCEPT_EXPLICIT_CREDENTIALS (0x00000001)")]
        public const int IKEEXT_NTLM_V2_AUTH_DONT_ACCEPT_EXPLICIT_CREDENTIALS = (0x00000001);

        [NativeTypeName("#define IKEEXT_EAP_FLAG_LOCAL_AUTH_ONLY (0x00000001)")]
        public const int IKEEXT_EAP_FLAG_LOCAL_AUTH_ONLY = (0x00000001);

        [NativeTypeName("#define IKEEXT_EAP_FLAG_REMOTE_AUTH_ONLY (0x00000002)")]
        public const int IKEEXT_EAP_FLAG_REMOTE_AUTH_ONLY = (0x00000002);

        [NativeTypeName("#define IKEEXT_POLICY_FLAG_DISABLE_DIAGNOSTICS (0x00000001)")]
        public const int IKEEXT_POLICY_FLAG_DISABLE_DIAGNOSTICS = (0x00000001);

        [NativeTypeName("#define IKEEXT_POLICY_FLAG_NO_MACHINE_LUID_VERIFY (0x00000002)")]
        public const int IKEEXT_POLICY_FLAG_NO_MACHINE_LUID_VERIFY = (0x00000002);

        [NativeTypeName("#define IKEEXT_POLICY_FLAG_NO_IMPERSONATION_LUID_VERIFY (0x00000004)")]
        public const int IKEEXT_POLICY_FLAG_NO_IMPERSONATION_LUID_VERIFY = (0x00000004);

        [NativeTypeName("#define IKEEXT_POLICY_FLAG_ENABLE_OPTIONAL_DH (0x00000008)")]
        public const int IKEEXT_POLICY_FLAG_ENABLE_OPTIONAL_DH = (0x00000008);

        [NativeTypeName("#define IKEEXT_POLICY_FLAG_MOBIKE_NOT_SUPPORTED (0x00000010)")]
        public const int IKEEXT_POLICY_FLAG_MOBIKE_NOT_SUPPORTED = (0x00000010);

        [NativeTypeName("#define IKEEXT_POLICY_FLAG_SITE_TO_SITE (0x00000020)")]
        public const int IKEEXT_POLICY_FLAG_SITE_TO_SITE = (0x00000020);

        [NativeTypeName("#define IKEEXT_POLICY_FLAG_IMS_VPN (0x00000040)")]
        public const int IKEEXT_POLICY_FLAG_IMS_VPN = (0x00000040);

        [NativeTypeName("#define IKEEXT_POLICY_ENABLE_IKEV2_FRAGMENTATION (0x00000080)")]
        public const int IKEEXT_POLICY_ENABLE_IKEV2_FRAGMENTATION = (0x00000080);

        [NativeTypeName("#define IKEEXT_POLICY_SUPPORT_LOW_POWER_MODE (0x00000100)")]
        public const int IKEEXT_POLICY_SUPPORT_LOW_POWER_MODE = (0x00000100);

        [NativeTypeName("#define IKEEXT_POLICY_FLAG_POINT_TO_SITE (0x00000200)")]
        public const int IKEEXT_POLICY_FLAG_POINT_TO_SITE = (0x00000200);

        [NativeTypeName("#define IKEEXT_ERROR_CODE_COUNT (ERROR_IPSEC_IKE_NEG_STATUS_END - ERROR_IPSEC_IKE_NEG_STATUS_BEGIN)")]
        public const int IKEEXT_ERROR_CODE_COUNT = (13897 - 13800);

        [NativeTypeName("#define IKEEXT_CERT_CREDENTIAL_FLAG_NAP_CERT (0x00000001)")]
        public const int IKEEXT_CERT_CREDENTIAL_FLAG_NAP_CERT = (0x00000001);
    }
}
