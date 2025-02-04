// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_FEATURE.xml' path='doc/member[@name="D2D1_FEATURE"]/*' />
public enum D2D1_FEATURE : uint
{
    /// <include file='D2D1_FEATURE.xml' path='doc/member[@name="D2D1_FEATURE.D2D1_FEATURE_DOUBLES"]/*' />
    D2D1_FEATURE_DOUBLES = 0,

    /// <include file='D2D1_FEATURE.xml' path='doc/member[@name="D2D1_FEATURE.D2D1_FEATURE_D3D10_X_HARDWARE_OPTIONS"]/*' />
    D2D1_FEATURE_D3D10_X_HARDWARE_OPTIONS = 1,

    /// <include file='D2D1_FEATURE.xml' path='doc/member[@name="D2D1_FEATURE.D2D1_FEATURE_FORCE_DWORD"]/*' />
    D2D1_FEATURE_FORCE_DWORD = 0xffffffff,
}
