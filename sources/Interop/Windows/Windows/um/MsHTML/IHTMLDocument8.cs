// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8"]/*' />
[Guid("305107D0-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDocument8 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDocument8 : IHTMLDocument8.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDocument8));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDocument8*, uint>)(lpVtbl[1]))((IHTMLDocument8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDocument8*, uint>)(lpVtbl[2]))((IHTMLDocument8*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, uint*, int>)(lpVtbl[3]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmscontentzoom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_onmscontentzoom(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[7]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmscontentzoom"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_onmscontentzoom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmspointerdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_onmspointerdown(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[9]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmspointerdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_onmspointerdown(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmspointermove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_onmspointermove(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[11]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmspointermove"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_onmspointermove(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[12]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmspointerup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_onmspointerup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[13]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmspointerup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_onmspointerup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[14]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmspointerover"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_onmspointerover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[15]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmspointerover"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_onmspointerover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[16]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmspointerout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_onmspointerout(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[17]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmspointerout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_onmspointerout(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[18]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmspointercancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_onmspointercancel(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[19]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmspointercancel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_onmspointercancel(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[20]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmspointerhover"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_onmspointerhover(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[21]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmspointerhover"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_onmspointerhover(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[22]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmsgesturestart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_onmsgesturestart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[23]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmsgesturestart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_onmsgesturestart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[24]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmsgesturechange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_onmsgesturechange(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[25]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmsgesturechange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_onmsgesturechange(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[26]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmsgestureend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_onmsgestureend(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[27]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmsgestureend"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_onmsgestureend(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[28]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmsgesturehold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_onmsgesturehold(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[29]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmsgesturehold"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_onmsgesturehold(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[30]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmsgesturetap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_onmsgesturetap(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[31]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmsgesturetap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_onmsgesturetap(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[32]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmsgesturedoubletap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_onmsgesturedoubletap(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[33]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmsgesturedoubletap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_onmsgesturedoubletap(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[34]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmsinertiastart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_onmsinertiastart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[35]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmsinertiastart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_onmsinertiastart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[36]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.elementsFromPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT elementsFromPoint(float x, float y, IHTMLDOMChildrenCollection** elementsHit)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, float, float, IHTMLDOMChildrenCollection**, int>)(lpVtbl[37]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), x, y, elementsHit);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.elementsFromRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT elementsFromRect(float left, float top, float width, float height, IHTMLDOMChildrenCollection** elementsHit)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, float, float, float, float, IHTMLDOMChildrenCollection**, int>)(lpVtbl[38]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), left, top, width, height, elementsHit);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_onmsmanipulationstatechanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_onmsmanipulationstatechanged(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT, int>)(lpVtbl[39]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_onmsmanipulationstatechanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_onmsmanipulationstatechanged(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, VARIANT*, int>)(lpVtbl[40]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.put_msCapsLockWarningOff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_msCapsLockWarningOff([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, short, int>)(lpVtbl[41]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLDocument8.xml' path='doc/member[@name="IHTMLDocument8.get_msCapsLockWarningOff"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_msCapsLockWarningOff([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLDocument8*, short*, int>)(lpVtbl[42]))((IHTMLDocument8*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_onmscontentzoom(VARIANT v);

        [VtblIndex(8)]
        HRESULT get_onmscontentzoom(VARIANT* p);

        [VtblIndex(9)]
        HRESULT put_onmspointerdown(VARIANT v);

        [VtblIndex(10)]
        HRESULT get_onmspointerdown(VARIANT* p);

        [VtblIndex(11)]
        HRESULT put_onmspointermove(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_onmspointermove(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_onmspointerup(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_onmspointerup(VARIANT* p);

        [VtblIndex(15)]
        HRESULT put_onmspointerover(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_onmspointerover(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_onmspointerout(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_onmspointerout(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_onmspointercancel(VARIANT v);

        [VtblIndex(20)]
        HRESULT get_onmspointercancel(VARIANT* p);

        [VtblIndex(21)]
        HRESULT put_onmspointerhover(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_onmspointerhover(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_onmsgesturestart(VARIANT v);

        [VtblIndex(24)]
        HRESULT get_onmsgesturestart(VARIANT* p);

        [VtblIndex(25)]
        HRESULT put_onmsgesturechange(VARIANT v);

        [VtblIndex(26)]
        HRESULT get_onmsgesturechange(VARIANT* p);

        [VtblIndex(27)]
        HRESULT put_onmsgestureend(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_onmsgestureend(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_onmsgesturehold(VARIANT v);

        [VtblIndex(30)]
        HRESULT get_onmsgesturehold(VARIANT* p);

        [VtblIndex(31)]
        HRESULT put_onmsgesturetap(VARIANT v);

        [VtblIndex(32)]
        HRESULT get_onmsgesturetap(VARIANT* p);

        [VtblIndex(33)]
        HRESULT put_onmsgesturedoubletap(VARIANT v);

        [VtblIndex(34)]
        HRESULT get_onmsgesturedoubletap(VARIANT* p);

        [VtblIndex(35)]
        HRESULT put_onmsinertiastart(VARIANT v);

        [VtblIndex(36)]
        HRESULT get_onmsinertiastart(VARIANT* p);

        [VtblIndex(37)]
        HRESULT elementsFromPoint(float x, float y, IHTMLDOMChildrenCollection** elementsHit);

        [VtblIndex(38)]
        HRESULT elementsFromRect(float left, float top, float width, float height, IHTMLDOMChildrenCollection** elementsHit);

        [VtblIndex(39)]
        HRESULT put_onmsmanipulationstatechanged(VARIANT v);

        [VtblIndex(40)]
        HRESULT get_onmsmanipulationstatechanged(VARIANT* p);

        [VtblIndex(41)]
        HRESULT put_msCapsLockWarningOff([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(42)]
        HRESULT get_msCapsLockWarningOff([NativeTypeName("VARIANT_BOOL *")] short* p);
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

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmscontentzoom;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmscontentzoom;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerdown;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerdown;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointermove;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointermove;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerup;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerup;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerover;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerover;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerout;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerout;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointercancel;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointercancel;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmspointerhover;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmspointerhover;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturestart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturestart;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturechange;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturechange;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgestureend;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgestureend;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturehold;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturehold;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturetap;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturetap;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsgesturedoubletap;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsgesturedoubletap;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsinertiastart;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsinertiastart;

        [NativeTypeName("HRESULT (float, float, IHTMLDOMChildrenCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, IHTMLDOMChildrenCollection**, int> elementsFromPoint;

        [NativeTypeName("HRESULT (float, float, float, float, IHTMLDOMChildrenCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, IHTMLDOMChildrenCollection**, int> elementsFromRect;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onmsmanipulationstatechanged;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onmsmanipulationstatechanged;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_msCapsLockWarningOff;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_msCapsLockWarningOff;
    }
}
