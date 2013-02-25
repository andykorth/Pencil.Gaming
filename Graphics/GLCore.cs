//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//



namespace Pencil.Gaming.Graphics {
    using System;
    using System.Security;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL {

        internal static partial class Core {

            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAccum", ExactSpelling = true)]
            internal extern static void Accum(Pencil.Gaming.Graphics.AccumOp op, Single value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveProgramEXT", ExactSpelling = true)]
            internal extern static void ActiveProgramEXT(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveShaderProgram", ExactSpelling = true)]
            internal extern static void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveStencilFaceEXT", ExactSpelling = true)]
            internal extern static void ActiveStencilFaceEXT(Pencil.Gaming.Graphics.ExtStencilTwoSide face);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal extern static void ActiveTexture(Pencil.Gaming.Graphics.TextureUnit texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveTextureARB", ExactSpelling = true)]
            internal extern static void ActiveTextureARB(Pencil.Gaming.Graphics.TextureUnit texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glActiveVaryingNV", ExactSpelling = true)]
            internal extern static void ActiveVaryingNV(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAlphaFragmentOp1ATI", ExactSpelling = true)]
            internal extern static void AlphaFragmentOp1ATI(Pencil.Gaming.Graphics.AtiFragmentShader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAlphaFragmentOp2ATI", ExactSpelling = true)]
            internal extern static void AlphaFragmentOp2ATI(Pencil.Gaming.Graphics.AtiFragmentShader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAlphaFragmentOp3ATI", ExactSpelling = true)]
            internal extern static void AlphaFragmentOp3ATI(Pencil.Gaming.Graphics.AtiFragmentShader op, UInt32 dst, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
            internal extern static void AlphaFunc(Pencil.Gaming.Graphics.AlphaFunction func, Single @ref);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glApplyTextureEXT", ExactSpelling = true)]
            internal extern static void ApplyTextureEXT(Pencil.Gaming.Graphics.ExtLightTexture mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAreProgramsResidentNV", ExactSpelling = true)]
            internal extern static unsafe bool AreProgramsResidentNV(Int32 n, UInt32* programs, [OutAttribute] bool* residences);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAreTexturesResident", ExactSpelling = true)]
            internal extern static unsafe bool AreTexturesResident(Int32 n, UInt32* textures, [OutAttribute] bool* residences);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAreTexturesResidentEXT", ExactSpelling = true)]
            internal extern static unsafe bool AreTexturesResidentEXT(Int32 n, UInt32* textures, [OutAttribute] bool* residences);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glArrayElement", ExactSpelling = true)]
            internal extern static void ArrayElement(Int32 i);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glArrayElementEXT", ExactSpelling = true)]
            internal extern static void ArrayElementEXT(Int32 i);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glArrayObjectATI", ExactSpelling = true)]
            internal extern static void ArrayObjectATI(Pencil.Gaming.Graphics.EnableCap array, Int32 size, Pencil.Gaming.Graphics.AtiVertexArrayObject type, Int32 stride, UInt32 buffer, UInt32 offset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAsyncMarkerSGIX", ExactSpelling = true)]
            internal extern static void AsyncMarkerSGIX(UInt32 marker);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAttachObjectARB", ExactSpelling = true)]
            internal extern static void AttachObjectARB(UInt32 containerObj, UInt32 obj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
            internal extern static void AttachShader(UInt32 program, UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBegin", ExactSpelling = true)]
            internal extern static void Begin(Pencil.Gaming.Graphics.BeginMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginConditionalRender", ExactSpelling = true)]
            internal extern static void BeginConditionalRender(UInt32 id, Pencil.Gaming.Graphics.ConditionalRenderType mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginConditionalRenderNV", ExactSpelling = true)]
            internal extern static void BeginConditionalRenderNV(UInt32 id, Pencil.Gaming.Graphics.NvConditionalRender mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginFragmentShaderATI", ExactSpelling = true)]
            internal extern static void BeginFragmentShaderATI();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginOcclusionQueryNV", ExactSpelling = true)]
            internal extern static void BeginOcclusionQueryNV(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginPerfMonitorAMD", ExactSpelling = true)]
            internal extern static void BeginPerfMonitorAMD(UInt32 monitor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
            internal extern static void BeginQuery(Pencil.Gaming.Graphics.QueryTarget target, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginQueryARB", ExactSpelling = true)]
            internal extern static void BeginQueryARB(Pencil.Gaming.Graphics.ArbOcclusionQuery target, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginQueryIndexed", ExactSpelling = true)]
            internal extern static void BeginQueryIndexed(Pencil.Gaming.Graphics.QueryTarget target, UInt32 index, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginTransformFeedback", ExactSpelling = true)]
            internal extern static void BeginTransformFeedback(Pencil.Gaming.Graphics.BeginFeedbackMode primitiveMode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginTransformFeedbackEXT", ExactSpelling = true)]
            internal extern static void BeginTransformFeedbackEXT(Pencil.Gaming.Graphics.ExtTransformFeedback primitiveMode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginTransformFeedbackNV", ExactSpelling = true)]
            internal extern static void BeginTransformFeedbackNV(Pencil.Gaming.Graphics.NvTransformFeedback primitiveMode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginVertexShaderEXT", ExactSpelling = true)]
            internal extern static void BeginVertexShaderEXT();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBeginVideoCaptureNV", ExactSpelling = true)]
            internal extern static void BeginVideoCaptureNV(UInt32 video_capture_slot);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
            internal extern static void BindAttribLocation(UInt32 program, UInt32 index, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindAttribLocationARB", ExactSpelling = true)]
            internal extern static void BindAttribLocationARB(UInt32 programObj, UInt32 index, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal extern static void BindBuffer(Pencil.Gaming.Graphics.BufferTarget target, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferARB", ExactSpelling = true)]
            internal extern static void BindBufferARB(Pencil.Gaming.Graphics.BufferTargetArb target, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferBase", ExactSpelling = true)]
            internal extern static void BindBufferBase(Pencil.Gaming.Graphics.BufferTarget target, UInt32 index, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferBaseEXT", ExactSpelling = true)]
            internal extern static void BindBufferBaseEXT(Pencil.Gaming.Graphics.ExtTransformFeedback target, UInt32 index, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferBaseNV", ExactSpelling = true)]
            internal extern static void BindBufferBaseNV(Pencil.Gaming.Graphics.NvTransformFeedback target, UInt32 index, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferOffsetEXT", ExactSpelling = true)]
            internal extern static void BindBufferOffsetEXT(Pencil.Gaming.Graphics.ExtTransformFeedback target, UInt32 index, UInt32 buffer, IntPtr offset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferOffsetNV", ExactSpelling = true)]
            internal extern static void BindBufferOffsetNV(Pencil.Gaming.Graphics.NvTransformFeedback target, UInt32 index, UInt32 buffer, IntPtr offset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferRange", ExactSpelling = true)]
            internal extern static void BindBufferRange(Pencil.Gaming.Graphics.BufferTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferRangeEXT", ExactSpelling = true)]
            internal extern static void BindBufferRangeEXT(Pencil.Gaming.Graphics.ExtTransformFeedback target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindBufferRangeNV", ExactSpelling = true)]
            internal extern static void BindBufferRangeNV(Pencil.Gaming.Graphics.NvTransformFeedback target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFragDataLocation", ExactSpelling = true)]
            internal extern static void BindFragDataLocation(UInt32 program, UInt32 color, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFragDataLocationEXT", ExactSpelling = true)]
            internal extern static void BindFragDataLocationEXT(UInt32 program, UInt32 color, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFragDataLocationIndexed", ExactSpelling = true)]
            internal extern static void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFragmentShaderATI", ExactSpelling = true)]
            internal extern static void BindFragmentShaderATI(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
            internal extern static void BindFramebuffer(Pencil.Gaming.Graphics.FramebufferTarget target, UInt32 framebuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindFramebufferEXT", ExactSpelling = true)]
            internal extern static void BindFramebufferEXT(Pencil.Gaming.Graphics.FramebufferTarget target, UInt32 framebuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindImageTextureEXT", ExactSpelling = true)]
            internal extern static void BindImageTextureEXT(UInt32 index, UInt32 texture, Int32 level, bool layered, Int32 layer, Pencil.Gaming.Graphics.ExtShaderImageLoadStore access, Int32 format);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindLightParameterEXT", ExactSpelling = true)]
            internal extern static Int32 BindLightParameterEXT(Pencil.Gaming.Graphics.LightName light, Pencil.Gaming.Graphics.LightParameter value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindMaterialParameterEXT", ExactSpelling = true)]
            internal extern static Int32 BindMaterialParameterEXT(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindMultiTextureEXT", ExactSpelling = true)]
            internal extern static void BindMultiTextureEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, UInt32 texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindParameterEXT", ExactSpelling = true)]
            internal extern static Int32 BindParameterEXT(Pencil.Gaming.Graphics.ExtVertexShader value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindProgramARB", ExactSpelling = true)]
            internal extern static void BindProgramARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindProgramNV", ExactSpelling = true)]
            internal extern static void BindProgramNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindProgramPipeline", ExactSpelling = true)]
            internal extern static void BindProgramPipeline(UInt32 pipeline);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
            internal extern static void BindRenderbuffer(Pencil.Gaming.Graphics.RenderbufferTarget target, UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindRenderbufferEXT", ExactSpelling = true)]
            internal extern static void BindRenderbufferEXT(Pencil.Gaming.Graphics.RenderbufferTarget target, UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindSampler", ExactSpelling = true)]
            internal extern static void BindSampler(UInt32 unit, UInt32 sampler);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTexGenParameterEXT", ExactSpelling = true)]
            internal extern static Int32 BindTexGenParameterEXT(Pencil.Gaming.Graphics.TextureUnit unit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal extern static void BindTexture(Pencil.Gaming.Graphics.TextureTarget target, UInt32 texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTextureEXT", ExactSpelling = true)]
            internal extern static void BindTextureEXT(Pencil.Gaming.Graphics.TextureTarget target, UInt32 texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTextureUnitParameterEXT", ExactSpelling = true)]
            internal extern static Int32 BindTextureUnitParameterEXT(Pencil.Gaming.Graphics.TextureUnit unit, Pencil.Gaming.Graphics.ExtVertexShader value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTransformFeedback", ExactSpelling = true)]
            internal extern static void BindTransformFeedback(Pencil.Gaming.Graphics.TransformFeedbackTarget target, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindTransformFeedbackNV", ExactSpelling = true)]
            internal extern static void BindTransformFeedbackNV(Pencil.Gaming.Graphics.NvTransformFeedback2 target, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVertexArray", ExactSpelling = true)]
            internal extern static void BindVertexArray(UInt32 array);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVertexArrayAPPLE", ExactSpelling = true)]
            internal extern static void BindVertexArrayAPPLE(UInt32 array);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVertexShaderEXT", ExactSpelling = true)]
            internal extern static void BindVertexShaderEXT(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVideoCaptureStreamBufferNV", ExactSpelling = true)]
            internal extern static void BindVideoCaptureStreamBufferNV(UInt32 video_capture_slot, UInt32 stream, Pencil.Gaming.Graphics.NvVideoCapture frame_region, IntPtr offset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBindVideoCaptureStreamTextureNV", ExactSpelling = true)]
            internal extern static void BindVideoCaptureStreamTextureNV(UInt32 video_capture_slot, UInt32 stream, Pencil.Gaming.Graphics.NvVideoCapture frame_region, Pencil.Gaming.Graphics.NvVideoCapture target, UInt32 texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3bEXT", ExactSpelling = true)]
            internal extern static void Binormal3bEXT(SByte bx, SByte by, SByte bz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3bvEXT", ExactSpelling = true)]
            internal extern static unsafe void Binormal3bvEXT(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3dEXT", ExactSpelling = true)]
            internal extern static void Binormal3dEXT(Double bx, Double by, Double bz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3dvEXT", ExactSpelling = true)]
            internal extern static unsafe void Binormal3dvEXT(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3fEXT", ExactSpelling = true)]
            internal extern static void Binormal3fEXT(Single bx, Single by, Single bz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void Binormal3fvEXT(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3iEXT", ExactSpelling = true)]
            internal extern static void Binormal3iEXT(Int32 bx, Int32 by, Int32 bz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3ivEXT", ExactSpelling = true)]
            internal extern static unsafe void Binormal3ivEXT(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3sEXT", ExactSpelling = true)]
            internal extern static void Binormal3sEXT(Int16 bx, Int16 by, Int16 bz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormal3svEXT", ExactSpelling = true)]
            internal extern static unsafe void Binormal3svEXT(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBinormalPointerEXT", ExactSpelling = true)]
            internal extern static void BinormalPointerEXT(Pencil.Gaming.Graphics.NormalPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBitmap", ExactSpelling = true)]
            internal extern static unsafe void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
            internal extern static void BlendColor(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendColorEXT", ExactSpelling = true)]
            internal extern static void BlendColorEXT(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
            internal extern static void BlendEquation(Pencil.Gaming.Graphics.BlendEquationMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationEXT", ExactSpelling = true)]
            internal extern static void BlendEquationEXT(Pencil.Gaming.Graphics.ExtBlendMinmax mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationi", ExactSpelling = true)]
            internal extern static void BlendEquationi(UInt32 buf, Pencil.Gaming.Graphics.Version40 mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationiARB", ExactSpelling = true)]
            internal extern static void BlendEquationiARB(UInt32 buf, Pencil.Gaming.Graphics.ArbDrawBuffersBlend mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationIndexedAMD", ExactSpelling = true)]
            internal extern static void BlendEquationIndexedAMD(UInt32 buf, Pencil.Gaming.Graphics.AmdDrawBuffersBlend mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
            internal extern static void BlendEquationSeparate(Pencil.Gaming.Graphics.BlendEquationMode modeRGB, Pencil.Gaming.Graphics.BlendEquationMode modeAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparateEXT", ExactSpelling = true)]
            internal extern static void BlendEquationSeparateEXT(Pencil.Gaming.Graphics.ExtBlendEquationSeparate modeRGB, Pencil.Gaming.Graphics.ExtBlendEquationSeparate modeAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparatei", ExactSpelling = true)]
            internal extern static void BlendEquationSeparatei(UInt32 buf, Pencil.Gaming.Graphics.BlendEquationMode modeRGB, Pencil.Gaming.Graphics.BlendEquationMode modeAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparateiARB", ExactSpelling = true)]
            internal extern static void BlendEquationSeparateiARB(UInt32 buf, Pencil.Gaming.Graphics.ArbDrawBuffersBlend modeRGB, Pencil.Gaming.Graphics.ArbDrawBuffersBlend modeAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendEquationSeparateIndexedAMD", ExactSpelling = true)]
            internal extern static void BlendEquationSeparateIndexedAMD(UInt32 buf, Pencil.Gaming.Graphics.AmdDrawBuffersBlend modeRGB, Pencil.Gaming.Graphics.AmdDrawBuffersBlend modeAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal extern static void BlendFunc(Pencil.Gaming.Graphics.BlendingFactorSrc sfactor, Pencil.Gaming.Graphics.BlendingFactorDest dfactor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFunci", ExactSpelling = true)]
            internal extern static void BlendFunci(UInt32 buf, Pencil.Gaming.Graphics.Version40 src, Pencil.Gaming.Graphics.Version40 dst);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFunciARB", ExactSpelling = true)]
            internal extern static void BlendFunciARB(UInt32 buf, Pencil.Gaming.Graphics.ArbDrawBuffersBlend src, Pencil.Gaming.Graphics.ArbDrawBuffersBlend dst);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncIndexedAMD", ExactSpelling = true)]
            internal extern static void BlendFuncIndexedAMD(UInt32 buf, Pencil.Gaming.Graphics.AmdDrawBuffersBlend src, Pencil.Gaming.Graphics.AmdDrawBuffersBlend dst);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
            internal extern static void BlendFuncSeparate(Pencil.Gaming.Graphics.BlendingFactorSrc sfactorRGB, Pencil.Gaming.Graphics.BlendingFactorDest dfactorRGB, Pencil.Gaming.Graphics.BlendingFactorSrc sfactorAlpha, Pencil.Gaming.Graphics.BlendingFactorDest dfactorAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparateEXT", ExactSpelling = true)]
            internal extern static void BlendFuncSeparateEXT(Pencil.Gaming.Graphics.ExtBlendFuncSeparate sfactorRGB, Pencil.Gaming.Graphics.ExtBlendFuncSeparate dfactorRGB, Pencil.Gaming.Graphics.ExtBlendFuncSeparate sfactorAlpha, Pencil.Gaming.Graphics.ExtBlendFuncSeparate dfactorAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparatei", ExactSpelling = true)]
            internal extern static void BlendFuncSeparatei(UInt32 buf, Pencil.Gaming.Graphics.Version40 srcRGB, Pencil.Gaming.Graphics.Version40 dstRGB, Pencil.Gaming.Graphics.Version40 srcAlpha, Pencil.Gaming.Graphics.Version40 dstAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparateiARB", ExactSpelling = true)]
            internal extern static void BlendFuncSeparateiARB(UInt32 buf, Pencil.Gaming.Graphics.ArbDrawBuffersBlend srcRGB, Pencil.Gaming.Graphics.ArbDrawBuffersBlend dstRGB, Pencil.Gaming.Graphics.ArbDrawBuffersBlend srcAlpha, Pencil.Gaming.Graphics.ArbDrawBuffersBlend dstAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparateIndexedAMD", ExactSpelling = true)]
            internal extern static void BlendFuncSeparateIndexedAMD(UInt32 buf, Pencil.Gaming.Graphics.AmdDrawBuffersBlend srcRGB, Pencil.Gaming.Graphics.AmdDrawBuffersBlend dstRGB, Pencil.Gaming.Graphics.AmdDrawBuffersBlend srcAlpha, Pencil.Gaming.Graphics.AmdDrawBuffersBlend dstAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlendFuncSeparateINGR", ExactSpelling = true)]
            internal extern static void BlendFuncSeparateINGR(Pencil.Gaming.Graphics.All sfactorRGB, Pencil.Gaming.Graphics.All dfactorRGB, Pencil.Gaming.Graphics.All sfactorAlpha, Pencil.Gaming.Graphics.All dfactorAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlitFramebuffer", ExactSpelling = true)]
            internal extern static void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, Pencil.Gaming.Graphics.ClearBufferMask mask, Pencil.Gaming.Graphics.BlitFramebufferFilter filter);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBlitFramebufferEXT", ExactSpelling = true)]
            internal extern static void BlitFramebufferEXT(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, Pencil.Gaming.Graphics.ClearBufferMask mask, Pencil.Gaming.Graphics.ExtFramebufferBlit filter);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferAddressRangeNV", ExactSpelling = true)]
            internal extern static void BufferAddressRangeNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory pname, UInt32 index, UInt64 address, IntPtr length);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal extern static void BufferData(Pencil.Gaming.Graphics.BufferTarget target, IntPtr size, IntPtr data, Pencil.Gaming.Graphics.BufferUsageHint usage);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferDataARB", ExactSpelling = true)]
            internal extern static void BufferDataARB(Pencil.Gaming.Graphics.BufferTargetArb target, IntPtr size, IntPtr data, Pencil.Gaming.Graphics.BufferUsageArb usage);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferParameteriAPPLE", ExactSpelling = true)]
            internal extern static void BufferParameteriAPPLE(Pencil.Gaming.Graphics.BufferTarget target, Pencil.Gaming.Graphics.BufferParameterApple pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal extern static void BufferSubData(Pencil.Gaming.Graphics.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glBufferSubDataARB", ExactSpelling = true)]
            internal extern static void BufferSubDataARB(Pencil.Gaming.Graphics.BufferTargetArb target, IntPtr offset, IntPtr size, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCallList", ExactSpelling = true)]
            internal extern static void CallList(UInt32 list);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCallLists", ExactSpelling = true)]
            internal extern static void CallLists(Int32 n, Pencil.Gaming.Graphics.ListNameType type, IntPtr lists);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
            internal extern static Pencil.Gaming.Graphics.FramebufferErrorCode CheckFramebufferStatus(Pencil.Gaming.Graphics.FramebufferTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCheckFramebufferStatusEXT", ExactSpelling = true)]
            internal extern static Pencil.Gaming.Graphics.FramebufferErrorCode CheckFramebufferStatusEXT(Pencil.Gaming.Graphics.FramebufferTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCheckNamedFramebufferStatusEXT", ExactSpelling = true)]
            internal extern static Pencil.Gaming.Graphics.ExtDirectStateAccess CheckNamedFramebufferStatusEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClampColor", ExactSpelling = true)]
            internal extern static void ClampColor(Pencil.Gaming.Graphics.ClampColorTarget target, Pencil.Gaming.Graphics.ClampColorMode clamp);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClampColorARB", ExactSpelling = true)]
            internal extern static void ClampColorARB(Pencil.Gaming.Graphics.ArbColorBufferFloat target, Pencil.Gaming.Graphics.ArbColorBufferFloat clamp);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal extern static void Clear(Pencil.Gaming.Graphics.ClearBufferMask mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearAccum", ExactSpelling = true)]
            internal extern static void ClearAccum(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferfi", ExactSpelling = true)]
            internal extern static void ClearBufferfi(Pencil.Gaming.Graphics.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferfv", ExactSpelling = true)]
            internal extern static unsafe void ClearBufferfv(Pencil.Gaming.Graphics.ClearBuffer buffer, Int32 drawbuffer, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferiv", ExactSpelling = true)]
            internal extern static unsafe void ClearBufferiv(Pencil.Gaming.Graphics.ClearBuffer buffer, Int32 drawbuffer, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearBufferuiv", ExactSpelling = true)]
            internal extern static unsafe void ClearBufferuiv(Pencil.Gaming.Graphics.ClearBuffer buffer, Int32 drawbuffer, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal extern static void ClearColor(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearColorIiEXT", ExactSpelling = true)]
            internal extern static void ClearColorIiEXT(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearColorIuiEXT", ExactSpelling = true)]
            internal extern static void ClearColorIuiEXT(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
            internal extern static void ClearDepth(Double depth);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepthdNV", ExactSpelling = true)]
            internal extern static void ClearDepthdNV(Double depth);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal extern static void ClearDepthf(Single d);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearIndex", ExactSpelling = true)]
            internal extern static void ClearIndex(Single c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal extern static void ClearStencil(Int32 s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
            internal extern static void ClientActiveTexture(Pencil.Gaming.Graphics.TextureUnit texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientActiveTextureARB", ExactSpelling = true)]
            internal extern static void ClientActiveTextureARB(Pencil.Gaming.Graphics.TextureUnit texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientActiveVertexStreamATI", ExactSpelling = true)]
            internal extern static void ClientActiveVertexStreamATI(Pencil.Gaming.Graphics.AtiVertexStreams stream);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientAttribDefaultEXT", ExactSpelling = true)]
            internal extern static void ClientAttribDefaultEXT(Pencil.Gaming.Graphics.ClientAttribMask mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClientWaitSync", ExactSpelling = true)]
            internal extern static Pencil.Gaming.Graphics.ArbSync ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glClipPlane", ExactSpelling = true)]
            internal extern static unsafe void ClipPlane(Pencil.Gaming.Graphics.ClipPlaneName plane, Double* equation);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3b", ExactSpelling = true)]
            internal extern static void Color3b(SByte red, SByte green, SByte blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3bv", ExactSpelling = true)]
            internal extern static unsafe void Color3bv(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3d", ExactSpelling = true)]
            internal extern static void Color3d(Double red, Double green, Double blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3dv", ExactSpelling = true)]
            internal extern static unsafe void Color3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3f", ExactSpelling = true)]
            internal extern static void Color3f(Single red, Single green, Single blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3fv", ExactSpelling = true)]
            internal extern static unsafe void Color3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void Color3fVertex3fSUN(Single r, Single g, Single b, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void Color3fVertex3fvSUN(Single* c, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3i", ExactSpelling = true)]
            internal extern static void Color3i(Int32 red, Int32 green, Int32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3iv", ExactSpelling = true)]
            internal extern static unsafe void Color3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3s", ExactSpelling = true)]
            internal extern static void Color3s(Int16 red, Int16 green, Int16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3sv", ExactSpelling = true)]
            internal extern static unsafe void Color3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3ub", ExactSpelling = true)]
            internal extern static void Color3ub(Byte red, Byte green, Byte blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3ubv", ExactSpelling = true)]
            internal extern static unsafe void Color3ubv(Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3ui", ExactSpelling = true)]
            internal extern static void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3uiv", ExactSpelling = true)]
            internal extern static unsafe void Color3uiv(UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3us", ExactSpelling = true)]
            internal extern static void Color3us(UInt16 red, UInt16 green, UInt16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor3usv", ExactSpelling = true)]
            internal extern static unsafe void Color3usv(UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4b", ExactSpelling = true)]
            internal extern static void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4bv", ExactSpelling = true)]
            internal extern static unsafe void Color4bv(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4d", ExactSpelling = true)]
            internal extern static void Color4d(Double red, Double green, Double blue, Double alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4dv", ExactSpelling = true)]
            internal extern static unsafe void Color4dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4f", ExactSpelling = true)]
            internal extern static void Color4f(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void Color4fNormal3fVertex3fSUN(Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void Color4fNormal3fVertex3fvSUN(Single* c, Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4fv", ExactSpelling = true)]
            internal extern static unsafe void Color4fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4i", ExactSpelling = true)]
            internal extern static void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4iv", ExactSpelling = true)]
            internal extern static unsafe void Color4iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4s", ExactSpelling = true)]
            internal extern static void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4sv", ExactSpelling = true)]
            internal extern static unsafe void Color4sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4ub", ExactSpelling = true)]
            internal extern static void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4ubv", ExactSpelling = true)]
            internal extern static unsafe void Color4ubv(Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4ubVertex2fSUN", ExactSpelling = true)]
            internal extern static void Color4ubVertex2fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4ubVertex2fvSUN", ExactSpelling = true)]
            internal extern static unsafe void Color4ubVertex2fvSUN(Byte* c, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4ubVertex3fSUN", ExactSpelling = true)]
            internal extern static void Color4ubVertex3fSUN(Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4ubVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void Color4ubVertex3fvSUN(Byte* c, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4ui", ExactSpelling = true)]
            internal extern static void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4uiv", ExactSpelling = true)]
            internal extern static unsafe void Color4uiv(UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4us", ExactSpelling = true)]
            internal extern static void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColor4usv", ExactSpelling = true)]
            internal extern static unsafe void Color4usv(UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorFormatNV", ExactSpelling = true)]
            internal extern static void ColorFormatNV(Int32 size, Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorFragmentOp1ATI", ExactSpelling = true)]
            internal extern static void ColorFragmentOp1ATI(Pencil.Gaming.Graphics.AtiFragmentShader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorFragmentOp2ATI", ExactSpelling = true)]
            internal extern static void ColorFragmentOp2ATI(Pencil.Gaming.Graphics.AtiFragmentShader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorFragmentOp3ATI", ExactSpelling = true)]
            internal extern static void ColorFragmentOp3ATI(Pencil.Gaming.Graphics.AtiFragmentShader op, UInt32 dst, UInt32 dstMask, UInt32 dstMod, UInt32 arg1, UInt32 arg1Rep, UInt32 arg1Mod, UInt32 arg2, UInt32 arg2Rep, UInt32 arg2Mod, UInt32 arg3, UInt32 arg3Rep, UInt32 arg3Mod);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal extern static void ColorMask(bool red, bool green, bool blue, bool alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorMaski", ExactSpelling = true)]
            internal extern static void ColorMaski(UInt32 index, bool r, bool g, bool b, bool a);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorMaskIndexedEXT", ExactSpelling = true)]
            internal extern static void ColorMaskIndexedEXT(UInt32 index, bool r, bool g, bool b, bool a);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorMaterial", ExactSpelling = true)]
            internal extern static void ColorMaterial(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.ColorMaterialParameter mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorP3ui", ExactSpelling = true)]
            internal extern static void ColorP3ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 color);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorP3uiv", ExactSpelling = true)]
            internal extern static unsafe void ColorP3uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* color);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorP4ui", ExactSpelling = true)]
            internal extern static void ColorP4ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 color);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorP4uiv", ExactSpelling = true)]
            internal extern static unsafe void ColorP4uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* color);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
            internal extern static void ColorPointer(Int32 size, Pencil.Gaming.Graphics.ColorPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorPointerEXT", ExactSpelling = true)]
            internal extern static void ColorPointerEXT(Int32 size, Pencil.Gaming.Graphics.ColorPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorPointerListIBM", ExactSpelling = true)]
            internal extern static void ColorPointerListIBM(Int32 size, Pencil.Gaming.Graphics.ColorPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorPointervINTEL", ExactSpelling = true)]
            internal extern static void ColorPointervINTEL(Int32 size, Pencil.Gaming.Graphics.VertexPointerType type, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorSubTable", ExactSpelling = true)]
            internal extern static void ColorSubTable(Pencil.Gaming.Graphics.ColorTableTarget target, Int32 start, Int32 count, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorSubTableEXT", ExactSpelling = true)]
            internal extern static void ColorSubTableEXT(Pencil.Gaming.Graphics.ColorTableTarget target, Int32 start, Int32 count, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTable", ExactSpelling = true)]
            internal extern static void ColorTable(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr table);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTableEXT", ExactSpelling = true)]
            internal extern static void ColorTableEXT(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalFormat, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr table);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTableParameterfv", ExactSpelling = true)]
            internal extern static unsafe void ColorTableParameterfv(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.ColorTableParameterPName pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTableParameterfvSGI", ExactSpelling = true)]
            internal extern static unsafe void ColorTableParameterfvSGI(Pencil.Gaming.Graphics.SgiColorTable target, Pencil.Gaming.Graphics.SgiColorTable pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTableParameteriv", ExactSpelling = true)]
            internal extern static unsafe void ColorTableParameteriv(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.ColorTableParameterPName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTableParameterivSGI", ExactSpelling = true)]
            internal extern static unsafe void ColorTableParameterivSGI(Pencil.Gaming.Graphics.SgiColorTable target, Pencil.Gaming.Graphics.SgiColorTable pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glColorTableSGI", ExactSpelling = true)]
            internal extern static void ColorTableSGI(Pencil.Gaming.Graphics.SgiColorTable target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr table);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCombinerInputNV", ExactSpelling = true)]
            internal extern static void CombinerInputNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage, Pencil.Gaming.Graphics.NvRegisterCombiners portion, Pencil.Gaming.Graphics.NvRegisterCombiners variable, Pencil.Gaming.Graphics.NvRegisterCombiners input, Pencil.Gaming.Graphics.NvRegisterCombiners mapping, Pencil.Gaming.Graphics.NvRegisterCombiners componentUsage);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCombinerOutputNV", ExactSpelling = true)]
            internal extern static void CombinerOutputNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage, Pencil.Gaming.Graphics.NvRegisterCombiners portion, Pencil.Gaming.Graphics.NvRegisterCombiners abOutput, Pencil.Gaming.Graphics.NvRegisterCombiners cdOutput, Pencil.Gaming.Graphics.NvRegisterCombiners sumOutput, Pencil.Gaming.Graphics.NvRegisterCombiners scale, Pencil.Gaming.Graphics.NvRegisterCombiners bias, bool abDotProduct, bool cdDotProduct, bool muxSum);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCombinerParameterfNV", ExactSpelling = true)]
            internal extern static void CombinerParameterfNV(Pencil.Gaming.Graphics.NvRegisterCombiners pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCombinerParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void CombinerParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCombinerParameteriNV", ExactSpelling = true)]
            internal extern static void CombinerParameteriNV(Pencil.Gaming.Graphics.NvRegisterCombiners pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCombinerParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void CombinerParameterivNV(Pencil.Gaming.Graphics.NvRegisterCombiners pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCombinerStageParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void CombinerStageParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners2 stage, Pencil.Gaming.Graphics.NvRegisterCombiners2 pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
            internal extern static void CompileShader(UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompileShaderARB", ExactSpelling = true)]
            internal extern static void CompileShaderARB(UInt32 shaderObj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompileShaderIncludeARB", ExactSpelling = true)]
            internal extern static unsafe void CompileShaderIncludeARB(UInt32 shader, Int32 count, String[] path, Int32* length);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedMultiTexImage1DEXT", ExactSpelling = true)]
            internal extern static void CompressedMultiTexImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedMultiTexImage2DEXT", ExactSpelling = true)]
            internal extern static void CompressedMultiTexImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedMultiTexImage3DEXT", ExactSpelling = true)]
            internal extern static void CompressedMultiTexImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedMultiTexSubImage1DEXT", ExactSpelling = true)]
            internal extern static void CompressedMultiTexSubImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedMultiTexSubImage2DEXT", ExactSpelling = true)]
            internal extern static void CompressedMultiTexSubImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedMultiTexSubImage3DEXT", ExactSpelling = true)]
            internal extern static void CompressedMultiTexSubImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
            internal extern static void CompressedTexImage1D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage1DARB", ExactSpelling = true)]
            internal extern static void CompressedTexImage1DARB(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexImage2D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage2DARB", ExactSpelling = true)]
            internal extern static void CompressedTexImage2DARB(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
            internal extern static void CompressedTexImage3D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexImage3DARB", ExactSpelling = true)]
            internal extern static void CompressedTexImage3DARB(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage1DARB", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage1DARB(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage2DARB", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2DARB(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTexSubImage3DARB", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage3DARB(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTextureImage1DEXT", ExactSpelling = true)]
            internal extern static void CompressedTextureImage1DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTextureImage2DEXT", ExactSpelling = true)]
            internal extern static void CompressedTextureImage2DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTextureImage3DEXT", ExactSpelling = true)]
            internal extern static void CompressedTextureImage3DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTextureSubImage1DEXT", ExactSpelling = true)]
            internal extern static void CompressedTextureSubImage1DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTextureSubImage2DEXT", ExactSpelling = true)]
            internal extern static void CompressedTextureSubImage2DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCompressedTextureSubImage3DEXT", ExactSpelling = true)]
            internal extern static void CompressedTextureSubImage3DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Pencil.Gaming.Graphics.PixelFormat format, Int32 imageSize, IntPtr bits);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionFilter1D", ExactSpelling = true)]
            internal extern static void ConvolutionFilter1D(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionFilter1DEXT", ExactSpelling = true)]
            internal extern static void ConvolutionFilter1DEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionFilter2D", ExactSpelling = true)]
            internal extern static void ConvolutionFilter2D(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionFilter2DEXT", ExactSpelling = true)]
            internal extern static void ConvolutionFilter2DEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterf", ExactSpelling = true)]
            internal extern static void ConvolutionParameterf(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.ConvolutionParameter pname, Single @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterfEXT", ExactSpelling = true)]
            internal extern static void ConvolutionParameterfEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.ExtConvolution pname, Single @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterfv", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameterfv(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.ConvolutionParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameterfvEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.ExtConvolution pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameteri", ExactSpelling = true)]
            internal extern static void ConvolutionParameteri(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.ConvolutionParameter pname, Int32 @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameteriEXT", ExactSpelling = true)]
            internal extern static void ConvolutionParameteriEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.ExtConvolution pname, Int32 @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameteriv", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameteriv(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.ConvolutionParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glConvolutionParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void ConvolutionParameterivEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.ExtConvolution pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyBufferSubData", ExactSpelling = true)]
            internal extern static void CopyBufferSubData(Pencil.Gaming.Graphics.BufferTarget readTarget, Pencil.Gaming.Graphics.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyColorSubTable", ExactSpelling = true)]
            internal extern static void CopyColorSubTable(Pencil.Gaming.Graphics.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyColorSubTableEXT", ExactSpelling = true)]
            internal extern static void CopyColorSubTableEXT(Pencil.Gaming.Graphics.ColorTableTarget target, Int32 start, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyColorTable", ExactSpelling = true)]
            internal extern static void CopyColorTable(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyColorTableSGI", ExactSpelling = true)]
            internal extern static void CopyColorTableSGI(Pencil.Gaming.Graphics.SgiColorTable target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyConvolutionFilter1D", ExactSpelling = true)]
            internal extern static void CopyConvolutionFilter1D(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyConvolutionFilter1DEXT", ExactSpelling = true)]
            internal extern static void CopyConvolutionFilter1DEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyConvolutionFilter2D", ExactSpelling = true)]
            internal extern static void CopyConvolutionFilter2D(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyConvolutionFilter2DEXT", ExactSpelling = true)]
            internal extern static void CopyConvolutionFilter2DEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyImageSubDataNV", ExactSpelling = true)]
            internal extern static void CopyImageSubDataNV(UInt32 srcName, Pencil.Gaming.Graphics.NvCopyImage srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, Pencil.Gaming.Graphics.NvCopyImage dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 width, Int32 height, Int32 depth);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyMultiTexImage1DEXT", ExactSpelling = true)]
            internal extern static void CopyMultiTexImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyMultiTexImage2DEXT", ExactSpelling = true)]
            internal extern static void CopyMultiTexImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyMultiTexSubImage1DEXT", ExactSpelling = true)]
            internal extern static void CopyMultiTexSubImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyMultiTexSubImage2DEXT", ExactSpelling = true)]
            internal extern static void CopyMultiTexSubImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyMultiTexSubImage3DEXT", ExactSpelling = true)]
            internal extern static void CopyMultiTexSubImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyPixels", ExactSpelling = true)]
            internal extern static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelCopyType type);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
            internal extern static void CopyTexImage1D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexImage1DEXT", ExactSpelling = true)]
            internal extern static void CopyTexImage1DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal extern static void CopyTexImage2D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexImage2DEXT", ExactSpelling = true)]
            internal extern static void CopyTexImage2DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage1DEXT", ExactSpelling = true)]
            internal extern static void CopyTexSubImage1DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage2DEXT", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTexSubImage3DEXT", ExactSpelling = true)]
            internal extern static void CopyTexSubImage3DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTextureImage1DEXT", ExactSpelling = true)]
            internal extern static void CopyTextureImage1DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTextureImage2DEXT", ExactSpelling = true)]
            internal extern static void CopyTextureImage2DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTextureSubImage1DEXT", ExactSpelling = true)]
            internal extern static void CopyTextureSubImage1DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTextureSubImage2DEXT", ExactSpelling = true)]
            internal extern static void CopyTextureSubImage2DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCopyTextureSubImage3DEXT", ExactSpelling = true)]
            internal extern static void CopyTextureSubImage3DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
            internal extern static Int32 CreateProgram();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateProgramObjectARB", ExactSpelling = true)]
            internal extern static Int32 CreateProgramObjectARB();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
            internal extern static Int32 CreateShader(Pencil.Gaming.Graphics.ShaderType type);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShaderObjectARB", ExactSpelling = true)]
            internal extern static Int32 CreateShaderObjectARB(Pencil.Gaming.Graphics.ArbShaderObjects shaderType);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShaderProgramEXT", ExactSpelling = true)]
            internal extern static Int32 CreateShaderProgramEXT(Pencil.Gaming.Graphics.ExtSeparateShaderObjects type, String @string);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateShaderProgramv", ExactSpelling = true)]
            internal extern static Int32 CreateShaderProgramv(Pencil.Gaming.Graphics.ShaderType type, Int32 count, String[] strings);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCreateSyncFromCLeventARB", ExactSpelling = true)]
            internal extern static IntPtr CreateSyncFromCLeventARB(IntPtr context, IntPtr @event, UInt32 flags);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal extern static void CullFace(Pencil.Gaming.Graphics.CullFaceMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCullParameterdvEXT", ExactSpelling = true)]
            internal extern static unsafe void CullParameterdvEXT(Pencil.Gaming.Graphics.ExtCullVertex pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCullParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void CullParameterfvEXT(Pencil.Gaming.Graphics.ExtCullVertex pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glCurrentPaletteMatrixARB", ExactSpelling = true)]
            internal extern static void CurrentPaletteMatrixARB(Int32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageCallbackAMD", ExactSpelling = true)]
            internal extern static void DebugMessageCallbackAMD(DebugProcAmd callback, [OutAttribute] IntPtr userParam);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageCallbackARB", ExactSpelling = true)]
            internal extern static void DebugMessageCallbackARB(DebugProcArb callback, IntPtr userParam);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageControlARB", ExactSpelling = true)]
            internal extern static unsafe void DebugMessageControlARB(Pencil.Gaming.Graphics.ArbDebugOutput source, Pencil.Gaming.Graphics.ArbDebugOutput type, Pencil.Gaming.Graphics.ArbDebugOutput severity, Int32 count, UInt32* ids, bool enabled);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageEnableAMD", ExactSpelling = true)]
            internal extern static unsafe void DebugMessageEnableAMD(Pencil.Gaming.Graphics.AmdDebugOutput category, Pencil.Gaming.Graphics.AmdDebugOutput severity, Int32 count, UInt32* ids, bool enabled);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageInsertAMD", ExactSpelling = true)]
            internal extern static void DebugMessageInsertAMD(Pencil.Gaming.Graphics.AmdDebugOutput category, Pencil.Gaming.Graphics.AmdDebugOutput severity, UInt32 id, Int32 length, String buf);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDebugMessageInsertARB", ExactSpelling = true)]
            internal extern static void DebugMessageInsertARB(Pencil.Gaming.Graphics.ArbDebugOutput source, Pencil.Gaming.Graphics.ArbDebugOutput type, UInt32 id, Pencil.Gaming.Graphics.ArbDebugOutput severity, Int32 length, String buf);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeformationMap3dSGIX", ExactSpelling = true)]
            internal extern static unsafe void DeformationMap3dSGIX(Pencil.Gaming.Graphics.SgixPolynomialFfd target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double w1, Double w2, Int32 wstride, Int32 worder, Double* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeformationMap3fSGIX", ExactSpelling = true)]
            internal extern static unsafe void DeformationMap3fSGIX(Pencil.Gaming.Graphics.SgixPolynomialFfd target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single w1, Single w2, Int32 wstride, Int32 worder, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeformSGIX", ExactSpelling = true)]
            internal extern static void DeformSGIX(UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteAsyncMarkersSGIX", ExactSpelling = true)]
            internal extern static void DeleteAsyncMarkersSGIX(UInt32 marker, Int32 range);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteBuffers(Int32 n, UInt32* buffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteBuffersARB", ExactSpelling = true)]
            internal extern static unsafe void DeleteBuffersARB(Int32 n, UInt32* buffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFencesAPPLE", ExactSpelling = true)]
            internal extern static unsafe void DeleteFencesAPPLE(Int32 n, UInt32* fences);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFencesNV", ExactSpelling = true)]
            internal extern static unsafe void DeleteFencesNV(Int32 n, UInt32* fences);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFragmentShaderATI", ExactSpelling = true)]
            internal extern static void DeleteFragmentShaderATI(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteFramebuffers(Int32 n, UInt32* framebuffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteFramebuffersEXT", ExactSpelling = true)]
            internal extern static unsafe void DeleteFramebuffersEXT(Int32 n, UInt32* framebuffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteLists", ExactSpelling = true)]
            internal extern static void DeleteLists(UInt32 list, Int32 range);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteNamedStringARB", ExactSpelling = true)]
            internal extern static void DeleteNamedStringARB(Int32 namelen, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteNamesAMD", ExactSpelling = true)]
            internal extern static unsafe void DeleteNamesAMD(Pencil.Gaming.Graphics.AmdNameGenDelete identifier, UInt32 num, UInt32* names);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteObjectARB", ExactSpelling = true)]
            internal extern static void DeleteObjectARB(UInt32 obj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteOcclusionQueriesNV", ExactSpelling = true)]
            internal extern static unsafe void DeleteOcclusionQueriesNV(Int32 n, UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeletePerfMonitorsAMD", ExactSpelling = true)]
            internal extern static unsafe void DeletePerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
            internal extern static void DeleteProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteProgramPipelines", ExactSpelling = true)]
            internal extern static unsafe void DeleteProgramPipelines(Int32 n, UInt32* pipelines);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteProgramsARB", ExactSpelling = true)]
            internal extern static unsafe void DeleteProgramsARB(Int32 n, UInt32* programs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteProgramsNV", ExactSpelling = true)]
            internal extern static unsafe void DeleteProgramsNV(Int32 n, UInt32* programs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
            internal extern static unsafe void DeleteQueries(Int32 n, UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteQueriesARB", ExactSpelling = true)]
            internal extern static unsafe void DeleteQueriesARB(Int32 n, UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
            internal extern static unsafe void DeleteRenderbuffers(Int32 n, UInt32* renderbuffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteRenderbuffersEXT", ExactSpelling = true)]
            internal extern static unsafe void DeleteRenderbuffersEXT(Int32 n, UInt32* renderbuffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteSamplers", ExactSpelling = true)]
            internal extern static unsafe void DeleteSamplers(Int32 count, UInt32* samplers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
            internal extern static void DeleteShader(UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteSync", ExactSpelling = true)]
            internal extern static void DeleteSync(IntPtr sync);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal extern static unsafe void DeleteTextures(Int32 n, UInt32* textures);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteTexturesEXT", ExactSpelling = true)]
            internal extern static unsafe void DeleteTexturesEXT(Int32 n, UInt32* textures);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteTransformFeedbacks", ExactSpelling = true)]
            internal extern static unsafe void DeleteTransformFeedbacks(Int32 n, UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteTransformFeedbacksNV", ExactSpelling = true)]
            internal extern static unsafe void DeleteTransformFeedbacksNV(Int32 n, UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteVertexArrays", ExactSpelling = true)]
            internal extern static unsafe void DeleteVertexArrays(Int32 n, UInt32* arrays);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteVertexArraysAPPLE", ExactSpelling = true)]
            internal extern static unsafe void DeleteVertexArraysAPPLE(Int32 n, UInt32* arrays);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDeleteVertexShaderEXT", ExactSpelling = true)]
            internal extern static void DeleteVertexShaderEXT(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthBoundsdNV", ExactSpelling = true)]
            internal extern static void DepthBoundsdNV(Double zmin, Double zmax);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthBoundsEXT", ExactSpelling = true)]
            internal extern static void DepthBoundsEXT(Double zmin, Double zmax);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal extern static void DepthFunc(Pencil.Gaming.Graphics.DepthFunction func);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal extern static void DepthMask(bool flag);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
            internal extern static void DepthRange(Double near, Double far);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangeArrayv", ExactSpelling = true)]
            internal extern static unsafe void DepthRangeArrayv(UInt32 first, Int32 count, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangedNV", ExactSpelling = true)]
            internal extern static void DepthRangedNV(Double zNear, Double zFar);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal extern static void DepthRangef(Single n, Single f);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDepthRangeIndexed", ExactSpelling = true)]
            internal extern static void DepthRangeIndexed(UInt32 index, Double n, Double f);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDetachObjectARB", ExactSpelling = true)]
            internal extern static void DetachObjectARB(UInt32 containerObj, UInt32 attachedObj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
            internal extern static void DetachShader(UInt32 program, UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDetailTexFuncSGIS", ExactSpelling = true)]
            internal extern static unsafe void DetailTexFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target, Int32 n, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal extern static void Disable(Pencil.Gaming.Graphics.EnableCap cap);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
            internal extern static void DisableClientState(Pencil.Gaming.Graphics.ArrayCap array);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableClientStateIndexedEXT", ExactSpelling = true)]
            internal extern static void DisableClientStateIndexedEXT(Pencil.Gaming.Graphics.EnableCap array, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisablei", ExactSpelling = true)]
            internal extern static void Disablei(Pencil.Gaming.Graphics.IndexedEnableCap target, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableIndexedEXT", ExactSpelling = true)]
            internal extern static void DisableIndexedEXT(Pencil.Gaming.Graphics.IndexedEnableCap target, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableVariantClientStateEXT", ExactSpelling = true)]
            internal extern static void DisableVariantClientStateEXT(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableVertexAttribAPPLE", ExactSpelling = true)]
            internal extern static void DisableVertexAttribAPPLE(UInt32 index, Pencil.Gaming.Graphics.AppleVertexProgramEvaluators pname);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
            internal extern static void DisableVertexAttribArray(UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDisableVertexAttribArrayARB", ExactSpelling = true)]
            internal extern static void DisableVertexAttribArrayARB(UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays(Pencil.Gaming.Graphics.BeginMode mode, Int32 first, Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysEXT", ExactSpelling = true)]
            internal extern static void DrawArraysEXT(Pencil.Gaming.Graphics.BeginMode mode, Int32 first, Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysIndirect", ExactSpelling = true)]
            internal extern static void DrawArraysIndirect(Pencil.Gaming.Graphics.ArbDrawIndirect mode, IntPtr indirect);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysInstanced", ExactSpelling = true)]
            internal extern static void DrawArraysInstanced(Pencil.Gaming.Graphics.BeginMode mode, Int32 first, Int32 count, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysInstancedARB", ExactSpelling = true)]
            internal extern static void DrawArraysInstancedARB(Pencil.Gaming.Graphics.BeginMode mode, Int32 first, Int32 count, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawArraysInstancedEXT", ExactSpelling = true)]
            internal extern static void DrawArraysInstancedEXT(Pencil.Gaming.Graphics.BeginMode mode, Int32 start, Int32 count, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
            internal extern static void DrawBuffer(Pencil.Gaming.Graphics.DrawBufferMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
            internal extern static unsafe void DrawBuffers(Int32 n, Pencil.Gaming.Graphics.DrawBuffersEnum* bufs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffersARB", ExactSpelling = true)]
            internal extern static unsafe void DrawBuffersARB(Int32 n, Pencil.Gaming.Graphics.ArbDrawBuffers* bufs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawBuffersATI", ExactSpelling = true)]
            internal extern static unsafe void DrawBuffersATI(Int32 n, Pencil.Gaming.Graphics.AtiDrawBuffers* bufs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementArrayAPPLE", ExactSpelling = true)]
            internal extern static void DrawElementArrayAPPLE(Pencil.Gaming.Graphics.BeginMode mode, Int32 first, Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementArrayATI", ExactSpelling = true)]
            internal extern static void DrawElementArrayATI(Pencil.Gaming.Graphics.BeginMode mode, Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements(Pencil.Gaming.Graphics.BeginMode mode, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsBaseVertex", ExactSpelling = true)]
            internal extern static void DrawElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 basevertex);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsIndirect", ExactSpelling = true)]
            internal extern static void DrawElementsIndirect(Pencil.Gaming.Graphics.ArbDrawIndirect mode, Pencil.Gaming.Graphics.ArbDrawIndirect type, IntPtr indirect);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstanced", ExactSpelling = true)]
            internal extern static void DrawElementsInstanced(Pencil.Gaming.Graphics.BeginMode mode, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedARB", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedARB(Pencil.Gaming.Graphics.BeginMode mode, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedBaseVertex", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedBaseVertex(Pencil.Gaming.Graphics.BeginMode mode, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawElementsInstancedEXT", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedEXT(Pencil.Gaming.Graphics.BeginMode mode, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawMeshArraysSUN", ExactSpelling = true)]
            internal extern static void DrawMeshArraysSUN(Pencil.Gaming.Graphics.BeginMode mode, Int32 first, Int32 count, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawPixels", ExactSpelling = true)]
            internal extern static void DrawPixels(Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawRangeElementArrayAPPLE", ExactSpelling = true)]
            internal extern static void DrawRangeElementArrayAPPLE(Pencil.Gaming.Graphics.BeginMode mode, UInt32 start, UInt32 end, Int32 first, Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawRangeElementArrayATI", ExactSpelling = true)]
            internal extern static void DrawRangeElementArrayATI(Pencil.Gaming.Graphics.BeginMode mode, UInt32 start, UInt32 end, Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
            internal extern static void DrawRangeElements(Pencil.Gaming.Graphics.BeginMode mode, UInt32 start, UInt32 end, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawRangeElementsBaseVertex", ExactSpelling = true)]
            internal extern static void DrawRangeElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode, UInt32 start, UInt32 end, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 basevertex);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawRangeElementsEXT", ExactSpelling = true)]
            internal extern static void DrawRangeElementsEXT(Pencil.Gaming.Graphics.BeginMode mode, UInt32 start, UInt32 end, Int32 count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTransformFeedback", ExactSpelling = true)]
            internal extern static void DrawTransformFeedback(Pencil.Gaming.Graphics.BeginMode mode, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTransformFeedbackNV", ExactSpelling = true)]
            internal extern static void DrawTransformFeedbackNV(Pencil.Gaming.Graphics.NvTransformFeedback2 mode, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glDrawTransformFeedbackStream", ExactSpelling = true)]
            internal extern static void DrawTransformFeedbackStream(Pencil.Gaming.Graphics.BeginMode mode, UInt32 id, UInt32 stream);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEdgeFlag", ExactSpelling = true)]
            internal extern static void EdgeFlag(bool flag);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEdgeFlagFormatNV", ExactSpelling = true)]
            internal extern static void EdgeFlagFormatNV(Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEdgeFlagPointer", ExactSpelling = true)]
            internal extern static void EdgeFlagPointer(Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEdgeFlagPointerEXT", ExactSpelling = true)]
            internal extern static unsafe void EdgeFlagPointerEXT(Int32 stride, Int32 count, bool* pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEdgeFlagPointerListIBM", ExactSpelling = true)]
            internal extern static unsafe void EdgeFlagPointerListIBM(Int32 stride, bool* pointer, Int32 ptrstride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
            internal extern static unsafe void EdgeFlagv(bool* flag);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glElementPointerAPPLE", ExactSpelling = true)]
            internal extern static void ElementPointerAPPLE(Pencil.Gaming.Graphics.AppleElementArray type, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glElementPointerATI", ExactSpelling = true)]
            internal extern static void ElementPointerATI(Pencil.Gaming.Graphics.AtiElementArray type, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal extern static void Enable(Pencil.Gaming.Graphics.EnableCap cap);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
            internal extern static void EnableClientState(Pencil.Gaming.Graphics.ArrayCap array);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableClientStateIndexedEXT", ExactSpelling = true)]
            internal extern static void EnableClientStateIndexedEXT(Pencil.Gaming.Graphics.EnableCap array, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnablei", ExactSpelling = true)]
            internal extern static void Enablei(Pencil.Gaming.Graphics.IndexedEnableCap target, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableIndexedEXT", ExactSpelling = true)]
            internal extern static void EnableIndexedEXT(Pencil.Gaming.Graphics.IndexedEnableCap target, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableVariantClientStateEXT", ExactSpelling = true)]
            internal extern static void EnableVariantClientStateEXT(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableVertexAttribAPPLE", ExactSpelling = true)]
            internal extern static void EnableVertexAttribAPPLE(UInt32 index, Pencil.Gaming.Graphics.AppleVertexProgramEvaluators pname);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
            internal extern static void EnableVertexAttribArray(UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnableVertexAttribArrayARB", ExactSpelling = true)]
            internal extern static void EnableVertexAttribArrayARB(UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEnd", ExactSpelling = true)]
            internal extern static void End();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndConditionalRender", ExactSpelling = true)]
            internal extern static void EndConditionalRender();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndConditionalRenderNV", ExactSpelling = true)]
            internal extern static void EndConditionalRenderNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndFragmentShaderATI", ExactSpelling = true)]
            internal extern static void EndFragmentShaderATI();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndList", ExactSpelling = true)]
            internal extern static void EndList();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndOcclusionQueryNV", ExactSpelling = true)]
            internal extern static void EndOcclusionQueryNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndPerfMonitorAMD", ExactSpelling = true)]
            internal extern static void EndPerfMonitorAMD(UInt32 monitor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
            internal extern static void EndQuery(Pencil.Gaming.Graphics.QueryTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndQueryARB", ExactSpelling = true)]
            internal extern static void EndQueryARB(Pencil.Gaming.Graphics.ArbOcclusionQuery target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndQueryIndexed", ExactSpelling = true)]
            internal extern static void EndQueryIndexed(Pencil.Gaming.Graphics.QueryTarget target, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndTransformFeedback", ExactSpelling = true)]
            internal extern static void EndTransformFeedback();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndTransformFeedbackEXT", ExactSpelling = true)]
            internal extern static void EndTransformFeedbackEXT();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndTransformFeedbackNV", ExactSpelling = true)]
            internal extern static void EndTransformFeedbackNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndVertexShaderEXT", ExactSpelling = true)]
            internal extern static void EndVertexShaderEXT();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEndVideoCaptureNV", ExactSpelling = true)]
            internal extern static void EndVideoCaptureNV(UInt32 video_capture_slot);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
            internal extern static void EvalCoord1d(Double u);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord1dv(Double* u);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
            internal extern static void EvalCoord1f(Single u);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord1fv(Single* u);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
            internal extern static void EvalCoord2d(Double u, Double v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord2dv(Double* u);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
            internal extern static void EvalCoord2f(Single u, Single v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
            internal extern static unsafe void EvalCoord2fv(Single* u);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalMapsNV", ExactSpelling = true)]
            internal extern static void EvalMapsNV(Pencil.Gaming.Graphics.NvEvaluators target, Pencil.Gaming.Graphics.NvEvaluators mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalMesh1", ExactSpelling = true)]
            internal extern static void EvalMesh1(Pencil.Gaming.Graphics.MeshMode1 mode, Int32 i1, Int32 i2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalMesh2", ExactSpelling = true)]
            internal extern static void EvalMesh2(Pencil.Gaming.Graphics.MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalPoint1", ExactSpelling = true)]
            internal extern static void EvalPoint1(Int32 i);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glEvalPoint2", ExactSpelling = true)]
            internal extern static void EvalPoint2(Int32 i, Int32 j);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExecuteProgramNV", ExactSpelling = true)]
            internal extern static unsafe void ExecuteProgramNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 id, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glExtractComponentEXT", ExactSpelling = true)]
            internal extern static void ExtractComponentEXT(UInt32 res, UInt32 src, UInt32 num);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
            internal extern static unsafe void FeedbackBuffer(Int32 size, Pencil.Gaming.Graphics.FeedbackType type, [OutAttribute] Single* buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFenceSync", ExactSpelling = true)]
            internal extern static IntPtr FenceSync(Pencil.Gaming.Graphics.ArbSync condition, UInt32 flags);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinalCombinerInputNV", ExactSpelling = true)]
            internal extern static void FinalCombinerInputNV(Pencil.Gaming.Graphics.NvRegisterCombiners variable, Pencil.Gaming.Graphics.NvRegisterCombiners input, Pencil.Gaming.Graphics.NvRegisterCombiners mapping, Pencil.Gaming.Graphics.NvRegisterCombiners componentUsage);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal extern static void Finish();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinishAsyncSGIX", ExactSpelling = true)]
            internal extern static unsafe Int32 FinishAsyncSGIX([OutAttribute] UInt32* markerp);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinishFenceAPPLE", ExactSpelling = true)]
            internal extern static void FinishFenceAPPLE(UInt32 fence);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinishFenceNV", ExactSpelling = true)]
            internal extern static void FinishFenceNV(UInt32 fence);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinishObjectAPPLE", ExactSpelling = true)]
            internal extern static void FinishObjectAPPLE(Pencil.Gaming.Graphics.AppleFence @object, Int32 name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFinishTextureSUNX", ExactSpelling = true)]
            internal extern static void FinishTextureSUNX();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal extern static void Flush();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushMappedBufferRange", ExactSpelling = true)]
            internal extern static void FlushMappedBufferRange(Pencil.Gaming.Graphics.BufferTarget target, IntPtr offset, IntPtr length);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushMappedBufferRangeAPPLE", ExactSpelling = true)]
            internal extern static void FlushMappedBufferRangeAPPLE(Pencil.Gaming.Graphics.BufferTarget target, IntPtr offset, IntPtr size);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushMappedNamedBufferRangeEXT", ExactSpelling = true)]
            internal extern static void FlushMappedNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, IntPtr length);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushPixelDataRangeNV", ExactSpelling = true)]
            internal extern static void FlushPixelDataRangeNV(Pencil.Gaming.Graphics.NvPixelDataRange target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushRasterSGIX", ExactSpelling = true)]
            internal extern static void FlushRasterSGIX();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushVertexArrayRangeAPPLE", ExactSpelling = true)]
            internal extern static void FlushVertexArrayRangeAPPLE(Int32 length, [OutAttribute] IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFlushVertexArrayRangeNV", ExactSpelling = true)]
            internal extern static void FlushVertexArrayRangeNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordd", ExactSpelling = true)]
            internal extern static void FogCoordd(Double coord);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoorddEXT", ExactSpelling = true)]
            internal extern static void FogCoorddEXT(Double coord);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoorddv", ExactSpelling = true)]
            internal extern static unsafe void FogCoorddv(Double* coord);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoorddvEXT", ExactSpelling = true)]
            internal extern static unsafe void FogCoorddvEXT(Double* coord);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordf", ExactSpelling = true)]
            internal extern static void FogCoordf(Single coord);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordfEXT", ExactSpelling = true)]
            internal extern static void FogCoordfEXT(Single coord);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordFormatNV", ExactSpelling = true)]
            internal extern static void FogCoordFormatNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordfv", ExactSpelling = true)]
            internal extern static unsafe void FogCoordfv(Single* coord);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordfvEXT", ExactSpelling = true)]
            internal extern static unsafe void FogCoordfvEXT(Single* coord);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordPointer", ExactSpelling = true)]
            internal extern static void FogCoordPointer(Pencil.Gaming.Graphics.FogPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordPointerEXT", ExactSpelling = true)]
            internal extern static void FogCoordPointerEXT(Pencil.Gaming.Graphics.ExtFogCoord type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogCoordPointerListIBM", ExactSpelling = true)]
            internal extern static void FogCoordPointerListIBM(Pencil.Gaming.Graphics.IbmVertexArrayLists type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogf", ExactSpelling = true)]
            internal extern static void Fogf(Pencil.Gaming.Graphics.FogParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogFuncSGIS", ExactSpelling = true)]
            internal extern static unsafe void FogFuncSGIS(Int32 n, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogfv", ExactSpelling = true)]
            internal extern static unsafe void Fogfv(Pencil.Gaming.Graphics.FogParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogi", ExactSpelling = true)]
            internal extern static void Fogi(Pencil.Gaming.Graphics.FogParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFogiv", ExactSpelling = true)]
            internal extern static unsafe void Fogiv(Pencil.Gaming.Graphics.FogParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentColorMaterialSGIX", ExactSpelling = true)]
            internal extern static void FragmentColorMaterialSGIX(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentLightfSGIX", ExactSpelling = true)]
            internal extern static void FragmentLightfSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light, Pencil.Gaming.Graphics.SgixFragmentLighting pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentLightfvSGIX", ExactSpelling = true)]
            internal extern static unsafe void FragmentLightfvSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light, Pencil.Gaming.Graphics.SgixFragmentLighting pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentLightiSGIX", ExactSpelling = true)]
            internal extern static void FragmentLightiSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light, Pencil.Gaming.Graphics.SgixFragmentLighting pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentLightivSGIX", ExactSpelling = true)]
            internal extern static unsafe void FragmentLightivSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light, Pencil.Gaming.Graphics.SgixFragmentLighting pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentLightModelfSGIX", ExactSpelling = true)]
            internal extern static void FragmentLightModelfSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentLightModelfvSGIX", ExactSpelling = true)]
            internal extern static unsafe void FragmentLightModelfvSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentLightModeliSGIX", ExactSpelling = true)]
            internal extern static void FragmentLightModeliSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentLightModelivSGIX", ExactSpelling = true)]
            internal extern static unsafe void FragmentLightModelivSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentMaterialfSGIX", ExactSpelling = true)]
            internal extern static void FragmentMaterialfSGIX(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentMaterialfvSGIX", ExactSpelling = true)]
            internal extern static unsafe void FragmentMaterialfvSGIX(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentMaterialiSGIX", ExactSpelling = true)]
            internal extern static void FragmentMaterialiSGIX(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFragmentMaterialivSGIX", ExactSpelling = true)]
            internal extern static unsafe void FragmentMaterialivSGIX(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferDrawBufferEXT", ExactSpelling = true)]
            internal extern static void FramebufferDrawBufferEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.DrawBufferMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferDrawBuffersEXT", ExactSpelling = true)]
            internal extern static unsafe void FramebufferDrawBuffersEXT(UInt32 framebuffer, Int32 n, Pencil.Gaming.Graphics.DrawBufferMode* bufs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferReadBufferEXT", ExactSpelling = true)]
            internal extern static void FramebufferReadBufferEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.ReadBufferMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
            internal extern static void FramebufferRenderbuffer(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferRenderbufferEXT", ExactSpelling = true)]
            internal extern static void FramebufferRenderbufferEXT(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture", ExactSpelling = true)]
            internal extern static void FramebufferTexture(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture1D", ExactSpelling = true)]
            internal extern static void FramebufferTexture1D(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture1DEXT", ExactSpelling = true)]
            internal extern static void FramebufferTexture1DEXT(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
            internal extern static void FramebufferTexture2D(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture2DEXT", ExactSpelling = true)]
            internal extern static void FramebufferTexture2DEXT(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture3D", ExactSpelling = true)]
            internal extern static void FramebufferTexture3D(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTexture3DEXT", ExactSpelling = true)]
            internal extern static void FramebufferTexture3DEXT(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTextureARB", ExactSpelling = true)]
            internal extern static void FramebufferTextureARB(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTextureEXT", ExactSpelling = true)]
            internal extern static void FramebufferTextureEXT(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTextureFaceARB", ExactSpelling = true)]
            internal extern static void FramebufferTextureFaceARB(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level, Pencil.Gaming.Graphics.TextureTarget face);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTextureFaceEXT", ExactSpelling = true)]
            internal extern static void FramebufferTextureFaceEXT(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level, Pencil.Gaming.Graphics.TextureTarget face);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTextureLayer", ExactSpelling = true)]
            internal extern static void FramebufferTextureLayer(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTextureLayerARB", ExactSpelling = true)]
            internal extern static void FramebufferTextureLayerARB(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFramebufferTextureLayerEXT", ExactSpelling = true)]
            internal extern static void FramebufferTextureLayerEXT(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrameTerminatorGREMEDY", ExactSpelling = true)]
            internal extern static void FrameTerminatorGREMEDY();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrameZoomSGIX", ExactSpelling = true)]
            internal extern static void FrameZoomSGIX(Int32 factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFreeObjectBufferATI", ExactSpelling = true)]
            internal extern static void FreeObjectBufferATI(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal extern static void FrontFace(Pencil.Gaming.Graphics.FrontFaceDirection mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glFrustum", ExactSpelling = true)]
            internal extern static void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenAsyncMarkersSGIX", ExactSpelling = true)]
            internal extern static Int32 GenAsyncMarkersSGIX(Int32 range);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal extern static unsafe void GenBuffers(Int32 n, [OutAttribute] UInt32* buffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenBuffersARB", ExactSpelling = true)]
            internal extern static unsafe void GenBuffersARB(Int32 n, [OutAttribute] UInt32* buffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
            internal extern static void GenerateMipmap(Pencil.Gaming.Graphics.GenerateMipmapTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenerateMipmapEXT", ExactSpelling = true)]
            internal extern static void GenerateMipmapEXT(Pencil.Gaming.Graphics.GenerateMipmapTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenerateMultiTexMipmapEXT", ExactSpelling = true)]
            internal extern static void GenerateMultiTexMipmapEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenerateTextureMipmapEXT", ExactSpelling = true)]
            internal extern static void GenerateTextureMipmapEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFencesAPPLE", ExactSpelling = true)]
            internal extern static unsafe void GenFencesAPPLE(Int32 n, [OutAttribute] UInt32* fences);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFencesNV", ExactSpelling = true)]
            internal extern static unsafe void GenFencesNV(Int32 n, [OutAttribute] UInt32* fences);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFragmentShadersATI", ExactSpelling = true)]
            internal extern static Int32 GenFragmentShadersATI(UInt32 range);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
            internal extern static unsafe void GenFramebuffers(Int32 n, [OutAttribute] UInt32* framebuffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenFramebuffersEXT", ExactSpelling = true)]
            internal extern static unsafe void GenFramebuffersEXT(Int32 n, [OutAttribute] UInt32* framebuffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenLists", ExactSpelling = true)]
            internal extern static Int32 GenLists(Int32 range);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenNamesAMD", ExactSpelling = true)]
            internal extern static unsafe void GenNamesAMD(Pencil.Gaming.Graphics.AmdNameGenDelete identifier, UInt32 num, [OutAttribute] UInt32* names);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenOcclusionQueriesNV", ExactSpelling = true)]
            internal extern static unsafe void GenOcclusionQueriesNV(Int32 n, [OutAttribute] UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenPerfMonitorsAMD", ExactSpelling = true)]
            internal extern static unsafe void GenPerfMonitorsAMD(Int32 n, [OutAttribute] UInt32* monitors);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenProgramPipelines", ExactSpelling = true)]
            internal extern static unsafe void GenProgramPipelines(Int32 n, [OutAttribute] UInt32* pipelines);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenProgramsARB", ExactSpelling = true)]
            internal extern static unsafe void GenProgramsARB(Int32 n, [OutAttribute] UInt32* programs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenProgramsNV", ExactSpelling = true)]
            internal extern static unsafe void GenProgramsNV(Int32 n, [OutAttribute] UInt32* programs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
            internal extern static unsafe void GenQueries(Int32 n, [OutAttribute] UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenQueriesARB", ExactSpelling = true)]
            internal extern static unsafe void GenQueriesARB(Int32 n, [OutAttribute] UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
            internal extern static unsafe void GenRenderbuffers(Int32 n, [OutAttribute] UInt32* renderbuffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenRenderbuffersEXT", ExactSpelling = true)]
            internal extern static unsafe void GenRenderbuffersEXT(Int32 n, [OutAttribute] UInt32* renderbuffers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenSamplers", ExactSpelling = true)]
            internal extern static unsafe void GenSamplers(Int32 count, [OutAttribute] UInt32* samplers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenSymbolsEXT", ExactSpelling = true)]
            internal extern static Int32 GenSymbolsEXT(Pencil.Gaming.Graphics.ExtVertexShader datatype, Pencil.Gaming.Graphics.ExtVertexShader storagetype, Pencil.Gaming.Graphics.ExtVertexShader range, UInt32 components);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal extern static unsafe void GenTextures(Int32 n, [OutAttribute] UInt32* textures);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenTexturesEXT", ExactSpelling = true)]
            internal extern static unsafe void GenTexturesEXT(Int32 n, [OutAttribute] UInt32* textures);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenTransformFeedbacks", ExactSpelling = true)]
            internal extern static unsafe void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenTransformFeedbacksNV", ExactSpelling = true)]
            internal extern static unsafe void GenTransformFeedbacksNV(Int32 n, [OutAttribute] UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenVertexArrays", ExactSpelling = true)]
            internal extern static unsafe void GenVertexArrays(Int32 n, [OutAttribute] UInt32* arrays);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenVertexArraysAPPLE", ExactSpelling = true)]
            internal extern static unsafe void GenVertexArraysAPPLE(Int32 n, [OutAttribute] UInt32* arrays);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGenVertexShadersEXT", ExactSpelling = true)]
            internal extern static Int32 GenVertexShadersEXT(UInt32 range);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
            internal extern static unsafe void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] Pencil.Gaming.Graphics.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveAttribARB", ExactSpelling = true)]
            internal extern static unsafe void GetActiveAttribARB(UInt32 programObj, UInt32 index, Int32 maxLength, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] Pencil.Gaming.Graphics.ArbVertexShader* type, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveSubroutineName", ExactSpelling = true)]
            internal extern static unsafe void GetActiveSubroutineName(UInt32 program, Pencil.Gaming.Graphics.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveSubroutineUniformiv", ExactSpelling = true)]
            internal extern static unsafe void GetActiveSubroutineUniformiv(UInt32 program, Pencil.Gaming.Graphics.ShaderType shadertype, UInt32 index, Pencil.Gaming.Graphics.ActiveSubroutineUniformParameter pname, [OutAttribute] Int32* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveSubroutineUniformName", ExactSpelling = true)]
            internal extern static unsafe void GetActiveSubroutineUniformName(UInt32 program, Pencil.Gaming.Graphics.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] Pencil.Gaming.Graphics.ActiveUniformType* type, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformARB", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformARB(UInt32 programObj, UInt32 index, Int32 maxLength, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] Pencil.Gaming.Graphics.ArbShaderObjects* type, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformBlockiv", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, Pencil.Gaming.Graphics.ActiveUniformBlockParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformBlockName", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformBlockName);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformName", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder uniformName);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveUniformsiv", ExactSpelling = true)]
            internal extern static unsafe void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, UInt32* uniformIndices, Pencil.Gaming.Graphics.ActiveUniformParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetActiveVaryingNV", ExactSpelling = true)]
            internal extern static unsafe void GetActiveVaryingNV(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] Pencil.Gaming.Graphics.NvTransformFeedback* type, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetArrayObjectfvATI", ExactSpelling = true)]
            internal extern static unsafe void GetArrayObjectfvATI(Pencil.Gaming.Graphics.EnableCap array, Pencil.Gaming.Graphics.AtiVertexArrayObject pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetArrayObjectivATI", ExactSpelling = true)]
            internal extern static unsafe void GetArrayObjectivATI(Pencil.Gaming.Graphics.EnableCap array, Pencil.Gaming.Graphics.AtiVertexArrayObject pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetAttachedObjectsARB", ExactSpelling = true)]
            internal extern static unsafe void GetAttachedObjectsARB(UInt32 containerObj, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* obj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
            internal extern static unsafe void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32* count, [OutAttribute] UInt32* obj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
            internal extern static Int32 GetAttribLocation(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetAttribLocationARB", ExactSpelling = true)]
            internal extern static Int32 GetAttribLocationARB(UInt32 programObj, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBooleani_v", ExactSpelling = true)]
            internal extern static unsafe void GetBooleani_v(Pencil.Gaming.Graphics.GetIndexedPName target, UInt32 index, [OutAttribute] bool* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBooleanIndexedvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetBooleanIndexedvEXT(Pencil.Gaming.Graphics.ExtDrawBuffers2 target, UInt32 index, [OutAttribute] bool* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal extern static unsafe void GetBooleanv(Pencil.Gaming.Graphics.GetPName pname, [OutAttribute] bool* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferParameteri64v", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameteri64v(Pencil.Gaming.Graphics.BufferTarget target, Pencil.Gaming.Graphics.BufferParameterName pname, [OutAttribute] Int64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameteriv(Pencil.Gaming.Graphics.BufferTarget target, Pencil.Gaming.Graphics.BufferParameterName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferParameterivARB", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameterivARB(Pencil.Gaming.Graphics.ArbVertexBufferObject target, Pencil.Gaming.Graphics.BufferParameterNameArb pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferParameterui64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetBufferParameterui64vNV(Pencil.Gaming.Graphics.NvShaderBufferLoad target, Pencil.Gaming.Graphics.NvShaderBufferLoad pname, [OutAttribute] UInt64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
            internal extern static void GetBufferPointerv(Pencil.Gaming.Graphics.BufferTarget target, Pencil.Gaming.Graphics.BufferPointer pname, [OutAttribute] IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferPointervARB", ExactSpelling = true)]
            internal extern static void GetBufferPointervARB(Pencil.Gaming.Graphics.ArbVertexBufferObject target, Pencil.Gaming.Graphics.BufferPointerNameArb pname, [OutAttribute] IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
            internal extern static void GetBufferSubData(Pencil.Gaming.Graphics.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetBufferSubDataARB", ExactSpelling = true)]
            internal extern static void GetBufferSubDataARB(Pencil.Gaming.Graphics.BufferTargetArb target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetClipPlane", ExactSpelling = true)]
            internal extern static unsafe void GetClipPlane(Pencil.Gaming.Graphics.ClipPlaneName plane, [OutAttribute] Double* equation);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTable", ExactSpelling = true)]
            internal extern static void GetColorTable(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr table);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableEXT", ExactSpelling = true)]
            internal extern static void GetColorTableEXT(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameterfv(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.GetColorTableParameterPName pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameterfvEXT(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.GetColorTableParameterPName pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableParameterfvSGI", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameterfvSGI(Pencil.Gaming.Graphics.SgiColorTable target, Pencil.Gaming.Graphics.SgiColorTable pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameteriv(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.GetColorTableParameterPName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameterivEXT(Pencil.Gaming.Graphics.ColorTableTarget target, Pencil.Gaming.Graphics.GetColorTableParameterPName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableParameterivSGI", ExactSpelling = true)]
            internal extern static unsafe void GetColorTableParameterivSGI(Pencil.Gaming.Graphics.SgiColorTable target, Pencil.Gaming.Graphics.SgiColorTable pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetColorTableSGI", ExactSpelling = true)]
            internal extern static void GetColorTableSGI(Pencil.Gaming.Graphics.SgiColorTable target, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr table);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCombinerInputParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetCombinerInputParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage, Pencil.Gaming.Graphics.NvRegisterCombiners portion, Pencil.Gaming.Graphics.NvRegisterCombiners variable, Pencil.Gaming.Graphics.NvRegisterCombiners pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCombinerInputParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void GetCombinerInputParameterivNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage, Pencil.Gaming.Graphics.NvRegisterCombiners portion, Pencil.Gaming.Graphics.NvRegisterCombiners variable, Pencil.Gaming.Graphics.NvRegisterCombiners pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCombinerOutputParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetCombinerOutputParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage, Pencil.Gaming.Graphics.NvRegisterCombiners portion, Pencil.Gaming.Graphics.NvRegisterCombiners pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCombinerOutputParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void GetCombinerOutputParameterivNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage, Pencil.Gaming.Graphics.NvRegisterCombiners portion, Pencil.Gaming.Graphics.NvRegisterCombiners pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCombinerStageParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetCombinerStageParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners2 stage, Pencil.Gaming.Graphics.NvRegisterCombiners2 pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCompressedMultiTexImageEXT", ExactSpelling = true)]
            internal extern static void GetCompressedMultiTexImageEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 lod, [OutAttribute] IntPtr img);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
            internal extern static void GetCompressedTexImage(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, [OutAttribute] IntPtr img);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCompressedTexImageARB", ExactSpelling = true)]
            internal extern static void GetCompressedTexImageARB(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, [OutAttribute] IntPtr img);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetCompressedTextureImageEXT", ExactSpelling = true)]
            internal extern static void GetCompressedTextureImageEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 lod, [OutAttribute] IntPtr img);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionFilter", ExactSpelling = true)]
            internal extern static void GetConvolutionFilter(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionFilterEXT", ExactSpelling = true)]
            internal extern static void GetConvolutionFilterEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameterfv(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.GetConvolutionParameterPName pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameterfvEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.ExtConvolution pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameteriv(Pencil.Gaming.Graphics.ConvolutionTarget target, Pencil.Gaming.Graphics.GetConvolutionParameterPName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetConvolutionParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetConvolutionParameterivEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.ExtConvolution pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDebugMessageLogAMD", ExactSpelling = true)]
            internal extern static unsafe Int32 GetDebugMessageLogAMD(UInt32 count, Int32 bufsize, [OutAttribute] Pencil.Gaming.Graphics.AmdDebugOutput* categories, [OutAttribute] UInt32* severities, [OutAttribute] UInt32* ids, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder message);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDebugMessageLogARB", ExactSpelling = true)]
            internal extern static unsafe Int32 GetDebugMessageLogARB(UInt32 count, Int32 bufsize, [OutAttribute] Pencil.Gaming.Graphics.ArbDebugOutput* sources, [OutAttribute] Pencil.Gaming.Graphics.ArbDebugOutput* types, [OutAttribute] UInt32* ids, [OutAttribute] Pencil.Gaming.Graphics.ArbDebugOutput* severities, [OutAttribute] Int32* lengths, [OutAttribute] StringBuilder messageLog);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDetailTexFuncSGIS", ExactSpelling = true)]
            internal extern static unsafe void GetDetailTexFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target, [OutAttribute] Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDoublei_v", ExactSpelling = true)]
            internal extern static unsafe void GetDoublei_v(Pencil.Gaming.Graphics.GetIndexedPName target, UInt32 index, [OutAttribute] Double* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDoubleIndexedvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetDoubleIndexedvEXT(Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Double* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
            internal extern static unsafe void GetDoublev(Pencil.Gaming.Graphics.GetPName pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal extern static Pencil.Gaming.Graphics.ErrorCode GetError();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFenceivNV", ExactSpelling = true)]
            internal extern static unsafe void GetFenceivNV(UInt32 fence, Pencil.Gaming.Graphics.NvFence pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFinalCombinerInputParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetFinalCombinerInputParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners variable, Pencil.Gaming.Graphics.NvRegisterCombiners pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFinalCombinerInputParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void GetFinalCombinerInputParameterivNV(Pencil.Gaming.Graphics.NvRegisterCombiners variable, Pencil.Gaming.Graphics.NvRegisterCombiners pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFloati_v", ExactSpelling = true)]
            internal extern static unsafe void GetFloati_v(Pencil.Gaming.Graphics.GetIndexedPName target, UInt32 index, [OutAttribute] Single* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFloatIndexedvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetFloatIndexedvEXT(Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Single* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal extern static unsafe void GetFloatv(Pencil.Gaming.Graphics.GetPName pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFogFuncSGIS", ExactSpelling = true)]
            internal extern static unsafe void GetFogFuncSGIS([OutAttribute] Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragDataIndex", ExactSpelling = true)]
            internal extern static Int32 GetFragDataIndex(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragDataLocation", ExactSpelling = true)]
            internal extern static Int32 GetFragDataLocation(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragDataLocationEXT", ExactSpelling = true)]
            internal extern static Int32 GetFragDataLocationEXT(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragmentLightfvSGIX", ExactSpelling = true)]
            internal extern static unsafe void GetFragmentLightfvSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light, Pencil.Gaming.Graphics.SgixFragmentLighting pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragmentLightivSGIX", ExactSpelling = true)]
            internal extern static unsafe void GetFragmentLightivSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light, Pencil.Gaming.Graphics.SgixFragmentLighting pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragmentMaterialfvSGIX", ExactSpelling = true)]
            internal extern static unsafe void GetFragmentMaterialfvSGIX(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFragmentMaterialivSGIX", ExactSpelling = true)]
            internal extern static unsafe void GetFragmentMaterialivSGIX(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetFramebufferAttachmentParameteriv(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFramebufferAttachmentParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetFramebufferAttachmentParameterivEXT(Pencil.Gaming.Graphics.FramebufferTarget target, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.FramebufferParameterName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetFramebufferParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetFramebufferParameterivEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.ExtDirectStateAccess pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetGraphicsResetStatusARB", ExactSpelling = true)]
            internal extern static Pencil.Gaming.Graphics.ArbRobustness GetGraphicsResetStatusARB();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHandleARB", ExactSpelling = true)]
            internal extern static Int32 GetHandleARB(Pencil.Gaming.Graphics.ArbShaderObjects pname);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogram", ExactSpelling = true)]
            internal extern static void GetHistogram(Pencil.Gaming.Graphics.HistogramTarget target, bool reset, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogramEXT", ExactSpelling = true)]
            internal extern static void GetHistogramEXT(Pencil.Gaming.Graphics.ExtHistogram target, bool reset, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogramParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameterfv(Pencil.Gaming.Graphics.HistogramTarget target, Pencil.Gaming.Graphics.GetHistogramParameterPName pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogramParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameterfvEXT(Pencil.Gaming.Graphics.ExtHistogram target, Pencil.Gaming.Graphics.ExtHistogram pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogramParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameteriv(Pencil.Gaming.Graphics.HistogramTarget target, Pencil.Gaming.Graphics.GetHistogramParameterPName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetHistogramParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetHistogramParameterivEXT(Pencil.Gaming.Graphics.ExtHistogram target, Pencil.Gaming.Graphics.ExtHistogram pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetImageTransformParameterfvHP", ExactSpelling = true)]
            internal extern static unsafe void GetImageTransformParameterfvHP(Pencil.Gaming.Graphics.HpImageTransform target, Pencil.Gaming.Graphics.HpImageTransform pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetImageTransformParameterivHP", ExactSpelling = true)]
            internal extern static unsafe void GetImageTransformParameterivHP(Pencil.Gaming.Graphics.HpImageTransform target, Pencil.Gaming.Graphics.HpImageTransform pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInfoLogARB", ExactSpelling = true)]
            internal extern static unsafe void GetInfoLogARB(UInt32 obj, Int32 maxLength, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInstrumentsSGIX", ExactSpelling = true)]
            internal extern static Int32 GetInstrumentsSGIX();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInteger64i_v", ExactSpelling = true)]
            internal extern static unsafe void GetInteger64i_v(Pencil.Gaming.Graphics.GetIndexedPName target, UInt32 index, [OutAttribute] Int64* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInteger64v", ExactSpelling = true)]
            internal extern static unsafe void GetInteger64v(Pencil.Gaming.Graphics.ArbSync pname, [OutAttribute] Int64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegeri_v", ExactSpelling = true)]
            internal extern static unsafe void GetIntegeri_v(Pencil.Gaming.Graphics.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegerIndexedvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerIndexedvEXT(Pencil.Gaming.Graphics.GetIndexedPName target, UInt32 index, [OutAttribute] Int32* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegerui64i_vNV", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerui64i_vNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory value, UInt32 index, [OutAttribute] UInt64* result);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegerui64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerui64vNV(Pencil.Gaming.Graphics.NvShaderBufferLoad value, [OutAttribute] UInt64* result);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal extern static unsafe void GetIntegerv(Pencil.Gaming.Graphics.GetPName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInvariantBooleanvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetInvariantBooleanvEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] bool* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInvariantFloatvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetInvariantFloatvEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] Single* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetInvariantIntegervEXT", ExactSpelling = true)]
            internal extern static unsafe void GetInvariantIntegervEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] Int32* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLightfv", ExactSpelling = true)]
            internal extern static unsafe void GetLightfv(Pencil.Gaming.Graphics.LightName light, Pencil.Gaming.Graphics.LightParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLightiv", ExactSpelling = true)]
            internal extern static unsafe void GetLightiv(Pencil.Gaming.Graphics.LightName light, Pencil.Gaming.Graphics.LightParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetListParameterfvSGIX", ExactSpelling = true)]
            internal extern static unsafe void GetListParameterfvSGIX(UInt32 list, Pencil.Gaming.Graphics.ListParameterName pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetListParameterivSGIX", ExactSpelling = true)]
            internal extern static unsafe void GetListParameterivSGIX(UInt32 list, Pencil.Gaming.Graphics.ListParameterName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLocalConstantBooleanvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetLocalConstantBooleanvEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] bool* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLocalConstantFloatvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetLocalConstantFloatvEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] Single* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetLocalConstantIntegervEXT", ExactSpelling = true)]
            internal extern static unsafe void GetLocalConstantIntegervEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] Int32* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapAttribParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetMapAttribParameterfvNV(Pencil.Gaming.Graphics.NvEvaluators target, UInt32 index, Pencil.Gaming.Graphics.NvEvaluators pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapAttribParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void GetMapAttribParameterivNV(Pencil.Gaming.Graphics.NvEvaluators target, UInt32 index, Pencil.Gaming.Graphics.NvEvaluators pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapControlPointsNV", ExactSpelling = true)]
            internal extern static void GetMapControlPointsNV(Pencil.Gaming.Graphics.NvEvaluators target, UInt32 index, Pencil.Gaming.Graphics.NvEvaluators type, Int32 ustride, Int32 vstride, bool packed, [OutAttribute] IntPtr points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapdv", ExactSpelling = true)]
            internal extern static unsafe void GetMapdv(Pencil.Gaming.Graphics.MapTarget target, Pencil.Gaming.Graphics.GetMapQuery query, [OutAttribute] Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapfv", ExactSpelling = true)]
            internal extern static unsafe void GetMapfv(Pencil.Gaming.Graphics.MapTarget target, Pencil.Gaming.Graphics.GetMapQuery query, [OutAttribute] Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapiv", ExactSpelling = true)]
            internal extern static unsafe void GetMapiv(Pencil.Gaming.Graphics.MapTarget target, Pencil.Gaming.Graphics.GetMapQuery query, [OutAttribute] Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetMapParameterfvNV(Pencil.Gaming.Graphics.NvEvaluators target, Pencil.Gaming.Graphics.NvEvaluators pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMapParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void GetMapParameterivNV(Pencil.Gaming.Graphics.NvEvaluators target, Pencil.Gaming.Graphics.NvEvaluators pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
            internal extern static unsafe void GetMaterialfv(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
            internal extern static unsafe void GetMaterialiv(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmax", ExactSpelling = true)]
            internal extern static void GetMinmax(Pencil.Gaming.Graphics.MinmaxTarget target, bool reset, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmaxEXT", ExactSpelling = true)]
            internal extern static void GetMinmaxEXT(Pencil.Gaming.Graphics.ExtHistogram target, bool reset, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmaxParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetMinmaxParameterfv(Pencil.Gaming.Graphics.MinmaxTarget target, Pencil.Gaming.Graphics.GetMinmaxParameterPName pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmaxParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMinmaxParameterfvEXT(Pencil.Gaming.Graphics.ExtHistogram target, Pencil.Gaming.Graphics.ExtHistogram pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmaxParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetMinmaxParameteriv(Pencil.Gaming.Graphics.MinmaxTarget target, Pencil.Gaming.Graphics.GetMinmaxParameterPName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMinmaxParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMinmaxParameterivEXT(Pencil.Gaming.Graphics.ExtHistogram target, Pencil.Gaming.Graphics.ExtHistogram pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultisamplefv", ExactSpelling = true)]
            internal extern static unsafe void GetMultisamplefv(Pencil.Gaming.Graphics.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single* val);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultisamplefvNV", ExactSpelling = true)]
            internal extern static unsafe void GetMultisamplefvNV(Pencil.Gaming.Graphics.NvExplicitMultisample pname, UInt32 index, [OutAttribute] Single* val);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexEnvfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexEnvfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexEnvivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexEnvivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexGendvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexGendvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexGenfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexGenfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexGenivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexGenivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexImageEXT", ExactSpelling = true)]
            internal extern static void GetMultiTexImageEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexLevelParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexLevelParameterfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexLevelParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexLevelParameterivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexParameterfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexParameterIivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexParameterIivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexParameterIuivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexParameterIuivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetMultiTexParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetMultiTexParameterivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedBufferParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetNamedBufferParameterivEXT(UInt32 buffer, Pencil.Gaming.Graphics.ExtDirectStateAccess pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedBufferParameterui64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetNamedBufferParameterui64vNV(UInt32 buffer, Pencil.Gaming.Graphics.NvShaderBufferLoad pname, [OutAttribute] UInt64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedBufferPointervEXT", ExactSpelling = true)]
            internal extern static void GetNamedBufferPointervEXT(UInt32 buffer, Pencil.Gaming.Graphics.ExtDirectStateAccess pname, [OutAttribute] IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedBufferSubDataEXT", ExactSpelling = true)]
            internal extern static void GetNamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedFramebufferAttachmentParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetNamedFramebufferAttachmentParameterivEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.ExtDirectStateAccess pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedProgramivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetNamedProgramivEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, Pencil.Gaming.Graphics.ExtDirectStateAccess pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedProgramLocalParameterdvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetNamedProgramLocalParameterdvEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedProgramLocalParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetNamedProgramLocalParameterfvEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedProgramLocalParameterIivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetNamedProgramLocalParameterIivEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedProgramLocalParameterIuivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetNamedProgramLocalParameterIuivEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedProgramStringEXT", ExactSpelling = true)]
            internal extern static void GetNamedProgramStringEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, Pencil.Gaming.Graphics.ExtDirectStateAccess pname, [OutAttribute] IntPtr @string);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedRenderbufferParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetNamedRenderbufferParameterivEXT(UInt32 renderbuffer, Pencil.Gaming.Graphics.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedStringARB", ExactSpelling = true)]
            internal extern static unsafe void GetNamedStringARB(Int32 namelen, String name, Int32 bufSize, [OutAttribute] Int32* stringlen, [OutAttribute] StringBuilder @string);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetNamedStringivARB", ExactSpelling = true)]
            internal extern static unsafe void GetNamedStringivARB(Int32 namelen, String name, Pencil.Gaming.Graphics.ArbShadingLanguageInclude pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnColorTableARB", ExactSpelling = true)]
            internal extern static void GetnColorTableARB(Pencil.Gaming.Graphics.ArbRobustness target, Pencil.Gaming.Graphics.ArbRobustness format, Pencil.Gaming.Graphics.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr table);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnCompressedTexImageARB", ExactSpelling = true)]
            internal extern static void GetnCompressedTexImageARB(Pencil.Gaming.Graphics.ArbRobustness target, Int32 lod, Int32 bufSize, [OutAttribute] IntPtr img);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnConvolutionFilterARB", ExactSpelling = true)]
            internal extern static void GetnConvolutionFilterARB(Pencil.Gaming.Graphics.ArbRobustness target, Pencil.Gaming.Graphics.ArbRobustness format, Pencil.Gaming.Graphics.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnHistogramARB", ExactSpelling = true)]
            internal extern static void GetnHistogramARB(Pencil.Gaming.Graphics.ArbRobustness target, bool reset, Pencil.Gaming.Graphics.ArbRobustness format, Pencil.Gaming.Graphics.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnMapdvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnMapdvARB(Pencil.Gaming.Graphics.ArbRobustness target, Pencil.Gaming.Graphics.ArbRobustness query, Int32 bufSize, [OutAttribute] Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnMapfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnMapfvARB(Pencil.Gaming.Graphics.ArbRobustness target, Pencil.Gaming.Graphics.ArbRobustness query, Int32 bufSize, [OutAttribute] Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnMapivARB", ExactSpelling = true)]
            internal extern static unsafe void GetnMapivARB(Pencil.Gaming.Graphics.ArbRobustness target, Pencil.Gaming.Graphics.ArbRobustness query, Int32 bufSize, [OutAttribute] Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnMinmaxARB", ExactSpelling = true)]
            internal extern static void GetnMinmaxARB(Pencil.Gaming.Graphics.ArbRobustness target, bool reset, Pencil.Gaming.Graphics.ArbRobustness format, Pencil.Gaming.Graphics.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnPixelMapfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnPixelMapfvARB(Pencil.Gaming.Graphics.ArbRobustness map, Int32 bufSize, [OutAttribute] Single* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnPixelMapuivARB", ExactSpelling = true)]
            internal extern static unsafe void GetnPixelMapuivARB(Pencil.Gaming.Graphics.ArbRobustness map, Int32 bufSize, [OutAttribute] UInt32* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnPixelMapusvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnPixelMapusvARB(Pencil.Gaming.Graphics.ArbRobustness map, Int32 bufSize, [OutAttribute] UInt16* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnPolygonStippleARB", ExactSpelling = true)]
            internal extern static unsafe void GetnPolygonStippleARB(Int32 bufSize, [OutAttribute] Byte* pattern);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnSeparableFilterARB", ExactSpelling = true)]
            internal extern static void GetnSeparableFilterARB(Pencil.Gaming.Graphics.ArbRobustness target, Pencil.Gaming.Graphics.ArbRobustness format, Pencil.Gaming.Graphics.ArbRobustness type, Int32 rowBufSize, [OutAttribute] IntPtr row, Int32 columnBufSize, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnTexImageARB", ExactSpelling = true)]
            internal extern static void GetnTexImageARB(Pencil.Gaming.Graphics.ArbRobustness target, Int32 level, Pencil.Gaming.Graphics.ArbRobustness format, Pencil.Gaming.Graphics.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr img);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformdvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformdvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformfvARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformivARB", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetnUniformuivARB", ExactSpelling = true)]
            internal extern static unsafe void GetnUniformuivARB(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectBufferfvATI", ExactSpelling = true)]
            internal extern static unsafe void GetObjectBufferfvATI(UInt32 buffer, Pencil.Gaming.Graphics.AtiVertexArrayObject pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectBufferivATI", ExactSpelling = true)]
            internal extern static unsafe void GetObjectBufferivATI(UInt32 buffer, Pencil.Gaming.Graphics.AtiVertexArrayObject pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectParameterfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetObjectParameterfvARB(UInt32 obj, Pencil.Gaming.Graphics.ArbShaderObjects pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectParameterivAPPLE", ExactSpelling = true)]
            internal extern static unsafe void GetObjectParameterivAPPLE(Pencil.Gaming.Graphics.AppleObjectPurgeable objectType, UInt32 name, Pencil.Gaming.Graphics.AppleObjectPurgeable pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetObjectParameterivARB", ExactSpelling = true)]
            internal extern static unsafe void GetObjectParameterivARB(UInt32 obj, Pencil.Gaming.Graphics.ArbShaderObjects pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetOcclusionQueryivNV", ExactSpelling = true)]
            internal extern static unsafe void GetOcclusionQueryivNV(UInt32 id, Pencil.Gaming.Graphics.NvOcclusionQuery pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetOcclusionQueryuivNV", ExactSpelling = true)]
            internal extern static unsafe void GetOcclusionQueryuivNV(UInt32 id, Pencil.Gaming.Graphics.NvOcclusionQuery pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorCounterDataAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorCounterDataAMD(UInt32 monitor, Pencil.Gaming.Graphics.AmdPerformanceMonitor pname, Int32 dataSize, [OutAttribute] UInt32* data, [OutAttribute] Int32* bytesWritten);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorCounterInfoAMD", ExactSpelling = true)]
            internal extern static void GetPerfMonitorCounterInfoAMD(UInt32 group, UInt32 counter, Pencil.Gaming.Graphics.AmdPerformanceMonitor pname, [OutAttribute] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorCountersAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorCountersAMD(UInt32 group, [OutAttribute] Int32* numCounters, [OutAttribute] Int32* maxActiveCounters, Int32 counterSize, [OutAttribute] UInt32* counters);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorCounterStringAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorCounterStringAMD(UInt32 group, UInt32 counter, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder counterString);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorGroupsAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorGroupsAMD([OutAttribute] Int32* numGroups, Int32 groupsSize, [OutAttribute] UInt32* groups);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPerfMonitorGroupStringAMD", ExactSpelling = true)]
            internal extern static unsafe void GetPerfMonitorGroupStringAMD(UInt32 group, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder groupString);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
            internal extern static unsafe void GetPixelMapfv(Pencil.Gaming.Graphics.PixelMap map, [OutAttribute] Single* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
            internal extern static unsafe void GetPixelMapuiv(Pencil.Gaming.Graphics.PixelMap map, [OutAttribute] UInt32* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
            internal extern static unsafe void GetPixelMapusv(Pencil.Gaming.Graphics.PixelMap map, [OutAttribute] UInt16* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPixelTexGenParameterfvSGIS", ExactSpelling = true)]
            internal extern static unsafe void GetPixelTexGenParameterfvSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPixelTexGenParameterivSGIS", ExactSpelling = true)]
            internal extern static unsafe void GetPixelTexGenParameterivSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPointerIndexedvEXT", ExactSpelling = true)]
            internal extern static void GetPointerIndexedvEXT(Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, [OutAttribute] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
            internal extern static void GetPointerv(Pencil.Gaming.Graphics.GetPointervPName pname, [OutAttribute] IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPointervEXT", ExactSpelling = true)]
            internal extern static void GetPointervEXT(Pencil.Gaming.Graphics.GetPointervPName pname, [OutAttribute] IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
            internal extern static unsafe void GetPolygonStipple([OutAttribute] Byte* mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramBinary", ExactSpelling = true)]
            internal extern static unsafe void GetProgramBinary(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Pencil.Gaming.Graphics.BinaryFormat* binaryFormat, [OutAttribute] IntPtr binary);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramEnvParameterdvARB", ExactSpelling = true)]
            internal extern static unsafe void GetProgramEnvParameterdvARB(Pencil.Gaming.Graphics.ArbVertexProgram target, UInt32 index, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramEnvParameterfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetProgramEnvParameterfvARB(Pencil.Gaming.Graphics.ArbVertexProgram target, UInt32 index, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramEnvParameterIivNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramEnvParameterIivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramEnvParameterIuivNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramEnvParameterIuivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetProgramInfoLog(UInt32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramiv(UInt32 program, Pencil.Gaming.Graphics.ProgramParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramivARB", ExactSpelling = true)]
            internal extern static unsafe void GetProgramivARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramivNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramivNV(UInt32 id, Pencil.Gaming.Graphics.NvVertexProgram pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramLocalParameterdvARB", ExactSpelling = true)]
            internal extern static unsafe void GetProgramLocalParameterdvARB(Pencil.Gaming.Graphics.ArbVertexProgram target, UInt32 index, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramLocalParameterfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetProgramLocalParameterfvARB(Pencil.Gaming.Graphics.ArbVertexProgram target, UInt32 index, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramLocalParameterIivNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramLocalParameterIivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramLocalParameterIuivNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramLocalParameterIuivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramNamedParameterdvNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramNamedParameterdvNV(UInt32 id, Int32 len, Byte* name, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramNamedParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramNamedParameterfvNV(UInt32 id, Int32 len, Byte* name, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramParameterdvNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramParameterdvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramParameterfvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramPipelineInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramPipelineiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramPipelineiv(UInt32 pipeline, Pencil.Gaming.Graphics.ProgramPipelineParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramStageiv", ExactSpelling = true)]
            internal extern static unsafe void GetProgramStageiv(UInt32 program, Pencil.Gaming.Graphics.ShaderType shadertype, Pencil.Gaming.Graphics.ProgramStageParameter pname, [OutAttribute] Int32* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramStringARB", ExactSpelling = true)]
            internal extern static void GetProgramStringARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname, [OutAttribute] IntPtr @string);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramStringNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramStringNV(UInt32 id, Pencil.Gaming.Graphics.NvVertexProgram pname, [OutAttribute] Byte* program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetProgramSubroutineParameteruivNV", ExactSpelling = true)]
            internal extern static unsafe void GetProgramSubroutineParameteruivNV(Pencil.Gaming.Graphics.NvGpuProgram5 target, UInt32 index, [OutAttribute] UInt32* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryIndexediv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryIndexediv(Pencil.Gaming.Graphics.QueryTarget target, UInt32 index, Pencil.Gaming.Graphics.GetQueryParam pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryiv(Pencil.Gaming.Graphics.QueryTarget target, Pencil.Gaming.Graphics.GetQueryParam pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryivARB", ExactSpelling = true)]
            internal extern static unsafe void GetQueryivARB(Pencil.Gaming.Graphics.ArbOcclusionQuery target, Pencil.Gaming.Graphics.ArbOcclusionQuery pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjecti64v", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjecti64v(UInt32 id, Pencil.Gaming.Graphics.GetQueryObjectParam pname, [OutAttribute] Int64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjecti64vEXT", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjecti64vEXT(UInt32 id, Pencil.Gaming.Graphics.ExtTimerQuery pname, [OutAttribute] Int64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectiv(UInt32 id, Pencil.Gaming.Graphics.GetQueryObjectParam pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectivARB", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectivARB(UInt32 id, Pencil.Gaming.Graphics.ArbOcclusionQuery pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectui64v", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectui64v(UInt32 id, Pencil.Gaming.Graphics.GetQueryObjectParam pname, [OutAttribute] UInt64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectui64vEXT", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectui64vEXT(UInt32 id, Pencil.Gaming.Graphics.ExtTimerQuery pname, [OutAttribute] UInt64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectuiv(UInt32 id, Pencil.Gaming.Graphics.GetQueryObjectParam pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetQueryObjectuivARB", ExactSpelling = true)]
            internal extern static unsafe void GetQueryObjectuivARB(UInt32 id, Pencil.Gaming.Graphics.ArbOcclusionQuery pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetRenderbufferParameteriv(Pencil.Gaming.Graphics.RenderbufferTarget target, Pencil.Gaming.Graphics.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetRenderbufferParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetRenderbufferParameterivEXT(Pencil.Gaming.Graphics.RenderbufferTarget target, Pencil.Gaming.Graphics.RenderbufferParameterName pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSamplerParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetSamplerParameterfv(UInt32 sampler, Pencil.Gaming.Graphics.SamplerParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSamplerParameterIiv", ExactSpelling = true)]
            internal extern static unsafe void GetSamplerParameterIiv(UInt32 sampler, Pencil.Gaming.Graphics.ArbSamplerObjects pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSamplerParameterIuiv", ExactSpelling = true)]
            internal extern static unsafe void GetSamplerParameterIuiv(UInt32 sampler, Pencil.Gaming.Graphics.ArbSamplerObjects pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSamplerParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetSamplerParameteriv(UInt32 sampler, Pencil.Gaming.Graphics.SamplerParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSeparableFilter", ExactSpelling = true)]
            internal extern static void GetSeparableFilter(Pencil.Gaming.Graphics.SeparableTarget target, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSeparableFilterEXT", ExactSpelling = true)]
            internal extern static void GetSeparableFilterEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr row, [OutAttribute] IntPtr column, [OutAttribute] IntPtr span);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
            internal extern static unsafe void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
            internal extern static unsafe void GetShaderiv(UInt32 shader, Pencil.Gaming.Graphics.ShaderParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
            internal extern static unsafe void GetShaderPrecisionFormat(Pencil.Gaming.Graphics.ShaderType shadertype, Pencil.Gaming.Graphics.ShaderPrecisionType precisiontype, [OutAttribute] Int32* range, [OutAttribute] Int32* precision);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
            internal extern static unsafe void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetShaderSourceARB", ExactSpelling = true)]
            internal extern static unsafe void GetShaderSourceARB(UInt32 obj, Int32 maxLength, [OutAttribute] Int32* length, [OutAttribute] StringBuilder source);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSharpenTexFuncSGIS", ExactSpelling = true)]
            internal extern static unsafe void GetSharpenTexFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target, [OutAttribute] Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal extern static IntPtr GetString(Pencil.Gaming.Graphics.StringName name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetStringi", ExactSpelling = true)]
            internal extern static IntPtr GetStringi(Pencil.Gaming.Graphics.StringName name, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSubroutineIndex", ExactSpelling = true)]
            internal extern static Int32 GetSubroutineIndex(UInt32 program, Pencil.Gaming.Graphics.ShaderType shadertype, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSubroutineUniformLocation", ExactSpelling = true)]
            internal extern static Int32 GetSubroutineUniformLocation(UInt32 program, Pencil.Gaming.Graphics.ShaderType shadertype, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetSynciv", ExactSpelling = true)]
            internal extern static unsafe void GetSynciv(IntPtr sync, Pencil.Gaming.Graphics.ArbSync pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexBumpParameterfvATI", ExactSpelling = true)]
            internal extern static unsafe void GetTexBumpParameterfvATI(Pencil.Gaming.Graphics.AtiEnvmapBumpmap pname, [OutAttribute] Single* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexBumpParameterivATI", ExactSpelling = true)]
            internal extern static unsafe void GetTexBumpParameterivATI(Pencil.Gaming.Graphics.AtiEnvmapBumpmap pname, [OutAttribute] Int32* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexEnvfv(Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
            internal extern static unsafe void GetTexEnviv(Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexFilterFuncSGIS", ExactSpelling = true)]
            internal extern static unsafe void GetTexFilterFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.SgisTextureFilter4 filter, [OutAttribute] Single* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexGendv", ExactSpelling = true)]
            internal extern static unsafe void GetTexGendv(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexGenfv(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
            internal extern static unsafe void GetTexGeniv(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
            internal extern static void GetTexImage(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexLevelParameterfv(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexLevelParameteriv(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterfv(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterIiv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterIiv(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterIivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterIivEXT(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterIuiv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterIuiv(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterIuivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameterIuivEXT(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void GetTexParameteriv(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTexParameterPointervAPPLE", ExactSpelling = true)]
            internal extern static void GetTexParameterPointervAPPLE(Pencil.Gaming.Graphics.AppleTextureRange target, Pencil.Gaming.Graphics.AppleTextureRange pname, [OutAttribute] IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureImageEXT", ExactSpelling = true)]
            internal extern static void GetTextureImageEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureLevelParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTextureLevelParameterfvEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureLevelParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTextureLevelParameterivEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTextureParameterfvEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureParameterIivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTextureParameterIivEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureParameterIuivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTextureParameterIuivEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTextureParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTextureParameterivEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.GetTextureParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTrackMatrixivNV", ExactSpelling = true)]
            internal extern static unsafe void GetTrackMatrixivNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 address, Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTransformFeedbackVarying", ExactSpelling = true)]
            internal extern static unsafe void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] Pencil.Gaming.Graphics.ActiveAttribType* type, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTransformFeedbackVaryingEXT", ExactSpelling = true)]
            internal extern static unsafe void GetTransformFeedbackVaryingEXT(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] Pencil.Gaming.Graphics.ExtTransformFeedback* type, [OutAttribute] StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetTransformFeedbackVaryingNV", ExactSpelling = true)]
            internal extern static unsafe void GetTransformFeedbackVaryingNV(UInt32 program, UInt32 index, [OutAttribute] Int32* location);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformBlockIndex", ExactSpelling = true)]
            internal extern static Int32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformBufferSizeEXT", ExactSpelling = true)]
            internal extern static Int32 GetUniformBufferSizeEXT(UInt32 program, Int32 location);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformdv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetUniformfvARB(UInt32 programObj, Int32 location, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformi64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetUniformi64vNV(UInt32 program, Int32 location, [OutAttribute] Int64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformIndices", ExactSpelling = true)]
            internal extern static unsafe void GetUniformIndices(UInt32 program, Int32 uniformCount, String[] uniformNames, [OutAttribute] UInt32* uniformIndices);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformivARB", ExactSpelling = true)]
            internal extern static unsafe void GetUniformivARB(UInt32 programObj, Int32 location, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
            internal extern static Int32 GetUniformLocation(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformLocationARB", ExactSpelling = true)]
            internal extern static Int32 GetUniformLocationARB(UInt32 programObj, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformOffsetEXT", ExactSpelling = true)]
            internal extern static IntPtr GetUniformOffsetEXT(UInt32 program, Int32 location);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformSubroutineuiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformSubroutineuiv(Pencil.Gaming.Graphics.ShaderType shadertype, Int32 location, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformui64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetUniformui64vNV(UInt32 program, Int32 location, [OutAttribute] UInt64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformuiv", ExactSpelling = true)]
            internal extern static unsafe void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetUniformuivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetUniformuivEXT(UInt32 program, Int32 location, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVariantArrayObjectfvATI", ExactSpelling = true)]
            internal extern static unsafe void GetVariantArrayObjectfvATI(UInt32 id, Pencil.Gaming.Graphics.AtiVertexArrayObject pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVariantArrayObjectivATI", ExactSpelling = true)]
            internal extern static unsafe void GetVariantArrayObjectivATI(UInt32 id, Pencil.Gaming.Graphics.AtiVertexArrayObject pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVariantBooleanvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetVariantBooleanvEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] bool* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVariantFloatvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetVariantFloatvEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] Single* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVariantIntegervEXT", ExactSpelling = true)]
            internal extern static unsafe void GetVariantIntegervEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] Int32* data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVariantPointervEXT", ExactSpelling = true)]
            internal extern static void GetVariantPointervEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader value, [OutAttribute] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVaryingLocationNV", ExactSpelling = true)]
            internal extern static Int32 GetVaryingLocationNV(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribArrayObjectfvATI", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribArrayObjectfvATI(UInt32 index, Pencil.Gaming.Graphics.AtiVertexAttribArrayObject pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribArrayObjectivATI", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribArrayObjectivATI(UInt32 index, Pencil.Gaming.Graphics.AtiVertexAttribArrayObject pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribdv(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameter pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribdvARB", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribdvARB(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameterArb pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribdvNV", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribdvNV(UInt32 index, Pencil.Gaming.Graphics.NvVertexProgram pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribfv(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameter pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribfvARB", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribfvARB(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameterArb pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribfvNV(UInt32 index, Pencil.Gaming.Graphics.NvVertexProgram pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribIiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribIiv(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribIivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribIivEXT(UInt32 index, Pencil.Gaming.Graphics.NvVertexProgram4 pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribIuiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribIuiv(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameter pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribIuivEXT", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribIuivEXT(UInt32 index, Pencil.Gaming.Graphics.NvVertexProgram4 pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribiv(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameter pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribivARB", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribivARB(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameterArb pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribivNV", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribivNV(UInt32 index, Pencil.Gaming.Graphics.NvVertexProgram pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribLdv", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribLdv(UInt32 index, Pencil.Gaming.Graphics.VertexAttribParameter pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribLdvEXT", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribLdvEXT(UInt32 index, Pencil.Gaming.Graphics.ExtVertexAttrib64bit pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribLi64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribLi64vNV(UInt32 index, Pencil.Gaming.Graphics.NvVertexAttribInteger64bit pname, [OutAttribute] Int64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribLui64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetVertexAttribLui64vNV(UInt32 index, Pencil.Gaming.Graphics.NvVertexAttribInteger64bit pname, [OutAttribute] UInt64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
            internal extern static void GetVertexAttribPointerv(UInt32 index, Pencil.Gaming.Graphics.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribPointervARB", ExactSpelling = true)]
            internal extern static void GetVertexAttribPointervARB(UInt32 index, Pencil.Gaming.Graphics.VertexAttribPointerParameterArb pname, [OutAttribute] IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVertexAttribPointervNV", ExactSpelling = true)]
            internal extern static void GetVertexAttribPointervNV(UInt32 index, Pencil.Gaming.Graphics.NvVertexProgram pname, [OutAttribute] IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVideoCaptureivNV", ExactSpelling = true)]
            internal extern static unsafe void GetVideoCaptureivNV(UInt32 video_capture_slot, Pencil.Gaming.Graphics.NvVideoCapture pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVideoCaptureStreamdvNV", ExactSpelling = true)]
            internal extern static unsafe void GetVideoCaptureStreamdvNV(UInt32 video_capture_slot, UInt32 stream, Pencil.Gaming.Graphics.NvVideoCapture pname, [OutAttribute] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVideoCaptureStreamfvNV", ExactSpelling = true)]
            internal extern static unsafe void GetVideoCaptureStreamfvNV(UInt32 video_capture_slot, UInt32 stream, Pencil.Gaming.Graphics.NvVideoCapture pname, [OutAttribute] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVideoCaptureStreamivNV", ExactSpelling = true)]
            internal extern static unsafe void GetVideoCaptureStreamivNV(UInt32 video_capture_slot, UInt32 stream, Pencil.Gaming.Graphics.NvVideoCapture pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVideoi64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetVideoi64vNV(UInt32 video_slot, Pencil.Gaming.Graphics.NvPresentVideo pname, [OutAttribute] Int64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVideoivNV", ExactSpelling = true)]
            internal extern static unsafe void GetVideoivNV(UInt32 video_slot, Pencil.Gaming.Graphics.NvPresentVideo pname, [OutAttribute] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVideoui64vNV", ExactSpelling = true)]
            internal extern static unsafe void GetVideoui64vNV(UInt32 video_slot, Pencil.Gaming.Graphics.NvPresentVideo pname, [OutAttribute] UInt64* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGetVideouivNV", ExactSpelling = true)]
            internal extern static unsafe void GetVideouivNV(UInt32 video_slot, Pencil.Gaming.Graphics.NvPresentVideo pname, [OutAttribute] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGlobalAlphaFactorbSUN", ExactSpelling = true)]
            internal extern static void GlobalAlphaFactorbSUN(SByte factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGlobalAlphaFactordSUN", ExactSpelling = true)]
            internal extern static void GlobalAlphaFactordSUN(Double factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGlobalAlphaFactorfSUN", ExactSpelling = true)]
            internal extern static void GlobalAlphaFactorfSUN(Single factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGlobalAlphaFactoriSUN", ExactSpelling = true)]
            internal extern static void GlobalAlphaFactoriSUN(Int32 factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGlobalAlphaFactorsSUN", ExactSpelling = true)]
            internal extern static void GlobalAlphaFactorsSUN(Int16 factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGlobalAlphaFactorubSUN", ExactSpelling = true)]
            internal extern static void GlobalAlphaFactorubSUN(Byte factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGlobalAlphaFactoruiSUN", ExactSpelling = true)]
            internal extern static void GlobalAlphaFactoruiSUN(UInt32 factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glGlobalAlphaFactorusSUN", ExactSpelling = true)]
            internal extern static void GlobalAlphaFactorusSUN(UInt16 factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal extern static void Hint(Pencil.Gaming.Graphics.HintTarget target, Pencil.Gaming.Graphics.HintMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glHintPGI", ExactSpelling = true)]
            internal extern static void HintPGI(Pencil.Gaming.Graphics.PgiMiscHints target, Int32 mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glHistogram", ExactSpelling = true)]
            internal extern static void Histogram(Pencil.Gaming.Graphics.HistogramTarget target, Int32 width, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, bool sink);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glHistogramEXT", ExactSpelling = true)]
            internal extern static void HistogramEXT(Pencil.Gaming.Graphics.ExtHistogram target, Int32 width, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, bool sink);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIglooInterfaceSGIX", ExactSpelling = true)]
            internal extern static void IglooInterfaceSGIX(Pencil.Gaming.Graphics.All pname, IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glImageTransformParameterfHP", ExactSpelling = true)]
            internal extern static void ImageTransformParameterfHP(Pencil.Gaming.Graphics.HpImageTransform target, Pencil.Gaming.Graphics.HpImageTransform pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glImageTransformParameterfvHP", ExactSpelling = true)]
            internal extern static unsafe void ImageTransformParameterfvHP(Pencil.Gaming.Graphics.HpImageTransform target, Pencil.Gaming.Graphics.HpImageTransform pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glImageTransformParameteriHP", ExactSpelling = true)]
            internal extern static void ImageTransformParameteriHP(Pencil.Gaming.Graphics.HpImageTransform target, Pencil.Gaming.Graphics.HpImageTransform pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glImageTransformParameterivHP", ExactSpelling = true)]
            internal extern static unsafe void ImageTransformParameterivHP(Pencil.Gaming.Graphics.HpImageTransform target, Pencil.Gaming.Graphics.HpImageTransform pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glImportSyncEXT", ExactSpelling = true)]
            internal extern static IntPtr ImportSyncEXT(Pencil.Gaming.Graphics.ExtX11SyncObject external_sync_type, IntPtr external_sync, UInt32 flags);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexd", ExactSpelling = true)]
            internal extern static void Indexd(Double c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexdv", ExactSpelling = true)]
            internal extern static unsafe void Indexdv(Double* c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexf", ExactSpelling = true)]
            internal extern static void Indexf(Single c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexFormatNV", ExactSpelling = true)]
            internal extern static void IndexFormatNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexFuncEXT", ExactSpelling = true)]
            internal extern static void IndexFuncEXT(Pencil.Gaming.Graphics.ExtIndexFunc func, Single @ref);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexfv", ExactSpelling = true)]
            internal extern static unsafe void Indexfv(Single* c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexi", ExactSpelling = true)]
            internal extern static void Indexi(Int32 c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexiv", ExactSpelling = true)]
            internal extern static unsafe void Indexiv(Int32* c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexMask", ExactSpelling = true)]
            internal extern static void IndexMask(UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexMaterialEXT", ExactSpelling = true)]
            internal extern static void IndexMaterialEXT(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.ExtIndexMaterial mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexPointer", ExactSpelling = true)]
            internal extern static void IndexPointer(Pencil.Gaming.Graphics.IndexPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexPointerEXT", ExactSpelling = true)]
            internal extern static void IndexPointerEXT(Pencil.Gaming.Graphics.IndexPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexPointerListIBM", ExactSpelling = true)]
            internal extern static void IndexPointerListIBM(Pencil.Gaming.Graphics.IndexPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexs", ExactSpelling = true)]
            internal extern static void Indexs(Int16 c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexsv", ExactSpelling = true)]
            internal extern static unsafe void Indexsv(Int16* c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexub", ExactSpelling = true)]
            internal extern static void Indexub(Byte c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIndexubv", ExactSpelling = true)]
            internal extern static unsafe void Indexubv(Byte* c);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInitNames", ExactSpelling = true)]
            internal extern static void InitNames();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInsertComponentEXT", ExactSpelling = true)]
            internal extern static void InsertComponentEXT(UInt32 res, UInt32 src, UInt32 num);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInstrumentsBufferSGIX", ExactSpelling = true)]
            internal extern static unsafe void InstrumentsBufferSGIX(Int32 size, [OutAttribute] Int32* buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glInterleavedArrays", ExactSpelling = true)]
            internal extern static void InterleavedArrays(Pencil.Gaming.Graphics.InterleavedArrayFormat format, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsAsyncMarkerSGIX", ExactSpelling = true)]
            internal extern static bool IsAsyncMarkerSGIX(UInt32 marker);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal extern static bool IsBuffer(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsBufferARB", ExactSpelling = true)]
            internal extern static bool IsBufferARB(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsBufferResidentNV", ExactSpelling = true)]
            internal extern static bool IsBufferResidentNV(Pencil.Gaming.Graphics.NvShaderBufferLoad target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal extern static bool IsEnabled(Pencil.Gaming.Graphics.EnableCap cap);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsEnabledi", ExactSpelling = true)]
            internal extern static bool IsEnabledi(Pencil.Gaming.Graphics.IndexedEnableCap target, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsEnabledIndexedEXT", ExactSpelling = true)]
            internal extern static bool IsEnabledIndexedEXT(Pencil.Gaming.Graphics.IndexedEnableCap target, UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFenceAPPLE", ExactSpelling = true)]
            internal extern static bool IsFenceAPPLE(UInt32 fence);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFenceNV", ExactSpelling = true)]
            internal extern static bool IsFenceNV(UInt32 fence);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
            internal extern static bool IsFramebuffer(UInt32 framebuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsFramebufferEXT", ExactSpelling = true)]
            internal extern static bool IsFramebufferEXT(UInt32 framebuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsList", ExactSpelling = true)]
            internal extern static bool IsList(UInt32 list);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsNameAMD", ExactSpelling = true)]
            internal extern static bool IsNameAMD(Pencil.Gaming.Graphics.AmdNameGenDelete identifier, UInt32 name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsNamedBufferResidentNV", ExactSpelling = true)]
            internal extern static bool IsNamedBufferResidentNV(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsNamedStringARB", ExactSpelling = true)]
            internal extern static bool IsNamedStringARB(Int32 namelen, String name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsObjectBufferATI", ExactSpelling = true)]
            internal extern static bool IsObjectBufferATI(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsOcclusionQueryNV", ExactSpelling = true)]
            internal extern static bool IsOcclusionQueryNV(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
            internal extern static bool IsProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsProgramARB", ExactSpelling = true)]
            internal extern static bool IsProgramARB(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsProgramNV", ExactSpelling = true)]
            internal extern static bool IsProgramNV(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsProgramPipeline", ExactSpelling = true)]
            internal extern static bool IsProgramPipeline(UInt32 pipeline);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
            internal extern static bool IsQuery(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsQueryARB", ExactSpelling = true)]
            internal extern static bool IsQueryARB(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
            internal extern static bool IsRenderbuffer(UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsRenderbufferEXT", ExactSpelling = true)]
            internal extern static bool IsRenderbufferEXT(UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsSampler", ExactSpelling = true)]
            internal extern static bool IsSampler(UInt32 sampler);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsShader", ExactSpelling = true)]
            internal extern static bool IsShader(UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsSync", ExactSpelling = true)]
            internal extern static bool IsSync(IntPtr sync);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
            internal extern static bool IsTexture(UInt32 texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsTextureEXT", ExactSpelling = true)]
            internal extern static bool IsTextureEXT(UInt32 texture);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsTransformFeedback", ExactSpelling = true)]
            internal extern static bool IsTransformFeedback(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsTransformFeedbackNV", ExactSpelling = true)]
            internal extern static bool IsTransformFeedbackNV(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsVariantEnabledEXT", ExactSpelling = true)]
            internal extern static bool IsVariantEnabledEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader cap);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsVertexArray", ExactSpelling = true)]
            internal extern static bool IsVertexArray(UInt32 array);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsVertexArrayAPPLE", ExactSpelling = true)]
            internal extern static bool IsVertexArrayAPPLE(UInt32 array);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glIsVertexAttribEnabledAPPLE", ExactSpelling = true)]
            internal extern static bool IsVertexAttribEnabledAPPLE(UInt32 index, Pencil.Gaming.Graphics.AppleVertexProgramEvaluators pname);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightEnviSGIX", ExactSpelling = true)]
            internal extern static void LightEnviSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightf", ExactSpelling = true)]
            internal extern static void Lightf(Pencil.Gaming.Graphics.LightName light, Pencil.Gaming.Graphics.LightParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightfv", ExactSpelling = true)]
            internal extern static unsafe void Lightfv(Pencil.Gaming.Graphics.LightName light, Pencil.Gaming.Graphics.LightParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLighti", ExactSpelling = true)]
            internal extern static void Lighti(Pencil.Gaming.Graphics.LightName light, Pencil.Gaming.Graphics.LightParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightiv", ExactSpelling = true)]
            internal extern static unsafe void Lightiv(Pencil.Gaming.Graphics.LightName light, Pencil.Gaming.Graphics.LightParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
            internal extern static void LightModelf(Pencil.Gaming.Graphics.LightModelParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
            internal extern static unsafe void LightModelfv(Pencil.Gaming.Graphics.LightModelParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModeli", ExactSpelling = true)]
            internal extern static void LightModeli(Pencil.Gaming.Graphics.LightModelParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLightModeliv", ExactSpelling = true)]
            internal extern static unsafe void LightModeliv(Pencil.Gaming.Graphics.LightModelParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLineStipple", ExactSpelling = true)]
            internal extern static void LineStipple(Int32 factor, UInt16 pattern);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal extern static void LineWidth(Single width);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
            internal extern static void LinkProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLinkProgramARB", ExactSpelling = true)]
            internal extern static void LinkProgramARB(UInt32 programObj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glListBase", ExactSpelling = true)]
            internal extern static void ListBase(UInt32 @base);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glListParameterfSGIX", ExactSpelling = true)]
            internal extern static void ListParameterfSGIX(UInt32 list, Pencil.Gaming.Graphics.ListParameterName pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glListParameterfvSGIX", ExactSpelling = true)]
            internal extern static unsafe void ListParameterfvSGIX(UInt32 list, Pencil.Gaming.Graphics.ListParameterName pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glListParameteriSGIX", ExactSpelling = true)]
            internal extern static void ListParameteriSGIX(UInt32 list, Pencil.Gaming.Graphics.ListParameterName pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glListParameterivSGIX", ExactSpelling = true)]
            internal extern static unsafe void ListParameterivSGIX(UInt32 list, Pencil.Gaming.Graphics.ListParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
            internal extern static void LoadIdentity();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadIdentityDeformationMapSGIX", ExactSpelling = true)]
            internal extern static void LoadIdentityDeformationMapSGIX(UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixd(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
            internal extern static unsafe void LoadMatrixf(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadName", ExactSpelling = true)]
            internal extern static void LoadName(UInt32 name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadProgramNV", ExactSpelling = true)]
            internal extern static unsafe void LoadProgramNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 id, Int32 len, Byte* program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadTransposeMatrixd", ExactSpelling = true)]
            internal extern static unsafe void LoadTransposeMatrixd(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadTransposeMatrixdARB", ExactSpelling = true)]
            internal extern static unsafe void LoadTransposeMatrixdARB(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadTransposeMatrixf", ExactSpelling = true)]
            internal extern static unsafe void LoadTransposeMatrixf(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLoadTransposeMatrixfARB", ExactSpelling = true)]
            internal extern static unsafe void LoadTransposeMatrixfARB(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLockArraysEXT", ExactSpelling = true)]
            internal extern static void LockArraysEXT(Int32 first, Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal extern static void LogicOp(Pencil.Gaming.Graphics.LogicOp opcode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMakeBufferNonResidentNV", ExactSpelling = true)]
            internal extern static void MakeBufferNonResidentNV(Pencil.Gaming.Graphics.NvShaderBufferLoad target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMakeBufferResidentNV", ExactSpelling = true)]
            internal extern static void MakeBufferResidentNV(Pencil.Gaming.Graphics.NvShaderBufferLoad target, Pencil.Gaming.Graphics.NvShaderBufferLoad access);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMakeNamedBufferNonResidentNV", ExactSpelling = true)]
            internal extern static void MakeNamedBufferNonResidentNV(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMakeNamedBufferResidentNV", ExactSpelling = true)]
            internal extern static void MakeNamedBufferResidentNV(UInt32 buffer, Pencil.Gaming.Graphics.NvShaderBufferLoad access);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMap1d", ExactSpelling = true)]
            internal extern static unsafe void Map1d(Pencil.Gaming.Graphics.MapTarget target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMap1f", ExactSpelling = true)]
            internal extern static unsafe void Map1f(Pencil.Gaming.Graphics.MapTarget target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMap2d", ExactSpelling = true)]
            internal extern static unsafe void Map2d(Pencil.Gaming.Graphics.MapTarget target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMap2f", ExactSpelling = true)]
            internal extern static unsafe void Map2f(Pencil.Gaming.Graphics.MapTarget target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
            internal extern static unsafe IntPtr MapBuffer(Pencil.Gaming.Graphics.BufferTarget target, Pencil.Gaming.Graphics.BufferAccess access);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBufferARB", ExactSpelling = true)]
            internal extern static unsafe IntPtr MapBufferARB(Pencil.Gaming.Graphics.BufferTargetArb target, Pencil.Gaming.Graphics.ArbVertexBufferObject access);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapBufferRange", ExactSpelling = true)]
            internal extern static unsafe IntPtr MapBufferRange(Pencil.Gaming.Graphics.BufferTarget target, IntPtr offset, IntPtr length, Pencil.Gaming.Graphics.BufferAccessMask access);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapControlPointsNV", ExactSpelling = true)]
            internal extern static void MapControlPointsNV(Pencil.Gaming.Graphics.NvEvaluators target, UInt32 index, Pencil.Gaming.Graphics.NvEvaluators type, Int32 ustride, Int32 vstride, Int32 uorder, Int32 vorder, bool packed, IntPtr points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapGrid1d", ExactSpelling = true)]
            internal extern static void MapGrid1d(Int32 un, Double u1, Double u2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapGrid1f", ExactSpelling = true)]
            internal extern static void MapGrid1f(Int32 un, Single u1, Single u2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapGrid2d", ExactSpelling = true)]
            internal extern static void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapGrid2f", ExactSpelling = true)]
            internal extern static void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapNamedBufferEXT", ExactSpelling = true)]
            internal extern static unsafe IntPtr MapNamedBufferEXT(UInt32 buffer, Pencil.Gaming.Graphics.ExtDirectStateAccess access);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapNamedBufferRangeEXT", ExactSpelling = true)]
            internal extern static unsafe IntPtr MapNamedBufferRangeEXT(UInt32 buffer, IntPtr offset, IntPtr length, Pencil.Gaming.Graphics.BufferAccessMask access);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapObjectBufferATI", ExactSpelling = true)]
            internal extern static unsafe IntPtr MapObjectBufferATI(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void MapParameterfvNV(Pencil.Gaming.Graphics.NvEvaluators target, Pencil.Gaming.Graphics.NvEvaluators pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void MapParameterivNV(Pencil.Gaming.Graphics.NvEvaluators target, Pencil.Gaming.Graphics.NvEvaluators pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapVertexAttrib1dAPPLE", ExactSpelling = true)]
            internal extern static unsafe void MapVertexAttrib1dAPPLE(UInt32 index, UInt32 size, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapVertexAttrib1fAPPLE", ExactSpelling = true)]
            internal extern static unsafe void MapVertexAttrib1fAPPLE(UInt32 index, UInt32 size, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapVertexAttrib2dAPPLE", ExactSpelling = true)]
            internal extern static unsafe void MapVertexAttrib2dAPPLE(UInt32 index, UInt32 size, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMapVertexAttrib2fAPPLE", ExactSpelling = true)]
            internal extern static unsafe void MapVertexAttrib2fAPPLE(UInt32 index, UInt32 size, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
            internal extern static void Materialf(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
            internal extern static unsafe void Materialfv(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMateriali", ExactSpelling = true)]
            internal extern static void Materiali(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMaterialiv", ExactSpelling = true)]
            internal extern static unsafe void Materialiv(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixFrustumEXT", ExactSpelling = true)]
            internal extern static void MatrixFrustumEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixIndexPointerARB", ExactSpelling = true)]
            internal extern static void MatrixIndexPointerARB(Int32 size, Pencil.Gaming.Graphics.ArbMatrixPalette type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixIndexubvARB", ExactSpelling = true)]
            internal extern static unsafe void MatrixIndexubvARB(Int32 size, Byte* indices);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixIndexuivARB", ExactSpelling = true)]
            internal extern static unsafe void MatrixIndexuivARB(Int32 size, UInt32* indices);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixIndexusvARB", ExactSpelling = true)]
            internal extern static unsafe void MatrixIndexusvARB(Int32 size, UInt16* indices);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixLoaddEXT", ExactSpelling = true)]
            internal extern static unsafe void MatrixLoaddEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixLoadfEXT", ExactSpelling = true)]
            internal extern static unsafe void MatrixLoadfEXT(Pencil.Gaming.Graphics.MatrixMode mode, Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixLoadIdentityEXT", ExactSpelling = true)]
            internal extern static void MatrixLoadIdentityEXT(Pencil.Gaming.Graphics.MatrixMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixLoadTransposedEXT", ExactSpelling = true)]
            internal extern static unsafe void MatrixLoadTransposedEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixLoadTransposefEXT", ExactSpelling = true)]
            internal extern static unsafe void MatrixLoadTransposefEXT(Pencil.Gaming.Graphics.MatrixMode mode, Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
            internal extern static void MatrixMode(Pencil.Gaming.Graphics.MatrixMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixMultdEXT", ExactSpelling = true)]
            internal extern static unsafe void MatrixMultdEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixMultfEXT", ExactSpelling = true)]
            internal extern static unsafe void MatrixMultfEXT(Pencil.Gaming.Graphics.MatrixMode mode, Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixMultTransposedEXT", ExactSpelling = true)]
            internal extern static unsafe void MatrixMultTransposedEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixMultTransposefEXT", ExactSpelling = true)]
            internal extern static unsafe void MatrixMultTransposefEXT(Pencil.Gaming.Graphics.MatrixMode mode, Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixOrthoEXT", ExactSpelling = true)]
            internal extern static void MatrixOrthoEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixPopEXT", ExactSpelling = true)]
            internal extern static void MatrixPopEXT(Pencil.Gaming.Graphics.MatrixMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixPushEXT", ExactSpelling = true)]
            internal extern static void MatrixPushEXT(Pencil.Gaming.Graphics.MatrixMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixRotatedEXT", ExactSpelling = true)]
            internal extern static void MatrixRotatedEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double angle, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixRotatefEXT", ExactSpelling = true)]
            internal extern static void MatrixRotatefEXT(Pencil.Gaming.Graphics.MatrixMode mode, Single angle, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixScaledEXT", ExactSpelling = true)]
            internal extern static void MatrixScaledEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixScalefEXT", ExactSpelling = true)]
            internal extern static void MatrixScalefEXT(Pencil.Gaming.Graphics.MatrixMode mode, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixTranslatedEXT", ExactSpelling = true)]
            internal extern static void MatrixTranslatedEXT(Pencil.Gaming.Graphics.MatrixMode mode, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMatrixTranslatefEXT", ExactSpelling = true)]
            internal extern static void MatrixTranslatefEXT(Pencil.Gaming.Graphics.MatrixMode mode, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMemoryBarrierEXT", ExactSpelling = true)]
            internal extern static void MemoryBarrierEXT(UInt32 barriers);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMinmax", ExactSpelling = true)]
            internal extern static void Minmax(Pencil.Gaming.Graphics.MinmaxTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, bool sink);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMinmaxEXT", ExactSpelling = true)]
            internal extern static void MinmaxEXT(Pencil.Gaming.Graphics.ExtHistogram target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, bool sink);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMinSampleShading", ExactSpelling = true)]
            internal extern static void MinSampleShading(Single value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMinSampleShadingARB", ExactSpelling = true)]
            internal extern static void MinSampleShadingARB(Single value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawArrays(Pencil.Gaming.Graphics.BeginMode mode, Int32* first, Int32* count, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawArraysEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawArraysEXT(Pencil.Gaming.Graphics.BeginMode mode, Int32* first, Int32* count, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawArraysIndirectAMD", ExactSpelling = true)]
            internal extern static void MultiDrawArraysIndirectAMD(Pencil.Gaming.Graphics.AmdMultiDrawIndirect mode, IntPtr indirect, Int32 primcount, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementArrayAPPLE", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElementArrayAPPLE(Pencil.Gaming.Graphics.BeginMode mode, Int32* first, Int32* count, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElements(Pencil.Gaming.Graphics.BeginMode mode, Int32* count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementsBaseVertex", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode, Int32* count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 primcount, Int32* basevertex);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementsEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawElementsEXT(Pencil.Gaming.Graphics.BeginMode mode, Int32* count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawElementsIndirectAMD", ExactSpelling = true)]
            internal extern static void MultiDrawElementsIndirectAMD(Pencil.Gaming.Graphics.AmdMultiDrawIndirect mode, Pencil.Gaming.Graphics.AmdMultiDrawIndirect type, IntPtr indirect, Int32 primcount, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiDrawRangeElementArrayAPPLE", ExactSpelling = true)]
            internal extern static unsafe void MultiDrawRangeElementArrayAPPLE(Pencil.Gaming.Graphics.BeginMode mode, UInt32 start, UInt32 end, Int32* first, Int32* count, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiModeDrawArraysIBM", ExactSpelling = true)]
            internal extern static unsafe void MultiModeDrawArraysIBM(Pencil.Gaming.Graphics.BeginMode* mode, Int32* first, Int32* count, Int32 primcount, Int32 modestride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiModeDrawElementsIBM", ExactSpelling = true)]
            internal extern static unsafe void MultiModeDrawElementsIBM(Pencil.Gaming.Graphics.BeginMode* mode, Int32* count, Pencil.Gaming.Graphics.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 modestride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexBufferEXT", ExactSpelling = true)]
            internal extern static void MultiTexBufferEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1d", ExactSpelling = true)]
            internal extern static void MultiTexCoord1d(Pencil.Gaming.Graphics.TextureUnit target, Double s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1dARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord1dARB(Pencil.Gaming.Graphics.TextureUnit target, Double s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1dv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1dv(Pencil.Gaming.Graphics.TextureUnit target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1dvARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1dvARB(Pencil.Gaming.Graphics.TextureUnit target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1f", ExactSpelling = true)]
            internal extern static void MultiTexCoord1f(Pencil.Gaming.Graphics.TextureUnit target, Single s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1fARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord1fARB(Pencil.Gaming.Graphics.TextureUnit target, Single s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1fv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1fv(Pencil.Gaming.Graphics.TextureUnit target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1fvARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1fvARB(Pencil.Gaming.Graphics.TextureUnit target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1i", ExactSpelling = true)]
            internal extern static void MultiTexCoord1i(Pencil.Gaming.Graphics.TextureUnit target, Int32 s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1iARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord1iARB(Pencil.Gaming.Graphics.TextureUnit target, Int32 s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1iv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1iv(Pencil.Gaming.Graphics.TextureUnit target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1ivARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1ivARB(Pencil.Gaming.Graphics.TextureUnit target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1s", ExactSpelling = true)]
            internal extern static void MultiTexCoord1s(Pencil.Gaming.Graphics.TextureUnit target, Int16 s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1sARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord1sARB(Pencil.Gaming.Graphics.TextureUnit target, Int16 s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1sv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1sv(Pencil.Gaming.Graphics.TextureUnit target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord1svARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord1svARB(Pencil.Gaming.Graphics.TextureUnit target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2d", ExactSpelling = true)]
            internal extern static void MultiTexCoord2d(Pencil.Gaming.Graphics.TextureUnit target, Double s, Double t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2dARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord2dARB(Pencil.Gaming.Graphics.TextureUnit target, Double s, Double t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2dv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2dv(Pencil.Gaming.Graphics.TextureUnit target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2dvARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2dvARB(Pencil.Gaming.Graphics.TextureUnit target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2f", ExactSpelling = true)]
            internal extern static void MultiTexCoord2f(Pencil.Gaming.Graphics.TextureUnit target, Single s, Single t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2fARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord2fARB(Pencil.Gaming.Graphics.TextureUnit target, Single s, Single t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2fv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2fv(Pencil.Gaming.Graphics.TextureUnit target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2fvARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2fvARB(Pencil.Gaming.Graphics.TextureUnit target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2i", ExactSpelling = true)]
            internal extern static void MultiTexCoord2i(Pencil.Gaming.Graphics.TextureUnit target, Int32 s, Int32 t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2iARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord2iARB(Pencil.Gaming.Graphics.TextureUnit target, Int32 s, Int32 t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2iv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2iv(Pencil.Gaming.Graphics.TextureUnit target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2ivARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2ivARB(Pencil.Gaming.Graphics.TextureUnit target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2s", ExactSpelling = true)]
            internal extern static void MultiTexCoord2s(Pencil.Gaming.Graphics.TextureUnit target, Int16 s, Int16 t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2sARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord2sARB(Pencil.Gaming.Graphics.TextureUnit target, Int16 s, Int16 t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2sv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2sv(Pencil.Gaming.Graphics.TextureUnit target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord2svARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord2svARB(Pencil.Gaming.Graphics.TextureUnit target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3d", ExactSpelling = true)]
            internal extern static void MultiTexCoord3d(Pencil.Gaming.Graphics.TextureUnit target, Double s, Double t, Double r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3dARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord3dARB(Pencil.Gaming.Graphics.TextureUnit target, Double s, Double t, Double r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3dv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3dv(Pencil.Gaming.Graphics.TextureUnit target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3dvARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3dvARB(Pencil.Gaming.Graphics.TextureUnit target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3f", ExactSpelling = true)]
            internal extern static void MultiTexCoord3f(Pencil.Gaming.Graphics.TextureUnit target, Single s, Single t, Single r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3fARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord3fARB(Pencil.Gaming.Graphics.TextureUnit target, Single s, Single t, Single r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3fv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3fv(Pencil.Gaming.Graphics.TextureUnit target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3fvARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3fvARB(Pencil.Gaming.Graphics.TextureUnit target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3i", ExactSpelling = true)]
            internal extern static void MultiTexCoord3i(Pencil.Gaming.Graphics.TextureUnit target, Int32 s, Int32 t, Int32 r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3iARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord3iARB(Pencil.Gaming.Graphics.TextureUnit target, Int32 s, Int32 t, Int32 r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3iv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3iv(Pencil.Gaming.Graphics.TextureUnit target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3ivARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3ivARB(Pencil.Gaming.Graphics.TextureUnit target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3s", ExactSpelling = true)]
            internal extern static void MultiTexCoord3s(Pencil.Gaming.Graphics.TextureUnit target, Int16 s, Int16 t, Int16 r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3sARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord3sARB(Pencil.Gaming.Graphics.TextureUnit target, Int16 s, Int16 t, Int16 r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3sv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3sv(Pencil.Gaming.Graphics.TextureUnit target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord3svARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord3svARB(Pencil.Gaming.Graphics.TextureUnit target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4d", ExactSpelling = true)]
            internal extern static void MultiTexCoord4d(Pencil.Gaming.Graphics.TextureUnit target, Double s, Double t, Double r, Double q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4dARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord4dARB(Pencil.Gaming.Graphics.TextureUnit target, Double s, Double t, Double r, Double q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4dv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4dv(Pencil.Gaming.Graphics.TextureUnit target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4dvARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4dvARB(Pencil.Gaming.Graphics.TextureUnit target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
            internal extern static void MultiTexCoord4f(Pencil.Gaming.Graphics.TextureUnit target, Single s, Single t, Single r, Single q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4fARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord4fARB(Pencil.Gaming.Graphics.TextureUnit target, Single s, Single t, Single r, Single q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4fv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4fv(Pencil.Gaming.Graphics.TextureUnit target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4fvARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4fvARB(Pencil.Gaming.Graphics.TextureUnit target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4i", ExactSpelling = true)]
            internal extern static void MultiTexCoord4i(Pencil.Gaming.Graphics.TextureUnit target, Int32 s, Int32 t, Int32 r, Int32 q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4iARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord4iARB(Pencil.Gaming.Graphics.TextureUnit target, Int32 s, Int32 t, Int32 r, Int32 q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4iv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4iv(Pencil.Gaming.Graphics.TextureUnit target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4ivARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4ivARB(Pencil.Gaming.Graphics.TextureUnit target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4s", ExactSpelling = true)]
            internal extern static void MultiTexCoord4s(Pencil.Gaming.Graphics.TextureUnit target, Int16 s, Int16 t, Int16 r, Int16 q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4sARB", ExactSpelling = true)]
            internal extern static void MultiTexCoord4sARB(Pencil.Gaming.Graphics.TextureUnit target, Int16 s, Int16 t, Int16 r, Int16 q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4sv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4sv(Pencil.Gaming.Graphics.TextureUnit target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoord4svARB", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoord4svARB(Pencil.Gaming.Graphics.TextureUnit target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP1ui", ExactSpelling = true)]
            internal extern static void MultiTexCoordP1ui(Pencil.Gaming.Graphics.TextureUnit texture, Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP1uiv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoordP1uiv(Pencil.Gaming.Graphics.TextureUnit texture, Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP2ui", ExactSpelling = true)]
            internal extern static void MultiTexCoordP2ui(Pencil.Gaming.Graphics.TextureUnit texture, Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP2uiv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoordP2uiv(Pencil.Gaming.Graphics.TextureUnit texture, Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP3ui", ExactSpelling = true)]
            internal extern static void MultiTexCoordP3ui(Pencil.Gaming.Graphics.TextureUnit texture, Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP3uiv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoordP3uiv(Pencil.Gaming.Graphics.TextureUnit texture, Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP4ui", ExactSpelling = true)]
            internal extern static void MultiTexCoordP4ui(Pencil.Gaming.Graphics.TextureUnit texture, Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordP4uiv", ExactSpelling = true)]
            internal extern static unsafe void MultiTexCoordP4uiv(Pencil.Gaming.Graphics.TextureUnit texture, Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexCoordPointerEXT", ExactSpelling = true)]
            internal extern static void MultiTexCoordPointerEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Int32 size, Pencil.Gaming.Graphics.TexCoordPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexEnvfEXT", ExactSpelling = true)]
            internal extern static void MultiTexEnvfEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexEnvfvEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexEnvfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexEnviEXT", ExactSpelling = true)]
            internal extern static void MultiTexEnviEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexEnvivEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexEnvivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexGendEXT", ExactSpelling = true)]
            internal extern static void MultiTexGendEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Double param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexGendvEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexGendvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexGenfEXT", ExactSpelling = true)]
            internal extern static void MultiTexGenfEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexGenfvEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexGenfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexGeniEXT", ExactSpelling = true)]
            internal extern static void MultiTexGeniEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexGenivEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexGenivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexImage1DEXT", ExactSpelling = true)]
            internal extern static void MultiTexImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexImage2DEXT", ExactSpelling = true)]
            internal extern static void MultiTexImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexImage3DEXT", ExactSpelling = true)]
            internal extern static void MultiTexImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexParameterfEXT", ExactSpelling = true)]
            internal extern static void MultiTexParameterfEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexParameterfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexParameteriEXT", ExactSpelling = true)]
            internal extern static void MultiTexParameteriEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexParameterIivEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexParameterIivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexParameterIuivEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexParameterIuivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void MultiTexParameterivEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexRenderbufferEXT", ExactSpelling = true)]
            internal extern static void MultiTexRenderbufferEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexSubImage1DEXT", ExactSpelling = true)]
            internal extern static void MultiTexSubImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexSubImage2DEXT", ExactSpelling = true)]
            internal extern static void MultiTexSubImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultiTexSubImage3DEXT", ExactSpelling = true)]
            internal extern static void MultiTexSubImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultMatrixd", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixd(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
            internal extern static unsafe void MultMatrixf(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultTransposeMatrixd", ExactSpelling = true)]
            internal extern static unsafe void MultTransposeMatrixd(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultTransposeMatrixdARB", ExactSpelling = true)]
            internal extern static unsafe void MultTransposeMatrixdARB(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultTransposeMatrixf", ExactSpelling = true)]
            internal extern static unsafe void MultTransposeMatrixf(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glMultTransposeMatrixfARB", ExactSpelling = true)]
            internal extern static unsafe void MultTransposeMatrixfARB(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedBufferDataEXT", ExactSpelling = true)]
            internal extern static void NamedBufferDataEXT(UInt32 buffer, IntPtr size, IntPtr data, Pencil.Gaming.Graphics.ExtDirectStateAccess usage);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedBufferSubDataEXT", ExactSpelling = true)]
            internal extern static void NamedBufferSubDataEXT(UInt32 buffer, IntPtr offset, IntPtr size, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedCopyBufferSubDataEXT", ExactSpelling = true)]
            internal extern static void NamedCopyBufferSubDataEXT(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedFramebufferRenderbufferEXT", ExactSpelling = true)]
            internal extern static void NamedFramebufferRenderbufferEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedFramebufferTexture1DEXT", ExactSpelling = true)]
            internal extern static void NamedFramebufferTexture1DEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedFramebufferTexture2DEXT", ExactSpelling = true)]
            internal extern static void NamedFramebufferTexture2DEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedFramebufferTexture3DEXT", ExactSpelling = true)]
            internal extern static void NamedFramebufferTexture3DEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferAttachment attachment, Pencil.Gaming.Graphics.TextureTarget textarget, UInt32 texture, Int32 level, Int32 zoffset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedFramebufferTextureEXT", ExactSpelling = true)]
            internal extern static void NamedFramebufferTextureEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedFramebufferTextureFaceEXT", ExactSpelling = true)]
            internal extern static void NamedFramebufferTextureFaceEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level, Pencil.Gaming.Graphics.TextureTarget face);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedFramebufferTextureLayerEXT", ExactSpelling = true)]
            internal extern static void NamedFramebufferTextureLayerEXT(UInt32 framebuffer, Pencil.Gaming.Graphics.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameter4dEXT", ExactSpelling = true)]
            internal extern static void NamedProgramLocalParameter4dEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameter4dvEXT", ExactSpelling = true)]
            internal extern static unsafe void NamedProgramLocalParameter4dvEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameter4fEXT", ExactSpelling = true)]
            internal extern static void NamedProgramLocalParameter4fEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameter4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void NamedProgramLocalParameter4fvEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameterI4iEXT", ExactSpelling = true)]
            internal extern static void NamedProgramLocalParameterI4iEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameterI4ivEXT", ExactSpelling = true)]
            internal extern static unsafe void NamedProgramLocalParameterI4ivEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameterI4uiEXT", ExactSpelling = true)]
            internal extern static void NamedProgramLocalParameterI4uiEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameterI4uivEXT", ExactSpelling = true)]
            internal extern static unsafe void NamedProgramLocalParameterI4uivEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParameters4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void NamedProgramLocalParameters4fvEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Int32 count, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParametersI4ivEXT", ExactSpelling = true)]
            internal extern static unsafe void NamedProgramLocalParametersI4ivEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Int32 count, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramLocalParametersI4uivEXT", ExactSpelling = true)]
            internal extern static unsafe void NamedProgramLocalParametersI4uivEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, UInt32 index, Int32 count, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedProgramStringEXT", ExactSpelling = true)]
            internal extern static void NamedProgramStringEXT(UInt32 program, Pencil.Gaming.Graphics.ExtDirectStateAccess target, Pencil.Gaming.Graphics.ExtDirectStateAccess format, Int32 len, IntPtr @string);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedRenderbufferStorageEXT", ExactSpelling = true)]
            internal extern static void NamedRenderbufferStorageEXT(UInt32 renderbuffer, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedRenderbufferStorageMultisampleCoverageEXT", ExactSpelling = true)]
            internal extern static void NamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer, Int32 coverageSamples, Int32 colorSamples, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
            internal extern static void NamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer, Int32 samples, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNamedStringARB", ExactSpelling = true)]
            internal extern static void NamedStringARB(Pencil.Gaming.Graphics.ArbShadingLanguageInclude type, Int32 namelen, String name, Int32 stringlen, String @string);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNewList", ExactSpelling = true)]
            internal extern static void NewList(UInt32 list, Pencil.Gaming.Graphics.ListMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNewObjectBufferATI", ExactSpelling = true)]
            internal extern static Int32 NewObjectBufferATI(Int32 size, IntPtr pointer, Pencil.Gaming.Graphics.AtiVertexArrayObject usage);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3b", ExactSpelling = true)]
            internal extern static void Normal3b(SByte nx, SByte ny, SByte nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3bv", ExactSpelling = true)]
            internal extern static unsafe void Normal3bv(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3d", ExactSpelling = true)]
            internal extern static void Normal3d(Double nx, Double ny, Double nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3dv", ExactSpelling = true)]
            internal extern static unsafe void Normal3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
            internal extern static void Normal3f(Single nx, Single ny, Single nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3fv", ExactSpelling = true)]
            internal extern static unsafe void Normal3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void Normal3fVertex3fSUN(Single nx, Single ny, Single nz, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void Normal3fVertex3fvSUN(Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3i", ExactSpelling = true)]
            internal extern static void Normal3i(Int32 nx, Int32 ny, Int32 nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3iv", ExactSpelling = true)]
            internal extern static unsafe void Normal3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3s", ExactSpelling = true)]
            internal extern static void Normal3s(Int16 nx, Int16 ny, Int16 nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormal3sv", ExactSpelling = true)]
            internal extern static unsafe void Normal3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalFormatNV", ExactSpelling = true)]
            internal extern static void NormalFormatNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalP3ui", ExactSpelling = true)]
            internal extern static void NormalP3ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalP3uiv", ExactSpelling = true)]
            internal extern static unsafe void NormalP3uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
            internal extern static void NormalPointer(Pencil.Gaming.Graphics.NormalPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalPointerEXT", ExactSpelling = true)]
            internal extern static void NormalPointerEXT(Pencil.Gaming.Graphics.NormalPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalPointerListIBM", ExactSpelling = true)]
            internal extern static void NormalPointerListIBM(Pencil.Gaming.Graphics.NormalPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalPointervINTEL", ExactSpelling = true)]
            internal extern static void NormalPointervINTEL(Pencil.Gaming.Graphics.NormalPointerType type, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3bATI", ExactSpelling = true)]
            internal extern static void NormalStream3bATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, SByte nx, SByte ny, SByte nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3bvATI", ExactSpelling = true)]
            internal extern static unsafe void NormalStream3bvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, SByte* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3dATI", ExactSpelling = true)]
            internal extern static void NormalStream3dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double nx, Double ny, Double nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3dvATI", ExactSpelling = true)]
            internal extern static unsafe void NormalStream3dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3fATI", ExactSpelling = true)]
            internal extern static void NormalStream3fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single nx, Single ny, Single nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3fvATI", ExactSpelling = true)]
            internal extern static unsafe void NormalStream3fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3iATI", ExactSpelling = true)]
            internal extern static void NormalStream3iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32 nx, Int32 ny, Int32 nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3ivATI", ExactSpelling = true)]
            internal extern static unsafe void NormalStream3ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3sATI", ExactSpelling = true)]
            internal extern static void NormalStream3sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16 nx, Int16 ny, Int16 nz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glNormalStream3svATI", ExactSpelling = true)]
            internal extern static unsafe void NormalStream3svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectPurgeableAPPLE", ExactSpelling = true)]
            internal extern static Pencil.Gaming.Graphics.AppleObjectPurgeable ObjectPurgeableAPPLE(Pencil.Gaming.Graphics.AppleObjectPurgeable objectType, UInt32 name, Pencil.Gaming.Graphics.AppleObjectPurgeable option);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glObjectUnpurgeableAPPLE", ExactSpelling = true)]
            internal extern static Pencil.Gaming.Graphics.AppleObjectPurgeable ObjectUnpurgeableAPPLE(Pencil.Gaming.Graphics.AppleObjectPurgeable objectType, UInt32 name, Pencil.Gaming.Graphics.AppleObjectPurgeable option);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glOrtho", ExactSpelling = true)]
            internal extern static void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPassTexCoordATI", ExactSpelling = true)]
            internal extern static void PassTexCoordATI(UInt32 dst, UInt32 coord, Pencil.Gaming.Graphics.AtiFragmentShader swizzle);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPassThrough", ExactSpelling = true)]
            internal extern static void PassThrough(Single token);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPatchParameterfv", ExactSpelling = true)]
            internal extern static unsafe void PatchParameterfv(Pencil.Gaming.Graphics.PatchParameterFloat pname, Single* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPatchParameteri", ExactSpelling = true)]
            internal extern static void PatchParameteri(Pencil.Gaming.Graphics.PatchParameterInt pname, Int32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPauseTransformFeedback", ExactSpelling = true)]
            internal extern static void PauseTransformFeedback();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPauseTransformFeedbackNV", ExactSpelling = true)]
            internal extern static void PauseTransformFeedbackNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelDataRangeNV", ExactSpelling = true)]
            internal extern static void PixelDataRangeNV(Pencil.Gaming.Graphics.NvPixelDataRange target, Int32 length, [OutAttribute] IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelMapfv", ExactSpelling = true)]
            internal extern static unsafe void PixelMapfv(Pencil.Gaming.Graphics.PixelMap map, Int32 mapsize, Single* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
            internal extern static unsafe void PixelMapuiv(Pencil.Gaming.Graphics.PixelMap map, Int32 mapsize, UInt32* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelMapusv", ExactSpelling = true)]
            internal extern static unsafe void PixelMapusv(Pencil.Gaming.Graphics.PixelMap map, Int32 mapsize, UInt16* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
            internal extern static void PixelStoref(Pencil.Gaming.Graphics.PixelStoreParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal extern static void PixelStorei(Pencil.Gaming.Graphics.PixelStoreParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTexGenParameterfSGIS", ExactSpelling = true)]
            internal extern static void PixelTexGenParameterfSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTexGenParameterfvSGIS", ExactSpelling = true)]
            internal extern static unsafe void PixelTexGenParameterfvSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTexGenParameteriSGIS", ExactSpelling = true)]
            internal extern static void PixelTexGenParameteriSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTexGenParameterivSGIS", ExactSpelling = true)]
            internal extern static unsafe void PixelTexGenParameterivSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTexGenSGIX", ExactSpelling = true)]
            internal extern static void PixelTexGenSGIX(Pencil.Gaming.Graphics.SgixPixelTexture mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTransferf", ExactSpelling = true)]
            internal extern static void PixelTransferf(Pencil.Gaming.Graphics.PixelTransferParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTransferi", ExactSpelling = true)]
            internal extern static void PixelTransferi(Pencil.Gaming.Graphics.PixelTransferParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTransformParameterfEXT", ExactSpelling = true)]
            internal extern static void PixelTransformParameterfEXT(Pencil.Gaming.Graphics.ExtPixelTransform target, Pencil.Gaming.Graphics.ExtPixelTransform pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTransformParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void PixelTransformParameterfvEXT(Pencil.Gaming.Graphics.ExtPixelTransform target, Pencil.Gaming.Graphics.ExtPixelTransform pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTransformParameteriEXT", ExactSpelling = true)]
            internal extern static void PixelTransformParameteriEXT(Pencil.Gaming.Graphics.ExtPixelTransform target, Pencil.Gaming.Graphics.ExtPixelTransform pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelTransformParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void PixelTransformParameterivEXT(Pencil.Gaming.Graphics.ExtPixelTransform target, Pencil.Gaming.Graphics.ExtPixelTransform pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPixelZoom", ExactSpelling = true)]
            internal extern static void PixelZoom(Single xfactor, Single yfactor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPNTrianglesfATI", ExactSpelling = true)]
            internal extern static void PNTrianglesfATI(Pencil.Gaming.Graphics.AtiPnTriangles pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPNTrianglesiATI", ExactSpelling = true)]
            internal extern static void PNTrianglesiATI(Pencil.Gaming.Graphics.AtiPnTriangles pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
            internal extern static void PointParameterf(Pencil.Gaming.Graphics.PointParameterName pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfARB", ExactSpelling = true)]
            internal extern static void PointParameterfARB(Pencil.Gaming.Graphics.ArbPointParameters pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfEXT", ExactSpelling = true)]
            internal extern static void PointParameterfEXT(Pencil.Gaming.Graphics.ExtPointParameters pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfSGIS", ExactSpelling = true)]
            internal extern static void PointParameterfSGIS(Pencil.Gaming.Graphics.SgisPointParameters pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
            internal extern static unsafe void PointParameterfv(Pencil.Gaming.Graphics.PointParameterName pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfvARB", ExactSpelling = true)]
            internal extern static unsafe void PointParameterfvARB(Pencil.Gaming.Graphics.ArbPointParameters pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void PointParameterfvEXT(Pencil.Gaming.Graphics.ExtPointParameters pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterfvSGIS", ExactSpelling = true)]
            internal extern static unsafe void PointParameterfvSGIS(Pencil.Gaming.Graphics.SgisPointParameters pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
            internal extern static void PointParameteri(Pencil.Gaming.Graphics.PointParameterName pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameteriNV", ExactSpelling = true)]
            internal extern static void PointParameteriNV(Pencil.Gaming.Graphics.NvPointSprite pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
            internal extern static unsafe void PointParameteriv(Pencil.Gaming.Graphics.PointParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void PointParameterivNV(Pencil.Gaming.Graphics.NvPointSprite pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal extern static void PointSize(Single size);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPollAsyncSGIX", ExactSpelling = true)]
            internal extern static unsafe Int32 PollAsyncSGIX([OutAttribute] UInt32* markerp);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPollInstrumentsSGIX", ExactSpelling = true)]
            internal extern static unsafe Int32 PollInstrumentsSGIX([OutAttribute] Int32* marker_p);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
            internal extern static void PolygonMode(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.PolygonMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal extern static void PolygonOffset(Single factor, Single units);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonOffsetEXT", ExactSpelling = true)]
            internal extern static void PolygonOffsetEXT(Single factor, Single bias);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPolygonStipple", ExactSpelling = true)]
            internal extern static unsafe void PolygonStipple(Byte* mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPopAttrib", ExactSpelling = true)]
            internal extern static void PopAttrib();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPopClientAttrib", ExactSpelling = true)]
            internal extern static void PopClientAttrib();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
            internal extern static void PopMatrix();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPopName", ExactSpelling = true)]
            internal extern static void PopName();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPresentFrameDualFillNV", ExactSpelling = true)]
            internal extern static void PresentFrameDualFillNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Pencil.Gaming.Graphics.NvPresentVideo type, Pencil.Gaming.Graphics.NvPresentVideo target0, UInt32 fill0, Pencil.Gaming.Graphics.NvPresentVideo target1, UInt32 fill1, Pencil.Gaming.Graphics.NvPresentVideo target2, UInt32 fill2, Pencil.Gaming.Graphics.NvPresentVideo target3, UInt32 fill3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPresentFrameKeyedNV", ExactSpelling = true)]
            internal extern static void PresentFrameKeyedNV(UInt32 video_slot, UInt64 minPresentTime, UInt32 beginPresentTimeId, UInt32 presentDurationId, Pencil.Gaming.Graphics.NvPresentVideo type, Pencil.Gaming.Graphics.NvPresentVideo target0, UInt32 fill0, UInt32 key0, Pencil.Gaming.Graphics.NvPresentVideo target1, UInt32 fill1, UInt32 key1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPrimitiveRestartIndex", ExactSpelling = true)]
            internal extern static void PrimitiveRestartIndex(UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPrimitiveRestartIndexNV", ExactSpelling = true)]
            internal extern static void PrimitiveRestartIndexNV(UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPrimitiveRestartNV", ExactSpelling = true)]
            internal extern static void PrimitiveRestartNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPrioritizeTextures", ExactSpelling = true)]
            internal extern static unsafe void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPrioritizeTexturesEXT", ExactSpelling = true)]
            internal extern static unsafe void PrioritizeTexturesEXT(Int32 n, UInt32* textures, Single* priorities);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramBinary", ExactSpelling = true)]
            internal extern static void ProgramBinary(UInt32 program, Pencil.Gaming.Graphics.BinaryFormat binaryFormat, IntPtr binary, Int32 length);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramBufferParametersfvNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramBufferParametersfvNV(Pencil.Gaming.Graphics.NvParameterBufferObject target, UInt32 buffer, UInt32 index, Int32 count, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramBufferParametersIivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramBufferParametersIivNV(Pencil.Gaming.Graphics.NvParameterBufferObject target, UInt32 buffer, UInt32 index, Int32 count, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramBufferParametersIuivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramBufferParametersIuivNV(Pencil.Gaming.Graphics.NvParameterBufferObject target, UInt32 buffer, UInt32 index, Int32 count, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameter4dARB", ExactSpelling = true)]
            internal extern static void ProgramEnvParameter4dARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameter4dvARB", ExactSpelling = true)]
            internal extern static unsafe void ProgramEnvParameter4dvARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameter4fARB", ExactSpelling = true)]
            internal extern static void ProgramEnvParameter4fARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameter4fvARB", ExactSpelling = true)]
            internal extern static unsafe void ProgramEnvParameter4fvARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameterI4iNV", ExactSpelling = true)]
            internal extern static void ProgramEnvParameterI4iNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameterI4ivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramEnvParameterI4ivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameterI4uiNV", ExactSpelling = true)]
            internal extern static void ProgramEnvParameterI4uiNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameterI4uivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramEnvParameterI4uivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParameters4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramEnvParameters4fvEXT(Pencil.Gaming.Graphics.ExtGpuProgramParameters target, UInt32 index, Int32 count, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParametersI4ivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramEnvParametersI4ivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, Int32 count, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramEnvParametersI4uivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramEnvParametersI4uivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, Int32 count, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameter4dARB", ExactSpelling = true)]
            internal extern static void ProgramLocalParameter4dARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameter4dvARB", ExactSpelling = true)]
            internal extern static unsafe void ProgramLocalParameter4dvARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameter4fARB", ExactSpelling = true)]
            internal extern static void ProgramLocalParameter4fARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameter4fvARB", ExactSpelling = true)]
            internal extern static unsafe void ProgramLocalParameter4fvARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameterI4iNV", ExactSpelling = true)]
            internal extern static void ProgramLocalParameterI4iNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameterI4ivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramLocalParameterI4ivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameterI4uiNV", ExactSpelling = true)]
            internal extern static void ProgramLocalParameterI4uiNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameterI4uivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramLocalParameterI4uivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParameters4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramLocalParameters4fvEXT(Pencil.Gaming.Graphics.ExtGpuProgramParameters target, UInt32 index, Int32 count, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParametersI4ivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramLocalParametersI4ivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, Int32 count, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramLocalParametersI4uivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramLocalParametersI4uivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target, UInt32 index, Int32 count, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramNamedParameter4dNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramNamedParameter4dNV(UInt32 id, Int32 len, Byte* name, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramNamedParameter4dvNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramNamedParameter4dvNV(UInt32 id, Int32 len, Byte* name, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramNamedParameter4fNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramNamedParameter4fNV(UInt32 id, Int32 len, Byte* name, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramNamedParameter4fvNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramNamedParameter4fvNV(UInt32 id, Int32 len, Byte* name, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameter4dNV", ExactSpelling = true)]
            internal extern static void ProgramParameter4dNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameter4dvNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramParameter4dvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameter4fNV", ExactSpelling = true)]
            internal extern static void ProgramParameter4fNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameter4fvNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramParameter4fvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameteri", ExactSpelling = true)]
            internal extern static void ProgramParameteri(UInt32 program, Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname, Int32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameteriARB", ExactSpelling = true)]
            internal extern static void ProgramParameteriARB(UInt32 program, Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname, Int32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameteriEXT", ExactSpelling = true)]
            internal extern static void ProgramParameteriEXT(UInt32 program, Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname, Int32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameters4dvNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramParameters4dvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Int32 count, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramParameters4fvNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramParameters4fvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 index, Int32 count, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramStringARB", ExactSpelling = true)]
            internal extern static void ProgramStringARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, Pencil.Gaming.Graphics.ArbVertexProgram format, Int32 len, IntPtr @string);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramSubroutineParametersuivNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramSubroutineParametersuivNV(Pencil.Gaming.Graphics.NvGpuProgram5 target, Int32 count, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1d", ExactSpelling = true)]
            internal extern static void ProgramUniform1d(UInt32 program, Int32 location, Double v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1dEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform1dEXT(UInt32 program, Int32 location, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1dv(UInt32 program, Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1dvEXT(UInt32 program, Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1f", ExactSpelling = true)]
            internal extern static void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1fEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform1fEXT(UInt32 program, Int32 location, Single v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1i", ExactSpelling = true)]
            internal extern static void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1i64NV", ExactSpelling = true)]
            internal extern static void ProgramUniform1i64NV(UInt32 program, Int32 location, Int64 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1i64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1iEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform1iEXT(UInt32 program, Int32 location, Int32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1iv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1ivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1ui", ExactSpelling = true)]
            internal extern static void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1ui64NV", ExactSpelling = true)]
            internal extern static void ProgramUniform1ui64NV(UInt32 program, Int32 location, UInt64 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1uiEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform1uiEXT(UInt32 program, Int32 location, UInt32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1uiv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform1uivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform1uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2d", ExactSpelling = true)]
            internal extern static void ProgramUniform2d(UInt32 program, Int32 location, Double v0, Double v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2dEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform2dEXT(UInt32 program, Int32 location, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2dv(UInt32 program, Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2dvEXT(UInt32 program, Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2f", ExactSpelling = true)]
            internal extern static void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2fEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform2fEXT(UInt32 program, Int32 location, Single v0, Single v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2i", ExactSpelling = true)]
            internal extern static void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2i64NV", ExactSpelling = true)]
            internal extern static void ProgramUniform2i64NV(UInt32 program, Int32 location, Int64 x, Int64 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2i64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2iEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform2iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2iv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2ivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2ui", ExactSpelling = true)]
            internal extern static void ProgramUniform2ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2ui64NV", ExactSpelling = true)]
            internal extern static void ProgramUniform2ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2uiEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform2uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2uiv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform2uivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform2uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3d", ExactSpelling = true)]
            internal extern static void ProgramUniform3d(UInt32 program, Int32 location, Double v0, Double v1, Double v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3dEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform3dEXT(UInt32 program, Int32 location, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3dv(UInt32 program, Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3dvEXT(UInt32 program, Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3f", ExactSpelling = true)]
            internal extern static void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3fEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform3fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3i", ExactSpelling = true)]
            internal extern static void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3i64NV", ExactSpelling = true)]
            internal extern static void ProgramUniform3i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3i64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3iEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform3iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3iv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3ivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3ui", ExactSpelling = true)]
            internal extern static void ProgramUniform3ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3ui64NV", ExactSpelling = true)]
            internal extern static void ProgramUniform3ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3uiEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform3uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3uiv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform3uivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform3uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4d", ExactSpelling = true)]
            internal extern static void ProgramUniform4d(UInt32 program, Int32 location, Double v0, Double v1, Double v2, Double v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4dEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform4dEXT(UInt32 program, Int32 location, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4dv(UInt32 program, Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4dvEXT(UInt32 program, Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4f", ExactSpelling = true)]
            internal extern static void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4fEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform4fEXT(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4fvEXT(UInt32 program, Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4i", ExactSpelling = true)]
            internal extern static void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4i64NV", ExactSpelling = true)]
            internal extern static void ProgramUniform4i64NV(UInt32 program, Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4i64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4i64vNV(UInt32 program, Int32 location, Int32 count, Int64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4iEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform4iEXT(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4iv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4ivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4ivEXT(UInt32 program, Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4ui", ExactSpelling = true)]
            internal extern static void ProgramUniform4ui(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4ui64NV", ExactSpelling = true)]
            internal extern static void ProgramUniform4ui64NV(UInt32 program, Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4ui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4uiEXT", ExactSpelling = true)]
            internal extern static void ProgramUniform4uiEXT(UInt32 program, Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4uiv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniform4uivEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniform4uivEXT(UInt32 program, Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x3dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x3dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x3fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x4dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x4dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x4fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix2x4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix2x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x2dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x2dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x2fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x2fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x4dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x4dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x4fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix3x4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix3x4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x2dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x2dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x2dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x2dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x2fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x2fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x2fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x3dv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x3dv(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x3dvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x3dvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x3fv", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformMatrix4x3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformMatrix4x3fvEXT(UInt32 program, Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformui64NV", ExactSpelling = true)]
            internal extern static void ProgramUniformui64NV(UInt32 program, Int32 location, UInt64 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramUniformui64vNV", ExactSpelling = true)]
            internal extern static unsafe void ProgramUniformui64vNV(UInt32 program, Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProgramVertexLimitNV", ExactSpelling = true)]
            internal extern static void ProgramVertexLimitNV(Pencil.Gaming.Graphics.NvGeometryProgram4 target, Int32 limit);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProvokingVertex", ExactSpelling = true)]
            internal extern static void ProvokingVertex(Pencil.Gaming.Graphics.ProvokingVertexMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glProvokingVertexEXT", ExactSpelling = true)]
            internal extern static void ProvokingVertexEXT(Pencil.Gaming.Graphics.ExtProvokingVertex mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushAttrib", ExactSpelling = true)]
            internal extern static void PushAttrib(Pencil.Gaming.Graphics.AttribMask mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushClientAttrib", ExactSpelling = true)]
            internal extern static void PushClientAttrib(Pencil.Gaming.Graphics.ClientAttribMask mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushClientAttribDefaultEXT", ExactSpelling = true)]
            internal extern static void PushClientAttribDefaultEXT(Pencil.Gaming.Graphics.ClientAttribMask mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
            internal extern static void PushMatrix();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glPushName", ExactSpelling = true)]
            internal extern static void PushName(UInt32 name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glQueryCounter", ExactSpelling = true)]
            internal extern static void QueryCounter(UInt32 id, Pencil.Gaming.Graphics.QueryCounterTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2d", ExactSpelling = true)]
            internal extern static void RasterPos2d(Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2f", ExactSpelling = true)]
            internal extern static void RasterPos2f(Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2i", ExactSpelling = true)]
            internal extern static void RasterPos2i(Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2s", ExactSpelling = true)]
            internal extern static void RasterPos2s(Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos2sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3d", ExactSpelling = true)]
            internal extern static void RasterPos3d(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3f", ExactSpelling = true)]
            internal extern static void RasterPos3f(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3i", ExactSpelling = true)]
            internal extern static void RasterPos3i(Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3s", ExactSpelling = true)]
            internal extern static void RasterPos3s(Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4d", ExactSpelling = true)]
            internal extern static void RasterPos4d(Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4f", ExactSpelling = true)]
            internal extern static void RasterPos4f(Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4i", ExactSpelling = true)]
            internal extern static void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4s", ExactSpelling = true)]
            internal extern static void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
            internal extern static unsafe void RasterPos4sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
            internal extern static void ReadBuffer(Pencil.Gaming.Graphics.ReadBufferMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadInstrumentsSGIX", ExactSpelling = true)]
            internal extern static void ReadInstrumentsSGIX(Int32 marker);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadnPixelsARB", ExactSpelling = true)]
            internal extern static void ReadnPixelsARB(Int32 x, Int32 y, Int32 width, Int32 height, Pencil.Gaming.Graphics.ArbRobustness format, Pencil.Gaming.Graphics.ArbRobustness type, Int32 bufSize, [OutAttribute] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal extern static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, [OutAttribute] IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRectd", ExactSpelling = true)]
            internal extern static void Rectd(Double x1, Double y1, Double x2, Double y2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRectdv", ExactSpelling = true)]
            internal extern static unsafe void Rectdv(Double* v1, Double* v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRectf", ExactSpelling = true)]
            internal extern static void Rectf(Single x1, Single y1, Single x2, Single y2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRectfv", ExactSpelling = true)]
            internal extern static unsafe void Rectfv(Single* v1, Single* v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRecti", ExactSpelling = true)]
            internal extern static void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRectiv", ExactSpelling = true)]
            internal extern static unsafe void Rectiv(Int32* v1, Int32* v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRects", ExactSpelling = true)]
            internal extern static void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRectsv", ExactSpelling = true)]
            internal extern static unsafe void Rectsv(Int16* v1, Int16* v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReferencePlaneSGIX", ExactSpelling = true)]
            internal extern static unsafe void ReferencePlaneSGIX(Double* equation);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReleaseShaderCompiler", ExactSpelling = true)]
            internal extern static void ReleaseShaderCompiler();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
            internal extern static void RenderbufferStorage(Pencil.Gaming.Graphics.RenderbufferTarget target, Pencil.Gaming.Graphics.RenderbufferStorage internalformat, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageEXT", ExactSpelling = true)]
            internal extern static void RenderbufferStorageEXT(Pencil.Gaming.Graphics.RenderbufferTarget target, Pencil.Gaming.Graphics.RenderbufferStorage internalformat, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisample", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisample(Pencil.Gaming.Graphics.RenderbufferTarget target, Int32 samples, Pencil.Gaming.Graphics.RenderbufferStorage internalformat, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleCoverageNV", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleCoverageNV(Pencil.Gaming.Graphics.RenderbufferTarget target, Int32 coverageSamples, Int32 colorSamples, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderbufferStorageMultisampleEXT", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisampleEXT(Pencil.Gaming.Graphics.ExtFramebufferMultisample target, Int32 samples, Pencil.Gaming.Graphics.ExtFramebufferMultisample internalformat, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRenderMode", ExactSpelling = true)]
            internal extern static Int32 RenderMode(Pencil.Gaming.Graphics.RenderingMode mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodePointerSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodePointerSUN(Pencil.Gaming.Graphics.SunTriangleList type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeubSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeubSUN(Byte code);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeubvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeubvSUN(Byte* code);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc, Single* c, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* c, Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc, Byte* c, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc, Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiSUN(UInt32 code);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* c, Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc, Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc, Single* tc, Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc, Single s, Single t, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc, Single* tc, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiVertex3fSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeuiVertex3fSUN(UInt32 rc, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuiVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuiVertex3fvSUN(UInt32* rc, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeuivSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeuivSUN(UInt32* code);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeusSUN", ExactSpelling = true)]
            internal extern static void ReplacementCodeusSUN(UInt16 code);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glReplacementCodeusvSUN", ExactSpelling = true)]
            internal extern static unsafe void ReplacementCodeusvSUN(UInt16* code);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRequestResidentProgramsNV", ExactSpelling = true)]
            internal extern static unsafe void RequestResidentProgramsNV(Int32 n, UInt32* programs);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResetHistogram", ExactSpelling = true)]
            internal extern static void ResetHistogram(Pencil.Gaming.Graphics.HistogramTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResetHistogramEXT", ExactSpelling = true)]
            internal extern static void ResetHistogramEXT(Pencil.Gaming.Graphics.ExtHistogram target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResetMinmax", ExactSpelling = true)]
            internal extern static void ResetMinmax(Pencil.Gaming.Graphics.MinmaxTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResetMinmaxEXT", ExactSpelling = true)]
            internal extern static void ResetMinmaxEXT(Pencil.Gaming.Graphics.ExtHistogram target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResizeBuffersMESA", CharSet = CharSet.Auto)]
            internal extern static void ResizeBuffersMESA();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResumeTransformFeedback", ExactSpelling = true)]
            internal extern static void ResumeTransformFeedback();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glResumeTransformFeedbackNV", ExactSpelling = true)]
            internal extern static void ResumeTransformFeedbackNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRotated", ExactSpelling = true)]
            internal extern static void Rotated(Double angle, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glRotatef", ExactSpelling = true)]
            internal extern static void Rotatef(Single angle, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal extern static void SampleCoverage(Single value, bool invert);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleCoverageARB", ExactSpelling = true)]
            internal extern static void SampleCoverageARB(Single value, bool invert);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleMapATI", ExactSpelling = true)]
            internal extern static void SampleMapATI(UInt32 dst, UInt32 interp, Pencil.Gaming.Graphics.AtiFragmentShader swizzle);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleMaskEXT", ExactSpelling = true)]
            internal extern static void SampleMaskEXT(Single value, bool invert);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleMaski", ExactSpelling = true)]
            internal extern static void SampleMaski(UInt32 index, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleMaskIndexedNV", ExactSpelling = true)]
            internal extern static void SampleMaskIndexedNV(UInt32 index, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSampleMaskSGIS", ExactSpelling = true)]
            internal extern static void SampleMaskSGIS(Single value, bool invert);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplePatternEXT", ExactSpelling = true)]
            internal extern static void SamplePatternEXT(Pencil.Gaming.Graphics.ExtMultisample pattern);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplePatternSGIS", ExactSpelling = true)]
            internal extern static void SamplePatternSGIS(Pencil.Gaming.Graphics.SgisMultisample pattern);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameterf", ExactSpelling = true)]
            internal extern static void SamplerParameterf(UInt32 sampler, Pencil.Gaming.Graphics.SamplerParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameterfv", ExactSpelling = true)]
            internal extern static unsafe void SamplerParameterfv(UInt32 sampler, Pencil.Gaming.Graphics.SamplerParameter pname, Single* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameteri", ExactSpelling = true)]
            internal extern static void SamplerParameteri(UInt32 sampler, Pencil.Gaming.Graphics.SamplerParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameterIiv", ExactSpelling = true)]
            internal extern static unsafe void SamplerParameterIiv(UInt32 sampler, Pencil.Gaming.Graphics.ArbSamplerObjects pname, Int32* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameterIuiv", ExactSpelling = true)]
            internal extern static unsafe void SamplerParameterIuiv(UInt32 sampler, Pencil.Gaming.Graphics.ArbSamplerObjects pname, UInt32* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSamplerParameteriv", ExactSpelling = true)]
            internal extern static unsafe void SamplerParameteriv(UInt32 sampler, Pencil.Gaming.Graphics.SamplerParameter pname, Int32* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScaled", ExactSpelling = true)]
            internal extern static void Scaled(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScalef", ExactSpelling = true)]
            internal extern static void Scalef(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal extern static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissorArrayv", ExactSpelling = true)]
            internal extern static unsafe void ScissorArrayv(UInt32 first, Int32 count, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissorIndexed", ExactSpelling = true)]
            internal extern static void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glScissorIndexedv", ExactSpelling = true)]
            internal extern static unsafe void ScissorIndexedv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3b", ExactSpelling = true)]
            internal extern static void SecondaryColor3b(SByte red, SByte green, SByte blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3bEXT", ExactSpelling = true)]
            internal extern static void SecondaryColor3bEXT(SByte red, SByte green, SByte blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3bv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3bv(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3bvEXT", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3bvEXT(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3d", ExactSpelling = true)]
            internal extern static void SecondaryColor3d(Double red, Double green, Double blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3dEXT", ExactSpelling = true)]
            internal extern static void SecondaryColor3dEXT(Double red, Double green, Double blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3dv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3dvEXT", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3dvEXT(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3f", ExactSpelling = true)]
            internal extern static void SecondaryColor3f(Single red, Single green, Single blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3fEXT", ExactSpelling = true)]
            internal extern static void SecondaryColor3fEXT(Single red, Single green, Single blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3fv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3fvEXT(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3i", ExactSpelling = true)]
            internal extern static void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3iEXT", ExactSpelling = true)]
            internal extern static void SecondaryColor3iEXT(Int32 red, Int32 green, Int32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3iv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3ivEXT", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3ivEXT(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3s", ExactSpelling = true)]
            internal extern static void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3sEXT", ExactSpelling = true)]
            internal extern static void SecondaryColor3sEXT(Int16 red, Int16 green, Int16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3sv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3svEXT", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3svEXT(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3ub", ExactSpelling = true)]
            internal extern static void SecondaryColor3ub(Byte red, Byte green, Byte blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3ubEXT", ExactSpelling = true)]
            internal extern static void SecondaryColor3ubEXT(Byte red, Byte green, Byte blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3ubv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3ubv(Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3ubvEXT", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3ubvEXT(Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3ui", ExactSpelling = true)]
            internal extern static void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3uiEXT", ExactSpelling = true)]
            internal extern static void SecondaryColor3uiEXT(UInt32 red, UInt32 green, UInt32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3uiv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3uiv(UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3uivEXT", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3uivEXT(UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3us", ExactSpelling = true)]
            internal extern static void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3usEXT", ExactSpelling = true)]
            internal extern static void SecondaryColor3usEXT(UInt16 red, UInt16 green, UInt16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3usv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3usv(UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColor3usvEXT", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColor3usvEXT(UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColorFormatNV", ExactSpelling = true)]
            internal extern static void SecondaryColorFormatNV(Int32 size, Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColorP3ui", ExactSpelling = true)]
            internal extern static void SecondaryColorP3ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 color);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColorP3uiv", ExactSpelling = true)]
            internal extern static unsafe void SecondaryColorP3uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* color);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColorPointer", ExactSpelling = true)]
            internal extern static void SecondaryColorPointer(Int32 size, Pencil.Gaming.Graphics.ColorPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColorPointerEXT", ExactSpelling = true)]
            internal extern static void SecondaryColorPointerEXT(Int32 size, Pencil.Gaming.Graphics.ColorPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSecondaryColorPointerListIBM", ExactSpelling = true)]
            internal extern static void SecondaryColorPointerListIBM(Int32 size, Pencil.Gaming.Graphics.IbmVertexArrayLists type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSelectBuffer", ExactSpelling = true)]
            internal extern static unsafe void SelectBuffer(Int32 size, [OutAttribute] UInt32* buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSelectPerfMonitorCountersAMD", ExactSpelling = true)]
            internal extern static unsafe void SelectPerfMonitorCountersAMD(UInt32 monitor, bool enable, UInt32 group, Int32 numCounters, [OutAttribute] UInt32* counterList);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSeparableFilter2D", ExactSpelling = true)]
            internal extern static void SeparableFilter2D(Pencil.Gaming.Graphics.SeparableTarget target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr row, IntPtr column);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSeparableFilter2DEXT", ExactSpelling = true)]
            internal extern static void SeparableFilter2DEXT(Pencil.Gaming.Graphics.ExtConvolution target, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr row, IntPtr column);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSetFenceAPPLE", ExactSpelling = true)]
            internal extern static void SetFenceAPPLE(UInt32 fence);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSetFenceNV", ExactSpelling = true)]
            internal extern static void SetFenceNV(UInt32 fence, Pencil.Gaming.Graphics.NvFence condition);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSetFragmentShaderConstantATI", ExactSpelling = true)]
            internal extern static unsafe void SetFragmentShaderConstantATI(UInt32 dst, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSetInvariantEXT", ExactSpelling = true)]
            internal extern static void SetInvariantEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader type, IntPtr addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSetLocalConstantEXT", ExactSpelling = true)]
            internal extern static void SetLocalConstantEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader type, IntPtr addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSetMultisamplefvAMD", ExactSpelling = true)]
            internal extern static unsafe void SetMultisamplefvAMD(Pencil.Gaming.Graphics.AmdSamplePositions pname, UInt32 index, Single* val);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
            internal extern static void ShadeModel(Pencil.Gaming.Graphics.ShadingModel mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
            internal extern static unsafe void ShaderBinary(Int32 count, UInt32* shaders, Pencil.Gaming.Graphics.BinaryFormat binaryformat, IntPtr binary, Int32 length);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderOp1EXT", ExactSpelling = true)]
            internal extern static void ShaderOp1EXT(Pencil.Gaming.Graphics.ExtVertexShader op, UInt32 res, UInt32 arg1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderOp2EXT", ExactSpelling = true)]
            internal extern static void ShaderOp2EXT(Pencil.Gaming.Graphics.ExtVertexShader op, UInt32 res, UInt32 arg1, UInt32 arg2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderOp3EXT", ExactSpelling = true)]
            internal extern static void ShaderOp3EXT(Pencil.Gaming.Graphics.ExtVertexShader op, UInt32 res, UInt32 arg1, UInt32 arg2, UInt32 arg3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
            internal extern static unsafe void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glShaderSourceARB", ExactSpelling = true)]
            internal extern static unsafe void ShaderSourceARB(UInt32 shaderObj, Int32 count, String[] @string, Int32* length);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSharpenTexFuncSGIS", ExactSpelling = true)]
            internal extern static unsafe void SharpenTexFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target, Int32 n, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSpriteParameterfSGIX", ExactSpelling = true)]
            internal extern static void SpriteParameterfSGIX(Pencil.Gaming.Graphics.SgixSprite pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSpriteParameterfvSGIX", ExactSpelling = true)]
            internal extern static unsafe void SpriteParameterfvSGIX(Pencil.Gaming.Graphics.SgixSprite pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSpriteParameteriSGIX", ExactSpelling = true)]
            internal extern static void SpriteParameteriSGIX(Pencil.Gaming.Graphics.SgixSprite pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSpriteParameterivSGIX", ExactSpelling = true)]
            internal extern static unsafe void SpriteParameterivSGIX(Pencil.Gaming.Graphics.SgixSprite pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStartInstrumentsSGIX", ExactSpelling = true)]
            internal extern static void StartInstrumentsSGIX();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilClearTagEXT", ExactSpelling = true)]
            internal extern static void StencilClearTagEXT(Int32 stencilTagBits, UInt32 stencilClearTag);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal extern static void StencilFunc(Pencil.Gaming.Graphics.StencilFunction func, Int32 @ref, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal extern static void StencilFuncSeparate(Pencil.Gaming.Graphics.Version20 face, Pencil.Gaming.Graphics.StencilFunction func, Int32 @ref, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilFuncSeparateATI", ExactSpelling = true)]
            internal extern static void StencilFuncSeparateATI(Pencil.Gaming.Graphics.StencilFunction frontfunc, Pencil.Gaming.Graphics.StencilFunction backfunc, Int32 @ref, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal extern static void StencilMask(UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
            internal extern static void StencilMaskSeparate(Pencil.Gaming.Graphics.StencilFace face, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal extern static void StencilOp(Pencil.Gaming.Graphics.StencilOp fail, Pencil.Gaming.Graphics.StencilOp zfail, Pencil.Gaming.Graphics.StencilOp zpass);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal extern static void StencilOpSeparate(Pencil.Gaming.Graphics.StencilFace face, Pencil.Gaming.Graphics.StencilOp sfail, Pencil.Gaming.Graphics.StencilOp dpfail, Pencil.Gaming.Graphics.StencilOp dppass);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStencilOpSeparateATI", ExactSpelling = true)]
            internal extern static void StencilOpSeparateATI(Pencil.Gaming.Graphics.AtiSeparateStencil face, Pencil.Gaming.Graphics.StencilOp sfail, Pencil.Gaming.Graphics.StencilOp dpfail, Pencil.Gaming.Graphics.StencilOp dppass);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStopInstrumentsSGIX", ExactSpelling = true)]
            internal extern static void StopInstrumentsSGIX(Int32 marker);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glStringMarkerGREMEDY", ExactSpelling = true)]
            internal extern static void StringMarkerGREMEDY(Int32 len, IntPtr @string);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glSwizzleEXT", ExactSpelling = true)]
            internal extern static void SwizzleEXT(UInt32 res, UInt32 @in, Pencil.Gaming.Graphics.ExtVertexShader outX, Pencil.Gaming.Graphics.ExtVertexShader outY, Pencil.Gaming.Graphics.ExtVertexShader outZ, Pencil.Gaming.Graphics.ExtVertexShader outW);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTagSampleBufferSGIX", ExactSpelling = true)]
            internal extern static void TagSampleBufferSGIX();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3bEXT", ExactSpelling = true)]
            internal extern static void Tangent3bEXT(SByte tx, SByte ty, SByte tz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3bvEXT", ExactSpelling = true)]
            internal extern static unsafe void Tangent3bvEXT(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3dEXT", ExactSpelling = true)]
            internal extern static void Tangent3dEXT(Double tx, Double ty, Double tz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3dvEXT", ExactSpelling = true)]
            internal extern static unsafe void Tangent3dvEXT(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3fEXT", ExactSpelling = true)]
            internal extern static void Tangent3fEXT(Single tx, Single ty, Single tz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3fvEXT", ExactSpelling = true)]
            internal extern static unsafe void Tangent3fvEXT(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3iEXT", ExactSpelling = true)]
            internal extern static void Tangent3iEXT(Int32 tx, Int32 ty, Int32 tz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3ivEXT", ExactSpelling = true)]
            internal extern static unsafe void Tangent3ivEXT(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3sEXT", ExactSpelling = true)]
            internal extern static void Tangent3sEXT(Int16 tx, Int16 ty, Int16 tz);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangent3svEXT", ExactSpelling = true)]
            internal extern static unsafe void Tangent3svEXT(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTangentPointerEXT", ExactSpelling = true)]
            internal extern static void TangentPointerEXT(Pencil.Gaming.Graphics.NormalPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTbufferMask3DFX", ExactSpelling = true)]
            internal extern static void TbufferMask3DFX(UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTessellationFactorAMD", ExactSpelling = true)]
            internal extern static void TessellationFactorAMD(Single factor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTessellationModeAMD", ExactSpelling = true)]
            internal extern static void TessellationModeAMD(Pencil.Gaming.Graphics.AmdVertexShaderTesselator mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTestFenceAPPLE", ExactSpelling = true)]
            internal extern static bool TestFenceAPPLE(UInt32 fence);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTestFenceNV", ExactSpelling = true)]
            internal extern static bool TestFenceNV(UInt32 fence);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTestObjectAPPLE", ExactSpelling = true)]
            internal extern static bool TestObjectAPPLE(Pencil.Gaming.Graphics.AppleFence @object, UInt32 name);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexBuffer", ExactSpelling = true)]
            internal extern static void TexBuffer(Pencil.Gaming.Graphics.TextureBufferTarget target, Pencil.Gaming.Graphics.SizedInternalFormat internalformat, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexBufferARB", ExactSpelling = true)]
            internal extern static void TexBufferARB(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.ArbTextureBufferObject internalformat, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexBufferEXT", ExactSpelling = true)]
            internal extern static void TexBufferEXT(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.ExtTextureBufferObject internalformat, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexBumpParameterfvATI", ExactSpelling = true)]
            internal extern static unsafe void TexBumpParameterfvATI(Pencil.Gaming.Graphics.AtiEnvmapBumpmap pname, Single* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexBumpParameterivATI", ExactSpelling = true)]
            internal extern static unsafe void TexBumpParameterivATI(Pencil.Gaming.Graphics.AtiEnvmapBumpmap pname, Int32* param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1d", ExactSpelling = true)]
            internal extern static void TexCoord1d(Double s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1f", ExactSpelling = true)]
            internal extern static void TexCoord1f(Single s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1i", ExactSpelling = true)]
            internal extern static void TexCoord1i(Int32 s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1s", ExactSpelling = true)]
            internal extern static void TexCoord1s(Int16 s);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord1sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2d", ExactSpelling = true)]
            internal extern static void TexCoord2d(Double s, Double t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2f", ExactSpelling = true)]
            internal extern static void TexCoord2f(Single s, Single t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fColor3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void TexCoord2fColor3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fColor3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2fColor3fVertex3fvSUN(Single* tc, Single* c, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void TexCoord2fColor4fNormal3fVertex3fSUN(Single s, Single t, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2fColor4fNormal3fVertex3fvSUN(Single* tc, Single* c, Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fColor4ubVertex3fSUN", ExactSpelling = true)]
            internal extern static void TexCoord2fColor4ubVertex3fSUN(Single s, Single t, Byte r, Byte g, Byte b, Byte a, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2fColor4ubVertex3fvSUN(Single* tc, Byte* c, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fNormal3fVertex3fSUN", ExactSpelling = true)]
            internal extern static void TexCoord2fNormal3fVertex3fSUN(Single s, Single t, Single nx, Single ny, Single nz, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2fNormal3fVertex3fvSUN(Single* tc, Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fVertex3fSUN", ExactSpelling = true)]
            internal extern static void TexCoord2fVertex3fSUN(Single s, Single t, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2fVertex3fvSUN", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2fVertex3fvSUN(Single* tc, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2i", ExactSpelling = true)]
            internal extern static void TexCoord2i(Int32 s, Int32 t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2s", ExactSpelling = true)]
            internal extern static void TexCoord2s(Int16 s, Int16 t);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord2sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3d", ExactSpelling = true)]
            internal extern static void TexCoord3d(Double s, Double t, Double r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3f", ExactSpelling = true)]
            internal extern static void TexCoord3f(Single s, Single t, Single r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3i", ExactSpelling = true)]
            internal extern static void TexCoord3i(Int32 s, Int32 t, Int32 r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3s", ExactSpelling = true)]
            internal extern static void TexCoord3s(Int16 s, Int16 t, Int16 r);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4d", ExactSpelling = true)]
            internal extern static void TexCoord4d(Double s, Double t, Double r, Double q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4f", ExactSpelling = true)]
            internal extern static void TexCoord4f(Single s, Single t, Single r, Single q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN", ExactSpelling = true)]
            internal extern static void TexCoord4fColor4fNormal3fVertex4fSUN(Single s, Single t, Single p, Single q, Single r, Single g, Single b, Single a, Single nx, Single ny, Single nz, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4fColor4fNormal3fVertex4fvSUN(Single* tc, Single* c, Single* n, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4fVertex4fSUN", ExactSpelling = true)]
            internal extern static void TexCoord4fVertex4fSUN(Single s, Single t, Single p, Single q, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4fVertex4fvSUN", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4fVertex4fvSUN(Single* tc, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4i", ExactSpelling = true)]
            internal extern static void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4s", ExactSpelling = true)]
            internal extern static void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
            internal extern static unsafe void TexCoord4sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordFormatNV", ExactSpelling = true)]
            internal extern static void TexCoordFormatNV(Int32 size, Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP1ui", ExactSpelling = true)]
            internal extern static void TexCoordP1ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP1uiv", ExactSpelling = true)]
            internal extern static unsafe void TexCoordP1uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP2ui", ExactSpelling = true)]
            internal extern static void TexCoordP2ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP2uiv", ExactSpelling = true)]
            internal extern static unsafe void TexCoordP2uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP3ui", ExactSpelling = true)]
            internal extern static void TexCoordP3ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP3uiv", ExactSpelling = true)]
            internal extern static unsafe void TexCoordP3uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP4ui", ExactSpelling = true)]
            internal extern static void TexCoordP4ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordP4uiv", ExactSpelling = true)]
            internal extern static unsafe void TexCoordP4uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
            internal extern static void TexCoordPointer(Int32 size, Pencil.Gaming.Graphics.TexCoordPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordPointerEXT", ExactSpelling = true)]
            internal extern static void TexCoordPointerEXT(Int32 size, Pencil.Gaming.Graphics.TexCoordPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordPointerListIBM", ExactSpelling = true)]
            internal extern static void TexCoordPointerListIBM(Int32 size, Pencil.Gaming.Graphics.TexCoordPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexCoordPointervINTEL", ExactSpelling = true)]
            internal extern static void TexCoordPointervINTEL(Int32 size, Pencil.Gaming.Graphics.VertexPointerType type, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
            internal extern static void TexEnvf(Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
            internal extern static unsafe void TexEnvfv(Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnvi", ExactSpelling = true)]
            internal extern static void TexEnvi(Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexEnviv", ExactSpelling = true)]
            internal extern static unsafe void TexEnviv(Pencil.Gaming.Graphics.TextureEnvTarget target, Pencil.Gaming.Graphics.TextureEnvParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexFilterFuncSGIS", ExactSpelling = true)]
            internal extern static unsafe void TexFilterFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.SgisTextureFilter4 filter, Int32 n, Single* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGend", ExactSpelling = true)]
            internal extern static void TexGend(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Double param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGendv", ExactSpelling = true)]
            internal extern static unsafe void TexGendv(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGenf", ExactSpelling = true)]
            internal extern static void TexGenf(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGenfv", ExactSpelling = true)]
            internal extern static unsafe void TexGenfv(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGeni", ExactSpelling = true)]
            internal extern static void TexGeni(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexGeniv", ExactSpelling = true)]
            internal extern static unsafe void TexGeniv(Pencil.Gaming.Graphics.TextureCoordName coord, Pencil.Gaming.Graphics.TextureGenParameter pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
            internal extern static void TexImage1D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal extern static void TexImage2D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage2DMultisample", ExactSpelling = true)]
            internal extern static void TexImage2DMultisample(Pencil.Gaming.Graphics.TextureTargetMultisample target, Int32 samples, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, bool fixedsamplelocations);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage2DMultisampleCoverageNV", ExactSpelling = true)]
            internal extern static void TexImage2DMultisampleCoverageNV(Pencil.Gaming.Graphics.NvTextureMultisample target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
            internal extern static void TexImage3D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage3DEXT", ExactSpelling = true)]
            internal extern static void TexImage3DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage3DMultisample", ExactSpelling = true)]
            internal extern static void TexImage3DMultisample(Pencil.Gaming.Graphics.TextureTargetMultisample target, Int32 samples, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, bool fixedsamplelocations);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage3DMultisampleCoverageNV", ExactSpelling = true)]
            internal extern static void TexImage3DMultisampleCoverageNV(Pencil.Gaming.Graphics.NvTextureMultisample target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexImage4DSGIS", ExactSpelling = true)]
            internal extern static void TexImage4DSGIS(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 depth, Int32 size4d, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal extern static void TexParameterf(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterfv(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal extern static void TexParameteri(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterIiv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterIiv(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterIivEXT", ExactSpelling = true)]
            internal extern static unsafe void TexParameterIivEXT(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterIuiv", ExactSpelling = true)]
            internal extern static unsafe void TexParameterIuiv(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameterIuivEXT", ExactSpelling = true)]
            internal extern static unsafe void TexParameterIuivEXT(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal extern static unsafe void TexParameteriv(Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexRenderbufferNV", ExactSpelling = true)]
            internal extern static void TexRenderbufferNV(Pencil.Gaming.Graphics.TextureTarget target, UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
            internal extern static void TexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage1DEXT", ExactSpelling = true)]
            internal extern static void TexSubImage1DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal extern static void TexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage2DEXT", ExactSpelling = true)]
            internal extern static void TexSubImage2DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
            internal extern static void TexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage3DEXT", ExactSpelling = true)]
            internal extern static void TexSubImage3DEXT(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTexSubImage4DSGIS", ExactSpelling = true)]
            internal extern static void TexSubImage4DSGIS(Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 woffset, Int32 width, Int32 height, Int32 depth, Int32 size4d, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureBarrierNV", ExactSpelling = true)]
            internal extern static void TextureBarrierNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureBufferEXT", ExactSpelling = true)]
            internal extern static void TextureBufferEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureColorMaskSGIS", ExactSpelling = true)]
            internal extern static void TextureColorMaskSGIS(bool red, bool green, bool blue, bool alpha);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureImage1DEXT", ExactSpelling = true)]
            internal extern static void TextureImage1DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureImage2DEXT", ExactSpelling = true)]
            internal extern static void TextureImage2DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureImage2DMultisampleCoverageNV", ExactSpelling = true)]
            internal extern static void TextureImage2DMultisampleCoverageNV(UInt32 texture, Pencil.Gaming.Graphics.NvTextureMultisample target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureImage2DMultisampleNV", ExactSpelling = true)]
            internal extern static void TextureImage2DMultisampleNV(UInt32 texture, Pencil.Gaming.Graphics.NvTextureMultisample target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, bool fixedSampleLocations);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureImage3DEXT", ExactSpelling = true)]
            internal extern static void TextureImage3DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureImage3DMultisampleCoverageNV", ExactSpelling = true)]
            internal extern static void TextureImage3DMultisampleCoverageNV(UInt32 texture, Pencil.Gaming.Graphics.NvTextureMultisample target, Int32 coverageSamples, Int32 colorSamples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureImage3DMultisampleNV", ExactSpelling = true)]
            internal extern static void TextureImage3DMultisampleNV(UInt32 texture, Pencil.Gaming.Graphics.NvTextureMultisample target, Int32 samples, Int32 internalFormat, Int32 width, Int32 height, Int32 depth, bool fixedSampleLocations);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureLightEXT", ExactSpelling = true)]
            internal extern static void TextureLightEXT(Pencil.Gaming.Graphics.ExtLightTexture pname);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureMaterialEXT", ExactSpelling = true)]
            internal extern static void TextureMaterialEXT(Pencil.Gaming.Graphics.MaterialFace face, Pencil.Gaming.Graphics.MaterialParameter mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureNormalEXT", ExactSpelling = true)]
            internal extern static void TextureNormalEXT(Pencil.Gaming.Graphics.ExtTexturePerturbNormal mode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureParameterfEXT", ExactSpelling = true)]
            internal extern static void TextureParameterfEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureParameterfvEXT", ExactSpelling = true)]
            internal extern static unsafe void TextureParameterfvEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureParameteriEXT", ExactSpelling = true)]
            internal extern static void TextureParameteriEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureParameterIivEXT", ExactSpelling = true)]
            internal extern static unsafe void TextureParameterIivEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureParameterIuivEXT", ExactSpelling = true)]
            internal extern static unsafe void TextureParameterIuivEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureParameterivEXT", ExactSpelling = true)]
            internal extern static unsafe void TextureParameterivEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Pencil.Gaming.Graphics.TextureParameterName pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureRangeAPPLE", ExactSpelling = true)]
            internal extern static void TextureRangeAPPLE(Pencil.Gaming.Graphics.AppleTextureRange target, Int32 length, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureRenderbufferEXT", ExactSpelling = true)]
            internal extern static void TextureRenderbufferEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, UInt32 renderbuffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureSubImage1DEXT", ExactSpelling = true)]
            internal extern static void TextureSubImage1DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureSubImage2DEXT", ExactSpelling = true)]
            internal extern static void TextureSubImage2DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTextureSubImage3DEXT", ExactSpelling = true)]
            internal extern static void TextureSubImage3DEXT(UInt32 texture, Pencil.Gaming.Graphics.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Pencil.Gaming.Graphics.PixelFormat format, Pencil.Gaming.Graphics.PixelType type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTrackMatrixNV", ExactSpelling = true)]
            internal extern static void TrackMatrixNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target, UInt32 address, Pencil.Gaming.Graphics.NvVertexProgram matrix, Pencil.Gaming.Graphics.NvVertexProgram transform);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTransformFeedbackAttribsNV", ExactSpelling = true)]
            internal extern static unsafe void TransformFeedbackAttribsNV(UInt32 count, Int32* attribs, Pencil.Gaming.Graphics.NvTransformFeedback bufferMode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTransformFeedbackStreamAttribsNV", ExactSpelling = true)]
            internal extern static unsafe void TransformFeedbackStreamAttribsNV(Int32 count, Int32* attribs, Int32 nbuffers, Int32* bufstreams, Pencil.Gaming.Graphics.NvTransformFeedback bufferMode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTransformFeedbackVaryings", ExactSpelling = true)]
            internal extern static void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, Pencil.Gaming.Graphics.TransformFeedbackMode bufferMode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTransformFeedbackVaryingsEXT", ExactSpelling = true)]
            internal extern static void TransformFeedbackVaryingsEXT(UInt32 program, Int32 count, String[] varyings, Pencil.Gaming.Graphics.ExtTransformFeedback bufferMode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTransformFeedbackVaryingsNV", ExactSpelling = true)]
            internal extern static unsafe void TransformFeedbackVaryingsNV(UInt32 program, Int32 count, Int32* locations, Pencil.Gaming.Graphics.NvTransformFeedback bufferMode);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTranslated", ExactSpelling = true)]
            internal extern static void Translated(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
            internal extern static void Translatef(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1d", ExactSpelling = true)]
            internal extern static void Uniform1d(Int32 location, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1dv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1dv(Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
            internal extern static void Uniform1f(Int32 location, Single v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1fARB", ExactSpelling = true)]
            internal extern static void Uniform1fARB(Int32 location, Single v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1fv(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1fvARB", ExactSpelling = true)]
            internal extern static unsafe void Uniform1fvARB(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
            internal extern static void Uniform1i(Int32 location, Int32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1i64NV", ExactSpelling = true)]
            internal extern static void Uniform1i64NV(Int32 location, Int64 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1i64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniform1i64vNV(Int32 location, Int32 count, Int64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1iARB", ExactSpelling = true)]
            internal extern static void Uniform1iARB(Int32 location, Int32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1iv(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1ivARB", ExactSpelling = true)]
            internal extern static unsafe void Uniform1ivARB(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1ui", ExactSpelling = true)]
            internal extern static void Uniform1ui(Int32 location, UInt32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1ui64NV", ExactSpelling = true)]
            internal extern static void Uniform1ui64NV(Int32 location, UInt64 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniform1ui64vNV(Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1uiEXT", ExactSpelling = true)]
            internal extern static void Uniform1uiEXT(Int32 location, UInt32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1uiv", ExactSpelling = true)]
            internal extern static unsafe void Uniform1uiv(Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform1uivEXT", ExactSpelling = true)]
            internal extern static unsafe void Uniform1uivEXT(Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2d", ExactSpelling = true)]
            internal extern static void Uniform2d(Int32 location, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2dv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2dv(Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
            internal extern static void Uniform2f(Int32 location, Single v0, Single v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2fARB", ExactSpelling = true)]
            internal extern static void Uniform2fARB(Int32 location, Single v0, Single v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2fv(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2fvARB", ExactSpelling = true)]
            internal extern static unsafe void Uniform2fvARB(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
            internal extern static void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2i64NV", ExactSpelling = true)]
            internal extern static void Uniform2i64NV(Int32 location, Int64 x, Int64 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2i64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniform2i64vNV(Int32 location, Int32 count, Int64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2iARB", ExactSpelling = true)]
            internal extern static void Uniform2iARB(Int32 location, Int32 v0, Int32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2iv(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2ivARB", ExactSpelling = true)]
            internal extern static unsafe void Uniform2ivARB(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2ui", ExactSpelling = true)]
            internal extern static void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2ui64NV", ExactSpelling = true)]
            internal extern static void Uniform2ui64NV(Int32 location, UInt64 x, UInt64 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniform2ui64vNV(Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2uiEXT", ExactSpelling = true)]
            internal extern static void Uniform2uiEXT(Int32 location, UInt32 v0, UInt32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2uiv", ExactSpelling = true)]
            internal extern static unsafe void Uniform2uiv(Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform2uivEXT", ExactSpelling = true)]
            internal extern static unsafe void Uniform2uivEXT(Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3d", ExactSpelling = true)]
            internal extern static void Uniform3d(Int32 location, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3dv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3dv(Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
            internal extern static void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3fARB", ExactSpelling = true)]
            internal extern static void Uniform3fARB(Int32 location, Single v0, Single v1, Single v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3fv(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3fvARB", ExactSpelling = true)]
            internal extern static unsafe void Uniform3fvARB(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
            internal extern static void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3i64NV", ExactSpelling = true)]
            internal extern static void Uniform3i64NV(Int32 location, Int64 x, Int64 y, Int64 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3i64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniform3i64vNV(Int32 location, Int32 count, Int64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3iARB", ExactSpelling = true)]
            internal extern static void Uniform3iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3iv(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3ivARB", ExactSpelling = true)]
            internal extern static unsafe void Uniform3ivARB(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3ui", ExactSpelling = true)]
            internal extern static void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3ui64NV", ExactSpelling = true)]
            internal extern static void Uniform3ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniform3ui64vNV(Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3uiEXT", ExactSpelling = true)]
            internal extern static void Uniform3uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3uiv", ExactSpelling = true)]
            internal extern static unsafe void Uniform3uiv(Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform3uivEXT", ExactSpelling = true)]
            internal extern static unsafe void Uniform3uivEXT(Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4d", ExactSpelling = true)]
            internal extern static void Uniform4d(Int32 location, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4dv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4dv(Int32 location, Int32 count, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
            internal extern static void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4fARB", ExactSpelling = true)]
            internal extern static void Uniform4fARB(Int32 location, Single v0, Single v1, Single v2, Single v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4fv(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4fvARB", ExactSpelling = true)]
            internal extern static unsafe void Uniform4fvARB(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
            internal extern static void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4i64NV", ExactSpelling = true)]
            internal extern static void Uniform4i64NV(Int32 location, Int64 x, Int64 y, Int64 z, Int64 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4i64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniform4i64vNV(Int32 location, Int32 count, Int64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4iARB", ExactSpelling = true)]
            internal extern static void Uniform4iARB(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4iv(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4ivARB", ExactSpelling = true)]
            internal extern static unsafe void Uniform4ivARB(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4ui", ExactSpelling = true)]
            internal extern static void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4ui64NV", ExactSpelling = true)]
            internal extern static void Uniform4ui64NV(Int32 location, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniform4ui64vNV(Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4uiEXT", ExactSpelling = true)]
            internal extern static void Uniform4uiEXT(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4uiv", ExactSpelling = true)]
            internal extern static unsafe void Uniform4uiv(Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniform4uivEXT", ExactSpelling = true)]
            internal extern static unsafe void Uniform4uivEXT(Int32 location, Int32 count, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformBlockBinding", ExactSpelling = true)]
            internal extern static void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformBufferEXT", ExactSpelling = true)]
            internal extern static void UniformBufferEXT(UInt32 program, Int32 location, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2fvARB", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2fvARB(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x3dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x4dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix2x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3fvARB", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3fvARB(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x2dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x4dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x4dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix3x4fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4fvARB", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4fvARB(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x2dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x2dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x2fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x3dv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x3dv(Int32 location, Int32 count, bool transpose, Double* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
            internal extern static unsafe void UniformMatrix4x3fv(Int32 location, Int32 count, bool transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformSubroutinesuiv", ExactSpelling = true)]
            internal extern static unsafe void UniformSubroutinesuiv(Pencil.Gaming.Graphics.ShaderType shadertype, Int32 count, UInt32* indices);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformui64NV", ExactSpelling = true)]
            internal extern static void Uniformui64NV(Int32 location, UInt64 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUniformui64vNV", ExactSpelling = true)]
            internal extern static unsafe void Uniformui64vNV(Int32 location, Int32 count, UInt64* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUnlockArraysEXT", ExactSpelling = true)]
            internal extern static void UnlockArraysEXT();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
            internal extern static bool UnmapBuffer(Pencil.Gaming.Graphics.BufferTarget target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUnmapBufferARB", ExactSpelling = true)]
            internal extern static bool UnmapBufferARB(Pencil.Gaming.Graphics.BufferTargetArb target);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUnmapNamedBufferEXT", ExactSpelling = true)]
            internal extern static bool UnmapNamedBufferEXT(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUnmapObjectBufferATI", ExactSpelling = true)]
            internal extern static void UnmapObjectBufferATI(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUpdateObjectBufferATI", ExactSpelling = true)]
            internal extern static void UpdateObjectBufferATI(UInt32 buffer, UInt32 offset, Int32 size, IntPtr pointer, Pencil.Gaming.Graphics.AtiVertexArrayObject preserve);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
            internal extern static void UseProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseProgramObjectARB", ExactSpelling = true)]
            internal extern static void UseProgramObjectARB(UInt32 programObj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseProgramStages", ExactSpelling = true)]
            internal extern static void UseProgramStages(UInt32 pipeline, Pencil.Gaming.Graphics.ProgramStageMask stages, UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glUseShaderProgramEXT", ExactSpelling = true)]
            internal extern static void UseShaderProgramEXT(Pencil.Gaming.Graphics.ExtSeparateShaderObjects type, UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
            internal extern static void ValidateProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glValidateProgramARB", ExactSpelling = true)]
            internal extern static void ValidateProgramARB(UInt32 programObj);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glValidateProgramPipeline", ExactSpelling = true)]
            internal extern static void ValidateProgramPipeline(UInt32 pipeline);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantArrayObjectATI", ExactSpelling = true)]
            internal extern static void VariantArrayObjectATI(UInt32 id, Pencil.Gaming.Graphics.AtiVertexArrayObject type, Int32 stride, UInt32 buffer, UInt32 offset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantbvEXT", ExactSpelling = true)]
            internal extern static unsafe void VariantbvEXT(UInt32 id, SByte* addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantdvEXT", ExactSpelling = true)]
            internal extern static unsafe void VariantdvEXT(UInt32 id, Double* addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantfvEXT", ExactSpelling = true)]
            internal extern static unsafe void VariantfvEXT(UInt32 id, Single* addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantivEXT", ExactSpelling = true)]
            internal extern static unsafe void VariantivEXT(UInt32 id, Int32* addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantPointerEXT", ExactSpelling = true)]
            internal extern static void VariantPointerEXT(UInt32 id, Pencil.Gaming.Graphics.ExtVertexShader type, UInt32 stride, IntPtr addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantsvEXT", ExactSpelling = true)]
            internal extern static unsafe void VariantsvEXT(UInt32 id, Int16* addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantubvEXT", ExactSpelling = true)]
            internal extern static unsafe void VariantubvEXT(UInt32 id, Byte* addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantuivEXT", ExactSpelling = true)]
            internal extern static unsafe void VariantuivEXT(UInt32 id, UInt32* addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVariantusvEXT", ExactSpelling = true)]
            internal extern static unsafe void VariantusvEXT(UInt32 id, UInt16* addr);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAUFiniNV", ExactSpelling = true)]
            internal extern static void VDPAUFiniNV();
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAUGetSurfaceivNV", ExactSpelling = true)]
            internal extern static unsafe void VDPAUGetSurfaceivNV(IntPtr surface, Pencil.Gaming.Graphics.NvVdpauInterop pname, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* values);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAUInitNV", ExactSpelling = true)]
            internal extern static void VDPAUInitNV(IntPtr vdpDevice, IntPtr getProcAddress);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAUIsSurfaceNV", ExactSpelling = true)]
            internal extern static void VDPAUIsSurfaceNV(IntPtr surface);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAUMapSurfacesNV", ExactSpelling = true)]
            internal extern static unsafe void VDPAUMapSurfacesNV(Int32 numSurfaces, IntPtr* surfaces);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAURegisterOutputSurfaceNV", ExactSpelling = true)]
            internal extern static unsafe IntPtr VDPAURegisterOutputSurfaceNV([OutAttribute] IntPtr vdpSurface, Pencil.Gaming.Graphics.NvVdpauInterop target, Int32 numTextureNames, UInt32* textureNames);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAURegisterVideoSurfaceNV", ExactSpelling = true)]
            internal extern static unsafe IntPtr VDPAURegisterVideoSurfaceNV([OutAttribute] IntPtr vdpSurface, Pencil.Gaming.Graphics.NvVdpauInterop target, Int32 numTextureNames, UInt32* textureNames);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAUSurfaceAccessNV", ExactSpelling = true)]
            internal extern static void VDPAUSurfaceAccessNV(IntPtr surface, Pencil.Gaming.Graphics.NvVdpauInterop access);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAUUnmapSurfacesNV", ExactSpelling = true)]
            internal extern static unsafe void VDPAUUnmapSurfacesNV(Int32 numSurface, IntPtr* surfaces);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVDPAUUnregisterSurfaceNV", ExactSpelling = true)]
            internal extern static void VDPAUUnregisterSurfaceNV(IntPtr surface);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2d", ExactSpelling = true)]
            internal extern static void Vertex2d(Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2dv", ExactSpelling = true)]
            internal extern static unsafe void Vertex2dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2f", ExactSpelling = true)]
            internal extern static void Vertex2f(Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2fv", ExactSpelling = true)]
            internal extern static unsafe void Vertex2fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2i", ExactSpelling = true)]
            internal extern static void Vertex2i(Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2iv", ExactSpelling = true)]
            internal extern static unsafe void Vertex2iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2s", ExactSpelling = true)]
            internal extern static void Vertex2s(Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex2sv", ExactSpelling = true)]
            internal extern static unsafe void Vertex2sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3d", ExactSpelling = true)]
            internal extern static void Vertex3d(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3dv", ExactSpelling = true)]
            internal extern static unsafe void Vertex3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3f", ExactSpelling = true)]
            internal extern static void Vertex3f(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3fv", ExactSpelling = true)]
            internal extern static unsafe void Vertex3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3i", ExactSpelling = true)]
            internal extern static void Vertex3i(Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3iv", ExactSpelling = true)]
            internal extern static unsafe void Vertex3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3s", ExactSpelling = true)]
            internal extern static void Vertex3s(Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex3sv", ExactSpelling = true)]
            internal extern static unsafe void Vertex3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4d", ExactSpelling = true)]
            internal extern static void Vertex4d(Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4dv", ExactSpelling = true)]
            internal extern static unsafe void Vertex4dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4f", ExactSpelling = true)]
            internal extern static void Vertex4f(Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4fv", ExactSpelling = true)]
            internal extern static unsafe void Vertex4fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4i", ExactSpelling = true)]
            internal extern static void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4iv", ExactSpelling = true)]
            internal extern static unsafe void Vertex4iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4s", ExactSpelling = true)]
            internal extern static void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertex4sv", ExactSpelling = true)]
            internal extern static unsafe void Vertex4sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexArrayParameteriAPPLE", ExactSpelling = true)]
            internal extern static void VertexArrayParameteriAPPLE(Pencil.Gaming.Graphics.AppleVertexArrayRange pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexArrayRangeAPPLE", ExactSpelling = true)]
            internal extern static void VertexArrayRangeAPPLE(Int32 length, [OutAttribute] IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexArrayRangeNV", ExactSpelling = true)]
            internal extern static void VertexArrayRangeNV(Int32 length, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexArrayVertexAttribLOffsetEXT", ExactSpelling = true)]
            internal extern static void VertexArrayVertexAttribLOffsetEXT(UInt32 vaobj, UInt32 buffer, UInt32 index, Int32 size, Pencil.Gaming.Graphics.ExtVertexAttrib64bit type, Int32 stride, IntPtr offset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
            internal extern static void VertexAttrib1d(UInt32 index, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1dARB", ExactSpelling = true)]
            internal extern static void VertexAttrib1dARB(UInt32 index, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1dNV", ExactSpelling = true)]
            internal extern static void VertexAttrib1dNV(UInt32 index, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1dvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1dvARB(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1dvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1dvNV(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
            internal extern static void VertexAttrib1f(UInt32 index, Single x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1fARB", ExactSpelling = true)]
            internal extern static void VertexAttrib1fARB(UInt32 index, Single x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1fNV", ExactSpelling = true)]
            internal extern static void VertexAttrib1fNV(UInt32 index, Single x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1fv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1fvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1fvARB(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1fvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1fvNV(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
            internal extern static void VertexAttrib1s(UInt32 index, Int16 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1sARB", ExactSpelling = true)]
            internal extern static void VertexAttrib1sARB(UInt32 index, Int16 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1sNV", ExactSpelling = true)]
            internal extern static void VertexAttrib1sNV(UInt32 index, Int16 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1svARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1svARB(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib1svNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib1svNV(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
            internal extern static void VertexAttrib2d(UInt32 index, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2dARB", ExactSpelling = true)]
            internal extern static void VertexAttrib2dARB(UInt32 index, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2dNV", ExactSpelling = true)]
            internal extern static void VertexAttrib2dNV(UInt32 index, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2dvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2dvARB(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2dvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2dvNV(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
            internal extern static void VertexAttrib2f(UInt32 index, Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2fARB", ExactSpelling = true)]
            internal extern static void VertexAttrib2fARB(UInt32 index, Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2fNV", ExactSpelling = true)]
            internal extern static void VertexAttrib2fNV(UInt32 index, Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2fv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2fvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2fvARB(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2fvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2fvNV(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
            internal extern static void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2sARB", ExactSpelling = true)]
            internal extern static void VertexAttrib2sARB(UInt32 index, Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2sNV", ExactSpelling = true)]
            internal extern static void VertexAttrib2sNV(UInt32 index, Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2svARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2svARB(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib2svNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib2svNV(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
            internal extern static void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3dARB", ExactSpelling = true)]
            internal extern static void VertexAttrib3dARB(UInt32 index, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3dNV", ExactSpelling = true)]
            internal extern static void VertexAttrib3dNV(UInt32 index, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3dvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3dvARB(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3dvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3dvNV(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
            internal extern static void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3fARB", ExactSpelling = true)]
            internal extern static void VertexAttrib3fARB(UInt32 index, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3fNV", ExactSpelling = true)]
            internal extern static void VertexAttrib3fNV(UInt32 index, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3fv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3fvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3fvARB(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3fvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3fvNV(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
            internal extern static void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3sARB", ExactSpelling = true)]
            internal extern static void VertexAttrib3sARB(UInt32 index, Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3sNV", ExactSpelling = true)]
            internal extern static void VertexAttrib3sNV(UInt32 index, Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3svARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3svARB(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib3svNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib3svNV(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4bv(UInt32 index, SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4bvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4bvARB(UInt32 index, SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
            internal extern static void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4dARB", ExactSpelling = true)]
            internal extern static void VertexAttrib4dARB(UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4dNV", ExactSpelling = true)]
            internal extern static void VertexAttrib4dNV(UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4dvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4dvARB(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4dvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4dvNV(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
            internal extern static void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4fARB", ExactSpelling = true)]
            internal extern static void VertexAttrib4fARB(UInt32 index, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4fNV", ExactSpelling = true)]
            internal extern static void VertexAttrib4fNV(UInt32 index, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4fv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4fvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4fvARB(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4fvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4fvNV(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4iv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4ivARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4ivARB(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nbv(UInt32 index, SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4NbvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4NbvARB(UInt32 index, SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Niv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4NivARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4NivARB(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nsv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4NsvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4NsvARB(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4NubARB", ExactSpelling = true)]
            internal extern static void VertexAttrib4NubARB(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nubv(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4NubvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4NubvARB(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4NuivARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4NuivARB(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4NusvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4NusvARB(UInt32 index, UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
            internal extern static void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4sARB", ExactSpelling = true)]
            internal extern static void VertexAttrib4sARB(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4sNV", ExactSpelling = true)]
            internal extern static void VertexAttrib4sNV(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4svARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4svARB(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4svNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4svNV(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4ubNV", ExactSpelling = true)]
            internal extern static void VertexAttrib4ubNV(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4ubv(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4ubvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4ubvARB(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4ubvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4ubvNV(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4uiv(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4uivARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4uivARB(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4usv(UInt32 index, UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttrib4usvARB", ExactSpelling = true)]
            internal extern static unsafe void VertexAttrib4usvARB(UInt32 index, UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribArrayObjectATI", ExactSpelling = true)]
            internal extern static void VertexAttribArrayObjectATI(UInt32 index, Int32 size, Pencil.Gaming.Graphics.AtiVertexAttribArrayObject type, bool normalized, Int32 stride, UInt32 buffer, UInt32 offset);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribDivisor", ExactSpelling = true)]
            internal extern static void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribDivisorARB", ExactSpelling = true)]
            internal extern static void VertexAttribDivisorARB(UInt32 index, UInt32 divisor);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribFormatNV", ExactSpelling = true)]
            internal extern static void VertexAttribFormatNV(UInt32 index, Int32 size, Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, bool normalized, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1i", ExactSpelling = true)]
            internal extern static void VertexAttribI1i(UInt32 index, Int32 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1iEXT", ExactSpelling = true)]
            internal extern static void VertexAttribI1iEXT(UInt32 index, Int32 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI1iv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1ivEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI1ivEXT(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1ui", ExactSpelling = true)]
            internal extern static void VertexAttribI1ui(UInt32 index, UInt32 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1uiEXT", ExactSpelling = true)]
            internal extern static void VertexAttribI1uiEXT(UInt32 index, UInt32 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI1uiv(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI1uivEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI1uivEXT(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2i", ExactSpelling = true)]
            internal extern static void VertexAttribI2i(UInt32 index, Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2iEXT", ExactSpelling = true)]
            internal extern static void VertexAttribI2iEXT(UInt32 index, Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI2iv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2ivEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI2ivEXT(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2ui", ExactSpelling = true)]
            internal extern static void VertexAttribI2ui(UInt32 index, UInt32 x, UInt32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2uiEXT", ExactSpelling = true)]
            internal extern static void VertexAttribI2uiEXT(UInt32 index, UInt32 x, UInt32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI2uiv(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI2uivEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI2uivEXT(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3i", ExactSpelling = true)]
            internal extern static void VertexAttribI3i(UInt32 index, Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3iEXT", ExactSpelling = true)]
            internal extern static void VertexAttribI3iEXT(UInt32 index, Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI3iv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3ivEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI3ivEXT(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3ui", ExactSpelling = true)]
            internal extern static void VertexAttribI3ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3uiEXT", ExactSpelling = true)]
            internal extern static void VertexAttribI3uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI3uiv(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI3uivEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI3uivEXT(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4bv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4bv(UInt32 index, SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4bvEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4bvEXT(UInt32 index, SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4i", ExactSpelling = true)]
            internal extern static void VertexAttribI4i(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4iEXT", ExactSpelling = true)]
            internal extern static void VertexAttribI4iEXT(UInt32 index, Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4iv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4iv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4ivEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4ivEXT(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4sv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4svEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4svEXT(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4ubv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4ubv(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4ubvEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4ubvEXT(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4ui", ExactSpelling = true)]
            internal extern static void VertexAttribI4ui(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4uiEXT", ExactSpelling = true)]
            internal extern static void VertexAttribI4uiEXT(UInt32 index, UInt32 x, UInt32 y, UInt32 z, UInt32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4uiv(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4uivEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4uivEXT(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4usv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4usv(UInt32 index, UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribI4usvEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribI4usvEXT(UInt32 index, UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribIFormatNV", ExactSpelling = true)]
            internal extern static void VertexAttribIFormatNV(UInt32 index, Int32 size, Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribIPointer", ExactSpelling = true)]
            internal extern static void VertexAttribIPointer(UInt32 index, Int32 size, Pencil.Gaming.Graphics.VertexAttribIPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribIPointerEXT", ExactSpelling = true)]
            internal extern static void VertexAttribIPointerEXT(UInt32 index, Int32 size, Pencil.Gaming.Graphics.NvVertexProgram4 type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1d", ExactSpelling = true)]
            internal extern static void VertexAttribL1d(UInt32 index, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1dEXT", ExactSpelling = true)]
            internal extern static void VertexAttribL1dEXT(UInt32 index, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL1dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1dvEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL1dvEXT(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1i64NV", ExactSpelling = true)]
            internal extern static void VertexAttribL1i64NV(UInt32 index, Int64 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1i64vNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL1i64vNV(UInt32 index, Int64* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1ui64NV", ExactSpelling = true)]
            internal extern static void VertexAttribL1ui64NV(UInt32 index, UInt64 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL1ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL1ui64vNV(UInt32 index, UInt64* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2d", ExactSpelling = true)]
            internal extern static void VertexAttribL2d(UInt32 index, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2dEXT", ExactSpelling = true)]
            internal extern static void VertexAttribL2dEXT(UInt32 index, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL2dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2dvEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL2dvEXT(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2i64NV", ExactSpelling = true)]
            internal extern static void VertexAttribL2i64NV(UInt32 index, Int64 x, Int64 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2i64vNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL2i64vNV(UInt32 index, Int64* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2ui64NV", ExactSpelling = true)]
            internal extern static void VertexAttribL2ui64NV(UInt32 index, UInt64 x, UInt64 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL2ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL2ui64vNV(UInt32 index, UInt64* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3d", ExactSpelling = true)]
            internal extern static void VertexAttribL3d(UInt32 index, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3dEXT", ExactSpelling = true)]
            internal extern static void VertexAttribL3dEXT(UInt32 index, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL3dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3dvEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL3dvEXT(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3i64NV", ExactSpelling = true)]
            internal extern static void VertexAttribL3i64NV(UInt32 index, Int64 x, Int64 y, Int64 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3i64vNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL3i64vNV(UInt32 index, Int64* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3ui64NV", ExactSpelling = true)]
            internal extern static void VertexAttribL3ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL3ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL3ui64vNV(UInt32 index, UInt64* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4d", ExactSpelling = true)]
            internal extern static void VertexAttribL4d(UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4dEXT", ExactSpelling = true)]
            internal extern static void VertexAttribL4dEXT(UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4dv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL4dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4dvEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL4dvEXT(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4i64NV", ExactSpelling = true)]
            internal extern static void VertexAttribL4i64NV(UInt32 index, Int64 x, Int64 y, Int64 z, Int64 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4i64vNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL4i64vNV(UInt32 index, Int64* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4ui64NV", ExactSpelling = true)]
            internal extern static void VertexAttribL4ui64NV(UInt32 index, UInt64 x, UInt64 y, UInt64 z, UInt64 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribL4ui64vNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribL4ui64vNV(UInt32 index, UInt64* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribLFormatNV", ExactSpelling = true)]
            internal extern static void VertexAttribLFormatNV(UInt32 index, Int32 size, Pencil.Gaming.Graphics.NvVertexAttribInteger64bit type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribLPointer", ExactSpelling = true)]
            internal extern static void VertexAttribLPointer(UInt32 index, Int32 size, Pencil.Gaming.Graphics.VertexAttribDPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribLPointerEXT", ExactSpelling = true)]
            internal extern static void VertexAttribLPointerEXT(UInt32 index, Int32 size, Pencil.Gaming.Graphics.ExtVertexAttrib64bit type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP1ui", ExactSpelling = true)]
            internal extern static void VertexAttribP1ui(UInt32 index, Pencil.Gaming.Graphics.PackedPointerType type, bool normalized, UInt32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP1uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribP1uiv(UInt32 index, Pencil.Gaming.Graphics.PackedPointerType type, bool normalized, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP2ui", ExactSpelling = true)]
            internal extern static void VertexAttribP2ui(UInt32 index, Pencil.Gaming.Graphics.PackedPointerType type, bool normalized, UInt32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP2uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribP2uiv(UInt32 index, Pencil.Gaming.Graphics.PackedPointerType type, bool normalized, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP3ui", ExactSpelling = true)]
            internal extern static void VertexAttribP3ui(UInt32 index, Pencil.Gaming.Graphics.PackedPointerType type, bool normalized, UInt32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP3uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribP3uiv(UInt32 index, Pencil.Gaming.Graphics.PackedPointerType type, bool normalized, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP4ui", ExactSpelling = true)]
            internal extern static void VertexAttribP4ui(UInt32 index, Pencil.Gaming.Graphics.PackedPointerType type, bool normalized, UInt32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribP4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribP4uiv(UInt32 index, Pencil.Gaming.Graphics.PackedPointerType type, bool normalized, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
            internal extern static void VertexAttribPointer(UInt32 index, Int32 size, Pencil.Gaming.Graphics.VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribPointerARB", ExactSpelling = true)]
            internal extern static void VertexAttribPointerARB(UInt32 index, Int32 size, Pencil.Gaming.Graphics.VertexAttribPointerTypeArb type, bool normalized, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribPointerNV", ExactSpelling = true)]
            internal extern static void VertexAttribPointerNV(UInt32 index, Int32 fsize, Pencil.Gaming.Graphics.VertexAttribParameterArb type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs1dvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs1dvNV(UInt32 index, Int32 count, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs1fvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs1fvNV(UInt32 index, Int32 count, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs1svNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs1svNV(UInt32 index, Int32 count, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs2dvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs2dvNV(UInt32 index, Int32 count, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs2fvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs2fvNV(UInt32 index, Int32 count, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs2svNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs2svNV(UInt32 index, Int32 count, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs3dvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs3dvNV(UInt32 index, Int32 count, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs3fvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs3fvNV(UInt32 index, Int32 count, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs3svNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs3svNV(UInt32 index, Int32 count, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs4dvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs4dvNV(UInt32 index, Int32 count, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs4fvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs4fvNV(UInt32 index, Int32 count, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs4svNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs4svNV(UInt32 index, Int32 count, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexAttribs4ubvNV", ExactSpelling = true)]
            internal extern static unsafe void VertexAttribs4ubvNV(UInt32 index, Int32 count, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexBlendARB", ExactSpelling = true)]
            internal extern static void VertexBlendARB(Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexBlendEnvfATI", ExactSpelling = true)]
            internal extern static void VertexBlendEnvfATI(Pencil.Gaming.Graphics.AtiVertexStreams pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexBlendEnviATI", ExactSpelling = true)]
            internal extern static void VertexBlendEnviATI(Pencil.Gaming.Graphics.AtiVertexStreams pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexFormatNV", ExactSpelling = true)]
            internal extern static void VertexFormatNV(Int32 size, Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type, Int32 stride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP2ui", ExactSpelling = true)]
            internal extern static void VertexP2ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP2uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexP2uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP3ui", ExactSpelling = true)]
            internal extern static void VertexP3ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP3uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexP3uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP4ui", ExactSpelling = true)]
            internal extern static void VertexP4ui(Pencil.Gaming.Graphics.PackedPointerType type, UInt32 value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexP4uiv", ExactSpelling = true)]
            internal extern static unsafe void VertexP4uiv(Pencil.Gaming.Graphics.PackedPointerType type, UInt32* value);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
            internal extern static void VertexPointer(Int32 size, Pencil.Gaming.Graphics.VertexPointerType type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexPointerEXT", ExactSpelling = true)]
            internal extern static void VertexPointerEXT(Int32 size, Pencil.Gaming.Graphics.VertexPointerType type, Int32 stride, Int32 count, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexPointerListIBM", ExactSpelling = true)]
            internal extern static void VertexPointerListIBM(Int32 size, Pencil.Gaming.Graphics.VertexPointerType type, Int32 stride, IntPtr pointer, Int32 ptrstride);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexPointervINTEL", ExactSpelling = true)]
            internal extern static void VertexPointervINTEL(Int32 size, Pencil.Gaming.Graphics.VertexPointerType type, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream1dATI", ExactSpelling = true)]
            internal extern static void VertexStream1dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream1dvATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream1dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream1fATI", ExactSpelling = true)]
            internal extern static void VertexStream1fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream1fvATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream1fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream1iATI", ExactSpelling = true)]
            internal extern static void VertexStream1iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream1ivATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream1ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream1sATI", ExactSpelling = true)]
            internal extern static void VertexStream1sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16 x);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream1svATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream1svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream2dATI", ExactSpelling = true)]
            internal extern static void VertexStream2dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream2dvATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream2dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream2fATI", ExactSpelling = true)]
            internal extern static void VertexStream2fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream2fvATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream2fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream2iATI", ExactSpelling = true)]
            internal extern static void VertexStream2iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream2ivATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream2ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream2sATI", ExactSpelling = true)]
            internal extern static void VertexStream2sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream2svATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream2svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream3dATI", ExactSpelling = true)]
            internal extern static void VertexStream3dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream3dvATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream3dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream3fATI", ExactSpelling = true)]
            internal extern static void VertexStream3fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream3fvATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream3fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream3iATI", ExactSpelling = true)]
            internal extern static void VertexStream3iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream3ivATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream3ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream3sATI", ExactSpelling = true)]
            internal extern static void VertexStream3sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream3svATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream3svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream4dATI", ExactSpelling = true)]
            internal extern static void VertexStream4dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream4dvATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream4dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Double* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream4fATI", ExactSpelling = true)]
            internal extern static void VertexStream4fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream4fvATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream4fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Single* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream4iATI", ExactSpelling = true)]
            internal extern static void VertexStream4iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream4ivATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream4ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int32* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream4sATI", ExactSpelling = true)]
            internal extern static void VertexStream4sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexStream4svATI", ExactSpelling = true)]
            internal extern static unsafe void VertexStream4svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream, Int16* coords);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexWeightfEXT", ExactSpelling = true)]
            internal extern static void VertexWeightfEXT(Single weight);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexWeightfvEXT", ExactSpelling = true)]
            internal extern static unsafe void VertexWeightfvEXT(Single* weight);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVertexWeightPointerEXT", ExactSpelling = true)]
            internal extern static void VertexWeightPointerEXT(Int32 size, Pencil.Gaming.Graphics.ExtVertexWeighting type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVideoCaptureNV", ExactSpelling = true)]
            internal extern static unsafe Pencil.Gaming.Graphics.NvVideoCapture VideoCaptureNV(UInt32 video_capture_slot, [OutAttribute] UInt32* sequence_num, [OutAttribute] UInt64* capture_time);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVideoCaptureStreamParameterdvNV", ExactSpelling = true)]
            internal extern static unsafe void VideoCaptureStreamParameterdvNV(UInt32 video_capture_slot, UInt32 stream, Pencil.Gaming.Graphics.NvVideoCapture pname, Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVideoCaptureStreamParameterfvNV", ExactSpelling = true)]
            internal extern static unsafe void VideoCaptureStreamParameterfvNV(UInt32 video_capture_slot, UInt32 stream, Pencil.Gaming.Graphics.NvVideoCapture pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glVideoCaptureStreamParameterivNV", ExactSpelling = true)]
            internal extern static unsafe void VideoCaptureStreamParameterivNV(UInt32 video_capture_slot, UInt32 stream, Pencil.Gaming.Graphics.NvVideoCapture pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal extern static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewportArrayv", ExactSpelling = true)]
            internal extern static unsafe void ViewportArrayv(UInt32 first, Int32 count, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewportIndexedf", ExactSpelling = true)]
            internal extern static void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glViewportIndexedfv", ExactSpelling = true)]
            internal extern static unsafe void ViewportIndexedfv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWaitSync", ExactSpelling = true)]
            internal extern static void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightbvARB", ExactSpelling = true)]
            internal extern static unsafe void WeightbvARB(Int32 size, SByte* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightdvARB", ExactSpelling = true)]
            internal extern static unsafe void WeightdvARB(Int32 size, Double* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightfvARB", ExactSpelling = true)]
            internal extern static unsafe void WeightfvARB(Int32 size, Single* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightivARB", ExactSpelling = true)]
            internal extern static unsafe void WeightivARB(Int32 size, Int32* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightPointerARB", ExactSpelling = true)]
            internal extern static void WeightPointerARB(Int32 size, Pencil.Gaming.Graphics.ArbVertexBlend type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightsvARB", ExactSpelling = true)]
            internal extern static unsafe void WeightsvARB(Int32 size, Int16* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightubvARB", ExactSpelling = true)]
            internal extern static unsafe void WeightubvARB(Int32 size, Byte* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightuivARB", ExactSpelling = true)]
            internal extern static unsafe void WeightuivARB(Int32 size, UInt32* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWeightusvARB", ExactSpelling = true)]
            internal extern static unsafe void WeightusvARB(Int32 size, UInt16* weights);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2d", ExactSpelling = true)]
            internal extern static void WindowPos2d(Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2dARB", ExactSpelling = true)]
            internal extern static void WindowPos2dARB(Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2dMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos2dMESA(Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2dv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2dvARB", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2dvARB(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2dvMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos2dvMESA(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2f", ExactSpelling = true)]
            internal extern static void WindowPos2f(Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2fARB", ExactSpelling = true)]
            internal extern static void WindowPos2fARB(Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2fMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos2fMESA(Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2fv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2fvARB", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2fvARB(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2fvMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos2fvMESA(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2i", ExactSpelling = true)]
            internal extern static void WindowPos2i(Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2iARB", ExactSpelling = true)]
            internal extern static void WindowPos2iARB(Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2iMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos2iMESA(Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2iv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2ivARB", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2ivARB(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2ivMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos2ivMESA(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2s", ExactSpelling = true)]
            internal extern static void WindowPos2s(Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2sARB", ExactSpelling = true)]
            internal extern static void WindowPos2sARB(Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2sMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos2sMESA(Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2sv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2svARB", ExactSpelling = true)]
            internal extern static unsafe void WindowPos2svARB(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos2svMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos2svMESA(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3d", ExactSpelling = true)]
            internal extern static void WindowPos3d(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3dARB", ExactSpelling = true)]
            internal extern static void WindowPos3dARB(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3dMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos3dMESA(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3dv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3dvARB", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3dvARB(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3dvMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos3dvMESA(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3f", ExactSpelling = true)]
            internal extern static void WindowPos3f(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3fARB", ExactSpelling = true)]
            internal extern static void WindowPos3fARB(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3fMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos3fMESA(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3fv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3fvARB", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3fvARB(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3fvMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos3fvMESA(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3i", ExactSpelling = true)]
            internal extern static void WindowPos3i(Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3iARB", ExactSpelling = true)]
            internal extern static void WindowPos3iARB(Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3iMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos3iMESA(Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3iv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3ivARB", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3ivARB(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3ivMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos3ivMESA(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3s", ExactSpelling = true)]
            internal extern static void WindowPos3s(Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3sARB", ExactSpelling = true)]
            internal extern static void WindowPos3sARB(Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3sMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos3sMESA(Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3sv", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3svARB", ExactSpelling = true)]
            internal extern static unsafe void WindowPos3svARB(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos3svMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos3svMESA(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos4dMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos4dMESA(Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos4dvMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos4dvMESA(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos4fMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos4fMESA(Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos4fvMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos4fvMESA(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos4iMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos4iMESA(Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos4ivMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos4ivMESA(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos4sMESA", CharSet = CharSet.Auto)]
            internal extern static void WindowPos4sMESA(Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWindowPos4svMESA", CharSet = CharSet.Auto)]
            internal extern static unsafe void WindowPos4svMESA(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [System.Runtime.InteropServices.DllImport(GL.Library, EntryPoint = "glWriteMaskEXT", ExactSpelling = true)]
            internal extern static void WriteMaskEXT(UInt32 res, UInt32 @in, Pencil.Gaming.Graphics.ExtVertexShader outX, Pencil.Gaming.Graphics.ExtVertexShader outY, Pencil.Gaming.Graphics.ExtVertexShader outZ, Pencil.Gaming.Graphics.ExtVertexShader outW);
        }
    }
}
