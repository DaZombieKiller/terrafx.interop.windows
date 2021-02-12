// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct IMAGE_THUNK_DATA64
    {
        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:18201:5)")]
        public _u1_e__Union u1;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _u1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong ForwarderString;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Function;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Ordinal;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong AddressOfData;
        }
    }
}
