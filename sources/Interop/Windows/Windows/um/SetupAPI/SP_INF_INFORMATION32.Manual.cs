// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SP_INF_INFORMATION32
{
    [NativeTypeName("DWORD")]
    public uint InfStyle;

    [NativeTypeName("DWORD")]
    public uint InfCount;

    [NativeTypeName("BYTE [1]")]
    public fixed byte VersionData[1];
}
