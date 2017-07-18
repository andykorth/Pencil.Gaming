#region License
// Copyright (c) 2017 Antonie Blom
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;

namespace Pencil.Gaming {
	public enum KeyState {
		Release = 0,
		Press = 1,
		Repeat = 2
	}

	public enum ButtonState {
		Release = 0,
		Press = 1
	}

	public enum Key {
		Unknown = -1,
		Space = 32,
		Apostrophe = 39  /* ' */,
		Comma = 44  /* , */,
		Minus = 45  /* - */,
		Period = 46  /* . */,
		Slash = 47  /* / */,
		Zero = 48,
		One = 49,
		Two = 50,
		Three = 51,
		Four = 52,
		Five = 53,
		Six = 54,
		Seven = 55,
		Eight = 56,
		Nine = 57,
		Semicolon = 59  /* ; */,
		Equal = 61  /* = */,
		A = 65,
		B = 66,
		C = 67,
		D = 68,
		E = 69,
		F = 70,
		G = 71,
		H = 72,
		I = 73,
		J = 74,
		K = 75,
		L = 76,
		M = 77,
		N = 78,
		O = 79,
		P = 80,
		Q = 81,
		R = 82,
		S = 83,
		T = 84,
		U = 85,
		V = 86,
		W = 87,
		X = 88,
		Y = 89,
		Z = 90,
		LeftBracket = 91  /* [ */,
		Backslash = 92  /* \ */,
		RightBracket = 93  /* ] */,
		GraveAccent = 96  /* ` */,
		World1 = 161 /* non-US #1 */,
		World2 = 162 /* non-US #2 */,
		Escape = 256,
		Enter = 257,
		Tab = 258,
		Backspace = 259,
		Insert = 260,
		Delete = 261,
		Right = 262,
		Left = 263,
		Down = 264,
		Up = 265,
		PageUp = 266,
		PageDown = 267,
		Home = 268,
		End = 269,
		CapsLock = 280,
		ScrollLock = 281,
		NumLock = 282,
		PrintScreen = 283,
		Pause = 284,
		F1 = 290,
		F2 = 291,
		F3 = 292,
		F4 = 293,
		F5 = 294,
		F6 = 295,
		F7 = 296,
		F8 = 297,
		F9 = 298,
		F10 = 299,
		F11 = 300,
		F12 = 301,
		F13 = 302,
		F14 = 303,
		F15 = 304,
		F16 = 305,
		F17 = 306,
		F18 = 307,
		F19 = 308,
		F20 = 309,
		F21 = 310,
		F22 = 311,
		F23 = 312,
		F24 = 313,
		F25 = 314,
		KP0 = 320,
		KP1 = 321,
		KP2 = 322,
		KP3 = 323,
		KP4 = 324,
		KP5 = 325,
		KP6 = 326,
		KP7 = 327,
		KP8 = 328,
		KP9 = 329,
		KPDecimal = 330,
		KPDivide = 331,
		KPMultiply = 332,
		KPSubtract = 333,
		KPAdd = 334,
		KPEnter = 335,
		KPEqual = 336,
		LeftShift = 340,
		LeftControl = 341,
		LeftAlt = 342,
		LeftSuper = 343,
		RightShift = 344,
		RightControL = 345,
		RightAlt = 346,
		RightSuper = 347,
		Menu = 348,
		Last = Menu
	}

	[Flags]
	public enum KeyModifiers {
		Shift = 0x0001,
		Control = 0x0002,
		Alt = 0x0004,
		Super = 0x0008
	}

	public enum MouseButton {
		Button1 = 0,
		Button2 = 1,
		Button3 = 2,
		Button4 = 3,
		Button5 = 4,
		Button6 = 5,
		Button7 = 6,
		Button8 = 7,
		ButtonLast = Button8,
		ButtonLeft = Button1,
		ButtonRight = Button2,
		ButtonMiddle = Button3
	}

	public enum Joystick {
		Joystick1 = 0,
		Joystick2 = 1,
		Joystick3 = 2,
		Joystick4 = 3,
		Joystick5 = 4,
		Joystick6 = 5,
		Joystick7 = 6,
		Joystick8 = 7,
		Joystick9 = 8,
		Joystick10 = 9,
		Joystick11 = 10,
		Joystick12 = 11,
		Joystick13 = 12,
		Joystick14 = 13,
		Joystick15 = 14,
		Joystick16 = 15,
		JoystickLast = Joystick16
	}

	public enum GlfwError {
		NotInitialized = 0x00010001,
		NoCurrentContext = 0x00010002,
		InvalidEnum = 0x00010003,
		InvalidValue = 0x00010004,
		OutOfMemory = 0x00010005,
		OpenGLAPIUnavailable = 0x00010006,
		VersionUnavailable = 0x00010007,
		PlatformError = 0x00010008,
		FormatUnavailable = 0x00010009,
		NoWindowContext = 0x0001000A
	}

