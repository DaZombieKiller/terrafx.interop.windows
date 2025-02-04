// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAMAnalogVideoEncoder.xml' path='doc/member[@name="IAMAnalogVideoEncoder"]/*' />
[Guid("C6E133B0-30AC-11D0-A18C-00A0C9118956")]
[NativeTypeName("struct IAMAnalogVideoEncoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMAnalogVideoEncoder : IAMAnalogVideoEncoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMAnalogVideoEncoder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, Guid*, void**, int>)(lpVtbl[0]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, uint>)(lpVtbl[1]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, uint>)(lpVtbl[2]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMAnalogVideoEncoder.xml' path='doc/member[@name="IAMAnalogVideoEncoder.get_AvailableTVFormats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard)
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, int*, int>)(lpVtbl[3]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
    }

    /// <include file='IAMAnalogVideoEncoder.xml' path='doc/member[@name="IAMAnalogVideoEncoder.put_TVFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_TVFormat([NativeTypeName("long")] int lAnalogVideoStandard)
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, int, int>)(lpVtbl[4]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lAnalogVideoStandard);
    }

    /// <include file='IAMAnalogVideoEncoder.xml' path='doc/member[@name="IAMAnalogVideoEncoder.get_TVFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard)
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, int*, int>)(lpVtbl[5]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), plAnalogVideoStandard);
    }

    /// <include file='IAMAnalogVideoEncoder.xml' path='doc/member[@name="IAMAnalogVideoEncoder.put_CopyProtection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_CopyProtection([NativeTypeName("long")] int lVideoCopyProtection)
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, int, int>)(lpVtbl[6]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lVideoCopyProtection);
    }

    /// <include file='IAMAnalogVideoEncoder.xml' path='doc/member[@name="IAMAnalogVideoEncoder.get_CopyProtection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CopyProtection([NativeTypeName("long *")] int* lVideoCopyProtection)
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, int*, int>)(lpVtbl[7]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lVideoCopyProtection);
    }

    /// <include file='IAMAnalogVideoEncoder.xml' path='doc/member[@name="IAMAnalogVideoEncoder.put_CCEnable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CCEnable([NativeTypeName("long")] int lCCEnable)
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, int, int>)(lpVtbl[8]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lCCEnable);
    }

    /// <include file='IAMAnalogVideoEncoder.xml' path='doc/member[@name="IAMAnalogVideoEncoder.get_CCEnable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CCEnable([NativeTypeName("long *")] int* lCCEnable)
    {
        return ((delegate* unmanaged<IAMAnalogVideoEncoder*, int*, int>)(lpVtbl[9]))((IAMAnalogVideoEncoder*)Unsafe.AsPointer(ref this), lCCEnable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard);

        [VtblIndex(4)]
        HRESULT put_TVFormat([NativeTypeName("long")] int lAnalogVideoStandard);

        [VtblIndex(5)]
        HRESULT get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard);

        [VtblIndex(6)]
        HRESULT put_CopyProtection([NativeTypeName("long")] int lVideoCopyProtection);

        [VtblIndex(7)]
        HRESULT get_CopyProtection([NativeTypeName("long *")] int* lVideoCopyProtection);

        [VtblIndex(8)]
        HRESULT put_CCEnable([NativeTypeName("long")] int lCCEnable);

        [VtblIndex(9)]
        HRESULT get_CCEnable([NativeTypeName("long *")] int* lCCEnable);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AvailableTVFormats;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_TVFormat;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TVFormat;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_CopyProtection;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_CopyProtection;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_CCEnable;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_CCEnable;
    }
}
