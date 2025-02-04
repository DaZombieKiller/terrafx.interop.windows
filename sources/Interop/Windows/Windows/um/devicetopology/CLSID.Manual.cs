// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class CLSID
{
    public static ref readonly Guid CLSID_DeviceTopology
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x39, 0xF6, 0x1D,
                    0xC1, 0x5E,
                    0xAA, 0x47,
                    0x93,
                    0x79,
                    0x82,
                    0x8D,
                    0xC1,
                    0xAA,
                    0x8C,
                    0x59
                };

            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
