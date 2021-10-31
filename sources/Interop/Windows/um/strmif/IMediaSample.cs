// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A8689A-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IMediaSample : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMediaSample
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMediaSample*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMediaSample*, uint>)(lpVtbl[1]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMediaSample*, uint>)(lpVtbl[2]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPointer([NativeTypeName("BYTE **")] byte** ppBuffer)
        {
            return ((delegate* unmanaged<IMediaSample*, byte**, int>)(lpVtbl[3]))((IMediaSample*)Unsafe.AsPointer(ref this), ppBuffer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("long")]
        public int GetSize()
        {
            return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[4]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample*, long*, long*, int>)(lpVtbl[5]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample*, long*, long*, int>)(lpVtbl[6]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsSyncPoint()
        {
            return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[7]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetSyncPoint(BOOL bIsSyncPoint)
        {
            return ((delegate* unmanaged<IMediaSample*, BOOL, int>)(lpVtbl[8]))((IMediaSample*)Unsafe.AsPointer(ref this), bIsSyncPoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int IsPreroll()
        {
            return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[9]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetPreroll(BOOL bIsPreroll)
        {
            return ((delegate* unmanaged<IMediaSample*, BOOL, int>)(lpVtbl[10]))((IMediaSample*)Unsafe.AsPointer(ref this), bIsPreroll);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("long")]
        public int GetActualDataLength()
        {
            return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[11]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000)
        {
            return ((delegate* unmanaged<IMediaSample*, int, int>)(lpVtbl[12]))((IMediaSample*)Unsafe.AsPointer(ref this), __MIDL__IMediaSample0000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaType(AM_MEDIA_TYPE** ppMediaType)
        {
            return ((delegate* unmanaged<IMediaSample*, AM_MEDIA_TYPE**, int>)(lpVtbl[13]))((IMediaSample*)Unsafe.AsPointer(ref this), ppMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int SetMediaType(AM_MEDIA_TYPE* pMediaType)
        {
            return ((delegate* unmanaged<IMediaSample*, AM_MEDIA_TYPE*, int>)(lpVtbl[14]))((IMediaSample*)Unsafe.AsPointer(ref this), pMediaType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int IsDiscontinuity()
        {
            return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[15]))((IMediaSample*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SetDiscontinuity(BOOL bDiscontinuity)
        {
            return ((delegate* unmanaged<IMediaSample*, BOOL, int>)(lpVtbl[16]))((IMediaSample*)Unsafe.AsPointer(ref this), bDiscontinuity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample*, long*, long*, int>)(lpVtbl[17]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int SetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
        {
            return ((delegate* unmanaged<IMediaSample*, long*, long*, int>)(lpVtbl[18]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
        }
    }
}
