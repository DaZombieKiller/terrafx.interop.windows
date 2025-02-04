// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct PACKAGE_ID
{
    [NativeTypeName("UINT32")]
    public uint reserved;

    [NativeTypeName("UINT32")]
    public uint processorArchitecture;

    public PACKAGE_VERSION version;

    [NativeTypeName("PWSTR")]
    public ushort* name;

    [NativeTypeName("PWSTR")]
    public ushort* publisher;

    [NativeTypeName("PWSTR")]
    public ushort* resourceId;

    [NativeTypeName("PWSTR")]
    public ushort* publisherId;
}
