// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/MessageDispatcherApi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("ole32", ExactSpelling = true)]
        public static extern void CoSetMessageDispatcher([NativeTypeName("PMessageDispatcher")] IMessageDispatcher* pMessageDispatcher);

        [DllImport("ole32", ExactSpelling = true)]
        public static extern void CoHandlePriorityEventsFromMessagePump();
    }
}
