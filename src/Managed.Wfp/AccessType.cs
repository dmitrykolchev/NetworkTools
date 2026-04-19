// <copyright file="AccessType.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.IpHlpApi.Native._NET_IF_ACCESS_TYPE;

namespace Managed.Wfp;

public enum AccessType
{
    /// <summary>
    /// The interface is a loopback interface. A loopback interface is a virtual network interface that the system uses to communicate with itself. Loopback interfaces are used for testing and diagnostics, and they are not associated with any physical network adapter.
    /// </summary>
    Loopback = NET_IF_ACCESS_LOOPBACK,
    /// <summary>
    /// The interface is a broadcast interface. A broadcast interface is a network interface that supports broadcasting, which allows it to send packets to all devices on the same network segment. Broadcast interfaces are typically used for local area networks (LANs).
    /// </summary>
    Broadcast = NET_IF_ACCESS_BROADCAST,
    /// <summary>
    /// The interface is a point-to-point interface. A point-to-point interface is a network interface that connects two devices directly, without any intermediate devices. Point-to-point interfaces are typically used for wide area networks (WANs) and virtual private networks (VPNs).
    /// </summary>
    PointToPoint = NET_IF_ACCESS_POINT_TO_POINT,
    /// <summary>
    /// The interface is a point-to-multipoint interface. A point-to-multipoint interface is a network interface that connects one device to multiple devices. Point-to-multipoint interfaces are typically used for wireless networks and satellite communications.
    /// </summary>
    PointToMultiPoint = NET_IF_ACCESS_POINT_TO_MULTI_POINT,
    /// <summary>
    /// The access type of the interface is unknown or cannot be determined.
    /// </summary>
    Unknown = NET_IF_ACCESS_MAXIMUM
}
