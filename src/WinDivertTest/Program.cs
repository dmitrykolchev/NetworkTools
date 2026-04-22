// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Net;
using System.Runtime.InteropServices;
using Managed.WinDivert;
using Managed.WinDivert.Native;

namespace WinDivertTest;

internal class Program
{
    private static bool Done;

    private static void Main(string[] args)
    {
        Console.CancelKeyPress += Console_CancelKeyPress;
        using var session = new Session();

        byte[] compiledFilter;
        if (args.Length >= 1)
        {
            compiledFilter = new byte[args[0].Length + 1];
            Utils.CompileFilter(args[0], Layer.Network, compiledFilter);
            session.Open(compiledFilter, Layer.Network, 0, SessionFlags.Sniff | SessionFlags.Fragments);
        }
        else
        {
            session.Open(Layer.Network, 0, SessionFlags.Sniff | SessionFlags.Fragments);
        }
        session.SetParameterValue(SessionParameter.QueueLength, Session.ParamQueueLengthMax);
        session.SetParameterValue(SessionParameter.QueueTime, Session.ParamQueueTimeMax);
        session.SetParameterValue(SessionParameter.QueueSize, Session.ParamQueueSizeMax);

        // Main capture-modify-inject loop:
        Span<byte> packet = stackalloc byte[0xFFFF];
        Console.Clear();
        do
        {
            var address = new Address();
            var read = session.Receive(packet, ref address);
            if (read == 0)
            {
                // Handle recv error
                continue;
            }
            Utils.ParsePacket(packet, out var ipV4Header, out var ipV6Header, out _, out _, out var tcpHeader, out var udpHeader, out _);

            ushort srcPort = 0;
            ushort dstPort = 0;
            if (!tcpHeader.IsEmpty)
            {
                srcPort = Utils.NetworkToHostOrder(tcpHeader[0].SrcPort);
                dstPort = Utils.NetworkToHostOrder(tcpHeader[0].DstPort);
            }
            else if (!udpHeader.IsEmpty)
            {
                srcPort = Utils.NetworkToHostOrder(udpHeader[0].SrcPort);
                dstPort = Utils.NetworkToHostOrder(udpHeader[0].DstPort);
            }

            if (!ipV4Header.IsEmpty)
            {
                if (dstPort == 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    ref readonly var v = ref ipV4Header[0];
                    var srcAddress = new IPAddress(v.SrcAddr);
                    var dstAddress = new IPAddress(v.DstAddr);
                    var path = $"{srcAddress}:{srcPort} -> {dstAddress}:{dstPort}";
                    Console.WriteLine($"IPv4 [Version={v.Version} HdrLength={v.HdrLength} TOS={v.TOS} Length={IPAddress.NetworkToHostOrder((short)v.Length)} Id=0x{IPAddress.NetworkToHostOrder((short)v.Id):X04} TTL={v.TTL} Protocol={v.Protocol}]");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\t{path}");
                }
            }
            else if (!ipV6Header.IsEmpty && false)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                ref readonly var v = ref ipV6Header[0];
                ReadOnlySpan<uint> src = v.SrcAddr;
                ReadOnlySpan<uint> dst = v.DstAddr;
                var path = $"[{new IPAddress(MemoryMarshal.AsBytes(src))}]:{srcPort} -> [{new IPAddress(MemoryMarshal.AsBytes(dst))}]:{dstPort}";
                Console.WriteLine($"IPv6 [Version={v.Version} Length={IPAddress.NetworkToHostOrder((short)v.Length)} HopLimit={v.HopLimit}]");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\t{path}");
            }
        } while (!Done);
        session.Shutdown();
        session.Close();
    }

    private static void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)
    {
        Done = true;
        e.Cancel = true;
    }
}
