// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct COINSTALLER_CONTEXT_DATA32
{
    public BOOL PostProcessing;

    [NativeTypeName("DWORD")]
    public uint InstallResult;

    [NativeTypeName("PVOID")]
    public void* PrivateData;
}
