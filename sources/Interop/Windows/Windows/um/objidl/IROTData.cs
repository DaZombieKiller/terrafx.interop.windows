// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IROTData.xml' path='doc/member[@name="IROTData"]/*' />
[Guid("F29F6BC0-5021-11CE-AA15-00006901293F")]
[NativeTypeName("struct IROTData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IROTData : IROTData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IROTData));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IROTData*, Guid*, void**, int>)(lpVtbl[0]))((IROTData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IROTData*, uint>)(lpVtbl[1]))((IROTData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IROTData*, uint>)(lpVtbl[2]))((IROTData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IROTData.xml' path='doc/member[@name="IROTData.GetComparisonData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComparisonData(byte* pbData, [NativeTypeName("ULONG")] uint cbMax, [NativeTypeName("ULONG *")] uint* pcbData)
    {
        return ((delegate* unmanaged<IROTData*, byte*, uint, uint*, int>)(lpVtbl[3]))((IROTData*)Unsafe.AsPointer(ref this), pbData, cbMax, pcbData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetComparisonData(byte* pbData, [NativeTypeName("ULONG")] uint cbMax, [NativeTypeName("ULONG *")] uint* pcbData);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (byte *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, uint*, int> GetComparisonData;
    }
}
