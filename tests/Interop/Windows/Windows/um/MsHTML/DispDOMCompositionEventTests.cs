// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DispDOMCompositionEvent" /> struct.</summary>
public static unsafe partial class DispDOMCompositionEventTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispDOMCompositionEvent" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispDOMCompositionEvent).GUID, Is.EqualTo(IID_DispDOMCompositionEvent));
    }

    /// <summary>Validates that the <see cref="DispDOMCompositionEvent" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispDOMCompositionEvent>(), Is.EqualTo(sizeof(DispDOMCompositionEvent)));
    }

    /// <summary>Validates that the <see cref="DispDOMCompositionEvent" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispDOMCompositionEvent).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DispDOMCompositionEvent" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispDOMCompositionEvent), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispDOMCompositionEvent), Is.EqualTo(4));
        }
    }
}
