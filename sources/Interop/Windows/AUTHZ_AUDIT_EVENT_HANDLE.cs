// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_AUDIT_EVENT_HANDLE : IEquatable<AUTHZ_AUDIT_EVENT_HANDLE>
    {
        public readonly nint Value;

        public AUTHZ_AUDIT_EVENT_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_AUDIT_EVENT_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_AUDIT_EVENT_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_AUDIT_EVENT_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_AUDIT_EVENT_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public AUTHZ_AUDIT_EVENT_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(AUTHZ_AUDIT_EVENT_HANDLE left, AUTHZ_AUDIT_EVENT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_AUDIT_EVENT_HANDLE left, AUTHZ_AUDIT_EVENT_HANDLE right) => left.Value != right.Value;

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(int value) => new AUTHZ_AUDIT_EVENT_HANDLE(value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(uint value) => new AUTHZ_AUDIT_EVENT_HANDLE(value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(nint value) => new AUTHZ_AUDIT_EVENT_HANDLE(value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(nuint value) => new AUTHZ_AUDIT_EVENT_HANDLE(value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(void* value) => new AUTHZ_AUDIT_EVENT_HANDLE(value);

        public static explicit operator AUTHZ_AUDIT_EVENT_HANDLE(HANDLE value) => new AUTHZ_AUDIT_EVENT_HANDLE(value);

        public static implicit operator int(AUTHZ_AUDIT_EVENT_HANDLE value) => (int)(value.Value);

        public static implicit operator uint(AUTHZ_AUDIT_EVENT_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(AUTHZ_AUDIT_EVENT_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(AUTHZ_AUDIT_EVENT_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(AUTHZ_AUDIT_EVENT_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(AUTHZ_AUDIT_EVENT_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is AUTHZ_AUDIT_EVENT_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_AUDIT_EVENT_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