	public enum WindowAttrib {
		Focused = 0x00020001,
		Iconified = 0x00020002,
		Resizable = 0x00020003,
		Visible = 0x00020004,
		Decorated = 0x00020005,
		Floating = 0x00020007,
		Maximized = 0x00020008
	}

	public enum WindowHint {
		Focused = 0x00020001,
		Iconified = 0x00020002,
		Resizable = 0x00020003,
		Visible = 0x00020004,
		Decorated = 0x00020005,
		AutoIconify = 0x00020006,
		Floating = 0x00020007,
		Maximized = 0x00020008,
		RedBits = 0x00021001,
		GreenBits = 0x00021002,
		BlueBits = 0x00021003,
		AlphaBits = 0x00021004,
		DepthBits = 0x00021005,
		StencilBits = 0x00021006,
		AccumRedBits = 0x00021007,
		AccumGreenBits = 0x00021008,
		AccumBlueBits = 0x00021009,
		AccumAlphaBits = 0x0002100A,
		AuxBuffers = 0x0002100B,
		Stereo = 0x0002100C,
		Samples = 0x0002100D,
		SRGBCapable = 0x0002100E,
		RefreshRate = 0x0002100F,
		Doublebuffer = 0x00021010,
		ClientOpenGLAPI = 0x00022001,
		ContextVersionMajor = 0x00022002,
		ContextVersionMinor = 0x00022003,
		ContextRevision = 0x00022004,
		ContextRobustness = 0x00022005,
		OpenGLForwardCompat = 0x00022006,
		OpenGLDebugContext = 0x00022007,
		OpenGLProfile = 0x00022008,
		ContextReleaseBehavior = 0x00022009,
		ContextNoError = 0x0002200A,
		ContextCreationOpenGLAPI = 0x0002200B
	}

	public enum OpenGLAPI {
		NoAPI = 0,
		OpenGLAPI = 0x00030001,
		OpenGLESAPI = 0x00030002,
	}

	public enum Robustness {
		NoRobustness = 0,
		NoResetNotification = 0x00031001,
		LostContextOnReset = 0x00031002
	}

	public enum OpenGLProfile {
		OpenGLAnyProfile = 0,
		OpenGLCoreProfile = 0x00032001,
		OpenGLCompatProfile = 0x00032002
	}

	public enum InputMode {
		Cursor = 0x00033001,
		StickyKeys = 0x00033002,
		StickyMouseButtons = 0x00033003
	}

	public enum CursorMode {
		CursorNormal = 0x00034001,
		CursorHidden = 0x00034002,
		CursorDisabled = 0x00034003
	}

	public enum ReleaseBehavior {
		AnyReleaseBehavior = 0,
		ReleaseBehaviorFlush = 0x00035001,
		ReleaseBehaviorNone = 0x00035002
	}

	public enum ContextOpenGLAPI {
		NativeContextOpenGLAPI = 0x00036001,
		EGLContextOpenGLAPI = 0x00036002
	}

	public enum CursorShape {
		ArrowCursor = 0x00036001,
		IbeamCursor = 0x00036002,
		CrosshairCursor = 0x00036003,
		HandCursor = 0x00036004,
		HResizeCursor = 0x00036005,
		VResizeCursor = 0x00036006
	}

	public enum ConnectionState {
		Connected = 0x00040001,
		Disconnected = 0x00040002
	}


	// This is a set of references to the functions that
	// Pencil.Gaming actually passes to GLFW (they are
	// wrappers around the functions that the user passes
	// to Pencil.Gaming).
	//
	// If this weren't here, the .NET GC would be free to
	// destroy them.
	internal class WindowDelegates : IDisposable {
		public GlfwWindowPosFun windowposfun;
		public GlfwWindowSizeFun windowsizefun;
		public GlfwWindowCloseFun windowclosefun;
		public GlfwWindowRefreshFun windowrefreshfun;
		public GlfwWindowFocusFun windowfocusfun;
		public GlfwWindowIconifyFun windowiconifyfun;
		public GlfwFramebufferSizeFun framebuffersizefun;
		public GlfwMouseButtonFun mousebuttonfun;
		public GlfwCursorPosFun cursorposfun;
		public GlfwCursorEnterFun cursorenterfun;
		public GlfwScrollFun scrollfun;
		public KeyFun keyfun;
		public GlfwCharFun charfun;
		public GlfwCharModsFun charmodsfun;
		public GLFWdropfun dropfun; // wrapped version of the one below
		public GlfwDropFun userDropfun;

