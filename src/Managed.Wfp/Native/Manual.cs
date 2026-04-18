using System.Runtime.InteropServices;

namespace Managed.Win32.Native;

[System.Runtime.CompilerServices.InlineArray(14)]
public struct ByteBuffer14
{
    private byte _element0; // Тип элемента
}

[StructLayout(LayoutKind.Sequential)]
#pragma warning disable CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
public struct sockaddr
#pragma warning restore CS8981 // The type name only contains lower-cased ascii characters. Such names may become reserved for the language.
{
    public ushort sa_family;              /* address family */
    public ByteBuffer14 sa_data;          /* up to 14 bytes of direct address */
};


[StructLayout(LayoutKind.Sequential)]
public partial struct _MIB_OPAQUE_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwId;

    public ulong ullAlign;

    public unsafe byte* rgbyData
    {
        get
        {
            fixed (void* ptr = &ullAlign) return (byte*)ptr;
        }
    }
}


[System.Runtime.CompilerServices.InlineArray(15)]
public struct NUIntBuffer15
{
    private byte _element0; // Тип элемента
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct _EXCEPTION_RECORD
{
    public uint ExceptionCode;
    public uint ExceptionFlags;
    public _EXCEPTION_RECORD *ExceptionRecord;
    public void* ExceptionAddress;
    public uint NumberParameters;
    public NUIntBuffer15 ExceptionInformation;
}

[System.Runtime.CompilerServices.InlineArray(6)]
public struct ByteBuffer6
{
    private byte _element0; // Тип элемента
}

[StructLayout(LayoutKind.Sequential)]
public struct SID_IDENTIFIER_AUTHORITY
{
    public ByteBuffer6 Value;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct SID
{
    public byte Revision;
    public byte SubAuthorityCount;
    public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;

    //DWORD SubAuthority[ANYSIZE_ARRAY];
    private readonly int SubAuthorityFirst;
    public int* SubAuthority
    {
        get
        {
            fixed (int* p = &SubAuthorityFirst) return p;
        }
    }
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct SID_AND_ATTRIBUTES
{
    public SID* Sid;
    public int Attributes;
}

[StructLayout(LayoutKind.Sequential)]
public struct ACL
{
    public byte AclRevision;
    public byte Sbz1;
    public ushort AclSize;
    public ushort AceCount;
    public ushort Sbz2;
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct SEC_WINNT_AUTH_IDENTITY_W
{
    public ushort* User;
    public uint UserLength;
    public ushort* Domain;
    public uint DomainLength;
    public ushort* Password;
    public uint PasswordLength;
    public uint Flags;
}
