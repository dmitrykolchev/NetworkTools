// <copyright file="ConnectionType.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.IpHlpApi.Native._NET_IF_CONNECTION_TYPE;

namespace Managed.Wfp;

public enum ConnectionType
{
    Dedicated = NET_IF_CONNECTION_DEDICATED,
    Passive = NET_IF_CONNECTION_PASSIVE,
    Demand = NET_IF_CONNECTION_DEMAND,
    Maximum = NET_IF_CONNECTION_MAXIMUM,
}
