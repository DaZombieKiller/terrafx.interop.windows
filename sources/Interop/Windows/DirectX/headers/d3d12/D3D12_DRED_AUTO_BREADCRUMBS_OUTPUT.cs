// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT"]/*' />
public unsafe partial struct D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT
{
    /// <include file='D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT.pHeadAutoBreadcrumbNode"]/*' />
    [NativeTypeName("const D3D12_AUTO_BREADCRUMB_NODE *")]
    public D3D12_AUTO_BREADCRUMB_NODE* pHeadAutoBreadcrumbNode;
}
