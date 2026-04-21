// <copyright file="SessionFlags.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.WinDivert.Native.Methods;

namespace Managed.WinDivert;

[Flags]
public enum SessionFlags: ulong
{
    None = 0,
    Sniff = WINDIVERT_FLAG_SNIFF,
    Drop = WINDIVERT_FLAG_DROP,
    RecvOnly = WINDIVERT_FLAG_RECV_ONLY,
    ReadOnly = WINDIVERT_FLAG_READ_ONLY,
    SendOnly = WINDIVERT_FLAG_SEND_ONLY,
    WriteOnly = WINDIVERT_FLAG_WRITE_ONLY,
    NoInstall = WINDIVERT_FLAG_NO_INSTALL,
    Fragments = WINDIVERT_FLAG_FRAGMENTS
}
