// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaImageData.xml' path='doc/member[@name="IDiaImageData"]/*' />
[Guid("C8E40ED2-A1D9-4221-8692-3CE661184B44")]
[NativeTypeName("struct IDiaImageData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaImageData : IDiaImageData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaImageData));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaImageData*, Guid*, void**, int>)(lpVtbl[0]))((IDiaImageData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaImageData*, uint>)(lpVtbl[1]))((IDiaImageData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaImageData*, uint>)(lpVtbl[2]))((IDiaImageData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaImageData.xml' path='doc/member[@name="IDiaImageData.get_relativeVirtualAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaImageData*, uint*, int>)(lpVtbl[3]))((IDiaImageData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaImageData.xml' path='doc/member[@name="IDiaImageData.get_virtualAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaImageData*, ulong*, int>)(lpVtbl[4]))((IDiaImageData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaImageData.xml' path='doc/member[@name="IDiaImageData.get_imageBase"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_imageBase([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaImageData*, ulong*, int>)(lpVtbl[5]))((IDiaImageData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(4)]
        HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

        [VtblIndex(5)]
        HRESULT get_imageBase([NativeTypeName("ULONGLONG *")] ulong* pRetVal);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_relativeVirtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_virtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_imageBase;
    }
}
