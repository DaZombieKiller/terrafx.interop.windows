// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct NOTIFYICONIDENTIFIER64
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public HWND hWnd;

        [NativeTypeName("UINT")]
        public uint uID;

        [NativeTypeName("GUID")]
        public Guid guidItem;
    }
}
