// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8222C490-507B-4BEF-B3BD-41DCA7B5934C")]
    [NativeTypeName("struct IDiaStackWalkHelper2 : IDiaStackWalkHelper")]
    [NativeInheritance("IDiaStackWalkHelper")]
    public unsafe partial struct IDiaStackWalkHelper2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, Guid*, void**, int>)(lpVtbl[0]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, uint>)(lpVtbl[1]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, uint>)(lpVtbl[2]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int get_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG *")] ulong* pRetVal)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, uint, ulong*, int>)(lpVtbl[3]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), index, pRetVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int put_registerValue([NativeTypeName("DWORD")] uint index, [NativeTypeName("ULONGLONG")] ulong NewVal)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, uint, ulong, int>)(lpVtbl[4]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), index, NewVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int readMemory([NativeTypeName("enum MemoryTypeEnum")] MemoryTypeEnum type, [NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pbData)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, MemoryTypeEnum, ulong, uint, uint*, byte*, int>)(lpVtbl[5]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), type, va, cbData, pcbData, pbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int searchForReturnAddress(IDiaFrameData* frame, [NativeTypeName("ULONGLONG *")] ulong* returnAddress)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, IDiaFrameData*, ulong*, int>)(lpVtbl[6]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), frame, returnAddress);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int searchForReturnAddressStart(IDiaFrameData* frame, [NativeTypeName("ULONGLONG")] ulong startAddress, [NativeTypeName("ULONGLONG *")] ulong* returnAddress)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, IDiaFrameData*, ulong, ulong*, int>)(lpVtbl[7]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), frame, startAddress, returnAddress);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int frameForVA([NativeTypeName("ULONGLONG")] ulong va, IDiaFrameData** ppFrame)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, IDiaFrameData**, int>)(lpVtbl[8]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), va, ppFrame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int symbolForVA([NativeTypeName("ULONGLONG")] ulong va, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, IDiaSymbol**, int>)(lpVtbl[9]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), va, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int pdataForVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, [NativeTypeName("BYTE *")] byte* pbData)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, uint, uint*, byte*, int>)(lpVtbl[10]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), va, cbData, pcbData, pbData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int imageForVA([NativeTypeName("ULONGLONG")] ulong vaContext, [NativeTypeName("ULONGLONG *")] ulong* pvaImageStart)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, ulong*, int>)(lpVtbl[11]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), vaContext, pvaImageStart);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int addressForVA([NativeTypeName("ULONGLONG")] ulong va, [NativeTypeName("DWORD *")] uint* pISect, [NativeTypeName("DWORD *")] uint* pOffset)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, uint*, uint*, int>)(lpVtbl[12]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), va, pISect, pOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int numberOfFunctionFragmentsForVA([NativeTypeName("ULONGLONG")] ulong vaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD *")] uint* pNumFragments)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, uint, uint*, int>)(lpVtbl[13]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), vaFunc, cbFunc, pNumFragments);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int functionFragmentsForVA([NativeTypeName("ULONGLONG")] ulong vaFunc, [NativeTypeName("DWORD")] uint cbFunc, [NativeTypeName("DWORD")] uint cFragments, [NativeTypeName("ULONGLONG *")] ulong* pVaFragment, [NativeTypeName("DWORD *")] uint* pLenFragment)
        {
            return ((delegate* unmanaged<IDiaStackWalkHelper2*, ulong, uint, uint, ulong*, uint*, int>)(lpVtbl[14]))((IDiaStackWalkHelper2*)Unsafe.AsPointer(ref this), vaFunc, cbFunc, cFragments, pVaFragment, pLenFragment);
        }
    }
}
