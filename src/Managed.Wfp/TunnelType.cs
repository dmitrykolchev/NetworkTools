// <copyright file="TunnelType.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.IpHlpApi.Native.TUNNEL_TYPE;

namespace Managed.Wfp;

public enum TunnelType
{
    None = TUNNEL_TYPE_NONE,
    Other = TUNNEL_TYPE_OTHER,
    Direct = TUNNEL_TYPE_DIRECT,
    IPv6To4 = TUNNEL_TYPE_6TO4,
    Isatap = TUNNEL_TYPE_ISATAP,
    Teredo = TUNNEL_TYPE_TEREDO,
    IPHttps = TUNNEL_TYPE_IPHTTPS,
}
