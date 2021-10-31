// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("76E54780-AD74-48E3-A695-3BA9A0AFF10D")]
    [NativeTypeName("struct IPreviousVersionsInfo : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPreviousVersionsInfo
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPreviousVersionsInfo*, Guid*, void**, int>)(lpVtbl[0]))((IPreviousVersionsInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPreviousVersionsInfo*, uint>)(lpVtbl[1]))((IPreviousVersionsInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPreviousVersionsInfo*, uint>)(lpVtbl[2]))((IPreviousVersionsInfo*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int AreSnapshotsAvailable([NativeTypeName("LPCWSTR")] ushort* pszPath, BOOL fOkToBeSlow, BOOL* pfAvailable)
        {
            return ((delegate* unmanaged<IPreviousVersionsInfo*, ushort*, BOOL, BOOL*, int>)(lpVtbl[3]))((IPreviousVersionsInfo*)Unsafe.AsPointer(ref this), pszPath, fOkToBeSlow, pfAvailable);
        }
    }
}
