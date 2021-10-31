// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7D5ABF16-4CBB-4E08-B977-9BA59049943E")]
    [NativeTypeName("struct IMFContentDecryptionModuleFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFContentDecryptionModuleFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, uint>)(lpVtbl[1]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, uint>)(lpVtbl[2]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public BOOL IsTypeSupported([NativeTypeName("LPCWSTR")] ushort* keySystem, [NativeTypeName("LPCWSTR")] ushort* contentType)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, ushort*, ushort*, int>)(lpVtbl[3]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this), keySystem, contentType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContentDecryptionModuleAccess([NativeTypeName("LPCWSTR")] ushort* keySystem, IPropertyStore** configurations, [NativeTypeName("DWORD")] uint numConfigurations, IMFContentDecryptionModuleAccess** contentDecryptionModuleAccess)
        {
            return ((delegate* unmanaged<IMFContentDecryptionModuleFactory*, ushort*, IPropertyStore**, uint, IMFContentDecryptionModuleAccess**, int>)(lpVtbl[4]))((IMFContentDecryptionModuleFactory*)Unsafe.AsPointer(ref this), keySystem, configurations, numConfigurations, contentDecryptionModuleAccess);
        }
    }
}
