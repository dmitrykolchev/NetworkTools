// <copyright file="Layer.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.WinDivert.Native.WINDIVERT_LAYER;
namespace Managed.WinDivert;

public enum Layer
{
    Network = WINDIVERT_LAYER_NETWORK,
    NetworkForward = WINDIVERT_LAYER_NETWORK_FORWARD,
    Flow = WINDIVERT_LAYER_FLOW,
    Socket = WINDIVERT_LAYER_SOCKET,
    Reflect = WINDIVERT_LAYER_REFLECT,
}
