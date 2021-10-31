// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateFromMoniker(IMoniker* pimkTrgt, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateFromString([NativeTypeName("LPCWSTR")] ushort* pwzTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateFromData(IDataObject* piDataObj, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkQueryCreateFromData(IDataObject* piDataObj);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkClone(IHlink* pihl, [NativeTypeName("const IID &")] Guid* riid, IHlinkSite* pihlsiteForClone, [NativeTypeName("DWORD")] uint dwSiteData, void** ppvObj);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateBrowseContext(IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkNavigateToStringReference([NativeTypeName("LPCWSTR")] ushort* pwzTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IHlinkFrame* pihlframe, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPBC")] IBindCtx* pibc, IBindStatusCallback* pibsc, IHlinkBrowseContext* pihlbc);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkNavigate(IHlink* pihl, IHlinkFrame* pihlframe, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("LPBC")] IBindCtx* pbc, IBindStatusCallback* pibsc, IHlinkBrowseContext* pihlbc);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkOnNavigate(IHlinkFrame* pihlframe, IHlinkBrowseContext* pihlbc, [NativeTypeName("DWORD")] uint grfHLNF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName, [NativeTypeName("ULONG *")] uint* puHLID);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkUpdateStackItem(IHlinkFrame* pihlframe, IHlinkBrowseContext* pihlbc, [NativeTypeName("ULONG")] uint uHLID, IMoniker* pimkTrgt, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzFriendlyName);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkOnRenameDocument([NativeTypeName("DWORD")] uint dwReserved, IHlinkBrowseContext* pihlbc, IMoniker* pimkOld, IMoniker* pimkNew);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveMonikerForData([NativeTypeName("LPMONIKER")] IMoniker* pimkReference, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("ULONG")] uint cFmtetc, FORMATETC* rgFmtetc, IBindStatusCallback* pibsc, [NativeTypeName("LPMONIKER")] IMoniker* pimkBase);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveStringForData([NativeTypeName("LPCWSTR")] ushort* pwzReference, [NativeTypeName("DWORD")] uint reserved, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("ULONG")] uint cFmtetc, FORMATETC* rgFmtetc, IBindStatusCallback* pibsc, [NativeTypeName("LPMONIKER")] IMoniker* pimkBase);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkParseDisplayName([NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("LPCWSTR")] ushort* pwzDisplayName, BOOL fNoForceAbs, [NativeTypeName("ULONG *")] uint* pcchEaten, IMoniker** ppimk);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateExtensionServices([NativeTypeName("LPCWSTR")] ushort* pwzAdditionalHeaders, [NativeTypeName("HWND")] IntPtr phwnd, [NativeTypeName("LPCWSTR")] ushort* pszUsername, [NativeTypeName("LPCWSTR")] ushort* pszPassword, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkPreprocessMoniker([NativeTypeName("LPBC")] IBindCtx* pibc, IMoniker* pimkIn, IMoniker** ppimkOut);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int OleSaveToStreamEx(IUnknown* piunk, IStream* pistm, BOOL fClearDirty);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkSetSpecialReference([NativeTypeName("ULONG")] uint uReference, [NativeTypeName("LPCWSTR")] ushort* pwzReference);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkGetSpecialReference([NativeTypeName("ULONG")] uint uReference, [NativeTypeName("LPWSTR *")] ushort** ppwzReference);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateShortcut([NativeTypeName("DWORD")] uint grfHLSHORTCUTF, IHlink* pihl, [NativeTypeName("LPCWSTR")] ushort* pwzDir, [NativeTypeName("LPCWSTR")] ushort* pwzFileName, [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateShortcutFromMoniker([NativeTypeName("DWORD")] uint grfHLSHORTCUTF, IMoniker* pimkTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzDir, [NativeTypeName("LPCWSTR")] ushort* pwzFileName, [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkCreateShortcutFromString([NativeTypeName("DWORD")] uint grfHLSHORTCUTF, [NativeTypeName("LPCWSTR")] ushort* pwzTarget, [NativeTypeName("LPCWSTR")] ushort* pwzLocation, [NativeTypeName("LPCWSTR")] ushort* pwzDir, [NativeTypeName("LPCWSTR")] ushort* pwzFileName, [NativeTypeName("LPWSTR *")] ushort** ppwzShortcutFile, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveShortcut([NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName, IHlinkSite* pihlsite, [NativeTypeName("DWORD")] uint dwSiteData, IUnknown* piunkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObj);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveShortcutToMoniker([NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName, IMoniker** ppimkTarget, [NativeTypeName("LPWSTR *")] ushort** ppwzLocation);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkResolveShortcutToString([NativeTypeName("LPCWSTR")] ushort* pwzShortcutFileName, [NativeTypeName("LPWSTR *")] ushort** ppwzTarget, [NativeTypeName("LPWSTR *")] ushort** ppwzLocation);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkIsShortcut([NativeTypeName("LPCWSTR")] ushort* pwzFileName);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkGetValueFromParams([NativeTypeName("LPCWSTR")] ushort* pwzParams, [NativeTypeName("LPCWSTR")] ushort* pwzName, [NativeTypeName("LPWSTR *")] ushort** ppwzValue);

        [DllImport("hlink", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int HlinkTranslateURL([NativeTypeName("LPCWSTR")] ushort* pwzURL, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("LPWSTR *")] ushort** ppwzTranslatedURL);

        [NativeTypeName("#define SID_SHlinkFrame IID_IHlinkFrame")]
        public static ref readonly Guid SID_SHlinkFrame => ref IID_IHlinkFrame;

        [NativeTypeName("#define IID_IHlinkSource IID_IHlinkTarget")]
        public static ref readonly Guid IID_IHlinkSource => ref IID_IHlinkTarget;

        [NativeTypeName("#define HLINK_E_FIRST (OLE_E_LAST+1)")]
        public const int HLINK_E_FIRST = unchecked(((int)(0x800400FF)) + 1);

        [NativeTypeName("#define HLINK_S_FIRST (OLE_S_LAST+1)")]
        public const int HLINK_S_FIRST = (((int)(0x000400FF)) + 1);

        [NativeTypeName("#define HLINK_S_DONTHIDE (HLINK_S_FIRST)")]
        public const int HLINK_S_DONTHIDE = ((((int)(0x000400FF)) + 1));

        [NativeTypeName("#define CFSTR_HYPERLINK (TEXT(\"Hyperlink\"))")]
        public const string CFSTR_HYPERLINK = ("Hyperlink");

        public static ref readonly Guid IID_IHlink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHlinkSite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHlinkTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHlinkFrame
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumHLITEM
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IHlinkBrowseContext
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IExtensionServices
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0xC9, 0xEA, 0x79,
                    0xF9, 0xBA,
                    0xCE, 0x11,
                    0x8C,
                    0x82,
                    0x00,
                    0xAA,
                    0x00,
                    0x4B,
                    0xA9,
                    0x0B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
