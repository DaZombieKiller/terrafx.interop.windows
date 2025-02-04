// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmodel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PACKAGE_ID" /> struct.</summary>
public static unsafe partial class PACKAGE_IDTests
{
    /// <summary>Validates that the <see cref="PACKAGE_ID" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PACKAGE_ID>(), Is.EqualTo(sizeof(PACKAGE_ID)));
    }

    /// <summary>Validates that the <see cref="PACKAGE_ID" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PACKAGE_ID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PACKAGE_ID" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PACKAGE_ID), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(PACKAGE_ID), Is.EqualTo(32));
        }
    }
}
