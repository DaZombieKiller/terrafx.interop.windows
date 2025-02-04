// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="UDACCEL" /> struct.</summary>
public static unsafe partial class UDACCELTests
{
    /// <summary>Validates that the <see cref="UDACCEL" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<UDACCEL>(), Is.EqualTo(sizeof(UDACCEL)));
    }

    /// <summary>Validates that the <see cref="UDACCEL" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(UDACCEL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="UDACCEL" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(UDACCEL), Is.EqualTo(8));
    }
}
