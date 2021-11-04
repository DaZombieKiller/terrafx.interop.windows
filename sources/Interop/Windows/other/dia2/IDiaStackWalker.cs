// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5485216B-A54C-469F-9670-52B24D5229BB")]
    [NativeTypeName("struct IDiaStackWalker : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiaStackWalker : IDiaStackWalker.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiaStackWalker*, Guid*, void**, int>)(lpVtbl[0]))((IDiaStackWalker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiaStackWalker*, uint>)(lpVtbl[1]))((IDiaStackWalker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiaStackWalker*, uint>)(lpVtbl[2]))((IDiaStackWalker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT getEnumFrames(IDiaStackWalkHelper* pHelper, IDiaEnumStackFrames** ppEnum)
        {
            return ((delegate* unmanaged<IDiaStackWalker*, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int>)(lpVtbl[3]))((IDiaStackWalker*)Unsafe.AsPointer(ref this), pHelper, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT getEnumFrames2([NativeTypeName("enum CV_CPU_TYPE_e")] CV_CPU_TYPE_e cpuid, IDiaStackWalkHelper* pHelper, IDiaEnumStackFrames** ppEnum)
        {
            return ((delegate* unmanaged<IDiaStackWalker*, CV_CPU_TYPE_e, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int>)(lpVtbl[4]))((IDiaStackWalker*)Unsafe.AsPointer(ref this), cpuid, pHelper, ppEnum);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT getEnumFrames(IDiaStackWalkHelper* pHelper, IDiaEnumStackFrames** ppEnum);

            [VtblIndex(4)]
            HRESULT getEnumFrames2([NativeTypeName("enum CV_CPU_TYPE_e")] CV_CPU_TYPE_e cpuid, IDiaStackWalkHelper* pHelper, IDiaEnumStackFrames** ppEnum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker*, uint> Release;

            [NativeTypeName("HRESULT (IDiaStackWalkHelper *, IDiaEnumStackFrames **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker*, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int> getEnumFrames;

            [NativeTypeName("HRESULT (enum CV_CPU_TYPE_e, IDiaStackWalkHelper *, IDiaEnumStackFrames **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDiaStackWalker*, CV_CPU_TYPE_e, IDiaStackWalkHelper*, IDiaEnumStackFrames**, int> getEnumFrames2;
        }
    }
}
