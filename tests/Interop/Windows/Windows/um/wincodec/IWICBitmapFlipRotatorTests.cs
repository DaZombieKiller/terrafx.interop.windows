// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IWICBitmapFlipRotator" /> struct.</summary>
public static unsafe partial class IWICBitmapFlipRotatorTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICBitmapFlipRotator" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWICBitmapFlipRotator).GUID, Is.EqualTo(IID_IWICBitmapFlipRotator));
    }

    /// <summary>Validates that the <see cref="IWICBitmapFlipRotator" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWICBitmapFlipRotator>(), Is.EqualTo(sizeof(IWICBitmapFlipRotator)));
    }

    /// <summary>Validates that the <see cref="IWICBitmapFlipRotator" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWICBitmapFlipRotator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IWICBitmapFlipRotator" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWICBitmapFlipRotator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWICBitmapFlipRotator), Is.EqualTo(4));
        }
    }
}
