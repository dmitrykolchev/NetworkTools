// <copyright file="ShutdownFlags.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.WinDivert.Native.WINDIVERT_SHUTDOWN;

namespace Managed.WinDivert;

[Flags]
public enum ShutdownFlags
{
    Recv = WINDIVERT_SHUTDOWN_RECV,
    Send = WINDIVERT_SHUTDOWN_SEND,
    Both = WINDIVERT_SHUTDOWN_BOTH,
}
