// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IEnumDMO.xml' path='doc/member[@name="IEnumDMO"]/*' />
[Guid("2C3CD98A-2BFA-4A53-9C27-5249BA64BA0F")]
[NativeTypeName("struct IEnumDMO : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IEnumDMO : IEnumDMO.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEnumDMO));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEnumDMO*, Guid*, void**, int>)(lpVtbl[0]))((IEnumDMO*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEnumDMO*, uint>)(lpVtbl[1]))((IEnumDMO*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEnumDMO*, uint>)(lpVtbl[2]))((IEnumDMO*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumDMO.xml' path='doc/member[@name="IEnumDMO.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Next([NativeTypeName("DWORD")] uint cItemsToFetch, [NativeTypeName("CLSID *")] Guid* pCLSID, [NativeTypeName("LPWSTR *")] ushort** Names, [NativeTypeName("DWORD *")] uint* pcItemsFetched)
    {
        return ((delegate* unmanaged<IEnumDMO*, uint, Guid*, ushort**, uint*, int>)(lpVtbl[3]))((IEnumDMO*)Unsafe.AsPointer(ref this), cItemsToFetch, pCLSID, Names, pcItemsFetched);
    }

    /// <include file='IEnumDMO.xml' path='doc/member[@name="IEnumDMO.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Skip([NativeTypeName("DWORD")] uint cItemsToSkip)
    {
        return ((delegate* unmanaged<IEnumDMO*, uint, int>)(lpVtbl[4]))((IEnumDMO*)Unsafe.AsPointer(ref this), cItemsToSkip);
    }

    /// <include file='IEnumDMO.xml' path='doc/member[@name="IEnumDMO.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IEnumDMO*, int>)(lpVtbl[5]))((IEnumDMO*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IEnumDMO.xml' path='doc/member[@name="IEnumDMO.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Clone(IEnumDMO** ppEnum)
    {
        return ((delegate* unmanaged<IEnumDMO*, IEnumDMO**, int>)(lpVtbl[6]))((IEnumDMO*)Unsafe.AsPointer(ref this), ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Next([NativeTypeName("DWORD")] uint cItemsToFetch, [NativeTypeName("CLSID *")] Guid* pCLSID, [NativeTypeName("LPWSTR *")] ushort** Names, [NativeTypeName("DWORD *")] uint* pcItemsFetched);

        [VtblIndex(4)]
        HRESULT Skip([NativeTypeName("DWORD")] uint cItemsToSkip);

        [VtblIndex(5)]
        HRESULT Reset();

        [VtblIndex(6)]
        HRESULT Clone(IEnumDMO** ppEnum);
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

        [NativeTypeName("HRESULT (DWORD, CLSID *, LPWSTR *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, ushort**, uint*, int> Next;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IEnumDMO **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumDMO**, int> Clone;
    }
}
