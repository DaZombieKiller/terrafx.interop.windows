// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_PIXEL_OPTIONS.xml' path='doc/member[@name="D2D1_PIXEL_OPTIONS"]/*' />
[Flags]
public enum D2D1_PIXEL_OPTIONS : uint
{
    /// <include file='D2D1_PIXEL_OPTIONS.xml' path='doc/member[@name="D2D1_PIXEL_OPTIONS.D2D1_PIXEL_OPTIONS_NONE"]/*' />
    D2D1_PIXEL_OPTIONS_NONE = 0,

    /// <include file='D2D1_PIXEL_OPTIONS.xml' path='doc/member[@name="D2D1_PIXEL_OPTIONS.D2D1_PIXEL_OPTIONS_TRIVIAL_SAMPLING"]/*' />
    D2D1_PIXEL_OPTIONS_TRIVIAL_SAMPLING = 1,

    /// <include file='D2D1_PIXEL_OPTIONS.xml' path='doc/member[@name="D2D1_PIXEL_OPTIONS.D2D1_PIXEL_OPTIONS_FORCE_DWORD"]/*' />
    D2D1_PIXEL_OPTIONS_FORCE_DWORD = 0xffffffff,
}
