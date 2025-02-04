// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr"]/*' />
[Guid("87955690-E627-11D2-8DDB-00105A2799B5")]
[NativeTypeName("struct ITfLangBarMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfLangBarMgr : ITfLangBarMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLangBarMgr));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint>)(lpVtbl[1]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint>)(lpVtbl[2]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.AdviseEventSink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseEventSink(ITfLangBarEventSink* pSink, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, ITfLangBarEventSink*, HWND, uint, uint*, int>)(lpVtbl[3]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pSink, hwnd, dwFlags, pdwCookie);
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.UnadviseEventSink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseEventSink([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint, int>)(lpVtbl[4]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.GetThreadMarshalInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetThreadMarshalInterface([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint, uint, Guid*, IUnknown**, int>)(lpVtbl[5]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, dwType, riid, ppunk);
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.GetThreadLangBarItemMgr"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetThreadLangBarItemMgr([NativeTypeName("DWORD")] uint dwThreadId, ITfLangBarItemMgr** pplbi, [NativeTypeName("DWORD *")] uint* pdwThreadid)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint, ITfLangBarItemMgr**, uint*, int>)(lpVtbl[6]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, pplbi, pdwThreadid);
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.GetInputProcessorProfiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInputProcessorProfiles([NativeTypeName("DWORD")] uint dwThreadId, ITfInputProcessorProfiles** ppaip, [NativeTypeName("DWORD *")] uint* pdwThreadid)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint, ITfInputProcessorProfiles**, uint*, int>)(lpVtbl[7]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, ppaip, pdwThreadid);
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.RestoreLastFocus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RestoreLastFocus([NativeTypeName("DWORD *")] uint* pdwThreadId, BOOL fPrev)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint*, BOOL, int>)(lpVtbl[8]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pdwThreadId, fPrev);
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.SetModalInput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetModalInput(ITfLangBarEventSink* pSink, [NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, ITfLangBarEventSink*, uint, uint, int>)(lpVtbl[9]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pSink, dwThreadId, dwFlags);
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.ShowFloating"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ShowFloating([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint, int>)(lpVtbl[10]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwFlags);
    }

    /// <include file='ITfLangBarMgr.xml' path='doc/member[@name="ITfLangBarMgr.GetShowFloatingStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetShowFloatingStatus([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITfLangBarMgr*, uint*, int>)(lpVtbl[11]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseEventSink(ITfLangBarEventSink* pSink, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [VtblIndex(4)]
        HRESULT UnadviseEventSink([NativeTypeName("DWORD")] uint dwCookie);

        [VtblIndex(5)]
        HRESULT GetThreadMarshalInterface([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk);

        [VtblIndex(6)]
        HRESULT GetThreadLangBarItemMgr([NativeTypeName("DWORD")] uint dwThreadId, ITfLangBarItemMgr** pplbi, [NativeTypeName("DWORD *")] uint* pdwThreadid);

        [VtblIndex(7)]
        HRESULT GetInputProcessorProfiles([NativeTypeName("DWORD")] uint dwThreadId, ITfInputProcessorProfiles** ppaip, [NativeTypeName("DWORD *")] uint* pdwThreadid);

        [VtblIndex(8)]
        HRESULT RestoreLastFocus([NativeTypeName("DWORD *")] uint* pdwThreadId, BOOL fPrev);

        [VtblIndex(9)]
        HRESULT SetModalInput(ITfLangBarEventSink* pSink, [NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(10)]
        HRESULT ShowFloating([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(11)]
        HRESULT GetShowFloatingStatus([NativeTypeName("DWORD *")] uint* pdwFlags);
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

        [NativeTypeName("HRESULT (ITfLangBarEventSink *, HWND, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfLangBarEventSink*, HWND, uint, uint*, int> AdviseEventSink;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnadviseEventSink;

        [NativeTypeName("HRESULT (DWORD, DWORD, const IID &, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, Guid*, IUnknown**, int> GetThreadMarshalInterface;

        [NativeTypeName("HRESULT (DWORD, ITfLangBarItemMgr **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfLangBarItemMgr**, uint*, int> GetThreadLangBarItemMgr;

        [NativeTypeName("HRESULT (DWORD, ITfInputProcessorProfiles **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfInputProcessorProfiles**, uint*, int> GetInputProcessorProfiles;

        [NativeTypeName("HRESULT (DWORD *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, BOOL, int> RestoreLastFocus;

        [NativeTypeName("HRESULT (ITfLangBarEventSink *, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfLangBarEventSink*, uint, uint, int> SetModalInput;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ShowFloating;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetShowFloatingStatus;
    }
}
