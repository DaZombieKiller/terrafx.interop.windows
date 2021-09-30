// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct NMTBDISPINFOA
    {
        public NMHDR hdr;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        public int idCommand;

        [NativeTypeName("DWORD_PTR")]
        public nuint lParam;

        public int iImage;

        [NativeTypeName("LPSTR")]
        public sbyte* pszText;

        public int cchText;
    }
}
