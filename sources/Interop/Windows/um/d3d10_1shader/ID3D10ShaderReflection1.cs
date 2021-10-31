// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    [NativeTypeName("struct ID3D10ShaderReflection1 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID3D10ShaderReflection1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint>)(lpVtbl[1]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint>)(lpVtbl[2]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetDesc(D3D10_SHADER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, D3D10_SHADER_DESC*, int>)(lpVtbl[3]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByIndex([NativeTypeName("UINT")] uint Index)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint, ID3D10ShaderReflectionConstantBuffer*>)(lpVtbl[4]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), Index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public ID3D10ShaderReflectionConstantBuffer* GetConstantBufferByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, ID3D10ShaderReflectionConstantBuffer*>)(lpVtbl[5]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDesc([NativeTypeName("UINT")] uint ResourceIndex, D3D10_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[6]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), ResourceIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetInputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[7]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetOutputParameterDesc([NativeTypeName("UINT")] uint ParameterIndex, D3D10_SIGNATURE_PARAMETER_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint, D3D10_SIGNATURE_PARAMETER_DESC*, int>)(lpVtbl[8]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), ParameterIndex, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public ID3D10ShaderReflectionVariable* GetVariableByName([NativeTypeName("LPCSTR")] sbyte* Name)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, ID3D10ShaderReflectionVariable*>)(lpVtbl[9]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), Name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetResourceBindingDescByName([NativeTypeName("LPCSTR")] sbyte* Name, D3D10_SHADER_INPUT_BIND_DESC* pDesc)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, sbyte*, D3D10_SHADER_INPUT_BIND_DESC*, int>)(lpVtbl[10]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), Name, pDesc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int GetMovInstructionCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int>)(lpVtbl[11]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetMovcInstructionCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int>)(lpVtbl[12]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int GetConversionInstructionCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int>)(lpVtbl[13]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetBitwiseInstructionCount([NativeTypeName("UINT *")] uint* pCount)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, uint*, int>)(lpVtbl[14]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int GetGSInputPrimitive([NativeTypeName("D3D10_PRIMITIVE *")] D3D_PRIMITIVE* pPrim)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, D3D_PRIMITIVE*, int>)(lpVtbl[15]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pPrim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int IsLevel9Shader(BOOL* pbLevel9Shader)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, BOOL*, int>)(lpVtbl[16]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pbLevel9Shader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int IsSampleFrequencyShader(BOOL* pbSampleFrequency)
        {
            return ((delegate* unmanaged<ID3D10ShaderReflection1*, BOOL*, int>)(lpVtbl[17]))((ID3D10ShaderReflection1*)Unsafe.AsPointer(ref this), pbSampleFrequency);
        }
    }
}
