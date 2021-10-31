// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_4.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("94D99BDB-F1F8-4AB0-B236-7DA0170EDAB1")]
    [NativeTypeName("struct IDXGISwapChain3 : IDXGISwapChain2")]
    [NativeInheritance("IDXGISwapChain2")]
    public unsafe partial struct IDXGISwapChain3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, Guid*, void**, int>)(lpVtbl[0]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint>)(lpVtbl[1]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint>)(lpVtbl[2]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, Guid*, uint, void*, int>)(lpVtbl[3]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, Guid*, IUnknown*, int>)(lpVtbl[4]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, void* pData)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, Guid*, uint*, void*, int>)(lpVtbl[5]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetParent([NativeTypeName("const IID &")] Guid* riid, void** ppParent)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, Guid*, void**, int>)(lpVtbl[6]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppDevice)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, Guid*, void**, int>)(lpVtbl[7]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), riid, ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Present([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint Flags)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint, uint, int>)(lpVtbl[8]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), SyncInterval, Flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetBuffer([NativeTypeName("UINT")] uint Buffer, [NativeTypeName("const IID &")] Guid* riid, void** ppSurface)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint, Guid*, void**, int>)(lpVtbl[9]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Buffer, riid, ppSurface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetFullscreenState(BOOL Fullscreen, IDXGIOutput* pTarget)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, BOOL, IDXGIOutput*, int>)(lpVtbl[10]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Fullscreen, pTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetFullscreenState(BOOL* pFullscreen, IDXGIOutput** ppTarget)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, BOOL*, IDXGIOutput**, int>)(lpVtbl[11]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pFullscreen, ppTarget);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetDesc(DXGI_SWAP_CHAIN_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_SWAP_CHAIN_DESC*, int>)(lpVtbl[12]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT ResizeBuffers([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT NewFormat, [NativeTypeName("UINT")] uint SwapChainFlags)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint, uint, uint, DXGI_FORMAT, uint, int>)(lpVtbl[13]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, NewFormat, SwapChainFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT ResizeTarget([NativeTypeName("const DXGI_MODE_DESC *")] DXGI_MODE_DESC* pNewTargetParameters)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_MODE_DESC*, int>)(lpVtbl[14]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pNewTargetParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetContainingOutput(IDXGIOutput** ppOutput)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, IDXGIOutput**, int>)(lpVtbl[15]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), ppOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetFrameStatistics(DXGI_FRAME_STATISTICS* pStats)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_FRAME_STATISTICS*, int>)(lpVtbl[16]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pStats);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT GetLastPresentCount([NativeTypeName("UINT *")] uint* pLastPresentCount)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint*, int>)(lpVtbl[17]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pLastPresentCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetDesc1(DXGI_SWAP_CHAIN_DESC1* pDesc)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_SWAP_CHAIN_DESC1*, int>)(lpVtbl[18]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetFullscreenDesc(DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pDesc)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_SWAP_CHAIN_FULLSCREEN_DESC*, int>)(lpVtbl[19]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetHwnd(HWND* pHwnd)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, HWND*, int>)(lpVtbl[20]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pHwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetCoreWindow([NativeTypeName("const IID &")] Guid* refiid, void** ppUnk)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, Guid*, void**, int>)(lpVtbl[21]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), refiid, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT Present1([NativeTypeName("UINT")] uint SyncInterval, [NativeTypeName("UINT")] uint PresentFlags, [NativeTypeName("const DXGI_PRESENT_PARAMETERS *")] DXGI_PRESENT_PARAMETERS* pPresentParameters)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint, uint, DXGI_PRESENT_PARAMETERS*, int>)(lpVtbl[22]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), SyncInterval, PresentFlags, pPresentParameters);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public BOOL IsTemporaryMonoSupported()
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, int>)(lpVtbl[23]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT GetRestrictToOutput(IDXGIOutput** ppRestrictToOutput)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, IDXGIOutput**, int>)(lpVtbl[24]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), ppRestrictToOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT SetBackgroundColor([NativeTypeName("const DXGI_RGBA *")] DXGI_RGBA* pColor)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_RGBA*, int>)(lpVtbl[25]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT GetBackgroundColor(DXGI_RGBA* pColor)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_RGBA*, int>)(lpVtbl[26]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pColor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetRotation(DXGI_MODE_ROTATION Rotation)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_MODE_ROTATION, int>)(lpVtbl[27]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetRotation(DXGI_MODE_ROTATION* pRotation)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_MODE_ROTATION*, int>)(lpVtbl[28]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pRotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SetSourceSize([NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint, uint, int>)(lpVtbl[29]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), Width, Height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetSourceSize([NativeTypeName("UINT *")] uint* pWidth, [NativeTypeName("UINT *")] uint* pHeight)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint*, uint*, int>)(lpVtbl[30]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pWidth, pHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT SetMaximumFrameLatency([NativeTypeName("UINT")] uint MaxLatency)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint, int>)(lpVtbl[31]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), MaxLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT GetMaximumFrameLatency([NativeTypeName("UINT *")] uint* pMaxLatency)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint*, int>)(lpVtbl[32]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pMaxLatency);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HANDLE GetFrameLatencyWaitableObject()
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, nint>)(lpVtbl[33]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT SetMatrixTransform([NativeTypeName("const DXGI_MATRIX_3X2_F *")] DXGI_MATRIX_3X2_F* pMatrix)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_MATRIX_3X2_F*, int>)(lpVtbl[34]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT GetMatrixTransform(DXGI_MATRIX_3X2_F* pMatrix)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_MATRIX_3X2_F*, int>)(lpVtbl[35]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), pMatrix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("UINT")]
        public uint GetCurrentBackBufferIndex()
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint>)(lpVtbl[36]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT CheckColorSpaceSupport(DXGI_COLOR_SPACE_TYPE ColorSpace, [NativeTypeName("UINT *")] uint* pColorSpaceSupport)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_COLOR_SPACE_TYPE, uint*, int>)(lpVtbl[37]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), ColorSpace, pColorSpaceSupport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT SetColorSpace1(DXGI_COLOR_SPACE_TYPE ColorSpace)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, DXGI_COLOR_SPACE_TYPE, int>)(lpVtbl[38]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), ColorSpace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT ResizeBuffers1([NativeTypeName("UINT")] uint BufferCount, [NativeTypeName("UINT")] uint Width, [NativeTypeName("UINT")] uint Height, DXGI_FORMAT Format, [NativeTypeName("UINT")] uint SwapChainFlags, [NativeTypeName("const UINT *")] uint* pCreationNodeMask, [NativeTypeName("IUnknown *const *")] IUnknown** ppPresentQueue)
        {
            return ((delegate* unmanaged<IDXGISwapChain3*, uint, uint, uint, DXGI_FORMAT, uint, uint*, IUnknown**, int>)(lpVtbl[39]))((IDXGISwapChain3*)Unsafe.AsPointer(ref this), BufferCount, Width, Height, Format, SwapChainFlags, pCreationNodeMask, ppPresentQueue);
        }
    }
}
