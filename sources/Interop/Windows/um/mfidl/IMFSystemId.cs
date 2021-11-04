// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FFF4AF3A-1FC1-4EF9-A29B-D26C49E2F31A")]
    [NativeTypeName("struct IMFSystemId : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSystemId : IMFSystemId.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSystemId*, Guid*, void**, int>)(lpVtbl[0]))((IMFSystemId*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSystemId*, uint>)(lpVtbl[1]))((IMFSystemId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSystemId*, uint>)(lpVtbl[2]))((IMFSystemId*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetData([NativeTypeName("UINT32 *")] uint* size, byte** data)
        {
            return ((delegate* unmanaged<IMFSystemId*, uint*, byte**, int>)(lpVtbl[3]))((IMFSystemId*)Unsafe.AsPointer(ref this), size, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Setup([NativeTypeName("UINT32")] uint stage, [NativeTypeName("UINT32")] uint cbIn, [NativeTypeName("const BYTE *")] byte* pbIn, [NativeTypeName("UINT32 *")] uint* pcbOut, byte** ppbOut)
        {
            return ((delegate* unmanaged<IMFSystemId*, uint, uint, byte*, uint*, byte**, int>)(lpVtbl[4]))((IMFSystemId*)Unsafe.AsPointer(ref this), stage, cbIn, pbIn, pcbOut, ppbOut);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetData([NativeTypeName("UINT32 *")] uint* size, byte** data);

            [VtblIndex(4)]
            HRESULT Setup([NativeTypeName("UINT32")] uint stage, [NativeTypeName("UINT32")] uint cbIn, [NativeTypeName("const BYTE *")] byte* pbIn, [NativeTypeName("UINT32 *")] uint* pcbOut, byte** ppbOut);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSystemId*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSystemId*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSystemId*, uint> Release;

            [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSystemId*, uint*, byte**, int> GetData;

            [NativeTypeName("HRESULT (UINT32, UINT32, const BYTE *, UINT32 *, BYTE **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFSystemId*, uint, uint, byte*, uint*, byte**, int> Setup;
        }
    }
}
