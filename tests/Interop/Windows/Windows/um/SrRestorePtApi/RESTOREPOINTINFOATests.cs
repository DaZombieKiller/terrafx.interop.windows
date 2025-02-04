// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="RESTOREPOINTINFOA" /> struct.</summary>
public static unsafe partial class RESTOREPOINTINFOATests
{
    /// <summary>Validates that the <see cref="RESTOREPOINTINFOA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RESTOREPOINTINFOA>(), Is.EqualTo(sizeof(RESTOREPOINTINFOA)));
    }

    /// <summary>Validates that the <see cref="RESTOREPOINTINFOA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RESTOREPOINTINFOA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="RESTOREPOINTINFOA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RESTOREPOINTINFOA), Is.EqualTo(80));
    }
}
