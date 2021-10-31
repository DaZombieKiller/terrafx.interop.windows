// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FillConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("CHAR")] sbyte cCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FillConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WCHAR")] ushort cCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FillConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WORD")] ushort wAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GenerateConsoleCtrlEvent([NativeTypeName("DWORD")] uint dwCtrlEvent, [NativeTypeName("DWORD")] uint dwProcessGroupId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HANDLE")]
        public static extern IntPtr CreateConsoleScreenBuffer([NativeTypeName("DWORD")] uint dwDesiredAccess, [NativeTypeName("DWORD")] uint dwShareMode, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* lpSecurityAttributes, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPVOID")] void* lpScreenBufferData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleActiveScreenBuffer([NativeTypeName("HANDLE")] IntPtr hConsoleOutput);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FlushConsoleInputBuffer([NativeTypeName("HANDLE")] IntPtr hConsoleInput);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleCP([NativeTypeName("UINT")] uint wCodePageID);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleOutputCP([NativeTypeName("UINT")] uint wCodePageID);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetConsoleCursorInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_CURSOR_INFO")] CONSOLE_CURSOR_INFO* lpConsoleCursorInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleCursorInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CONSOLE_CURSOR_INFO *")] CONSOLE_CURSOR_INFO* lpConsoleCursorInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetConsoleScreenBufferInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFO")] CONSOLE_SCREEN_BUFFER_INFO* lpConsoleScreenBufferInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetConsoleScreenBufferInfoEx([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFOEX")] CONSOLE_SCREEN_BUFFER_INFOEX* lpConsoleScreenBufferInfoEx);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleScreenBufferInfoEx([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCONSOLE_SCREEN_BUFFER_INFOEX")] CONSOLE_SCREEN_BUFFER_INFOEX* lpConsoleScreenBufferInfoEx);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleScreenBufferSize([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, COORD dwSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleCursorPosition([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, COORD dwCursorPosition);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern COORD GetLargestConsoleWindowSize([NativeTypeName("HANDLE")] IntPtr hConsoleOutput);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleTextAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("WORD")] ushort wAttributes);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleWindowInfo([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, BOOL bAbsolute, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpConsoleWindow);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPCSTR")] sbyte* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPCWSTR")] ushort* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const WORD *")] ushort* lpAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwWriteCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleOutputCharacterA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPSTR")] sbyte* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleOutputCharacterW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPWSTR")] ushort* lpCharacter, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfCharsRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleOutputAttribute([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("LPWORD")] ushort* lpAttribute, [NativeTypeName("DWORD")] uint nLength, COORD dwReadCoord, [NativeTypeName("LPDWORD")] uint* lpNumberOfAttrsRead);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleInputA([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("const INPUT_RECORD *")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleInputW([NativeTypeName("HANDLE")] IntPtr hConsoleInput, [NativeTypeName("const INPUT_RECORD *")] INPUT_RECORD* lpBuffer, [NativeTypeName("DWORD")] uint nLength, [NativeTypeName("LPDWORD")] uint* lpNumberOfEventsWritten);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ScrollConsoleScreenBufferA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpScrollRectangle, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpClipRectangle, COORD dwDestinationOrigin, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpFill);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ScrollConsoleScreenBufferW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpScrollRectangle, [NativeTypeName("const SMALL_RECT *")] SMALL_RECT* lpClipRectangle, COORD dwDestinationOrigin, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpFill);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleOutputA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpWriteRegion);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL WriteConsoleOutputW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("const CHAR_INFO *")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpWriteRegion);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleOutputA([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCHAR_INFO")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpReadRegion);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL ReadConsoleOutputW([NativeTypeName("HANDLE")] IntPtr hConsoleOutput, [NativeTypeName("PCHAR_INFO")] CHAR_INFO* lpBuffer, COORD dwBufferSize, COORD dwBufferCoord, [NativeTypeName("PSMALL_RECT")] SMALL_RECT* lpReadRegion);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleTitleA([NativeTypeName("LPSTR")] sbyte* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleTitleW([NativeTypeName("LPWSTR")] ushort* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleOriginalTitleA([NativeTypeName("LPSTR")] sbyte* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetConsoleOriginalTitleW([NativeTypeName("LPWSTR")] ushort* lpConsoleTitle, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleTitleA([NativeTypeName("LPCSTR")] sbyte* lpConsoleTitle);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetConsoleTitleW([NativeTypeName("LPCWSTR")] ushort* lpConsoleTitle);

        [NativeTypeName("#define FOREGROUND_BLUE 0x0001")]
        public const int FOREGROUND_BLUE = 0x0001;

        [NativeTypeName("#define FOREGROUND_GREEN 0x0002")]
        public const int FOREGROUND_GREEN = 0x0002;

        [NativeTypeName("#define FOREGROUND_RED 0x0004")]
        public const int FOREGROUND_RED = 0x0004;

        [NativeTypeName("#define FOREGROUND_INTENSITY 0x0008")]
        public const int FOREGROUND_INTENSITY = 0x0008;

        [NativeTypeName("#define BACKGROUND_BLUE 0x0010")]
        public const int BACKGROUND_BLUE = 0x0010;

        [NativeTypeName("#define BACKGROUND_GREEN 0x0020")]
        public const int BACKGROUND_GREEN = 0x0020;

        [NativeTypeName("#define BACKGROUND_RED 0x0040")]
        public const int BACKGROUND_RED = 0x0040;

        [NativeTypeName("#define BACKGROUND_INTENSITY 0x0080")]
        public const int BACKGROUND_INTENSITY = 0x0080;

        [NativeTypeName("#define COMMON_LVB_LEADING_BYTE 0x0100")]
        public const int COMMON_LVB_LEADING_BYTE = 0x0100;

        [NativeTypeName("#define COMMON_LVB_TRAILING_BYTE 0x0200")]
        public const int COMMON_LVB_TRAILING_BYTE = 0x0200;

        [NativeTypeName("#define COMMON_LVB_GRID_HORIZONTAL 0x0400")]
        public const int COMMON_LVB_GRID_HORIZONTAL = 0x0400;

        [NativeTypeName("#define COMMON_LVB_GRID_LVERTICAL 0x0800")]
        public const int COMMON_LVB_GRID_LVERTICAL = 0x0800;

        [NativeTypeName("#define COMMON_LVB_GRID_RVERTICAL 0x1000")]
        public const int COMMON_LVB_GRID_RVERTICAL = 0x1000;

        [NativeTypeName("#define COMMON_LVB_REVERSE_VIDEO 0x4000")]
        public const int COMMON_LVB_REVERSE_VIDEO = 0x4000;

        [NativeTypeName("#define COMMON_LVB_UNDERSCORE 0x8000")]
        public const int COMMON_LVB_UNDERSCORE = 0x8000;

        [NativeTypeName("#define COMMON_LVB_SBCSDBCS 0x0300")]
        public const int COMMON_LVB_SBCSDBCS = 0x0300;

        [NativeTypeName("#define FillConsoleOutputCharacter FillConsoleOutputCharacterW")]
        public static delegate*<IntPtr, ushort, uint, COORD, uint*, BOOL> FillConsoleOutputCharacter => &FillConsoleOutputCharacterW;

        [NativeTypeName("#define WriteConsoleOutputCharacter WriteConsoleOutputCharacterW")]
        public static delegate*<IntPtr, ushort*, uint, COORD, uint*, BOOL> WriteConsoleOutputCharacter => &WriteConsoleOutputCharacterW;

        [NativeTypeName("#define ReadConsoleOutputCharacter ReadConsoleOutputCharacterW")]
        public static delegate*<IntPtr, ushort*, uint, COORD, uint*, BOOL> ReadConsoleOutputCharacter => &ReadConsoleOutputCharacterW;

        [NativeTypeName("#define WriteConsoleInput WriteConsoleInputW")]
        public static delegate*<IntPtr, INPUT_RECORD*, uint, uint*, BOOL> WriteConsoleInput => &WriteConsoleInputW;

        [NativeTypeName("#define ScrollConsoleScreenBuffer ScrollConsoleScreenBufferW")]
        public static delegate*<IntPtr, SMALL_RECT*, SMALL_RECT*, COORD, CHAR_INFO*, BOOL> ScrollConsoleScreenBuffer => &ScrollConsoleScreenBufferW;

        [NativeTypeName("#define WriteConsoleOutput WriteConsoleOutputW")]
        public static delegate*<IntPtr, CHAR_INFO*, COORD, COORD, SMALL_RECT*, BOOL> WriteConsoleOutput => &WriteConsoleOutputW;

        [NativeTypeName("#define ReadConsoleOutput ReadConsoleOutputW")]
        public static delegate*<IntPtr, CHAR_INFO*, COORD, COORD, SMALL_RECT*, BOOL> ReadConsoleOutput => &ReadConsoleOutputW;

        [NativeTypeName("#define GetConsoleTitle GetConsoleTitleW")]
        public static delegate*<ushort*, uint, uint> GetConsoleTitle => &GetConsoleTitleW;

        [NativeTypeName("#define GetConsoleOriginalTitle GetConsoleOriginalTitleW")]
        public static delegate*<ushort*, uint, uint> GetConsoleOriginalTitle => &GetConsoleOriginalTitleW;

        [NativeTypeName("#define SetConsoleTitle SetConsoleTitleW")]
        public static delegate*<ushort*, BOOL> SetConsoleTitle => &SetConsoleTitleW;
    }
}
