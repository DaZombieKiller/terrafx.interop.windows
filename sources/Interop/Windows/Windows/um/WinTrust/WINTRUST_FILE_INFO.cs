// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='WINTRUST_FILE_INFO.xml' path='doc/member[@name="WINTRUST_FILE_INFO"]/*' />
public unsafe partial struct WINTRUST_FILE_INFO
{
    /// <include file='WINTRUST_FILE_INFO.xml' path='doc/member[@name="WINTRUST_FILE_INFO.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='WINTRUST_FILE_INFO.xml' path='doc/member[@name="WINTRUST_FILE_INFO.pcwszFilePath"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pcwszFilePath;

    /// <include file='WINTRUST_FILE_INFO.xml' path='doc/member[@name="WINTRUST_FILE_INFO.hFile"]/*' />
    public HANDLE hFile;

    /// <include file='WINTRUST_FILE_INFO.xml' path='doc/member[@name="WINTRUST_FILE_INFO.pgKnownSubject"]/*' />
    public Guid* pgKnownSubject;
}
