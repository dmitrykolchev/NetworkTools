// <copyright file="OperationalStatus.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.IpHlpApi.Native.IF_OPER_STATUS;

namespace Managed.Wfp;

public enum OperationalStatus
{
    Up = IfOperStatusUp,
    Down = IfOperStatusDown,
    Testing = IfOperStatusTesting,
    Unknown = IfOperStatusUnknown,
    Dormant = IfOperStatusDormant,
    NotPresent = IfOperStatusNotPresent,
    LowerLayerDown = IfOperStatusLowerLayerDown,
}
