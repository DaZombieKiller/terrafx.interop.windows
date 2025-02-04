// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumSectionContribs.xml' path='doc/member[@name="IDiaEnumSectionContribs"]/*' />
[Guid("1994DEB2-2C82-4B1D-A57F-AFF424D54A68")]
[NativeTypeName("struct IDiaEnumSectionContribs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumSectionContribs : IDiaEnumSectionContribs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumSectionContribs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint>)(lpVtbl[1]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint>)(lpVtbl[2]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumSectionContribs.xml' path='doc/member[@name="IDiaEnumSectionContribs.get__NewEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown** pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumSectionContribs.xml' path='doc/member[@name="IDiaEnumSectionContribs.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, int*, int>)(lpVtbl[4]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumSectionContribs.xml' path='doc/member[@name="IDiaEnumSectionContribs.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaSectionContrib** section)
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint, IDiaSectionContrib**, int>)(lpVtbl[5]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), index, section);
    }

    /// <include file='IDiaEnumSectionContribs.xml' path='doc/member[@name="IDiaEnumSectionContribs.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSectionContrib** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint, IDiaSectionContrib**, uint*, int>)(lpVtbl[6]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IDiaEnumSectionContribs.xml' path='doc/member[@name="IDiaEnumSectionContribs.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, uint, int>)(lpVtbl[7]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IDiaEnumSectionContribs.xml' path='doc/member[@name="IDiaEnumSectionContribs.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, int>)(lpVtbl[8]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumSectionContribs.xml' path='doc/member[@name="IDiaEnumSectionContribs.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(IDiaEnumSectionContribs** ppenum)
    {
        return ((delegate* unmanaged<IDiaEnumSectionContribs*, IDiaEnumSectionContribs**, int>)(lpVtbl[9]))((IDiaEnumSectionContribs*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown** pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaSectionContrib** section);

        [VtblIndex(6)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSectionContrib** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(7)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(8)]
        HRESULT Reset();

        [VtblIndex(9)]
        HRESULT Clone(IDiaEnumSectionContribs** ppenum);
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown**, int> get__NewEnum;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (DWORD, IDiaSectionContrib **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSectionContrib**, int> Item;

        [NativeTypeName("HRESULT (ULONG, IDiaSectionContrib **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaSectionContrib**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumSectionContribs **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumSectionContribs**, int> Clone;
    }
}
