using System.Runtime.InteropServices;

namespace Managed.Win32.Native;

[StructLayout(LayoutKind.Sequential)]
public struct FILETIME
{
    uint dwLowDateTime;
    uint dwHighDateTime;
}

[StructLayout(LayoutKind.Sequential)]
public struct LUID
{
    public uint LowPart;

    public int HighPart;
}


[AttributeUsage(AttributeTargets.All)]
public class NativeTypeNameAttribute : Attribute
{
    public NativeTypeNameAttribute(string typeName) { }
}