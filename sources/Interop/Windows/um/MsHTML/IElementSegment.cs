// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F68F-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementSegment : ISegment")]
    [NativeInheritance("ISegment")]
    public unsafe partial struct IElementSegment
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementSegment*, Guid*, void**, int>)(lpVtbl[0]))((IElementSegment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementSegment*, uint>)(lpVtbl[1]))((IElementSegment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementSegment*, uint>)(lpVtbl[2]))((IElementSegment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPointers(IMarkupPointer* pIStart, IMarkupPointer* pIEnd)
        {
            return ((delegate* unmanaged<IElementSegment*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[3]))((IElementSegment*)Unsafe.AsPointer(ref this), pIStart, pIEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetElement(IHTMLElement** ppIElement)
        {
            return ((delegate* unmanaged<IElementSegment*, IHTMLElement**, int>)(lpVtbl[4]))((IElementSegment*)Unsafe.AsPointer(ref this), ppIElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetPrimary(BOOL fPrimary)
        {
            return ((delegate* unmanaged<IElementSegment*, BOOL, int>)(lpVtbl[5]))((IElementSegment*)Unsafe.AsPointer(ref this), fPrimary);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int IsPrimary(BOOL* pfPrimary)
        {
            return ((delegate* unmanaged<IElementSegment*, BOOL*, int>)(lpVtbl[6]))((IElementSegment*)Unsafe.AsPointer(ref this), pfPrimary);
        }
    }
}
