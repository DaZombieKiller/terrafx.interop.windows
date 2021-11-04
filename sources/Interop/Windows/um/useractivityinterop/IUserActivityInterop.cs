// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/useractivityinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1ADE314D-0E0A-40D9-824C-9A088A50059F")]
    [NativeTypeName("struct IUserActivityInterop : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IUserActivityInterop : IUserActivityInterop.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUserActivityInterop*, Guid*, void**, int>)(lpVtbl[0]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUserActivityInterop*, uint>)(lpVtbl[1]))((IUserActivityInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUserActivityInterop*, uint>)(lpVtbl[2]))((IUserActivityInterop*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUserActivityInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<IUserActivityInterop*, HSTRING*, int>)(lpVtbl[4]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUserActivityInterop*, TrustLevel*, int>)(lpVtbl[5]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateSessionForWindow(HWND window, [NativeTypeName("const IID &")] Guid* iid, void** value)
        {
            return ((delegate* unmanaged<IUserActivityInterop*, HWND, Guid*, void**, int>)(lpVtbl[6]))((IUserActivityInterop*)Unsafe.AsPointer(ref this), window, iid, value);
        }

        public interface Interface : IInspectable.Interface
        {
            [VtblIndex(6)]
            HRESULT CreateSessionForWindow(HWND window, [NativeTypeName("const IID &")] Guid* iid, void** value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserActivityInterop*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUserActivityInterop*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IUserActivityInterop*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserActivityInterop*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserActivityInterop*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserActivityInterop*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IUserActivityInterop*, HWND, Guid*, void**, int> CreateSessionForWindow;
        }
    }
}
