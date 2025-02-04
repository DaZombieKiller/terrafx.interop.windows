// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaEnumLineNumbers.xml' path='doc/member[@name="IDiaEnumLineNumbers"]/*' />
[Guid("FE30E878-54AC-44F1-81BA-39DE940F6052")]
[NativeTypeName("struct IDiaEnumLineNumbers : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaEnumLineNumbers : IDiaEnumLineNumbers.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaEnumLineNumbers));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint>)(lpVtbl[1]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint>)(lpVtbl[2]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumLineNumbers.xml' path='doc/member[@name="IDiaEnumLineNumbers.get__NewEnum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get__NewEnum(IUnknown** pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, IUnknown**, int>)(lpVtbl[3]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumLineNumbers.xml' path='doc/member[@name="IDiaEnumLineNumbers.get_Count"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal)
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, int*, int>)(lpVtbl[4]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaEnumLineNumbers.xml' path='doc/member[@name="IDiaEnumLineNumbers.Item"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaLineNumber** lineNumber)
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint, IDiaLineNumber**, int>)(lpVtbl[5]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), index, lineNumber);
    }

    /// <include file='IDiaEnumLineNumbers.xml' path='doc/member[@name="IDiaEnumLineNumbers.Next"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaLineNumber** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint, IDiaLineNumber**, uint*, int>)(lpVtbl[6]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
    }

    /// <include file='IDiaEnumLineNumbers.xml' path='doc/member[@name="IDiaEnumLineNumbers.Skip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, uint, int>)(lpVtbl[7]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), celt);
    }

    /// <include file='IDiaEnumLineNumbers.xml' path='doc/member[@name="IDiaEnumLineNumbers.Reset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, int>)(lpVtbl[8]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaEnumLineNumbers.xml' path='doc/member[@name="IDiaEnumLineNumbers.Clone"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clone(IDiaEnumLineNumbers** ppenum)
    {
        return ((delegate* unmanaged<IDiaEnumLineNumbers*, IDiaEnumLineNumbers**, int>)(lpVtbl[9]))((IDiaEnumLineNumbers*)Unsafe.AsPointer(ref this), ppenum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get__NewEnum(IUnknown** pRetVal);

        [VtblIndex(4)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* pRetVal);

        [VtblIndex(5)]
        HRESULT Item([NativeTypeName("DWORD")] uint index, IDiaLineNumber** lineNumber);

        [VtblIndex(6)]
        HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaLineNumber** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

        [VtblIndex(7)]
        HRESULT Skip([NativeTypeName("ULONG")] uint celt);

        [VtblIndex(8)]
        HRESULT Reset();

        [VtblIndex(9)]
        HRESULT Clone(IDiaEnumLineNumbers** ppenum);
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

        [NativeTypeName("HRESULT (DWORD, IDiaLineNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaLineNumber**, int> Item;

        [NativeTypeName("HRESULT (ULONG, IDiaLineNumber **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IDiaLineNumber**, uint*, int> Next;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Skip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (IDiaEnumLineNumbers **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumLineNumbers**, int> Clone;
    }
}
