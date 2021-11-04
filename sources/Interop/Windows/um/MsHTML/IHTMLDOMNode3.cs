// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("305106E0-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLDOMNode3 : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IHTMLDOMNode3 : IHTMLDOMNode3.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, uint>)(lpVtbl[1]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, uint>)(lpVtbl[2]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, uint*, int>)(lpVtbl[3]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT put_prefix(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT, int>)(lpVtbl[7]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_prefix(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int>)(lpVtbl[8]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_localName(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int>)(lpVtbl[9]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT get_namespaceURI(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int>)(lpVtbl[10]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT put_textContent(VARIANT v)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT, int>)(lpVtbl[11]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT get_textContent(VARIANT* p)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int>)(lpVtbl[12]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), p);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT isEqualNode(IHTMLDOMNode3* otherNode, [NativeTypeName("VARIANT_BOOL *")] short* isEqual)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode3*, short*, int>)(lpVtbl[13]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), otherNode, isEqual);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT lookupNamespaceURI(VARIANT* pvarPrefix, VARIANT* pvarNamespaceURI)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, VARIANT*, int>)(lpVtbl[14]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), pvarPrefix, pvarNamespaceURI);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT lookupPrefix(VARIANT* pvarNamespaceURI, VARIANT* pvarPrefix)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, VARIANT*, int>)(lpVtbl[15]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), pvarNamespaceURI, pvarPrefix);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT isDefaultNamespace(VARIANT* pvarNamespace, [NativeTypeName("VARIANT_BOOL *")] short* pfDefaultNamespace)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, short*, int>)(lpVtbl[16]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), pvarNamespace, pfDefaultNamespace);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT appendChild(IHTMLDOMNode* newChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[17]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), newChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT insertBefore(IHTMLDOMNode* newChild, VARIANT refChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, VARIANT, IHTMLDOMNode**, int>)(lpVtbl[18]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), newChild, refChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT removeChild(IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[19]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), oldChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT replaceChild(IHTMLDOMNode* newChild, IHTMLDOMNode* oldChild, IHTMLDOMNode** node)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int>)(lpVtbl[20]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), newChild, oldChild, node);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT isSameNode(IHTMLDOMNode3* otherNode, [NativeTypeName("VARIANT_BOOL *")] short* isSame)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode3*, short*, int>)(lpVtbl[21]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), otherNode, isSame);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT compareDocumentPosition(IHTMLDOMNode* otherNode, ushort* flags)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, ushort*, int>)(lpVtbl[22]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), otherNode, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT isSupported([NativeTypeName("BSTR")] ushort* feature, VARIANT version, [NativeTypeName("VARIANT_BOOL *")] short* pfisSupported)
        {
            return ((delegate* unmanaged<IHTMLDOMNode3*, ushort*, VARIANT, short*, int>)(lpVtbl[23]))((IHTMLDOMNode3*)Unsafe.AsPointer(ref this), feature, version, pfisSupported);
        }

        public interface Interface : IDispatch.Interface
        {
            [VtblIndex(7)]
            HRESULT put_prefix(VARIANT v);

            [VtblIndex(8)]
            HRESULT get_prefix(VARIANT* p);

            [VtblIndex(9)]
            HRESULT get_localName(VARIANT* p);

            [VtblIndex(10)]
            HRESULT get_namespaceURI(VARIANT* p);

            [VtblIndex(11)]
            HRESULT put_textContent(VARIANT v);

            [VtblIndex(12)]
            HRESULT get_textContent(VARIANT* p);

            [VtblIndex(13)]
            HRESULT isEqualNode(IHTMLDOMNode3* otherNode, [NativeTypeName("VARIANT_BOOL *")] short* isEqual);

            [VtblIndex(14)]
            HRESULT lookupNamespaceURI(VARIANT* pvarPrefix, VARIANT* pvarNamespaceURI);

            [VtblIndex(15)]
            HRESULT lookupPrefix(VARIANT* pvarNamespaceURI, VARIANT* pvarPrefix);

            [VtblIndex(16)]
            HRESULT isDefaultNamespace(VARIANT* pvarNamespace, [NativeTypeName("VARIANT_BOOL *")] short* pfDefaultNamespace);

            [VtblIndex(17)]
            HRESULT appendChild(IHTMLDOMNode* newChild, IHTMLDOMNode** node);

            [VtblIndex(18)]
            HRESULT insertBefore(IHTMLDOMNode* newChild, VARIANT refChild, IHTMLDOMNode** node);

            [VtblIndex(19)]
            HRESULT removeChild(IHTMLDOMNode* oldChild, IHTMLDOMNode** node);

            [VtblIndex(20)]
            HRESULT replaceChild(IHTMLDOMNode* newChild, IHTMLDOMNode* oldChild, IHTMLDOMNode** node);

            [VtblIndex(21)]
            HRESULT isSameNode(IHTMLDOMNode3* otherNode, [NativeTypeName("VARIANT_BOOL *")] short* isSame);

            [VtblIndex(22)]
            HRESULT compareDocumentPosition(IHTMLDOMNode* otherNode, ushort* flags);

            [VtblIndex(23)]
            HRESULT isSupported([NativeTypeName("BSTR")] ushort* feature, VARIANT version, [NativeTypeName("VARIANT_BOOL *")] short* pfisSupported);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, uint, uint, ITypeInfo**, int> GetTypeInfo;

            [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

            [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT, int> put_prefix;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int> get_prefix;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int> get_localName;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int> get_namespaceURI;

            [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT, int> put_textContent;

            [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, int> get_textContent;

            [NativeTypeName("HRESULT (IHTMLDOMNode3 *, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode3*, short*, int> isEqualNode;

            [NativeTypeName("HRESULT (VARIANT *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, VARIANT*, int> lookupNamespaceURI;

            [NativeTypeName("HRESULT (VARIANT *, VARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, VARIANT*, int> lookupPrefix;

            [NativeTypeName("HRESULT (VARIANT *, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, VARIANT*, short*, int> isDefaultNamespace;

            [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode**, int> appendChild;

            [NativeTypeName("HRESULT (IHTMLDOMNode *, VARIANT, IHTMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, VARIANT, IHTMLDOMNode**, int> insertBefore;

            [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode**, int> removeChild;

            [NativeTypeName("HRESULT (IHTMLDOMNode *, IHTMLDOMNode *, IHTMLDOMNode **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, IHTMLDOMNode*, IHTMLDOMNode**, int> replaceChild;

            [NativeTypeName("HRESULT (IHTMLDOMNode3 *, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode3*, short*, int> isSameNode;

            [NativeTypeName("HRESULT (IHTMLDOMNode *, USHORT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, IHTMLDOMNode*, ushort*, int> compareDocumentPosition;

            [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLDOMNode3*, ushort*, VARIANT, short*, int> isSupported;
        }
    }
}
