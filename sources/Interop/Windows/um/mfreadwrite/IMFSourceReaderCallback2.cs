// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF839FE6-8C2A-4DD2-B6EA-C22D6961AF05")]
    [NativeTypeName("struct IMFSourceReaderCallback2 : IMFSourceReaderCallback")]
    [NativeInheritance("IMFSourceReaderCallback")]
    public unsafe partial struct IMFSourceReaderCallback2 : IMFSourceReaderCallback2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback2*, Guid*, void**, int>)(lpVtbl[0]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback2*, uint>)(lpVtbl[1]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback2*, uint>)(lpVtbl[2]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnReadSample(HRESULT hrStatus, [NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("DWORD")] uint dwStreamFlags, [NativeTypeName("LONGLONG")] long llTimestamp, IMFSample* pSample)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback2*, HRESULT, uint, uint, long, IMFSample*, int>)(lpVtbl[3]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), hrStatus, dwStreamIndex, dwStreamFlags, llTimestamp, pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnFlush([NativeTypeName("DWORD")] uint dwStreamIndex)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback2*, uint, int>)(lpVtbl[4]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnEvent([NativeTypeName("DWORD")] uint dwStreamIndex, IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback2*, uint, IMFMediaEvent*, int>)(lpVtbl[5]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex, pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnTransformChange()
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback2*, int>)(lpVtbl[6]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnStreamError([NativeTypeName("DWORD")] uint dwStreamIndex, HRESULT hrStatus)
        {
            return ((delegate* unmanaged<IMFSourceReaderCallback2*, uint, HRESULT, int>)(lpVtbl[7]))((IMFSourceReaderCallback2*)Unsafe.AsPointer(ref this), dwStreamIndex, hrStatus);
        }

        public interface Interface : IMFSourceReaderCallback.Interface
        {
            [VtblIndex(6)]
            HRESULT OnTransformChange();

            [VtblIndex(7)]
            HRESULT OnStreamError([NativeTypeName("DWORD")] uint dwStreamIndex, HRESULT hrStatus);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceReaderCallback2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceReaderCallback2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceReaderCallback2*, uint> Release;

            [NativeTypeName("HRESULT (HRESULT, DWORD, DWORD, LONGLONG, IMFSample *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceReaderCallback2*, HRESULT, uint, uint, long, IMFSample*, int> OnReadSample;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceReaderCallback2*, uint, int> OnFlush;

            [NativeTypeName("HRESULT (DWORD, IMFMediaEvent *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceReaderCallback2*, uint, IMFMediaEvent*, int> OnEvent;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceReaderCallback2*, int> OnTransformChange;

            [NativeTypeName("HRESULT (DWORD, HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSourceReaderCallback2*, uint, HRESULT, int> OnStreamError;
        }
    }
}
