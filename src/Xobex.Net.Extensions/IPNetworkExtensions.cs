// <copyright file="Class1.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using System.Net;

namespace Xobex.Net.Extensions;

public static class IPNetworkExtensions
{
    public static IPv4Range AsRange(this IPNetwork net)
    {
        return new IPv4Range(net);
    }
}
