// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SVGTextPositioningElement" /> struct.</summary>
public static unsafe partial class SVGTextPositioningElementTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SVGTextPositioningElement" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGTextPositioningElement).GUID, Is.EqualTo(IID_SVGTextPositioningElement));
    }

    /// <summary>Validates that the <see cref="SVGTextPositioningElement" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGTextPositioningElement>(), Is.EqualTo(sizeof(SVGTextPositioningElement)));
    }

    /// <summary>Validates that the <see cref="SVGTextPositioningElement" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGTextPositioningElement).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SVGTextPositioningElement" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGTextPositioningElement), Is.EqualTo(1));
    }
}
