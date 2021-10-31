// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF45AEEA-B74A-4B6B-AFAD-2366B6AA012E")]
    [NativeTypeName("struct IAudioMute : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioMute
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioMute*, Guid*, void**, int>)(lpVtbl[0]))((IAudioMute*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioMute*, uint>)(lpVtbl[1]))((IAudioMute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioMute*, uint>)(lpVtbl[2]))((IAudioMute*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetMute(BOOL bMuted, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioMute*, BOOL, Guid*, int>)(lpVtbl[3]))((IAudioMute*)Unsafe.AsPointer(ref this), bMuted, pguidEventContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetMute(BOOL* pbMuted)
        {
            return ((delegate* unmanaged<IAudioMute*, BOOL*, int>)(lpVtbl[4]))((IAudioMute*)Unsafe.AsPointer(ref this), pbMuted);
        }
    }
}
