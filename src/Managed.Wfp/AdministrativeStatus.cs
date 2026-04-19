// <copyright file="AdministrativeState.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

using static Managed.Win32.IpHlpApi.Native._IF_ADMINISTRATIVE_STATE;

namespace Managed.Wfp;

public enum AdministrativeStatus
{
    Disabled = IF_ADMINISTRATIVE_DISABLED,
    Enabled = IF_ADMINISTRATIVE_ENABLED,
    Demanddial = IF_ADMINISTRATIVE_DEMANDDIAL,
}
