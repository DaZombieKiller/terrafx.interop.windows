// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDXGIAdapter" /> struct.</summary>
public static unsafe partial class IDXGIAdapterTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIAdapter" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXGIAdapter).GUID, Is.EqualTo(IID_IDXGIAdapter));
    }

    /// <summary>Validates that the <see cref="IDXGIAdapter" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDXGIAdapter>(), Is.EqualTo(sizeof(IDXGIAdapter)));
    }

    /// <summary>Validates that the <see cref="IDXGIAdapter" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDXGIAdapter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDXGIAdapter" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDXGIAdapter), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDXGIAdapter), Is.EqualTo(4));
        }
    }
}
