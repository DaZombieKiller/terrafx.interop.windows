// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE"]/*' />
public unsafe partial struct EMREXTESCAPE
{
    /// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE.emr"]/*' />
    public EMR emr;

    /// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE.iEscape"]/*' />
    public int iEscape;

    /// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE.cbEscData"]/*' />
    public int cbEscData;

    /// <include file='EMREXTESCAPE.xml' path='doc/member[@name="EMREXTESCAPE.EscData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte EscData[1];
}
