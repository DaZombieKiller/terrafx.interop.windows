// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="AppxFactory" /> struct.</summary>
public static unsafe partial class AppxFactoryTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="AppxFactory" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(AppxFactory).GUID, Is.EqualTo(IID_AppxFactory));
    }

    /// <summary>Validates that the <see cref="AppxFactory" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AppxFactory>(), Is.EqualTo(sizeof(AppxFactory)));
    }

    /// <summary>Validates that the <see cref="AppxFactory" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AppxFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AppxFactory" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AppxFactory), Is.EqualTo(1));
    }
}
