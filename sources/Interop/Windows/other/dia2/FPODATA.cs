// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

namespace TerraFX.Interop
{
    public partial struct FPODATA
    {
        [NativeTypeName("DWORD")]
        public uint ulOffStart;

        [NativeTypeName("DWORD")]
        public uint cbProcSize;

        [NativeTypeName("DWORD")]
        public uint cdwLocals;

        [NativeTypeName("WORD")]
        public ushort cdwParams;

        [NativeTypeName("WORD")]
        public ushort cdwFlags;
    }
}
