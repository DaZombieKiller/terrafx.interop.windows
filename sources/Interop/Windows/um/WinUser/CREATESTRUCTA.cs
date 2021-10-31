// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CREATESTRUCTA
    {
        [NativeTypeName("LPVOID")]
        public void* lpCreateParams;

        public HINSTANCE hInstance;

        public HMENU hMenu;

        public HWND hwndParent;

        public int cy;

        public int cx;

        public int y;

        public int x;

        [NativeTypeName("LONG")]
        public int style;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszName;

        [NativeTypeName("LPCSTR")]
        public sbyte* lpszClass;

        [NativeTypeName("DWORD")]
        public uint dwExStyle;
    }
}
