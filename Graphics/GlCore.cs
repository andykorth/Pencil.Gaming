using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    internal static unsafe class GlCore {
        [DllImport("opengl32.dll")]
        internal static extern void glAccum(int op, float value);
        [DllImport("opengl32.dll")]
        internal static extern void glAlphaFunc(int func, float @ref);
        [DllImport("opengl32.dll")]
        internal static extern bool glAreTexturesResident(int n, uint* textures, bool* residences);
        [DllImport("opengl32.dll")]
        internal static extern void glArrayElement(int i);
        [DllImport("opengl32.dll")]
        internal static extern void glBegin(int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glBindTexture(int target, uint texture);
        [DllImport("opengl32.dll")]
        internal static extern void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte * bitmap);
        [DllImport("opengl32.dll")]
        internal static extern void glBlendFunc(int sfactor, int dfactor);
        [DllImport("opengl32.dll")]
        internal static extern void glCallList(uint list);
        [DllImport("opengl32.dll")]
        internal static extern void glCallLists(int n, int type, IntPtr lists);
        [DllImport("opengl32.dll")]
        internal static extern void glClear(int mask);
        [DllImport("opengl32.dll")]
        internal static extern void glClearAccum(float red, float green, float blue, float alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glClearColor(float red, float green, float blue, float alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glClearDepth(double depth);
        [DllImport("opengl32.dll")]
        internal static extern void glClearIndex(float c);
        [DllImport("opengl32.dll")]
        internal static extern void glClearStencil(int s);
        [DllImport("opengl32.dll")]
        internal static extern void glClipPlane(int plane, double* equation);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3b(sbyte red, sbyte green, sbyte blue);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3bv(sbyte* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3d(double red, double green, double blue);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3f(float red, float green, float blue);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3i(int red, int green, int blue);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3s(short red, short green, short blue);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3ub(byte red, byte green, byte blue);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3ubv(byte* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3ui(uint red, uint green, uint blue);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3uiv(uint* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3us(ushort red, ushort green, ushort blue);
        [DllImport("opengl32.dll")]
        internal static extern void glColor3usv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4bv(sbyte* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4d(double red, double green, double blue, double alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4f(float red, float green, float blue, float alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4i(int red, int green, int blue, int alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4s(short red, short green, short blue, short alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4ub(byte red, byte green, byte blue, byte alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4ubv(byte* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4ui(uint red, uint green, uint blue, uint alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4uiv(uint* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColor4usv(ushort* v);
        [DllImport("opengl32.dll")]
        internal static extern void glColorMask(bool red, bool green, bool blue, bool alpha);
        [DllImport("opengl32.dll")]
        internal static extern void glColorMaterial(int face, int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glColorPointer(int size, int type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll")]
        internal static extern void glCopyPixels(int x, int y, int width, int height, int type);
        [DllImport("opengl32.dll")]
        internal static extern void glCopyTexImage1D(int target, int level, int internalFormat, int x, int y, int width, int border);
        [DllImport("opengl32.dll")]
        internal static extern void glCopyTexImage2D(int target, int level, int internalFormat, int x, int y, int width, int height, int border);
        [DllImport("opengl32.dll")]
        internal static extern void glCopyTexSubImage1D(int target, int level, int xoffset, int x, int y, int width);
        [DllImport("opengl32.dll")]
        internal static extern void glCopyTexSubImage2D(int target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        [DllImport("opengl32.dll")]
        internal static extern void glCullFace(int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glDeleteLists(uint list, int range);
        [DllImport("opengl32.dll")]
        internal static extern void glDeleteTextures(int n, uint* textures);
        [DllImport("opengl32.dll")]
        internal static extern void glDepthFunc(int func);
        [DllImport("opengl32.dll")]
        internal static extern void glDepthMask(bool flag);
        [DllImport("opengl32.dll")]
        internal static extern void glDepthRange(double zNear, double zFar);
        [DllImport("opengl32.dll")]
        internal static extern void glDisable(int cap);
        [DllImport("opengl32.dll")]
        internal static extern void glDisableClientState(int array);
        [DllImport("opengl32.dll")]
        internal static extern void glDrawArrays(int mode, int first, int count);
        [DllImport("opengl32.dll")]
        internal static extern void glDrawBuffer(int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glDrawElements(int mode, int count, int type, IntPtr indices);
        [DllImport("opengl32.dll")]
        internal static extern void glDrawPixels(int width, int height, int format, int type, IntPtr pixels);
        [DllImport("opengl32.dll")]
        internal static extern void glEdgeFlag(bool flag);
        [DllImport("opengl32.dll")]
        internal static extern void glEdgeFlagPointer(int stride, IntPtr pointer);
        [DllImport("opengl32.dll")]
        internal static extern void glEdgeFlagv(bool* flag);
        [DllImport("opengl32.dll")]
        internal static extern void glEnable(int cap);
        [DllImport("opengl32.dll")]
        internal static extern void glEnableClientState(int array);
        [DllImport("opengl32.dll")]
        internal static extern void glEnd();
        [DllImport("opengl32.dll")]
        internal static extern void glEndList();
        [DllImport("opengl32.dll")]
        internal static extern void glEvalCoord1d(double u);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalCoord1dv(double* u);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalCoord1f(float u);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalCoord1fv(float* u);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalCoord2d(double u, double v);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalCoord2dv(double* u);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalCoord2f(float u, float v);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalCoord2fv(float* u);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalMesh1(int mode, int i1, int i2);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalMesh2(int mode, int i1, int i2, int j1, int j2);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalPoint1(int i);
        [DllImport("opengl32.dll")]
        internal static extern void glEvalPoint2(int i, int j);
        [DllImport("opengl32.dll")]
        internal static extern void glFeedbackBuffer(int size, int type, float* buffer);
        [DllImport("opengl32.dll")]
        internal static extern void glFinish();
        [DllImport("opengl32.dll")]
        internal static extern void glFlush();
        [DllImport("opengl32.dll")]
        internal static extern void glFogf(int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glFogfv(int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glFogi(int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glFogiv(int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glFrontFace(int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport("opengl32.dll")]
        internal static extern int glGenLists(int range);
        [DllImport("opengl32.dll")]
        internal static extern void glGenTextures(int n, uint* textures);
        [DllImport("opengl32.dll")]
        internal static extern void glGetBooleanv(int pname, bool* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetClipPlane(int plane, double* equation);
        [DllImport("opengl32.dll")]
        internal static extern void glGetDoublev(int pname, double* @params);
        [DllImport("opengl32.dll")]
        internal static extern int glGetError();
        [DllImport("opengl32.dll")]
        internal static extern void glGetFloatv(int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetIntegerv(int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetLightfv(int light, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetLightiv(int light, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetMapdv(int target, int query, double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glGetMapfv(int target, int query, float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glGetMapiv(int target, int query, int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glGetMaterialfv(int face, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetMaterialiv(int face, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetPixelMapfv(int map, float* values);
        [DllImport("opengl32.dll")]
        internal static extern void glGetPixelMapuiv(int map, uint* values);
        [DllImport("opengl32.dll")]
        internal static extern void glGetPixelMapusv(int map, ushort* values);
        [DllImport("opengl32.dll")]
        internal static extern void glGetPointerv(int pname, IntPtr @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetPolygonStipple(byte* mask);
        [DllImport("opengl32.dll")]
        internal static extern IntPtr glGetString(int name);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexEnvfv(int target, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexEnviv(int target, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexGendv(int coord, int pname, double* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexGenfv(int coord, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexGeniv(int coord, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexImage(int target, int level, int format, int type, IntPtr pixels);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexLevelParameterfv(int target, int level, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexLevelParameteriv(int target, int level, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexParameterfv(int target, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glGetTexParameteriv(int target, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glHint(int target, int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexMask(uint mask);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexPointer(int type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexd(double c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexdv(double* c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexf(float c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexfv(float* c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexi(int c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexiv(int* c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexs(short c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexsv(short* c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexub(byte c);
        [DllImport("opengl32.dll")]
        internal static extern void glIndexubv(byte* c);
        [DllImport("opengl32.dll")]
        internal static extern void glInitNames();
        [DllImport("opengl32.dll")]
        internal static extern void interleavedArrays(int format, int stride, IntPtr pointer);
        [DllImport("opengl32.dll")]
        internal static extern bool glIsEnabled(int cap);
        [DllImport("opengl32.dll")]
        internal static extern bool glIsList(uint list);
        [DllImport("opengl32.dll")]
        internal static extern bool glIsTexture(uint texture);
        [DllImport("opengl32.dll")]
        internal static extern void glLightModelf(int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glLightModelfv(int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glLightModeli(int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glLightModeliv(int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glLightf(int light, int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glLightfv(int light, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glLighti(int light, int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glLightiv(int light, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glLineStipple(int factor, ushort pattern);
        [DllImport("opengl32.dll")]
        internal static extern void glLineWidth(float width);
        [DllImport("opengl32.dll")]
        internal static extern void glListBase(uint @base);
        [DllImport("opengl32.dll")]
        internal static extern void glLoadIdentity();
        [DllImport("opengl32.dll")]
        internal static extern void glLoadMatrixd(double* m);
        [DllImport("opengl32.dll")]
        internal static extern void glLoadMatrixf(float* m);
        [DllImport("opengl32.dll")]
        internal static extern void glLoadName(uint name);
        [DllImport("opengl32.dll")]
        internal static extern void glLogicOp(int opcode);
        [DllImport("opengl32.dll")]
        internal static extern void glMap1d(int target, double u1, double u2, int stride, int order, double* points);
        [DllImport("opengl32.dll")]
        internal static extern void glMap1f(int target, float u1, float u2, int stride, int order, float* points);
        [DllImport("opengl32.dll")]
        internal static extern void glMap2d(int target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);
        [DllImport("opengl32.dll")]
        internal static extern void glMap2f(int target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);
        [DllImport("opengl32.dll")]
        internal static extern void glMapGrid1d(int un, double u1, double u2);
        [DllImport("opengl32.dll")]
        internal static extern void glMapGrid1f(int un, float u1, float u2);
        [DllImport("opengl32.dll")]
        internal static extern void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);
        [DllImport("opengl32.dll")]
        internal static extern void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);
        [DllImport("opengl32.dll")]
        internal static extern void glMaterialf(int face, int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glMaterialfv(int face, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glMateriali(int face, int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glMaterialiv(int face, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glMatrixMode(int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glMultMatrixd(double* m);
        [DllImport("opengl32.dll")]
        internal static extern void glMultMatrixf(float* m);
        [DllImport("opengl32.dll")]
        internal static extern void glNewList(uint list, int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3b(sbyte nx, sbyte ny, sbyte nz);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3bv(sbyte* v);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3d(double nx, double ny, double nz);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3f(float nx, float ny, float nz);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3i(int nx, int ny, int nz);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3s(short nx, short ny, short nz);
        [DllImport("opengl32.dll")]
        internal static extern void glNormal3sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glNormalPointer(int type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll")]
        internal static extern void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);
        [DllImport("opengl32.dll")]
        internal static extern void glPassThrough(float token);
        [DllImport("opengl32.dll")]
        internal static extern void glPixelMapfv(int map, int mapsize, float* values);
        [DllImport("opengl32.dll")]
        internal static extern void glPixelMapuiv(int map, int mapsize, uint* values);
        [DllImport("opengl32.dll")]
        internal static extern void glPixelMapusv(int map, int mapsize, ushort* values);
        [DllImport("opengl32.dll")]
        internal static extern void glPixelStoref(int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glPixelStorei(int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glPixelTransferf(int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glPixelTransferi(int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glPixelZoom(float xfactor, float yfactor);
        [DllImport("opengl32.dll")]
        internal static extern void glPointSize(float size);
        [DllImport("opengl32.dll")]
        internal static extern void glPolygonMode(int face, int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glPolygonOffset(float factor, float units);
        [DllImport("opengl32.dll")]
        internal static extern void glPolygonStipple(byte* mask);
        [DllImport("opengl32.dll")]
        internal static extern void glPopAttrib();
        [DllImport("opengl32.dll")]
        internal static extern void glPopClientAttrib();
        [DllImport("opengl32.dll")]
        internal static extern void glPopMatrix();
        [DllImport("opengl32.dll")]
        internal static extern void glPopName();
        [DllImport("opengl32.dll")]
        internal static extern void glPrioritizeTextures(int n, uint* textures, float* priorities);
        [DllImport("opengl32.dll")]
        internal static extern void glPushAttrib(int mask);
        [DllImport("opengl32.dll")]
        internal static extern void glPushClientAttrib(int mask);
        [DllImport("opengl32.dll")]
        internal static extern void glPushMatrix();
        [DllImport("opengl32.dll")]
        internal static extern void glPushName(uint name);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos2d(double x, double y);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos2dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos2f(float x, float y);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos2fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos2i(int x, int y);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos2iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos2s(short x, short y);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos2sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos3d(double x, double y, double z);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos3dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos3f(float x, float y, float z);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos3fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos3i(int x, int y, int z);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos3iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos3s(short x, short y, short z);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos3sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos4d(double x, double y, double z, double w);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos4dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos4f(float x, float y, float z, float w);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos4fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos4i(int x, int y, int z, int w);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos4iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos4s(short x, short y, short z, short w);
        [DllImport("opengl32.dll")]
        internal static extern void glRasterPos4sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glReadBuffer(int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glReadPixels(int x, int y, int width, int height, int format, int type, IntPtr pixels);
        [DllImport("opengl32.dll")]
        internal static extern void glRectd(double x1, double y1, double x2, double y2);
        [DllImport("opengl32.dll")]
        internal static extern void glRectdv(double* v1, double* v2);
        [DllImport("opengl32.dll")]
        internal static extern void glRectf(float x1, float y1, float x2, float y2);
        [DllImport("opengl32.dll")]
        internal static extern void glRectfv(float* v1, float* v2);
        [DllImport("opengl32.dll")]
        internal static extern void glRecti(int x1, int y1, int x2, int y2);
        [DllImport("opengl32.dll")]
        internal static extern void glRectiv(int* v1, int* v2);
        [DllImport("opengl32.dll")]
        internal static extern void glRects(short x1, short y1, short x2, short y2);
        [DllImport("opengl32.dll")]
        internal static extern void glRectsv(short* v1, short* v2);
        [DllImport("opengl32.dll")]
        internal static extern int glRenderMode(int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glRotated(double angle, double x, double y, double z);
        [DllImport("opengl32.dll")]
        internal static extern void glRotatef(float angle, float x, float y, float z);
        [DllImport("opengl32.dll")]
        internal static extern void glScaled(double x, double y, double z);
        [DllImport("opengl32.dll")]
        internal static extern void glScalef(float x, float y, float z);
        [DllImport("opengl32.dll")]
        internal static extern void glScissor(int x, int y, int width, int height);
        [DllImport("opengl32.dll")]
        internal static extern void glSelectBuffer(int size, uint* buffer);
        [DllImport("opengl32.dll")]
        internal static extern void glShadeModel(int mode);
        [DllImport("opengl32.dll")]
        internal static extern void glStencilFunc(int func, int @ref, uint mask);
        [DllImport("opengl32.dll")]
        internal static extern void glStencilMask(uint mask);
        [DllImport("opengl32.dll")]
        internal static extern void glStencilOp(int fail, int zfail, int zpass);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord1d(double s);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord1dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord1f(float s);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord1fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord1i(int s);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord1iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord1s(short s);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord1sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord2d(double s, double t);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord2dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord2f(float s, float t);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord2fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord2i(int s, int t);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord2iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord2s(short s, short t);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord2sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord3d(double s, double t, double r);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord3dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord3f(float s, float t, float r);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord3fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord3i(int s, int t, int r);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord3iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord3s(short s, short t, short r);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord3sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord4d(double s, double t, double r, double q);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord4dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord4f(float s, float t, float r, float q);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord4fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord4i(int s, int t, int r, int q);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord4iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord4s(short s, short t, short r, short q);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoord4sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glTexCoordPointer(int size, int type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll")]
        internal static extern void glTexEnvf(int target, int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glTexEnvfv(int target, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glTexEnvi(int target, int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glTexEnviv(int target, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glTexGend(int coord, int pname, double param);
        [DllImport("opengl32.dll")]
        internal static extern void glTexGendv(int coord, int pname, double* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glTexGenf(int coord, int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glTexGenfv(int coord, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glTexGeni(int coord, int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glTexGeniv(int coord, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glTexImage1D(int target, int level, int internalformat, int width, int border, int format, int type, IntPtr pixels);
        [DllImport("opengl32.dll")]
        internal static extern void glTexImage2D(int target, int level, int internalformat, int width, int height, int border, int format, int type, IntPtr pixels);
        [DllImport("opengl32.dll")]
        internal static extern void glTexParameterf(int target, int pname, float param);
        [DllImport("opengl32.dll")]
        internal static extern void glTexParameterfv(int target, int pname, float* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glTexParameteri(int target, int pname, int param);
        [DllImport("opengl32.dll")]
        internal static extern void glTexParameteriv(int target, int pname, int* @params);
        [DllImport("opengl32.dll")]
        internal static extern void glTexSubImage1D(int target, int level, int xoffset, int width, int format, int type, IntPtr pixels);
        [DllImport("opengl32.dll")]
        internal static extern void glTexSubImage2D(int target, int level, int xoffset, int yoffset, int width, int height, int format, int type, IntPtr pixels);
        [DllImport("opengl32.dll")]
        internal static extern void glTranslated(double x, double y, double z);
        [DllImport("opengl32.dll")]
        internal static extern void glTranslatef(float x, float y, float z);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex2d(double x, double y);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex2dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex2f(float x, float y);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex2fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex2i(int x, int y);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex2iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex2s(short x, short y);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex2sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex3d(double x, double y, double z);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex3dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex3f(float x, float y, float z);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex3fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex3i(int x, int y, int z);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex3iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex3s(short x, short y, short z);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex3sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex4d(double x, double y, double z, double w);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex4dv(double* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex4f(float x, float y, float z, float w);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex4fv(float* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex4i(int x, int y, int z, int w);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex4iv(int* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex4s(short x, short y, short z, short w);
        [DllImport("opengl32.dll")]
        internal static extern void glVertex4sv(short* v);
        [DllImport("opengl32.dll")]
        internal static extern void glVertexPointer(int size, int type, int stride, IntPtr pointer);
        [DllImport("opengl32.dll")]
        internal static extern void glViewport(int x, int y, int width, int height);
    }
}
