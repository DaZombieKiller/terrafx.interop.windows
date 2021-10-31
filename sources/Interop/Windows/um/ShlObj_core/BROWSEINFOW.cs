// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct BROWSEINFOW
    {
        public HWND hwndOwner;

        [NativeTypeName("LPCITEMIDLIST")]
        public ITEMIDLIST* pidlRoot;

        [NativeTypeName("LPWSTR")]
        public ushort* pszDisplayName;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszTitle;

        [NativeTypeName("UINT")]
        public uint ulFlags;

        [NativeTypeName("BFFCALLBACK")]
        public delegate* unmanaged<HWND, uint, nint, nint, int> lpfn;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        public int iImage;
    }
}
