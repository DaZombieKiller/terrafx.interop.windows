// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="EMRROUNDRECT" /> struct.</summary>
public static unsafe partial class EMRROUNDRECTTests
{
    /// <summary>Validates that the <see cref="EMRROUNDRECT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EMRROUNDRECT>(), Is.EqualTo(sizeof(EMRROUNDRECT)));
    }

    /// <summary>Validates that the <see cref="EMRROUNDRECT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EMRROUNDRECT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="EMRROUNDRECT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EMRROUNDRECT), Is.EqualTo(32));
    }
}
