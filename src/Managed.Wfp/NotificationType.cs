// <copyright file="NotificationType.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.IpHlpApi.Native._MIB_NOTIFICATION_TYPE;
namespace Managed.Wfp;

public enum NotificationType
{
    ParameterNotification = MibParameterNotification,
    AddInstance = MibAddInstance,
    DeleteInstance = MibDeleteInstance,
    InitialNotification = MibInitialNotification
}
