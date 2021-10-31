// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("85FAD185-58CE-497A-9460-355366B64B9A")]
    [NativeTypeName("struct ITfCandidateListUIElementBehavior : ITfCandidateListUIElement")]
    [NativeInheritance("ITfCandidateListUIElement")]
    public unsafe partial struct ITfCandidateListUIElementBehavior
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, Guid*, void**, int>)(lpVtbl[0]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint>)(lpVtbl[1]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint>)(lpVtbl[2]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, ushort**, int>)(lpVtbl[3]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pbstrDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetGUID([NativeTypeName("GUID *")] Guid* pguid)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, Guid*, int>)(lpVtbl[4]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Show(BOOL bShow)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, BOOL, int>)(lpVtbl[5]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), bShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int IsShown(BOOL* pbShow)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, BOOL*, int>)(lpVtbl[6]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pbShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, int>)(lpVtbl[7]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetDocumentMgr(ITfDocumentMgr** ppdim)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, ITfDocumentMgr**, int>)(lpVtbl[8]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), ppdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* puCount)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, int>)(lpVtbl[9]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), puCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelection([NativeTypeName("UINT *")] uint* puIndex)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, int>)(lpVtbl[10]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), puIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetString([NativeTypeName("UINT")] uint uIndex, [NativeTypeName("BSTR *")] ushort** pstr)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint, ushort**, int>)(lpVtbl[11]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), uIndex, pstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetPageIndex([NativeTypeName("UINT *")] uint* pIndex, [NativeTypeName("UINT")] uint uSize, [NativeTypeName("UINT *")] uint* puPageCnt)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, uint, uint*, int>)(lpVtbl[12]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pIndex, uSize, puPageCnt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int SetPageIndex([NativeTypeName("UINT *")] uint* pIndex, [NativeTypeName("UINT")] uint uPageCnt)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, uint, int>)(lpVtbl[13]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), pIndex, uPageCnt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentPage([NativeTypeName("UINT *")] uint* puPage)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint*, int>)(lpVtbl[14]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), puPage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetSelection([NativeTypeName("UINT")] uint nIndex)
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, uint, int>)(lpVtbl[15]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this), nIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int Finalize()
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, int>)(lpVtbl[16]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int Abort()
        {
            return ((delegate* unmanaged<ITfCandidateListUIElementBehavior*, int>)(lpVtbl[17]))((ITfCandidateListUIElementBehavior*)Unsafe.AsPointer(ref this));
        }
    }
}
