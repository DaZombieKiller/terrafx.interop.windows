// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1093C18F-8D5E-43F0-B064-0917311B525E")]
    [NativeTypeName("struct IDWriteTextLayout2 : IDWriteTextLayout1")]
    [NativeInheritance("IDWriteTextLayout1")]
    public unsafe partial struct IDWriteTextLayout2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint>)(lpVtbl[1]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint>)(lpVtbl[2]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float, int>)(lpVtbl[8]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float>)(lpVtbl[16]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection(IDWriteFontCollection** fontCollection)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint>)(lpVtbl[20]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float>)(lpVtbl[25]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint>)(lpVtbl[26]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxWidth([NativeTypeName("FLOAT")] float maxWidth)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float, int>)(lpVtbl[28]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), maxWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxHeight([NativeTypeName("FLOAT")] float maxHeight)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float, int>)(lpVtbl[29]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), maxHeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontCollection(IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, IDWriteFontCollection*, DWRITE_TEXT_RANGE, int>)(lpVtbl[30]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontCollection, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[31]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int>)(lpVtbl[32]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontWeight, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int>)(lpVtbl[33]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontStyle, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int>)(lpVtbl[34]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontStretch, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontSize([NativeTypeName("FLOAT")] float fontSize, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float, DWRITE_TEXT_RANGE, int>)(lpVtbl[35]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int SetUnderline(BOOL hasUnderline, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, BOOL, DWRITE_TEXT_RANGE, int>)(lpVtbl[36]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int SetStrikethrough(BOOL hasStrikethrough, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, BOOL, DWRITE_TEXT_RANGE, int>)(lpVtbl[37]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int SetDrawingEffect(IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, IUnknown*, DWRITE_TEXT_RANGE, int>)(lpVtbl[38]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int SetInlineObject(IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, IDWriteInlineObject*, DWRITE_TEXT_RANGE, int>)(lpVtbl[39]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), inlineObject, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int SetTypography(IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, IDWriteTypography*, DWRITE_TEXT_RANGE, int>)(lpVtbl[40]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), typography, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[41]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), localeName, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("FLOAT")]
        public float GetMaxWidth()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float>)(lpVtbl[42]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("FLOAT")]
        public float GetMaxHeight()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float>)(lpVtbl[43]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, IDWriteFontCollection** fontCollection, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, IDWriteFontCollection**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[44]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[45]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[46]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_WEIGHT* fontWeight, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[47]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STYLE* fontStyle, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[48]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, DWRITE_FONT_STRETCH* fontStretch, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[49]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontSize([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* fontSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, float*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[50]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnderline([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasUnderline, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, BOOL*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[51]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, BOOL* hasStrikethrough, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, BOOL*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[52]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, IUnknown** drawingEffect, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, IUnknown**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[53]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, IDWriteInlineObject** inlineObject, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, IDWriteInlineObject**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[54]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypography([NativeTypeName("UINT32")] uint currentPosition, IDWriteTypography** typography, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, IDWriteTypography**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[55]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[56]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[57]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int Draw(void* clientDrawingContext, IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, void*, IDWriteTextRenderer*, float, float, int>)(lpVtbl[58]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(59)]
        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics(DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_LINE_METRICS*, uint, uint*, int>)(lpVtbl[59]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(60)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetrics(DWRITE_TEXT_METRICS* textMetrics)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_TEXT_METRICS*, int>)(lpVtbl[60]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(61)]
        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics(DWRITE_OVERHANG_METRICS* overhangs)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_OVERHANG_METRICS*, int>)(lpVtbl[61]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), overhangs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(62)]
        [return: NativeTypeName("HRESULT")]
        public int GetClusterMetrics(DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_CLUSTER_METRICS*, uint, uint*, int>)(lpVtbl[62]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(63)]
        [return: NativeTypeName("HRESULT")]
        public int DetermineMinWidth([NativeTypeName("FLOAT *")] float* minWidth)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float*, int>)(lpVtbl[63]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), minWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(64)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestPoint([NativeTypeName("FLOAT")] float pointX, [NativeTypeName("FLOAT")] float pointY, BOOL* isTrailingHit, BOOL* isInside, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float, float, BOOL*, BOOL*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[64]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(65)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, BOOL isTrailingHit, [NativeTypeName("FLOAT *")] float* pointX, [NativeTypeName("FLOAT *")] float* pointY, DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, BOOL, float*, float*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[65]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(66)]
        [return: NativeTypeName("HRESULT")]
        public int HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, uint, float, float, DWRITE_HIT_TEST_METRICS*, uint, uint*, int>)(lpVtbl[66]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(67)]
        [return: NativeTypeName("HRESULT")]
        public int SetPairKerning(BOOL isPairKerningEnabled, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, BOOL, DWRITE_TEXT_RANGE, int>)(lpVtbl[67]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), isPairKerningEnabled, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(68)]
        [return: NativeTypeName("HRESULT")]
        public int GetPairKerning([NativeTypeName("UINT32")] uint currentPosition, BOOL* isPairKerningEnabled, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, BOOL*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[68]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, isPairKerningEnabled, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(69)]
        [return: NativeTypeName("HRESULT")]
        public int SetCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, float, float, float, DWRITE_TEXT_RANGE, int>)(lpVtbl[69]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(70)]
        [return: NativeTypeName("HRESULT")]
        public int GetCharacterSpacing([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* leadingSpacing, [NativeTypeName("FLOAT *")] float* trailingSpacing, [NativeTypeName("FLOAT *")] float* minimumAdvanceWidth, DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, uint, float*, float*, float*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[70]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(71)]
        [return: NativeTypeName("HRESULT")]
        public int GetMetrics(DWRITE_TEXT_METRICS1* textMetrics)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_TEXT_METRICS1*, int>)(lpVtbl[71]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(72)]
        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int>)(lpVtbl[72]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(73)]
        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_VERTICAL_GLYPH_ORIENTATION>)(lpVtbl[73]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(74)]
        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping(BOOL isLastLineWrappingEnabled)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, BOOL, int>)(lpVtbl[74]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(75)]
        public BOOL GetLastLineWrapping()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, int>)(lpVtbl[75]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(76)]
        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_OPTICAL_ALIGNMENT, int>)(lpVtbl[76]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(77)]
        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, DWRITE_OPTICAL_ALIGNMENT>)(lpVtbl[77]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(78)]
        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback(IDWriteFontFallback* fontFallback)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, IDWriteFontFallback*, int>)(lpVtbl[78]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(79)]
        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback(IDWriteFontFallback** fontFallback)
        {
            return ((delegate* unmanaged<IDWriteTextLayout2*, IDWriteFontFallback**, int>)(lpVtbl[79]))((IDWriteTextLayout2*)Unsafe.AsPointer(ref this), fontFallback);
        }
    }
}
