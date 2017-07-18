using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
	public static class Glfw {
		public const int VersionMajor          = 3;
		public const int VersionMinor          = 2;
		public const int VersionRevision       = 1;
		public const int DontCare = -1;

		private static readonly Dictionary<GlfwWindowPtr, WindowDelegates> winDelegateMap
				= new Dictionary<GlfwWindowPtr, WindowDelegates>();

		private unsafe static GLFWdropfun WrapDropFun(GlfwDropFun fun) {
			return (w, n, ss) => {
				var strings = new string[n];
				for (int i = 0; i < n; ++i) {
					strings[i] = Marshal.PtrToStringAuto(ss[i]);
				}

				fun(w, strings);
			};
		}

		public static bool Init() {
			return GlfwDelegates.glfwInit();
		}
		public static void Terminate() {
			GlfwDelegates.glfwTerminate();
		}
		public static void GetVersion(out int major, out int minor, out int rev) {
			GlfwDelegates.glfwGetVersion(out major, out minor, out rev);
		}
		public static string GetVersionString() {
			return GlfwDelegates.glfwGetVersionString();
		}
		public static void WindowHint(WindowHint hint, int value) {
			GlfwDelegates.glfwWindowHint(hint, value);
		}

		private static GlfwErrorFun errorfun;
		public static GlfwErrorFun SetErrorCallback(GlfwErrorFun cbfun) {
			var result = errorfun;
			errorfun = cbfun;
			GlfwDelegates.glfwSetErrorCallback(cbfun);
			return result;
		}

		public static GlfwMonitorPtr GetPrimaryMonitor() {
			return GlfwDelegates.glfwGetPrimaryMonitor();
		}
		public static void GetMonitorPos(GlfwMonitorPtr monitor, out int xpos, out int ypos) {
			GlfwDelegates.glfwGetMonitorPos(monitor, out xpos, out ypos);
		}
		public static void GetMonitorPhysicalSize(GlfwMonitorPtr monitor, out int widthMM, out int heightMM) {
			GlfwDelegates.glfwGetMonitorPhysicalSize(monitor, out widthMM, out heightMM);
		}
		public static string GetMonitorName(GlfwMonitorPtr monitor) {
			return GlfwDelegates.glfwGetMonitorName(monitor);
		}
		public static void SetGamma(GlfwMonitorPtr monitor, float gamma) {
			GlfwDelegates.glfwSetGamma(monitor, gamma);
		}
		public static void DefaultWindowHints() {
			GlfwDelegates.glfwDefaultWindowHints();
		}
		public static bool WindowShouldClose(GlfwWindowPtr window) {
			return GlfwDelegates.glfwWindowShouldClose(window);
		}
		public static void SetWindowShouldClose(GlfwWindowPtr window, bool value) {
			GlfwDelegates.glfwSetWindowShouldClose(window, value);
		}
		public static void SetWindowTitle(GlfwWindowPtr window, string title) {
			GlfwDelegates.glfwSetWindowTitle(window, title);
		}
		public static void GetWindowPos(GlfwWindowPtr window, out int xpos, out int ypos) {
			GlfwDelegates.glfwGetWindowPos(window, out xpos, out ypos);
		}
		public static void SetWindowPos(GlfwWindowPtr window, int xpos, int ypos) {
			GlfwDelegates.glfwSetWindowPos(window, xpos, ypos);
		}
		public static void GetWindowSize(GlfwWindowPtr window, out int width, out int height) {
			GlfwDelegates.glfwGetWindowSize(window, out width, out height);
		}
		public static void SetWindowSizeLimits(GlfwWindowPtr window, int minwidth, int minheight, int maxwidth, int maxheight) {
			GlfwDelegates.glfwSetWindowSizeLimits(window, minwidth, minheight, maxwidth, maxheight);
		}
		public static void SetWindowAspectRatio(GlfwWindowPtr window, int numer, int denom) {
			GlfwDelegates.glfwSetWindowAspectRatio(window, numer, denom);
		}
		public static void SetWindowSize(GlfwWindowPtr window, int width, int height) {
			GlfwDelegates.glfwSetWindowSize(window, width, height);
		}
		public static void GetFramebufferSize(GlfwWindowPtr window, out int width, out int height) {
			GlfwDelegates.glfwGetFramebufferSize(window, out width, out height);
		}
		public static void GetWindowFrameSize(GlfwWindowPtr window, out int left, out int top, out int right, out int bottom) {
			GlfwDelegates.glfwGetWindowFrameSize(window, out left, out top, out right, out bottom);
		}
		public static void IconifyWindow(GlfwWindowPtr window) {
			GlfwDelegates.glfwIconifyWindow(window);
		}
		public static void RestoreWindow(GlfwWindowPtr window) {
			GlfwDelegates.glfwRestoreWindow(window);
		}
		public static void MaximizeWindow(GlfwWindowPtr window) {
			GlfwDelegates.glfwMaximizeWindow(window);
		}
		public static void ShowWindow(GlfwWindowPtr window) {
			GlfwDelegates.glfwShowWindow(window);
		}
		public static void HideWindow(GlfwWindowPtr window) {
			GlfwDelegates.glfwHideWindow(window);
		}
		public static void FocusWindow(GlfwWindowPtr window) {
			GlfwDelegates.glfwFocusWindow(window);
		}
		public static GlfwMonitorPtr GetWindowMonitor(GlfwWindowPtr window) {
			return GlfwDelegates.glfwGetWindowMonitor(window);
		}
		public static void SetWindowMonitor(GlfwWindowPtr window, GlfwMonitorPtr monitor, int xpos, int ypos, int width, int height, int refreshRate) {
			GlfwDelegates.glfwSetWindowMonitor(window, monitor, xpos, ypos, width, height, refreshRate);
		}
		public static bool GetWindowAttrib(GlfwWindowPtr window, WindowAttrib attrib) {
			return GlfwDelegates.glfwGetWindowAttrib(window, attrib);
		}
		public static void SetWindowUserPointer(GlfwWindowPtr window, IntPtr pointer) {
			GlfwDelegates.glfwSetWindowUserPointer(window, pointer);
		}
		public static IntPtr GetWindowUserPointer(GlfwWindowPtr window) {
			return GlfwDelegates.glfwGetWindowUserPointer(window);
		}
		public static void PollEvents() {
			GlfwDelegates.glfwPollEvents();
		}
		public static void WaitEvents() {
			GlfwDelegates.glfwWaitEvents();
		}
		public static void WaitEventsTimeout(double timeout) {
			GlfwDelegates.glfwWaitEventsTimeout(timeout);
		}
		public static void PostEmptyEvent() {
			GlfwDelegates.glfwPostEmptyEvent();
		}
		public static int GetInputMode(GlfwWindowPtr window, InputMode mode) {
			return GlfwDelegates.glfwGetInputMode(window, mode);
		}
		public static void SetInputMode(GlfwWindowPtr window, InputMode mode, int value) {
			GlfwDelegates.glfwSetInputMode(window, mode, value);
		}
		public static string GetKeyName(Key key, int scancode) {
			return GlfwDelegates.glfwGetKeyName(key, scancode);
		}
		public static KeyState GetKey(GlfwWindowPtr window, Key key) {
			return GlfwDelegates.glfwGetKey(window, key);
		}
		public static ButtonState GetMouseButton(GlfwWindowPtr window, MouseButton button) {
			return GlfwDelegates.glfwGetMouseButton(window, button);
		}
		public static void GetCursorPos(GlfwWindowPtr window, out double xpos, out double ypos) {
			GlfwDelegates.glfwGetCursorPos(window, out xpos, out ypos);
		}
		public static void SetCursorPos(GlfwWindowPtr window, double xpos, double ypos) {
			GlfwDelegates.glfwSetCursorPos(window, xpos, ypos);
		}
		public static GlfwCursorPtr CreateStandardCursor(CursorShape shape) {
			return GlfwDelegates.glfwCreateStandardCursor(shape);
		}
		public static void DestroyCursor(GlfwCursorPtr cursor) {
			GlfwDelegates.glfwDestroyCursor(cursor);
		}
		public static void SetCursor(GlfwWindowPtr window, GlfwCursorPtr cursor) {
			GlfwDelegates.glfwSetCursor(window, cursor);
		}
		public static bool JoystickPresent(Joystick joy) {
			return GlfwDelegates.glfwJoystickPresent(joy);
		}
		public static string GetJoystickName(Joystick joy) {
			return GlfwDelegates.glfwGetJoystickName(joy);
		}
		public static void SetClipboardString(GlfwWindowPtr window, string @string) {
			GlfwDelegates.glfwSetClipboardString(window, @string);
		}
		public static string GetClipboardString(GlfwWindowPtr window) {
			return GlfwDelegates.glfwGetClipboardString(window);
		}
		public static double GetTime() {
			return GlfwDelegates.glfwGetTime();
		}
		public static void SetTime(double time) {
			GlfwDelegates.glfwSetTime(time);
		}
		public static ulong GetTimerValue() {
			return GlfwDelegates.glfwGetTimerValue();
		}
		public static ulong GetTimerFrequency() {
			return GlfwDelegates.glfwGetTimerFrequency();
		}
		public static void MakeContextCurrent(GlfwWindowPtr window) {
			GlfwDelegates.glfwMakeContextCurrent(window);
		}
		public static GlfwWindowPtr GetCurrentContext() {
			return GlfwDelegates.glfwGetCurrentContext();
		}
		public static void SwapBuffers(GlfwWindowPtr window) {
			GlfwDelegates.glfwSwapBuffers(window);
		}
		public static void SwapInterval(int interval) {
			GlfwDelegates.glfwSwapInterval(interval);
		}
		public static int ExtensionSupported(string extension) {
			return GlfwDelegates.glfwExtensionSupported(extension);
		}
		public static IntPtr GetProcAddress(string procname) {
			return GlfwDelegates.glfwGetProcAddress(procname);
		}

		private static GlfwMonitorFun monitorFun;
		public static GlfwMonitorFun SetMonitorCallback(GlfwMonitorFun cbfun) {
			var prevMonitorFun = monitorFun;
			monitorFun = cbfun;
			GlfwDelegates.glfwSetMonitorCallback(cbfun);
			return prevMonitorFun;
		}

		public static unsafe GlfwMonitorPtr[] GetMonitors() {
			int count;
			var monitors = GlfwDelegates.glfwGetMonitors(out count);

			var result = new GlfwMonitorPtr[count];
			for (int i = 0; i < count; ++i) {
				result[i] = monitors[i];
			}
			return result;
		}

		public static unsafe GlfwVidMode[] GetVideoModes(GlfwMonitorPtr monitor) {
			int count;
			var modes = GlfwDelegates.glfwGetVideoModes(monitor, out count);

			var result = new GlfwVidMode[count];
			for (int i = 0; i < count; ++i) {
				result[i] = modes[i];
			}
			return result;
		}

		public static unsafe GlfwVidMode GetVideoMode(GlfwMonitorPtr monitor) {
			return *GlfwDelegates.glfwGetVideoMode(monitor);
		}

		public static unsafe GlfwGammaRamp? GetGammaRamp(GlfwMonitorPtr monitor) {
			var ramp = GlfwDelegates.glfwGetGammaRamp(monitor);
			if (ramp == null) {
				return null;
			}

			var res = new GlfwGammaRamp();
			res.Red = new ushort[ramp->size];
			res.Green = new ushort[ramp->size];
			res.Blue = new ushort[ramp->size];

			for (int i = 0; i < ramp->size; ++i) {
				res.Red[i] = ramp->red[i];
				res.Green[i] = ramp->green[i];
				res.Blue[i] = ramp->blue[i];
			}

			return res;
		}

		public static unsafe void SetGammaRamp(GlfwMonitorPtr monitor, ref GlfwGammaRamp ramp) {
			if (ramp.Red.Length != ramp.Green.Length || ramp.Green.Length != ramp.Blue.Length) {
				throw new ArgumentException(nameof(ramp), "all arrays in GlfwGammaRamp must be of the same size");
			}

			fixed (ushort* red = &ramp.Red[0])
			fixed (ushort* green = &ramp.Green[0])
			fixed (ushort* blue = &ramp.Blue[0]) {
				var actRamp = new GLFWgammaramp{
					red = red,
					green = green,
					blue = blue,
					size = ramp.Red.Length,
				};
				GlfwDelegates.glfwSetGammaRamp(monitor, ref actRamp);
			}
		}

		public static void WindowHint(WindowHint hint, bool value) {
			GlfwDelegates.glfwWindowHint(hint, value ? 1 : 0);
		}
		public static void WindowHint(WindowHint hint, OpenGLAPI value) {
			GlfwDelegates.glfwWindowHint(hint, (int)value);
		}
		public static void WindowHint(WindowHint hint, Robustness value) {
			GlfwDelegates.glfwWindowHint(hint, (int)value);
		}
		public static void WindowHint(WindowHint hint, OpenGLProfile value) {
			GlfwDelegates.glfwWindowHint(hint, (int)value);
		}
		public static void WindowHint(WindowHint hint, InputMode value) {
			GlfwDelegates.glfwWindowHint(hint, (int)value);
		}
		public static void WindowHint(WindowHint hint, ReleaseBehavior value) {
			GlfwDelegates.glfwWindowHint(hint, (int)value);
		}
		public static void WindowHint(WindowHint hint, ContextOpenGLAPI value) {
			GlfwDelegates.glfwWindowHint(hint, (int)value);
		}

		public static GlfwWindowPtr CreateWindow(int width, int height, string title, GlfwMonitorPtr monitor, GlfwWindowPtr share) {
			var wptr = GlfwDelegates.glfwCreateWindow(width, height, title, monitor, share);
			winDelegateMap[wptr] = new WindowDelegates();
			return wptr;
		}

		public static void DestroyWindow(GlfwWindowPtr window) {
			GlfwDelegates.glfwDestroyWindow(window);

			winDelegateMap[window].Dispose();
			winDelegateMap.Remove(window);
		}

		public static unsafe void SetWindowIcon(GlfwWindowPtr window, GlfwImage[] images) {
			throw new NotImplementedException();
		}

		public static GlfwWindowPosFun SetWindowPosCallback(GlfwWindowPtr window, GlfwWindowPosFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.windowposfun;
			winDelegates.windowposfun = cbfun;
			GlfwDelegates.glfwSetWindowPosCallback(window, cbfun);
			return result;
		}
		public static GlfwWindowSizeFun SetWindowSizeCallback(GlfwWindowPtr window, GlfwWindowSizeFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.windowsizefun;
			winDelegates.windowsizefun = cbfun;
			GlfwDelegates.glfwSetWindowSizeCallback(window, cbfun);
			return result;
		}
		public static GlfwWindowCloseFun SetWindowCloseCallback(GlfwWindowPtr window, GlfwWindowCloseFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.windowclosefun;
			winDelegates.windowclosefun = cbfun;
			GlfwDelegates.glfwSetWindowCloseCallback(window, cbfun);
			return result;
		}
		public static GlfwWindowRefreshFun SetWindowRefreshCallback(GlfwWindowPtr window, GlfwWindowRefreshFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.windowrefreshfun;
			winDelegates.windowrefreshfun = cbfun;
			GlfwDelegates.glfwSetWindowRefreshCallback(window, cbfun);
			return result;
		}
		public static GlfwWindowFocusFun SetWindowFocusCallback(GlfwWindowPtr window, GlfwWindowFocusFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.windowfocusfun;
			winDelegates.windowfocusfun = cbfun;
			GlfwDelegates.glfwSetWindowFocusCallback(window, cbfun);
			return result;
		}
		public static GlfwWindowIconifyFun SetWindowIconifyCallback(GlfwWindowPtr window, GlfwWindowIconifyFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.windowiconifyfun;
			winDelegates.windowiconifyfun = cbfun;
			GlfwDelegates.glfwSetWindowIconifyCallback(window, cbfun);
			return result;
		}
		public static GlfwFramebufferSizeFun SetFramebufferSizeCallback(GlfwWindowPtr window, GlfwFramebufferSizeFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.framebuffersizefun;
			winDelegates.framebuffersizefun = cbfun;
			GlfwDelegates.glfwSetFramebufferSizeCallback(window, cbfun);
			return result;
		}


		public static unsafe GlfwCursorPtr CreateCursor(ref GlfwImage image, int xhot, int yhot) {
			fixed (byte* pixels = &image.Pixels[0]) {
				var internalImg = new GLFWimage{
					width = image.Width,
					height = image.Height,
					pixels = pixels
				};
				return GlfwDelegates.glfwCreateCursor(ref internalImg, xhot, yhot);
			}
		}

		public static KeyFun SetKeyCallback(GlfwWindowPtr window, KeyFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.keyfun;
			winDelegates.keyfun = cbfun;
			GlfwDelegates.glfwSetKeyCallback(window, cbfun);
			return result;
		}

		public static GlfwCharFun SetCharCallback(GlfwWindowPtr window, GlfwCharFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.charfun;
			winDelegates.charfun = cbfun;
			GlfwDelegates.glfwSetCharCallback(window, cbfun);
			return result;
		}

		public static GlfwCharModsFun SetSetCharModsCallback(GlfwWindowPtr window, GlfwCharModsFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.charmodsfun;
			winDelegates.charmodsfun = cbfun;
			GlfwDelegates.glfwSetCharModsCallback(window, cbfun);
			return result;
		}

		public static GlfwMouseButtonFun SetMouseButtonCallback(GlfwWindowPtr window, GlfwMouseButtonFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.mousebuttonfun;
			winDelegates.mousebuttonfun = cbfun;
			GlfwDelegates.glfwSetMouseButtonCallback(window, cbfun);
			return result;
		}

		public static GlfwCursorPosFun SetCursorPosCallback(GlfwWindowPtr window, GlfwCursorPosFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.cursorposfun;
			winDelegates.cursorposfun = cbfun;
			GlfwDelegates.glfwSetCursorPosCallback(window, cbfun);
			return result;
		}

		public static GlfwCursorEnterFun SetCursorEnterCallback(GlfwWindowPtr window, GlfwCursorEnterFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.cursorenterfun;
			winDelegates.cursorenterfun = cbfun;
			GlfwDelegates.glfwSetCursorEnterCallback(window, cbfun);
			return result;
		}

		public static GlfwScrollFun SetScrollCallback(GlfwWindowPtr window, GlfwScrollFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.scrollfun;
			winDelegates.scrollfun = cbfun;
			GlfwDelegates.glfwSetScrollCallback(window, cbfun);
			return result;
		}

		public static GlfwDropFun SetDropCallback(GlfwWindowPtr window, GlfwDropFun cbfun) {
			var winDelegates = winDelegateMap[window];
			var result = winDelegates.userDropfun;
			winDelegates.userDropfun = cbfun;
			var wrapper = WrapDropFun(cbfun);
			winDelegates.dropfun = wrapper;
			GlfwDelegates.glfwSetDropCallback(window, wrapper);
			return result;
		}

		public static unsafe float[] GetJoystickAxes(Joystick joy) {
			int count;
			var buttons = GlfwDelegates.glfwGetJoystickButtons(joy, out count);

			var result = new float[count];
			for (int i = 0; i < count; ++i) {
				result[i] = buttons[i];
			}

			return result;
		}

		public static unsafe ButtonState[] GetJoystickButtons(Joystick joy) {
			int count;
			var buttons = GlfwDelegates.glfwGetJoystickButtons(joy, out count);

			var result = new ButtonState[count];
			for (int i = 0; i < count; ++i) {
				result[i] = (ButtonState)buttons[i];
			}

			return result;
		}

		private static JoystickFun joystickfun;
		public static JoystickFun SetJoystickCallback(JoystickFun cbfun) {
			var result = joystickfun;
			joystickfun = cbfun;
			GlfwDelegates.glfwSetJoystickCallback(cbfun);
			return result;
		}
	}
}
