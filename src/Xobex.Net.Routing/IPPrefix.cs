using System.Net;

namespace Xobex.Net.Routing;

public readonly struct IPPrefix
{
    public IPPrefix(IPAddress address, int length)
    {
        ArgumentNullException.ThrowIfNull(address);
        if (length < 0 || length > (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork ? 32 : 128))
        {
            throw new ArgumentOutOfRangeException(nameof(length), "Invalid prefix length for the given address family.");
        }
        Address = address;
        Length = length;
    }

    public IPAddress Address { get; }

    public int Length { get; }

    public override string ToString()
    {
        return $"{Address}/{Length}";
    }
}
