// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A714590A-58AF-430A-85BF-44F5EC838D85")]
    [NativeTypeName("struct IMFPMediaPlayer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFPMediaPlayer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, Guid*, void**, int>)(lpVtbl[0]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, uint>)(lpVtbl[1]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, uint>)(lpVtbl[2]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Play()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, int>)(lpVtbl[3]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Pause()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, int>)(lpVtbl[4]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Stop()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, int>)(lpVtbl[5]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int FrameStep()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, int>)(lpVtbl[6]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetPosition([NativeTypeName("const GUID &")] Guid* guidPositionType, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvPositionValue)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[7]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvPositionValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetPosition([NativeTypeName("const GUID &")] Guid* guidPositionType, PROPVARIANT* pvPositionValue)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[8]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvPositionValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetDuration([NativeTypeName("const GUID &")] Guid* guidPositionType, PROPVARIANT* pvDurationValue)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, Guid*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), guidPositionType, pvDurationValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetRate(float flRate)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, float, int>)(lpVtbl[10]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetRate(float* pflRate)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, float*, int>)(lpVtbl[11]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetSupportedRates(BOOL fForwardDirection, float* pflSlowestRate, float* pflFastestRate)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, BOOL, float*, float*, int>)(lpVtbl[12]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), fForwardDirection, pflSlowestRate, pflFastestRate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetState(MFP_MEDIAPLAYER_STATE* peState)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, MFP_MEDIAPLAYER_STATE*, int>)(lpVtbl[13]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), peState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMediaItemFromURL([NativeTypeName("LPCWSTR")] ushort* pwszURL, BOOL fSync, [NativeTypeName("DWORD_PTR")] nuint dwUserData, IMFPMediaItem** ppMediaItem)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, ushort*, BOOL, nuint, IMFPMediaItem**, int>)(lpVtbl[14]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pwszURL, fSync, dwUserData, ppMediaItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int CreateMediaItemFromObject(IUnknown* pIUnknownObj, BOOL fSync, [NativeTypeName("DWORD_PTR")] nuint dwUserData, IMFPMediaItem** ppMediaItem)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, IUnknown*, BOOL, nuint, IMFPMediaItem**, int>)(lpVtbl[15]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pIUnknownObj, fSync, dwUserData, ppMediaItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetMediaItem(IMFPMediaItem* pIMFPMediaItem)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, IMFPMediaItem*, int>)(lpVtbl[16]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pIMFPMediaItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int ClearMediaItem()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, int>)(lpVtbl[17]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaItem(IMFPMediaItem** ppIMFPMediaItem)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, IMFPMediaItem**, int>)(lpVtbl[18]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), ppIMFPMediaItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetVolume(float* pflVolume)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, float*, int>)(lpVtbl[19]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetVolume(float flVolume)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, float, int>)(lpVtbl[20]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flVolume);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetBalance(float* pflBalance)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, float*, int>)(lpVtbl[21]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pflBalance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int SetBalance(float flBalance)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, float, int>)(lpVtbl[22]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), flBalance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int GetMute(BOOL* pfMute)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, BOOL*, int>)(lpVtbl[23]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pfMute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int SetMute(BOOL fMute)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, BOOL, int>)(lpVtbl[24]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), fMute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int GetNativeVideoSize(SIZE* pszVideo, SIZE* pszARVideo)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, SIZE*, SIZE*, int>)(lpVtbl[25]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pszVideo, pszARVideo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int GetIdealVideoSize(SIZE* pszMin, SIZE* pszMax)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, SIZE*, SIZE*, int>)(lpVtbl[26]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pszMin, pszMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int SetVideoSourceRect([NativeTypeName("const MFVideoNormalizedRect *")] MFVideoNormalizedRect* pnrcSource)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, MFVideoNormalizedRect*, int>)(lpVtbl[27]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pnrcSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoSourceRect(MFVideoNormalizedRect* pnrcSource)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, MFVideoNormalizedRect*, int>)(lpVtbl[28]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pnrcSource);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int SetAspectRatioMode([NativeTypeName("DWORD")] uint dwAspectRatioMode)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, uint, int>)(lpVtbl[29]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), dwAspectRatioMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int GetAspectRatioMode([NativeTypeName("DWORD *")] uint* pdwAspectRatioMode)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, uint*, int>)(lpVtbl[30]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pdwAspectRatioMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int GetVideoWindow([NativeTypeName("HWND *")] IntPtr* phwndVideo)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, IntPtr*, int>)(lpVtbl[31]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), phwndVideo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateVideo()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, int>)(lpVtbl[32]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int SetBorderColor([NativeTypeName("COLORREF")] uint Clr)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, uint, int>)(lpVtbl[33]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), Clr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int GetBorderColor([NativeTypeName("COLORREF *")] uint* pClr)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, uint*, int>)(lpVtbl[34]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pClr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int InsertEffect(IUnknown* pEffect, BOOL fOptional)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, IUnknown*, BOOL, int>)(lpVtbl[35]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pEffect, fOptional);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveEffect(IUnknown* pEffect)
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, IUnknown*, int>)(lpVtbl[36]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this), pEffect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllEffects()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, int>)(lpVtbl[37]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* unmanaged<IMFPMediaPlayer*, int>)(lpVtbl[38]))((IMFPMediaPlayer*)Unsafe.AsPointer(ref this));
        }
    }
}
