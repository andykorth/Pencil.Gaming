using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Pencil.Gaming.Graphics {
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class GL {
        internal static partial class Delegates {
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Accum(Pencil.Gaming.Graphics.AccumOp op,Single value);
            internal static Accum glAccum;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveProgramEXT(UInt32 program);
            internal static ActiveProgramEXT glActiveProgramEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveShaderProgram(UInt32 pipeline,UInt32 program);
            internal static ActiveShaderProgram glActiveShaderProgram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveStencilFaceEXT(Pencil.Gaming.Graphics.ExtStencilTwoSide face);
            internal static ActiveStencilFaceEXT glActiveStencilFaceEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTexture(Pencil.Gaming.Graphics.TextureUnit texture);
            internal static ActiveTexture glActiveTexture;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveTextureARB(Pencil.Gaming.Graphics.TextureUnit texture);
            internal static ActiveTextureARB glActiveTextureARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ActiveVaryingNV(UInt32 program,String name);
            internal static ActiveVaryingNV glActiveVaryingNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp1ATI(Pencil.Gaming.Graphics.AtiFragmentShader op,UInt32 dst,UInt32 dstMod,UInt32 arg1,UInt32 arg1Rep,UInt32 arg1Mod);
            internal static AlphaFragmentOp1ATI glAlphaFragmentOp1ATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp2ATI(Pencil.Gaming.Graphics.AtiFragmentShader op,UInt32 dst,UInt32 dstMod,UInt32 arg1,UInt32 arg1Rep,UInt32 arg1Mod,UInt32 arg2,UInt32 arg2Rep,UInt32 arg2Mod);
            internal static AlphaFragmentOp2ATI glAlphaFragmentOp2ATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFragmentOp3ATI(Pencil.Gaming.Graphics.AtiFragmentShader op,UInt32 dst,UInt32 dstMod,UInt32 arg1,UInt32 arg1Rep,UInt32 arg1Mod,UInt32 arg2,UInt32 arg2Rep,UInt32 arg2Mod,UInt32 arg3,UInt32 arg3Rep,UInt32 arg3Mod);
            internal static AlphaFragmentOp3ATI glAlphaFragmentOp3ATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void AlphaFunc(Pencil.Gaming.Graphics.AlphaFunction func,Single @ref);
            internal static AlphaFunc glAlphaFunc;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ApplyTextureEXT(Pencil.Gaming.Graphics.ExtLightTexture mode);
            internal static ApplyTextureEXT glApplyTextureEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool AreProgramsResidentNV(Int32 n,UInt32* programs,[OutAttribute] bool* residences);
            internal unsafe static AreProgramsResidentNV glAreProgramsResidentNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool AreTexturesResident(Int32 n,UInt32* textures,[OutAttribute] bool* residences);
            internal unsafe static AreTexturesResident glAreTexturesResident;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate bool AreTexturesResidentEXT(Int32 n,UInt32* textures,[OutAttribute] bool* residences);
            internal unsafe static AreTexturesResidentEXT glAreTexturesResidentEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayElement(Int32 i);
            internal static ArrayElement glArrayElement;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayElementEXT(Int32 i);
            internal static ArrayElementEXT glArrayElementEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ArrayObjectATI(Pencil.Gaming.Graphics.EnableCap array,Int32 size,Pencil.Gaming.Graphics.AtiVertexArrayObject type,Int32 stride,UInt32 buffer,UInt32 offset);
            internal static ArrayObjectATI glArrayObjectATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void AsyncMarkerSGIX(UInt32 marker);
            internal static AsyncMarkerSGIX glAsyncMarkerSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachObjectARB(UInt32 containerObj,UInt32 obj);
            internal static AttachObjectARB glAttachObjectARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void AttachShader(UInt32 program,UInt32 shader);
            internal static AttachShader glAttachShader;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Begin(Pencil.Gaming.Graphics.BeginMode mode);
            internal static Begin glBegin;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginConditionalRender(UInt32 id,Pencil.Gaming.Graphics.ConditionalRenderType mode);
            internal static BeginConditionalRender glBeginConditionalRender;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginConditionalRenderNV(UInt32 id,Pencil.Gaming.Graphics.NvConditionalRender mode);
            internal static BeginConditionalRenderNV glBeginConditionalRenderNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginFragmentShaderATI();
            internal static BeginFragmentShaderATI glBeginFragmentShaderATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginOcclusionQueryNV(UInt32 id);
            internal static BeginOcclusionQueryNV glBeginOcclusionQueryNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginPerfMonitorAMD(UInt32 monitor);
            internal static BeginPerfMonitorAMD glBeginPerfMonitorAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQuery(Pencil.Gaming.Graphics.QueryTarget target,UInt32 id);
            internal static BeginQuery glBeginQuery;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryARB(Pencil.Gaming.Graphics.ArbOcclusionQuery target,UInt32 id);
            internal static BeginQueryARB glBeginQueryARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginQueryIndexed(Pencil.Gaming.Graphics.QueryTarget target,UInt32 index,UInt32 id);
            internal static BeginQueryIndexed glBeginQueryIndexed;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedback(Pencil.Gaming.Graphics.BeginFeedbackMode primitiveMode);
            internal static BeginTransformFeedback glBeginTransformFeedback;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedbackEXT(Pencil.Gaming.Graphics.ExtTransformFeedback primitiveMode);
            internal static BeginTransformFeedbackEXT glBeginTransformFeedbackEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginTransformFeedbackNV(Pencil.Gaming.Graphics.NvTransformFeedback primitiveMode);
            internal static BeginTransformFeedbackNV glBeginTransformFeedbackNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginVertexShaderEXT();
            internal static BeginVertexShaderEXT glBeginVertexShaderEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BeginVideoCaptureNV(UInt32 video_capture_slot);
            internal static BeginVideoCaptureNV glBeginVideoCaptureNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocation(UInt32 program,UInt32 index,String name);
            internal static BindAttribLocation glBindAttribLocation;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindAttribLocationARB(UInt32 programObj,UInt32 index,String name);
            internal static BindAttribLocationARB glBindAttribLocationARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBuffer(Pencil.Gaming.Graphics.BufferTarget target,UInt32 buffer);
            internal static BindBuffer glBindBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferARB(Pencil.Gaming.Graphics.BufferTargetArb target,UInt32 buffer);
            internal static BindBufferARB glBindBufferARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBase(Pencil.Gaming.Graphics.BufferTarget target,UInt32 index,UInt32 buffer);
            internal static BindBufferBase glBindBufferBase;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBaseEXT(Pencil.Gaming.Graphics.ExtTransformFeedback target,UInt32 index,UInt32 buffer);
            internal static BindBufferBaseEXT glBindBufferBaseEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferBaseNV(Pencil.Gaming.Graphics.NvTransformFeedback target,UInt32 index,UInt32 buffer);
            internal static BindBufferBaseNV glBindBufferBaseNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferOffsetEXT(Pencil.Gaming.Graphics.ExtTransformFeedback target,UInt32 index,UInt32 buffer,IntPtr offset);
            internal static BindBufferOffsetEXT glBindBufferOffsetEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferOffsetNV(Pencil.Gaming.Graphics.NvTransformFeedback target,UInt32 index,UInt32 buffer,IntPtr offset);
            internal static BindBufferOffsetNV glBindBufferOffsetNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRange(Pencil.Gaming.Graphics.BufferTarget target,UInt32 index,UInt32 buffer,IntPtr offset,IntPtr size);
            internal static BindBufferRange glBindBufferRange;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRangeEXT(Pencil.Gaming.Graphics.ExtTransformFeedback target,UInt32 index,UInt32 buffer,IntPtr offset,IntPtr size);
            internal static BindBufferRangeEXT glBindBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindBufferRangeNV(Pencil.Gaming.Graphics.NvTransformFeedback target,UInt32 index,UInt32 buffer,IntPtr offset,IntPtr size);
            internal static BindBufferRangeNV glBindBufferRangeNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocation(UInt32 program,UInt32 color,String name);
            internal static BindFragDataLocation glBindFragDataLocation;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocationEXT(UInt32 program,UInt32 color,String name);
            internal static BindFragDataLocationEXT glBindFragDataLocationEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragDataLocationIndexed(UInt32 program,UInt32 colorNumber,UInt32 index,String name);
            internal static BindFragDataLocationIndexed glBindFragDataLocationIndexed;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFragmentShaderATI(UInt32 id);
            internal static BindFragmentShaderATI glBindFragmentShaderATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebuffer(Pencil.Gaming.Graphics.FramebufferTarget target,UInt32 framebuffer);
            internal static BindFramebuffer glBindFramebuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindFramebufferEXT(Pencil.Gaming.Graphics.FramebufferTarget target,UInt32 framebuffer);
            internal static BindFramebufferEXT glBindFramebufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindImageTextureEXT(UInt32 index,UInt32 texture,Int32 level,bool layered,Int32 layer,Pencil.Gaming.Graphics.ExtShaderImageLoadStore access,Int32 format);
            internal static BindImageTextureEXT glBindImageTextureEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindLightParameterEXT(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter value);
            internal static BindLightParameterEXT glBindLightParameterEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindMaterialParameterEXT(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter value);
            internal static BindMaterialParameterEXT glBindMaterialParameterEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindMultiTextureEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,UInt32 texture);
            internal static BindMultiTextureEXT glBindMultiTextureEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindParameterEXT(Pencil.Gaming.Graphics.ExtVertexShader value);
            internal static BindParameterEXT glBindParameterEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 program);
            internal static BindProgramARB glBindProgramARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 id);
            internal static BindProgramNV glBindProgramNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindProgramPipeline(UInt32 pipeline);
            internal static BindProgramPipeline glBindProgramPipeline;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbuffer(Pencil.Gaming.Graphics.RenderbufferTarget target,UInt32 renderbuffer);
            internal static BindRenderbuffer glBindRenderbuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindRenderbufferEXT(Pencil.Gaming.Graphics.RenderbufferTarget target,UInt32 renderbuffer);
            internal static BindRenderbufferEXT glBindRenderbufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindSampler(UInt32 unit,UInt32 sampler);
            internal static BindSampler glBindSampler;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindTexGenParameterEXT(Pencil.Gaming.Graphics.TextureUnit unit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter value);
            internal static BindTexGenParameterEXT glBindTexGenParameterEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTexture(Pencil.Gaming.Graphics.TextureTarget target,UInt32 texture);
            internal static BindTexture glBindTexture;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTextureEXT(Pencil.Gaming.Graphics.TextureTarget target,UInt32 texture);
            internal static BindTextureEXT glBindTextureEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 BindTextureUnitParameterEXT(Pencil.Gaming.Graphics.TextureUnit unit,Pencil.Gaming.Graphics.ExtVertexShader value);
            internal static BindTextureUnitParameterEXT glBindTextureUnitParameterEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTransformFeedback(Pencil.Gaming.Graphics.TransformFeedbackTarget target,UInt32 id);
            internal static BindTransformFeedback glBindTransformFeedback;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindTransformFeedbackNV(Pencil.Gaming.Graphics.NvTransformFeedback2 target,UInt32 id);
            internal static BindTransformFeedbackNV glBindTransformFeedbackNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArray(UInt32 array);
            internal static BindVertexArray glBindVertexArray;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexArrayAPPLE(UInt32 array);
            internal static BindVertexArrayAPPLE glBindVertexArrayAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVertexShaderEXT(UInt32 id);
            internal static BindVertexShaderEXT glBindVertexShaderEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVideoCaptureStreamBufferNV(UInt32 video_capture_slot,UInt32 stream,Pencil.Gaming.Graphics.NvVideoCapture frame_region,IntPtr offset);
            internal static BindVideoCaptureStreamBufferNV glBindVideoCaptureStreamBufferNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BindVideoCaptureStreamTextureNV(UInt32 video_capture_slot,UInt32 stream,Pencil.Gaming.Graphics.NvVideoCapture frame_region,Pencil.Gaming.Graphics.NvVideoCapture target,UInt32 texture);
            internal static BindVideoCaptureStreamTextureNV glBindVideoCaptureStreamTextureNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3bEXT(SByte bx,SByte by,SByte bz);
            internal static Binormal3bEXT glBinormal3bEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3bvEXT(SByte* v);
            internal unsafe static Binormal3bvEXT glBinormal3bvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3dEXT(Double bx,Double by,Double bz);
            internal static Binormal3dEXT glBinormal3dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3dvEXT(Double* v);
            internal unsafe static Binormal3dvEXT glBinormal3dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3fEXT(Single bx,Single by,Single bz);
            internal static Binormal3fEXT glBinormal3fEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3fvEXT(Single* v);
            internal unsafe static Binormal3fvEXT glBinormal3fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3iEXT(Int32 bx,Int32 by,Int32 bz);
            internal static Binormal3iEXT glBinormal3iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3ivEXT(Int32* v);
            internal unsafe static Binormal3ivEXT glBinormal3ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Binormal3sEXT(Int16 bx,Int16 by,Int16 bz);
            internal static Binormal3sEXT glBinormal3sEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Binormal3svEXT(Int16* v);
            internal unsafe static Binormal3svEXT glBinormal3svEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BinormalPointerEXT(Pencil.Gaming.Graphics.NormalPointerType type,Int32 stride,IntPtr pointer);
            internal static BinormalPointerEXT glBinormalPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Bitmap(Int32 width,Int32 height,Single xorig,Single yorig,Single xmove,Single ymove,Byte* bitmap);
            internal unsafe static Bitmap glBitmap;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColor(Single red,Single green,Single blue,Single alpha);
            internal static BlendColor glBlendColor;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendColorEXT(Single red,Single green,Single blue,Single alpha);
            internal static BlendColorEXT glBlendColorEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquation(Pencil.Gaming.Graphics.BlendEquationMode mode);
            internal static BlendEquation glBlendEquation;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationEXT(Pencil.Gaming.Graphics.ExtBlendMinmax mode);
            internal static BlendEquationEXT glBlendEquationEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationi(UInt32 buf,Pencil.Gaming.Graphics.Version40 mode);
            internal static BlendEquationi glBlendEquationi;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationiARB(UInt32 buf,Pencil.Gaming.Graphics.ArbDrawBuffersBlend mode);
            internal static BlendEquationiARB glBlendEquationiARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationIndexedAMD(UInt32 buf,Pencil.Gaming.Graphics.AmdDrawBuffersBlend mode);
            internal static BlendEquationIndexedAMD glBlendEquationIndexedAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparate(Pencil.Gaming.Graphics.BlendEquationMode modeRGB,Pencil.Gaming.Graphics.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparate glBlendEquationSeparate;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateEXT(Pencil.Gaming.Graphics.ExtBlendEquationSeparate modeRGB,Pencil.Gaming.Graphics.ExtBlendEquationSeparate modeAlpha);
            internal static BlendEquationSeparateEXT glBlendEquationSeparateEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparatei(UInt32 buf,Pencil.Gaming.Graphics.BlendEquationMode modeRGB,Pencil.Gaming.Graphics.BlendEquationMode modeAlpha);
            internal static BlendEquationSeparatei glBlendEquationSeparatei;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateiARB(UInt32 buf,Pencil.Gaming.Graphics.ArbDrawBuffersBlend modeRGB,Pencil.Gaming.Graphics.ArbDrawBuffersBlend modeAlpha);
            internal static BlendEquationSeparateiARB glBlendEquationSeparateiARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendEquationSeparateIndexedAMD(UInt32 buf,Pencil.Gaming.Graphics.AmdDrawBuffersBlend modeRGB,Pencil.Gaming.Graphics.AmdDrawBuffersBlend modeAlpha);
            internal static BlendEquationSeparateIndexedAMD glBlendEquationSeparateIndexedAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunc(Pencil.Gaming.Graphics.BlendingFactorSrc sfactor,Pencil.Gaming.Graphics.BlendingFactorDest dfactor);
            internal static BlendFunc glBlendFunc;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunci(UInt32 buf,Pencil.Gaming.Graphics.Version40 src,Pencil.Gaming.Graphics.Version40 dst);
            internal static BlendFunci glBlendFunci;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFunciARB(UInt32 buf,Pencil.Gaming.Graphics.ArbDrawBuffersBlend src,Pencil.Gaming.Graphics.ArbDrawBuffersBlend dst);
            internal static BlendFunciARB glBlendFunciARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncIndexedAMD(UInt32 buf,Pencil.Gaming.Graphics.AmdDrawBuffersBlend src,Pencil.Gaming.Graphics.AmdDrawBuffersBlend dst);
            internal static BlendFuncIndexedAMD glBlendFuncIndexedAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparate(Pencil.Gaming.Graphics.BlendingFactorSrc sfactorRGB,Pencil.Gaming.Graphics.BlendingFactorDest dfactorRGB,Pencil.Gaming.Graphics.BlendingFactorSrc sfactorAlpha,Pencil.Gaming.Graphics.BlendingFactorDest dfactorAlpha);
            internal static BlendFuncSeparate glBlendFuncSeparate;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateEXT(Pencil.Gaming.Graphics.ExtBlendFuncSeparate sfactorRGB,Pencil.Gaming.Graphics.ExtBlendFuncSeparate dfactorRGB,Pencil.Gaming.Graphics.ExtBlendFuncSeparate sfactorAlpha,Pencil.Gaming.Graphics.ExtBlendFuncSeparate dfactorAlpha);
            internal static BlendFuncSeparateEXT glBlendFuncSeparateEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparatei(UInt32 buf,Pencil.Gaming.Graphics.Version40 srcRGB,Pencil.Gaming.Graphics.Version40 dstRGB,Pencil.Gaming.Graphics.Version40 srcAlpha,Pencil.Gaming.Graphics.Version40 dstAlpha);
            internal static BlendFuncSeparatei glBlendFuncSeparatei;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateiARB(UInt32 buf,Pencil.Gaming.Graphics.ArbDrawBuffersBlend srcRGB,Pencil.Gaming.Graphics.ArbDrawBuffersBlend dstRGB,Pencil.Gaming.Graphics.ArbDrawBuffersBlend srcAlpha,Pencil.Gaming.Graphics.ArbDrawBuffersBlend dstAlpha);
            internal static BlendFuncSeparateiARB glBlendFuncSeparateiARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateIndexedAMD(UInt32 buf,Pencil.Gaming.Graphics.AmdDrawBuffersBlend srcRGB,Pencil.Gaming.Graphics.AmdDrawBuffersBlend dstRGB,Pencil.Gaming.Graphics.AmdDrawBuffersBlend srcAlpha,Pencil.Gaming.Graphics.AmdDrawBuffersBlend dstAlpha);
            internal static BlendFuncSeparateIndexedAMD glBlendFuncSeparateIndexedAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlendFuncSeparateINGR(Pencil.Gaming.Graphics.All sfactorRGB,Pencil.Gaming.Graphics.All dfactorRGB,Pencil.Gaming.Graphics.All sfactorAlpha,Pencil.Gaming.Graphics.All dfactorAlpha);
            internal static BlendFuncSeparateINGR glBlendFuncSeparateINGR;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebuffer(Int32 srcX0,Int32 srcY0,Int32 srcX1,Int32 srcY1,Int32 dstX0,Int32 dstY0,Int32 dstX1,Int32 dstY1,Pencil.Gaming.Graphics.ClearBufferMask mask,Pencil.Gaming.Graphics.BlitFramebufferFilter filter);
            internal static BlitFramebuffer glBlitFramebuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BlitFramebufferEXT(Int32 srcX0,Int32 srcY0,Int32 srcX1,Int32 srcY1,Int32 dstX0,Int32 dstY0,Int32 dstX1,Int32 dstY1,Pencil.Gaming.Graphics.ClearBufferMask mask,Pencil.Gaming.Graphics.ExtFramebufferBlit filter);
            internal static BlitFramebufferEXT glBlitFramebufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferAddressRangeNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory pname,UInt32 index,UInt64 address,IntPtr length);
            internal static BufferAddressRangeNV glBufferAddressRangeNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferData(Pencil.Gaming.Graphics.BufferTarget target,IntPtr size,IntPtr data,Pencil.Gaming.Graphics.BufferUsageHint usage);
            internal static BufferData glBufferData;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferDataARB(Pencil.Gaming.Graphics.BufferTargetArb target,IntPtr size,IntPtr data,Pencil.Gaming.Graphics.BufferUsageArb usage);
            internal static BufferDataARB glBufferDataARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferParameteriAPPLE(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferParameterApple pname,Int32 param);
            internal static BufferParameteriAPPLE glBufferParameteriAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubData(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr size,IntPtr data);
            internal static BufferSubData glBufferSubData;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void BufferSubDataARB(Pencil.Gaming.Graphics.BufferTargetArb target,IntPtr offset,IntPtr size,IntPtr data);
            internal static BufferSubDataARB glBufferSubDataARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CallList(UInt32 list);
            internal static CallList glCallList;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CallLists(Int32 n,Pencil.Gaming.Graphics.ListNameType type,IntPtr lists);
            internal static CallLists glCallLists;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Pencil.Gaming.Graphics.FramebufferErrorCode CheckFramebufferStatus(Pencil.Gaming.Graphics.FramebufferTarget target);
            internal static CheckFramebufferStatus glCheckFramebufferStatus;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Pencil.Gaming.Graphics.FramebufferErrorCode CheckFramebufferStatusEXT(Pencil.Gaming.Graphics.FramebufferTarget target);
            internal static CheckFramebufferStatusEXT glCheckFramebufferStatusEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Pencil.Gaming.Graphics.ExtDirectStateAccess CheckNamedFramebufferStatusEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferTarget target);
            internal static CheckNamedFramebufferStatusEXT glCheckNamedFramebufferStatusEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClampColor(Pencil.Gaming.Graphics.ClampColorTarget target,Pencil.Gaming.Graphics.ClampColorMode clamp);
            internal static ClampColor glClampColor;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClampColorARB(Pencil.Gaming.Graphics.ArbColorBufferFloat target,Pencil.Gaming.Graphics.ArbColorBufferFloat clamp);
            internal static ClampColorARB glClampColorARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Clear(Pencil.Gaming.Graphics.ClearBufferMask mask);
            internal static Clear glClear;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearAccum(Single red,Single green,Single blue,Single alpha);
            internal static ClearAccum glClearAccum;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearBufferfi(Pencil.Gaming.Graphics.ClearBuffer buffer,Int32 drawbuffer,Single depth,Int32 stencil);
            internal static ClearBufferfi glClearBufferfi;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferfv(Pencil.Gaming.Graphics.ClearBuffer buffer,Int32 drawbuffer,Single* value);
            internal unsafe static ClearBufferfv glClearBufferfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferiv(Pencil.Gaming.Graphics.ClearBuffer buffer,Int32 drawbuffer,Int32* value);
            internal unsafe static ClearBufferiv glClearBufferiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClearBufferuiv(Pencil.Gaming.Graphics.ClearBuffer buffer,Int32 drawbuffer,UInt32* value);
            internal unsafe static ClearBufferuiv glClearBufferuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColor(Single red,Single green,Single blue,Single alpha);
            internal static ClearColor glClearColor;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorIiEXT(Int32 red,Int32 green,Int32 blue,Int32 alpha);
            internal static ClearColorIiEXT glClearColorIiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearColorIuiEXT(UInt32 red,UInt32 green,UInt32 blue,UInt32 alpha);
            internal static ClearColorIuiEXT glClearColorIuiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepth(Double depth);
            internal static ClearDepth glClearDepth;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthdNV(Double depth);
            internal static ClearDepthdNV glClearDepthdNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearDepthf(Single d);
            internal static ClearDepthf glClearDepthf;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearIndex(Single c);
            internal static ClearIndex glClearIndex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClearStencil(Int32 s);
            internal static ClearStencil glClearStencil;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTexture(Pencil.Gaming.Graphics.TextureUnit texture);
            internal static ClientActiveTexture glClientActiveTexture;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveTextureARB(Pencil.Gaming.Graphics.TextureUnit texture);
            internal static ClientActiveTextureARB glClientActiveTextureARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientActiveVertexStreamATI(Pencil.Gaming.Graphics.AtiVertexStreams stream);
            internal static ClientActiveVertexStreamATI glClientActiveVertexStreamATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ClientAttribDefaultEXT(Pencil.Gaming.Graphics.ClientAttribMask mask);
            internal static ClientAttribDefaultEXT glClientAttribDefaultEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Pencil.Gaming.Graphics.ArbSync ClientWaitSync(IntPtr sync,UInt32 flags,UInt64 timeout);
            internal static ClientWaitSync glClientWaitSync;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ClipPlane(Pencil.Gaming.Graphics.ClipPlaneName plane,Double* equation);
            internal unsafe static ClipPlane glClipPlane;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3b(SByte red,SByte green,SByte blue);
            internal static Color3b glColor3b;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3bv(SByte* v);
            internal unsafe static Color3bv glColor3bv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3d(Double red,Double green,Double blue);
            internal static Color3d glColor3d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3dv(Double* v);
            internal unsafe static Color3dv glColor3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3f(Single red,Single green,Single blue);
            internal static Color3f glColor3f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3fv(Single* v);
            internal unsafe static Color3fv glColor3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3fVertex3fSUN(Single r,Single g,Single b,Single x,Single y,Single z);
            internal static Color3fVertex3fSUN glColor3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3fVertex3fvSUN(Single* c,Single* v);
            internal unsafe static Color3fVertex3fvSUN glColor3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3i(Int32 red,Int32 green,Int32 blue);
            internal static Color3i glColor3i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3iv(Int32* v);
            internal unsafe static Color3iv glColor3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3s(Int16 red,Int16 green,Int16 blue);
            internal static Color3s glColor3s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3sv(Int16* v);
            internal unsafe static Color3sv glColor3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3ub(Byte red,Byte green,Byte blue);
            internal static Color3ub glColor3ub;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3ubv(Byte* v);
            internal unsafe static Color3ubv glColor3ubv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3ui(UInt32 red,UInt32 green,UInt32 blue);
            internal static Color3ui glColor3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3uiv(UInt32* v);
            internal unsafe static Color3uiv glColor3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color3us(UInt16 red,UInt16 green,UInt16 blue);
            internal static Color3us glColor3us;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color3usv(UInt16* v);
            internal unsafe static Color3usv glColor3usv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4b(SByte red,SByte green,SByte blue,SByte alpha);
            internal static Color4b glColor4b;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4bv(SByte* v);
            internal unsafe static Color4bv glColor4bv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4d(Double red,Double green,Double blue,Double alpha);
            internal static Color4d glColor4d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4dv(Double* v);
            internal unsafe static Color4dv glColor4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4f(Single red,Single green,Single blue,Single alpha);
            internal static Color4f glColor4f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4fNormal3fVertex3fSUN(Single r,Single g,Single b,Single a,Single nx,Single ny,Single nz,Single x,Single y,Single z);
            internal static Color4fNormal3fVertex3fSUN glColor4fNormal3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4fNormal3fVertex3fvSUN(Single* c,Single* n,Single* v);
            internal unsafe static Color4fNormal3fVertex3fvSUN glColor4fNormal3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4fv(Single* v);
            internal unsafe static Color4fv glColor4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4i(Int32 red,Int32 green,Int32 blue,Int32 alpha);
            internal static Color4i glColor4i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4iv(Int32* v);
            internal unsafe static Color4iv glColor4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4s(Int16 red,Int16 green,Int16 blue,Int16 alpha);
            internal static Color4s glColor4s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4sv(Int16* v);
            internal unsafe static Color4sv glColor4sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ub(Byte red,Byte green,Byte blue,Byte alpha);
            internal static Color4ub glColor4ub;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubv(Byte* v);
            internal unsafe static Color4ubv glColor4ubv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ubVertex2fSUN(Byte r,Byte g,Byte b,Byte a,Single x,Single y);
            internal static Color4ubVertex2fSUN glColor4ubVertex2fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubVertex2fvSUN(Byte* c,Single* v);
            internal unsafe static Color4ubVertex2fvSUN glColor4ubVertex2fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ubVertex3fSUN(Byte r,Byte g,Byte b,Byte a,Single x,Single y,Single z);
            internal static Color4ubVertex3fSUN glColor4ubVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4ubVertex3fvSUN(Byte* c,Single* v);
            internal unsafe static Color4ubVertex3fvSUN glColor4ubVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4ui(UInt32 red,UInt32 green,UInt32 blue,UInt32 alpha);
            internal static Color4ui glColor4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4uiv(UInt32* v);
            internal unsafe static Color4uiv glColor4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Color4us(UInt16 red,UInt16 green,UInt16 blue,UInt16 alpha);
            internal static Color4us glColor4us;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Color4usv(UInt16* v);
            internal unsafe static Color4usv glColor4usv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFormatNV(Int32 size,Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,Int32 stride);
            internal static ColorFormatNV glColorFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp1ATI(Pencil.Gaming.Graphics.AtiFragmentShader op,UInt32 dst,UInt32 dstMask,UInt32 dstMod,UInt32 arg1,UInt32 arg1Rep,UInt32 arg1Mod);
            internal static ColorFragmentOp1ATI glColorFragmentOp1ATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp2ATI(Pencil.Gaming.Graphics.AtiFragmentShader op,UInt32 dst,UInt32 dstMask,UInt32 dstMod,UInt32 arg1,UInt32 arg1Rep,UInt32 arg1Mod,UInt32 arg2,UInt32 arg2Rep,UInt32 arg2Mod);
            internal static ColorFragmentOp2ATI glColorFragmentOp2ATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorFragmentOp3ATI(Pencil.Gaming.Graphics.AtiFragmentShader op,UInt32 dst,UInt32 dstMask,UInt32 dstMod,UInt32 arg1,UInt32 arg1Rep,UInt32 arg1Mod,UInt32 arg2,UInt32 arg2Rep,UInt32 arg2Mod,UInt32 arg3,UInt32 arg3Rep,UInt32 arg3Mod);
            internal static ColorFragmentOp3ATI glColorFragmentOp3ATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMask(bool red,bool green,bool blue,bool alpha);
            internal static ColorMask glColorMask;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaski(UInt32 index,bool r,bool g,bool b,bool a);
            internal static ColorMaski glColorMaski;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaskIndexedEXT(UInt32 index,bool r,bool g,bool b,bool a);
            internal static ColorMaskIndexedEXT glColorMaskIndexedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorMaterial(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.ColorMaterialParameter mode);
            internal static ColorMaterial glColorMaterial;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 color);
            internal static ColorP3ui glColorP3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* color);
            internal unsafe static ColorP3uiv glColorP3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorP4ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 color);
            internal static ColorP4ui glColorP4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorP4uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* color);
            internal unsafe static ColorP4uiv glColorP4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointer(Int32 size,Pencil.Gaming.Graphics.ColorPointerType type,Int32 stride,IntPtr pointer);
            internal static ColorPointer glColorPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointerEXT(Int32 size,Pencil.Gaming.Graphics.ColorPointerType type,Int32 stride,Int32 count,IntPtr pointer);
            internal static ColorPointerEXT glColorPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointerListIBM(Int32 size,Pencil.Gaming.Graphics.ColorPointerType type,Int32 stride,IntPtr pointer,Int32 ptrstride);
            internal static ColorPointerListIBM glColorPointerListIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorPointervINTEL(Int32 size,Pencil.Gaming.Graphics.VertexPointerType type,IntPtr pointer);
            internal static ColorPointervINTEL glColorPointervINTEL;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorSubTable(Pencil.Gaming.Graphics.ColorTableTarget target,Int32 start,Int32 count,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr data);
            internal static ColorSubTable glColorSubTable;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorSubTableEXT(Pencil.Gaming.Graphics.ColorTableTarget target,Int32 start,Int32 count,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr data);
            internal static ColorSubTableEXT glColorSubTableEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTable(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr table);
            internal static ColorTable glColorTable;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTableEXT(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalFormat,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr table);
            internal static ColorTableEXT glColorTableEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfv(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.ColorTableParameterPName pname,Single* @params);
            internal unsafe static ColorTableParameterfv glColorTableParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterfvSGI(Pencil.Gaming.Graphics.SgiColorTable target,Pencil.Gaming.Graphics.SgiColorTable pname,Single* @params);
            internal unsafe static ColorTableParameterfvSGI glColorTableParameterfvSGI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameteriv(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.ColorTableParameterPName pname,Int32* @params);
            internal unsafe static ColorTableParameteriv glColorTableParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ColorTableParameterivSGI(Pencil.Gaming.Graphics.SgiColorTable target,Pencil.Gaming.Graphics.SgiColorTable pname,Int32* @params);
            internal unsafe static ColorTableParameterivSGI glColorTableParameterivSGI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ColorTableSGI(Pencil.Gaming.Graphics.SgiColorTable target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr table);
            internal static ColorTableSGI glColorTableSGI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerInputNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage,Pencil.Gaming.Graphics.NvRegisterCombiners portion,Pencil.Gaming.Graphics.NvRegisterCombiners variable,Pencil.Gaming.Graphics.NvRegisterCombiners input,Pencil.Gaming.Graphics.NvRegisterCombiners mapping,Pencil.Gaming.Graphics.NvRegisterCombiners componentUsage);
            internal static CombinerInputNV glCombinerInputNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerOutputNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage,Pencil.Gaming.Graphics.NvRegisterCombiners portion,Pencil.Gaming.Graphics.NvRegisterCombiners abOutput,Pencil.Gaming.Graphics.NvRegisterCombiners cdOutput,Pencil.Gaming.Graphics.NvRegisterCombiners sumOutput,Pencil.Gaming.Graphics.NvRegisterCombiners scale,Pencil.Gaming.Graphics.NvRegisterCombiners bias,bool abDotProduct,bool cdDotProduct,bool muxSum);
            internal static CombinerOutputNV glCombinerOutputNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerParameterfNV(Pencil.Gaming.Graphics.NvRegisterCombiners pname,Single param);
            internal static CombinerParameterfNV glCombinerParameterfNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners pname,Single* @params);
            internal unsafe static CombinerParameterfvNV glCombinerParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CombinerParameteriNV(Pencil.Gaming.Graphics.NvRegisterCombiners pname,Int32 param);
            internal static CombinerParameteriNV glCombinerParameteriNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerParameterivNV(Pencil.Gaming.Graphics.NvRegisterCombiners pname,Int32* @params);
            internal unsafe static CombinerParameterivNV glCombinerParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CombinerStageParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners2 stage,Pencil.Gaming.Graphics.NvRegisterCombiners2 pname,Single* @params);
            internal unsafe static CombinerStageParameterfvNV glCombinerStageParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShader(UInt32 shader);
            internal static CompileShader glCompileShader;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompileShaderARB(UInt32 shaderObj);
            internal static CompileShaderARB glCompileShaderARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CompileShaderIncludeARB(UInt32 shader,Int32 count,String[] path,Int32* length);
            internal unsafe static CompileShaderIncludeARB glCompileShaderIncludeARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 border,Int32 imageSize,IntPtr bits);
            internal static CompressedMultiTexImage1DEXT glCompressedMultiTexImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 height,Int32 border,Int32 imageSize,IntPtr bits);
            internal static CompressedMultiTexImage2DEXT glCompressedMultiTexImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Int32 imageSize,IntPtr bits);
            internal static CompressedMultiTexImage3DEXT glCompressedMultiTexImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexSubImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr bits);
            internal static CompressedMultiTexSubImage1DEXT glCompressedMultiTexSubImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexSubImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr bits);
            internal static CompressedMultiTexSubImage2DEXT glCompressedMultiTexSubImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedMultiTexSubImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr bits);
            internal static CompressedMultiTexSubImage3DEXT glCompressedMultiTexSubImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 border,Int32 imageSize,IntPtr data);
            internal static CompressedTexImage1D glCompressedTexImage1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage1DARB(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 border,Int32 imageSize,IntPtr data);
            internal static CompressedTexImage1DARB glCompressedTexImage1DARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 border,Int32 imageSize,IntPtr data);
            internal static CompressedTexImage2D glCompressedTexImage2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage2DARB(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 border,Int32 imageSize,IntPtr data);
            internal static CompressedTexImage2DARB glCompressedTexImage2DARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Int32 imageSize,IntPtr data);
            internal static CompressedTexImage3D glCompressedTexImage3D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexImage3DARB(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Int32 imageSize,IntPtr data);
            internal static CompressedTexImage3DARB glCompressedTexImage3DARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
            internal static CompressedTexSubImage1D glCompressedTexSubImage1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage1DARB(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
            internal static CompressedTexSubImage1DARB glCompressedTexSubImage1DARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
            internal static CompressedTexSubImage2D glCompressedTexSubImage2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage2DARB(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
            internal static CompressedTexSubImage2DARB glCompressedTexSubImage2DARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
            internal static CompressedTexSubImage3D glCompressedTexSubImage3D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTexSubImage3DARB(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr data);
            internal static CompressedTexSubImage3DARB glCompressedTexSubImage3DARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureImage1DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 border,Int32 imageSize,IntPtr bits);
            internal static CompressedTextureImage1DEXT glCompressedTextureImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureImage2DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 height,Int32 border,Int32 imageSize,IntPtr bits);
            internal static CompressedTextureImage2DEXT glCompressedTextureImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureImage3DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Int32 imageSize,IntPtr bits);
            internal static CompressedTextureImage3DEXT glCompressedTextureImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureSubImage1DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr bits);
            internal static CompressedTextureSubImage1DEXT glCompressedTextureSubImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureSubImage2DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr bits);
            internal static CompressedTextureSubImage2DEXT glCompressedTextureSubImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CompressedTextureSubImage3DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Int32 imageSize,IntPtr bits);
            internal static CompressedTextureSubImage3DEXT glCompressedTextureSubImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter1D(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr image);
            internal static ConvolutionFilter1D glConvolutionFilter1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter1DEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr image);
            internal static ConvolutionFilter1DEXT glConvolutionFilter1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter2D(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr image);
            internal static ConvolutionFilter2D glConvolutionFilter2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionFilter2DEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr image);
            internal static ConvolutionFilter2DEXT glConvolutionFilter2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterf(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.ConvolutionParameter pname,Single @params);
            internal static ConvolutionParameterf glConvolutionParameterf;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameterfEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.ExtConvolution pname,Single @params);
            internal static ConvolutionParameterfEXT glConvolutionParameterfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfv(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.ConvolutionParameter pname,Single* @params);
            internal unsafe static ConvolutionParameterfv glConvolutionParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterfvEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.ExtConvolution pname,Single* @params);
            internal unsafe static ConvolutionParameterfvEXT glConvolutionParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteri(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.ConvolutionParameter pname,Int32 @params);
            internal static ConvolutionParameteri glConvolutionParameteri;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ConvolutionParameteriEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.ExtConvolution pname,Int32 @params);
            internal static ConvolutionParameteriEXT glConvolutionParameteriEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameteriv(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.ConvolutionParameter pname,Int32* @params);
            internal unsafe static ConvolutionParameteriv glConvolutionParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ConvolutionParameterivEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.ExtConvolution pname,Int32* @params);
            internal unsafe static ConvolutionParameterivEXT glConvolutionParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyBufferSubData(Pencil.Gaming.Graphics.BufferTarget readTarget,Pencil.Gaming.Graphics.BufferTarget writeTarget,IntPtr readOffset,IntPtr writeOffset,IntPtr size);
            internal static CopyBufferSubData glCopyBufferSubData;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTable(Pencil.Gaming.Graphics.ColorTableTarget target,Int32 start,Int32 x,Int32 y,Int32 width);
            internal static CopyColorSubTable glCopyColorSubTable;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorSubTableEXT(Pencil.Gaming.Graphics.ColorTableTarget target,Int32 start,Int32 x,Int32 y,Int32 width);
            internal static CopyColorSubTableEXT glCopyColorSubTableEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTable(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width);
            internal static CopyColorTable glCopyColorTable;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyColorTableSGI(Pencil.Gaming.Graphics.SgiColorTable target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width);
            internal static CopyColorTableSGI glCopyColorTableSGI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1D(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width);
            internal static CopyConvolutionFilter1D glCopyConvolutionFilter1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter1DEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width);
            internal static CopyConvolutionFilter1DEXT glCopyConvolutionFilter1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2D(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyConvolutionFilter2D glCopyConvolutionFilter2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyConvolutionFilter2DEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyConvolutionFilter2DEXT glCopyConvolutionFilter2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyImageSubDataNV(UInt32 srcName,Pencil.Gaming.Graphics.NvCopyImage srcTarget,Int32 srcLevel,Int32 srcX,Int32 srcY,Int32 srcZ,UInt32 dstName,Pencil.Gaming.Graphics.NvCopyImage dstTarget,Int32 dstLevel,Int32 dstX,Int32 dstY,Int32 dstZ,Int32 width,Int32 height,Int32 depth);
            internal static CopyImageSubDataNV glCopyImageSubDataNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 x,Int32 y,Int32 width,Int32 border);
            internal static CopyMultiTexImage1DEXT glCopyMultiTexImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 x,Int32 y,Int32 width,Int32 height,Int32 border);
            internal static CopyMultiTexImage2DEXT glCopyMultiTexImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexSubImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 x,Int32 y,Int32 width);
            internal static CopyMultiTexSubImage1DEXT glCopyMultiTexSubImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexSubImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyMultiTexSubImage2DEXT glCopyMultiTexSubImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyMultiTexSubImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyMultiTexSubImage3DEXT glCopyMultiTexSubImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyPixels(Int32 x,Int32 y,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelCopyType type);
            internal static CopyPixels glCopyPixels;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 border);
            internal static CopyTexImage1D glCopyTexImage1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage1DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 border);
            internal static CopyTexImage1DEXT glCopyTexImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 height,Int32 border);
            internal static CopyTexImage2D glCopyTexImage2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexImage2DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 x,Int32 y,Int32 width,Int32 height,Int32 border);
            internal static CopyTexImage2DEXT glCopyTexImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 x,Int32 y,Int32 width);
            internal static CopyTexSubImage1D glCopyTexSubImage1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage1DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 x,Int32 y,Int32 width);
            internal static CopyTexSubImage1DEXT glCopyTexSubImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyTexSubImage2D glCopyTexSubImage2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage2DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyTexSubImage2DEXT glCopyTexSubImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyTexSubImage3D glCopyTexSubImage3D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTexSubImage3DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyTexSubImage3DEXT glCopyTexSubImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureImage1DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 x,Int32 y,Int32 width,Int32 border);
            internal static CopyTextureImage1DEXT glCopyTextureImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureImage2DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 x,Int32 y,Int32 width,Int32 height,Int32 border);
            internal static CopyTextureImage2DEXT glCopyTextureImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureSubImage1DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 x,Int32 y,Int32 width);
            internal static CopyTextureSubImage1DEXT glCopyTextureSubImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureSubImage2DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyTextureSubImage2DEXT glCopyTextureSubImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CopyTextureSubImage3DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 x,Int32 y,Int32 width,Int32 height);
            internal static CopyTextureSubImage3DEXT glCopyTextureSubImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgram();
            internal static CreateProgram glCreateProgram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateProgramObjectARB();
            internal static CreateProgramObjectARB glCreateProgramObjectARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShader(Pencil.Gaming.Graphics.ShaderType type);
            internal static CreateShader glCreateShader;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderObjectARB(Pencil.Gaming.Graphics.ArbShaderObjects shaderType);
            internal static CreateShaderObjectARB glCreateShaderObjectARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderProgramEXT(Pencil.Gaming.Graphics.ExtSeparateShaderObjects type,String @string);
            internal static CreateShaderProgramEXT glCreateShaderProgramEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 CreateShaderProgramv(Pencil.Gaming.Graphics.ShaderType type,Int32 count,String[] strings);
            internal static CreateShaderProgramv glCreateShaderProgramv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr CreateSyncFromCLeventARB(IntPtr context,IntPtr @event,UInt32 flags);
            internal static CreateSyncFromCLeventARB glCreateSyncFromCLeventARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CullFace(Pencil.Gaming.Graphics.CullFaceMode mode);
            internal static CullFace glCullFace;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CullParameterdvEXT(Pencil.Gaming.Graphics.ExtCullVertex pname,[OutAttribute] Double* @params);
            internal unsafe static CullParameterdvEXT glCullParameterdvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void CullParameterfvEXT(Pencil.Gaming.Graphics.ExtCullVertex pname,[OutAttribute] Single* @params);
            internal unsafe static CullParameterfvEXT glCullParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void CurrentPaletteMatrixARB(Int32 index);
            internal static CurrentPaletteMatrixARB glCurrentPaletteMatrixARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallbackAMD(DebugProcAmd callback,[OutAttribute] IntPtr userParam);
            internal static DebugMessageCallbackAMD glDebugMessageCallbackAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageCallbackARB(DebugProcArb callback,IntPtr userParam);
            internal static DebugMessageCallbackARB glDebugMessageCallbackARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageControlARB(Pencil.Gaming.Graphics.ArbDebugOutput source,Pencil.Gaming.Graphics.ArbDebugOutput type,Pencil.Gaming.Graphics.ArbDebugOutput severity,Int32 count,UInt32* ids,bool enabled);
            internal unsafe static DebugMessageControlARB glDebugMessageControlARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DebugMessageEnableAMD(Pencil.Gaming.Graphics.AmdDebugOutput category,Pencil.Gaming.Graphics.AmdDebugOutput severity,Int32 count,UInt32* ids,bool enabled);
            internal unsafe static DebugMessageEnableAMD glDebugMessageEnableAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsertAMD(Pencil.Gaming.Graphics.AmdDebugOutput category,Pencil.Gaming.Graphics.AmdDebugOutput severity,UInt32 id,Int32 length,String buf);
            internal static DebugMessageInsertAMD glDebugMessageInsertAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DebugMessageInsertARB(Pencil.Gaming.Graphics.ArbDebugOutput source,Pencil.Gaming.Graphics.ArbDebugOutput type,UInt32 id,Pencil.Gaming.Graphics.ArbDebugOutput severity,Int32 length,String buf);
            internal static DebugMessageInsertARB glDebugMessageInsertARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeformationMap3dSGIX(Pencil.Gaming.Graphics.SgixPolynomialFfd target,Double u1,Double u2,Int32 ustride,Int32 uorder,Double v1,Double v2,Int32 vstride,Int32 vorder,Double w1,Double w2,Int32 wstride,Int32 worder,Double* points);
            internal unsafe static DeformationMap3dSGIX glDeformationMap3dSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeformationMap3fSGIX(Pencil.Gaming.Graphics.SgixPolynomialFfd target,Single u1,Single u2,Int32 ustride,Int32 uorder,Single v1,Single v2,Int32 vstride,Int32 vorder,Single w1,Single w2,Int32 wstride,Int32 worder,Single* points);
            internal unsafe static DeformationMap3fSGIX glDeformationMap3fSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeformSGIX(UInt32 mask);
            internal static DeformSGIX glDeformSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteAsyncMarkersSGIX(UInt32 marker,Int32 range);
            internal static DeleteAsyncMarkersSGIX glDeleteAsyncMarkersSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffers(Int32 n,UInt32* buffers);
            internal unsafe static DeleteBuffers glDeleteBuffers;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteBuffersARB(Int32 n,UInt32* buffers);
            internal unsafe static DeleteBuffersARB glDeleteBuffersARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesAPPLE(Int32 n,UInt32* fences);
            internal unsafe static DeleteFencesAPPLE glDeleteFencesAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFencesNV(Int32 n,UInt32* fences);
            internal unsafe static DeleteFencesNV glDeleteFencesNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteFragmentShaderATI(UInt32 id);
            internal static DeleteFragmentShaderATI glDeleteFragmentShaderATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffers(Int32 n,UInt32* framebuffers);
            internal unsafe static DeleteFramebuffers glDeleteFramebuffers;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteFramebuffersEXT(Int32 n,UInt32* framebuffers);
            internal unsafe static DeleteFramebuffersEXT glDeleteFramebuffersEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteLists(UInt32 list,Int32 range);
            internal static DeleteLists glDeleteLists;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteNamedStringARB(Int32 namelen,String name);
            internal static DeleteNamedStringARB glDeleteNamedStringARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteNamesAMD(Pencil.Gaming.Graphics.AmdNameGenDelete identifier,UInt32 num,UInt32* names);
            internal unsafe static DeleteNamesAMD glDeleteNamesAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteObjectARB(UInt32 obj);
            internal static DeleteObjectARB glDeleteObjectARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteOcclusionQueriesNV(Int32 n,UInt32* ids);
            internal unsafe static DeleteOcclusionQueriesNV glDeleteOcclusionQueriesNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeletePerfMonitorsAMD(Int32 n,[OutAttribute] UInt32* monitors);
            internal unsafe static DeletePerfMonitorsAMD glDeletePerfMonitorsAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteProgram(UInt32 program);
            internal static DeleteProgram glDeleteProgram;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramPipelines(Int32 n,UInt32* pipelines);
            internal unsafe static DeleteProgramPipelines glDeleteProgramPipelines;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramsARB(Int32 n,UInt32* programs);
            internal unsafe static DeleteProgramsARB glDeleteProgramsARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteProgramsNV(Int32 n,UInt32* programs);
            internal unsafe static DeleteProgramsNV glDeleteProgramsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueries(Int32 n,UInt32* ids);
            internal unsafe static DeleteQueries glDeleteQueries;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteQueriesARB(Int32 n,UInt32* ids);
            internal unsafe static DeleteQueriesARB glDeleteQueriesARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffers(Int32 n,UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffers glDeleteRenderbuffers;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteRenderbuffersEXT(Int32 n,UInt32* renderbuffers);
            internal unsafe static DeleteRenderbuffersEXT glDeleteRenderbuffersEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteSamplers(Int32 count,UInt32* samplers);
            internal unsafe static DeleteSamplers glDeleteSamplers;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteShader(UInt32 shader);
            internal static DeleteShader glDeleteShader;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteSync(IntPtr sync);
            internal static DeleteSync glDeleteSync;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTextures(Int32 n,UInt32* textures);
            internal unsafe static DeleteTextures glDeleteTextures;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTexturesEXT(Int32 n,UInt32* textures);
            internal unsafe static DeleteTexturesEXT glDeleteTexturesEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTransformFeedbacks(Int32 n,UInt32* ids);
            internal unsafe static DeleteTransformFeedbacks glDeleteTransformFeedbacks;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteTransformFeedbacksNV(Int32 n,UInt32* ids);
            internal unsafe static DeleteTransformFeedbacksNV glDeleteTransformFeedbacksNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteVertexArrays(Int32 n,UInt32* arrays);
            internal unsafe static DeleteVertexArrays glDeleteVertexArrays;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DeleteVertexArraysAPPLE(Int32 n,UInt32* arrays);
            internal unsafe static DeleteVertexArraysAPPLE glDeleteVertexArraysAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DeleteVertexShaderEXT(UInt32 id);
            internal static DeleteVertexShaderEXT glDeleteVertexShaderEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthBoundsdNV(Double zmin,Double zmax);
            internal static DepthBoundsdNV glDepthBoundsdNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthBoundsEXT(Double zmin,Double zmax);
            internal static DepthBoundsEXT glDepthBoundsEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthFunc(Pencil.Gaming.Graphics.DepthFunction func);
            internal static DepthFunc glDepthFunc;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthMask(bool flag);
            internal static DepthMask glDepthMask;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRange(Double near,Double far);
            internal static DepthRange glDepthRange;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DepthRangeArrayv(UInt32 first,Int32 count,Double* v);
            internal unsafe static DepthRangeArrayv glDepthRangeArrayv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangedNV(Double zNear,Double zFar);
            internal static DepthRangedNV glDepthRangedNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangef(Single n,Single f);
            internal static DepthRangef glDepthRangef;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DepthRangeIndexed(UInt32 index,Double n,Double f);
            internal static DepthRangeIndexed glDepthRangeIndexed;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachObjectARB(UInt32 containerObj,UInt32 attachedObj);
            internal static DetachObjectARB glDetachObjectARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DetachShader(UInt32 program,UInt32 shader);
            internal static DetachShader glDetachShader;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DetailTexFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target,Int32 n,Single* points);
            internal unsafe static DetailTexFuncSGIS glDetailTexFuncSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Disable(Pencil.Gaming.Graphics.EnableCap cap);
            internal static Disable glDisable;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableClientState(Pencil.Gaming.Graphics.ArrayCap array);
            internal static DisableClientState glDisableClientState;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableClientStateIndexedEXT(Pencil.Gaming.Graphics.EnableCap array,UInt32 index);
            internal static DisableClientStateIndexedEXT glDisableClientStateIndexedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Disablei(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
            internal static Disablei glDisablei;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableIndexedEXT(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
            internal static DisableIndexedEXT glDisableIndexedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVariantClientStateEXT(UInt32 id);
            internal static DisableVariantClientStateEXT glDisableVariantClientStateEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribAPPLE(UInt32 index,Pencil.Gaming.Graphics.AppleVertexProgramEvaluators pname);
            internal static DisableVertexAttribAPPLE glDisableVertexAttribAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArray(UInt32 index);
            internal static DisableVertexAttribArray glDisableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DisableVertexAttribArrayARB(UInt32 index);
            internal static DisableVertexAttribArrayARB glDisableVertexAttribArrayARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArrays(Pencil.Gaming.Graphics.BeginMode mode,Int32 first,Int32 count);
            internal static DrawArrays glDrawArrays;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysEXT(Pencil.Gaming.Graphics.BeginMode mode,Int32 first,Int32 count);
            internal static DrawArraysEXT glDrawArraysEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysIndirect(Pencil.Gaming.Graphics.ArbDrawIndirect mode,IntPtr indirect);
            internal static DrawArraysIndirect glDrawArraysIndirect;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstanced(Pencil.Gaming.Graphics.BeginMode mode,Int32 first,Int32 count,Int32 primcount);
            internal static DrawArraysInstanced glDrawArraysInstanced;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedARB(Pencil.Gaming.Graphics.BeginMode mode,Int32 first,Int32 count,Int32 primcount);
            internal static DrawArraysInstancedARB glDrawArraysInstancedARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawArraysInstancedEXT(Pencil.Gaming.Graphics.BeginMode mode,Int32 start,Int32 count,Int32 primcount);
            internal static DrawArraysInstancedEXT glDrawArraysInstancedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawBuffer(Pencil.Gaming.Graphics.DrawBufferMode mode);
            internal static DrawBuffer glDrawBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffers(Int32 n,Pencil.Gaming.Graphics.DrawBuffersEnum* bufs);
            internal unsafe static DrawBuffers glDrawBuffers;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersARB(Int32 n,Pencil.Gaming.Graphics.ArbDrawBuffers* bufs);
            internal unsafe static DrawBuffersARB glDrawBuffersARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void DrawBuffersATI(Int32 n,Pencil.Gaming.Graphics.AtiDrawBuffers* bufs);
            internal unsafe static DrawBuffersATI glDrawBuffersATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementArrayAPPLE(Pencil.Gaming.Graphics.BeginMode mode,Int32 first,Int32 count);
            internal static DrawElementArrayAPPLE glDrawElementArrayAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementArrayATI(Pencil.Gaming.Graphics.BeginMode mode,Int32 count);
            internal static DrawElementArrayATI glDrawElementArrayATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElements(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices);
            internal static DrawElements glDrawElements;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 basevertex);
            internal static DrawElementsBaseVertex glDrawElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsIndirect(Pencil.Gaming.Graphics.ArbDrawIndirect mode,Pencil.Gaming.Graphics.ArbDrawIndirect type,IntPtr indirect);
            internal static DrawElementsIndirect glDrawElementsIndirect;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstanced(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount);
            internal static DrawElementsInstanced glDrawElementsInstanced;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedARB(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount);
            internal static DrawElementsInstancedARB glDrawElementsInstancedARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedBaseVertex(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount,Int32 basevertex);
            internal static DrawElementsInstancedBaseVertex glDrawElementsInstancedBaseVertex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawElementsInstancedEXT(Pencil.Gaming.Graphics.BeginMode mode,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount);
            internal static DrawElementsInstancedEXT glDrawElementsInstancedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawMeshArraysSUN(Pencil.Gaming.Graphics.BeginMode mode,Int32 first,Int32 count,Int32 width);
            internal static DrawMeshArraysSUN glDrawMeshArraysSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawPixels(Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static DrawPixels glDrawPixels;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementArrayAPPLE(Pencil.Gaming.Graphics.BeginMode mode,UInt32 start,UInt32 end,Int32 first,Int32 count);
            internal static DrawRangeElementArrayAPPLE glDrawRangeElementArrayAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementArrayATI(Pencil.Gaming.Graphics.BeginMode mode,UInt32 start,UInt32 end,Int32 count);
            internal static DrawRangeElementArrayATI glDrawRangeElementArrayATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElements(Pencil.Gaming.Graphics.BeginMode mode,UInt32 start,UInt32 end,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices);
            internal static DrawRangeElements glDrawRangeElements;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode,UInt32 start,UInt32 end,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 basevertex);
            internal static DrawRangeElementsBaseVertex glDrawRangeElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawRangeElementsEXT(Pencil.Gaming.Graphics.BeginMode mode,UInt32 start,UInt32 end,Int32 count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices);
            internal static DrawRangeElementsEXT glDrawRangeElementsEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedback(Pencil.Gaming.Graphics.BeginMode mode,UInt32 id);
            internal static DrawTransformFeedback glDrawTransformFeedback;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedbackNV(Pencil.Gaming.Graphics.NvTransformFeedback2 mode,UInt32 id);
            internal static DrawTransformFeedbackNV glDrawTransformFeedbackNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void DrawTransformFeedbackStream(Pencil.Gaming.Graphics.BeginMode mode,UInt32 id,UInt32 stream);
            internal static DrawTransformFeedbackStream glDrawTransformFeedbackStream;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlag(bool flag);
            internal static EdgeFlag glEdgeFlag;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlagFormatNV(Int32 stride);
            internal static EdgeFlagFormatNV glEdgeFlagFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EdgeFlagPointer(Int32 stride,IntPtr pointer);
            internal static EdgeFlagPointer glEdgeFlagPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointerEXT(Int32 stride,Int32 count,bool* pointer);
            internal unsafe static EdgeFlagPointerEXT glEdgeFlagPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagPointerListIBM(Int32 stride,bool* pointer,Int32 ptrstride);
            internal unsafe static EdgeFlagPointerListIBM glEdgeFlagPointerListIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EdgeFlagv(bool* flag);
            internal unsafe static EdgeFlagv glEdgeFlagv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ElementPointerAPPLE(Pencil.Gaming.Graphics.AppleElementArray type,IntPtr pointer);
            internal static ElementPointerAPPLE glElementPointerAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ElementPointerATI(Pencil.Gaming.Graphics.AtiElementArray type,IntPtr pointer);
            internal static ElementPointerATI glElementPointerATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Enable(Pencil.Gaming.Graphics.EnableCap cap);
            internal static Enable glEnable;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableClientState(Pencil.Gaming.Graphics.ArrayCap array);
            internal static EnableClientState glEnableClientState;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableClientStateIndexedEXT(Pencil.Gaming.Graphics.EnableCap array,UInt32 index);
            internal static EnableClientStateIndexedEXT glEnableClientStateIndexedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Enablei(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
            internal static Enablei glEnablei;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableIndexedEXT(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
            internal static EnableIndexedEXT glEnableIndexedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVariantClientStateEXT(UInt32 id);
            internal static EnableVariantClientStateEXT glEnableVariantClientStateEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribAPPLE(UInt32 index,Pencil.Gaming.Graphics.AppleVertexProgramEvaluators pname);
            internal static EnableVertexAttribAPPLE glEnableVertexAttribAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArray(UInt32 index);
            internal static EnableVertexAttribArray glEnableVertexAttribArray;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EnableVertexAttribArrayARB(UInt32 index);
            internal static EnableVertexAttribArrayARB glEnableVertexAttribArrayARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void End();
            internal static End glEnd;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndConditionalRender();
            internal static EndConditionalRender glEndConditionalRender;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndConditionalRenderNV();
            internal static EndConditionalRenderNV glEndConditionalRenderNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndFragmentShaderATI();
            internal static EndFragmentShaderATI glEndFragmentShaderATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndList();
            internal static EndList glEndList;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndOcclusionQueryNV();
            internal static EndOcclusionQueryNV glEndOcclusionQueryNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndPerfMonitorAMD(UInt32 monitor);
            internal static EndPerfMonitorAMD glEndPerfMonitorAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQuery(Pencil.Gaming.Graphics.QueryTarget target);
            internal static EndQuery glEndQuery;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryARB(Pencil.Gaming.Graphics.ArbOcclusionQuery target);
            internal static EndQueryARB glEndQueryARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndQueryIndexed(Pencil.Gaming.Graphics.QueryTarget target,UInt32 index);
            internal static EndQueryIndexed glEndQueryIndexed;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedback();
            internal static EndTransformFeedback glEndTransformFeedback;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedbackEXT();
            internal static EndTransformFeedbackEXT glEndTransformFeedbackEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndTransformFeedbackNV();
            internal static EndTransformFeedbackNV glEndTransformFeedbackNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndVertexShaderEXT();
            internal static EndVertexShaderEXT glEndVertexShaderEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EndVideoCaptureNV(UInt32 video_capture_slot);
            internal static EndVideoCaptureNV glEndVideoCaptureNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1d(Double u);
            internal static EvalCoord1d glEvalCoord1d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1dv(Double* u);
            internal unsafe static EvalCoord1dv glEvalCoord1dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord1f(Single u);
            internal static EvalCoord1f glEvalCoord1f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord1fv(Single* u);
            internal unsafe static EvalCoord1fv glEvalCoord1fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2d(Double u,Double v);
            internal static EvalCoord2d glEvalCoord2d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2dv(Double* u);
            internal unsafe static EvalCoord2dv glEvalCoord2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalCoord2f(Single u,Single v);
            internal static EvalCoord2f glEvalCoord2f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void EvalCoord2fv(Single* u);
            internal unsafe static EvalCoord2fv glEvalCoord2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMapsNV(Pencil.Gaming.Graphics.NvEvaluators target,Pencil.Gaming.Graphics.NvEvaluators mode);
            internal static EvalMapsNV glEvalMapsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMesh1(Pencil.Gaming.Graphics.MeshMode1 mode,Int32 i1,Int32 i2);
            internal static EvalMesh1 glEvalMesh1;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalMesh2(Pencil.Gaming.Graphics.MeshMode2 mode,Int32 i1,Int32 i2,Int32 j1,Int32 j2);
            internal static EvalMesh2 glEvalMesh2;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalPoint1(Int32 i);
            internal static EvalPoint1 glEvalPoint1;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void EvalPoint2(Int32 i,Int32 j);
            internal static EvalPoint2 glEvalPoint2;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ExecuteProgramNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 id,Single* @params);
            internal unsafe static ExecuteProgramNV glExecuteProgramNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ExtractComponentEXT(UInt32 res,UInt32 src,UInt32 num);
            internal static ExtractComponentEXT glExtractComponentEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FeedbackBuffer(Int32 size,Pencil.Gaming.Graphics.FeedbackType type,[OutAttribute] Single* buffer);
            internal unsafe static FeedbackBuffer glFeedbackBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr FenceSync(Pencil.Gaming.Graphics.ArbSync condition,UInt32 flags);
            internal static FenceSync glFenceSync;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FinalCombinerInputNV(Pencil.Gaming.Graphics.NvRegisterCombiners variable,Pencil.Gaming.Graphics.NvRegisterCombiners input,Pencil.Gaming.Graphics.NvRegisterCombiners mapping,Pencil.Gaming.Graphics.NvRegisterCombiners componentUsage);
            internal static FinalCombinerInputNV glFinalCombinerInputNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Finish();
            internal static Finish glFinish;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 FinishAsyncSGIX([OutAttribute] UInt32* markerp);
            internal unsafe static FinishAsyncSGIX glFinishAsyncSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceAPPLE(UInt32 fence);
            internal static FinishFenceAPPLE glFinishFenceAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishFenceNV(UInt32 fence);
            internal static FinishFenceNV glFinishFenceNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishObjectAPPLE(Pencil.Gaming.Graphics.AppleFence @object,Int32 name);
            internal static FinishObjectAPPLE glFinishObjectAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FinishTextureSUNX();
            internal static FinishTextureSUNX glFinishTextureSUNX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Flush();
            internal static Flush glFlush;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRange(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr length);
            internal static FlushMappedBufferRange glFlushMappedBufferRange;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedBufferRangeAPPLE(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr size);
            internal static FlushMappedBufferRangeAPPLE glFlushMappedBufferRangeAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushMappedNamedBufferRangeEXT(UInt32 buffer,IntPtr offset,IntPtr length);
            internal static FlushMappedNamedBufferRangeEXT glFlushMappedNamedBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushPixelDataRangeNV(Pencil.Gaming.Graphics.NvPixelDataRange target);
            internal static FlushPixelDataRangeNV glFlushPixelDataRangeNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushRasterSGIX();
            internal static FlushRasterSGIX glFlushRasterSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushVertexArrayRangeAPPLE(Int32 length,[OutAttribute] IntPtr pointer);
            internal static FlushVertexArrayRangeAPPLE glFlushVertexArrayRangeAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FlushVertexArrayRangeNV();
            internal static FlushVertexArrayRangeNV glFlushVertexArrayRangeNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordd(Double coord);
            internal static FogCoordd glFogCoordd;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoorddEXT(Double coord);
            internal static FogCoorddEXT glFogCoorddEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoorddv(Double* coord);
            internal unsafe static FogCoorddv glFogCoorddv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoorddvEXT(Double* coord);
            internal unsafe static FogCoorddvEXT glFogCoorddvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordf(Single coord);
            internal static FogCoordf glFogCoordf;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordfEXT(Single coord);
            internal static FogCoordfEXT glFogCoordfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordFormatNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,Int32 stride);
            internal static FogCoordFormatNV glFogCoordFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordfv(Single* coord);
            internal unsafe static FogCoordfv glFogCoordfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogCoordfvEXT(Single* coord);
            internal unsafe static FogCoordfvEXT glFogCoordfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointer(Pencil.Gaming.Graphics.FogPointerType type,Int32 stride,IntPtr pointer);
            internal static FogCoordPointer glFogCoordPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointerEXT(Pencil.Gaming.Graphics.ExtFogCoord type,Int32 stride,IntPtr pointer);
            internal static FogCoordPointerEXT glFogCoordPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FogCoordPointerListIBM(Pencil.Gaming.Graphics.IbmVertexArrayLists type,Int32 stride,IntPtr pointer,Int32 ptrstride);
            internal static FogCoordPointerListIBM glFogCoordPointerListIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogf(Pencil.Gaming.Graphics.FogParameter pname,Single param);
            internal static Fogf glFogf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FogFuncSGIS(Int32 n,Single* points);
            internal unsafe static FogFuncSGIS glFogFuncSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogfv(Pencil.Gaming.Graphics.FogParameter pname,Single* @params);
            internal unsafe static Fogfv glFogfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Fogi(Pencil.Gaming.Graphics.FogParameter pname,Int32 param);
            internal static Fogi glFogi;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Fogiv(Pencil.Gaming.Graphics.FogParameter pname,Int32* @params);
            internal unsafe static Fogiv glFogiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentColorMaterialSGIX(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter mode);
            internal static FragmentColorMaterialSGIX glFragmentColorMaterialSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightfSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light,Pencil.Gaming.Graphics.SgixFragmentLighting pname,Single param);
            internal static FragmentLightfSGIX glFragmentLightfSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightfvSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light,Pencil.Gaming.Graphics.SgixFragmentLighting pname,Single* @params);
            internal unsafe static FragmentLightfvSGIX glFragmentLightfvSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightiSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light,Pencil.Gaming.Graphics.SgixFragmentLighting pname,Int32 param);
            internal static FragmentLightiSGIX glFragmentLightiSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightivSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light,Pencil.Gaming.Graphics.SgixFragmentLighting pname,Int32* @params);
            internal unsafe static FragmentLightivSGIX glFragmentLightivSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightModelfSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname,Single param);
            internal static FragmentLightModelfSGIX glFragmentLightModelfSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightModelfvSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname,Single* @params);
            internal unsafe static FragmentLightModelfvSGIX glFragmentLightModelfvSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentLightModeliSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname,Int32 param);
            internal static FragmentLightModeliSGIX glFragmentLightModeliSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentLightModelivSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname,Int32* @params);
            internal unsafe static FragmentLightModelivSGIX glFragmentLightModelivSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentMaterialfSGIX(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Single param);
            internal static FragmentMaterialfSGIX glFragmentMaterialfSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentMaterialfvSGIX(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Single* @params);
            internal unsafe static FragmentMaterialfvSGIX glFragmentMaterialfvSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FragmentMaterialiSGIX(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Int32 param);
            internal static FragmentMaterialiSGIX glFragmentMaterialiSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FragmentMaterialivSGIX(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Int32* @params);
            internal unsafe static FragmentMaterialivSGIX glFragmentMaterialivSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferDrawBufferEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.DrawBufferMode mode);
            internal static FramebufferDrawBufferEXT glFramebufferDrawBufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void FramebufferDrawBuffersEXT(UInt32 framebuffer,Int32 n,Pencil.Gaming.Graphics.DrawBufferMode* bufs);
            internal unsafe static FramebufferDrawBuffersEXT glFramebufferDrawBuffersEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferReadBufferEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.ReadBufferMode mode);
            internal static FramebufferReadBufferEXT glFramebufferReadBufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbuffer(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.RenderbufferTarget renderbuffertarget,UInt32 renderbuffer);
            internal static FramebufferRenderbuffer glFramebufferRenderbuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferRenderbufferEXT(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.RenderbufferTarget renderbuffertarget,UInt32 renderbuffer);
            internal static FramebufferRenderbufferEXT glFramebufferRenderbufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level);
            internal static FramebufferTexture glFramebufferTexture;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture1D(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level);
            internal static FramebufferTexture1D glFramebufferTexture1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture1DEXT(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level);
            internal static FramebufferTexture1DEXT glFramebufferTexture1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2D(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level);
            internal static FramebufferTexture2D glFramebufferTexture2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture2DEXT(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level);
            internal static FramebufferTexture2DEXT glFramebufferTexture2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture3D(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level,Int32 zoffset);
            internal static FramebufferTexture3D glFramebufferTexture3D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTexture3DEXT(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level,Int32 zoffset);
            internal static FramebufferTexture3DEXT glFramebufferTexture3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureARB(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level);
            internal static FramebufferTextureARB glFramebufferTextureARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureEXT(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level);
            internal static FramebufferTextureEXT glFramebufferTextureEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureFaceARB(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level,Pencil.Gaming.Graphics.TextureTarget face);
            internal static FramebufferTextureFaceARB glFramebufferTextureFaceARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureFaceEXT(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level,Pencil.Gaming.Graphics.TextureTarget face);
            internal static FramebufferTextureFaceEXT glFramebufferTextureFaceEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayer(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level,Int32 layer);
            internal static FramebufferTextureLayer glFramebufferTextureLayer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayerARB(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level,Int32 layer);
            internal static FramebufferTextureLayerARB glFramebufferTextureLayerARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FramebufferTextureLayerEXT(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level,Int32 layer);
            internal static FramebufferTextureLayerEXT glFramebufferTextureLayerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FrameTerminatorGREMEDY();
            internal static FrameTerminatorGREMEDY glFrameTerminatorGREMEDY;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FrameZoomSGIX(Int32 factor);
            internal static FrameZoomSGIX glFrameZoomSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FreeObjectBufferATI(UInt32 buffer);
            internal static FreeObjectBufferATI glFreeObjectBufferATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void FrontFace(Pencil.Gaming.Graphics.FrontFaceDirection mode);
            internal static FrontFace glFrontFace;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Frustum(Double left,Double right,Double bottom,Double top,Double zNear,Double zFar);
            internal static Frustum glFrustum;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenAsyncMarkersSGIX(Int32 range);
            internal static GenAsyncMarkersSGIX glGenAsyncMarkersSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffers(Int32 n,[OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffers glGenBuffers;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenBuffersARB(Int32 n,[OutAttribute] UInt32* buffers);
            internal unsafe static GenBuffersARB glGenBuffersARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmap(Pencil.Gaming.Graphics.GenerateMipmapTarget target);
            internal static GenerateMipmap glGenerateMipmap;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMipmapEXT(Pencil.Gaming.Graphics.GenerateMipmapTarget target);
            internal static GenerateMipmapEXT glGenerateMipmapEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateMultiTexMipmapEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target);
            internal static GenerateMultiTexMipmapEXT glGenerateMultiTexMipmapEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GenerateTextureMipmapEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target);
            internal static GenerateTextureMipmapEXT glGenerateTextureMipmapEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesAPPLE(Int32 n,[OutAttribute] UInt32* fences);
            internal unsafe static GenFencesAPPLE glGenFencesAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFencesNV(Int32 n,[OutAttribute] UInt32* fences);
            internal unsafe static GenFencesNV glGenFencesNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenFragmentShadersATI(UInt32 range);
            internal static GenFragmentShadersATI glGenFragmentShadersATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffers(Int32 n,[OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffers glGenFramebuffers;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenFramebuffersEXT(Int32 n,[OutAttribute] UInt32* framebuffers);
            internal unsafe static GenFramebuffersEXT glGenFramebuffersEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenLists(Int32 range);
            internal static GenLists glGenLists;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenNamesAMD(Pencil.Gaming.Graphics.AmdNameGenDelete identifier,UInt32 num,[OutAttribute] UInt32* names);
            internal unsafe static GenNamesAMD glGenNamesAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenOcclusionQueriesNV(Int32 n,[OutAttribute] UInt32* ids);
            internal unsafe static GenOcclusionQueriesNV glGenOcclusionQueriesNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenPerfMonitorsAMD(Int32 n,[OutAttribute] UInt32* monitors);
            internal unsafe static GenPerfMonitorsAMD glGenPerfMonitorsAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramPipelines(Int32 n,[OutAttribute] UInt32* pipelines);
            internal unsafe static GenProgramPipelines glGenProgramPipelines;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramsARB(Int32 n,[OutAttribute] UInt32* programs);
            internal unsafe static GenProgramsARB glGenProgramsARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenProgramsNV(Int32 n,[OutAttribute] UInt32* programs);
            internal unsafe static GenProgramsNV glGenProgramsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueries(Int32 n,[OutAttribute] UInt32* ids);
            internal unsafe static GenQueries glGenQueries;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenQueriesARB(Int32 n,[OutAttribute] UInt32* ids);
            internal unsafe static GenQueriesARB glGenQueriesARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffers(Int32 n,[OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffers glGenRenderbuffers;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenRenderbuffersEXT(Int32 n,[OutAttribute] UInt32* renderbuffers);
            internal unsafe static GenRenderbuffersEXT glGenRenderbuffersEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenSamplers(Int32 count,[OutAttribute] UInt32* samplers);
            internal unsafe static GenSamplers glGenSamplers;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenSymbolsEXT(Pencil.Gaming.Graphics.ExtVertexShader datatype,Pencil.Gaming.Graphics.ExtVertexShader storagetype,Pencil.Gaming.Graphics.ExtVertexShader range,UInt32 components);
            internal static GenSymbolsEXT glGenSymbolsEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTextures(Int32 n,[OutAttribute] UInt32* textures);
            internal unsafe static GenTextures glGenTextures;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTexturesEXT(Int32 n,[OutAttribute] UInt32* textures);
            internal unsafe static GenTexturesEXT glGenTexturesEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTransformFeedbacks(Int32 n,[OutAttribute] UInt32* ids);
            internal unsafe static GenTransformFeedbacks glGenTransformFeedbacks;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenTransformFeedbacksNV(Int32 n,[OutAttribute] UInt32* ids);
            internal unsafe static GenTransformFeedbacksNV glGenTransformFeedbacksNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArrays(Int32 n,[OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArrays glGenVertexArrays;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GenVertexArraysAPPLE(Int32 n,[OutAttribute] UInt32* arrays);
            internal unsafe static GenVertexArraysAPPLE glGenVertexArraysAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GenVertexShadersEXT(UInt32 range);
            internal static GenVertexShadersEXT glGenVertexShadersEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttrib(UInt32 program,UInt32 index,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ActiveAttribType* type,[OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttrib glGetActiveAttrib;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveAttribARB(UInt32 programObj,UInt32 index,Int32 maxLength,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ArbVertexShader* type,[OutAttribute] StringBuilder name);
            internal unsafe static GetActiveAttribARB glGetActiveAttribARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineName(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,UInt32 index,Int32 bufsize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineName glGetActiveSubroutineName;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineUniformiv(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,UInt32 index,Pencil.Gaming.Graphics.ActiveSubroutineUniformParameter pname,[OutAttribute] Int32* values);
            internal unsafe static GetActiveSubroutineUniformiv glGetActiveSubroutineUniformiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveSubroutineUniformName(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,UInt32 index,Int32 bufsize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder name);
            internal unsafe static GetActiveSubroutineUniformName glGetActiveSubroutineUniformName;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniform(UInt32 program,UInt32 index,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ActiveUniformType* type,[OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniform glGetActiveUniform;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformARB(UInt32 programObj,UInt32 index,Int32 maxLength,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ArbShaderObjects* type,[OutAttribute] StringBuilder name);
            internal unsafe static GetActiveUniformARB glGetActiveUniformARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformBlockiv(UInt32 program,UInt32 uniformBlockIndex,Pencil.Gaming.Graphics.ActiveUniformBlockParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformBlockiv glGetActiveUniformBlockiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformBlockName(UInt32 program,UInt32 uniformBlockIndex,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder uniformBlockName);
            internal unsafe static GetActiveUniformBlockName glGetActiveUniformBlockName;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformName(UInt32 program,UInt32 uniformIndex,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder uniformName);
            internal unsafe static GetActiveUniformName glGetActiveUniformName;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveUniformsiv(UInt32 program,Int32 uniformCount,UInt32* uniformIndices,Pencil.Gaming.Graphics.ActiveUniformParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetActiveUniformsiv glGetActiveUniformsiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetActiveVaryingNV(UInt32 program,UInt32 index,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.NvTransformFeedback* type,[OutAttribute] StringBuilder name);
            internal unsafe static GetActiveVaryingNV glGetActiveVaryingNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetArrayObjectfvATI(Pencil.Gaming.Graphics.EnableCap array,Pencil.Gaming.Graphics.AtiVertexArrayObject pname,[OutAttribute] Single* @params);
            internal unsafe static GetArrayObjectfvATI glGetArrayObjectfvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetArrayObjectivATI(Pencil.Gaming.Graphics.EnableCap array,Pencil.Gaming.Graphics.AtiVertexArrayObject pname,[OutAttribute] Int32* @params);
            internal unsafe static GetArrayObjectivATI glGetArrayObjectivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedObjectsARB(UInt32 containerObj,Int32 maxCount,[OutAttribute] Int32* count,[OutAttribute] UInt32* obj);
            internal unsafe static GetAttachedObjectsARB glGetAttachedObjectsARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetAttachedShaders(UInt32 program,Int32 maxCount,[OutAttribute] Int32* count,[OutAttribute] UInt32* obj);
            internal unsafe static GetAttachedShaders glGetAttachedShaders;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocation(UInt32 program,String name);
            internal static GetAttribLocation glGetAttribLocation;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetAttribLocationARB(UInt32 programObj,String name);
            internal static GetAttribLocationARB glGetAttribLocationARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleani_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] bool* data);
            internal unsafe static GetBooleani_v glGetBooleani_v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanIndexedvEXT(Pencil.Gaming.Graphics.ExtDrawBuffers2 target,UInt32 index,[OutAttribute] bool* data);
            internal unsafe static GetBooleanIndexedvEXT glGetBooleanIndexedvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBooleanv(Pencil.Gaming.Graphics.GetPName pname,[OutAttribute] bool* @params);
            internal unsafe static GetBooleanv glGetBooleanv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteri64v(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferParameterName pname,[OutAttribute] Int64* @params);
            internal unsafe static GetBufferParameteri64v glGetBufferParameteri64v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameteriv(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferParameterName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameteriv glGetBufferParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameterivARB(Pencil.Gaming.Graphics.ArbVertexBufferObject target,Pencil.Gaming.Graphics.BufferParameterNameArb pname,[OutAttribute] Int32* @params);
            internal unsafe static GetBufferParameterivARB glGetBufferParameterivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetBufferParameterui64vNV(Pencil.Gaming.Graphics.NvShaderBufferLoad target,Pencil.Gaming.Graphics.NvShaderBufferLoad pname,[OutAttribute] UInt64* @params);
            internal unsafe static GetBufferParameterui64vNV glGetBufferParameterui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointerv(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferPointer pname,[OutAttribute] IntPtr @params);
            internal static GetBufferPointerv glGetBufferPointerv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferPointervARB(Pencil.Gaming.Graphics.ArbVertexBufferObject target,Pencil.Gaming.Graphics.BufferPointerNameArb pname,[OutAttribute] IntPtr @params);
            internal static GetBufferPointervARB glGetBufferPointervARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferSubData(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr size,[OutAttribute] IntPtr data);
            internal static GetBufferSubData glGetBufferSubData;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetBufferSubDataARB(Pencil.Gaming.Graphics.BufferTargetArb target,IntPtr offset,IntPtr size,[OutAttribute] IntPtr data);
            internal static GetBufferSubDataARB glGetBufferSubDataARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetClipPlane(Pencil.Gaming.Graphics.ClipPlaneName plane,[OutAttribute] Double* equation);
            internal unsafe static GetClipPlane glGetClipPlane;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTable(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr table);
            internal static GetColorTable glGetColorTable;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTableEXT(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr data);
            internal static GetColorTableEXT glGetColorTableEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfv(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.GetColorTableParameterPName pname,[OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfv glGetColorTableParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfvEXT(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.GetColorTableParameterPName pname,[OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfvEXT glGetColorTableParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterfvSGI(Pencil.Gaming.Graphics.SgiColorTable target,Pencil.Gaming.Graphics.SgiColorTable pname,[OutAttribute] Single* @params);
            internal unsafe static GetColorTableParameterfvSGI glGetColorTableParameterfvSGI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameteriv(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.GetColorTableParameterPName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameteriv glGetColorTableParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterivEXT(Pencil.Gaming.Graphics.ColorTableTarget target,Pencil.Gaming.Graphics.GetColorTableParameterPName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameterivEXT glGetColorTableParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetColorTableParameterivSGI(Pencil.Gaming.Graphics.SgiColorTable target,Pencil.Gaming.Graphics.SgiColorTable pname,[OutAttribute] Int32* @params);
            internal unsafe static GetColorTableParameterivSGI glGetColorTableParameterivSGI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetColorTableSGI(Pencil.Gaming.Graphics.SgiColorTable target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr table);
            internal static GetColorTableSGI glGetColorTableSGI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerInputParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage,Pencil.Gaming.Graphics.NvRegisterCombiners portion,Pencil.Gaming.Graphics.NvRegisterCombiners variable,Pencil.Gaming.Graphics.NvRegisterCombiners pname,[OutAttribute] Single* @params);
            internal unsafe static GetCombinerInputParameterfvNV glGetCombinerInputParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerInputParameterivNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage,Pencil.Gaming.Graphics.NvRegisterCombiners portion,Pencil.Gaming.Graphics.NvRegisterCombiners variable,Pencil.Gaming.Graphics.NvRegisterCombiners pname,[OutAttribute] Int32* @params);
            internal unsafe static GetCombinerInputParameterivNV glGetCombinerInputParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerOutputParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage,Pencil.Gaming.Graphics.NvRegisterCombiners portion,Pencil.Gaming.Graphics.NvRegisterCombiners pname,[OutAttribute] Single* @params);
            internal unsafe static GetCombinerOutputParameterfvNV glGetCombinerOutputParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerOutputParameterivNV(Pencil.Gaming.Graphics.NvRegisterCombiners stage,Pencil.Gaming.Graphics.NvRegisterCombiners portion,Pencil.Gaming.Graphics.NvRegisterCombiners pname,[OutAttribute] Int32* @params);
            internal unsafe static GetCombinerOutputParameterivNV glGetCombinerOutputParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetCombinerStageParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners2 stage,Pencil.Gaming.Graphics.NvRegisterCombiners2 pname,[OutAttribute] Single* @params);
            internal unsafe static GetCombinerStageParameterfvNV glGetCombinerStageParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedMultiTexImageEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 lod,[OutAttribute] IntPtr img);
            internal static GetCompressedMultiTexImageEXT glGetCompressedMultiTexImageEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTexImage(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,[OutAttribute] IntPtr img);
            internal static GetCompressedTexImage glGetCompressedTexImage;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTexImageARB(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,[OutAttribute] IntPtr img);
            internal static GetCompressedTexImageARB glGetCompressedTexImageARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetCompressedTextureImageEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 lod,[OutAttribute] IntPtr img);
            internal static GetCompressedTextureImageEXT glGetCompressedTextureImageEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetConvolutionFilter(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr image);
            internal static GetConvolutionFilter glGetConvolutionFilter;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetConvolutionFilterEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr image);
            internal static GetConvolutionFilterEXT glGetConvolutionFilterEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfv(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.GetConvolutionParameterPName pname,[OutAttribute] Single* @params);
            internal unsafe static GetConvolutionParameterfv glGetConvolutionParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterfvEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.ExtConvolution pname,[OutAttribute] Single* @params);
            internal unsafe static GetConvolutionParameterfvEXT glGetConvolutionParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameteriv(Pencil.Gaming.Graphics.ConvolutionTarget target,Pencil.Gaming.Graphics.GetConvolutionParameterPName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetConvolutionParameteriv glGetConvolutionParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetConvolutionParameterivEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.ExtConvolution pname,[OutAttribute] Int32* @params);
            internal unsafe static GetConvolutionParameterivEXT glGetConvolutionParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLogAMD(UInt32 count,Int32 bufsize,[OutAttribute] Pencil.Gaming.Graphics.AmdDebugOutput* categories,[OutAttribute] UInt32* severities,[OutAttribute] UInt32* ids,[OutAttribute] Int32* lengths,[OutAttribute] StringBuilder message);
            internal unsafe static GetDebugMessageLogAMD glGetDebugMessageLogAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 GetDebugMessageLogARB(UInt32 count,Int32 bufsize,[OutAttribute] Pencil.Gaming.Graphics.ArbDebugOutput* sources,[OutAttribute] Pencil.Gaming.Graphics.ArbDebugOutput* types,[OutAttribute] UInt32* ids,[OutAttribute] Pencil.Gaming.Graphics.ArbDebugOutput* severities,[OutAttribute] Int32* lengths,[OutAttribute] StringBuilder messageLog);
            internal unsafe static GetDebugMessageLogARB glGetDebugMessageLogARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDetailTexFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target,[OutAttribute] Single* points);
            internal unsafe static GetDetailTexFuncSGIS glGetDetailTexFuncSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoublei_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Double* data);
            internal unsafe static GetDoublei_v glGetDoublei_v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoubleIndexedvEXT(Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,[OutAttribute] Double* data);
            internal unsafe static GetDoubleIndexedvEXT glGetDoubleIndexedvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetDoublev(Pencil.Gaming.Graphics.GetPName pname,[OutAttribute] Double* @params);
            internal unsafe static GetDoublev glGetDoublev;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Pencil.Gaming.Graphics.ErrorCode GetError();
            internal static GetError glGetError;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFenceivNV(UInt32 fence,Pencil.Gaming.Graphics.NvFence pname,[OutAttribute] Int32* @params);
            internal unsafe static GetFenceivNV glGetFenceivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFinalCombinerInputParameterfvNV(Pencil.Gaming.Graphics.NvRegisterCombiners variable,Pencil.Gaming.Graphics.NvRegisterCombiners pname,[OutAttribute] Single* @params);
            internal unsafe static GetFinalCombinerInputParameterfvNV glGetFinalCombinerInputParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFinalCombinerInputParameterivNV(Pencil.Gaming.Graphics.NvRegisterCombiners variable,Pencil.Gaming.Graphics.NvRegisterCombiners pname,[OutAttribute] Int32* @params);
            internal unsafe static GetFinalCombinerInputParameterivNV glGetFinalCombinerInputParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloati_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Single* data);
            internal unsafe static GetFloati_v glGetFloati_v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatIndexedvEXT(Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,[OutAttribute] Single* data);
            internal unsafe static GetFloatIndexedvEXT glGetFloatIndexedvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFloatv(Pencil.Gaming.Graphics.GetPName pname,[OutAttribute] Single* @params);
            internal unsafe static GetFloatv glGetFloatv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFogFuncSGIS([OutAttribute] Single* points);
            internal unsafe static GetFogFuncSGIS glGetFogFuncSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataIndex(UInt32 program,String name);
            internal static GetFragDataIndex glGetFragDataIndex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataLocation(UInt32 program,String name);
            internal static GetFragDataLocation glGetFragDataLocation;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetFragDataLocationEXT(UInt32 program,String name);
            internal static GetFragDataLocationEXT glGetFragDataLocationEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentLightfvSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light,Pencil.Gaming.Graphics.SgixFragmentLighting pname,[OutAttribute] Single* @params);
            internal unsafe static GetFragmentLightfvSGIX glGetFragmentLightfvSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentLightivSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting light,Pencil.Gaming.Graphics.SgixFragmentLighting pname,[OutAttribute] Int32* @params);
            internal unsafe static GetFragmentLightivSGIX glGetFragmentLightivSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentMaterialfvSGIX(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetFragmentMaterialfvSGIX glGetFragmentMaterialfvSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFragmentMaterialivSGIX(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetFragmentMaterialivSGIX glGetFragmentMaterialivSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameteriv(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.FramebufferParameterName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameteriv glGetFramebufferAttachmentParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferAttachmentParameterivEXT(Pencil.Gaming.Graphics.FramebufferTarget target,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.FramebufferParameterName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferAttachmentParameterivEXT glGetFramebufferAttachmentParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetFramebufferParameterivEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.ExtDirectStateAccess pname,[OutAttribute] Int32* @params);
            internal unsafe static GetFramebufferParameterivEXT glGetFramebufferParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Pencil.Gaming.Graphics.ArbRobustness GetGraphicsResetStatusARB();
            internal static GetGraphicsResetStatusARB glGetGraphicsResetStatusARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetHandleARB(Pencil.Gaming.Graphics.ArbShaderObjects pname);
            internal static GetHandleARB glGetHandleARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetHistogram(Pencil.Gaming.Graphics.HistogramTarget target,bool reset,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr values);
            internal static GetHistogram glGetHistogram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetHistogramEXT(Pencil.Gaming.Graphics.ExtHistogram target,bool reset,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr values);
            internal static GetHistogramEXT glGetHistogramEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfv(Pencil.Gaming.Graphics.HistogramTarget target,Pencil.Gaming.Graphics.GetHistogramParameterPName pname,[OutAttribute] Single* @params);
            internal unsafe static GetHistogramParameterfv glGetHistogramParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterfvEXT(Pencil.Gaming.Graphics.ExtHistogram target,Pencil.Gaming.Graphics.ExtHistogram pname,[OutAttribute] Single* @params);
            internal unsafe static GetHistogramParameterfvEXT glGetHistogramParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameteriv(Pencil.Gaming.Graphics.HistogramTarget target,Pencil.Gaming.Graphics.GetHistogramParameterPName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetHistogramParameteriv glGetHistogramParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetHistogramParameterivEXT(Pencil.Gaming.Graphics.ExtHistogram target,Pencil.Gaming.Graphics.ExtHistogram pname,[OutAttribute] Int32* @params);
            internal unsafe static GetHistogramParameterivEXT glGetHistogramParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetImageTransformParameterfvHP(Pencil.Gaming.Graphics.HpImageTransform target,Pencil.Gaming.Graphics.HpImageTransform pname,[OutAttribute] Single* @params);
            internal unsafe static GetImageTransformParameterfvHP glGetImageTransformParameterfvHP;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetImageTransformParameterivHP(Pencil.Gaming.Graphics.HpImageTransform target,Pencil.Gaming.Graphics.HpImageTransform pname,[OutAttribute] Int32* @params);
            internal unsafe static GetImageTransformParameterivHP glGetImageTransformParameterivHP;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInfoLogARB(UInt32 obj,Int32 maxLength,[OutAttribute] Int32* length,[OutAttribute] StringBuilder infoLog);
            internal unsafe static GetInfoLogARB glGetInfoLogARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetInstrumentsSGIX();
            internal static GetInstrumentsSGIX glGetInstrumentsSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64i_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Int64* data);
            internal unsafe static GetInteger64i_v glGetInteger64i_v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInteger64v(Pencil.Gaming.Graphics.ArbSync pname,[OutAttribute] Int64* @params);
            internal unsafe static GetInteger64v glGetInteger64v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegeri_v(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Int32* data);
            internal unsafe static GetIntegeri_v glGetIntegeri_v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerIndexedvEXT(Pencil.Gaming.Graphics.GetIndexedPName target,UInt32 index,[OutAttribute] Int32* data);
            internal unsafe static GetIntegerIndexedvEXT glGetIntegerIndexedvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerui64i_vNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory value,UInt32 index,[OutAttribute] UInt64* result);
            internal unsafe static GetIntegerui64i_vNV glGetIntegerui64i_vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerui64vNV(Pencil.Gaming.Graphics.NvShaderBufferLoad value,[OutAttribute] UInt64* result);
            internal unsafe static GetIntegerui64vNV glGetIntegerui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetIntegerv(Pencil.Gaming.Graphics.GetPName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetIntegerv glGetIntegerv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantBooleanvEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] bool* data);
            internal unsafe static GetInvariantBooleanvEXT glGetInvariantBooleanvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantFloatvEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] Single* data);
            internal unsafe static GetInvariantFloatvEXT glGetInvariantFloatvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetInvariantIntegervEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] Int32* data);
            internal unsafe static GetInvariantIntegervEXT glGetInvariantIntegervEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightfv(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetLightfv glGetLightfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLightiv(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetLightiv glGetLightiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetListParameterfvSGIX(UInt32 list,Pencil.Gaming.Graphics.ListParameterName pname,[OutAttribute] Single* @params);
            internal unsafe static GetListParameterfvSGIX glGetListParameterfvSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetListParameterivSGIX(UInt32 list,Pencil.Gaming.Graphics.ListParameterName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetListParameterivSGIX glGetListParameterivSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantBooleanvEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] bool* data);
            internal unsafe static GetLocalConstantBooleanvEXT glGetLocalConstantBooleanvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantFloatvEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] Single* data);
            internal unsafe static GetLocalConstantFloatvEXT glGetLocalConstantFloatvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetLocalConstantIntegervEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] Int32* data);
            internal unsafe static GetLocalConstantIntegervEXT glGetLocalConstantIntegervEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapAttribParameterfvNV(Pencil.Gaming.Graphics.NvEvaluators target,UInt32 index,Pencil.Gaming.Graphics.NvEvaluators pname,[OutAttribute] Single* @params);
            internal unsafe static GetMapAttribParameterfvNV glGetMapAttribParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapAttribParameterivNV(Pencil.Gaming.Graphics.NvEvaluators target,UInt32 index,Pencil.Gaming.Graphics.NvEvaluators pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMapAttribParameterivNV glGetMapAttribParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMapControlPointsNV(Pencil.Gaming.Graphics.NvEvaluators target,UInt32 index,Pencil.Gaming.Graphics.NvEvaluators type,Int32 ustride,Int32 vstride,bool packed,[OutAttribute] IntPtr points);
            internal static GetMapControlPointsNV glGetMapControlPointsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapdv(Pencil.Gaming.Graphics.MapTarget target,Pencil.Gaming.Graphics.GetMapQuery query,[OutAttribute] Double* v);
            internal unsafe static GetMapdv glGetMapdv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapfv(Pencil.Gaming.Graphics.MapTarget target,Pencil.Gaming.Graphics.GetMapQuery query,[OutAttribute] Single* v);
            internal unsafe static GetMapfv glGetMapfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapiv(Pencil.Gaming.Graphics.MapTarget target,Pencil.Gaming.Graphics.GetMapQuery query,[OutAttribute] Int32* v);
            internal unsafe static GetMapiv glGetMapiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapParameterfvNV(Pencil.Gaming.Graphics.NvEvaluators target,Pencil.Gaming.Graphics.NvEvaluators pname,[OutAttribute] Single* @params);
            internal unsafe static GetMapParameterfvNV glGetMapParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMapParameterivNV(Pencil.Gaming.Graphics.NvEvaluators target,Pencil.Gaming.Graphics.NvEvaluators pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMapParameterivNV glGetMapParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialfv(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetMaterialfv glGetMaterialfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMaterialiv(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMaterialiv glGetMaterialiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMinmax(Pencil.Gaming.Graphics.MinmaxTarget target,bool reset,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr values);
            internal static GetMinmax glGetMinmax;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMinmaxEXT(Pencil.Gaming.Graphics.ExtHistogram target,bool reset,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr values);
            internal static GetMinmaxEXT glGetMinmaxEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfv(Pencil.Gaming.Graphics.MinmaxTarget target,Pencil.Gaming.Graphics.GetMinmaxParameterPName pname,[OutAttribute] Single* @params);
            internal unsafe static GetMinmaxParameterfv glGetMinmaxParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterfvEXT(Pencil.Gaming.Graphics.ExtHistogram target,Pencil.Gaming.Graphics.ExtHistogram pname,[OutAttribute] Single* @params);
            internal unsafe static GetMinmaxParameterfvEXT glGetMinmaxParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameteriv(Pencil.Gaming.Graphics.MinmaxTarget target,Pencil.Gaming.Graphics.GetMinmaxParameterPName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMinmaxParameteriv glGetMinmaxParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMinmaxParameterivEXT(Pencil.Gaming.Graphics.ExtHistogram target,Pencil.Gaming.Graphics.ExtHistogram pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMinmaxParameterivEXT glGetMinmaxParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultisamplefv(Pencil.Gaming.Graphics.GetMultisamplePName pname,UInt32 index,[OutAttribute] Single* val);
            internal unsafe static GetMultisamplefv glGetMultisamplefv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultisamplefvNV(Pencil.Gaming.Graphics.NvExplicitMultisample pname,UInt32 index,[OutAttribute] Single* val);
            internal unsafe static GetMultisamplefvNV glGetMultisamplefvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexEnvfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetMultiTexEnvfvEXT glGetMultiTexEnvfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexEnvivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexEnvivEXT glGetMultiTexEnvivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexGendvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Double* @params);
            internal unsafe static GetMultiTexGendvEXT glGetMultiTexGendvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexGenfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetMultiTexGenfvEXT glGetMultiTexGenfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexGenivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexGenivEXT glGetMultiTexGenivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetMultiTexImageEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr pixels);
            internal static GetMultiTexImageEXT glGetMultiTexImageEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexLevelParameterfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetMultiTexLevelParameterfvEXT glGetMultiTexLevelParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexLevelParameterivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexLevelParameterivEXT glGetMultiTexLevelParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexParameterfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetMultiTexParameterfvEXT glGetMultiTexParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexParameterIivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexParameterIivEXT glGetMultiTexParameterIivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexParameterIuivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetMultiTexParameterIuivEXT glGetMultiTexParameterIuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetMultiTexParameterivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetMultiTexParameterivEXT glGetMultiTexParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedBufferParameterivEXT(UInt32 buffer,Pencil.Gaming.Graphics.ExtDirectStateAccess pname,[OutAttribute] Int32* @params);
            internal unsafe static GetNamedBufferParameterivEXT glGetNamedBufferParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedBufferParameterui64vNV(UInt32 buffer,Pencil.Gaming.Graphics.NvShaderBufferLoad pname,[OutAttribute] UInt64* @params);
            internal unsafe static GetNamedBufferParameterui64vNV glGetNamedBufferParameterui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetNamedBufferPointervEXT(UInt32 buffer,Pencil.Gaming.Graphics.ExtDirectStateAccess pname,[OutAttribute] IntPtr @params);
            internal static GetNamedBufferPointervEXT glGetNamedBufferPointervEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetNamedBufferSubDataEXT(UInt32 buffer,IntPtr offset,IntPtr size,[OutAttribute] IntPtr data);
            internal static GetNamedBufferSubDataEXT glGetNamedBufferSubDataEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedFramebufferAttachmentParameterivEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.ExtDirectStateAccess pname,[OutAttribute] Int32* @params);
            internal unsafe static GetNamedFramebufferAttachmentParameterivEXT glGetNamedFramebufferAttachmentParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramivEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,Pencil.Gaming.Graphics.ExtDirectStateAccess pname,[OutAttribute] Int32* @params);
            internal unsafe static GetNamedProgramivEXT glGetNamedProgramivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramLocalParameterdvEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,[OutAttribute] Double* @params);
            internal unsafe static GetNamedProgramLocalParameterdvEXT glGetNamedProgramLocalParameterdvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramLocalParameterfvEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,[OutAttribute] Single* @params);
            internal unsafe static GetNamedProgramLocalParameterfvEXT glGetNamedProgramLocalParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramLocalParameterIivEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,[OutAttribute] Int32* @params);
            internal unsafe static GetNamedProgramLocalParameterIivEXT glGetNamedProgramLocalParameterIivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedProgramLocalParameterIuivEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,[OutAttribute] UInt32* @params);
            internal unsafe static GetNamedProgramLocalParameterIuivEXT glGetNamedProgramLocalParameterIuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetNamedProgramStringEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,Pencil.Gaming.Graphics.ExtDirectStateAccess pname,[OutAttribute] IntPtr @string);
            internal static GetNamedProgramStringEXT glGetNamedProgramStringEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedRenderbufferParameterivEXT(UInt32 renderbuffer,Pencil.Gaming.Graphics.RenderbufferParameterName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetNamedRenderbufferParameterivEXT glGetNamedRenderbufferParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedStringARB(Int32 namelen,String name,Int32 bufSize,[OutAttribute] Int32* stringlen,[OutAttribute] StringBuilder @string);
            internal unsafe static GetNamedStringARB glGetNamedStringARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetNamedStringivARB(Int32 namelen,String name,Pencil.Gaming.Graphics.ArbShadingLanguageInclude pname,[OutAttribute] Int32* @params);
            internal unsafe static GetNamedStringivARB glGetNamedStringivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnColorTableARB(Pencil.Gaming.Graphics.ArbRobustness target,Pencil.Gaming.Graphics.ArbRobustness format,Pencil.Gaming.Graphics.ArbRobustness type,Int32 bufSize,[OutAttribute] IntPtr table);
            internal static GetnColorTableARB glGetnColorTableARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnCompressedTexImageARB(Pencil.Gaming.Graphics.ArbRobustness target,Int32 lod,Int32 bufSize,[OutAttribute] IntPtr img);
            internal static GetnCompressedTexImageARB glGetnCompressedTexImageARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnConvolutionFilterARB(Pencil.Gaming.Graphics.ArbRobustness target,Pencil.Gaming.Graphics.ArbRobustness format,Pencil.Gaming.Graphics.ArbRobustness type,Int32 bufSize,[OutAttribute] IntPtr image);
            internal static GetnConvolutionFilterARB glGetnConvolutionFilterARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnHistogramARB(Pencil.Gaming.Graphics.ArbRobustness target,bool reset,Pencil.Gaming.Graphics.ArbRobustness format,Pencil.Gaming.Graphics.ArbRobustness type,Int32 bufSize,[OutAttribute] IntPtr values);
            internal static GetnHistogramARB glGetnHistogramARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapdvARB(Pencil.Gaming.Graphics.ArbRobustness target,Pencil.Gaming.Graphics.ArbRobustness query,Int32 bufSize,[OutAttribute] Double* v);
            internal unsafe static GetnMapdvARB glGetnMapdvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapfvARB(Pencil.Gaming.Graphics.ArbRobustness target,Pencil.Gaming.Graphics.ArbRobustness query,Int32 bufSize,[OutAttribute] Single* v);
            internal unsafe static GetnMapfvARB glGetnMapfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnMapivARB(Pencil.Gaming.Graphics.ArbRobustness target,Pencil.Gaming.Graphics.ArbRobustness query,Int32 bufSize,[OutAttribute] Int32* v);
            internal unsafe static GetnMapivARB glGetnMapivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnMinmaxARB(Pencil.Gaming.Graphics.ArbRobustness target,bool reset,Pencil.Gaming.Graphics.ArbRobustness format,Pencil.Gaming.Graphics.ArbRobustness type,Int32 bufSize,[OutAttribute] IntPtr values);
            internal static GetnMinmaxARB glGetnMinmaxARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapfvARB(Pencil.Gaming.Graphics.ArbRobustness map,Int32 bufSize,[OutAttribute] Single* values);
            internal unsafe static GetnPixelMapfvARB glGetnPixelMapfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapuivARB(Pencil.Gaming.Graphics.ArbRobustness map,Int32 bufSize,[OutAttribute] UInt32* values);
            internal unsafe static GetnPixelMapuivARB glGetnPixelMapuivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPixelMapusvARB(Pencil.Gaming.Graphics.ArbRobustness map,Int32 bufSize,[OutAttribute] UInt16* values);
            internal unsafe static GetnPixelMapusvARB glGetnPixelMapusvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnPolygonStippleARB(Int32 bufSize,[OutAttribute] Byte* pattern);
            internal unsafe static GetnPolygonStippleARB glGetnPolygonStippleARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnSeparableFilterARB(Pencil.Gaming.Graphics.ArbRobustness target,Pencil.Gaming.Graphics.ArbRobustness format,Pencil.Gaming.Graphics.ArbRobustness type,Int32 rowBufSize,[OutAttribute] IntPtr row,Int32 columnBufSize,[OutAttribute] IntPtr column,[OutAttribute] IntPtr span);
            internal static GetnSeparableFilterARB glGetnSeparableFilterARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetnTexImageARB(Pencil.Gaming.Graphics.ArbRobustness target,Int32 level,Pencil.Gaming.Graphics.ArbRobustness format,Pencil.Gaming.Graphics.ArbRobustness type,Int32 bufSize,[OutAttribute] IntPtr img);
            internal static GetnTexImageARB glGetnTexImageARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformdvARB(UInt32 program,Int32 location,Int32 bufSize,[OutAttribute] Double* @params);
            internal unsafe static GetnUniformdvARB glGetnUniformdvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformfvARB(UInt32 program,Int32 location,Int32 bufSize,[OutAttribute] Single* @params);
            internal unsafe static GetnUniformfvARB glGetnUniformfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformivARB(UInt32 program,Int32 location,Int32 bufSize,[OutAttribute] Int32* @params);
            internal unsafe static GetnUniformivARB glGetnUniformivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetnUniformuivARB(UInt32 program,Int32 location,Int32 bufSize,[OutAttribute] UInt32* @params);
            internal unsafe static GetnUniformuivARB glGetnUniformuivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectBufferfvATI(UInt32 buffer,Pencil.Gaming.Graphics.AtiVertexArrayObject pname,[OutAttribute] Single* @params);
            internal unsafe static GetObjectBufferfvATI glGetObjectBufferfvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectBufferivATI(UInt32 buffer,Pencil.Gaming.Graphics.AtiVertexArrayObject pname,[OutAttribute] Int32* @params);
            internal unsafe static GetObjectBufferivATI glGetObjectBufferivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterfvARB(UInt32 obj,Pencil.Gaming.Graphics.ArbShaderObjects pname,[OutAttribute] Single* @params);
            internal unsafe static GetObjectParameterfvARB glGetObjectParameterfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterivAPPLE(Pencil.Gaming.Graphics.AppleObjectPurgeable objectType,UInt32 name,Pencil.Gaming.Graphics.AppleObjectPurgeable pname,[OutAttribute] Int32* @params);
            internal unsafe static GetObjectParameterivAPPLE glGetObjectParameterivAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetObjectParameterivARB(UInt32 obj,Pencil.Gaming.Graphics.ArbShaderObjects pname,[OutAttribute] Int32* @params);
            internal unsafe static GetObjectParameterivARB glGetObjectParameterivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetOcclusionQueryivNV(UInt32 id,Pencil.Gaming.Graphics.NvOcclusionQuery pname,[OutAttribute] Int32* @params);
            internal unsafe static GetOcclusionQueryivNV glGetOcclusionQueryivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetOcclusionQueryuivNV(UInt32 id,Pencil.Gaming.Graphics.NvOcclusionQuery pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetOcclusionQueryuivNV glGetOcclusionQueryuivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCounterDataAMD(UInt32 monitor,Pencil.Gaming.Graphics.AmdPerformanceMonitor pname,Int32 dataSize,[OutAttribute] UInt32* data,[OutAttribute] Int32* bytesWritten);
            internal unsafe static GetPerfMonitorCounterDataAMD glGetPerfMonitorCounterDataAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPerfMonitorCounterInfoAMD(UInt32 group,UInt32 counter,Pencil.Gaming.Graphics.AmdPerformanceMonitor pname,[OutAttribute] IntPtr data);
            internal static GetPerfMonitorCounterInfoAMD glGetPerfMonitorCounterInfoAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCountersAMD(UInt32 group,[OutAttribute] Int32* numCounters,[OutAttribute] Int32* maxActiveCounters,Int32 counterSize,[OutAttribute] UInt32* counters);
            internal unsafe static GetPerfMonitorCountersAMD glGetPerfMonitorCountersAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorCounterStringAMD(UInt32 group,UInt32 counter,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder counterString);
            internal unsafe static GetPerfMonitorCounterStringAMD glGetPerfMonitorCounterStringAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorGroupsAMD([OutAttribute] Int32* numGroups,Int32 groupsSize,[OutAttribute] UInt32* groups);
            internal unsafe static GetPerfMonitorGroupsAMD glGetPerfMonitorGroupsAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPerfMonitorGroupStringAMD(UInt32 group,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder groupString);
            internal unsafe static GetPerfMonitorGroupStringAMD glGetPerfMonitorGroupStringAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapfv(Pencil.Gaming.Graphics.PixelMap map,[OutAttribute] Single* values);
            internal unsafe static GetPixelMapfv glGetPixelMapfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapuiv(Pencil.Gaming.Graphics.PixelMap map,[OutAttribute] UInt32* values);
            internal unsafe static GetPixelMapuiv glGetPixelMapuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelMapusv(Pencil.Gaming.Graphics.PixelMap map,[OutAttribute] UInt16* values);
            internal unsafe static GetPixelMapusv glGetPixelMapusv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelTexGenParameterfvSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname,[OutAttribute] Single* @params);
            internal unsafe static GetPixelTexGenParameterfvSGIS glGetPixelTexGenParameterfvSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPixelTexGenParameterivSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname,[OutAttribute] Int32* @params);
            internal unsafe static GetPixelTexGenParameterivSGIS glGetPixelTexGenParameterivSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerIndexedvEXT(Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,[OutAttribute] IntPtr data);
            internal static GetPointerIndexedvEXT glGetPointerIndexedvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointerv(Pencil.Gaming.Graphics.GetPointervPName pname,[OutAttribute] IntPtr @params);
            internal static GetPointerv glGetPointerv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetPointervEXT(Pencil.Gaming.Graphics.GetPointervPName pname,[OutAttribute] IntPtr @params);
            internal static GetPointervEXT glGetPointervEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetPolygonStipple([OutAttribute] Byte* mask);
            internal unsafe static GetPolygonStipple glGetPolygonStipple;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramBinary(UInt32 program,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Pencil.Gaming.Graphics.BinaryFormat* binaryFormat,[OutAttribute] IntPtr binary);
            internal unsafe static GetProgramBinary glGetProgramBinary;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterdvARB(Pencil.Gaming.Graphics.ArbVertexProgram target,UInt32 index,[OutAttribute] Double* @params);
            internal unsafe static GetProgramEnvParameterdvARB glGetProgramEnvParameterdvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterfvARB(Pencil.Gaming.Graphics.ArbVertexProgram target,UInt32 index,[OutAttribute] Single* @params);
            internal unsafe static GetProgramEnvParameterfvARB glGetProgramEnvParameterfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterIivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,[OutAttribute] Int32* @params);
            internal unsafe static GetProgramEnvParameterIivNV glGetProgramEnvParameterIivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramEnvParameterIuivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,[OutAttribute] UInt32* @params);
            internal unsafe static GetProgramEnvParameterIuivNV glGetProgramEnvParameterIuivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramInfoLog(UInt32 program,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramInfoLog glGetProgramInfoLog;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramiv(UInt32 program,Pencil.Gaming.Graphics.ProgramParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetProgramiv glGetProgramiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramivARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,[OutAttribute] Int32* @params);
            internal unsafe static GetProgramivARB glGetProgramivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramivNV(UInt32 id,Pencil.Gaming.Graphics.NvVertexProgram pname,[OutAttribute] Int32* @params);
            internal unsafe static GetProgramivNV glGetProgramivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterdvARB(Pencil.Gaming.Graphics.ArbVertexProgram target,UInt32 index,[OutAttribute] Double* @params);
            internal unsafe static GetProgramLocalParameterdvARB glGetProgramLocalParameterdvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterfvARB(Pencil.Gaming.Graphics.ArbVertexProgram target,UInt32 index,[OutAttribute] Single* @params);
            internal unsafe static GetProgramLocalParameterfvARB glGetProgramLocalParameterfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterIivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,[OutAttribute] Int32* @params);
            internal unsafe static GetProgramLocalParameterIivNV glGetProgramLocalParameterIivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramLocalParameterIuivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,[OutAttribute] UInt32* @params);
            internal unsafe static GetProgramLocalParameterIuivNV glGetProgramLocalParameterIuivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramNamedParameterdvNV(UInt32 id,Int32 len,Byte* name,[OutAttribute] Double* @params);
            internal unsafe static GetProgramNamedParameterdvNV glGetProgramNamedParameterdvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramNamedParameterfvNV(UInt32 id,Int32 len,Byte* name,[OutAttribute] Single* @params);
            internal unsafe static GetProgramNamedParameterfvNV glGetProgramNamedParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramParameterdvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,[OutAttribute] Double* @params);
            internal unsafe static GetProgramParameterdvNV glGetProgramParameterdvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramParameterfvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,[OutAttribute] Single* @params);
            internal unsafe static GetProgramParameterfvNV glGetProgramParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineInfoLog(UInt32 pipeline,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder infoLog);
            internal unsafe static GetProgramPipelineInfoLog glGetProgramPipelineInfoLog;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramPipelineiv(UInt32 pipeline,Pencil.Gaming.Graphics.ProgramPipelineParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetProgramPipelineiv glGetProgramPipelineiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramStageiv(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,Pencil.Gaming.Graphics.ProgramStageParameter pname,[OutAttribute] Int32* values);
            internal unsafe static GetProgramStageiv glGetProgramStageiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetProgramStringARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,[OutAttribute] IntPtr @string);
            internal static GetProgramStringARB glGetProgramStringARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramStringNV(UInt32 id,Pencil.Gaming.Graphics.NvVertexProgram pname,[OutAttribute] Byte* program);
            internal unsafe static GetProgramStringNV glGetProgramStringNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetProgramSubroutineParameteruivNV(Pencil.Gaming.Graphics.NvGpuProgram5 target,UInt32 index,[OutAttribute] UInt32* param);
            internal unsafe static GetProgramSubroutineParameteruivNV glGetProgramSubroutineParameteruivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryIndexediv(Pencil.Gaming.Graphics.QueryTarget target,UInt32 index,Pencil.Gaming.Graphics.GetQueryParam pname,[OutAttribute] Int32* @params);
            internal unsafe static GetQueryIndexediv glGetQueryIndexediv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryiv(Pencil.Gaming.Graphics.QueryTarget target,Pencil.Gaming.Graphics.GetQueryParam pname,[OutAttribute] Int32* @params);
            internal unsafe static GetQueryiv glGetQueryiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryivARB(Pencil.Gaming.Graphics.ArbOcclusionQuery target,Pencil.Gaming.Graphics.ArbOcclusionQuery pname,[OutAttribute] Int32* @params);
            internal unsafe static GetQueryivARB glGetQueryivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjecti64v(UInt32 id,Pencil.Gaming.Graphics.GetQueryObjectParam pname,[OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64v glGetQueryObjecti64v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjecti64vEXT(UInt32 id,Pencil.Gaming.Graphics.ExtTimerQuery pname,[OutAttribute] Int64* @params);
            internal unsafe static GetQueryObjecti64vEXT glGetQueryObjecti64vEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectiv(UInt32 id,Pencil.Gaming.Graphics.GetQueryObjectParam pname,[OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectiv glGetQueryObjectiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectivARB(UInt32 id,Pencil.Gaming.Graphics.ArbOcclusionQuery pname,[OutAttribute] Int32* @params);
            internal unsafe static GetQueryObjectivARB glGetQueryObjectivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectui64v(UInt32 id,Pencil.Gaming.Graphics.GetQueryObjectParam pname,[OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64v glGetQueryObjectui64v;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectui64vEXT(UInt32 id,Pencil.Gaming.Graphics.ExtTimerQuery pname,[OutAttribute] UInt64* @params);
            internal unsafe static GetQueryObjectui64vEXT glGetQueryObjectui64vEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuiv(UInt32 id,Pencil.Gaming.Graphics.GetQueryObjectParam pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuiv glGetQueryObjectuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetQueryObjectuivARB(UInt32 id,Pencil.Gaming.Graphics.ArbOcclusionQuery pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetQueryObjectuivARB glGetQueryObjectuivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameteriv(Pencil.Gaming.Graphics.RenderbufferTarget target,Pencil.Gaming.Graphics.RenderbufferParameterName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameteriv glGetRenderbufferParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetRenderbufferParameterivEXT(Pencil.Gaming.Graphics.RenderbufferTarget target,Pencil.Gaming.Graphics.RenderbufferParameterName pname,[OutAttribute] Int32* @params);
            internal unsafe static GetRenderbufferParameterivEXT glGetRenderbufferParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterfv(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetSamplerParameterfv glGetSamplerParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterIiv(UInt32 sampler,Pencil.Gaming.Graphics.ArbSamplerObjects pname,[OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameterIiv glGetSamplerParameterIiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameterIuiv(UInt32 sampler,Pencil.Gaming.Graphics.ArbSamplerObjects pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetSamplerParameterIuiv glGetSamplerParameterIuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSamplerParameteriv(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetSamplerParameteriv glGetSamplerParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetSeparableFilter(Pencil.Gaming.Graphics.SeparableTarget target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr row,[OutAttribute] IntPtr column,[OutAttribute] IntPtr span);
            internal static GetSeparableFilter glGetSeparableFilter;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetSeparableFilterEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr row,[OutAttribute] IntPtr column,[OutAttribute] IntPtr span);
            internal static GetSeparableFilterEXT glGetSeparableFilterEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderInfoLog(UInt32 shader,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder infoLog);
            internal unsafe static GetShaderInfoLog glGetShaderInfoLog;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderiv(UInt32 shader,Pencil.Gaming.Graphics.ShaderParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetShaderiv glGetShaderiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderPrecisionFormat(Pencil.Gaming.Graphics.ShaderType shadertype,Pencil.Gaming.Graphics.ShaderPrecisionType precisiontype,[OutAttribute] Int32* range,[OutAttribute] Int32* precision);
            internal unsafe static GetShaderPrecisionFormat glGetShaderPrecisionFormat;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSource(UInt32 shader,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSource glGetShaderSource;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetShaderSourceARB(UInt32 obj,Int32 maxLength,[OutAttribute] Int32* length,[OutAttribute] StringBuilder source);
            internal unsafe static GetShaderSourceARB glGetShaderSourceARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSharpenTexFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target,[OutAttribute] Single* points);
            internal unsafe static GetSharpenTexFuncSGIS glGetSharpenTexFuncSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetString(Pencil.Gaming.Graphics.StringName name);
            internal static GetString glGetString;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetStringi(Pencil.Gaming.Graphics.StringName name,UInt32 index);
            internal static GetStringi glGetStringi;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetSubroutineIndex(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,String name);
            internal static GetSubroutineIndex glGetSubroutineIndex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetSubroutineUniformLocation(UInt32 program,Pencil.Gaming.Graphics.ShaderType shadertype,String name);
            internal static GetSubroutineUniformLocation glGetSubroutineUniformLocation;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetSynciv(IntPtr sync,Pencil.Gaming.Graphics.ArbSync pname,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* values);
            internal unsafe static GetSynciv glGetSynciv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexBumpParameterfvATI(Pencil.Gaming.Graphics.AtiEnvmapBumpmap pname,[OutAttribute] Single* param);
            internal unsafe static GetTexBumpParameterfvATI glGetTexBumpParameterfvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexBumpParameterivATI(Pencil.Gaming.Graphics.AtiEnvmapBumpmap pname,[OutAttribute] Int32* param);
            internal unsafe static GetTexBumpParameterivATI glGetTexBumpParameterivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnvfv(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetTexEnvfv glGetTexEnvfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexEnviv(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTexEnviv glGetTexEnviv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexFilterFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.SgisTextureFilter4 filter,[OutAttribute] Single* weights);
            internal unsafe static GetTexFilterFuncSGIS glGetTexFilterFuncSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGendv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Double* @params);
            internal unsafe static GetTexGendv glGetTexGendv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGenfv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetTexGenfv glGetTexGenfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexGeniv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTexGeniv glGetTexGeniv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetTexImage(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr pixels);
            internal static GetTexImage glGetTexImage;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameterfv(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetTexLevelParameterfv glGetTexLevelParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexLevelParameteriv(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTexLevelParameteriv glGetTexLevelParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterfv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetTexParameterfv glGetTexParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIiv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTexParameterIiv glGetTexParameterIiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIivEXT(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTexParameterIivEXT glGetTexParameterIivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIuiv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetTexParameterIuiv glGetTexParameterIuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameterIuivEXT(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetTexParameterIuivEXT glGetTexParameterIuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTexParameteriv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTexParameteriv glGetTexParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetTexParameterPointervAPPLE(Pencil.Gaming.Graphics.AppleTextureRange target,Pencil.Gaming.Graphics.AppleTextureRange pname,[OutAttribute] IntPtr @params);
            internal static GetTexParameterPointervAPPLE glGetTexParameterPointervAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetTextureImageEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr pixels);
            internal static GetTextureImageEXT glGetTextureImageEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureLevelParameterfvEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetTextureLevelParameterfvEXT glGetTextureLevelParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureLevelParameterivEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTextureLevelParameterivEXT glGetTextureLevelParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureParameterfvEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetTextureParameterfvEXT glGetTextureParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureParameterIivEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTextureParameterIivEXT glGetTextureParameterIivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureParameterIuivEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetTextureParameterIuivEXT glGetTextureParameterIuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTextureParameterivEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.GetTextureParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTextureParameterivEXT glGetTextureParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTrackMatrixivNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 address,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,[OutAttribute] Int32* @params);
            internal unsafe static GetTrackMatrixivNV glGetTrackMatrixivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVarying(UInt32 program,UInt32 index,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ActiveAttribType* type,[OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVarying glGetTransformFeedbackVarying;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVaryingEXT(UInt32 program,UInt32 index,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* size,[OutAttribute] Pencil.Gaming.Graphics.ExtTransformFeedback* type,[OutAttribute] StringBuilder name);
            internal unsafe static GetTransformFeedbackVaryingEXT glGetTransformFeedbackVaryingEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetTransformFeedbackVaryingNV(UInt32 program,UInt32 index,[OutAttribute] Int32* location);
            internal unsafe static GetTransformFeedbackVaryingNV glGetTransformFeedbackVaryingNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformBlockIndex(UInt32 program,String uniformBlockName);
            internal static GetUniformBlockIndex glGetUniformBlockIndex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformBufferSizeEXT(UInt32 program,Int32 location);
            internal static GetUniformBufferSizeEXT glGetUniformBufferSizeEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformdv(UInt32 program,Int32 location,[OutAttribute] Double* @params);
            internal unsafe static GetUniformdv glGetUniformdv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfv(UInt32 program,Int32 location,[OutAttribute] Single* @params);
            internal unsafe static GetUniformfv glGetUniformfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformfvARB(UInt32 programObj,Int32 location,[OutAttribute] Single* @params);
            internal unsafe static GetUniformfvARB glGetUniformfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformi64vNV(UInt32 program,Int32 location,[OutAttribute] Int64* @params);
            internal unsafe static GetUniformi64vNV glGetUniformi64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformIndices(UInt32 program,Int32 uniformCount,String[] uniformNames,[OutAttribute] UInt32* uniformIndices);
            internal unsafe static GetUniformIndices glGetUniformIndices;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformiv(UInt32 program,Int32 location,[OutAttribute] Int32* @params);
            internal unsafe static GetUniformiv glGetUniformiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformivARB(UInt32 programObj,Int32 location,[OutAttribute] Int32* @params);
            internal unsafe static GetUniformivARB glGetUniformivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocation(UInt32 program,String name);
            internal static GetUniformLocation glGetUniformLocation;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetUniformLocationARB(UInt32 programObj,String name);
            internal static GetUniformLocationARB glGetUniformLocationARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr GetUniformOffsetEXT(UInt32 program,Int32 location);
            internal static GetUniformOffsetEXT glGetUniformOffsetEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformSubroutineuiv(Pencil.Gaming.Graphics.ShaderType shadertype,Int32 location,[OutAttribute] UInt32* @params);
            internal unsafe static GetUniformSubroutineuiv glGetUniformSubroutineuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformui64vNV(UInt32 program,Int32 location,[OutAttribute] UInt64* @params);
            internal unsafe static GetUniformui64vNV glGetUniformui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformuiv(UInt32 program,Int32 location,[OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuiv glGetUniformuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetUniformuivEXT(UInt32 program,Int32 location,[OutAttribute] UInt32* @params);
            internal unsafe static GetUniformuivEXT glGetUniformuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantArrayObjectfvATI(UInt32 id,Pencil.Gaming.Graphics.AtiVertexArrayObject pname,[OutAttribute] Single* @params);
            internal unsafe static GetVariantArrayObjectfvATI glGetVariantArrayObjectfvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantArrayObjectivATI(UInt32 id,Pencil.Gaming.Graphics.AtiVertexArrayObject pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVariantArrayObjectivATI glGetVariantArrayObjectivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantBooleanvEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] bool* data);
            internal unsafe static GetVariantBooleanvEXT glGetVariantBooleanvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantFloatvEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] Single* data);
            internal unsafe static GetVariantFloatvEXT glGetVariantFloatvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVariantIntegervEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] Int32* data);
            internal unsafe static GetVariantIntegervEXT glGetVariantIntegervEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVariantPointervEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader value,[OutAttribute] IntPtr data);
            internal static GetVariantPointervEXT glGetVariantPointervEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 GetVaryingLocationNV(UInt32 program,String name);
            internal static GetVaryingLocationNV glGetVaryingLocationNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribArrayObjectfvATI(UInt32 index,Pencil.Gaming.Graphics.AtiVertexAttribArrayObject pname,[OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribArrayObjectfvATI glGetVertexAttribArrayObjectfvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribArrayObjectivATI(UInt32 index,Pencil.Gaming.Graphics.AtiVertexAttribArrayObject pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribArrayObjectivATI glGetVertexAttribArrayObjectivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdv glGetVertexAttribdv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdvARB(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameterArb pname,[OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdvARB glGetVertexAttribdvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribdvNV(UInt32 index,Pencil.Gaming.Graphics.NvVertexProgram pname,[OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribdvNV glGetVertexAttribdvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfv glGetVertexAttribfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfvARB(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameterArb pname,[OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfvARB glGetVertexAttribfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribfvNV(UInt32 index,Pencil.Gaming.Graphics.NvVertexProgram pname,[OutAttribute] Single* @params);
            internal unsafe static GetVertexAttribfvNV glGetVertexAttribfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIiv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIiv glGetVertexAttribIiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIivEXT(UInt32 index,Pencil.Gaming.Graphics.NvVertexProgram4 pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribIivEXT glGetVertexAttribIivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIuiv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuiv glGetVertexAttribIuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribIuivEXT(UInt32 index,Pencil.Gaming.Graphics.NvVertexProgram4 pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetVertexAttribIuivEXT glGetVertexAttribIuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribiv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribiv glGetVertexAttribiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribivARB(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameterArb pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribivARB glGetVertexAttribivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribivNV(UInt32 index,Pencil.Gaming.Graphics.NvVertexProgram pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVertexAttribivNV glGetVertexAttribivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLdv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribParameter pname,[OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribLdv glGetVertexAttribLdv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLdvEXT(UInt32 index,Pencil.Gaming.Graphics.ExtVertexAttrib64bit pname,[OutAttribute] Double* @params);
            internal unsafe static GetVertexAttribLdvEXT glGetVertexAttribLdvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLi64vNV(UInt32 index,Pencil.Gaming.Graphics.NvVertexAttribInteger64bit pname,[OutAttribute] Int64* @params);
            internal unsafe static GetVertexAttribLi64vNV glGetVertexAttribLi64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVertexAttribLui64vNV(UInt32 index,Pencil.Gaming.Graphics.NvVertexAttribInteger64bit pname,[OutAttribute] UInt64* @params);
            internal unsafe static GetVertexAttribLui64vNV glGetVertexAttribLui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointerv(UInt32 index,Pencil.Gaming.Graphics.VertexAttribPointerParameter pname,[OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointerv glGetVertexAttribPointerv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointervARB(UInt32 index,Pencil.Gaming.Graphics.VertexAttribPointerParameterArb pname,[OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointervARB glGetVertexAttribPointervARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GetVertexAttribPointervNV(UInt32 index,Pencil.Gaming.Graphics.NvVertexProgram pname,[OutAttribute] IntPtr pointer);
            internal static GetVertexAttribPointervNV glGetVertexAttribPointervNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoCaptureivNV(UInt32 video_capture_slot,Pencil.Gaming.Graphics.NvVideoCapture pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVideoCaptureivNV glGetVideoCaptureivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoCaptureStreamdvNV(UInt32 video_capture_slot,UInt32 stream,Pencil.Gaming.Graphics.NvVideoCapture pname,[OutAttribute] Double* @params);
            internal unsafe static GetVideoCaptureStreamdvNV glGetVideoCaptureStreamdvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoCaptureStreamfvNV(UInt32 video_capture_slot,UInt32 stream,Pencil.Gaming.Graphics.NvVideoCapture pname,[OutAttribute] Single* @params);
            internal unsafe static GetVideoCaptureStreamfvNV glGetVideoCaptureStreamfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoCaptureStreamivNV(UInt32 video_capture_slot,UInt32 stream,Pencil.Gaming.Graphics.NvVideoCapture pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVideoCaptureStreamivNV glGetVideoCaptureStreamivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoi64vNV(UInt32 video_slot,Pencil.Gaming.Graphics.NvPresentVideo pname,[OutAttribute] Int64* @params);
            internal unsafe static GetVideoi64vNV glGetVideoi64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoivNV(UInt32 video_slot,Pencil.Gaming.Graphics.NvPresentVideo pname,[OutAttribute] Int32* @params);
            internal unsafe static GetVideoivNV glGetVideoivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideoui64vNV(UInt32 video_slot,Pencil.Gaming.Graphics.NvPresentVideo pname,[OutAttribute] UInt64* @params);
            internal unsafe static GetVideoui64vNV glGetVideoui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void GetVideouivNV(UInt32 video_slot,Pencil.Gaming.Graphics.NvPresentVideo pname,[OutAttribute] UInt32* @params);
            internal unsafe static GetVideouivNV glGetVideouivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorbSUN(SByte factor);
            internal static GlobalAlphaFactorbSUN glGlobalAlphaFactorbSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactordSUN(Double factor);
            internal static GlobalAlphaFactordSUN glGlobalAlphaFactordSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorfSUN(Single factor);
            internal static GlobalAlphaFactorfSUN glGlobalAlphaFactorfSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactoriSUN(Int32 factor);
            internal static GlobalAlphaFactoriSUN glGlobalAlphaFactoriSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorsSUN(Int16 factor);
            internal static GlobalAlphaFactorsSUN glGlobalAlphaFactorsSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorubSUN(Byte factor);
            internal static GlobalAlphaFactorubSUN glGlobalAlphaFactorubSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactoruiSUN(UInt32 factor);
            internal static GlobalAlphaFactoruiSUN glGlobalAlphaFactoruiSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void GlobalAlphaFactorusSUN(UInt16 factor);
            internal static GlobalAlphaFactorusSUN glGlobalAlphaFactorusSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Hint(Pencil.Gaming.Graphics.HintTarget target,Pencil.Gaming.Graphics.HintMode mode);
            internal static Hint glHint;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void HintPGI(Pencil.Gaming.Graphics.PgiMiscHints target,Int32 mode);
            internal static HintPGI glHintPGI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Histogram(Pencil.Gaming.Graphics.HistogramTarget target,Int32 width,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,bool sink);
            internal static Histogram glHistogram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void HistogramEXT(Pencil.Gaming.Graphics.ExtHistogram target,Int32 width,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,bool sink);
            internal static HistogramEXT glHistogramEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void IglooInterfaceSGIX(Pencil.Gaming.Graphics.All pname,IntPtr @params);
            internal static IglooInterfaceSGIX glIglooInterfaceSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ImageTransformParameterfHP(Pencil.Gaming.Graphics.HpImageTransform target,Pencil.Gaming.Graphics.HpImageTransform pname,Single param);
            internal static ImageTransformParameterfHP glImageTransformParameterfHP;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ImageTransformParameterfvHP(Pencil.Gaming.Graphics.HpImageTransform target,Pencil.Gaming.Graphics.HpImageTransform pname,Single* @params);
            internal unsafe static ImageTransformParameterfvHP glImageTransformParameterfvHP;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ImageTransformParameteriHP(Pencil.Gaming.Graphics.HpImageTransform target,Pencil.Gaming.Graphics.HpImageTransform pname,Int32 param);
            internal static ImageTransformParameteriHP glImageTransformParameteriHP;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ImageTransformParameterivHP(Pencil.Gaming.Graphics.HpImageTransform target,Pencil.Gaming.Graphics.HpImageTransform pname,Int32* @params);
            internal unsafe static ImageTransformParameterivHP glImageTransformParameterivHP;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate IntPtr ImportSyncEXT(Pencil.Gaming.Graphics.ExtX11SyncObject external_sync_type,IntPtr external_sync,UInt32 flags);
            internal static ImportSyncEXT glImportSyncEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexd(Double c);
            internal static Indexd glIndexd;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexdv(Double* c);
            internal unsafe static Indexdv glIndexdv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexf(Single c);
            internal static Indexf glIndexf;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexFormatNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,Int32 stride);
            internal static IndexFormatNV glIndexFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexFuncEXT(Pencil.Gaming.Graphics.ExtIndexFunc func,Single @ref);
            internal static IndexFuncEXT glIndexFuncEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexfv(Single* c);
            internal unsafe static Indexfv glIndexfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexi(Int32 c);
            internal static Indexi glIndexi;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexiv(Int32* c);
            internal unsafe static Indexiv glIndexiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexMask(UInt32 mask);
            internal static IndexMask glIndexMask;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexMaterialEXT(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.ExtIndexMaterial mode);
            internal static IndexMaterialEXT glIndexMaterialEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointer(Pencil.Gaming.Graphics.IndexPointerType type,Int32 stride,IntPtr pointer);
            internal static IndexPointer glIndexPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointerEXT(Pencil.Gaming.Graphics.IndexPointerType type,Int32 stride,Int32 count,IntPtr pointer);
            internal static IndexPointerEXT glIndexPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void IndexPointerListIBM(Pencil.Gaming.Graphics.IndexPointerType type,Int32 stride,IntPtr pointer,Int32 ptrstride);
            internal static IndexPointerListIBM glIndexPointerListIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexs(Int16 c);
            internal static Indexs glIndexs;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexsv(Int16* c);
            internal unsafe static Indexsv glIndexsv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Indexub(Byte c);
            internal static Indexub glIndexub;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Indexubv(Byte* c);
            internal unsafe static Indexubv glIndexubv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void InitNames();
            internal static InitNames glInitNames;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void InsertComponentEXT(UInt32 res,UInt32 src,UInt32 num);
            internal static InsertComponentEXT glInsertComponentEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void InstrumentsBufferSGIX(Int32 size,[OutAttribute] Int32* buffer);
            internal unsafe static InstrumentsBufferSGIX glInstrumentsBufferSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void InterleavedArrays(Pencil.Gaming.Graphics.InterleavedArrayFormat format,Int32 stride,IntPtr pointer);
            internal static InterleavedArrays glInterleavedArrays;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsAsyncMarkerSGIX(UInt32 marker);
            internal static IsAsyncMarkerSGIX glIsAsyncMarkerSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBuffer(UInt32 buffer);
            internal static IsBuffer glIsBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBufferARB(UInt32 buffer);
            internal static IsBufferARB glIsBufferARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsBufferResidentNV(Pencil.Gaming.Graphics.NvShaderBufferLoad target);
            internal static IsBufferResidentNV glIsBufferResidentNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabled(Pencil.Gaming.Graphics.EnableCap cap);
            internal static IsEnabled glIsEnabled;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabledi(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
            internal static IsEnabledi glIsEnabledi;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsEnabledIndexedEXT(Pencil.Gaming.Graphics.IndexedEnableCap target,UInt32 index);
            internal static IsEnabledIndexedEXT glIsEnabledIndexedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFenceAPPLE(UInt32 fence);
            internal static IsFenceAPPLE glIsFenceAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFenceNV(UInt32 fence);
            internal static IsFenceNV glIsFenceNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFramebuffer(UInt32 framebuffer);
            internal static IsFramebuffer glIsFramebuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsFramebufferEXT(UInt32 framebuffer);
            internal static IsFramebufferEXT glIsFramebufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsList(UInt32 list);
            internal static IsList glIsList;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsNameAMD(Pencil.Gaming.Graphics.AmdNameGenDelete identifier,UInt32 name);
            internal static IsNameAMD glIsNameAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsNamedBufferResidentNV(UInt32 buffer);
            internal static IsNamedBufferResidentNV glIsNamedBufferResidentNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsNamedStringARB(Int32 namelen,String name);
            internal static IsNamedStringARB glIsNamedStringARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsObjectBufferATI(UInt32 buffer);
            internal static IsObjectBufferATI glIsObjectBufferATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsOcclusionQueryNV(UInt32 id);
            internal static IsOcclusionQueryNV glIsOcclusionQueryNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgram(UInt32 program);
            internal static IsProgram glIsProgram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgramARB(UInt32 program);
            internal static IsProgramARB glIsProgramARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgramNV(UInt32 id);
            internal static IsProgramNV glIsProgramNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsProgramPipeline(UInt32 pipeline);
            internal static IsProgramPipeline glIsProgramPipeline;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsQuery(UInt32 id);
            internal static IsQuery glIsQuery;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsQueryARB(UInt32 id);
            internal static IsQueryARB glIsQueryARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsRenderbuffer(UInt32 renderbuffer);
            internal static IsRenderbuffer glIsRenderbuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsRenderbufferEXT(UInt32 renderbuffer);
            internal static IsRenderbufferEXT glIsRenderbufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsSampler(UInt32 sampler);
            internal static IsSampler glIsSampler;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsShader(UInt32 shader);
            internal static IsShader glIsShader;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsSync(IntPtr sync);
            internal static IsSync glIsSync;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTexture(UInt32 texture);
            internal static IsTexture glIsTexture;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTextureEXT(UInt32 texture);
            internal static IsTextureEXT glIsTextureEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTransformFeedback(UInt32 id);
            internal static IsTransformFeedback glIsTransformFeedback;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsTransformFeedbackNV(UInt32 id);
            internal static IsTransformFeedbackNV glIsTransformFeedbackNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVariantEnabledEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader cap);
            internal static IsVariantEnabledEXT glIsVariantEnabledEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexArray(UInt32 array);
            internal static IsVertexArray glIsVertexArray;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexArrayAPPLE(UInt32 array);
            internal static IsVertexArrayAPPLE glIsVertexArrayAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool IsVertexAttribEnabledAPPLE(UInt32 index,Pencil.Gaming.Graphics.AppleVertexProgramEvaluators pname);
            internal static IsVertexAttribEnabledAPPLE glIsVertexAttribEnabledAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LightEnviSGIX(Pencil.Gaming.Graphics.SgixFragmentLighting pname,Int32 param);
            internal static LightEnviSGIX glLightEnviSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Lightf(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,Single param);
            internal static Lightf glLightf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightfv(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,Single* @params);
            internal unsafe static Lightfv glLightfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Lighti(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,Int32 param);
            internal static Lighti glLighti;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Lightiv(Pencil.Gaming.Graphics.LightName light,Pencil.Gaming.Graphics.LightParameter pname,Int32* @params);
            internal unsafe static Lightiv glLightiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModelf(Pencil.Gaming.Graphics.LightModelParameter pname,Single param);
            internal static LightModelf glLightModelf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModelfv(Pencil.Gaming.Graphics.LightModelParameter pname,Single* @params);
            internal unsafe static LightModelfv glLightModelfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LightModeli(Pencil.Gaming.Graphics.LightModelParameter pname,Int32 param);
            internal static LightModeli glLightModeli;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LightModeliv(Pencil.Gaming.Graphics.LightModelParameter pname,Int32* @params);
            internal unsafe static LightModeliv glLightModeliv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LineStipple(Int32 factor,UInt16 pattern);
            internal static LineStipple glLineStipple;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LineWidth(Single width);
            internal static LineWidth glLineWidth;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgram(UInt32 program);
            internal static LinkProgram glLinkProgram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LinkProgramARB(UInt32 programObj);
            internal static LinkProgramARB glLinkProgramARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ListBase(UInt32 @base);
            internal static ListBase glListBase;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ListParameterfSGIX(UInt32 list,Pencil.Gaming.Graphics.ListParameterName pname,Single param);
            internal static ListParameterfSGIX glListParameterfSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ListParameterfvSGIX(UInt32 list,Pencil.Gaming.Graphics.ListParameterName pname,Single* @params);
            internal unsafe static ListParameterfvSGIX glListParameterfvSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ListParameteriSGIX(UInt32 list,Pencil.Gaming.Graphics.ListParameterName pname,Int32 param);
            internal static ListParameteriSGIX glListParameteriSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ListParameterivSGIX(UInt32 list,Pencil.Gaming.Graphics.ListParameterName pname,Int32* @params);
            internal unsafe static ListParameterivSGIX glListParameterivSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentity();
            internal static LoadIdentity glLoadIdentity;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadIdentityDeformationMapSGIX(UInt32 mask);
            internal static LoadIdentityDeformationMapSGIX glLoadIdentityDeformationMapSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixd(Double* m);
            internal unsafe static LoadMatrixd glLoadMatrixd;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadMatrixf(Single* m);
            internal unsafe static LoadMatrixf glLoadMatrixf;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LoadName(UInt32 name);
            internal static LoadName glLoadName;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadProgramNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 id,Int32 len,Byte* program);
            internal unsafe static LoadProgramNV glLoadProgramNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixd(Double* m);
            internal unsafe static LoadTransposeMatrixd glLoadTransposeMatrixd;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixdARB(Double* m);
            internal unsafe static LoadTransposeMatrixdARB glLoadTransposeMatrixdARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixf(Single* m);
            internal unsafe static LoadTransposeMatrixf glLoadTransposeMatrixf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void LoadTransposeMatrixfARB(Single* m);
            internal unsafe static LoadTransposeMatrixfARB glLoadTransposeMatrixfARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LockArraysEXT(Int32 first,Int32 count);
            internal static LockArraysEXT glLockArraysEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void LogicOp(Pencil.Gaming.Graphics.LogicOp opcode);
            internal static LogicOp glLogicOp;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeBufferNonResidentNV(Pencil.Gaming.Graphics.NvShaderBufferLoad target);
            internal static MakeBufferNonResidentNV glMakeBufferNonResidentNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeBufferResidentNV(Pencil.Gaming.Graphics.NvShaderBufferLoad target,Pencil.Gaming.Graphics.NvShaderBufferLoad access);
            internal static MakeBufferResidentNV glMakeBufferResidentNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeNamedBufferNonResidentNV(UInt32 buffer);
            internal static MakeNamedBufferNonResidentNV glMakeNamedBufferNonResidentNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MakeNamedBufferResidentNV(UInt32 buffer,Pencil.Gaming.Graphics.NvShaderBufferLoad access);
            internal static MakeNamedBufferResidentNV glMakeNamedBufferResidentNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map1d(Pencil.Gaming.Graphics.MapTarget target,Double u1,Double u2,Int32 stride,Int32 order,Double* points);
            internal unsafe static Map1d glMap1d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map1f(Pencil.Gaming.Graphics.MapTarget target,Single u1,Single u2,Int32 stride,Int32 order,Single* points);
            internal unsafe static Map1f glMap1f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map2d(Pencil.Gaming.Graphics.MapTarget target,Double u1,Double u2,Int32 ustride,Int32 uorder,Double v1,Double v2,Int32 vstride,Int32 vorder,Double* points);
            internal unsafe static Map2d glMap2d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Map2f(Pencil.Gaming.Graphics.MapTarget target,Single u1,Single u2,Int32 ustride,Int32 uorder,Single v1,Single v2,Int32 vstride,Int32 vorder,Single* points);
            internal unsafe static Map2f glMap2f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBuffer(Pencil.Gaming.Graphics.BufferTarget target,Pencil.Gaming.Graphics.BufferAccess access);
            internal unsafe static MapBuffer glMapBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBufferARB(Pencil.Gaming.Graphics.BufferTargetArb target,Pencil.Gaming.Graphics.ArbVertexBufferObject access);
            internal unsafe static MapBufferARB glMapBufferARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapBufferRange(Pencil.Gaming.Graphics.BufferTarget target,IntPtr offset,IntPtr length,Pencil.Gaming.Graphics.BufferAccessMask access);
            internal unsafe static MapBufferRange glMapBufferRange;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MapControlPointsNV(Pencil.Gaming.Graphics.NvEvaluators target,UInt32 index,Pencil.Gaming.Graphics.NvEvaluators type,Int32 ustride,Int32 vstride,Int32 uorder,Int32 vorder,bool packed,IntPtr points);
            internal static MapControlPointsNV glMapControlPointsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1d(Int32 un,Double u1,Double u2);
            internal static MapGrid1d glMapGrid1d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid1f(Int32 un,Single u1,Single u2);
            internal static MapGrid1f glMapGrid1f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2d(Int32 un,Double u1,Double u2,Int32 vn,Double v1,Double v2);
            internal static MapGrid2d glMapGrid2d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MapGrid2f(Int32 un,Single u1,Single u2,Int32 vn,Single v1,Single v2);
            internal static MapGrid2f glMapGrid2f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapNamedBufferEXT(UInt32 buffer,Pencil.Gaming.Graphics.ExtDirectStateAccess access);
            internal unsafe static MapNamedBufferEXT glMapNamedBufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapNamedBufferRangeEXT(UInt32 buffer,IntPtr offset,IntPtr length,Pencil.Gaming.Graphics.BufferAccessMask access);
            internal unsafe static MapNamedBufferRangeEXT glMapNamedBufferRangeEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr MapObjectBufferATI(UInt32 buffer);
            internal unsafe static MapObjectBufferATI glMapObjectBufferATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapParameterfvNV(Pencil.Gaming.Graphics.NvEvaluators target,Pencil.Gaming.Graphics.NvEvaluators pname,Single* @params);
            internal unsafe static MapParameterfvNV glMapParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapParameterivNV(Pencil.Gaming.Graphics.NvEvaluators target,Pencil.Gaming.Graphics.NvEvaluators pname,Int32* @params);
            internal unsafe static MapParameterivNV glMapParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapVertexAttrib1dAPPLE(UInt32 index,UInt32 size,Double u1,Double u2,Int32 stride,Int32 order,Double* points);
            internal unsafe static MapVertexAttrib1dAPPLE glMapVertexAttrib1dAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapVertexAttrib1fAPPLE(UInt32 index,UInt32 size,Single u1,Single u2,Int32 stride,Int32 order,Single* points);
            internal unsafe static MapVertexAttrib1fAPPLE glMapVertexAttrib1fAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapVertexAttrib2dAPPLE(UInt32 index,UInt32 size,Double u1,Double u2,Int32 ustride,Int32 uorder,Double v1,Double v2,Int32 vstride,Int32 vorder,Double* points);
            internal unsafe static MapVertexAttrib2dAPPLE glMapVertexAttrib2dAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MapVertexAttrib2fAPPLE(UInt32 index,UInt32 size,Single u1,Single u2,Int32 ustride,Int32 uorder,Single v1,Single v2,Int32 vstride,Int32 vorder,Single* points);
            internal unsafe static MapVertexAttrib2fAPPLE glMapVertexAttrib2fAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Materialf(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Single param);
            internal static Materialf glMaterialf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialfv(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Single* @params);
            internal unsafe static Materialfv glMaterialfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Materiali(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Int32 param);
            internal static Materiali glMateriali;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Materialiv(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter pname,Int32* @params);
            internal unsafe static Materialiv glMaterialiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixFrustumEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double left,Double right,Double bottom,Double top,Double zNear,Double zFar);
            internal static MatrixFrustumEXT glMatrixFrustumEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixIndexPointerARB(Int32 size,Pencil.Gaming.Graphics.ArbMatrixPalette type,Int32 stride,IntPtr pointer);
            internal static MatrixIndexPointerARB glMatrixIndexPointerARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexubvARB(Int32 size,Byte* indices);
            internal unsafe static MatrixIndexubvARB glMatrixIndexubvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexuivARB(Int32 size,UInt32* indices);
            internal unsafe static MatrixIndexuivARB glMatrixIndexuivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixIndexusvARB(Int32 size,UInt16* indices);
            internal unsafe static MatrixIndexusvARB glMatrixIndexusvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixLoaddEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double* m);
            internal unsafe static MatrixLoaddEXT glMatrixLoaddEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixLoadfEXT(Pencil.Gaming.Graphics.MatrixMode mode,Single* m);
            internal unsafe static MatrixLoadfEXT glMatrixLoadfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixLoadIdentityEXT(Pencil.Gaming.Graphics.MatrixMode mode);
            internal static MatrixLoadIdentityEXT glMatrixLoadIdentityEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixLoadTransposedEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double* m);
            internal unsafe static MatrixLoadTransposedEXT glMatrixLoadTransposedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixLoadTransposefEXT(Pencil.Gaming.Graphics.MatrixMode mode,Single* m);
            internal unsafe static MatrixLoadTransposefEXT glMatrixLoadTransposefEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixMode(Pencil.Gaming.Graphics.MatrixMode mode);
            internal static MatrixMode glMatrixMode;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixMultdEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double* m);
            internal unsafe static MatrixMultdEXT glMatrixMultdEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixMultfEXT(Pencil.Gaming.Graphics.MatrixMode mode,Single* m);
            internal unsafe static MatrixMultfEXT glMatrixMultfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixMultTransposedEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double* m);
            internal unsafe static MatrixMultTransposedEXT glMatrixMultTransposedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MatrixMultTransposefEXT(Pencil.Gaming.Graphics.MatrixMode mode,Single* m);
            internal unsafe static MatrixMultTransposefEXT glMatrixMultTransposefEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixOrthoEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double left,Double right,Double bottom,Double top,Double zNear,Double zFar);
            internal static MatrixOrthoEXT glMatrixOrthoEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixPopEXT(Pencil.Gaming.Graphics.MatrixMode mode);
            internal static MatrixPopEXT glMatrixPopEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixPushEXT(Pencil.Gaming.Graphics.MatrixMode mode);
            internal static MatrixPushEXT glMatrixPushEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixRotatedEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double angle,Double x,Double y,Double z);
            internal static MatrixRotatedEXT glMatrixRotatedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixRotatefEXT(Pencil.Gaming.Graphics.MatrixMode mode,Single angle,Single x,Single y,Single z);
            internal static MatrixRotatefEXT glMatrixRotatefEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixScaledEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double x,Double y,Double z);
            internal static MatrixScaledEXT glMatrixScaledEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixScalefEXT(Pencil.Gaming.Graphics.MatrixMode mode,Single x,Single y,Single z);
            internal static MatrixScalefEXT glMatrixScalefEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixTranslatedEXT(Pencil.Gaming.Graphics.MatrixMode mode,Double x,Double y,Double z);
            internal static MatrixTranslatedEXT glMatrixTranslatedEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MatrixTranslatefEXT(Pencil.Gaming.Graphics.MatrixMode mode,Single x,Single y,Single z);
            internal static MatrixTranslatefEXT glMatrixTranslatefEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MemoryBarrierEXT(UInt32 barriers);
            internal static MemoryBarrierEXT glMemoryBarrierEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Minmax(Pencil.Gaming.Graphics.MinmaxTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,bool sink);
            internal static Minmax glMinmax;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MinmaxEXT(Pencil.Gaming.Graphics.ExtHistogram target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,bool sink);
            internal static MinmaxEXT glMinmaxEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MinSampleShading(Single value);
            internal static MinSampleShading glMinSampleShading;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MinSampleShadingARB(Single value);
            internal static MinSampleShadingARB glMinSampleShadingARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArrays(Pencil.Gaming.Graphics.BeginMode mode,Int32* first,Int32* count,Int32 primcount);
            internal unsafe static MultiDrawArrays glMultiDrawArrays;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawArraysEXT(Pencil.Gaming.Graphics.BeginMode mode,Int32* first,Int32* count,Int32 primcount);
            internal unsafe static MultiDrawArraysEXT glMultiDrawArraysEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiDrawArraysIndirectAMD(Pencil.Gaming.Graphics.AmdMultiDrawIndirect mode,IntPtr indirect,Int32 primcount,Int32 stride);
            internal static MultiDrawArraysIndirectAMD glMultiDrawArraysIndirectAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementArrayAPPLE(Pencil.Gaming.Graphics.BeginMode mode,Int32* first,Int32* count,Int32 primcount);
            internal unsafe static MultiDrawElementArrayAPPLE glMultiDrawElementArrayAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElements(Pencil.Gaming.Graphics.BeginMode mode,Int32* count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount);
            internal unsafe static MultiDrawElements glMultiDrawElements;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsBaseVertex(Pencil.Gaming.Graphics.BeginMode mode,Int32* count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount,Int32* basevertex);
            internal unsafe static MultiDrawElementsBaseVertex glMultiDrawElementsBaseVertex;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawElementsEXT(Pencil.Gaming.Graphics.BeginMode mode,Int32* count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount);
            internal unsafe static MultiDrawElementsEXT glMultiDrawElementsEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiDrawElementsIndirectAMD(Pencil.Gaming.Graphics.AmdMultiDrawIndirect mode,Pencil.Gaming.Graphics.AmdMultiDrawIndirect type,IntPtr indirect,Int32 primcount,Int32 stride);
            internal static MultiDrawElementsIndirectAMD glMultiDrawElementsIndirectAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiDrawRangeElementArrayAPPLE(Pencil.Gaming.Graphics.BeginMode mode,UInt32 start,UInt32 end,Int32* first,Int32* count,Int32 primcount);
            internal unsafe static MultiDrawRangeElementArrayAPPLE glMultiDrawRangeElementArrayAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiModeDrawArraysIBM(Pencil.Gaming.Graphics.BeginMode* mode,Int32* first,Int32* count,Int32 primcount,Int32 modestride);
            internal unsafe static MultiModeDrawArraysIBM glMultiModeDrawArraysIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiModeDrawElementsIBM(Pencil.Gaming.Graphics.BeginMode* mode,Int32* count,Pencil.Gaming.Graphics.DrawElementsType type,IntPtr indices,Int32 primcount,Int32 modestride);
            internal unsafe static MultiModeDrawElementsIBM glMultiModeDrawElementsIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexBufferEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,UInt32 buffer);
            internal static MultiTexBufferEXT glMultiTexBufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1d(Pencil.Gaming.Graphics.TextureUnit target,Double s);
            internal static MultiTexCoord1d glMultiTexCoord1d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1dARB(Pencil.Gaming.Graphics.TextureUnit target,Double s);
            internal static MultiTexCoord1dARB glMultiTexCoord1dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1dv(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
            internal unsafe static MultiTexCoord1dv glMultiTexCoord1dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1dvARB(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
            internal unsafe static MultiTexCoord1dvARB glMultiTexCoord1dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1f(Pencil.Gaming.Graphics.TextureUnit target,Single s);
            internal static MultiTexCoord1f glMultiTexCoord1f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1fARB(Pencil.Gaming.Graphics.TextureUnit target,Single s);
            internal static MultiTexCoord1fARB glMultiTexCoord1fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1fv(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
            internal unsafe static MultiTexCoord1fv glMultiTexCoord1fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1fvARB(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
            internal unsafe static MultiTexCoord1fvARB glMultiTexCoord1fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1i(Pencil.Gaming.Graphics.TextureUnit target,Int32 s);
            internal static MultiTexCoord1i glMultiTexCoord1i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1iARB(Pencil.Gaming.Graphics.TextureUnit target,Int32 s);
            internal static MultiTexCoord1iARB glMultiTexCoord1iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1iv(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
            internal unsafe static MultiTexCoord1iv glMultiTexCoord1iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1ivARB(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
            internal unsafe static MultiTexCoord1ivARB glMultiTexCoord1ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1s(Pencil.Gaming.Graphics.TextureUnit target,Int16 s);
            internal static MultiTexCoord1s glMultiTexCoord1s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord1sARB(Pencil.Gaming.Graphics.TextureUnit target,Int16 s);
            internal static MultiTexCoord1sARB glMultiTexCoord1sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1sv(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
            internal unsafe static MultiTexCoord1sv glMultiTexCoord1sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord1svARB(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
            internal unsafe static MultiTexCoord1svARB glMultiTexCoord1svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2d(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t);
            internal static MultiTexCoord2d glMultiTexCoord2d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2dARB(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t);
            internal static MultiTexCoord2dARB glMultiTexCoord2dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2dv(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
            internal unsafe static MultiTexCoord2dv glMultiTexCoord2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2dvARB(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
            internal unsafe static MultiTexCoord2dvARB glMultiTexCoord2dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2f(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t);
            internal static MultiTexCoord2f glMultiTexCoord2f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2fARB(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t);
            internal static MultiTexCoord2fARB glMultiTexCoord2fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2fv(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
            internal unsafe static MultiTexCoord2fv glMultiTexCoord2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2fvARB(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
            internal unsafe static MultiTexCoord2fvARB glMultiTexCoord2fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2i(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t);
            internal static MultiTexCoord2i glMultiTexCoord2i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2iARB(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t);
            internal static MultiTexCoord2iARB glMultiTexCoord2iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2iv(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
            internal unsafe static MultiTexCoord2iv glMultiTexCoord2iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2ivARB(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
            internal unsafe static MultiTexCoord2ivARB glMultiTexCoord2ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2s(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t);
            internal static MultiTexCoord2s glMultiTexCoord2s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord2sARB(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t);
            internal static MultiTexCoord2sARB glMultiTexCoord2sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2sv(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
            internal unsafe static MultiTexCoord2sv glMultiTexCoord2sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord2svARB(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
            internal unsafe static MultiTexCoord2svARB glMultiTexCoord2svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3d(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t,Double r);
            internal static MultiTexCoord3d glMultiTexCoord3d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3dARB(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t,Double r);
            internal static MultiTexCoord3dARB glMultiTexCoord3dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3dv(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
            internal unsafe static MultiTexCoord3dv glMultiTexCoord3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3dvARB(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
            internal unsafe static MultiTexCoord3dvARB glMultiTexCoord3dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3f(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t,Single r);
            internal static MultiTexCoord3f glMultiTexCoord3f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3fARB(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t,Single r);
            internal static MultiTexCoord3fARB glMultiTexCoord3fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3fv(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
            internal unsafe static MultiTexCoord3fv glMultiTexCoord3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3fvARB(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
            internal unsafe static MultiTexCoord3fvARB glMultiTexCoord3fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3i(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t,Int32 r);
            internal static MultiTexCoord3i glMultiTexCoord3i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3iARB(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t,Int32 r);
            internal static MultiTexCoord3iARB glMultiTexCoord3iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3iv(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
            internal unsafe static MultiTexCoord3iv glMultiTexCoord3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3ivARB(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
            internal unsafe static MultiTexCoord3ivARB glMultiTexCoord3ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3s(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t,Int16 r);
            internal static MultiTexCoord3s glMultiTexCoord3s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord3sARB(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t,Int16 r);
            internal static MultiTexCoord3sARB glMultiTexCoord3sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3sv(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
            internal unsafe static MultiTexCoord3sv glMultiTexCoord3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord3svARB(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
            internal unsafe static MultiTexCoord3svARB glMultiTexCoord3svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4d(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t,Double r,Double q);
            internal static MultiTexCoord4d glMultiTexCoord4d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4dARB(Pencil.Gaming.Graphics.TextureUnit target,Double s,Double t,Double r,Double q);
            internal static MultiTexCoord4dARB glMultiTexCoord4dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4dv(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
            internal unsafe static MultiTexCoord4dv glMultiTexCoord4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4dvARB(Pencil.Gaming.Graphics.TextureUnit target,Double* v);
            internal unsafe static MultiTexCoord4dvARB glMultiTexCoord4dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4f(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t,Single r,Single q);
            internal static MultiTexCoord4f glMultiTexCoord4f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4fARB(Pencil.Gaming.Graphics.TextureUnit target,Single s,Single t,Single r,Single q);
            internal static MultiTexCoord4fARB glMultiTexCoord4fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4fv(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
            internal unsafe static MultiTexCoord4fv glMultiTexCoord4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4fvARB(Pencil.Gaming.Graphics.TextureUnit target,Single* v);
            internal unsafe static MultiTexCoord4fvARB glMultiTexCoord4fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4i(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t,Int32 r,Int32 q);
            internal static MultiTexCoord4i glMultiTexCoord4i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4iARB(Pencil.Gaming.Graphics.TextureUnit target,Int32 s,Int32 t,Int32 r,Int32 q);
            internal static MultiTexCoord4iARB glMultiTexCoord4iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4iv(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
            internal unsafe static MultiTexCoord4iv glMultiTexCoord4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4ivARB(Pencil.Gaming.Graphics.TextureUnit target,Int32* v);
            internal unsafe static MultiTexCoord4ivARB glMultiTexCoord4ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4s(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t,Int16 r,Int16 q);
            internal static MultiTexCoord4s glMultiTexCoord4s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoord4sARB(Pencil.Gaming.Graphics.TextureUnit target,Int16 s,Int16 t,Int16 r,Int16 q);
            internal static MultiTexCoord4sARB glMultiTexCoord4sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4sv(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
            internal unsafe static MultiTexCoord4sv glMultiTexCoord4sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoord4svARB(Pencil.Gaming.Graphics.TextureUnit target,Int16* v);
            internal unsafe static MultiTexCoord4svARB glMultiTexCoord4svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP1ui(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static MultiTexCoordP1ui glMultiTexCoordP1ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP1uiv(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static MultiTexCoordP1uiv glMultiTexCoordP1uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP2ui(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static MultiTexCoordP2ui glMultiTexCoordP2ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP2uiv(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static MultiTexCoordP2uiv glMultiTexCoordP2uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP3ui(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static MultiTexCoordP3ui glMultiTexCoordP3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP3uiv(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static MultiTexCoordP3uiv glMultiTexCoordP3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordP4ui(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static MultiTexCoordP4ui glMultiTexCoordP4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexCoordP4uiv(Pencil.Gaming.Graphics.TextureUnit texture,Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static MultiTexCoordP4uiv glMultiTexCoordP4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexCoordPointerEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Int32 size,Pencil.Gaming.Graphics.TexCoordPointerType type,Int32 stride,IntPtr pointer);
            internal static MultiTexCoordPointerEXT glMultiTexCoordPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexEnvfEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Single param);
            internal static MultiTexEnvfEXT glMultiTexEnvfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexEnvfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Single* @params);
            internal unsafe static MultiTexEnvfvEXT glMultiTexEnvfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexEnviEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Int32 param);
            internal static MultiTexEnviEXT glMultiTexEnviEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexEnvivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Int32* @params);
            internal unsafe static MultiTexEnvivEXT glMultiTexEnvivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexGendEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Double param);
            internal static MultiTexGendEXT glMultiTexGendEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexGendvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Double* @params);
            internal unsafe static MultiTexGendvEXT glMultiTexGendvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexGenfEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Single param);
            internal static MultiTexGenfEXT glMultiTexGenfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexGenfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Single* @params);
            internal unsafe static MultiTexGenfvEXT glMultiTexGenfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexGeniEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Int32 param);
            internal static MultiTexGeniEXT glMultiTexGeniEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexGenivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Int32* @params);
            internal unsafe static MultiTexGenivEXT glMultiTexGenivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static MultiTexImage1DEXT glMultiTexImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 height,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static MultiTexImage2DEXT glMultiTexImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static MultiTexImage3DEXT glMultiTexImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexParameterfEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Single param);
            internal static MultiTexParameterfEXT glMultiTexParameterfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexParameterfvEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Single* @params);
            internal unsafe static MultiTexParameterfvEXT glMultiTexParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexParameteriEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32 param);
            internal static MultiTexParameteriEXT glMultiTexParameteriEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexParameterIivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
            internal unsafe static MultiTexParameterIivEXT glMultiTexParameterIivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexParameterIuivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,UInt32* @params);
            internal unsafe static MultiTexParameterIuivEXT glMultiTexParameterIuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultiTexParameterivEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
            internal unsafe static MultiTexParameterivEXT glMultiTexParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexRenderbufferEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,UInt32 renderbuffer);
            internal static MultiTexRenderbufferEXT glMultiTexRenderbufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexSubImage1DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static MultiTexSubImage1DEXT glMultiTexSubImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexSubImage2DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static MultiTexSubImage2DEXT glMultiTexSubImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void MultiTexSubImage3DEXT(Pencil.Gaming.Graphics.TextureUnit texunit,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static MultiTexSubImage3DEXT glMultiTexSubImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixd(Double* m);
            internal unsafe static MultMatrixd glMultMatrixd;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultMatrixf(Single* m);
            internal unsafe static MultMatrixf glMultMatrixf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixd(Double* m);
            internal unsafe static MultTransposeMatrixd glMultTransposeMatrixd;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixdARB(Double* m);
            internal unsafe static MultTransposeMatrixdARB glMultTransposeMatrixdARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixf(Single* m);
            internal unsafe static MultTransposeMatrixf glMultTransposeMatrixf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void MultTransposeMatrixfARB(Single* m);
            internal unsafe static MultTransposeMatrixfARB glMultTransposeMatrixfARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedBufferDataEXT(UInt32 buffer,IntPtr size,IntPtr data,Pencil.Gaming.Graphics.ExtDirectStateAccess usage);
            internal static NamedBufferDataEXT glNamedBufferDataEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedBufferSubDataEXT(UInt32 buffer,IntPtr offset,IntPtr size,IntPtr data);
            internal static NamedBufferSubDataEXT glNamedBufferSubDataEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedCopyBufferSubDataEXT(UInt32 readBuffer,UInt32 writeBuffer,IntPtr readOffset,IntPtr writeOffset,IntPtr size);
            internal static NamedCopyBufferSubDataEXT glNamedCopyBufferSubDataEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferRenderbufferEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.RenderbufferTarget renderbuffertarget,UInt32 renderbuffer);
            internal static NamedFramebufferRenderbufferEXT glNamedFramebufferRenderbufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTexture1DEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level);
            internal static NamedFramebufferTexture1DEXT glNamedFramebufferTexture1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTexture2DEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level);
            internal static NamedFramebufferTexture2DEXT glNamedFramebufferTexture2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTexture3DEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferAttachment attachment,Pencil.Gaming.Graphics.TextureTarget textarget,UInt32 texture,Int32 level,Int32 zoffset);
            internal static NamedFramebufferTexture3DEXT glNamedFramebufferTexture3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTextureEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level);
            internal static NamedFramebufferTextureEXT glNamedFramebufferTextureEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTextureFaceEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level,Pencil.Gaming.Graphics.TextureTarget face);
            internal static NamedFramebufferTextureFaceEXT glNamedFramebufferTextureFaceEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedFramebufferTextureLayerEXT(UInt32 framebuffer,Pencil.Gaming.Graphics.FramebufferAttachment attachment,UInt32 texture,Int32 level,Int32 layer);
            internal static NamedFramebufferTextureLayerEXT glNamedFramebufferTextureLayerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramLocalParameter4dEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Double x,Double y,Double z,Double w);
            internal static NamedProgramLocalParameter4dEXT glNamedProgramLocalParameter4dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameter4dvEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Double* @params);
            internal unsafe static NamedProgramLocalParameter4dvEXT glNamedProgramLocalParameter4dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramLocalParameter4fEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Single x,Single y,Single z,Single w);
            internal static NamedProgramLocalParameter4fEXT glNamedProgramLocalParameter4fEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameter4fvEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Single* @params);
            internal unsafe static NamedProgramLocalParameter4fvEXT glNamedProgramLocalParameter4fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramLocalParameterI4iEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Int32 x,Int32 y,Int32 z,Int32 w);
            internal static NamedProgramLocalParameterI4iEXT glNamedProgramLocalParameterI4iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameterI4ivEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Int32* @params);
            internal unsafe static NamedProgramLocalParameterI4ivEXT glNamedProgramLocalParameterI4ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramLocalParameterI4uiEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,UInt32 x,UInt32 y,UInt32 z,UInt32 w);
            internal static NamedProgramLocalParameterI4uiEXT glNamedProgramLocalParameterI4uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameterI4uivEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,UInt32* @params);
            internal unsafe static NamedProgramLocalParameterI4uivEXT glNamedProgramLocalParameterI4uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParameters4fvEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Int32 count,Single* @params);
            internal unsafe static NamedProgramLocalParameters4fvEXT glNamedProgramLocalParameters4fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParametersI4ivEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Int32 count,Int32* @params);
            internal unsafe static NamedProgramLocalParametersI4ivEXT glNamedProgramLocalParametersI4ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NamedProgramLocalParametersI4uivEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,UInt32 index,Int32 count,UInt32* @params);
            internal unsafe static NamedProgramLocalParametersI4uivEXT glNamedProgramLocalParametersI4uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedProgramStringEXT(UInt32 program,Pencil.Gaming.Graphics.ExtDirectStateAccess target,Pencil.Gaming.Graphics.ExtDirectStateAccess format,Int32 len,IntPtr @string);
            internal static NamedProgramStringEXT glNamedProgramStringEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedRenderbufferStorageEXT(UInt32 renderbuffer,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height);
            internal static NamedRenderbufferStorageEXT glNamedRenderbufferStorageEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedRenderbufferStorageMultisampleCoverageEXT(UInt32 renderbuffer,Int32 coverageSamples,Int32 colorSamples,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height);
            internal static NamedRenderbufferStorageMultisampleCoverageEXT glNamedRenderbufferStorageMultisampleCoverageEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedRenderbufferStorageMultisampleEXT(UInt32 renderbuffer,Int32 samples,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height);
            internal static NamedRenderbufferStorageMultisampleEXT glNamedRenderbufferStorageMultisampleEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NamedStringARB(Pencil.Gaming.Graphics.ArbShadingLanguageInclude type,Int32 namelen,String name,Int32 stringlen,String @string);
            internal static NamedStringARB glNamedStringARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NewList(UInt32 list,Pencil.Gaming.Graphics.ListMode mode);
            internal static NewList glNewList;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 NewObjectBufferATI(Int32 size,IntPtr pointer,Pencil.Gaming.Graphics.AtiVertexArrayObject usage);
            internal static NewObjectBufferATI glNewObjectBufferATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3b(SByte nx,SByte ny,SByte nz);
            internal static Normal3b glNormal3b;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3bv(SByte* v);
            internal unsafe static Normal3bv glNormal3bv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3d(Double nx,Double ny,Double nz);
            internal static Normal3d glNormal3d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3dv(Double* v);
            internal unsafe static Normal3dv glNormal3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3f(Single nx,Single ny,Single nz);
            internal static Normal3f glNormal3f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3fv(Single* v);
            internal unsafe static Normal3fv glNormal3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3fVertex3fSUN(Single nx,Single ny,Single nz,Single x,Single y,Single z);
            internal static Normal3fVertex3fSUN glNormal3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3fVertex3fvSUN(Single* n,Single* v);
            internal unsafe static Normal3fVertex3fvSUN glNormal3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3i(Int32 nx,Int32 ny,Int32 nz);
            internal static Normal3i glNormal3i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3iv(Int32* v);
            internal unsafe static Normal3iv glNormal3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Normal3s(Int16 nx,Int16 ny,Int16 nz);
            internal static Normal3s glNormal3s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Normal3sv(Int16* v);
            internal unsafe static Normal3sv glNormal3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalFormatNV(Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,Int32 stride);
            internal static NormalFormatNV glNormalFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static NormalP3ui glNormalP3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static NormalP3uiv glNormalP3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointer(Pencil.Gaming.Graphics.NormalPointerType type,Int32 stride,IntPtr pointer);
            internal static NormalPointer glNormalPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointerEXT(Pencil.Gaming.Graphics.NormalPointerType type,Int32 stride,Int32 count,IntPtr pointer);
            internal static NormalPointerEXT glNormalPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointerListIBM(Pencil.Gaming.Graphics.NormalPointerType type,Int32 stride,IntPtr pointer,Int32 ptrstride);
            internal static NormalPointerListIBM glNormalPointerListIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalPointervINTEL(Pencil.Gaming.Graphics.NormalPointerType type,IntPtr pointer);
            internal static NormalPointervINTEL glNormalPointervINTEL;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3bATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,SByte nx,SByte ny,SByte nz);
            internal static NormalStream3bATI glNormalStream3bATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3bvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,SByte* coords);
            internal unsafe static NormalStream3bvATI glNormalStream3bvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double nx,Double ny,Double nz);
            internal static NormalStream3dATI glNormalStream3dATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double* coords);
            internal unsafe static NormalStream3dvATI glNormalStream3dvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single nx,Single ny,Single nz);
            internal static NormalStream3fATI glNormalStream3fATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single* coords);
            internal unsafe static NormalStream3fvATI glNormalStream3fvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32 nx,Int32 ny,Int32 nz);
            internal static NormalStream3iATI glNormalStream3iATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32* coords);
            internal unsafe static NormalStream3ivATI glNormalStream3ivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void NormalStream3sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16 nx,Int16 ny,Int16 nz);
            internal static NormalStream3sATI glNormalStream3sATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void NormalStream3svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16* coords);
            internal unsafe static NormalStream3svATI glNormalStream3svATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Pencil.Gaming.Graphics.AppleObjectPurgeable ObjectPurgeableAPPLE(Pencil.Gaming.Graphics.AppleObjectPurgeable objectType,UInt32 name,Pencil.Gaming.Graphics.AppleObjectPurgeable option);
            internal static ObjectPurgeableAPPLE glObjectPurgeableAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Pencil.Gaming.Graphics.AppleObjectPurgeable ObjectUnpurgeableAPPLE(Pencil.Gaming.Graphics.AppleObjectPurgeable objectType,UInt32 name,Pencil.Gaming.Graphics.AppleObjectPurgeable option);
            internal static ObjectUnpurgeableAPPLE glObjectUnpurgeableAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Ortho(Double left,Double right,Double bottom,Double top,Double zNear,Double zFar);
            internal static Ortho glOrtho;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PassTexCoordATI(UInt32 dst,UInt32 coord,Pencil.Gaming.Graphics.AtiFragmentShader swizzle);
            internal static PassTexCoordATI glPassTexCoordATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PassThrough(Single token);
            internal static PassThrough glPassThrough;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PatchParameterfv(Pencil.Gaming.Graphics.PatchParameterFloat pname,Single* values);
            internal unsafe static PatchParameterfv glPatchParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PatchParameteri(Pencil.Gaming.Graphics.PatchParameterInt pname,Int32 value);
            internal static PatchParameteri glPatchParameteri;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PauseTransformFeedback();
            internal static PauseTransformFeedback glPauseTransformFeedback;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PauseTransformFeedbackNV();
            internal static PauseTransformFeedbackNV glPauseTransformFeedbackNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelDataRangeNV(Pencil.Gaming.Graphics.NvPixelDataRange target,Int32 length,[OutAttribute] IntPtr pointer);
            internal static PixelDataRangeNV glPixelDataRangeNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapfv(Pencil.Gaming.Graphics.PixelMap map,Int32 mapsize,Single* values);
            internal unsafe static PixelMapfv glPixelMapfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapuiv(Pencil.Gaming.Graphics.PixelMap map,Int32 mapsize,UInt32* values);
            internal unsafe static PixelMapuiv glPixelMapuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelMapusv(Pencil.Gaming.Graphics.PixelMap map,Int32 mapsize,UInt16* values);
            internal unsafe static PixelMapusv glPixelMapusv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStoref(Pencil.Gaming.Graphics.PixelStoreParameter pname,Single param);
            internal static PixelStoref glPixelStoref;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelStorei(Pencil.Gaming.Graphics.PixelStoreParameter pname,Int32 param);
            internal static PixelStorei glPixelStorei;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenParameterfSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname,Single param);
            internal static PixelTexGenParameterfSGIS glPixelTexGenParameterfSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTexGenParameterfvSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname,Single* @params);
            internal unsafe static PixelTexGenParameterfvSGIS glPixelTexGenParameterfvSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenParameteriSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname,Int32 param);
            internal static PixelTexGenParameteriSGIS glPixelTexGenParameteriSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTexGenParameterivSGIS(Pencil.Gaming.Graphics.SgisPixelTexture pname,Int32* @params);
            internal unsafe static PixelTexGenParameterivSGIS glPixelTexGenParameterivSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTexGenSGIX(Pencil.Gaming.Graphics.SgixPixelTexture mode);
            internal static PixelTexGenSGIX glPixelTexGenSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferf(Pencil.Gaming.Graphics.PixelTransferParameter pname,Single param);
            internal static PixelTransferf glPixelTransferf;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransferi(Pencil.Gaming.Graphics.PixelTransferParameter pname,Int32 param);
            internal static PixelTransferi glPixelTransferi;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransformParameterfEXT(Pencil.Gaming.Graphics.ExtPixelTransform target,Pencil.Gaming.Graphics.ExtPixelTransform pname,Single param);
            internal static PixelTransformParameterfEXT glPixelTransformParameterfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTransformParameterfvEXT(Pencil.Gaming.Graphics.ExtPixelTransform target,Pencil.Gaming.Graphics.ExtPixelTransform pname,Single* @params);
            internal unsafe static PixelTransformParameterfvEXT glPixelTransformParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelTransformParameteriEXT(Pencil.Gaming.Graphics.ExtPixelTransform target,Pencil.Gaming.Graphics.ExtPixelTransform pname,Int32 param);
            internal static PixelTransformParameteriEXT glPixelTransformParameteriEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PixelTransformParameterivEXT(Pencil.Gaming.Graphics.ExtPixelTransform target,Pencil.Gaming.Graphics.ExtPixelTransform pname,Int32* @params);
            internal unsafe static PixelTransformParameterivEXT glPixelTransformParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PixelZoom(Single xfactor,Single yfactor);
            internal static PixelZoom glPixelZoom;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PNTrianglesfATI(Pencil.Gaming.Graphics.AtiPnTriangles pname,Single param);
            internal static PNTrianglesfATI glPNTrianglesfATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PNTrianglesiATI(Pencil.Gaming.Graphics.AtiPnTriangles pname,Int32 param);
            internal static PNTrianglesiATI glPNTrianglesiATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterf(Pencil.Gaming.Graphics.PointParameterName pname,Single param);
            internal static PointParameterf glPointParameterf;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfARB(Pencil.Gaming.Graphics.ArbPointParameters pname,Single param);
            internal static PointParameterfARB glPointParameterfARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfEXT(Pencil.Gaming.Graphics.ExtPointParameters pname,Single param);
            internal static PointParameterfEXT glPointParameterfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameterfSGIS(Pencil.Gaming.Graphics.SgisPointParameters pname,Single param);
            internal static PointParameterfSGIS glPointParameterfSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfv(Pencil.Gaming.Graphics.PointParameterName pname,Single* @params);
            internal unsafe static PointParameterfv glPointParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvARB(Pencil.Gaming.Graphics.ArbPointParameters pname,Single* @params);
            internal unsafe static PointParameterfvARB glPointParameterfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvEXT(Pencil.Gaming.Graphics.ExtPointParameters pname,Single* @params);
            internal unsafe static PointParameterfvEXT glPointParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterfvSGIS(Pencil.Gaming.Graphics.SgisPointParameters pname,Single* @params);
            internal unsafe static PointParameterfvSGIS glPointParameterfvSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteri(Pencil.Gaming.Graphics.PointParameterName pname,Int32 param);
            internal static PointParameteri glPointParameteri;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PointParameteriNV(Pencil.Gaming.Graphics.NvPointSprite pname,Int32 param);
            internal static PointParameteriNV glPointParameteriNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameteriv(Pencil.Gaming.Graphics.PointParameterName pname,Int32* @params);
            internal unsafe static PointParameteriv glPointParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PointParameterivNV(Pencil.Gaming.Graphics.NvPointSprite pname,Int32* @params);
            internal unsafe static PointParameterivNV glPointParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PointSize(Single size);
            internal static PointSize glPointSize;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 PollAsyncSGIX([OutAttribute] UInt32* markerp);
            internal unsafe static PollAsyncSGIX glPollAsyncSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Int32 PollInstrumentsSGIX([OutAttribute] Int32* marker_p);
            internal unsafe static PollInstrumentsSGIX glPollInstrumentsSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonMode(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.PolygonMode mode);
            internal static PolygonMode glPolygonMode;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffset(Single factor,Single units);
            internal static PolygonOffset glPolygonOffset;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PolygonOffsetEXT(Single factor,Single bias);
            internal static PolygonOffsetEXT glPolygonOffsetEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PolygonStipple(Byte* mask);
            internal unsafe static PolygonStipple glPolygonStipple;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PopAttrib();
            internal static PopAttrib glPopAttrib;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PopClientAttrib();
            internal static PopClientAttrib glPopClientAttrib;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PopMatrix();
            internal static PopMatrix glPopMatrix;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PopName();
            internal static PopName glPopName;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PresentFrameDualFillNV(UInt32 video_slot,UInt64 minPresentTime,UInt32 beginPresentTimeId,UInt32 presentDurationId,Pencil.Gaming.Graphics.NvPresentVideo type,Pencil.Gaming.Graphics.NvPresentVideo target0,UInt32 fill0,Pencil.Gaming.Graphics.NvPresentVideo target1,UInt32 fill1,Pencil.Gaming.Graphics.NvPresentVideo target2,UInt32 fill2,Pencil.Gaming.Graphics.NvPresentVideo target3,UInt32 fill3);
            internal static PresentFrameDualFillNV glPresentFrameDualFillNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PresentFrameKeyedNV(UInt32 video_slot,UInt64 minPresentTime,UInt32 beginPresentTimeId,UInt32 presentDurationId,Pencil.Gaming.Graphics.NvPresentVideo type,Pencil.Gaming.Graphics.NvPresentVideo target0,UInt32 fill0,UInt32 key0,Pencil.Gaming.Graphics.NvPresentVideo target1,UInt32 fill1,UInt32 key1);
            internal static PresentFrameKeyedNV glPresentFrameKeyedNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartIndex(UInt32 index);
            internal static PrimitiveRestartIndex glPrimitiveRestartIndex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartIndexNV(UInt32 index);
            internal static PrimitiveRestartIndexNV glPrimitiveRestartIndexNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PrimitiveRestartNV();
            internal static PrimitiveRestartNV glPrimitiveRestartNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTextures(Int32 n,UInt32* textures,Single* priorities);
            internal unsafe static PrioritizeTextures glPrioritizeTextures;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void PrioritizeTexturesEXT(Int32 n,UInt32* textures,Single* priorities);
            internal unsafe static PrioritizeTexturesEXT glPrioritizeTexturesEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramBinary(UInt32 program,Pencil.Gaming.Graphics.BinaryFormat binaryFormat,IntPtr binary,Int32 length);
            internal static ProgramBinary glProgramBinary;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersfvNV(Pencil.Gaming.Graphics.NvParameterBufferObject target,UInt32 buffer,UInt32 index,Int32 count,Single* @params);
            internal unsafe static ProgramBufferParametersfvNV glProgramBufferParametersfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersIivNV(Pencil.Gaming.Graphics.NvParameterBufferObject target,UInt32 buffer,UInt32 index,Int32 count,Int32* @params);
            internal unsafe static ProgramBufferParametersIivNV glProgramBufferParametersIivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramBufferParametersIuivNV(Pencil.Gaming.Graphics.NvParameterBufferObject target,UInt32 buffer,UInt32 index,Int32 count,UInt32* @params);
            internal unsafe static ProgramBufferParametersIuivNV glProgramBufferParametersIuivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameter4dARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Double x,Double y,Double z,Double w);
            internal static ProgramEnvParameter4dARB glProgramEnvParameter4dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameter4dvARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Double* @params);
            internal unsafe static ProgramEnvParameter4dvARB glProgramEnvParameter4dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameter4fARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Single x,Single y,Single z,Single w);
            internal static ProgramEnvParameter4fARB glProgramEnvParameter4fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameter4fvARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Single* @params);
            internal unsafe static ProgramEnvParameter4fvARB glProgramEnvParameter4fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameterI4iNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,Int32 x,Int32 y,Int32 z,Int32 w);
            internal static ProgramEnvParameterI4iNV glProgramEnvParameterI4iNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameterI4ivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,Int32* @params);
            internal unsafe static ProgramEnvParameterI4ivNV glProgramEnvParameterI4ivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramEnvParameterI4uiNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,UInt32 x,UInt32 y,UInt32 z,UInt32 w);
            internal static ProgramEnvParameterI4uiNV glProgramEnvParameterI4uiNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameterI4uivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,UInt32* @params);
            internal unsafe static ProgramEnvParameterI4uivNV glProgramEnvParameterI4uivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParameters4fvEXT(Pencil.Gaming.Graphics.ExtGpuProgramParameters target,UInt32 index,Int32 count,Single* @params);
            internal unsafe static ProgramEnvParameters4fvEXT glProgramEnvParameters4fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParametersI4ivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,Int32 count,Int32* @params);
            internal unsafe static ProgramEnvParametersI4ivNV glProgramEnvParametersI4ivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramEnvParametersI4uivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,Int32 count,UInt32* @params);
            internal unsafe static ProgramEnvParametersI4uivNV glProgramEnvParametersI4uivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameter4dARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Double x,Double y,Double z,Double w);
            internal static ProgramLocalParameter4dARB glProgramLocalParameter4dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameter4dvARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Double* @params);
            internal unsafe static ProgramLocalParameter4dvARB glProgramLocalParameter4dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameter4fARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Single x,Single y,Single z,Single w);
            internal static ProgramLocalParameter4fARB glProgramLocalParameter4fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameter4fvARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Single* @params);
            internal unsafe static ProgramLocalParameter4fvARB glProgramLocalParameter4fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameterI4iNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,Int32 x,Int32 y,Int32 z,Int32 w);
            internal static ProgramLocalParameterI4iNV glProgramLocalParameterI4iNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameterI4ivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,Int32* @params);
            internal unsafe static ProgramLocalParameterI4ivNV glProgramLocalParameterI4ivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramLocalParameterI4uiNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,UInt32 x,UInt32 y,UInt32 z,UInt32 w);
            internal static ProgramLocalParameterI4uiNV glProgramLocalParameterI4uiNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameterI4uivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,UInt32* @params);
            internal unsafe static ProgramLocalParameterI4uivNV glProgramLocalParameterI4uivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParameters4fvEXT(Pencil.Gaming.Graphics.ExtGpuProgramParameters target,UInt32 index,Int32 count,Single* @params);
            internal unsafe static ProgramLocalParameters4fvEXT glProgramLocalParameters4fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParametersI4ivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,Int32 count,Int32* @params);
            internal unsafe static ProgramLocalParametersI4ivNV glProgramLocalParametersI4ivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramLocalParametersI4uivNV(Pencil.Gaming.Graphics.NvGpuProgram4 target,UInt32 index,Int32 count,UInt32* @params);
            internal unsafe static ProgramLocalParametersI4uivNV glProgramLocalParametersI4uivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4dNV(UInt32 id,Int32 len,Byte* name,Double x,Double y,Double z,Double w);
            internal unsafe static ProgramNamedParameter4dNV glProgramNamedParameter4dNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4dvNV(UInt32 id,Int32 len,Byte* name,Double* v);
            internal unsafe static ProgramNamedParameter4dvNV glProgramNamedParameter4dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4fNV(UInt32 id,Int32 len,Byte* name,Single x,Single y,Single z,Single w);
            internal unsafe static ProgramNamedParameter4fNV glProgramNamedParameter4fNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramNamedParameter4fvNV(UInt32 id,Int32 len,Byte* name,Single* v);
            internal unsafe static ProgramNamedParameter4fvNV glProgramNamedParameter4fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameter4dNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Double x,Double y,Double z,Double w);
            internal static ProgramParameter4dNV glProgramParameter4dNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameter4dvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Double* v);
            internal unsafe static ProgramParameter4dvNV glProgramParameter4dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameter4fNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Single x,Single y,Single z,Single w);
            internal static ProgramParameter4fNV glProgramParameter4fNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameter4fvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Single* v);
            internal unsafe static ProgramParameter4fvNV glProgramParameter4fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteri(UInt32 program,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,Int32 value);
            internal static ProgramParameteri glProgramParameteri;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteriARB(UInt32 program,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,Int32 value);
            internal static ProgramParameteriARB glProgramParameteriARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramParameteriEXT(UInt32 program,Pencil.Gaming.Graphics.AssemblyProgramParameterArb pname,Int32 value);
            internal static ProgramParameteriEXT glProgramParameteriEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameters4dvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Int32 count,Double* v);
            internal unsafe static ProgramParameters4dvNV glProgramParameters4dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramParameters4fvNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 index,Int32 count,Single* v);
            internal unsafe static ProgramParameters4fvNV glProgramParameters4fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramStringARB(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,Pencil.Gaming.Graphics.ArbVertexProgram format,Int32 len,IntPtr @string);
            internal static ProgramStringARB glProgramStringARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramSubroutineParametersuivNV(Pencil.Gaming.Graphics.NvGpuProgram5 target,Int32 count,UInt32* @params);
            internal unsafe static ProgramSubroutineParametersuivNV glProgramSubroutineParametersuivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1d(UInt32 program,Int32 location,Double v0);
            internal static ProgramUniform1d glProgramUniform1d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1dEXT(UInt32 program,Int32 location,Double x);
            internal static ProgramUniform1dEXT glProgramUniform1dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1dv(UInt32 program,Int32 location,Int32 count,Double* value);
            internal unsafe static ProgramUniform1dv glProgramUniform1dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1dvEXT(UInt32 program,Int32 location,Int32 count,Double* value);
            internal unsafe static ProgramUniform1dvEXT glProgramUniform1dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1f(UInt32 program,Int32 location,Single v0);
            internal static ProgramUniform1f glProgramUniform1f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1fEXT(UInt32 program,Int32 location,Single v0);
            internal static ProgramUniform1fEXT glProgramUniform1fEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1fv(UInt32 program,Int32 location,Int32 count,Single* value);
            internal unsafe static ProgramUniform1fv glProgramUniform1fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1fvEXT(UInt32 program,Int32 location,Int32 count,Single* value);
            internal unsafe static ProgramUniform1fvEXT glProgramUniform1fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1i(UInt32 program,Int32 location,Int32 v0);
            internal static ProgramUniform1i glProgramUniform1i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1i64NV(UInt32 program,Int32 location,Int64 x);
            internal static ProgramUniform1i64NV glProgramUniform1i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1i64vNV(UInt32 program,Int32 location,Int32 count,Int64* value);
            internal unsafe static ProgramUniform1i64vNV glProgramUniform1i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1iEXT(UInt32 program,Int32 location,Int32 v0);
            internal static ProgramUniform1iEXT glProgramUniform1iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1iv(UInt32 program,Int32 location,Int32 count,Int32* value);
            internal unsafe static ProgramUniform1iv glProgramUniform1iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1ivEXT(UInt32 program,Int32 location,Int32 count,Int32* value);
            internal unsafe static ProgramUniform1ivEXT glProgramUniform1ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1ui(UInt32 program,Int32 location,UInt32 v0);
            internal static ProgramUniform1ui glProgramUniform1ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1ui64NV(UInt32 program,Int32 location,UInt64 x);
            internal static ProgramUniform1ui64NV glProgramUniform1ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1ui64vNV(UInt32 program,Int32 location,Int32 count,UInt64* value);
            internal unsafe static ProgramUniform1ui64vNV glProgramUniform1ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform1uiEXT(UInt32 program,Int32 location,UInt32 v0);
            internal static ProgramUniform1uiEXT glProgramUniform1uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1uiv(UInt32 program,Int32 location,Int32 count,UInt32* value);
            internal unsafe static ProgramUniform1uiv glProgramUniform1uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform1uivEXT(UInt32 program,Int32 location,Int32 count,UInt32* value);
            internal unsafe static ProgramUniform1uivEXT glProgramUniform1uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2d(UInt32 program,Int32 location,Double v0,Double v1);
            internal static ProgramUniform2d glProgramUniform2d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2dEXT(UInt32 program,Int32 location,Double x,Double y);
            internal static ProgramUniform2dEXT glProgramUniform2dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2dv(UInt32 program,Int32 location,Int32 count,Double* value);
            internal unsafe static ProgramUniform2dv glProgramUniform2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2dvEXT(UInt32 program,Int32 location,Int32 count,Double* value);
            internal unsafe static ProgramUniform2dvEXT glProgramUniform2dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2f(UInt32 program,Int32 location,Single v0,Single v1);
            internal static ProgramUniform2f glProgramUniform2f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2fEXT(UInt32 program,Int32 location,Single v0,Single v1);
            internal static ProgramUniform2fEXT glProgramUniform2fEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2fv(UInt32 program,Int32 location,Int32 count,Single* value);
            internal unsafe static ProgramUniform2fv glProgramUniform2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2fvEXT(UInt32 program,Int32 location,Int32 count,Single* value);
            internal unsafe static ProgramUniform2fvEXT glProgramUniform2fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2i(UInt32 program,Int32 location,Int32 v0,Int32 v1);
            internal static ProgramUniform2i glProgramUniform2i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2i64NV(UInt32 program,Int32 location,Int64 x,Int64 y);
            internal static ProgramUniform2i64NV glProgramUniform2i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2i64vNV(UInt32 program,Int32 location,Int32 count,Int64* value);
            internal unsafe static ProgramUniform2i64vNV glProgramUniform2i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2iEXT(UInt32 program,Int32 location,Int32 v0,Int32 v1);
            internal static ProgramUniform2iEXT glProgramUniform2iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2iv(UInt32 program,Int32 location,Int32 count,Int32* value);
            internal unsafe static ProgramUniform2iv glProgramUniform2iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2ivEXT(UInt32 program,Int32 location,Int32 count,Int32* value);
            internal unsafe static ProgramUniform2ivEXT glProgramUniform2ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2ui(UInt32 program,Int32 location,UInt32 v0,UInt32 v1);
            internal static ProgramUniform2ui glProgramUniform2ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2ui64NV(UInt32 program,Int32 location,UInt64 x,UInt64 y);
            internal static ProgramUniform2ui64NV glProgramUniform2ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2ui64vNV(UInt32 program,Int32 location,Int32 count,UInt64* value);
            internal unsafe static ProgramUniform2ui64vNV glProgramUniform2ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform2uiEXT(UInt32 program,Int32 location,UInt32 v0,UInt32 v1);
            internal static ProgramUniform2uiEXT glProgramUniform2uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2uiv(UInt32 program,Int32 location,Int32 count,UInt32* value);
            internal unsafe static ProgramUniform2uiv glProgramUniform2uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform2uivEXT(UInt32 program,Int32 location,Int32 count,UInt32* value);
            internal unsafe static ProgramUniform2uivEXT glProgramUniform2uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3d(UInt32 program,Int32 location,Double v0,Double v1,Double v2);
            internal static ProgramUniform3d glProgramUniform3d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3dEXT(UInt32 program,Int32 location,Double x,Double y,Double z);
            internal static ProgramUniform3dEXT glProgramUniform3dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3dv(UInt32 program,Int32 location,Int32 count,Double* value);
            internal unsafe static ProgramUniform3dv glProgramUniform3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3dvEXT(UInt32 program,Int32 location,Int32 count,Double* value);
            internal unsafe static ProgramUniform3dvEXT glProgramUniform3dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3f(UInt32 program,Int32 location,Single v0,Single v1,Single v2);
            internal static ProgramUniform3f glProgramUniform3f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3fEXT(UInt32 program,Int32 location,Single v0,Single v1,Single v2);
            internal static ProgramUniform3fEXT glProgramUniform3fEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3fv(UInt32 program,Int32 location,Int32 count,Single* value);
            internal unsafe static ProgramUniform3fv glProgramUniform3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3fvEXT(UInt32 program,Int32 location,Int32 count,Single* value);
            internal unsafe static ProgramUniform3fvEXT glProgramUniform3fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3i(UInt32 program,Int32 location,Int32 v0,Int32 v1,Int32 v2);
            internal static ProgramUniform3i glProgramUniform3i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3i64NV(UInt32 program,Int32 location,Int64 x,Int64 y,Int64 z);
            internal static ProgramUniform3i64NV glProgramUniform3i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3i64vNV(UInt32 program,Int32 location,Int32 count,Int64* value);
            internal unsafe static ProgramUniform3i64vNV glProgramUniform3i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3iEXT(UInt32 program,Int32 location,Int32 v0,Int32 v1,Int32 v2);
            internal static ProgramUniform3iEXT glProgramUniform3iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3iv(UInt32 program,Int32 location,Int32 count,Int32* value);
            internal unsafe static ProgramUniform3iv glProgramUniform3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3ivEXT(UInt32 program,Int32 location,Int32 count,Int32* value);
            internal unsafe static ProgramUniform3ivEXT glProgramUniform3ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3ui(UInt32 program,Int32 location,UInt32 v0,UInt32 v1,UInt32 v2);
            internal static ProgramUniform3ui glProgramUniform3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3ui64NV(UInt32 program,Int32 location,UInt64 x,UInt64 y,UInt64 z);
            internal static ProgramUniform3ui64NV glProgramUniform3ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3ui64vNV(UInt32 program,Int32 location,Int32 count,UInt64* value);
            internal unsafe static ProgramUniform3ui64vNV glProgramUniform3ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform3uiEXT(UInt32 program,Int32 location,UInt32 v0,UInt32 v1,UInt32 v2);
            internal static ProgramUniform3uiEXT glProgramUniform3uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3uiv(UInt32 program,Int32 location,Int32 count,UInt32* value);
            internal unsafe static ProgramUniform3uiv glProgramUniform3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform3uivEXT(UInt32 program,Int32 location,Int32 count,UInt32* value);
            internal unsafe static ProgramUniform3uivEXT glProgramUniform3uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4d(UInt32 program,Int32 location,Double v0,Double v1,Double v2,Double v3);
            internal static ProgramUniform4d glProgramUniform4d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4dEXT(UInt32 program,Int32 location,Double x,Double y,Double z,Double w);
            internal static ProgramUniform4dEXT glProgramUniform4dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4dv(UInt32 program,Int32 location,Int32 count,Double* value);
            internal unsafe static ProgramUniform4dv glProgramUniform4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4dvEXT(UInt32 program,Int32 location,Int32 count,Double* value);
            internal unsafe static ProgramUniform4dvEXT glProgramUniform4dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4f(UInt32 program,Int32 location,Single v0,Single v1,Single v2,Single v3);
            internal static ProgramUniform4f glProgramUniform4f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4fEXT(UInt32 program,Int32 location,Single v0,Single v1,Single v2,Single v3);
            internal static ProgramUniform4fEXT glProgramUniform4fEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4fv(UInt32 program,Int32 location,Int32 count,Single* value);
            internal unsafe static ProgramUniform4fv glProgramUniform4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4fvEXT(UInt32 program,Int32 location,Int32 count,Single* value);
            internal unsafe static ProgramUniform4fvEXT glProgramUniform4fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4i(UInt32 program,Int32 location,Int32 v0,Int32 v1,Int32 v2,Int32 v3);
            internal static ProgramUniform4i glProgramUniform4i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4i64NV(UInt32 program,Int32 location,Int64 x,Int64 y,Int64 z,Int64 w);
            internal static ProgramUniform4i64NV glProgramUniform4i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4i64vNV(UInt32 program,Int32 location,Int32 count,Int64* value);
            internal unsafe static ProgramUniform4i64vNV glProgramUniform4i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4iEXT(UInt32 program,Int32 location,Int32 v0,Int32 v1,Int32 v2,Int32 v3);
            internal static ProgramUniform4iEXT glProgramUniform4iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4iv(UInt32 program,Int32 location,Int32 count,Int32* value);
            internal unsafe static ProgramUniform4iv glProgramUniform4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4ivEXT(UInt32 program,Int32 location,Int32 count,Int32* value);
            internal unsafe static ProgramUniform4ivEXT glProgramUniform4ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4ui(UInt32 program,Int32 location,UInt32 v0,UInt32 v1,UInt32 v2,UInt32 v3);
            internal static ProgramUniform4ui glProgramUniform4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4ui64NV(UInt32 program,Int32 location,UInt64 x,UInt64 y,UInt64 z,UInt64 w);
            internal static ProgramUniform4ui64NV glProgramUniform4ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4ui64vNV(UInt32 program,Int32 location,Int32 count,UInt64* value);
            internal unsafe static ProgramUniform4ui64vNV glProgramUniform4ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniform4uiEXT(UInt32 program,Int32 location,UInt32 v0,UInt32 v1,UInt32 v2,UInt32 v3);
            internal static ProgramUniform4uiEXT glProgramUniform4uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4uiv(UInt32 program,Int32 location,Int32 count,UInt32* value);
            internal unsafe static ProgramUniform4uiv glProgramUniform4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniform4uivEXT(UInt32 program,Int32 location,Int32 count,UInt32* value);
            internal unsafe static ProgramUniform4uivEXT glProgramUniform4uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix2dv glProgramUniformMatrix2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix2dvEXT glProgramUniformMatrix2dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix2fv glProgramUniformMatrix2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix2fvEXT glProgramUniformMatrix2fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix2x3dv glProgramUniformMatrix2x3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix2x3dvEXT glProgramUniformMatrix2x3dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix2x3fv glProgramUniformMatrix2x3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x3fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix2x3fvEXT glProgramUniformMatrix2x3fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix2x4dv glProgramUniformMatrix2x4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix2x4dvEXT glProgramUniformMatrix2x4dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix2x4fv glProgramUniformMatrix2x4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix2x4fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix2x4fvEXT glProgramUniformMatrix2x4fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix3dv glProgramUniformMatrix3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix3dvEXT glProgramUniformMatrix3dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix3fv glProgramUniformMatrix3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix3fvEXT glProgramUniformMatrix3fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix3x2dv glProgramUniformMatrix3x2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix3x2dvEXT glProgramUniformMatrix3x2dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix3x2fv glProgramUniformMatrix3x2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x2fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix3x2fvEXT glProgramUniformMatrix3x2fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix3x4dv glProgramUniformMatrix3x4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix3x4dvEXT glProgramUniformMatrix3x4dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix3x4fv glProgramUniformMatrix3x4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix3x4fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix3x4fvEXT glProgramUniformMatrix3x4fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix4dv glProgramUniformMatrix4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix4dvEXT glProgramUniformMatrix4dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix4fv glProgramUniformMatrix4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix4fvEXT glProgramUniformMatrix4fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix4x2dv glProgramUniformMatrix4x2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix4x2dvEXT glProgramUniformMatrix4x2dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix4x2fv glProgramUniformMatrix4x2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x2fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix4x2fvEXT glProgramUniformMatrix4x2fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3dv(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix4x3dv glProgramUniformMatrix4x3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3dvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static ProgramUniformMatrix4x3dvEXT glProgramUniformMatrix4x3dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3fv(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix4x3fv glProgramUniformMatrix4x3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformMatrix4x3fvEXT(UInt32 program,Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static ProgramUniformMatrix4x3fvEXT glProgramUniformMatrix4x3fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramUniformui64NV(UInt32 program,Int32 location,UInt64 value);
            internal static ProgramUniformui64NV glProgramUniformui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ProgramUniformui64vNV(UInt32 program,Int32 location,Int32 count,UInt64* value);
            internal unsafe static ProgramUniformui64vNV glProgramUniformui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProgramVertexLimitNV(Pencil.Gaming.Graphics.NvGeometryProgram4 target,Int32 limit);
            internal static ProgramVertexLimitNV glProgramVertexLimitNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProvokingVertex(Pencil.Gaming.Graphics.ProvokingVertexMode mode);
            internal static ProvokingVertex glProvokingVertex;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ProvokingVertexEXT(Pencil.Gaming.Graphics.ExtProvokingVertex mode);
            internal static ProvokingVertexEXT glProvokingVertexEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PushAttrib(Pencil.Gaming.Graphics.AttribMask mask);
            internal static PushAttrib glPushAttrib;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PushClientAttrib(Pencil.Gaming.Graphics.ClientAttribMask mask);
            internal static PushClientAttrib glPushClientAttrib;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PushClientAttribDefaultEXT(Pencil.Gaming.Graphics.ClientAttribMask mask);
            internal static PushClientAttribDefaultEXT glPushClientAttribDefaultEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PushMatrix();
            internal static PushMatrix glPushMatrix;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void PushName(UInt32 name);
            internal static PushName glPushName;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void QueryCounter(UInt32 id,Pencil.Gaming.Graphics.QueryCounterTarget target);
            internal static QueryCounter glQueryCounter;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2d(Double x,Double y);
            internal static RasterPos2d glRasterPos2d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2dv(Double* v);
            internal unsafe static RasterPos2dv glRasterPos2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2f(Single x,Single y);
            internal static RasterPos2f glRasterPos2f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2fv(Single* v);
            internal unsafe static RasterPos2fv glRasterPos2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2i(Int32 x,Int32 y);
            internal static RasterPos2i glRasterPos2i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2iv(Int32* v);
            internal unsafe static RasterPos2iv glRasterPos2iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos2s(Int16 x,Int16 y);
            internal static RasterPos2s glRasterPos2s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos2sv(Int16* v);
            internal unsafe static RasterPos2sv glRasterPos2sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3d(Double x,Double y,Double z);
            internal static RasterPos3d glRasterPos3d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3dv(Double* v);
            internal unsafe static RasterPos3dv glRasterPos3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3f(Single x,Single y,Single z);
            internal static RasterPos3f glRasterPos3f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3fv(Single* v);
            internal unsafe static RasterPos3fv glRasterPos3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3i(Int32 x,Int32 y,Int32 z);
            internal static RasterPos3i glRasterPos3i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3iv(Int32* v);
            internal unsafe static RasterPos3iv glRasterPos3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos3s(Int16 x,Int16 y,Int16 z);
            internal static RasterPos3s glRasterPos3s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos3sv(Int16* v);
            internal unsafe static RasterPos3sv glRasterPos3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4d(Double x,Double y,Double z,Double w);
            internal static RasterPos4d glRasterPos4d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4dv(Double* v);
            internal unsafe static RasterPos4dv glRasterPos4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4f(Single x,Single y,Single z,Single w);
            internal static RasterPos4f glRasterPos4f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4fv(Single* v);
            internal unsafe static RasterPos4fv glRasterPos4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4i(Int32 x,Int32 y,Int32 z,Int32 w);
            internal static RasterPos4i glRasterPos4i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4iv(Int32* v);
            internal unsafe static RasterPos4iv glRasterPos4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RasterPos4s(Int16 x,Int16 y,Int16 z,Int16 w);
            internal static RasterPos4s glRasterPos4s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RasterPos4sv(Int16* v);
            internal unsafe static RasterPos4sv glRasterPos4sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadBuffer(Pencil.Gaming.Graphics.ReadBufferMode mode);
            internal static ReadBuffer glReadBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadInstrumentsSGIX(Int32 marker);
            internal static ReadInstrumentsSGIX glReadInstrumentsSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadnPixelsARB(Int32 x,Int32 y,Int32 width,Int32 height,Pencil.Gaming.Graphics.ArbRobustness format,Pencil.Gaming.Graphics.ArbRobustness type,Int32 bufSize,[OutAttribute] IntPtr data);
            internal static ReadnPixelsARB glReadnPixelsARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReadPixels(Int32 x,Int32 y,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,[OutAttribute] IntPtr pixels);
            internal static ReadPixels glReadPixels;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Rectd(Double x1,Double y1,Double x2,Double y2);
            internal static Rectd glRectd;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectdv(Double* v1,Double* v2);
            internal unsafe static Rectdv glRectdv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Rectf(Single x1,Single y1,Single x2,Single y2);
            internal static Rectf glRectf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectfv(Single* v1,Single* v2);
            internal unsafe static Rectfv glRectfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Recti(Int32 x1,Int32 y1,Int32 x2,Int32 y2);
            internal static Recti glRecti;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectiv(Int32* v1,Int32* v2);
            internal unsafe static Rectiv glRectiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Rects(Int16 x1,Int16 y1,Int16 x2,Int16 y2);
            internal static Rects glRects;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Rectsv(Int16* v1,Int16* v2);
            internal unsafe static Rectsv glRectsv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReferencePlaneSGIX(Double* equation);
            internal unsafe static ReferencePlaneSGIX glReferencePlaneSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReleaseShaderCompiler();
            internal static ReleaseShaderCompiler glReleaseShaderCompiler;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorage(Pencil.Gaming.Graphics.RenderbufferTarget target,Pencil.Gaming.Graphics.RenderbufferStorage internalformat,Int32 width,Int32 height);
            internal static RenderbufferStorage glRenderbufferStorage;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageEXT(Pencil.Gaming.Graphics.RenderbufferTarget target,Pencil.Gaming.Graphics.RenderbufferStorage internalformat,Int32 width,Int32 height);
            internal static RenderbufferStorageEXT glRenderbufferStorageEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisample(Pencil.Gaming.Graphics.RenderbufferTarget target,Int32 samples,Pencil.Gaming.Graphics.RenderbufferStorage internalformat,Int32 width,Int32 height);
            internal static RenderbufferStorageMultisample glRenderbufferStorageMultisample;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleCoverageNV(Pencil.Gaming.Graphics.RenderbufferTarget target,Int32 coverageSamples,Int32 colorSamples,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height);
            internal static RenderbufferStorageMultisampleCoverageNV glRenderbufferStorageMultisampleCoverageNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void RenderbufferStorageMultisampleEXT(Pencil.Gaming.Graphics.ExtFramebufferMultisample target,Int32 samples,Pencil.Gaming.Graphics.ExtFramebufferMultisample internalformat,Int32 width,Int32 height);
            internal static RenderbufferStorageMultisampleEXT glRenderbufferStorageMultisampleEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate Int32 RenderMode(Pencil.Gaming.Graphics.RenderingMode mode);
            internal static RenderMode glRenderMode;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodePointerSUN(Pencil.Gaming.Graphics.SunTriangleList type,Int32 stride,IntPtr pointer);
            internal static ReplacementCodePointerSUN glReplacementCodePointerSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeubSUN(Byte code);
            internal static ReplacementCodeubSUN glReplacementCodeubSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeubvSUN(Byte* code);
            internal unsafe static ReplacementCodeubvSUN glReplacementCodeubvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor3fVertex3fSUN(UInt32 rc,Single r,Single g,Single b,Single x,Single y,Single z);
            internal static ReplacementCodeuiColor3fVertex3fSUN glReplacementCodeuiColor3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor3fVertex3fvSUN(UInt32* rc,Single* c,Single* v);
            internal unsafe static ReplacementCodeuiColor3fVertex3fvSUN glReplacementCodeuiColor3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor4fNormal3fVertex3fSUN(UInt32 rc,Single r,Single g,Single b,Single a,Single nx,Single ny,Single nz,Single x,Single y,Single z);
            internal static ReplacementCodeuiColor4fNormal3fVertex3fSUN glReplacementCodeuiColor4fNormal3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor4fNormal3fVertex3fvSUN(UInt32* rc,Single* c,Single* n,Single* v);
            internal unsafe static ReplacementCodeuiColor4fNormal3fVertex3fvSUN glReplacementCodeuiColor4fNormal3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiColor4ubVertex3fSUN(UInt32 rc,Byte r,Byte g,Byte b,Byte a,Single x,Single y,Single z);
            internal static ReplacementCodeuiColor4ubVertex3fSUN glReplacementCodeuiColor4ubVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiColor4ubVertex3fvSUN(UInt32* rc,Byte* c,Single* v);
            internal unsafe static ReplacementCodeuiColor4ubVertex3fvSUN glReplacementCodeuiColor4ubVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiNormal3fVertex3fSUN(UInt32 rc,Single nx,Single ny,Single nz,Single x,Single y,Single z);
            internal static ReplacementCodeuiNormal3fVertex3fSUN glReplacementCodeuiNormal3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiNormal3fVertex3fvSUN(UInt32* rc,Single* n,Single* v);
            internal unsafe static ReplacementCodeuiNormal3fVertex3fvSUN glReplacementCodeuiNormal3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiSUN(UInt32 code);
            internal static ReplacementCodeuiSUN glReplacementCodeuiSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN(UInt32 rc,Single s,Single t,Single r,Single g,Single b,Single a,Single nx,Single ny,Single nz,Single x,Single y,Single z);
            internal static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN(UInt32* rc,Single* tc,Single* c,Single* n,Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN(UInt32 rc,Single s,Single t,Single nx,Single ny,Single nz,Single x,Single y,Single z);
            internal static ReplacementCodeuiTexCoord2fNormal3fVertex3fSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN(UInt32* rc,Single* tc,Single* n,Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiTexCoord2fVertex3fSUN(UInt32 rc,Single s,Single t,Single x,Single y,Single z);
            internal static ReplacementCodeuiTexCoord2fVertex3fSUN glReplacementCodeuiTexCoord2fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiTexCoord2fVertex3fvSUN(UInt32* rc,Single* tc,Single* v);
            internal unsafe static ReplacementCodeuiTexCoord2fVertex3fvSUN glReplacementCodeuiTexCoord2fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeuiVertex3fSUN(UInt32 rc,Single x,Single y,Single z);
            internal static ReplacementCodeuiVertex3fSUN glReplacementCodeuiVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuiVertex3fvSUN(UInt32* rc,Single* v);
            internal unsafe static ReplacementCodeuiVertex3fvSUN glReplacementCodeuiVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeuivSUN(UInt32* code);
            internal unsafe static ReplacementCodeuivSUN glReplacementCodeuivSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ReplacementCodeusSUN(UInt16 code);
            internal static ReplacementCodeusSUN glReplacementCodeusSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ReplacementCodeusvSUN(UInt16* code);
            internal unsafe static ReplacementCodeusvSUN glReplacementCodeusvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void RequestResidentProgramsNV(Int32 n,UInt32* programs);
            internal unsafe static RequestResidentProgramsNV glRequestResidentProgramsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogram(Pencil.Gaming.Graphics.HistogramTarget target);
            internal static ResetHistogram glResetHistogram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetHistogramEXT(Pencil.Gaming.Graphics.ExtHistogram target);
            internal static ResetHistogramEXT glResetHistogramEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmax(Pencil.Gaming.Graphics.MinmaxTarget target);
            internal static ResetMinmax glResetMinmax;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ResetMinmaxEXT(Pencil.Gaming.Graphics.ExtHistogram target);
            internal static ResetMinmaxEXT glResetMinmaxEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ResizeBuffersMESA();
            internal static ResizeBuffersMESA glResizeBuffersMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ResumeTransformFeedback();
            internal static ResumeTransformFeedback glResumeTransformFeedback;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ResumeTransformFeedbackNV();
            internal static ResumeTransformFeedbackNV glResumeTransformFeedbackNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotated(Double angle,Double x,Double y,Double z);
            internal static Rotated glRotated;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Rotatef(Single angle,Single x,Single y,Single z);
            internal static Rotatef glRotatef;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverage(Single value,bool invert);
            internal static SampleCoverage glSampleCoverage;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleCoverageARB(Single value,bool invert);
            internal static SampleCoverageARB glSampleCoverageARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMapATI(UInt32 dst,UInt32 interp,Pencil.Gaming.Graphics.AtiFragmentShader swizzle);
            internal static SampleMapATI glSampleMapATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskEXT(Single value,bool invert);
            internal static SampleMaskEXT glSampleMaskEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaski(UInt32 index,UInt32 mask);
            internal static SampleMaski glSampleMaski;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskIndexedNV(UInt32 index,UInt32 mask);
            internal static SampleMaskIndexedNV glSampleMaskIndexedNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SampleMaskSGIS(Single value,bool invert);
            internal static SampleMaskSGIS glSampleMaskSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplePatternEXT(Pencil.Gaming.Graphics.ExtMultisample pattern);
            internal static SamplePatternEXT glSamplePatternEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplePatternSGIS(Pencil.Gaming.Graphics.SgisMultisample pattern);
            internal static SamplePatternSGIS glSamplePatternSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplerParameterf(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,Single param);
            internal static SamplerParameterf glSamplerParameterf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterfv(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,Single* param);
            internal unsafe static SamplerParameterfv glSamplerParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SamplerParameteri(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,Int32 param);
            internal static SamplerParameteri glSamplerParameteri;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterIiv(UInt32 sampler,Pencil.Gaming.Graphics.ArbSamplerObjects pname,Int32* param);
            internal unsafe static SamplerParameterIiv glSamplerParameterIiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameterIuiv(UInt32 sampler,Pencil.Gaming.Graphics.ArbSamplerObjects pname,UInt32* param);
            internal unsafe static SamplerParameterIuiv glSamplerParameterIuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SamplerParameteriv(UInt32 sampler,Pencil.Gaming.Graphics.SamplerParameter pname,Int32* param);
            internal unsafe static SamplerParameteriv glSamplerParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Scaled(Double x,Double y,Double z);
            internal static Scaled glScaled;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Scalef(Single x,Single y,Single z);
            internal static Scalef glScalef;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Scissor(Int32 x,Int32 y,Int32 width,Int32 height);
            internal static Scissor glScissor;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ScissorArrayv(UInt32 first,Int32 count,Int32* v);
            internal unsafe static ScissorArrayv glScissorArrayv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ScissorIndexed(UInt32 index,Int32 left,Int32 bottom,Int32 width,Int32 height);
            internal static ScissorIndexed glScissorIndexed;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ScissorIndexedv(UInt32 index,Int32* v);
            internal unsafe static ScissorIndexedv glScissorIndexedv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3b(SByte red,SByte green,SByte blue);
            internal static SecondaryColor3b glSecondaryColor3b;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3bEXT(SByte red,SByte green,SByte blue);
            internal static SecondaryColor3bEXT glSecondaryColor3bEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3bv(SByte* v);
            internal unsafe static SecondaryColor3bv glSecondaryColor3bv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3bvEXT(SByte* v);
            internal unsafe static SecondaryColor3bvEXT glSecondaryColor3bvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3d(Double red,Double green,Double blue);
            internal static SecondaryColor3d glSecondaryColor3d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3dEXT(Double red,Double green,Double blue);
            internal static SecondaryColor3dEXT glSecondaryColor3dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3dv(Double* v);
            internal unsafe static SecondaryColor3dv glSecondaryColor3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3dvEXT(Double* v);
            internal unsafe static SecondaryColor3dvEXT glSecondaryColor3dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3f(Single red,Single green,Single blue);
            internal static SecondaryColor3f glSecondaryColor3f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3fEXT(Single red,Single green,Single blue);
            internal static SecondaryColor3fEXT glSecondaryColor3fEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3fv(Single* v);
            internal unsafe static SecondaryColor3fv glSecondaryColor3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3fvEXT(Single* v);
            internal unsafe static SecondaryColor3fvEXT glSecondaryColor3fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3i(Int32 red,Int32 green,Int32 blue);
            internal static SecondaryColor3i glSecondaryColor3i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3iEXT(Int32 red,Int32 green,Int32 blue);
            internal static SecondaryColor3iEXT glSecondaryColor3iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3iv(Int32* v);
            internal unsafe static SecondaryColor3iv glSecondaryColor3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ivEXT(Int32* v);
            internal unsafe static SecondaryColor3ivEXT glSecondaryColor3ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3s(Int16 red,Int16 green,Int16 blue);
            internal static SecondaryColor3s glSecondaryColor3s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3sEXT(Int16 red,Int16 green,Int16 blue);
            internal static SecondaryColor3sEXT glSecondaryColor3sEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3sv(Int16* v);
            internal unsafe static SecondaryColor3sv glSecondaryColor3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3svEXT(Int16* v);
            internal unsafe static SecondaryColor3svEXT glSecondaryColor3svEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ub(Byte red,Byte green,Byte blue);
            internal static SecondaryColor3ub glSecondaryColor3ub;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ubEXT(Byte red,Byte green,Byte blue);
            internal static SecondaryColor3ubEXT glSecondaryColor3ubEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ubv(Byte* v);
            internal unsafe static SecondaryColor3ubv glSecondaryColor3ubv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3ubvEXT(Byte* v);
            internal unsafe static SecondaryColor3ubvEXT glSecondaryColor3ubvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3ui(UInt32 red,UInt32 green,UInt32 blue);
            internal static SecondaryColor3ui glSecondaryColor3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3uiEXT(UInt32 red,UInt32 green,UInt32 blue);
            internal static SecondaryColor3uiEXT glSecondaryColor3uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3uiv(UInt32* v);
            internal unsafe static SecondaryColor3uiv glSecondaryColor3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3uivEXT(UInt32* v);
            internal unsafe static SecondaryColor3uivEXT glSecondaryColor3uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3us(UInt16 red,UInt16 green,UInt16 blue);
            internal static SecondaryColor3us glSecondaryColor3us;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColor3usEXT(UInt16 red,UInt16 green,UInt16 blue);
            internal static SecondaryColor3usEXT glSecondaryColor3usEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3usv(UInt16* v);
            internal unsafe static SecondaryColor3usv glSecondaryColor3usv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColor3usvEXT(UInt16* v);
            internal unsafe static SecondaryColor3usvEXT glSecondaryColor3usvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorFormatNV(Int32 size,Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,Int32 stride);
            internal static SecondaryColorFormatNV glSecondaryColorFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 color);
            internal static SecondaryColorP3ui glSecondaryColorP3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SecondaryColorP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* color);
            internal unsafe static SecondaryColorP3uiv glSecondaryColorP3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointer(Int32 size,Pencil.Gaming.Graphics.ColorPointerType type,Int32 stride,IntPtr pointer);
            internal static SecondaryColorPointer glSecondaryColorPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointerEXT(Int32 size,Pencil.Gaming.Graphics.ColorPointerType type,Int32 stride,IntPtr pointer);
            internal static SecondaryColorPointerEXT glSecondaryColorPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SecondaryColorPointerListIBM(Int32 size,Pencil.Gaming.Graphics.IbmVertexArrayLists type,Int32 stride,IntPtr pointer,Int32 ptrstride);
            internal static SecondaryColorPointerListIBM glSecondaryColorPointerListIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SelectBuffer(Int32 size,[OutAttribute] UInt32* buffer);
            internal unsafe static SelectBuffer glSelectBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SelectPerfMonitorCountersAMD(UInt32 monitor,bool enable,UInt32 group,Int32 numCounters,[OutAttribute] UInt32* counterList);
            internal unsafe static SelectPerfMonitorCountersAMD glSelectPerfMonitorCountersAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SeparableFilter2D(Pencil.Gaming.Graphics.SeparableTarget target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr row,IntPtr column);
            internal static SeparableFilter2D glSeparableFilter2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SeparableFilter2DEXT(Pencil.Gaming.Graphics.ExtConvolution target,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr row,IntPtr column);
            internal static SeparableFilter2DEXT glSeparableFilter2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceAPPLE(UInt32 fence);
            internal static SetFenceAPPLE glSetFenceAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SetFenceNV(UInt32 fence,Pencil.Gaming.Graphics.NvFence condition);
            internal static SetFenceNV glSetFenceNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SetFragmentShaderConstantATI(UInt32 dst,Single* value);
            internal unsafe static SetFragmentShaderConstantATI glSetFragmentShaderConstantATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SetInvariantEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader type,IntPtr addr);
            internal static SetInvariantEXT glSetInvariantEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SetLocalConstantEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader type,IntPtr addr);
            internal static SetLocalConstantEXT glSetLocalConstantEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SetMultisamplefvAMD(Pencil.Gaming.Graphics.AmdSamplePositions pname,UInt32 index,Single* val);
            internal unsafe static SetMultisamplefvAMD glSetMultisamplefvAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ShadeModel(Pencil.Gaming.Graphics.ShadingModel mode);
            internal static ShadeModel glShadeModel;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderBinary(Int32 count,UInt32* shaders,Pencil.Gaming.Graphics.BinaryFormat binaryformat,IntPtr binary,Int32 length);
            internal unsafe static ShaderBinary glShaderBinary;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp1EXT(Pencil.Gaming.Graphics.ExtVertexShader op,UInt32 res,UInt32 arg1);
            internal static ShaderOp1EXT glShaderOp1EXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp2EXT(Pencil.Gaming.Graphics.ExtVertexShader op,UInt32 res,UInt32 arg1,UInt32 arg2);
            internal static ShaderOp2EXT glShaderOp2EXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ShaderOp3EXT(Pencil.Gaming.Graphics.ExtVertexShader op,UInt32 res,UInt32 arg1,UInt32 arg2,UInt32 arg3);
            internal static ShaderOp3EXT glShaderOp3EXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSource(UInt32 shader,Int32 count,String[] @string,Int32* length);
            internal unsafe static ShaderSource glShaderSource;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ShaderSourceARB(UInt32 shaderObj,Int32 count,String[] @string,Int32* length);
            internal unsafe static ShaderSourceARB glShaderSourceARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SharpenTexFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target,Int32 n,Single* points);
            internal unsafe static SharpenTexFuncSGIS glSharpenTexFuncSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SpriteParameterfSGIX(Pencil.Gaming.Graphics.SgixSprite pname,Single param);
            internal static SpriteParameterfSGIX glSpriteParameterfSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SpriteParameterfvSGIX(Pencil.Gaming.Graphics.SgixSprite pname,Single* @params);
            internal unsafe static SpriteParameterfvSGIX glSpriteParameterfvSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SpriteParameteriSGIX(Pencil.Gaming.Graphics.SgixSprite pname,Int32 param);
            internal static SpriteParameteriSGIX glSpriteParameteriSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void SpriteParameterivSGIX(Pencil.Gaming.Graphics.SgixSprite pname,Int32* @params);
            internal unsafe static SpriteParameterivSGIX glSpriteParameterivSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StartInstrumentsSGIX();
            internal static StartInstrumentsSGIX glStartInstrumentsSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilClearTagEXT(Int32 stencilTagBits,UInt32 stencilClearTag);
            internal static StencilClearTagEXT glStencilClearTagEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFunc(Pencil.Gaming.Graphics.StencilFunction func,Int32 @ref,UInt32 mask);
            internal static StencilFunc glStencilFunc;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparate(Pencil.Gaming.Graphics.Version20 face,Pencil.Gaming.Graphics.StencilFunction func,Int32 @ref,UInt32 mask);
            internal static StencilFuncSeparate glStencilFuncSeparate;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilFuncSeparateATI(Pencil.Gaming.Graphics.StencilFunction frontfunc,Pencil.Gaming.Graphics.StencilFunction backfunc,Int32 @ref,UInt32 mask);
            internal static StencilFuncSeparateATI glStencilFuncSeparateATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMask(UInt32 mask);
            internal static StencilMask glStencilMask;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilMaskSeparate(Pencil.Gaming.Graphics.StencilFace face,UInt32 mask);
            internal static StencilMaskSeparate glStencilMaskSeparate;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOp(Pencil.Gaming.Graphics.StencilOp fail,Pencil.Gaming.Graphics.StencilOp zfail,Pencil.Gaming.Graphics.StencilOp zpass);
            internal static StencilOp glStencilOp;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparate(Pencil.Gaming.Graphics.StencilFace face,Pencil.Gaming.Graphics.StencilOp sfail,Pencil.Gaming.Graphics.StencilOp dpfail,Pencil.Gaming.Graphics.StencilOp dppass);
            internal static StencilOpSeparate glStencilOpSeparate;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StencilOpSeparateATI(Pencil.Gaming.Graphics.AtiSeparateStencil face,Pencil.Gaming.Graphics.StencilOp sfail,Pencil.Gaming.Graphics.StencilOp dpfail,Pencil.Gaming.Graphics.StencilOp dppass);
            internal static StencilOpSeparateATI glStencilOpSeparateATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StopInstrumentsSGIX(Int32 marker);
            internal static StopInstrumentsSGIX glStopInstrumentsSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void StringMarkerGREMEDY(Int32 len,IntPtr @string);
            internal static StringMarkerGREMEDY glStringMarkerGREMEDY;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void SwizzleEXT(UInt32 res,UInt32 @in,Pencil.Gaming.Graphics.ExtVertexShader outX,Pencil.Gaming.Graphics.ExtVertexShader outY,Pencil.Gaming.Graphics.ExtVertexShader outZ,Pencil.Gaming.Graphics.ExtVertexShader outW);
            internal static SwizzleEXT glSwizzleEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TagSampleBufferSGIX();
            internal static TagSampleBufferSGIX glTagSampleBufferSGIX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3bEXT(SByte tx,SByte ty,SByte tz);
            internal static Tangent3bEXT glTangent3bEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3bvEXT(SByte* v);
            internal unsafe static Tangent3bvEXT glTangent3bvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3dEXT(Double tx,Double ty,Double tz);
            internal static Tangent3dEXT glTangent3dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3dvEXT(Double* v);
            internal unsafe static Tangent3dvEXT glTangent3dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3fEXT(Single tx,Single ty,Single tz);
            internal static Tangent3fEXT glTangent3fEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3fvEXT(Single* v);
            internal unsafe static Tangent3fvEXT glTangent3fvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3iEXT(Int32 tx,Int32 ty,Int32 tz);
            internal static Tangent3iEXT glTangent3iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3ivEXT(Int32* v);
            internal unsafe static Tangent3ivEXT glTangent3ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Tangent3sEXT(Int16 tx,Int16 ty,Int16 tz);
            internal static Tangent3sEXT glTangent3sEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Tangent3svEXT(Int16* v);
            internal unsafe static Tangent3svEXT glTangent3svEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TangentPointerEXT(Pencil.Gaming.Graphics.NormalPointerType type,Int32 stride,IntPtr pointer);
            internal static TangentPointerEXT glTangentPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TbufferMask3DFX(UInt32 mask);
            internal static TbufferMask3DFX glTbufferMask3DFX;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TessellationFactorAMD(Single factor);
            internal static TessellationFactorAMD glTessellationFactorAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TessellationModeAMD(Pencil.Gaming.Graphics.AmdVertexShaderTesselator mode);
            internal static TessellationModeAMD glTessellationModeAMD;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool TestFenceAPPLE(UInt32 fence);
            internal static TestFenceAPPLE glTestFenceAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool TestFenceNV(UInt32 fence);
            internal static TestFenceNV glTestFenceNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool TestObjectAPPLE(Pencil.Gaming.Graphics.AppleFence @object,UInt32 name);
            internal static TestObjectAPPLE glTestObjectAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBuffer(Pencil.Gaming.Graphics.TextureBufferTarget target,Pencil.Gaming.Graphics.SizedInternalFormat internalformat,UInt32 buffer);
            internal static TexBuffer glTexBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBufferARB(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.ArbTextureBufferObject internalformat,UInt32 buffer);
            internal static TexBufferARB glTexBufferARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexBufferEXT(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.ExtTextureBufferObject internalformat,UInt32 buffer);
            internal static TexBufferEXT glTexBufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexBumpParameterfvATI(Pencil.Gaming.Graphics.AtiEnvmapBumpmap pname,Single* param);
            internal unsafe static TexBumpParameterfvATI glTexBumpParameterfvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexBumpParameterivATI(Pencil.Gaming.Graphics.AtiEnvmapBumpmap pname,Int32* param);
            internal unsafe static TexBumpParameterivATI glTexBumpParameterivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1d(Double s);
            internal static TexCoord1d glTexCoord1d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1dv(Double* v);
            internal unsafe static TexCoord1dv glTexCoord1dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1f(Single s);
            internal static TexCoord1f glTexCoord1f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1fv(Single* v);
            internal unsafe static TexCoord1fv glTexCoord1fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1i(Int32 s);
            internal static TexCoord1i glTexCoord1i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1iv(Int32* v);
            internal unsafe static TexCoord1iv glTexCoord1iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord1s(Int16 s);
            internal static TexCoord1s glTexCoord1s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord1sv(Int16* v);
            internal unsafe static TexCoord1sv glTexCoord1sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2d(Double s,Double t);
            internal static TexCoord2d glTexCoord2d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2dv(Double* v);
            internal unsafe static TexCoord2dv glTexCoord2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2f(Single s,Single t);
            internal static TexCoord2f glTexCoord2f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor3fVertex3fSUN(Single s,Single t,Single r,Single g,Single b,Single x,Single y,Single z);
            internal static TexCoord2fColor3fVertex3fSUN glTexCoord2fColor3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor3fVertex3fvSUN(Single* tc,Single* c,Single* v);
            internal unsafe static TexCoord2fColor3fVertex3fvSUN glTexCoord2fColor3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor4fNormal3fVertex3fSUN(Single s,Single t,Single r,Single g,Single b,Single a,Single nx,Single ny,Single nz,Single x,Single y,Single z);
            internal static TexCoord2fColor4fNormal3fVertex3fSUN glTexCoord2fColor4fNormal3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor4fNormal3fVertex3fvSUN(Single* tc,Single* c,Single* n,Single* v);
            internal unsafe static TexCoord2fColor4fNormal3fVertex3fvSUN glTexCoord2fColor4fNormal3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fColor4ubVertex3fSUN(Single s,Single t,Byte r,Byte g,Byte b,Byte a,Single x,Single y,Single z);
            internal static TexCoord2fColor4ubVertex3fSUN glTexCoord2fColor4ubVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fColor4ubVertex3fvSUN(Single* tc,Byte* c,Single* v);
            internal unsafe static TexCoord2fColor4ubVertex3fvSUN glTexCoord2fColor4ubVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fNormal3fVertex3fSUN(Single s,Single t,Single nx,Single ny,Single nz,Single x,Single y,Single z);
            internal static TexCoord2fNormal3fVertex3fSUN glTexCoord2fNormal3fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fNormal3fVertex3fvSUN(Single* tc,Single* n,Single* v);
            internal unsafe static TexCoord2fNormal3fVertex3fvSUN glTexCoord2fNormal3fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fv(Single* v);
            internal unsafe static TexCoord2fv glTexCoord2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2fVertex3fSUN(Single s,Single t,Single x,Single y,Single z);
            internal static TexCoord2fVertex3fSUN glTexCoord2fVertex3fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2fVertex3fvSUN(Single* tc,Single* v);
            internal unsafe static TexCoord2fVertex3fvSUN glTexCoord2fVertex3fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2i(Int32 s,Int32 t);
            internal static TexCoord2i glTexCoord2i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2iv(Int32* v);
            internal unsafe static TexCoord2iv glTexCoord2iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord2s(Int16 s,Int16 t);
            internal static TexCoord2s glTexCoord2s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord2sv(Int16* v);
            internal unsafe static TexCoord2sv glTexCoord2sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3d(Double s,Double t,Double r);
            internal static TexCoord3d glTexCoord3d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3dv(Double* v);
            internal unsafe static TexCoord3dv glTexCoord3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3f(Single s,Single t,Single r);
            internal static TexCoord3f glTexCoord3f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3fv(Single* v);
            internal unsafe static TexCoord3fv glTexCoord3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3i(Int32 s,Int32 t,Int32 r);
            internal static TexCoord3i glTexCoord3i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3iv(Int32* v);
            internal unsafe static TexCoord3iv glTexCoord3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord3s(Int16 s,Int16 t,Int16 r);
            internal static TexCoord3s glTexCoord3s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord3sv(Int16* v);
            internal unsafe static TexCoord3sv glTexCoord3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4d(Double s,Double t,Double r,Double q);
            internal static TexCoord4d glTexCoord4d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4dv(Double* v);
            internal unsafe static TexCoord4dv glTexCoord4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4f(Single s,Single t,Single r,Single q);
            internal static TexCoord4f glTexCoord4f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4fColor4fNormal3fVertex4fSUN(Single s,Single t,Single p,Single q,Single r,Single g,Single b,Single a,Single nx,Single ny,Single nz,Single x,Single y,Single z,Single w);
            internal static TexCoord4fColor4fNormal3fVertex4fSUN glTexCoord4fColor4fNormal3fVertex4fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fColor4fNormal3fVertex4fvSUN(Single* tc,Single* c,Single* n,Single* v);
            internal unsafe static TexCoord4fColor4fNormal3fVertex4fvSUN glTexCoord4fColor4fNormal3fVertex4fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fv(Single* v);
            internal unsafe static TexCoord4fv glTexCoord4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4fVertex4fSUN(Single s,Single t,Single p,Single q,Single x,Single y,Single z,Single w);
            internal static TexCoord4fVertex4fSUN glTexCoord4fVertex4fSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4fVertex4fvSUN(Single* tc,Single* v);
            internal unsafe static TexCoord4fVertex4fvSUN glTexCoord4fVertex4fvSUN;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4i(Int32 s,Int32 t,Int32 r,Int32 q);
            internal static TexCoord4i glTexCoord4i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4iv(Int32* v);
            internal unsafe static TexCoord4iv glTexCoord4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoord4s(Int16 s,Int16 t,Int16 r,Int16 q);
            internal static TexCoord4s glTexCoord4s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoord4sv(Int16* v);
            internal unsafe static TexCoord4sv glTexCoord4sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordFormatNV(Int32 size,Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,Int32 stride);
            internal static TexCoordFormatNV glTexCoordFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP1ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static TexCoordP1ui glTexCoordP1ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP1uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static TexCoordP1uiv glTexCoordP1uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP2ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static TexCoordP2ui glTexCoordP2ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP2uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static TexCoordP2uiv glTexCoordP2uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static TexCoordP3ui glTexCoordP3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static TexCoordP3uiv glTexCoordP3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordP4ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 coords);
            internal static TexCoordP4ui glTexCoordP4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexCoordP4uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* coords);
            internal unsafe static TexCoordP4uiv glTexCoordP4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointer(Int32 size,Pencil.Gaming.Graphics.TexCoordPointerType type,Int32 stride,IntPtr pointer);
            internal static TexCoordPointer glTexCoordPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointerEXT(Int32 size,Pencil.Gaming.Graphics.TexCoordPointerType type,Int32 stride,Int32 count,IntPtr pointer);
            internal static TexCoordPointerEXT glTexCoordPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointerListIBM(Int32 size,Pencil.Gaming.Graphics.TexCoordPointerType type,Int32 stride,IntPtr pointer,Int32 ptrstride);
            internal static TexCoordPointerListIBM glTexCoordPointerListIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexCoordPointervINTEL(Int32 size,Pencil.Gaming.Graphics.VertexPointerType type,IntPtr pointer);
            internal static TexCoordPointervINTEL glTexCoordPointervINTEL;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvf(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Single param);
            internal static TexEnvf glTexEnvf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnvfv(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Single* @params);
            internal unsafe static TexEnvfv glTexEnvfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexEnvi(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Int32 param);
            internal static TexEnvi glTexEnvi;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexEnviv(Pencil.Gaming.Graphics.TextureEnvTarget target,Pencil.Gaming.Graphics.TextureEnvParameter pname,Int32* @params);
            internal unsafe static TexEnviv glTexEnviv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexFilterFuncSGIS(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.SgisTextureFilter4 filter,Int32 n,Single* weights);
            internal unsafe static TexFilterFuncSGIS glTexFilterFuncSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGend(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Double param);
            internal static TexGend glTexGend;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGendv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Double* @params);
            internal unsafe static TexGendv glTexGendv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGenf(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Single param);
            internal static TexGenf glTexGenf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGenfv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Single* @params);
            internal unsafe static TexGenfv glTexGenfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexGeni(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Int32 param);
            internal static TexGeni glTexGeni;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexGeniv(Pencil.Gaming.Graphics.TextureCoordName coord,Pencil.Gaming.Graphics.TextureGenParameter pname,Int32* @params);
            internal unsafe static TexGeniv glTexGeniv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexImage1D glTexImage1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexImage2D glTexImage2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2DMultisample(Pencil.Gaming.Graphics.TextureTargetMultisample target,Int32 samples,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,bool fixedsamplelocations);
            internal static TexImage2DMultisample glTexImage2DMultisample;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage2DMultisampleCoverageNV(Pencil.Gaming.Graphics.NvTextureMultisample target,Int32 coverageSamples,Int32 colorSamples,Int32 internalFormat,Int32 width,Int32 height,bool fixedSampleLocations);
            internal static TexImage2DMultisampleCoverageNV glTexImage2DMultisampleCoverageNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexImage3D glTexImage3D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexImage3DEXT glTexImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DMultisample(Pencil.Gaming.Graphics.TextureTargetMultisample target,Int32 samples,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,bool fixedsamplelocations);
            internal static TexImage3DMultisample glTexImage3DMultisample;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage3DMultisampleCoverageNV(Pencil.Gaming.Graphics.NvTextureMultisample target,Int32 coverageSamples,Int32 colorSamples,Int32 internalFormat,Int32 width,Int32 height,Int32 depth,bool fixedSampleLocations);
            internal static TexImage3DMultisampleCoverageNV glTexImage3DMultisampleCoverageNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexImage4DSGIS(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.PixelInternalFormat internalformat,Int32 width,Int32 height,Int32 depth,Int32 size4d,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexImage4DSGIS glTexImage4DSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameterf(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Single param);
            internal static TexParameterf glTexParameterf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterfv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Single* @params);
            internal unsafe static TexParameterfv glTexParameterfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexParameteri(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32 param);
            internal static TexParameteri glTexParameteri;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIiv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
            internal unsafe static TexParameterIiv glTexParameterIiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIivEXT(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
            internal unsafe static TexParameterIivEXT glTexParameterIivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIuiv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,UInt32* @params);
            internal unsafe static TexParameterIuiv glTexParameterIuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameterIuivEXT(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,UInt32* @params);
            internal unsafe static TexParameterIuivEXT glTexParameterIuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TexParameteriv(Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
            internal unsafe static TexParameteriv glTexParameteriv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexRenderbufferNV(Pencil.Gaming.Graphics.TextureTarget target,UInt32 renderbuffer);
            internal static TexRenderbufferNV glTexRenderbufferNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage1D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexSubImage1D glTexSubImage1D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage1DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexSubImage1DEXT glTexSubImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexSubImage2D glTexSubImage2D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage2DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexSubImage2DEXT glTexSubImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3D(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexSubImage3D glTexSubImage3D;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage3DEXT(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexSubImage3DEXT glTexSubImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TexSubImage4DSGIS(Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 woffset,Int32 width,Int32 height,Int32 depth,Int32 size4d,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TexSubImage4DSGIS glTexSubImage4DSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureBarrierNV();
            internal static TextureBarrierNV glTextureBarrierNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureBufferEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,UInt32 buffer);
            internal static TextureBufferEXT glTextureBufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureColorMaskSGIS(bool red,bool green,bool blue,bool alpha);
            internal static TextureColorMaskSGIS glTextureColorMaskSGIS;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage1DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TextureImage1DEXT glTextureImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage2DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 height,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TextureImage2DEXT glTextureImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage2DMultisampleCoverageNV(UInt32 texture,Pencil.Gaming.Graphics.NvTextureMultisample target,Int32 coverageSamples,Int32 colorSamples,Int32 internalFormat,Int32 width,Int32 height,bool fixedSampleLocations);
            internal static TextureImage2DMultisampleCoverageNV glTextureImage2DMultisampleCoverageNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage2DMultisampleNV(UInt32 texture,Pencil.Gaming.Graphics.NvTextureMultisample target,Int32 samples,Int32 internalFormat,Int32 width,Int32 height,bool fixedSampleLocations);
            internal static TextureImage2DMultisampleNV glTextureImage2DMultisampleNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage3DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Pencil.Gaming.Graphics.ExtDirectStateAccess internalformat,Int32 width,Int32 height,Int32 depth,Int32 border,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TextureImage3DEXT glTextureImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage3DMultisampleCoverageNV(UInt32 texture,Pencil.Gaming.Graphics.NvTextureMultisample target,Int32 coverageSamples,Int32 colorSamples,Int32 internalFormat,Int32 width,Int32 height,Int32 depth,bool fixedSampleLocations);
            internal static TextureImage3DMultisampleCoverageNV glTextureImage3DMultisampleCoverageNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureImage3DMultisampleNV(UInt32 texture,Pencil.Gaming.Graphics.NvTextureMultisample target,Int32 samples,Int32 internalFormat,Int32 width,Int32 height,Int32 depth,bool fixedSampleLocations);
            internal static TextureImage3DMultisampleNV glTextureImage3DMultisampleNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureLightEXT(Pencil.Gaming.Graphics.ExtLightTexture pname);
            internal static TextureLightEXT glTextureLightEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureMaterialEXT(Pencil.Gaming.Graphics.MaterialFace face,Pencil.Gaming.Graphics.MaterialParameter mode);
            internal static TextureMaterialEXT glTextureMaterialEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureNormalEXT(Pencil.Gaming.Graphics.ExtTexturePerturbNormal mode);
            internal static TextureNormalEXT glTextureNormalEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureParameterfEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Single param);
            internal static TextureParameterfEXT glTextureParameterfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TextureParameterfvEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Single* @params);
            internal unsafe static TextureParameterfvEXT glTextureParameterfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureParameteriEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32 param);
            internal static TextureParameteriEXT glTextureParameteriEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TextureParameterIivEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
            internal unsafe static TextureParameterIivEXT glTextureParameterIivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TextureParameterIuivEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,UInt32* @params);
            internal unsafe static TextureParameterIuivEXT glTextureParameterIuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TextureParameterivEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Pencil.Gaming.Graphics.TextureParameterName pname,Int32* @params);
            internal unsafe static TextureParameterivEXT glTextureParameterivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureRangeAPPLE(Pencil.Gaming.Graphics.AppleTextureRange target,Int32 length,IntPtr pointer);
            internal static TextureRangeAPPLE glTextureRangeAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureRenderbufferEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,UInt32 renderbuffer);
            internal static TextureRenderbufferEXT glTextureRenderbufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureSubImage1DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 width,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TextureSubImage1DEXT glTextureSubImage1DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureSubImage2DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 width,Int32 height,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TextureSubImage2DEXT glTextureSubImage2DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TextureSubImage3DEXT(UInt32 texture,Pencil.Gaming.Graphics.TextureTarget target,Int32 level,Int32 xoffset,Int32 yoffset,Int32 zoffset,Int32 width,Int32 height,Int32 depth,Pencil.Gaming.Graphics.PixelFormat format,Pencil.Gaming.Graphics.PixelType type,IntPtr pixels);
            internal static TextureSubImage3DEXT glTextureSubImage3DEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TrackMatrixNV(Pencil.Gaming.Graphics.AssemblyProgramTargetArb target,UInt32 address,Pencil.Gaming.Graphics.NvVertexProgram matrix,Pencil.Gaming.Graphics.NvVertexProgram transform);
            internal static TrackMatrixNV glTrackMatrixNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackAttribsNV(UInt32 count,Int32* attribs,Pencil.Gaming.Graphics.NvTransformFeedback bufferMode);
            internal unsafe static TransformFeedbackAttribsNV glTransformFeedbackAttribsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackStreamAttribsNV(Int32 count,Int32* attribs,Int32 nbuffers,Int32* bufstreams,Pencil.Gaming.Graphics.NvTransformFeedback bufferMode);
            internal unsafe static TransformFeedbackStreamAttribsNV glTransformFeedbackStreamAttribsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TransformFeedbackVaryings(UInt32 program,Int32 count,String[] varyings,Pencil.Gaming.Graphics.TransformFeedbackMode bufferMode);
            internal static TransformFeedbackVaryings glTransformFeedbackVaryings;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void TransformFeedbackVaryingsEXT(UInt32 program,Int32 count,String[] varyings,Pencil.Gaming.Graphics.ExtTransformFeedback bufferMode);
            internal static TransformFeedbackVaryingsEXT glTransformFeedbackVaryingsEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void TransformFeedbackVaryingsNV(UInt32 program,Int32 count,Int32* locations,Pencil.Gaming.Graphics.NvTransformFeedback bufferMode);
            internal unsafe static TransformFeedbackVaryingsNV glTransformFeedbackVaryingsNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Translated(Double x,Double y,Double z);
            internal static Translated glTranslated;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Translatef(Single x,Single y,Single z);
            internal static Translatef glTranslatef;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1d(Int32 location,Double x);
            internal static Uniform1d glUniform1d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1dv(Int32 location,Int32 count,Double* value);
            internal unsafe static Uniform1dv glUniform1dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1f(Int32 location,Single v0);
            internal static Uniform1f glUniform1f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1fARB(Int32 location,Single v0);
            internal static Uniform1fARB glUniform1fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fv(Int32 location,Int32 count,Single* value);
            internal unsafe static Uniform1fv glUniform1fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1fvARB(Int32 location,Int32 count,Single* value);
            internal unsafe static Uniform1fvARB glUniform1fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i(Int32 location,Int32 v0);
            internal static Uniform1i glUniform1i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1i64NV(Int32 location,Int64 x);
            internal static Uniform1i64NV glUniform1i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1i64vNV(Int32 location,Int32 count,Int64* value);
            internal unsafe static Uniform1i64vNV glUniform1i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1iARB(Int32 location,Int32 v0);
            internal static Uniform1iARB glUniform1iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1iv(Int32 location,Int32 count,Int32* value);
            internal unsafe static Uniform1iv glUniform1iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1ivARB(Int32 location,Int32 count,Int32* value);
            internal unsafe static Uniform1ivARB glUniform1ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1ui(Int32 location,UInt32 v0);
            internal static Uniform1ui glUniform1ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1ui64NV(Int32 location,UInt64 x);
            internal static Uniform1ui64NV glUniform1ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1ui64vNV(Int32 location,Int32 count,UInt64* value);
            internal unsafe static Uniform1ui64vNV glUniform1ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform1uiEXT(Int32 location,UInt32 v0);
            internal static Uniform1uiEXT glUniform1uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1uiv(Int32 location,Int32 count,UInt32* value);
            internal unsafe static Uniform1uiv glUniform1uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform1uivEXT(Int32 location,Int32 count,UInt32* value);
            internal unsafe static Uniform1uivEXT glUniform1uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2d(Int32 location,Double x,Double y);
            internal static Uniform2d glUniform2d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2dv(Int32 location,Int32 count,Double* value);
            internal unsafe static Uniform2dv glUniform2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2f(Int32 location,Single v0,Single v1);
            internal static Uniform2f glUniform2f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2fARB(Int32 location,Single v0,Single v1);
            internal static Uniform2fARB glUniform2fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fv(Int32 location,Int32 count,Single* value);
            internal unsafe static Uniform2fv glUniform2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2fvARB(Int32 location,Int32 count,Single* value);
            internal unsafe static Uniform2fvARB glUniform2fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i(Int32 location,Int32 v0,Int32 v1);
            internal static Uniform2i glUniform2i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2i64NV(Int32 location,Int64 x,Int64 y);
            internal static Uniform2i64NV glUniform2i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2i64vNV(Int32 location,Int32 count,Int64* value);
            internal unsafe static Uniform2i64vNV glUniform2i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2iARB(Int32 location,Int32 v0,Int32 v1);
            internal static Uniform2iARB glUniform2iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2iv(Int32 location,Int32 count,Int32* value);
            internal unsafe static Uniform2iv glUniform2iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2ivARB(Int32 location,Int32 count,Int32* value);
            internal unsafe static Uniform2ivARB glUniform2ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2ui(Int32 location,UInt32 v0,UInt32 v1);
            internal static Uniform2ui glUniform2ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2ui64NV(Int32 location,UInt64 x,UInt64 y);
            internal static Uniform2ui64NV glUniform2ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2ui64vNV(Int32 location,Int32 count,UInt64* value);
            internal unsafe static Uniform2ui64vNV glUniform2ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform2uiEXT(Int32 location,UInt32 v0,UInt32 v1);
            internal static Uniform2uiEXT glUniform2uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2uiv(Int32 location,Int32 count,UInt32* value);
            internal unsafe static Uniform2uiv glUniform2uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform2uivEXT(Int32 location,Int32 count,UInt32* value);
            internal unsafe static Uniform2uivEXT glUniform2uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3d(Int32 location,Double x,Double y,Double z);
            internal static Uniform3d glUniform3d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3dv(Int32 location,Int32 count,Double* value);
            internal unsafe static Uniform3dv glUniform3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3f(Int32 location,Single v0,Single v1,Single v2);
            internal static Uniform3f glUniform3f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3fARB(Int32 location,Single v0,Single v1,Single v2);
            internal static Uniform3fARB glUniform3fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fv(Int32 location,Int32 count,Single* value);
            internal unsafe static Uniform3fv glUniform3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3fvARB(Int32 location,Int32 count,Single* value);
            internal unsafe static Uniform3fvARB glUniform3fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i(Int32 location,Int32 v0,Int32 v1,Int32 v2);
            internal static Uniform3i glUniform3i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3i64NV(Int32 location,Int64 x,Int64 y,Int64 z);
            internal static Uniform3i64NV glUniform3i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3i64vNV(Int32 location,Int32 count,Int64* value);
            internal unsafe static Uniform3i64vNV glUniform3i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3iARB(Int32 location,Int32 v0,Int32 v1,Int32 v2);
            internal static Uniform3iARB glUniform3iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3iv(Int32 location,Int32 count,Int32* value);
            internal unsafe static Uniform3iv glUniform3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3ivARB(Int32 location,Int32 count,Int32* value);
            internal unsafe static Uniform3ivARB glUniform3ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3ui(Int32 location,UInt32 v0,UInt32 v1,UInt32 v2);
            internal static Uniform3ui glUniform3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3ui64NV(Int32 location,UInt64 x,UInt64 y,UInt64 z);
            internal static Uniform3ui64NV glUniform3ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3ui64vNV(Int32 location,Int32 count,UInt64* value);
            internal unsafe static Uniform3ui64vNV glUniform3ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform3uiEXT(Int32 location,UInt32 v0,UInt32 v1,UInt32 v2);
            internal static Uniform3uiEXT glUniform3uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3uiv(Int32 location,Int32 count,UInt32* value);
            internal unsafe static Uniform3uiv glUniform3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform3uivEXT(Int32 location,Int32 count,UInt32* value);
            internal unsafe static Uniform3uivEXT glUniform3uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4d(Int32 location,Double x,Double y,Double z,Double w);
            internal static Uniform4d glUniform4d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4dv(Int32 location,Int32 count,Double* value);
            internal unsafe static Uniform4dv glUniform4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4f(Int32 location,Single v0,Single v1,Single v2,Single v3);
            internal static Uniform4f glUniform4f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4fARB(Int32 location,Single v0,Single v1,Single v2,Single v3);
            internal static Uniform4fARB glUniform4fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fv(Int32 location,Int32 count,Single* value);
            internal unsafe static Uniform4fv glUniform4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4fvARB(Int32 location,Int32 count,Single* value);
            internal unsafe static Uniform4fvARB glUniform4fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i(Int32 location,Int32 v0,Int32 v1,Int32 v2,Int32 v3);
            internal static Uniform4i glUniform4i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4i64NV(Int32 location,Int64 x,Int64 y,Int64 z,Int64 w);
            internal static Uniform4i64NV glUniform4i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4i64vNV(Int32 location,Int32 count,Int64* value);
            internal unsafe static Uniform4i64vNV glUniform4i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4iARB(Int32 location,Int32 v0,Int32 v1,Int32 v2,Int32 v3);
            internal static Uniform4iARB glUniform4iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4iv(Int32 location,Int32 count,Int32* value);
            internal unsafe static Uniform4iv glUniform4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4ivARB(Int32 location,Int32 count,Int32* value);
            internal unsafe static Uniform4ivARB glUniform4ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4ui(Int32 location,UInt32 v0,UInt32 v1,UInt32 v2,UInt32 v3);
            internal static Uniform4ui glUniform4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4ui64NV(Int32 location,UInt64 x,UInt64 y,UInt64 z,UInt64 w);
            internal static Uniform4ui64NV glUniform4ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4ui64vNV(Int32 location,Int32 count,UInt64* value);
            internal unsafe static Uniform4ui64vNV glUniform4ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniform4uiEXT(Int32 location,UInt32 v0,UInt32 v1,UInt32 v2,UInt32 v3);
            internal static Uniform4uiEXT glUniform4uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4uiv(Int32 location,Int32 count,UInt32* value);
            internal unsafe static Uniform4uiv glUniform4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniform4uivEXT(Int32 location,Int32 count,UInt32* value);
            internal unsafe static Uniform4uivEXT glUniform4uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UniformBlockBinding(UInt32 program,UInt32 uniformBlockIndex,UInt32 uniformBlockBinding);
            internal static UniformBlockBinding glUniformBlockBinding;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UniformBufferEXT(UInt32 program,Int32 location,UInt32 buffer);
            internal static UniformBufferEXT glUniformBufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix2dv glUniformMatrix2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix2fv glUniformMatrix2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2fvARB(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix2fvARB glUniformMatrix2fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix2x3dv glUniformMatrix2x3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x3fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix2x3fv glUniformMatrix2x3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix2x4dv glUniformMatrix2x4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix2x4fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix2x4fv glUniformMatrix2x4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix3dv glUniformMatrix3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix3fv glUniformMatrix3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3fvARB(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix3fvARB glUniformMatrix3fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix3x2dv glUniformMatrix3x2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x2fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix3x2fv glUniformMatrix3x2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix3x4dv glUniformMatrix3x4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix3x4fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix3x4fv glUniformMatrix3x4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix4dv glUniformMatrix4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix4fv glUniformMatrix4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4fvARB(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix4fvARB glUniformMatrix4fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix4x2dv glUniformMatrix4x2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x2fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix4x2fv glUniformMatrix4x2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3dv(Int32 location,Int32 count,bool transpose,Double* value);
            internal unsafe static UniformMatrix4x3dv glUniformMatrix4x3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformMatrix4x3fv(Int32 location,Int32 count,bool transpose,Single* value);
            internal unsafe static UniformMatrix4x3fv glUniformMatrix4x3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void UniformSubroutinesuiv(Pencil.Gaming.Graphics.ShaderType shadertype,Int32 count,UInt32* indices);
            internal unsafe static UniformSubroutinesuiv glUniformSubroutinesuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Uniformui64NV(Int32 location,UInt64 value);
            internal static Uniformui64NV glUniformui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Uniformui64vNV(Int32 location,Int32 count,UInt64* value);
            internal unsafe static Uniformui64vNV glUniformui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UnlockArraysEXT();
            internal static UnlockArraysEXT glUnlockArraysEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBuffer(Pencil.Gaming.Graphics.BufferTarget target);
            internal static UnmapBuffer glUnmapBuffer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapBufferARB(Pencil.Gaming.Graphics.BufferTargetArb target);
            internal static UnmapBufferARB glUnmapBufferARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate bool UnmapNamedBufferEXT(UInt32 buffer);
            internal static UnmapNamedBufferEXT glUnmapNamedBufferEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UnmapObjectBufferATI(UInt32 buffer);
            internal static UnmapObjectBufferATI glUnmapObjectBufferATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UpdateObjectBufferATI(UInt32 buffer,UInt32 offset,Int32 size,IntPtr pointer,Pencil.Gaming.Graphics.AtiVertexArrayObject preserve);
            internal static UpdateObjectBufferATI glUpdateObjectBufferATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgram(UInt32 program);
            internal static UseProgram glUseProgram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramObjectARB(UInt32 programObj);
            internal static UseProgramObjectARB glUseProgramObjectARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UseProgramStages(UInt32 pipeline,Pencil.Gaming.Graphics.ProgramStageMask stages,UInt32 program);
            internal static UseProgramStages glUseProgramStages;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void UseShaderProgramEXT(Pencil.Gaming.Graphics.ExtSeparateShaderObjects type,UInt32 program);
            internal static UseShaderProgramEXT glUseShaderProgramEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgram(UInt32 program);
            internal static ValidateProgram glValidateProgram;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramARB(UInt32 programObj);
            internal static ValidateProgramARB glValidateProgramARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ValidateProgramPipeline(UInt32 pipeline);
            internal static ValidateProgramPipeline glValidateProgramPipeline;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VariantArrayObjectATI(UInt32 id,Pencil.Gaming.Graphics.AtiVertexArrayObject type,Int32 stride,UInt32 buffer,UInt32 offset);
            internal static VariantArrayObjectATI glVariantArrayObjectATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantbvEXT(UInt32 id,SByte* addr);
            internal unsafe static VariantbvEXT glVariantbvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantdvEXT(UInt32 id,Double* addr);
            internal unsafe static VariantdvEXT glVariantdvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantfvEXT(UInt32 id,Single* addr);
            internal unsafe static VariantfvEXT glVariantfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantivEXT(UInt32 id,Int32* addr);
            internal unsafe static VariantivEXT glVariantivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VariantPointerEXT(UInt32 id,Pencil.Gaming.Graphics.ExtVertexShader type,UInt32 stride,IntPtr addr);
            internal static VariantPointerEXT glVariantPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantsvEXT(UInt32 id,Int16* addr);
            internal unsafe static VariantsvEXT glVariantsvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantubvEXT(UInt32 id,Byte* addr);
            internal unsafe static VariantubvEXT glVariantubvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantuivEXT(UInt32 id,UInt32* addr);
            internal unsafe static VariantuivEXT glVariantuivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VariantusvEXT(UInt32 id,UInt16* addr);
            internal unsafe static VariantusvEXT glVariantusvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUFiniNV();
            internal static VDPAUFiniNV glVDPAUFiniNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VDPAUGetSurfaceivNV(IntPtr surface,Pencil.Gaming.Graphics.NvVdpauInterop pname,Int32 bufSize,[OutAttribute] Int32* length,[OutAttribute] Int32* values);
            internal unsafe static VDPAUGetSurfaceivNV glVDPAUGetSurfaceivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUInitNV(IntPtr vdpDevice,IntPtr getProcAddress);
            internal static VDPAUInitNV glVDPAUInitNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUIsSurfaceNV(IntPtr surface);
            internal static VDPAUIsSurfaceNV glVDPAUIsSurfaceNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VDPAUMapSurfacesNV(Int32 numSurfaces,IntPtr* surfaces);
            internal unsafe static VDPAUMapSurfacesNV glVDPAUMapSurfacesNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr VDPAURegisterOutputSurfaceNV([OutAttribute] IntPtr vdpSurface,Pencil.Gaming.Graphics.NvVdpauInterop target,Int32 numTextureNames,UInt32* textureNames);
            internal unsafe static VDPAURegisterOutputSurfaceNV glVDPAURegisterOutputSurfaceNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate IntPtr VDPAURegisterVideoSurfaceNV([OutAttribute] IntPtr vdpSurface,Pencil.Gaming.Graphics.NvVdpauInterop target,Int32 numTextureNames,UInt32* textureNames);
            internal unsafe static VDPAURegisterVideoSurfaceNV glVDPAURegisterVideoSurfaceNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUSurfaceAccessNV(IntPtr surface,Pencil.Gaming.Graphics.NvVdpauInterop access);
            internal static VDPAUSurfaceAccessNV glVDPAUSurfaceAccessNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VDPAUUnmapSurfacesNV(Int32 numSurface,IntPtr* surfaces);
            internal unsafe static VDPAUUnmapSurfacesNV glVDPAUUnmapSurfacesNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VDPAUUnregisterSurfaceNV(IntPtr surface);
            internal static VDPAUUnregisterSurfaceNV glVDPAUUnregisterSurfaceNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2d(Double x,Double y);
            internal static Vertex2d glVertex2d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2dv(Double* v);
            internal unsafe static Vertex2dv glVertex2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2f(Single x,Single y);
            internal static Vertex2f glVertex2f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2fv(Single* v);
            internal unsafe static Vertex2fv glVertex2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2i(Int32 x,Int32 y);
            internal static Vertex2i glVertex2i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2iv(Int32* v);
            internal unsafe static Vertex2iv glVertex2iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex2s(Int16 x,Int16 y);
            internal static Vertex2s glVertex2s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex2sv(Int16* v);
            internal unsafe static Vertex2sv glVertex2sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3d(Double x,Double y,Double z);
            internal static Vertex3d glVertex3d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3dv(Double* v);
            internal unsafe static Vertex3dv glVertex3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3f(Single x,Single y,Single z);
            internal static Vertex3f glVertex3f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3fv(Single* v);
            internal unsafe static Vertex3fv glVertex3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3i(Int32 x,Int32 y,Int32 z);
            internal static Vertex3i glVertex3i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3iv(Int32* v);
            internal unsafe static Vertex3iv glVertex3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex3s(Int16 x,Int16 y,Int16 z);
            internal static Vertex3s glVertex3s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex3sv(Int16* v);
            internal unsafe static Vertex3sv glVertex3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4d(Double x,Double y,Double z,Double w);
            internal static Vertex4d glVertex4d;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4dv(Double* v);
            internal unsafe static Vertex4dv glVertex4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4f(Single x,Single y,Single z,Single w);
            internal static Vertex4f glVertex4f;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4fv(Single* v);
            internal unsafe static Vertex4fv glVertex4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4i(Int32 x,Int32 y,Int32 z,Int32 w);
            internal static Vertex4i glVertex4i;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4iv(Int32* v);
            internal unsafe static Vertex4iv glVertex4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Vertex4s(Int16 x,Int16 y,Int16 z,Int16 w);
            internal static Vertex4s glVertex4s;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void Vertex4sv(Int16* v);
            internal unsafe static Vertex4sv glVertex4sv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayParameteriAPPLE(Pencil.Gaming.Graphics.AppleVertexArrayRange pname,Int32 param);
            internal static VertexArrayParameteriAPPLE glVertexArrayParameteriAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayRangeAPPLE(Int32 length,[OutAttribute] IntPtr pointer);
            internal static VertexArrayRangeAPPLE glVertexArrayRangeAPPLE;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayRangeNV(Int32 length,IntPtr pointer);
            internal static VertexArrayRangeNV glVertexArrayRangeNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexArrayVertexAttribLOffsetEXT(UInt32 vaobj,UInt32 buffer,UInt32 index,Int32 size,Pencil.Gaming.Graphics.ExtVertexAttrib64bit type,Int32 stride,IntPtr offset);
            internal static VertexArrayVertexAttribLOffsetEXT glVertexArrayVertexAttribLOffsetEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1d(UInt32 index,Double x);
            internal static VertexAttrib1d glVertexAttrib1d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1dARB(UInt32 index,Double x);
            internal static VertexAttrib1dARB glVertexAttrib1dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1dNV(UInt32 index,Double x);
            internal static VertexAttrib1dNV glVertexAttrib1dNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dv(UInt32 index,Double* v);
            internal unsafe static VertexAttrib1dv glVertexAttrib1dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dvARB(UInt32 index,Double* v);
            internal unsafe static VertexAttrib1dvARB glVertexAttrib1dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1dvNV(UInt32 index,Double* v);
            internal unsafe static VertexAttrib1dvNV glVertexAttrib1dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1f(UInt32 index,Single x);
            internal static VertexAttrib1f glVertexAttrib1f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1fARB(UInt32 index,Single x);
            internal static VertexAttrib1fARB glVertexAttrib1fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1fNV(UInt32 index,Single x);
            internal static VertexAttrib1fNV glVertexAttrib1fNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fv(UInt32 index,Single* v);
            internal unsafe static VertexAttrib1fv glVertexAttrib1fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fvARB(UInt32 index,Single* v);
            internal unsafe static VertexAttrib1fvARB glVertexAttrib1fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1fvNV(UInt32 index,Single* v);
            internal unsafe static VertexAttrib1fvNV glVertexAttrib1fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1s(UInt32 index,Int16 x);
            internal static VertexAttrib1s glVertexAttrib1s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1sARB(UInt32 index,Int16 x);
            internal static VertexAttrib1sARB glVertexAttrib1sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib1sNV(UInt32 index,Int16 x);
            internal static VertexAttrib1sNV glVertexAttrib1sNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1sv(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib1sv glVertexAttrib1sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1svARB(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib1svARB glVertexAttrib1svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib1svNV(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib1svNV glVertexAttrib1svNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2d(UInt32 index,Double x,Double y);
            internal static VertexAttrib2d glVertexAttrib2d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2dARB(UInt32 index,Double x,Double y);
            internal static VertexAttrib2dARB glVertexAttrib2dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2dNV(UInt32 index,Double x,Double y);
            internal static VertexAttrib2dNV glVertexAttrib2dNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dv(UInt32 index,Double* v);
            internal unsafe static VertexAttrib2dv glVertexAttrib2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dvARB(UInt32 index,Double* v);
            internal unsafe static VertexAttrib2dvARB glVertexAttrib2dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2dvNV(UInt32 index,Double* v);
            internal unsafe static VertexAttrib2dvNV glVertexAttrib2dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2f(UInt32 index,Single x,Single y);
            internal static VertexAttrib2f glVertexAttrib2f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2fARB(UInt32 index,Single x,Single y);
            internal static VertexAttrib2fARB glVertexAttrib2fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2fNV(UInt32 index,Single x,Single y);
            internal static VertexAttrib2fNV glVertexAttrib2fNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fv(UInt32 index,Single* v);
            internal unsafe static VertexAttrib2fv glVertexAttrib2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fvARB(UInt32 index,Single* v);
            internal unsafe static VertexAttrib2fvARB glVertexAttrib2fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2fvNV(UInt32 index,Single* v);
            internal unsafe static VertexAttrib2fvNV glVertexAttrib2fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2s(UInt32 index,Int16 x,Int16 y);
            internal static VertexAttrib2s glVertexAttrib2s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2sARB(UInt32 index,Int16 x,Int16 y);
            internal static VertexAttrib2sARB glVertexAttrib2sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib2sNV(UInt32 index,Int16 x,Int16 y);
            internal static VertexAttrib2sNV glVertexAttrib2sNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2sv(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib2sv glVertexAttrib2sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2svARB(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib2svARB glVertexAttrib2svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib2svNV(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib2svNV glVertexAttrib2svNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3d(UInt32 index,Double x,Double y,Double z);
            internal static VertexAttrib3d glVertexAttrib3d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3dARB(UInt32 index,Double x,Double y,Double z);
            internal static VertexAttrib3dARB glVertexAttrib3dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3dNV(UInt32 index,Double x,Double y,Double z);
            internal static VertexAttrib3dNV glVertexAttrib3dNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dv(UInt32 index,Double* v);
            internal unsafe static VertexAttrib3dv glVertexAttrib3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dvARB(UInt32 index,Double* v);
            internal unsafe static VertexAttrib3dvARB glVertexAttrib3dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3dvNV(UInt32 index,Double* v);
            internal unsafe static VertexAttrib3dvNV glVertexAttrib3dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3f(UInt32 index,Single x,Single y,Single z);
            internal static VertexAttrib3f glVertexAttrib3f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3fARB(UInt32 index,Single x,Single y,Single z);
            internal static VertexAttrib3fARB glVertexAttrib3fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3fNV(UInt32 index,Single x,Single y,Single z);
            internal static VertexAttrib3fNV glVertexAttrib3fNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fv(UInt32 index,Single* v);
            internal unsafe static VertexAttrib3fv glVertexAttrib3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fvARB(UInt32 index,Single* v);
            internal unsafe static VertexAttrib3fvARB glVertexAttrib3fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3fvNV(UInt32 index,Single* v);
            internal unsafe static VertexAttrib3fvNV glVertexAttrib3fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3s(UInt32 index,Int16 x,Int16 y,Int16 z);
            internal static VertexAttrib3s glVertexAttrib3s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3sARB(UInt32 index,Int16 x,Int16 y,Int16 z);
            internal static VertexAttrib3sARB glVertexAttrib3sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib3sNV(UInt32 index,Int16 x,Int16 y,Int16 z);
            internal static VertexAttrib3sNV glVertexAttrib3sNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3sv(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib3sv glVertexAttrib3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3svARB(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib3svARB glVertexAttrib3svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib3svNV(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib3svNV glVertexAttrib3svNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4bv(UInt32 index,SByte* v);
            internal unsafe static VertexAttrib4bv glVertexAttrib4bv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4bvARB(UInt32 index,SByte* v);
            internal unsafe static VertexAttrib4bvARB glVertexAttrib4bvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4d(UInt32 index,Double x,Double y,Double z,Double w);
            internal static VertexAttrib4d glVertexAttrib4d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4dARB(UInt32 index,Double x,Double y,Double z,Double w);
            internal static VertexAttrib4dARB glVertexAttrib4dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4dNV(UInt32 index,Double x,Double y,Double z,Double w);
            internal static VertexAttrib4dNV glVertexAttrib4dNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dv(UInt32 index,Double* v);
            internal unsafe static VertexAttrib4dv glVertexAttrib4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dvARB(UInt32 index,Double* v);
            internal unsafe static VertexAttrib4dvARB glVertexAttrib4dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4dvNV(UInt32 index,Double* v);
            internal unsafe static VertexAttrib4dvNV glVertexAttrib4dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4f(UInt32 index,Single x,Single y,Single z,Single w);
            internal static VertexAttrib4f glVertexAttrib4f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4fARB(UInt32 index,Single x,Single y,Single z,Single w);
            internal static VertexAttrib4fARB glVertexAttrib4fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4fNV(UInt32 index,Single x,Single y,Single z,Single w);
            internal static VertexAttrib4fNV glVertexAttrib4fNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fv(UInt32 index,Single* v);
            internal unsafe static VertexAttrib4fv glVertexAttrib4fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fvARB(UInt32 index,Single* v);
            internal unsafe static VertexAttrib4fvARB glVertexAttrib4fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4fvNV(UInt32 index,Single* v);
            internal unsafe static VertexAttrib4fvNV glVertexAttrib4fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4iv(UInt32 index,Int32* v);
            internal unsafe static VertexAttrib4iv glVertexAttrib4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ivARB(UInt32 index,Int32* v);
            internal unsafe static VertexAttrib4ivARB glVertexAttrib4ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nbv(UInt32 index,SByte* v);
            internal unsafe static VertexAttrib4Nbv glVertexAttrib4Nbv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NbvARB(UInt32 index,SByte* v);
            internal unsafe static VertexAttrib4NbvARB glVertexAttrib4NbvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Niv(UInt32 index,Int32* v);
            internal unsafe static VertexAttrib4Niv glVertexAttrib4Niv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NivARB(UInt32 index,Int32* v);
            internal unsafe static VertexAttrib4NivARB glVertexAttrib4NivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nsv(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib4Nsv glVertexAttrib4Nsv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NsvARB(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib4NsvARB glVertexAttrib4NsvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4Nub(UInt32 index,Byte x,Byte y,Byte z,Byte w);
            internal static VertexAttrib4Nub glVertexAttrib4Nub;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4NubARB(UInt32 index,Byte x,Byte y,Byte z,Byte w);
            internal static VertexAttrib4NubARB glVertexAttrib4NubARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nubv(UInt32 index,Byte* v);
            internal unsafe static VertexAttrib4Nubv glVertexAttrib4Nubv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NubvARB(UInt32 index,Byte* v);
            internal unsafe static VertexAttrib4NubvARB glVertexAttrib4NubvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nuiv(UInt32 index,UInt32* v);
            internal unsafe static VertexAttrib4Nuiv glVertexAttrib4Nuiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NuivARB(UInt32 index,UInt32* v);
            internal unsafe static VertexAttrib4NuivARB glVertexAttrib4NuivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4Nusv(UInt32 index,UInt16* v);
            internal unsafe static VertexAttrib4Nusv glVertexAttrib4Nusv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4NusvARB(UInt32 index,UInt16* v);
            internal unsafe static VertexAttrib4NusvARB glVertexAttrib4NusvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4s(UInt32 index,Int16 x,Int16 y,Int16 z,Int16 w);
            internal static VertexAttrib4s glVertexAttrib4s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4sARB(UInt32 index,Int16 x,Int16 y,Int16 z,Int16 w);
            internal static VertexAttrib4sARB glVertexAttrib4sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4sNV(UInt32 index,Int16 x,Int16 y,Int16 z,Int16 w);
            internal static VertexAttrib4sNV glVertexAttrib4sNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4sv(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib4sv glVertexAttrib4sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4svARB(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib4svARB glVertexAttrib4svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4svNV(UInt32 index,Int16* v);
            internal unsafe static VertexAttrib4svNV glVertexAttrib4svNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttrib4ubNV(UInt32 index,Byte x,Byte y,Byte z,Byte w);
            internal static VertexAttrib4ubNV glVertexAttrib4ubNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubv(UInt32 index,Byte* v);
            internal unsafe static VertexAttrib4ubv glVertexAttrib4ubv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubvARB(UInt32 index,Byte* v);
            internal unsafe static VertexAttrib4ubvARB glVertexAttrib4ubvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4ubvNV(UInt32 index,Byte* v);
            internal unsafe static VertexAttrib4ubvNV glVertexAttrib4ubvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4uiv(UInt32 index,UInt32* v);
            internal unsafe static VertexAttrib4uiv glVertexAttrib4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4uivARB(UInt32 index,UInt32* v);
            internal unsafe static VertexAttrib4uivARB glVertexAttrib4uivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4usv(UInt32 index,UInt16* v);
            internal unsafe static VertexAttrib4usv glVertexAttrib4usv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttrib4usvARB(UInt32 index,UInt16* v);
            internal unsafe static VertexAttrib4usvARB glVertexAttrib4usvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribArrayObjectATI(UInt32 index,Int32 size,Pencil.Gaming.Graphics.AtiVertexAttribArrayObject type,bool normalized,Int32 stride,UInt32 buffer,UInt32 offset);
            internal static VertexAttribArrayObjectATI glVertexAttribArrayObjectATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisor(UInt32 index,UInt32 divisor);
            internal static VertexAttribDivisor glVertexAttribDivisor;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribDivisorARB(UInt32 index,UInt32 divisor);
            internal static VertexAttribDivisorARB glVertexAttribDivisorARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribFormatNV(UInt32 index,Int32 size,Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,bool normalized,Int32 stride);
            internal static VertexAttribFormatNV glVertexAttribFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1i(UInt32 index,Int32 x);
            internal static VertexAttribI1i glVertexAttribI1i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1iEXT(UInt32 index,Int32 x);
            internal static VertexAttribI1iEXT glVertexAttribI1iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1iv(UInt32 index,Int32* v);
            internal unsafe static VertexAttribI1iv glVertexAttribI1iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1ivEXT(UInt32 index,Int32* v);
            internal unsafe static VertexAttribI1ivEXT glVertexAttribI1ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1ui(UInt32 index,UInt32 x);
            internal static VertexAttribI1ui glVertexAttribI1ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI1uiEXT(UInt32 index,UInt32 x);
            internal static VertexAttribI1uiEXT glVertexAttribI1uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1uiv(UInt32 index,UInt32* v);
            internal unsafe static VertexAttribI1uiv glVertexAttribI1uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI1uivEXT(UInt32 index,UInt32* v);
            internal unsafe static VertexAttribI1uivEXT glVertexAttribI1uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2i(UInt32 index,Int32 x,Int32 y);
            internal static VertexAttribI2i glVertexAttribI2i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2iEXT(UInt32 index,Int32 x,Int32 y);
            internal static VertexAttribI2iEXT glVertexAttribI2iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2iv(UInt32 index,Int32* v);
            internal unsafe static VertexAttribI2iv glVertexAttribI2iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2ivEXT(UInt32 index,Int32* v);
            internal unsafe static VertexAttribI2ivEXT glVertexAttribI2ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2ui(UInt32 index,UInt32 x,UInt32 y);
            internal static VertexAttribI2ui glVertexAttribI2ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI2uiEXT(UInt32 index,UInt32 x,UInt32 y);
            internal static VertexAttribI2uiEXT glVertexAttribI2uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2uiv(UInt32 index,UInt32* v);
            internal unsafe static VertexAttribI2uiv glVertexAttribI2uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI2uivEXT(UInt32 index,UInt32* v);
            internal unsafe static VertexAttribI2uivEXT glVertexAttribI2uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3i(UInt32 index,Int32 x,Int32 y,Int32 z);
            internal static VertexAttribI3i glVertexAttribI3i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3iEXT(UInt32 index,Int32 x,Int32 y,Int32 z);
            internal static VertexAttribI3iEXT glVertexAttribI3iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3iv(UInt32 index,Int32* v);
            internal unsafe static VertexAttribI3iv glVertexAttribI3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3ivEXT(UInt32 index,Int32* v);
            internal unsafe static VertexAttribI3ivEXT glVertexAttribI3ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3ui(UInt32 index,UInt32 x,UInt32 y,UInt32 z);
            internal static VertexAttribI3ui glVertexAttribI3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI3uiEXT(UInt32 index,UInt32 x,UInt32 y,UInt32 z);
            internal static VertexAttribI3uiEXT glVertexAttribI3uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3uiv(UInt32 index,UInt32* v);
            internal unsafe static VertexAttribI3uiv glVertexAttribI3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI3uivEXT(UInt32 index,UInt32* v);
            internal unsafe static VertexAttribI3uivEXT glVertexAttribI3uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4bv(UInt32 index,SByte* v);
            internal unsafe static VertexAttribI4bv glVertexAttribI4bv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4bvEXT(UInt32 index,SByte* v);
            internal unsafe static VertexAttribI4bvEXT glVertexAttribI4bvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4i(UInt32 index,Int32 x,Int32 y,Int32 z,Int32 w);
            internal static VertexAttribI4i glVertexAttribI4i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4iEXT(UInt32 index,Int32 x,Int32 y,Int32 z,Int32 w);
            internal static VertexAttribI4iEXT glVertexAttribI4iEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4iv(UInt32 index,Int32* v);
            internal unsafe static VertexAttribI4iv glVertexAttribI4iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ivEXT(UInt32 index,Int32* v);
            internal unsafe static VertexAttribI4ivEXT glVertexAttribI4ivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4sv(UInt32 index,Int16* v);
            internal unsafe static VertexAttribI4sv glVertexAttribI4sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4svEXT(UInt32 index,Int16* v);
            internal unsafe static VertexAttribI4svEXT glVertexAttribI4svEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ubv(UInt32 index,Byte* v);
            internal unsafe static VertexAttribI4ubv glVertexAttribI4ubv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4ubvEXT(UInt32 index,Byte* v);
            internal unsafe static VertexAttribI4ubvEXT glVertexAttribI4ubvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4ui(UInt32 index,UInt32 x,UInt32 y,UInt32 z,UInt32 w);
            internal static VertexAttribI4ui glVertexAttribI4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribI4uiEXT(UInt32 index,UInt32 x,UInt32 y,UInt32 z,UInt32 w);
            internal static VertexAttribI4uiEXT glVertexAttribI4uiEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4uiv(UInt32 index,UInt32* v);
            internal unsafe static VertexAttribI4uiv glVertexAttribI4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4uivEXT(UInt32 index,UInt32* v);
            internal unsafe static VertexAttribI4uivEXT glVertexAttribI4uivEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4usv(UInt32 index,UInt16* v);
            internal unsafe static VertexAttribI4usv glVertexAttribI4usv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribI4usvEXT(UInt32 index,UInt16* v);
            internal unsafe static VertexAttribI4usvEXT glVertexAttribI4usvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIFormatNV(UInt32 index,Int32 size,Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,Int32 stride);
            internal static VertexAttribIFormatNV glVertexAttribIFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIPointer(UInt32 index,Int32 size,Pencil.Gaming.Graphics.VertexAttribIPointerType type,Int32 stride,IntPtr pointer);
            internal static VertexAttribIPointer glVertexAttribIPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribIPointerEXT(UInt32 index,Int32 size,Pencil.Gaming.Graphics.NvVertexProgram4 type,Int32 stride,IntPtr pointer);
            internal static VertexAttribIPointerEXT glVertexAttribIPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1d(UInt32 index,Double x);
            internal static VertexAttribL1d glVertexAttribL1d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1dEXT(UInt32 index,Double x);
            internal static VertexAttribL1dEXT glVertexAttribL1dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1dv(UInt32 index,Double* v);
            internal unsafe static VertexAttribL1dv glVertexAttribL1dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1dvEXT(UInt32 index,Double* v);
            internal unsafe static VertexAttribL1dvEXT glVertexAttribL1dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1i64NV(UInt32 index,Int64 x);
            internal static VertexAttribL1i64NV glVertexAttribL1i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1i64vNV(UInt32 index,Int64* v);
            internal unsafe static VertexAttribL1i64vNV glVertexAttribL1i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL1ui64NV(UInt32 index,UInt64 x);
            internal static VertexAttribL1ui64NV glVertexAttribL1ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL1ui64vNV(UInt32 index,UInt64* v);
            internal unsafe static VertexAttribL1ui64vNV glVertexAttribL1ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2d(UInt32 index,Double x,Double y);
            internal static VertexAttribL2d glVertexAttribL2d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2dEXT(UInt32 index,Double x,Double y);
            internal static VertexAttribL2dEXT glVertexAttribL2dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2dv(UInt32 index,Double* v);
            internal unsafe static VertexAttribL2dv glVertexAttribL2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2dvEXT(UInt32 index,Double* v);
            internal unsafe static VertexAttribL2dvEXT glVertexAttribL2dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2i64NV(UInt32 index,Int64 x,Int64 y);
            internal static VertexAttribL2i64NV glVertexAttribL2i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2i64vNV(UInt32 index,Int64* v);
            internal unsafe static VertexAttribL2i64vNV glVertexAttribL2i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL2ui64NV(UInt32 index,UInt64 x,UInt64 y);
            internal static VertexAttribL2ui64NV glVertexAttribL2ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL2ui64vNV(UInt32 index,UInt64* v);
            internal unsafe static VertexAttribL2ui64vNV glVertexAttribL2ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3d(UInt32 index,Double x,Double y,Double z);
            internal static VertexAttribL3d glVertexAttribL3d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3dEXT(UInt32 index,Double x,Double y,Double z);
            internal static VertexAttribL3dEXT glVertexAttribL3dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3dv(UInt32 index,Double* v);
            internal unsafe static VertexAttribL3dv glVertexAttribL3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3dvEXT(UInt32 index,Double* v);
            internal unsafe static VertexAttribL3dvEXT glVertexAttribL3dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3i64NV(UInt32 index,Int64 x,Int64 y,Int64 z);
            internal static VertexAttribL3i64NV glVertexAttribL3i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3i64vNV(UInt32 index,Int64* v);
            internal unsafe static VertexAttribL3i64vNV glVertexAttribL3i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL3ui64NV(UInt32 index,UInt64 x,UInt64 y,UInt64 z);
            internal static VertexAttribL3ui64NV glVertexAttribL3ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL3ui64vNV(UInt32 index,UInt64* v);
            internal unsafe static VertexAttribL3ui64vNV glVertexAttribL3ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4d(UInt32 index,Double x,Double y,Double z,Double w);
            internal static VertexAttribL4d glVertexAttribL4d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4dEXT(UInt32 index,Double x,Double y,Double z,Double w);
            internal static VertexAttribL4dEXT glVertexAttribL4dEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4dv(UInt32 index,Double* v);
            internal unsafe static VertexAttribL4dv glVertexAttribL4dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4dvEXT(UInt32 index,Double* v);
            internal unsafe static VertexAttribL4dvEXT glVertexAttribL4dvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4i64NV(UInt32 index,Int64 x,Int64 y,Int64 z,Int64 w);
            internal static VertexAttribL4i64NV glVertexAttribL4i64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4i64vNV(UInt32 index,Int64* v);
            internal unsafe static VertexAttribL4i64vNV glVertexAttribL4i64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribL4ui64NV(UInt32 index,UInt64 x,UInt64 y,UInt64 z,UInt64 w);
            internal static VertexAttribL4ui64NV glVertexAttribL4ui64NV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribL4ui64vNV(UInt32 index,UInt64* v);
            internal unsafe static VertexAttribL4ui64vNV glVertexAttribL4ui64vNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribLFormatNV(UInt32 index,Int32 size,Pencil.Gaming.Graphics.NvVertexAttribInteger64bit type,Int32 stride);
            internal static VertexAttribLFormatNV glVertexAttribLFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribLPointer(UInt32 index,Int32 size,Pencil.Gaming.Graphics.VertexAttribDPointerType type,Int32 stride,IntPtr pointer);
            internal static VertexAttribLPointer glVertexAttribLPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribLPointerEXT(UInt32 index,Int32 size,Pencil.Gaming.Graphics.ExtVertexAttrib64bit type,Int32 stride,IntPtr pointer);
            internal static VertexAttribLPointerEXT glVertexAttribLPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP1ui(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32 value);
            internal static VertexAttribP1ui glVertexAttribP1ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP1uiv(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32* value);
            internal unsafe static VertexAttribP1uiv glVertexAttribP1uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP2ui(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32 value);
            internal static VertexAttribP2ui glVertexAttribP2ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP2uiv(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32* value);
            internal unsafe static VertexAttribP2uiv glVertexAttribP2uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP3ui(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32 value);
            internal static VertexAttribP3ui glVertexAttribP3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP3uiv(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32* value);
            internal unsafe static VertexAttribP3uiv glVertexAttribP3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribP4ui(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32 value);
            internal static VertexAttribP4ui glVertexAttribP4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribP4uiv(UInt32 index,Pencil.Gaming.Graphics.PackedPointerType type,bool normalized,UInt32* value);
            internal unsafe static VertexAttribP4uiv glVertexAttribP4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointer(UInt32 index,Int32 size,Pencil.Gaming.Graphics.VertexAttribPointerType type,bool normalized,Int32 stride,IntPtr pointer);
            internal static VertexAttribPointer glVertexAttribPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointerARB(UInt32 index,Int32 size,Pencil.Gaming.Graphics.VertexAttribPointerTypeArb type,bool normalized,Int32 stride,IntPtr pointer);
            internal static VertexAttribPointerARB glVertexAttribPointerARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexAttribPointerNV(UInt32 index,Int32 fsize,Pencil.Gaming.Graphics.VertexAttribParameterArb type,Int32 stride,IntPtr pointer);
            internal static VertexAttribPointerNV glVertexAttribPointerNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1dvNV(UInt32 index,Int32 count,Double* v);
            internal unsafe static VertexAttribs1dvNV glVertexAttribs1dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1fvNV(UInt32 index,Int32 count,Single* v);
            internal unsafe static VertexAttribs1fvNV glVertexAttribs1fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs1svNV(UInt32 index,Int32 count,Int16* v);
            internal unsafe static VertexAttribs1svNV glVertexAttribs1svNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2dvNV(UInt32 index,Int32 count,Double* v);
            internal unsafe static VertexAttribs2dvNV glVertexAttribs2dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2fvNV(UInt32 index,Int32 count,Single* v);
            internal unsafe static VertexAttribs2fvNV glVertexAttribs2fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs2svNV(UInt32 index,Int32 count,Int16* v);
            internal unsafe static VertexAttribs2svNV glVertexAttribs2svNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3dvNV(UInt32 index,Int32 count,Double* v);
            internal unsafe static VertexAttribs3dvNV glVertexAttribs3dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3fvNV(UInt32 index,Int32 count,Single* v);
            internal unsafe static VertexAttribs3fvNV glVertexAttribs3fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs3svNV(UInt32 index,Int32 count,Int16* v);
            internal unsafe static VertexAttribs3svNV glVertexAttribs3svNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4dvNV(UInt32 index,Int32 count,Double* v);
            internal unsafe static VertexAttribs4dvNV glVertexAttribs4dvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4fvNV(UInt32 index,Int32 count,Single* v);
            internal unsafe static VertexAttribs4fvNV glVertexAttribs4fvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4svNV(UInt32 index,Int32 count,Int16* v);
            internal unsafe static VertexAttribs4svNV glVertexAttribs4svNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexAttribs4ubvNV(UInt32 index,Int32 count,Byte* v);
            internal unsafe static VertexAttribs4ubvNV glVertexAttribs4ubvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendARB(Int32 count);
            internal static VertexBlendARB glVertexBlendARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendEnvfATI(Pencil.Gaming.Graphics.AtiVertexStreams pname,Single param);
            internal static VertexBlendEnvfATI glVertexBlendEnvfATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexBlendEnviATI(Pencil.Gaming.Graphics.AtiVertexStreams pname,Int32 param);
            internal static VertexBlendEnviATI glVertexBlendEnviATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexFormatNV(Int32 size,Pencil.Gaming.Graphics.NvVertexBufferUnifiedMemory type,Int32 stride);
            internal static VertexFormatNV glVertexFormatNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP2ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 value);
            internal static VertexP2ui glVertexP2ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP2uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* value);
            internal unsafe static VertexP2uiv glVertexP2uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP3ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 value);
            internal static VertexP3ui glVertexP3ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP3uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* value);
            internal unsafe static VertexP3uiv glVertexP3uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexP4ui(Pencil.Gaming.Graphics.PackedPointerType type,UInt32 value);
            internal static VertexP4ui glVertexP4ui;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexP4uiv(Pencil.Gaming.Graphics.PackedPointerType type,UInt32* value);
            internal unsafe static VertexP4uiv glVertexP4uiv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointer(Int32 size,Pencil.Gaming.Graphics.VertexPointerType type,Int32 stride,IntPtr pointer);
            internal static VertexPointer glVertexPointer;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointerEXT(Int32 size,Pencil.Gaming.Graphics.VertexPointerType type,Int32 stride,Int32 count,IntPtr pointer);
            internal static VertexPointerEXT glVertexPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointerListIBM(Int32 size,Pencil.Gaming.Graphics.VertexPointerType type,Int32 stride,IntPtr pointer,Int32 ptrstride);
            internal static VertexPointerListIBM glVertexPointerListIBM;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexPointervINTEL(Int32 size,Pencil.Gaming.Graphics.VertexPointerType type,IntPtr pointer);
            internal static VertexPointervINTEL glVertexPointervINTEL;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double x);
            internal static VertexStream1dATI glVertexStream1dATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double* coords);
            internal unsafe static VertexStream1dvATI glVertexStream1dvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single x);
            internal static VertexStream1fATI glVertexStream1fATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single* coords);
            internal unsafe static VertexStream1fvATI glVertexStream1fvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32 x);
            internal static VertexStream1iATI glVertexStream1iATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32* coords);
            internal unsafe static VertexStream1ivATI glVertexStream1ivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream1sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16 x);
            internal static VertexStream1sATI glVertexStream1sATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream1svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16* coords);
            internal unsafe static VertexStream1svATI glVertexStream1svATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double x,Double y);
            internal static VertexStream2dATI glVertexStream2dATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double* coords);
            internal unsafe static VertexStream2dvATI glVertexStream2dvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single x,Single y);
            internal static VertexStream2fATI glVertexStream2fATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single* coords);
            internal unsafe static VertexStream2fvATI glVertexStream2fvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32 x,Int32 y);
            internal static VertexStream2iATI glVertexStream2iATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32* coords);
            internal unsafe static VertexStream2ivATI glVertexStream2ivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream2sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16 x,Int16 y);
            internal static VertexStream2sATI glVertexStream2sATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream2svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16* coords);
            internal unsafe static VertexStream2svATI glVertexStream2svATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double x,Double y,Double z);
            internal static VertexStream3dATI glVertexStream3dATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double* coords);
            internal unsafe static VertexStream3dvATI glVertexStream3dvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single x,Single y,Single z);
            internal static VertexStream3fATI glVertexStream3fATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single* coords);
            internal unsafe static VertexStream3fvATI glVertexStream3fvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32 x,Int32 y,Int32 z);
            internal static VertexStream3iATI glVertexStream3iATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32* coords);
            internal unsafe static VertexStream3ivATI glVertexStream3ivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream3sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16 x,Int16 y,Int16 z);
            internal static VertexStream3sATI glVertexStream3sATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream3svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16* coords);
            internal unsafe static VertexStream3svATI glVertexStream3svATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4dATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double x,Double y,Double z,Double w);
            internal static VertexStream4dATI glVertexStream4dATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4dvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Double* coords);
            internal unsafe static VertexStream4dvATI glVertexStream4dvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4fATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single x,Single y,Single z,Single w);
            internal static VertexStream4fATI glVertexStream4fATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4fvATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Single* coords);
            internal unsafe static VertexStream4fvATI glVertexStream4fvATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4iATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32 x,Int32 y,Int32 z,Int32 w);
            internal static VertexStream4iATI glVertexStream4iATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4ivATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int32* coords);
            internal unsafe static VertexStream4ivATI glVertexStream4ivATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexStream4sATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16 x,Int16 y,Int16 z,Int16 w);
            internal static VertexStream4sATI glVertexStream4sATI;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexStream4svATI(Pencil.Gaming.Graphics.AtiVertexStreams stream,Int16* coords);
            internal unsafe static VertexStream4svATI glVertexStream4svATI;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeightfEXT(Single weight);
            internal static VertexWeightfEXT glVertexWeightfEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VertexWeightfvEXT(Single* weight);
            internal unsafe static VertexWeightfvEXT glVertexWeightfvEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void VertexWeightPointerEXT(Int32 size,Pencil.Gaming.Graphics.ExtVertexWeighting type,Int32 stride,IntPtr pointer);
            internal static VertexWeightPointerEXT glVertexWeightPointerEXT;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate Pencil.Gaming.Graphics.NvVideoCapture VideoCaptureNV(UInt32 video_capture_slot,[OutAttribute] UInt32* sequence_num,[OutAttribute] UInt64* capture_time);
            internal unsafe static VideoCaptureNV glVideoCaptureNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VideoCaptureStreamParameterdvNV(UInt32 video_capture_slot,UInt32 stream,Pencil.Gaming.Graphics.NvVideoCapture pname,Double* @params);
            internal unsafe static VideoCaptureStreamParameterdvNV glVideoCaptureStreamParameterdvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VideoCaptureStreamParameterfvNV(UInt32 video_capture_slot,UInt32 stream,Pencil.Gaming.Graphics.NvVideoCapture pname,Single* @params);
            internal unsafe static VideoCaptureStreamParameterfvNV glVideoCaptureStreamParameterfvNV;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void VideoCaptureStreamParameterivNV(UInt32 video_capture_slot,UInt32 stream,Pencil.Gaming.Graphics.NvVideoCapture pname,Int32* @params);
            internal unsafe static VideoCaptureStreamParameterivNV glVideoCaptureStreamParameterivNV;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void Viewport(Int32 x,Int32 y,Int32 width,Int32 height);
            internal static Viewport glViewport;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ViewportArrayv(UInt32 first,Int32 count,Single* v);
            internal unsafe static ViewportArrayv glViewportArrayv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void ViewportIndexedf(UInt32 index,Single x,Single y,Single w,Single h);
            internal static ViewportIndexedf glViewportIndexedf;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void ViewportIndexedfv(UInt32 index,Single* v);
            internal unsafe static ViewportIndexedfv glViewportIndexedfv;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WaitSync(IntPtr sync,UInt32 flags,UInt64 timeout);
            internal static WaitSync glWaitSync;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightbvARB(Int32 size,SByte* weights);
            internal unsafe static WeightbvARB glWeightbvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightdvARB(Int32 size,Double* weights);
            internal unsafe static WeightdvARB glWeightdvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightfvARB(Int32 size,Single* weights);
            internal unsafe static WeightfvARB glWeightfvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightivARB(Int32 size,Int32* weights);
            internal unsafe static WeightivARB glWeightivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WeightPointerARB(Int32 size,Pencil.Gaming.Graphics.ArbVertexBlend type,Int32 stride,IntPtr pointer);
            internal static WeightPointerARB glWeightPointerARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightsvARB(Int32 size,Int16* weights);
            internal unsafe static WeightsvARB glWeightsvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightubvARB(Int32 size,Byte* weights);
            internal unsafe static WeightubvARB glWeightubvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightuivARB(Int32 size,UInt32* weights);
            internal unsafe static WeightuivARB glWeightuivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WeightusvARB(Int32 size,UInt16* weights);
            internal unsafe static WeightusvARB glWeightusvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2d(Double x,Double y);
            internal static WindowPos2d glWindowPos2d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2dARB(Double x,Double y);
            internal static WindowPos2dARB glWindowPos2dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2dMESA(Double x,Double y);
            internal static WindowPos2dMESA glWindowPos2dMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dv(Double* v);
            internal unsafe static WindowPos2dv glWindowPos2dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dvARB(Double* v);
            internal unsafe static WindowPos2dvARB glWindowPos2dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2dvMESA(Double* v);
            internal unsafe static WindowPos2dvMESA glWindowPos2dvMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2f(Single x,Single y);
            internal static WindowPos2f glWindowPos2f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2fARB(Single x,Single y);
            internal static WindowPos2fARB glWindowPos2fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2fMESA(Single x,Single y);
            internal static WindowPos2fMESA glWindowPos2fMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fv(Single* v);
            internal unsafe static WindowPos2fv glWindowPos2fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fvARB(Single* v);
            internal unsafe static WindowPos2fvARB glWindowPos2fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2fvMESA(Single* v);
            internal unsafe static WindowPos2fvMESA glWindowPos2fvMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2i(Int32 x,Int32 y);
            internal static WindowPos2i glWindowPos2i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2iARB(Int32 x,Int32 y);
            internal static WindowPos2iARB glWindowPos2iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2iMESA(Int32 x,Int32 y);
            internal static WindowPos2iMESA glWindowPos2iMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2iv(Int32* v);
            internal unsafe static WindowPos2iv glWindowPos2iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2ivARB(Int32* v);
            internal unsafe static WindowPos2ivARB glWindowPos2ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2ivMESA(Int32* v);
            internal unsafe static WindowPos2ivMESA glWindowPos2ivMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2s(Int16 x,Int16 y);
            internal static WindowPos2s glWindowPos2s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2sARB(Int16 x,Int16 y);
            internal static WindowPos2sARB glWindowPos2sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos2sMESA(Int16 x,Int16 y);
            internal static WindowPos2sMESA glWindowPos2sMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2sv(Int16* v);
            internal unsafe static WindowPos2sv glWindowPos2sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2svARB(Int16* v);
            internal unsafe static WindowPos2svARB glWindowPos2svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos2svMESA(Int16* v);
            internal unsafe static WindowPos2svMESA glWindowPos2svMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3d(Double x,Double y,Double z);
            internal static WindowPos3d glWindowPos3d;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3dARB(Double x,Double y,Double z);
            internal static WindowPos3dARB glWindowPos3dARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3dMESA(Double x,Double y,Double z);
            internal static WindowPos3dMESA glWindowPos3dMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dv(Double* v);
            internal unsafe static WindowPos3dv glWindowPos3dv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dvARB(Double* v);
            internal unsafe static WindowPos3dvARB glWindowPos3dvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3dvMESA(Double* v);
            internal unsafe static WindowPos3dvMESA glWindowPos3dvMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3f(Single x,Single y,Single z);
            internal static WindowPos3f glWindowPos3f;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3fARB(Single x,Single y,Single z);
            internal static WindowPos3fARB glWindowPos3fARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3fMESA(Single x,Single y,Single z);
            internal static WindowPos3fMESA glWindowPos3fMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fv(Single* v);
            internal unsafe static WindowPos3fv glWindowPos3fv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fvARB(Single* v);
            internal unsafe static WindowPos3fvARB glWindowPos3fvARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3fvMESA(Single* v);
            internal unsafe static WindowPos3fvMESA glWindowPos3fvMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3i(Int32 x,Int32 y,Int32 z);
            internal static WindowPos3i glWindowPos3i;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3iARB(Int32 x,Int32 y,Int32 z);
            internal static WindowPos3iARB glWindowPos3iARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3iMESA(Int32 x,Int32 y,Int32 z);
            internal static WindowPos3iMESA glWindowPos3iMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3iv(Int32* v);
            internal unsafe static WindowPos3iv glWindowPos3iv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3ivARB(Int32* v);
            internal unsafe static WindowPos3ivARB glWindowPos3ivARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3ivMESA(Int32* v);
            internal unsafe static WindowPos3ivMESA glWindowPos3ivMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3s(Int16 x,Int16 y,Int16 z);
            internal static WindowPos3s glWindowPos3s;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3sARB(Int16 x,Int16 y,Int16 z);
            internal static WindowPos3sARB glWindowPos3sARB;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos3sMESA(Int16 x,Int16 y,Int16 z);
            internal static WindowPos3sMESA glWindowPos3sMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3sv(Int16* v);
            internal unsafe static WindowPos3sv glWindowPos3sv;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3svARB(Int16* v);
            internal unsafe static WindowPos3svARB glWindowPos3svARB;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos3svMESA(Int16* v);
            internal unsafe static WindowPos3svMESA glWindowPos3svMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4dMESA(Double x,Double y,Double z,Double w);
            internal static WindowPos4dMESA glWindowPos4dMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4dvMESA(Double* v);
            internal unsafe static WindowPos4dvMESA glWindowPos4dvMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4fMESA(Single x,Single y,Single z,Single w);
            internal static WindowPos4fMESA glWindowPos4fMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4fvMESA(Single* v);
            internal unsafe static WindowPos4fvMESA glWindowPos4fvMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4iMESA(Int32 x,Int32 y,Int32 z,Int32 w);
            internal static WindowPos4iMESA glWindowPos4iMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4ivMESA(Int32* v);
            internal unsafe static WindowPos4ivMESA glWindowPos4ivMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WindowPos4sMESA(Int16 x,Int16 y,Int16 z,Int16 w);
            internal static WindowPos4sMESA glWindowPos4sMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal unsafe delegate void WindowPos4svMESA(Int16* v);
            internal unsafe static WindowPos4svMESA glWindowPos4svMESA;
            [SuppressUnmanagedCodeSecurity()]
            internal delegate void WriteMaskEXT(UInt32 res,UInt32 @in,Pencil.Gaming.Graphics.ExtVertexShader outX,Pencil.Gaming.Graphics.ExtVertexShader outY,Pencil.Gaming.Graphics.ExtVertexShader outZ,Pencil.Gaming.Graphics.ExtVertexShader outW);
            internal static WriteMaskEXT glWriteMaskEXT;
        }
    }
}
