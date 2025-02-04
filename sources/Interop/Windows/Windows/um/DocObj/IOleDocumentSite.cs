// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IOleDocumentSite.xml' path='doc/member[@name="IOleDocumentSite"]/*' />
[Guid("B722BCC7-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IOleDocumentSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleDocumentSite : IOleDocumentSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleDocumentSite));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleDocumentSite*, Guid*, void**, int>)(lpVtbl[0]))((IOleDocumentSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleDocumentSite*, uint>)(lpVtbl[1]))((IOleDocumentSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleDocumentSite*, uint>)(lpVtbl[2]))((IOleDocumentSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleDocumentSite.xml' path='doc/member[@name="IOleDocumentSite.ActivateMe"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ActivateMe(IOleDocumentView* pViewToActivate)
    {
        return ((delegate* unmanaged<IOleDocumentSite*, IOleDocumentView*, int>)(lpVtbl[3]))((IOleDocumentSite*)Unsafe.AsPointer(ref this), pViewToActivate);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ActivateMe(IOleDocumentView* pViewToActivate);
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

        [NativeTypeName("HRESULT (IOleDocumentView *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleDocumentView*, int> ActivateMe;
    }
}
