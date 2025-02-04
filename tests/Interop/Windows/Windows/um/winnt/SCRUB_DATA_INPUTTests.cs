// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SCRUB_DATA_INPUT" /> struct.</summary>
public static unsafe partial class SCRUB_DATA_INPUTTests
{
    /// <summary>Validates that the <see cref="SCRUB_DATA_INPUT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCRUB_DATA_INPUT>(), Is.EqualTo(sizeof(SCRUB_DATA_INPUT)));
    }

    /// <summary>Validates that the <see cref="SCRUB_DATA_INPUT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCRUB_DATA_INPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SCRUB_DATA_INPUT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCRUB_DATA_INPUT), Is.EqualTo(1232));
    }
}
