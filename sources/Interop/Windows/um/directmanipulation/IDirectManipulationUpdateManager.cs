// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B0AE62FD-BE34-46E7-9CAA-D361FACBB9CC")]
    [NativeTypeName("struct IDirectManipulationUpdateManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectManipulationUpdateManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationUpdateManager*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationUpdateManager*, uint>)(lpVtbl[1]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationUpdateManager*, uint>)(lpVtbl[2]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterWaitHandleCallback(HANDLE handle, IDirectManipulationUpdateHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
        {
            return ((delegate* unmanaged<IDirectManipulationUpdateManager*, HANDLE, IDirectManipulationUpdateHandler*, uint*, int>)(lpVtbl[3]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), handle, eventHandler, cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnregisterWaitHandleCallback([NativeTypeName("DWORD")] uint cookie)
        {
            return ((delegate* unmanaged<IDirectManipulationUpdateManager*, uint, int>)(lpVtbl[4]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), cookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Update(IDirectManipulationFrameInfoProvider* frameInfo)
        {
            return ((delegate* unmanaged<IDirectManipulationUpdateManager*, IDirectManipulationFrameInfoProvider*, int>)(lpVtbl[5]))((IDirectManipulationUpdateManager*)Unsafe.AsPointer(ref this), frameInfo);
        }
    }
}
