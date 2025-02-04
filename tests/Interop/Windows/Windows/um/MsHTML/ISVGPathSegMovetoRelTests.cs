// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISVGPathSegMovetoRel" /> struct.</summary>
public static unsafe partial class ISVGPathSegMovetoRelTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISVGPathSegMovetoRel" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISVGPathSegMovetoRel).GUID, Is.EqualTo(IID_ISVGPathSegMovetoRel));
    }

    /// <summary>Validates that the <see cref="ISVGPathSegMovetoRel" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISVGPathSegMovetoRel>(), Is.EqualTo(sizeof(ISVGPathSegMovetoRel)));
    }

    /// <summary>Validates that the <see cref="ISVGPathSegMovetoRel" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISVGPathSegMovetoRel).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISVGPathSegMovetoRel" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISVGPathSegMovetoRel), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISVGPathSegMovetoRel), Is.EqualTo(4));
        }
    }
}
