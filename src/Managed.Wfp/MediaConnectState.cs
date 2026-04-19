// <copyright file="MediaConnectState.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.IpHlpApi.Native._NET_IF_MEDIA_CONNECT_STATE;

namespace Managed.Wfp;

public enum MediaConnectState
{
    Unknown = MediaConnectStateUnknown,
    Connected = MediaConnectStateConnected,
    Disconnected = MediaConnectStateDisconnected,
}
