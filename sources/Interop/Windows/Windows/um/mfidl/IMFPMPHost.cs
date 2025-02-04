// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFPMPHost.xml' path='doc/member[@name="IMFPMPHost"]/*' />
[Guid("F70CA1A9-FDC7-4782-B994-ADFFB1C98606")]
[NativeTypeName("struct IMFPMPHost : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFPMPHost : IMFPMPHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFPMPHost));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFPMPHost*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMPHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFPMPHost*, uint>)(lpVtbl[1]))((IMFPMPHost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFPMPHost*, uint>)(lpVtbl[2]))((IMFPMPHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMPHost.xml' path='doc/member[@name="IMFPMPHost.LockProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LockProcess()
    {
        return ((delegate* unmanaged<IMFPMPHost*, int>)(lpVtbl[3]))((IMFPMPHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMPHost.xml' path='doc/member[@name="IMFPMPHost.UnlockProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnlockProcess()
    {
        return ((delegate* unmanaged<IMFPMPHost*, int>)(lpVtbl[4]))((IMFPMPHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFPMPHost.xml' path='doc/member[@name="IMFPMPHost.CreateObjectByCLSID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateObjectByCLSID([NativeTypeName("const IID &")] Guid* clsid, IStream* pStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IMFPMPHost*, Guid*, IStream*, Guid*, void**, int>)(lpVtbl[5]))((IMFPMPHost*)Unsafe.AsPointer(ref this), clsid, pStream, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LockProcess();

        [VtblIndex(4)]
        HRESULT UnlockProcess();

        [VtblIndex(5)]
        HRESULT CreateObjectByCLSID([NativeTypeName("const IID &")] Guid* clsid, IStream* pStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockProcess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockProcess;

        [NativeTypeName("HRESULT (const IID &, IStream *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IStream*, Guid*, void**, int> CreateObjectByCLSID;
    }
}
