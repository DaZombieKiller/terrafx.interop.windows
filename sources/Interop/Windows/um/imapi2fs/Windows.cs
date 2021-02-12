// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define IMAPI2FS_BOOT_ENTRY_COUNT_MAX 32")]
        public const int IMAPI2FS_BOOT_ENTRY_COUNT_MAX = 32;

        [NativeTypeName("#define DISPID_DFILESYSTEMIMAGEEVENTS_UPDATE 0x100")]
        public const int DISPID_DFILESYSTEMIMAGEEVENTS_UPDATE = 0x100;

        [NativeTypeName("#define DISPID_DFILESYSTEMIMAGEIMPORTEVENTS_UPDATEIMPORT 0x101")]
        public const int DISPID_DFILESYSTEMIMAGEIMPORTEVENTS_UPDATEIMPORT = 0x101;

        [NativeTypeName("#define IMAPI2FS_MajorVersion 1")]
        public const int IMAPI2FS_MajorVersion = 1;

        [NativeTypeName("#define IMAPI2FS_MinorVersion 0")]
        public const int IMAPI2FS_MinorVersion = 0;

        [NativeTypeName("#define IMAPI2FS_FullVersion_STR \"1.0\"")]
        public static ReadOnlySpan<byte> IMAPI2FS_FullVersion_STR => new byte[] { 0x31, 0x2E, 0x30, 0x00 };

        [NativeTypeName("#define IMAPI2FS_FullVersion_WSTR L\"1.0\"")]
        public const string IMAPI2FS_FullVersion_WSTR = "1.0";

        public static readonly Guid IID_IBootOptions = new Guid(0x2C941FD4, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IProgressItem = new Guid(0x2C941FD5, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IEnumProgressItems = new Guid(0x2C941FD6, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IProgressItems = new Guid(0x2C941FD7, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IFileSystemImageResult = new Guid(0x2C941FD8, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IFileSystemImageResult2 = new Guid(0xB507CA29, 0x2204, 0x11DD, 0x96, 0x6A, 0x00, 0x1A, 0xA0, 0x1B, 0xBC, 0x58);

        public static readonly Guid IID_IFsiItem = new Guid(0x2C941FD9, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IEnumFsiItems = new Guid(0x2C941FDA, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IFsiFileItem = new Guid(0x2C941FDB, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IFsiFileItem2 = new Guid(0x199D0C19, 0x11E1, 0x40EB, 0x8E, 0xC2, 0xC8, 0xC8, 0x22, 0xA0, 0x77, 0x92);

        public static readonly Guid IID_IFsiNamedStreams = new Guid(0xED79BA56, 0x5294, 0x4250, 0x8D, 0x46, 0xF9, 0xAE, 0xCE, 0xE2, 0x34, 0x59);

        public static readonly Guid IID_IFsiDirectoryItem = new Guid(0x2C941FDC, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IFsiDirectoryItem2 = new Guid(0xF7FB4B9B, 0x6D96, 0x4D7B, 0x91, 0x15, 0x20, 0x1B, 0x14, 0x48, 0x11, 0xEF);

        public static readonly Guid IID_IFileSystemImage = new Guid(0x2C941FE1, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_IFileSystemImage2 = new Guid(0xD7644B2C, 0x1537, 0x4767, 0xB6, 0x2F, 0xF1, 0x38, 0x7B, 0x02, 0xDD, 0xFD);

        public static readonly Guid IID_IFileSystemImage3 = new Guid(0x7CFF842C, 0x7E97, 0x4807, 0x83, 0x04, 0x91, 0x0D, 0xD8, 0xF7, 0xC0, 0x51);

        public static readonly Guid IID_DFileSystemImageEvents = new Guid(0x2C941FDF, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid IID_DFileSystemImageImportEvents = new Guid(0xD25C30F9, 0x4087, 0x4366, 0x9E, 0x24, 0xE5, 0x5B, 0xE2, 0x86, 0x42, 0x4B);

        public static readonly Guid IID_IIsoImageManager = new Guid(0x6CA38BE5, 0xFBBB, 0x4800, 0x95, 0xA1, 0xA4, 0x38, 0x86, 0x5E, 0xB0, 0xD4);

        public static readonly Guid CLSID_BootOptions = new Guid(0x2C941FCE, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_FsiStream = new Guid(0x2C941FCD, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_FileSystemImageResult = new Guid(0x2C941FCC, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_ProgressItem = new Guid(0x2C941FCB, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_EnumProgressItems = new Guid(0x2C941FCA, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_ProgressItems = new Guid(0x2C941FC9, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_FsiDirectoryItem = new Guid(0x2C941FC8, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_FsiFileItem = new Guid(0x2C941FC7, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_EnumFsiItems = new Guid(0x2C941FC6, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_FsiNamedStreams = new Guid(0xC6B6F8ED, 0x6D19, 0x44B4, 0xB5, 0x39, 0xB1, 0x59, 0xB7, 0x93, 0xA3, 0x2D);

        public static readonly Guid CLSID_MsftFileSystemImage = new Guid(0x2C941FC5, 0x975B, 0x59BE, 0xA9, 0x60, 0x9A, 0x2A, 0x26, 0x28, 0x53, 0xA5);

        public static readonly Guid CLSID_MsftIsoImageManager = new Guid(0xCEEE3B62, 0x8F56, 0x4056, 0x86, 0x9B, 0xEF, 0x16, 0x91, 0x7E, 0x3E, 0xFC);

        public static readonly Guid CLSID_BlockRange = new Guid(0xB507CA27, 0x2204, 0x11DD, 0x96, 0x6A, 0x00, 0x1A, 0xA0, 0x1B, 0xBC, 0x58);

        public static readonly Guid CLSID_BlockRangeList = new Guid(0xB507CA28, 0x2204, 0x11DD, 0x96, 0x6A, 0x00, 0x1A, 0xA0, 0x1B, 0xBC, 0x58);
    }
}
