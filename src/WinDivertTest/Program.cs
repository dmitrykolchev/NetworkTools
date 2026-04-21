// <copyright file="Program.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Buffers;
using System.Net;
using System.Runtime.InteropServices;
using Managed.WinDivert;
using Managed.WinDivert.Native;

namespace WinDivertTest;

internal class Program
{
    private static bool Done;
    private static readonly Dictionary<string, long> traffic = [];

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
        var index = 0;
        Console.Clear();
        var localNetwork = IPNetwork.Parse("192.168.175.0/24");
        do
        {
            var address = new Address();
            var read = session.Receive(packet, ref address);
            if (read == 0)
            {
                // Handle recv error
                continue;
            }
            Utils.ParsePacket(packet, out var ipV4Header, out var ipV6Header);
            if (!ipV4Header.IsEmpty)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                ref readonly var v = ref ipV4Header[0];
                var srcAddress = new IPAddress(v.SrcAddr);
                var dstAddress = new IPAddress(v.DstAddr);
                if(srcAddress.Equals(dstAddress))
                {
                    continue;
                }
                if (!localNetwork.Contains(srcAddress) || !localNetwork.Contains(dstAddress))
                {
                    Console.WriteLine($"IPv4 [Version={v.Version} HdrLength={v.HdrLength} TOS={v.TOS} Length={IPAddress.NetworkToHostOrder((short)v.Length)} Id=0x{IPAddress.NetworkToHostOrder((short)v.Id):X04} TTL={v.TTL} Protocol={v.Protocol}]");
                    var path = $"{srcAddress} -> {dstAddress}";
                    Console.WriteLine($"\t{path}");
                }
                //if (traffic.TryGetValue(path, out var value))
                //{
                //    value += v.Length;
                //}
                //else
                //{
                //    value = v.Length;
                //}
                //traffic[path] = value;
            }
            else if(!ipV6Header.IsEmpty)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                ref readonly var v = ref ipV6Header[0];
                ReadOnlySpan<uint> src = v.SrcAddr;
                ReadOnlySpan<uint> dst = v.DstAddr;
                Console.WriteLine($"IPv6 [Version={v.Version} Length={IPAddress.NetworkToHostOrder((short)v.Length)} HopLimit={v.HopLimit}]");
                var path = $"{new IPAddress(MemoryMarshal.AsBytes(src))} -> {new IPAddress(MemoryMarshal.AsBytes(dst))}";
                Console.WriteLine($"\t{path}");
            }
            //Console.CursorTop = 0;
            //Console.CursorLeft = 0;
            //foreach (var item in traffic.OrderBy(t => t.Key))
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}                               ");
            //}
            //var temp = packet[..Math.Min(32, read)].ToArray();
            //Console.WriteLine($"\t{BitConverter.ToString(temp)}");
            ++index;
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
