// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("407FB1DE-F85A-4150-97CF-B7FB274FB4F8")]
    [NativeTypeName("struct IInkD2DRenderer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInkD2DRenderer : IInkD2DRenderer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInkD2DRenderer*, Guid*, void**, int>)(lpVtbl[0]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInkD2DRenderer*, uint>)(lpVtbl[1]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInkD2DRenderer*, uint>)(lpVtbl[2]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Draw(IUnknown* pD2D1DeviceContext, IUnknown* pInkStrokeIterable, BOOL fHighContrast)
        {
            return ((delegate* unmanaged<IInkD2DRenderer*, IUnknown*, IUnknown*, BOOL, int>)(lpVtbl[3]))((IInkD2DRenderer*)Unsafe.AsPointer(ref this), pD2D1DeviceContext, pInkStrokeIterable, fHighContrast);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Draw(IUnknown* pD2D1DeviceContext, IUnknown* pInkStrokeIterable, BOOL fHighContrast);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IInkD2DRenderer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInkD2DRenderer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IInkD2DRenderer*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, IUnknown *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IInkD2DRenderer*, IUnknown*, IUnknown*, BOOL, int> Draw;
        }
    }
}
