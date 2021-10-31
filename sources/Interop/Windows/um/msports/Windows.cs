// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msports.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int SerialDisplayAdvancedSettings(HWND ParentHwnd, HDEVINFO DeviceInfoSet, [NativeTypeName("PSP_DEVINFO_DATA")] void* DeviceInfoData);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBOpen([NativeTypeName("PHCOMDB")] HCOMDB* PHComDB);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBClose(HCOMDB HComDB);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBGetCurrentPortUsage(HCOMDB HComDB, [NativeTypeName("PBYTE")] byte* Buffer, [NativeTypeName("DWORD")] uint BufferSize, [NativeTypeName("ULONG")] uint ReportType, [NativeTypeName("LPDWORD")] uint* MaxPortsReported);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBClaimNextFreePort(HCOMDB HComDB, [NativeTypeName("LPDWORD")] uint* ComNumber);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBClaimPort(HCOMDB HComDB, [NativeTypeName("DWORD")] uint ComNumber, BOOL ForceClaim, [NativeTypeName("PBOOL")] BOOL* Forced);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBReleasePort(HCOMDB HComDB, [NativeTypeName("DWORD")] uint ComNumber);

        [DllImport("msports", ExactSpelling = true)]
        [return: NativeTypeName("LONG")]
        public static extern int ComDBResizeDatabase(HCOMDB HComDB, [NativeTypeName("DWORD")] uint NewSize);

        [NativeTypeName("#define COMDB_MIN_PORTS_ARBITRATED 256")]
        public const int COMDB_MIN_PORTS_ARBITRATED = 256;

        [NativeTypeName("#define COMDB_MAX_PORTS_ARBITRATED 4096")]
        public const int COMDB_MAX_PORTS_ARBITRATED = 4096;

        [NativeTypeName("#define CDB_REPORT_BITS 0x0")]
        public const int CDB_REPORT_BITS = 0x0;

        [NativeTypeName("#define CDB_REPORT_BYTES 0x1")]
        public const int CDB_REPORT_BYTES = 0x1;
    }
}
