// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDCompositionSurface" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDCompositionSurfaceTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionSurface" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDCompositionSurface).GUID, Is.EqualTo(IID_IDCompositionSurface));
    }

    /// <summary>Validates that the <see cref="IDCompositionSurface" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDCompositionSurface>(), Is.EqualTo(sizeof(IDCompositionSurface)));
    }

    /// <summary>Validates that the <see cref="IDCompositionSurface" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionSurface).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDCompositionSurface" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionSurface), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionSurface), Is.EqualTo(4));
        }
    }
}
