// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMIDISTRM : IEquatable<HMIDISTRM>
    {
        public readonly nint Value;

        public HMIDISTRM(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMIDISTRM left, HMIDISTRM right) => left.Value == right.Value;

        public static bool operator !=(HMIDISTRM left, HMIDISTRM right) => left.Value != right.Value;

        public static implicit operator HMIDISTRM(nint value) => new HMIDISTRM(value);

        public static implicit operator nint(HMIDISTRM value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMIDISTRM other) && Equals(other);

        public bool Equals(HMIDISTRM other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
