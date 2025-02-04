// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpatialAudioObjectBase.xml' path='doc/member[@name="ISpatialAudioObjectBase"]/*' />
[Guid("CCE0B8F2-8D4D-4EFB-A8CF-3D6ECF1C30E0")]
[NativeTypeName("struct ISpatialAudioObjectBase : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpatialAudioObjectBase : ISpatialAudioObjectBase.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectBase));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectBase*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectBase*, uint>)(lpVtbl[1]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectBase*, uint>)(lpVtbl[2]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpatialAudioObjectBase.xml' path='doc/member[@name="ISpatialAudioObjectBase.GetBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectBase*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), buffer, bufferLength);
    }

    /// <include file='ISpatialAudioObjectBase.xml' path='doc/member[@name="ISpatialAudioObjectBase.SetEndOfStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectBase*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), frameCount);
    }

    /// <include file='ISpatialAudioObjectBase.xml' path='doc/member[@name="ISpatialAudioObjectBase.IsActive"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsActive(BOOL* isActive)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectBase*, BOOL*, int>)(lpVtbl[5]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), isActive);
    }

    /// <include file='ISpatialAudioObjectBase.xml' path='doc/member[@name="ISpatialAudioObjectBase.GetAudioObjectType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioObjectType(AudioObjectType* audioObjectType)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectBase*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectBase*)Unsafe.AsPointer(ref this), audioObjectType);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength);

        [VtblIndex(4)]
        HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount);

        [VtblIndex(5)]
        HRESULT IsActive(BOOL* isActive);

        [VtblIndex(6)]
        HRESULT GetAudioObjectType(AudioObjectType* audioObjectType);
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

        [NativeTypeName("HRESULT (BYTE **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetBuffer;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetEndOfStream;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsActive;

        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType*, int> GetAudioObjectType;
    }
}
