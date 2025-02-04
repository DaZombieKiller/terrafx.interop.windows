// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IPersistStorage.xml' path='doc/member[@name="IPersistStorage"]/*' />
[Guid("0000010A-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPersistStorage : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistStorage : IPersistStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistStorage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistStorage*, Guid*, void**, int>)(lpVtbl[0]))((IPersistStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistStorage*, uint>)(lpVtbl[1]))((IPersistStorage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistStorage*, uint>)(lpVtbl[2]))((IPersistStorage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IPersist.GetClassID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistStorage*, Guid*, int>)(lpVtbl[3]))((IPersistStorage*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistStorage.xml' path='doc/member[@name="IPersistStorage.IsDirty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistStorage*, int>)(lpVtbl[4]))((IPersistStorage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPersistStorage.xml' path='doc/member[@name="IPersistStorage.InitNew"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InitNew(IStorage* pStg)
    {
        return ((delegate* unmanaged<IPersistStorage*, IStorage*, int>)(lpVtbl[5]))((IPersistStorage*)Unsafe.AsPointer(ref this), pStg);
    }

    /// <include file='IPersistStorage.xml' path='doc/member[@name="IPersistStorage.Load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Load(IStorage* pStg)
    {
        return ((delegate* unmanaged<IPersistStorage*, IStorage*, int>)(lpVtbl[6]))((IPersistStorage*)Unsafe.AsPointer(ref this), pStg);
    }

    /// <include file='IPersistStorage.xml' path='doc/member[@name="IPersistStorage.Save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Save(IStorage* pStgSave, BOOL fSameAsLoad)
    {
        return ((delegate* unmanaged<IPersistStorage*, IStorage*, BOOL, int>)(lpVtbl[7]))((IPersistStorage*)Unsafe.AsPointer(ref this), pStgSave, fSameAsLoad);
    }

    /// <include file='IPersistStorage.xml' path='doc/member[@name="IPersistStorage.SaveCompleted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SaveCompleted(IStorage* pStgNew)
    {
        return ((delegate* unmanaged<IPersistStorage*, IStorage*, int>)(lpVtbl[8]))((IPersistStorage*)Unsafe.AsPointer(ref this), pStgNew);
    }

    /// <include file='IPersistStorage.xml' path='doc/member[@name="IPersistStorage.HandsOffStorage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT HandsOffStorage()
    {
        return ((delegate* unmanaged<IPersistStorage*, int>)(lpVtbl[9]))((IPersistStorage*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT InitNew(IStorage* pStg);

        [VtblIndex(6)]
        HRESULT Load(IStorage* pStg);

        [VtblIndex(7)]
        HRESULT Save(IStorage* pStgSave, BOOL fSameAsLoad);

        [VtblIndex(8)]
        HRESULT SaveCompleted(IStorage* pStgNew);

        [VtblIndex(9)]
        HRESULT HandsOffStorage();
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;

        [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorage*, int> InitNew;

        [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorage*, int> Load;

        [NativeTypeName("HRESULT (IStorage *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorage*, BOOL, int> Save;

        [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorage*, int> SaveCompleted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> HandsOffStorage;
    }
}
