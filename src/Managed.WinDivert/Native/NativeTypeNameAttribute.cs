// <copyright file="NativeTypeNameAttribute.cs" company="Dmitry Kolchev">
// Copyright (c) 2026 Dmitry Kolchev. All rights reserved.
// See LICENSE in the project root for license information
// </copyright>

namespace Managed.Win32.Native;

[AttributeUsage(AttributeTargets.All)]
internal class NativeTypeNameAttribute : Attribute
{
    public NativeTypeNameAttribute(string typeName) { }
}
