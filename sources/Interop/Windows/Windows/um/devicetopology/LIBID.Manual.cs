// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class LIBID
{
    public static ref readonly Guid LIBID_DevTopologyLib
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0xA0, 0xB9, 0x51,
                    0x81, 0x81,
                    0x63, 0x43,
                    0xB5,
                    0x9C,
                    0xE6,
                    0x78,
                    0xF4,
                    0x76,
                    0xDD,
                    0x0E
                };

            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
