// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData"]/*' />
[Guid("A39184B7-6A36-42DE-8EEC-7DF9F3F59F33")]
[NativeTypeName("struct IDiaFrameData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaFrameData : IDiaFrameData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaFrameData));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaFrameData*, Guid*, void**, int>)(lpVtbl[0]))((IDiaFrameData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint>)(lpVtbl[1]))((IDiaFrameData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint>)(lpVtbl[2]))((IDiaFrameData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_addressSection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[3]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_addressOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[4]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_relativeVirtualAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[5]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_virtualAddress"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, ulong*, int>)(lpVtbl[6]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_lengthBlock"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_lengthBlock([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[7]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_lengthLocals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_lengthLocals([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[8]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_lengthParams"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_lengthParams([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[9]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_maxStack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_maxStack([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[10]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_lengthProlog"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_lengthProlog([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[11]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_lengthSavedRegisters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_lengthSavedRegisters([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[12]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_program"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_program([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, ushort**, int>)(lpVtbl[13]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_systemExceptionHandling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_systemExceptionHandling(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, BOOL*, int>)(lpVtbl[14]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_cplusplusExceptionHandling"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_cplusplusExceptionHandling(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, BOOL*, int>)(lpVtbl[15]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_functionStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_functionStart(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, BOOL*, int>)(lpVtbl[16]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_allocatesBasePointer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_allocatesBasePointer(BOOL* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, BOOL*, int>)(lpVtbl[17]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_type([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, uint*, int>)(lpVtbl[18]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.get_functionParent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_functionParent(IDiaFrameData** pRetVal)
    {
        return ((delegate* unmanaged<IDiaFrameData*, IDiaFrameData**, int>)(lpVtbl[19]))((IDiaFrameData*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaFrameData.xml' path='doc/member[@name="IDiaFrameData.execute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT execute(IDiaStackWalkFrame* frame)
    {
        return ((delegate* unmanaged<IDiaFrameData*, IDiaStackWalkFrame*, int>)(lpVtbl[20]))((IDiaFrameData*)Unsafe.AsPointer(ref this), frame);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_addressSection([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(4)]
        HRESULT get_addressOffset([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(5)]
        HRESULT get_relativeVirtualAddress([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(6)]
        HRESULT get_virtualAddress([NativeTypeName("ULONGLONG *")] ulong* pRetVal);

        [VtblIndex(7)]
        HRESULT get_lengthBlock([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(8)]
        HRESULT get_lengthLocals([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(9)]
        HRESULT get_lengthParams([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(10)]
        HRESULT get_maxStack([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(11)]
        HRESULT get_lengthProlog([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(12)]
        HRESULT get_lengthSavedRegisters([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(13)]
        HRESULT get_program([NativeTypeName("BSTR *")] ushort** pRetVal);

        [VtblIndex(14)]
        HRESULT get_systemExceptionHandling(BOOL* pRetVal);

        [VtblIndex(15)]
        HRESULT get_cplusplusExceptionHandling(BOOL* pRetVal);

        [VtblIndex(16)]
        HRESULT get_functionStart(BOOL* pRetVal);

        [VtblIndex(17)]
        HRESULT get_allocatesBasePointer(BOOL* pRetVal);

        [VtblIndex(18)]
        HRESULT get_type([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(19)]
        HRESULT get_functionParent(IDiaFrameData** pRetVal);

        [VtblIndex(20)]
        HRESULT execute(IDiaStackWalkFrame* frame);
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
        public delegate* unmanaged<TSelf*, uint*, int> get_addressSection;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_addressOffset;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_relativeVirtualAddress;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_virtualAddress;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_lengthBlock;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_lengthLocals;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_lengthParams;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_maxStack;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_lengthProlog;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_lengthSavedRegisters;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_program;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_systemExceptionHandling;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_cplusplusExceptionHandling;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_functionStart;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> get_allocatesBasePointer;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_type;

        [NativeTypeName("HRESULT (IDiaFrameData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaFrameData**, int> get_functionParent;

        [NativeTypeName("HRESULT (IDiaStackWalkFrame *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaStackWalkFrame*, int> execute;
    }
}