		public void Dispose() {
			windowposfun = null;
			windowsizefun = null;
			windowclosefun = null;
			windowrefreshfun = null;
			windowfocusfun = null;
			windowiconifyfun = null;
			framebuffersizefun = null;
			mousebuttonfun = null;
			cursorposfun = null;
			cursorenterfun = null;
			scrollfun = null;
			keyfun = null;
			charfun = null;
			charmodsfun = null;
			dropfun = null;
			userDropfun = null;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct GlfwCursorPtr {
		public IntPtr Handle { get; private set; }

		private GlfwCursorPtr(IntPtr handle) {
			Handle = handle;
		}

		public static readonly GlfwCursorPtr Zero = new GlfwCursorPtr(IntPtr.Zero);

		public override int GetHashCode() {
			return Handle.GetHashCode();
		}

		public override bool Equals(object other) {
			if (other == null || !(other is GlfwCursorPtr)) {
				return false;
			}

			return this == (GlfwCursorPtr)other;
		}

		public static bool operator ==(GlfwCursorPtr l, GlfwCursorPtr r) {
			return l.Handle == r.Handle;
		}
		public static bool operator !=(GlfwCursorPtr l, GlfwCursorPtr r) {
			return l.Handle != r.Handle;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct GlfwWindowPtr {
		public IntPtr Handle { get; private set; }

		private GlfwWindowPtr(IntPtr handle) {
			Handle = handle;
		}

		public static readonly GlfwWindowPtr Zero = new GlfwWindowPtr(IntPtr.Zero);

		public override int GetHashCode() {
			return Handle.GetHashCode();
		}

		public override bool Equals(object other) {
			if (other == null || !(other is GlfwWindowPtr)) {
				return false;
			}

			return this == (GlfwWindowPtr)other;
		}

		public static bool operator ==(GlfwWindowPtr l, GlfwWindowPtr r) {
			return l.Handle == r.Handle;
		}
		public static bool operator !=(GlfwWindowPtr l, GlfwWindowPtr r) {
			return l.Handle != r.Handle;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct GlfwMonitorPtr {
		public IntPtr Handle { get; private set; }

		private GlfwMonitorPtr(IntPtr handle) {
			Handle = handle;
		}

		public static readonly GlfwMonitorPtr Zero = new GlfwMonitorPtr(IntPtr.Zero);

		public override int GetHashCode() {
			return Handle.GetHashCode();
		}

		public override bool Equals(object other) {
			if (other == null || !(other is GlfwMonitorPtr)) {
				return false;
			}

			return this == (GlfwMonitorPtr)other;
		}

		public static bool operator ==(GlfwMonitorPtr l, GlfwMonitorPtr r) {
			return l.Handle == r.Handle;
		}
		public static bool operator !=(GlfwMonitorPtr l, GlfwMonitorPtr r) {
			return l.Handle != r.Handle;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct GLFWimage {
		public int width;
		public int height;
		public byte* pixels;
	}

	public struct GlfwImage {
		public int Width;
		public int Height;
		public byte[] Pixels;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal unsafe struct GLFWgammaramp {
		public ushort *red;
		public ushort *green;
		public ushort *blue;
		public int size;
	}

	public struct GlfwGammaRamp {
		public ushort[] Red;
		public ushort[] Green;
		public ushort[] Blue;
	}

	[StructLayout(LayoutKind.Sequential)]
	public struct GlfwVidMode {
		public int Width;
		public int Height;
		public int RedBits;
		public int GreenBits;
		public int BlueBits;
		public int RefreshRate;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwErrorFun(GlfwError error, [MarshalAs(UnmanagedType.LPStr)] string message);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwWindowPosFun(GlfwWindowPtr win, int x, int y);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwWindowSizeFun(GlfwWindowPtr win, int w,int h);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwWindowCloseFun(GlfwWindowPtr win);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwWindowRefreshFun(GlfwWindowPtr win);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwWindowFocusFun(GlfwWindowPtr win, bool focus);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwWindowIconifyFun(GlfwWindowPtr win, bool iconified);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwFramebufferSizeFun(GlfwWindowPtr win, int w, int h);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwMouseButtonFun(GlfwWindowPtr win, ButtonState button, ButtonState state, KeyModifiers mods);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwCursorPosFun(GlfwWindowPtr win, double x, double y);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwCursorEnterFun(GlfwWindowPtr win, bool entered);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwScrollFun(GlfwWindowPtr win, double x, double y);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void KeyFun(GlfwWindowPtr win, Key key, int scancode, KeyState state, KeyModifiers mods);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwCharFun(GlfwWindowPtr win, uint codepoint);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwCharModsFun(GlfwWindowPtr win, uint codepoint, KeyModifiers mods);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	internal unsafe delegate void GLFWdropfun(GlfwWindowPtr win, int num, IntPtr* strings);
	public delegate void GlfwDropFun(GlfwWindowPtr win, string[] paths);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void GlfwMonitorFun(GlfwMonitorPtr mtor, ConnectionState connected);
	[UnmanagedFunctionPointer(CallingConvention.Cdecl), SuppressUnmanagedCodeSecurity]
	public delegate void JoystickFun(Joystick stick, ConnectionState connected);
}
