// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpatialAudioObjectForMetadataItems.xml' path='doc/member[@name="ISpatialAudioObjectForMetadataItems"]/*' />
[Guid("DDEA49FF-3BC0-4377-8AAD-9FBCFD808566")]
[NativeTypeName("struct ISpatialAudioObjectForMetadataItems : ISpatialAudioObjectBase")]
[NativeInheritance("ISpatialAudioObjectBase")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioObjectForMetadataItems : ISpatialAudioObjectForMetadataItems.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioObjectForMetadataItems));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint>)(lpVtbl[1]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint>)(lpVtbl[2]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISpatialAudioObjectBase.GetBuffer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(byte** buffer, [NativeTypeName("UINT32 *")] uint* bufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, byte**, uint*, int>)(lpVtbl[3]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), buffer, bufferLength);
    }

    /// <inheritdoc cref="ISpatialAudioObjectBase.SetEndOfStream" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEndOfStream([NativeTypeName("UINT32")] uint frameCount)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, uint, int>)(lpVtbl[4]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), frameCount);
    }

    /// <inheritdoc cref="ISpatialAudioObjectBase.IsActive" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsActive(BOOL* isActive)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, BOOL*, int>)(lpVtbl[5]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), isActive);
    }

    /// <inheritdoc cref="ISpatialAudioObjectBase.GetAudioObjectType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAudioObjectType(AudioObjectType* audioObjectType)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, AudioObjectType*, int>)(lpVtbl[6]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), audioObjectType);
    }

    /// <include file='ISpatialAudioObjectForMetadataItems.xml' path='doc/member[@name="ISpatialAudioObjectForMetadataItems.GetSpatialAudioMetadataItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetSpatialAudioMetadataItems(ISpatialAudioMetadataItems** metadataItems)
    {
        return ((delegate* unmanaged<ISpatialAudioObjectForMetadataItems*, ISpatialAudioMetadataItems**, int>)(lpVtbl[7]))((ISpatialAudioObjectForMetadataItems*)Unsafe.AsPointer(ref this), metadataItems);
    }

    public interface Interface : ISpatialAudioObjectBase.Interface
    {
        [VtblIndex(7)]
        HRESULT GetSpatialAudioMetadataItems(ISpatialAudioMetadataItems** metadataItems);
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

        [NativeTypeName("HRESULT (ISpatialAudioMetadataItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpatialAudioMetadataItems**, int> GetSpatialAudioMetadataItems;
    }
}
