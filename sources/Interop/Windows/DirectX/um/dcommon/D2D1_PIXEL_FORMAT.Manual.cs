// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D2D1_ALPHA_MODE;
using static TerraFX.Interop.DirectX.DXGI_FORMAT;

namespace TerraFX.Interop.DirectX;

public partial struct D2D1_PIXEL_FORMAT
{
    public static ref readonly D2D1_PIXEL_FORMAT DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                };

            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_PIXEL_FORMAT>());
            return ref Unsafe.As<byte, D2D1_PIXEL_FORMAT>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D2D1_PIXEL_FORMAT(DXGI_FORMAT format = DXGI_FORMAT_UNKNOWN, D2D1_ALPHA_MODE alphaMode = D2D1_ALPHA_MODE_UNKNOWN)
    {
        this.format = format;
        this.alphaMode = alphaMode;
    }
}
