using System.Runtime.InteropServices;

namespace Managed.Win32.Native;

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
