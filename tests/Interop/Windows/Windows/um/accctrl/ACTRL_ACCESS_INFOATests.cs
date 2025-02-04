// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ACTRL_ACCESS_INFOA" /> struct.</summary>
public static unsafe partial class ACTRL_ACCESS_INFOATests
{
    /// <summary>Validates that the <see cref="ACTRL_ACCESS_INFOA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACTRL_ACCESS_INFOA>(), Is.EqualTo(sizeof(ACTRL_ACCESS_INFOA)));
    }

    /// <summary>Validates that the <see cref="ACTRL_ACCESS_INFOA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTRL_ACCESS_INFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ACTRL_ACCESS_INFOA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTRL_ACCESS_INFOA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(ACTRL_ACCESS_INFOA), Is.EqualTo(8));
        }
    }
}
