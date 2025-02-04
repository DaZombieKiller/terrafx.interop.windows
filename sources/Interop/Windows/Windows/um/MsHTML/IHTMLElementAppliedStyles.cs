// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLElementAppliedStyles.xml' path='doc/member[@name="IHTMLElementAppliedStyles"]/*' />
[Guid("305104BD-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElementAppliedStyles : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElementAppliedStyles : IHTMLElementAppliedStyles.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLElementAppliedStyles));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, uint>)(lpVtbl[1]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, uint>)(lpVtbl[2]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, uint*, int>)(lpVtbl[3]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLElementAppliedStyles.xml' path='doc/member[@name="IHTMLElementAppliedStyles.msGetRulesApplied"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT msGetRulesApplied(IRulesAppliedCollection** ppRulesAppliedCollection)
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, IRulesAppliedCollection**, int>)(lpVtbl[7]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this), ppRulesAppliedCollection);
    }

    /// <include file='IHTMLElementAppliedStyles.xml' path='doc/member[@name="IHTMLElementAppliedStyles.msGetRulesAppliedWithAncestor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT msGetRulesAppliedWithAncestor(VARIANT varContext, IRulesAppliedCollection** ppRulesAppliedCollection)
    {
        return ((delegate* unmanaged<IHTMLElementAppliedStyles*, VARIANT, IRulesAppliedCollection**, int>)(lpVtbl[8]))((IHTMLElementAppliedStyles*)Unsafe.AsPointer(ref this), varContext, ppRulesAppliedCollection);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT msGetRulesApplied(IRulesAppliedCollection** ppRulesAppliedCollection);

        [VtblIndex(8)]
        HRESULT msGetRulesAppliedWithAncestor(VARIANT varContext, IRulesAppliedCollection** ppRulesAppliedCollection);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (IRulesAppliedCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IRulesAppliedCollection**, int> msGetRulesApplied;

        [NativeTypeName("HRESULT (VARIANT, IRulesAppliedCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, IRulesAppliedCollection**, int> msGetRulesAppliedWithAncestor;
    }
}
