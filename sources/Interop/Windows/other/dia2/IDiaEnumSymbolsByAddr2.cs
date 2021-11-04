// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1E45BD02-BE45-4D71-BA32-0E576CFCD59F")]
    [NativeTypeName("struct IDiaEnumSymbolsByAddr2 : IDiaEnumSymbolsByAddr")]
    [NativeInheritance("IDiaEnumSymbolsByAddr")]
    public unsafe partial struct IDiaEnumSymbolsByAddr2 : IDiaEnumSymbolsByAddr2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, Guid*, void**, int>)(lpVtbl[0]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint>)(lpVtbl[1]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint>)(lpVtbl[2]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT symbolByAddr([NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint, uint, IDiaSymbol**, int>)(lpVtbl[3]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), isect, offset, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT symbolByRVA([NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint, IDiaSymbol**, int>)(lpVtbl[4]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), relativeVirtualAddress, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT symbolByVA([NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, ulong, IDiaSymbol**, int>)(lpVtbl[5]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), virtualAddress, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint, IDiaSymbol**, uint*, int>)(lpVtbl[6]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Prev([NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint, IDiaSymbol**, uint*, int>)(lpVtbl[7]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Clone(IDiaEnumSymbolsByAddr** ppenum)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, IDiaEnumSymbolsByAddr**, int>)(lpVtbl[8]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT symbolByAddrEx(BOOL fPromoteBlockSym, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, uint, uint, IDiaSymbol**, int>)(lpVtbl[9]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), fPromoteBlockSym, isect, offset, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT symbolByRVAEx(BOOL fPromoteBlockSym, [NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, uint, IDiaSymbol**, int>)(lpVtbl[10]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), fPromoteBlockSym, relativeVirtualAddress, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT symbolByVAEx(BOOL fPromoteBlockSym, [NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaSymbol** ppSymbol)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, ulong, IDiaSymbol**, int>)(lpVtbl[11]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), fPromoteBlockSym, virtualAddress, ppSymbol);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT NextEx(BOOL fPromoteBlockSym, [NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, uint, IDiaSymbol**, uint*, int>)(lpVtbl[12]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), fPromoteBlockSym, celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT PrevEx(BOOL fPromoteBlockSym, [NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, uint, IDiaSymbol**, uint*, int>)(lpVtbl[13]))((IDiaEnumSymbolsByAddr2*)Unsafe.AsPointer(ref this), fPromoteBlockSym, celt, rgelt, pceltFetched);
        }

        public interface Interface : IDiaEnumSymbolsByAddr.Interface
        {
            [VtblIndex(9)]
            HRESULT symbolByAddrEx(BOOL fPromoteBlockSym, [NativeTypeName("DWORD")] uint isect, [NativeTypeName("DWORD")] uint offset, IDiaSymbol** ppSymbol);

            [VtblIndex(10)]
            HRESULT symbolByRVAEx(BOOL fPromoteBlockSym, [NativeTypeName("DWORD")] uint relativeVirtualAddress, IDiaSymbol** ppSymbol);

            [VtblIndex(11)]
            HRESULT symbolByVAEx(BOOL fPromoteBlockSym, [NativeTypeName("ULONGLONG")] ulong virtualAddress, IDiaSymbol** ppSymbol);

            [VtblIndex(12)]
            HRESULT NextEx(BOOL fPromoteBlockSym, [NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

            [VtblIndex(13)]
            HRESULT PrevEx(BOOL fPromoteBlockSym, [NativeTypeName("ULONG")] uint celt, IDiaSymbol** rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, DWORD, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint, uint, IDiaSymbol**, int> symbolByAddr;

            [NativeTypeName("HRESULT (DWORD, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint, IDiaSymbol**, int> symbolByRVA;

            [NativeTypeName("HRESULT (ULONGLONG, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, ulong, IDiaSymbol**, int> symbolByVA;

            [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint, IDiaSymbol**, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, uint, IDiaSymbol**, uint*, int> Prev;

            [NativeTypeName("HRESULT (IDiaEnumSymbolsByAddr **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, IDiaEnumSymbolsByAddr**, int> Clone;

            [NativeTypeName("HRESULT (BOOL, DWORD, DWORD, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, uint, uint, IDiaSymbol**, int> symbolByAddrEx;

            [NativeTypeName("HRESULT (BOOL, DWORD, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, uint, IDiaSymbol**, int> symbolByRVAEx;

            [NativeTypeName("HRESULT (BOOL, ULONGLONG, IDiaSymbol **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, ulong, IDiaSymbol**, int> symbolByVAEx;

            [NativeTypeName("HRESULT (BOOL, ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, uint, IDiaSymbol**, uint*, int> NextEx;

            [NativeTypeName("HRESULT (BOOL, ULONG, IDiaSymbol **, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaEnumSymbolsByAddr2*, BOOL, uint, IDiaSymbol**, uint*, int> PrevEx;
        }
    }
}
