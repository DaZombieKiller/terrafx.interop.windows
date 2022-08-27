// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WICImageParameters" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class WICImageParametersTests
{
    /// <summary>Validates that the <see cref="WICImageParameters" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WICImageParameters>(), Is.EqualTo(sizeof(WICImageParameters)));
    }

    /// <summary>Validates that the <see cref="WICImageParameters" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WICImageParameters).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WICImageParameters" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WICImageParameters), Is.EqualTo(32));
    }
}
