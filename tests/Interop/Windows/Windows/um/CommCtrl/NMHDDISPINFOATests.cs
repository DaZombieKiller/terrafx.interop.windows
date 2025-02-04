// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="NMHDDISPINFOA" /> struct.</summary>
public static unsafe partial class NMHDDISPINFOATests
{
    /// <summary>Validates that the <see cref="NMHDDISPINFOA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<NMHDDISPINFOA>(), Is.EqualTo(sizeof(NMHDDISPINFOA)));
    }

    /// <summary>Validates that the <see cref="NMHDDISPINFOA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(NMHDDISPINFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="NMHDDISPINFOA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(NMHDDISPINFOA), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(NMHDDISPINFOA), Is.EqualTo(36));
        }
    }
}
