// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IInternetSecurityManagerEx" /> struct.</summary>
public static unsafe partial class IInternetSecurityManagerExTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IInternetSecurityManagerEx" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IInternetSecurityManagerEx).GUID, Is.EqualTo(IID_IInternetSecurityManagerEx));
    }

    /// <summary>Validates that the <see cref="IInternetSecurityManagerEx" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IInternetSecurityManagerEx>(), Is.EqualTo(sizeof(IInternetSecurityManagerEx)));
    }

    /// <summary>Validates that the <see cref="IInternetSecurityManagerEx" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IInternetSecurityManagerEx).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IInternetSecurityManagerEx" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IInternetSecurityManagerEx), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IInternetSecurityManagerEx), Is.EqualTo(4));
        }
    }
}
