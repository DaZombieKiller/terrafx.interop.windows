// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MANAGEDAPPLICATION
    {
        [NativeTypeName("LPWSTR")]
        public ushort* pszPackageName;

        [NativeTypeName("LPWSTR")]
        public ushort* pszPublisher;

        [NativeTypeName("DWORD")]
        public uint dwVersionHi;

        [NativeTypeName("DWORD")]
        public uint dwVersionLo;

        [NativeTypeName("DWORD")]
        public uint dwRevision;

        [NativeTypeName("GUID")]
        public Guid GpoId;

        [NativeTypeName("LPWSTR")]
        public ushort* pszPolicyName;

        [NativeTypeName("GUID")]
        public Guid ProductId;

        [NativeTypeName("LANGID")]
        public ushort Language;

        [NativeTypeName("LPWSTR")]
        public ushort* pszOwner;

        [NativeTypeName("LPWSTR")]
        public ushort* pszCompany;

        [NativeTypeName("LPWSTR")]
        public ushort* pszComments;

        [NativeTypeName("LPWSTR")]
        public ushort* pszContact;

        [NativeTypeName("LPWSTR")]
        public ushort* pszSupportUrl;

        [NativeTypeName("DWORD")]
        public uint dwPathType;

        public BOOL bInstalled;
    }
}
