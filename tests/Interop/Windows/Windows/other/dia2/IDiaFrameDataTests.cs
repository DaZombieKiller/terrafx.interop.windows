// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IDiaFrameData" /> struct.</summary>
public static unsafe partial class IDiaFrameDataTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDiaFrameData" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDiaFrameData).GUID, Is.EqualTo(IID_IDiaFrameData));
    }

    /// <summary>Validates that the <see cref="IDiaFrameData" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDiaFrameData>(), Is.EqualTo(sizeof(IDiaFrameData)));
    }

    /// <summary>Validates that the <see cref="IDiaFrameData" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDiaFrameData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDiaFrameData" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDiaFrameData), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDiaFrameData), Is.EqualTo(4));
        }
    }
}
