// <copyright file="SessionParameter.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.WinDivert.Native.WINDIVERT_PARAM;

namespace Managed.WinDivert;

public enum SessionParameter
{
    QueueLength = WINDIVERT_PARAM_QUEUE_LENGTH,
    QueueTime = WINDIVERT_PARAM_QUEUE_TIME,
    QueueSize = WINDIVERT_PARAM_QUEUE_SIZE,
    VersionMajor = WINDIVERT_PARAM_VERSION_MAJOR,
    VersionMinor = WINDIVERT_PARAM_VERSION_MINOR,
}
