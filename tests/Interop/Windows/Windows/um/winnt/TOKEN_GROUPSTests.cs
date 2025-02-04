// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TOKEN_GROUPS" /> struct.</summary>
public static unsafe partial class TOKEN_GROUPSTests
{
    /// <summary>Validates that the <see cref="TOKEN_GROUPS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TOKEN_GROUPS>(), Is.EqualTo(sizeof(TOKEN_GROUPS)));
    }

    /// <summary>Validates that the <see cref="TOKEN_GROUPS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TOKEN_GROUPS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TOKEN_GROUPS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TOKEN_GROUPS), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(TOKEN_GROUPS), Is.EqualTo(12));
        }
    }
}
