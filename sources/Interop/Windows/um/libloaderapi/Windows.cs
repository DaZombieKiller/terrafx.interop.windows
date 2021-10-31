// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/libloaderapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL DisableThreadLibraryCalls([NativeTypeName("HMODULE")] HINSTANCE hLibModule);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HRSRC FindResourceExW([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("WORD")] ushort wLanguage);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern int FindStringOrdinal([NativeTypeName("DWORD")] uint dwFindStringOrdinalFlags, [NativeTypeName("LPCWSTR")] ushort* lpStringSource, int cchSource, [NativeTypeName("LPCWSTR")] ushort* lpStringValue, int cchValue, BOOL bIgnoreCase);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL FreeLibrary([NativeTypeName("HMODULE")] HINSTANCE hLibModule);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern void FreeLibraryAndExitThread([NativeTypeName("HMODULE")] HINSTANCE hLibModule, [NativeTypeName("DWORD")] uint dwExitCode);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL FreeResource([NativeTypeName("HGLOBAL")] HANDLE hResData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetModuleFileNameA([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPSTR")] sbyte* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint GetModuleFileNameW([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPWSTR")] ushort* lpFilename, [NativeTypeName("DWORD")] uint nSize);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern HINSTANCE GetModuleHandleA([NativeTypeName("LPCSTR")] sbyte* lpModuleName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern HINSTANCE GetModuleHandleW([NativeTypeName("LPCWSTR")] ushort* lpModuleName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetModuleHandleExA([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* lpModuleName, [NativeTypeName("HMODULE *")] HINSTANCE* phModule);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL GetModuleHandleExW([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* lpModuleName, [NativeTypeName("HMODULE *")] HINSTANCE* phModule);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("FARPROC")]
        public static extern IntPtr GetProcAddress([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCSTR")] sbyte* lpProcName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern HINSTANCE LoadLibraryExA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName, HANDLE hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern HINSTANCE LoadLibraryExW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName, HANDLE hFile, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HGLOBAL")]
        public static extern HANDLE LoadResource([NativeTypeName("HMODULE")] HINSTANCE hModule, HRSRC hResInfo);

        [DllImport("kernel32", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* LockResource([NativeTypeName("HGLOBAL")] HANDLE hResData);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SizeofResource([NativeTypeName("HMODULE")] HINSTANCE hModule, HRSRC hResInfo);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("DLL_DIRECTORY_COOKIE")]
        public static extern void* AddDllDirectory([NativeTypeName("PCWSTR")] ushort* NewDirectory);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL RemoveDllDirectory([NativeTypeName("DLL_DIRECTORY_COOKIE")] void* Cookie);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL SetDefaultDllDirectories([NativeTypeName("DWORD")] uint DirectoryFlags);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumResourceLanguagesExA([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("LPCSTR")] sbyte* lpName, [NativeTypeName("ENUMRESLANGPROCA")] delegate* unmanaged<HINSTANCE, sbyte*, sbyte*, ushort, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumResourceLanguagesExW([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("ENUMRESLANGPROCW")] delegate* unmanaged<HINSTANCE, ushort*, ushort*, ushort, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumResourceNamesExA([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* unmanaged<HINSTANCE, sbyte*, sbyte*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumResourceNamesExW([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] delegate* unmanaged<HINSTANCE, ushort*, ushort*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumResourceTypesExA([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("ENUMRESTYPEPROCA")] delegate* unmanaged<HINSTANCE, sbyte*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern BOOL EnumResourceTypesExW([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("ENUMRESTYPEPROCW")] delegate* unmanaged<HINSTANCE, ushort*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LANGID")] ushort LangId);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        public static extern HRSRC FindResourceW([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCWSTR")] ushort* lpName, [NativeTypeName("LPCWSTR")] ushort* lpType);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern HINSTANCE LoadLibraryA([NativeTypeName("LPCSTR")] sbyte* lpLibFileName);

        [DllImport("kernel32", ExactSpelling = true, SetLastError = true)]
        [return: NativeTypeName("HMODULE")]
        public static extern HINSTANCE LoadLibraryW([NativeTypeName("LPCWSTR")] ushort* lpLibFileName);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL EnumResourceNamesW([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCWSTR")] ushort* lpType, [NativeTypeName("ENUMRESNAMEPROCW")] delegate* unmanaged<HINSTANCE, ushort*, ushort*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [DllImport("kernel32", ExactSpelling = true)]
        public static extern BOOL EnumResourceNamesA([NativeTypeName("HMODULE")] HINSTANCE hModule, [NativeTypeName("LPCSTR")] sbyte* lpType, [NativeTypeName("ENUMRESNAMEPROCA")] delegate* unmanaged<HINSTANCE, sbyte*, sbyte*, nint, BOOL> lpEnumFunc, [NativeTypeName("LONG_PTR")] nint lParam);

        [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_TYPES (0x0100)")]
        public const int FIND_RESOURCE_DIRECTORY_TYPES = (0x0100);

        [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_NAMES (0x0200)")]
        public const int FIND_RESOURCE_DIRECTORY_NAMES = (0x0200);

        [NativeTypeName("#define FIND_RESOURCE_DIRECTORY_LANGUAGES (0x0400)")]
        public const int FIND_RESOURCE_DIRECTORY_LANGUAGES = (0x0400);

        [NativeTypeName("#define RESOURCE_ENUM_LN (0x0001)")]
        public const int RESOURCE_ENUM_LN = (0x0001);

        [NativeTypeName("#define RESOURCE_ENUM_MUI (0x0002)")]
        public const int RESOURCE_ENUM_MUI = (0x0002);

        [NativeTypeName("#define RESOURCE_ENUM_MUI_SYSTEM (0x0004)")]
        public const int RESOURCE_ENUM_MUI_SYSTEM = (0x0004);

        [NativeTypeName("#define RESOURCE_ENUM_VALIDATE (0x0008)")]
        public const int RESOURCE_ENUM_VALIDATE = (0x0008);

        [NativeTypeName("#define RESOURCE_ENUM_MODULE_EXACT (0x0010)")]
        public const int RESOURCE_ENUM_MODULE_EXACT = (0x0010);

        [NativeTypeName("#define SUPPORT_LANG_NUMBER 32")]
        public const int SUPPORT_LANG_NUMBER = 32;

        [NativeTypeName("#define FindResourceEx FindResourceExW")]
        public static delegate*<HINSTANCE, ushort*, ushort*, ushort, HRSRC> FindResourceEx => &FindResourceExW;

        [NativeTypeName("#define GetModuleFileName GetModuleFileNameW")]
        public static delegate*<HINSTANCE, ushort*, uint, uint> GetModuleFileName => &GetModuleFileNameW;

        [NativeTypeName("#define GetModuleHandle GetModuleHandleW")]
        public static delegate*<ushort*, HINSTANCE> GetModuleHandle => &GetModuleHandleW;

        [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_PIN (0x00000001)")]
        public const int GET_MODULE_HANDLE_EX_FLAG_PIN = (0x00000001);

        [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT (0x00000002)")]
        public const int GET_MODULE_HANDLE_EX_FLAG_UNCHANGED_REFCOUNT = (0x00000002);

        [NativeTypeName("#define GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS (0x00000004)")]
        public const int GET_MODULE_HANDLE_EX_FLAG_FROM_ADDRESS = (0x00000004);

        [NativeTypeName("#define GetModuleHandleEx GetModuleHandleExW")]
        public static delegate*<uint, ushort*, HINSTANCE*, BOOL> GetModuleHandleEx => &GetModuleHandleExW;

        [NativeTypeName("#define CURRENT_IMPORT_REDIRECTION_VERSION 1")]
        public const int CURRENT_IMPORT_REDIRECTION_VERSION = 1;

        [NativeTypeName("#define LoadLibraryEx LoadLibraryExW")]
        public static delegate*<ushort*, HANDLE, uint, HINSTANCE> LoadLibraryEx => &LoadLibraryExW;

        [NativeTypeName("#define DONT_RESOLVE_DLL_REFERENCES 0x00000001")]
        public const int DONT_RESOLVE_DLL_REFERENCES = 0x00000001;

        [NativeTypeName("#define LOAD_LIBRARY_AS_DATAFILE 0x00000002")]
        public const int LOAD_LIBRARY_AS_DATAFILE = 0x00000002;

        [NativeTypeName("#define LOAD_WITH_ALTERED_SEARCH_PATH 0x00000008")]
        public const int LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008;

        [NativeTypeName("#define LOAD_IGNORE_CODE_AUTHZ_LEVEL 0x00000010")]
        public const int LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010;

        [NativeTypeName("#define LOAD_LIBRARY_AS_IMAGE_RESOURCE 0x00000020")]
        public const int LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020;

        [NativeTypeName("#define LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE 0x00000040")]
        public const int LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040;

        [NativeTypeName("#define LOAD_LIBRARY_REQUIRE_SIGNED_TARGET 0x00000080")]
        public const int LOAD_LIBRARY_REQUIRE_SIGNED_TARGET = 0x00000080;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR 0x00000100")]
        public const int LOAD_LIBRARY_SEARCH_DLL_LOAD_DIR = 0x00000100;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_APPLICATION_DIR 0x00000200")]
        public const int LOAD_LIBRARY_SEARCH_APPLICATION_DIR = 0x00000200;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_USER_DIRS 0x00000400")]
        public const int LOAD_LIBRARY_SEARCH_USER_DIRS = 0x00000400;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_SYSTEM32 0x00000800")]
        public const int LOAD_LIBRARY_SEARCH_SYSTEM32 = 0x00000800;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_DEFAULT_DIRS 0x00001000")]
        public const int LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000;

        [NativeTypeName("#define LOAD_LIBRARY_SAFE_CURRENT_DIRS 0x00002000")]
        public const int LOAD_LIBRARY_SAFE_CURRENT_DIRS = 0x00002000;

        [NativeTypeName("#define LOAD_LIBRARY_SEARCH_SYSTEM32_NO_FORWARDER 0x00004000")]
        public const int LOAD_LIBRARY_SEARCH_SYSTEM32_NO_FORWARDER = 0x00004000;

        [NativeTypeName("#define LOAD_LIBRARY_OS_INTEGRITY_CONTINUITY 0x00008000")]
        public const int LOAD_LIBRARY_OS_INTEGRITY_CONTINUITY = 0x00008000;

        [NativeTypeName("#define EnumResourceLanguagesEx EnumResourceLanguagesExW")]
        public static delegate*<HINSTANCE, ushort*, ushort*, delegate* unmanaged<HINSTANCE, ushort*, ushort*, ushort, nint, BOOL>, nint, uint, ushort, BOOL> EnumResourceLanguagesEx => &EnumResourceLanguagesExW;

        [NativeTypeName("#define EnumResourceNamesEx EnumResourceNamesExW")]
        public static delegate*<HINSTANCE, ushort*, delegate* unmanaged<HINSTANCE, ushort*, ushort*, nint, BOOL>, nint, uint, ushort, BOOL> EnumResourceNamesEx => &EnumResourceNamesExW;

        [NativeTypeName("#define EnumResourceTypesEx EnumResourceTypesExW")]
        public static delegate*<HINSTANCE, delegate* unmanaged<HINSTANCE, ushort*, nint, BOOL>, nint, uint, ushort, BOOL> EnumResourceTypesEx => &EnumResourceTypesExW;

        [NativeTypeName("#define FindResource FindResourceW")]
        public static delegate*<HINSTANCE, ushort*, ushort*, HRSRC> FindResource => &FindResourceW;

        [NativeTypeName("#define LoadLibrary LoadLibraryW")]
        public static delegate*<ushort*, HINSTANCE> LoadLibrary => &LoadLibraryW;

        [NativeTypeName("#define EnumResourceNames EnumResourceNamesW")]
        public static delegate*<HINSTANCE, ushort*, delegate* unmanaged<HINSTANCE, ushort*, ushort*, nint, BOOL>, nint, BOOL> EnumResourceNames => &EnumResourceNamesW;
    }
}
