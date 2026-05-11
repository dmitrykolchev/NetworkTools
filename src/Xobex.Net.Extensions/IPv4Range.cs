// <copyright file="IPv4Range.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Buffers.Binary;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Xobex.Net.Extensions;

public struct IPv4Range
{
    public uint Start;
    public uint End;

#if DEBUG
    internal readonly IPNetwork _source;
#endif

    public IPv4Range(IPNetwork network)
    {
#if DEBUG
        _source = network;
#endif
        unsafe
        {
            Span<byte> buffer = stackalloc byte[4];
            if (!network.BaseAddress.TryWriteBytes(buffer, out _))
            {
                throw new InvalidOperationException();
            }
            Start = BinaryPrimitives.ReadUInt32BigEndian(buffer) & (0xFF_FF_FF_FFu << (32 - network.PrefixLength));
            End = Start + ~(0xFF_FF_FF_FFu << (32 - network.PrefixLength));
        }
    }

    public IPAddress StartAddress
    {
        get
        {
            var le = BinaryPrimitives.ReadUInt32BigEndian(MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref Start, 1)));
            return new IPAddress(MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref le, 1)));
        }
    }

    public IPAddress EndAddress
    {
        get
        {
            var le = BinaryPrimitives.ReadUInt32BigEndian(MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref End, 1)));
            return new IPAddress(MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref le, 1)));
        }
    }

    public bool Contains(IPv4Range range)
    {
        return Start <= range.Start && End >= range.End;
    }

    public bool Contains(IPNetwork network)
    {
        return Contains((IPv4Range)network);
    }

    public override string ToString()
    {
        return $"{StartAddress} - {EndAddress}";
    }

    public IPNetwork ToCidr()
    {
        IPv4Range range = new()
        {
            Start = Start
        };
        var count = BitOperations.TrailingZeroCount(range.Start);
        for (; count > 0;)
        {
            var hostMask = ~(0xFFFFFFFFu << count);
            if (range.Start + hostMask <= End)
            {
                range.End = range.Start + hostMask;
                return new IPNetwork(range.StartAddress, 32 - count);
            }
            else
            {
                count--;
            }
        }
        return new IPNetwork(range.StartAddress, 32);
    }

    public IPNetwork[] ToArray()
    {
        List<IPNetwork> result = [];
        IPv4Range range = new()
        {
            Start = Start
        };
        var count = BitOperations.TrailingZeroCount(range.Start);
        for (; range.Start <= End;)
        {
            var hostMask = ~(0xFFFFFFFFu << count);
            if (range.Start + hostMask <= End)
            {
                range.End = range.Start + hostMask;
                result.Add(new IPNetwork(range.StartAddress, 32 - count));
                range.Start = range.End + 1;
                count = BitOperations.TrailingZeroCount(range.Start);
            }
            else
            {
                count--;
            }
        }
        return result.ToArray();
    }

    public static explicit operator IPv4Range(IPNetwork network)
    {
        if (network.BaseAddress.AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)
        {
            throw new ArgumentException("must be IPv4 network");
        }
        return new IPv4Range(network);
    }
}
