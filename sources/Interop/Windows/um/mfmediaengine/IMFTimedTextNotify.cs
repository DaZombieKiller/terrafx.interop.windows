// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF6B87B6-CE12-45DB-ABA7-432FE054E57D")]
    [NativeTypeName("struct IMFTimedTextNotify : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFTimedTextNotify
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFTimedTextNotify*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFTimedTextNotify*, uint>)(lpVtbl[1]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFTimedTextNotify*, uint>)(lpVtbl[2]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void TrackAdded([NativeTypeName("DWORD")] uint trackId)
        {
            ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[3]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public void TrackRemoved([NativeTypeName("DWORD")] uint trackId)
        {
            ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[4]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public void TrackSelected([NativeTypeName("DWORD")] uint trackId, BOOL selected)
        {
            ((delegate* unmanaged<IMFTimedTextNotify*, uint, BOOL, void>)(lpVtbl[5]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId, selected);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void TrackReadyStateChanged([NativeTypeName("DWORD")] uint trackId)
        {
            ((delegate* unmanaged<IMFTimedTextNotify*, uint, void>)(lpVtbl[6]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), trackId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public void Error(MF_TIMED_TEXT_ERROR_CODE errorCode, [NativeTypeName("HRESULT")] int extendedErrorCode, [NativeTypeName("DWORD")] uint sourceTrackId)
        {
            ((delegate* unmanaged<IMFTimedTextNotify*, MF_TIMED_TEXT_ERROR_CODE, int, uint, void>)(lpVtbl[7]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), errorCode, extendedErrorCode, sourceTrackId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void Cue(MF_TIMED_TEXT_CUE_EVENT cueEvent, double currentTime, IMFTimedTextCue* cue)
        {
            ((delegate* unmanaged<IMFTimedTextNotify*, MF_TIMED_TEXT_CUE_EVENT, double, IMFTimedTextCue*, void>)(lpVtbl[8]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this), cueEvent, currentTime, cue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public void Reset()
        {
            ((delegate* unmanaged<IMFTimedTextNotify*, void>)(lpVtbl[9]))((IMFTimedTextNotify*)Unsafe.AsPointer(ref this));
        }
    }
}
