// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6295DF40-35EE-11D1-8707-00C04FD93327")]
    [NativeTypeName("struct ISyncMgrSynchronize : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISyncMgrSynchronize
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, uint>)(lpVtbl[1]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, uint>)(lpVtbl[2]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Initialize([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint dwSyncMgrFlags, [NativeTypeName("DWORD")] uint cbCookie, [NativeTypeName("const BYTE *")] byte* lpCookie)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, uint, uint, uint, byte*, int>)(lpVtbl[3]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), dwReserved, dwSyncMgrFlags, cbCookie, lpCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetHandlerInfo(SYNCMGRHANDLERINFO** ppSyncMgrHandlerInfo)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, SYNCMGRHANDLERINFO**, int>)(lpVtbl[4]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), ppSyncMgrHandlerInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EnumSyncMgrItems(ISyncMgrEnumItems** ppSyncMgrEnumItems)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, ISyncMgrEnumItems**, int>)(lpVtbl[5]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), ppSyncMgrEnumItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetItemObject([NativeTypeName("const GUID &")] Guid* ItemID, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, Guid*, Guid*, void**, int>)(lpVtbl[6]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), ItemID, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT ShowProperties(HWND hWndParent, [NativeTypeName("const GUID &")] Guid* ItemID)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, HWND, Guid*, int>)(lpVtbl[7]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), hWndParent, ItemID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetProgressCallback(ISyncMgrSynchronizeCallback* lpCallBack)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, ISyncMgrSynchronizeCallback*, int>)(lpVtbl[8]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), lpCallBack);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT PrepareForSync([NativeTypeName("ULONG")] uint cbNumItems, [NativeTypeName("GUID *")] Guid* pItemIDs, HWND hWndParent, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, uint, Guid*, HWND, uint, int>)(lpVtbl[9]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), cbNumItems, pItemIDs, hWndParent, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Synchronize(HWND hWndParent)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, HWND, int>)(lpVtbl[10]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), hWndParent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetItemStatus([NativeTypeName("const GUID &")] Guid* pItemID, [NativeTypeName("DWORD")] uint dwSyncMgrStatus)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, Guid*, uint, int>)(lpVtbl[11]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), pItemID, dwSyncMgrStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT ShowError(HWND hWndParent, [NativeTypeName("const GUID &")] Guid* ErrorID)
        {
            return ((delegate* unmanaged<ISyncMgrSynchronize*, HWND, Guid*, int>)(lpVtbl[12]))((ISyncMgrSynchronize*)Unsafe.AsPointer(ref this), hWndParent, ErrorID);
        }
    }
}
