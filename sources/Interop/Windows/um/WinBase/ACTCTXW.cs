// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ACTCTXW
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpSource;

        [NativeTypeName("USHORT")]
        public ushort wProcessorArchitecture;

        [NativeTypeName("LANGID")]
        public ushort wLangId;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpAssemblyDirectory;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpResourceName;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpApplicationName;

        [NativeTypeName("HMODULE")]
        public HINSTANCE hModule;
    }
}
