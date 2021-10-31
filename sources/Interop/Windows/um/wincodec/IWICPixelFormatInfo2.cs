// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4")]
    [NativeTypeName("struct IWICPixelFormatInfo2 : IWICPixelFormatInfo")]
    [NativeInheritance("IWICPixelFormatInfo")]
    public unsafe partial struct IWICPixelFormatInfo2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, Guid*, void**, int>)(lpVtbl[0]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint>)(lpVtbl[1]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint>)(lpVtbl[2]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetComponentType(WICComponentType* pType)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, WICComponentType*, int>)(lpVtbl[3]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[4]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[5]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetAuthor([NativeTypeName("UINT")] uint cchAuthor, [NativeTypeName("WCHAR *")] ushort* wzAuthor, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[6]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetVendorGUID([NativeTypeName("GUID *")] Guid* pguidVendor)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[7]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pguidVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetVersion([NativeTypeName("UINT")] uint cchVersion, [NativeTypeName("WCHAR *")] ushort* wzVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[8]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetSpecVersion([NativeTypeName("UINT")] uint cchSpecVersion, [NativeTypeName("WCHAR *")] ushort* wzSpecVersion, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[9]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetFriendlyName([NativeTypeName("UINT")] uint cchFriendlyName, [NativeTypeName("WCHAR *")] ushort* wzFriendlyName, [NativeTypeName("UINT *")] uint* pcchActual)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint, ushort*, uint*, int>)(lpVtbl[10]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetFormatGUID([NativeTypeName("GUID *")] Guid* pFormat)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, Guid*, int>)(lpVtbl[11]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetColorContext(IWICColorContext** ppIColorContext)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, IWICColorContext**, int>)(lpVtbl[12]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), ppIColorContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitsPerPixel([NativeTypeName("UINT *")] uint* puiBitsPerPixel)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[13]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), puiBitsPerPixel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelCount([NativeTypeName("UINT *")] uint* puiChannelCount)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint*, int>)(lpVtbl[14]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), puiChannelCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetChannelMask([NativeTypeName("UINT")] uint uiChannelIndex, [NativeTypeName("UINT")] uint cbMaskBuffer, [NativeTypeName("BYTE *")] byte* pbMaskBuffer, [NativeTypeName("UINT *")] uint* pcbActual)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, uint, uint, byte*, uint*, int>)(lpVtbl[15]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), uiChannelIndex, cbMaskBuffer, pbMaskBuffer, pcbActual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int SupportsTransparency(BOOL* pfSupportsTransparency)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, BOOL*, int>)(lpVtbl[16]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pfSupportsTransparency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetNumericRepresentation(WICPixelFormatNumericRepresentation* pNumericRepresentation)
        {
            return ((delegate* unmanaged<IWICPixelFormatInfo2*, WICPixelFormatNumericRepresentation*, int>)(lpVtbl[17]))((IWICPixelFormatInfo2*)Unsafe.AsPointer(ref this), pNumericRepresentation);
        }
    }
}
