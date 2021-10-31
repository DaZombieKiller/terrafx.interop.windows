// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("85401FD4-6DE4-4B9D-9869-2D6753A82F3C")]
    [NativeTypeName("struct IAudioAutoGainControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAudioAutoGainControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAudioAutoGainControl*, Guid*, void**, int>)(lpVtbl[0]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAudioAutoGainControl*, uint>)(lpVtbl[1]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAudioAutoGainControl*, uint>)(lpVtbl[2]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnabled(BOOL* pbEnabled)
        {
            return ((delegate* unmanaged<IAudioAutoGainControl*, BOOL*, int>)(lpVtbl[3]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this), pbEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetEnabled(BOOL bEnable, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
        {
            return ((delegate* unmanaged<IAudioAutoGainControl*, BOOL, Guid*, int>)(lpVtbl[4]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this), bEnable, pguidEventContext);
        }
    }
}
