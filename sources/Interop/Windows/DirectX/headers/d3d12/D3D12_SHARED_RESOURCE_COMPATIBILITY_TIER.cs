// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER.xml' path='doc/member[@name="D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER"]/*' />
public enum D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER
{
    /// <include file='D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER.xml' path='doc/member[@name="D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER.D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0"]/*' />
    D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0 = 0,

    /// <include file='D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER.xml' path='doc/member[@name="D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER.D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1"]/*' />
    D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1 = (D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_0 + 1),

    /// <include file='D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER.xml' path='doc/member[@name="D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER.D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_2"]/*' />
    D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_2 = (D3D12_SHARED_RESOURCE_COMPATIBILITY_TIER_1 + 1),
}
