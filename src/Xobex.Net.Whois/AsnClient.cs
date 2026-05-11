// <copyright file="AsnClient.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Xobex.Net.Whois;

public class AsnCymruClient
{
    public IEnumerable<string> GetAsnList(IPAddress address)
    {
        if (address.AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork)
        {
            throw new ArgumentException("IPv4 addresses only supported", nameof(address));
        }
        string query = $"{string.Join(".", address.ToString().Split('.').Reverse())}.origin.asn.cymru.com";
        DnsClient
}
