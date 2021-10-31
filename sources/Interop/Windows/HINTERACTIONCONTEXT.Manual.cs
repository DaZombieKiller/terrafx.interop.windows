// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HINTERACTIONCONTEXT
    {
        public static explicit operator HINTERACTIONCONTEXT(nuint value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator nuint(HINTERACTIONCONTEXT value) => (nuint)(value.Value);

        public static explicit operator HINTERACTIONCONTEXT(void* value) => new HINTERACTIONCONTEXT((nint)(value));

        public static explicit operator void*(HINTERACTIONCONTEXT value) => (void*)(value.Value);
    }
}
