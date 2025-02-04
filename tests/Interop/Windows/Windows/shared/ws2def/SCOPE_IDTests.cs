// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SCOPE_ID" /> struct.</summary>
public static unsafe partial class SCOPE_IDTests
{
    /// <summary>Validates that the <see cref="SCOPE_ID" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCOPE_ID>(), Is.EqualTo(sizeof(SCOPE_ID)));
    }

    /// <summary>Validates that the <see cref="SCOPE_ID" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCOPE_ID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SCOPE_ID" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCOPE_ID), Is.EqualTo(4));
    }
}
