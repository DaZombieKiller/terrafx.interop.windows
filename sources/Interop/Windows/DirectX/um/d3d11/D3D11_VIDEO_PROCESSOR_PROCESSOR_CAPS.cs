// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND"]/*' />
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BLEND = 0x1,

    /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB"]/*' />
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_BOB = 0x2,

    /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE"]/*' />
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_ADAPTIVE = 0x4,

    /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION"]/*' />
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_DEINTERLACE_MOTION_COMPENSATION = 0x8,

    /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE"]/*' />
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_INVERSE_TELECINE = 0x10,

    /// <include file='D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS.D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION"]/*' />
    D3D11_VIDEO_PROCESSOR_PROCESSOR_CAPS_FRAME_RATE_CONVERSION = 0x20,
}
