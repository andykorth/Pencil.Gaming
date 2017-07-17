using System;
using System.Security;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
	internal static unsafe class Glfw64 {
		private const string lib = "natives64/glfw3.dll";

		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern int glfwInit();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwTerminate();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwGetVersion(out int major, out int minor, out int rev);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal static extern string glfwGetVersionString();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwWindowHint(GlfwWindowHint hint, int value);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwErrorFun glfwSetErrorCallback(GlfwErrorFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwMonitorPtr* glfwGetMonitors(out int count);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwMonitorPtr glfwGetPrimaryMonitor();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwGetMonitorPos(GlfwMonitorPtr monitor, out int xpos, out int ypos);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwGetMonitorPhysicalSize(GlfwMonitorPtr monitor, out int widthMM, out int heightMM);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal static extern string glfwGetMonitorName(GlfwMonitorPtr monitor);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr glfwSetMonitorCallback([MarshalAs(UnmanagedType.FunctionPtr)] GlfwMonitorFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwVidMode* glfwGetVideoModes(GlfwMonitorPtr monitor, out int count);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwVidMode* glfwGetVideoMode(GlfwMonitorPtr monitor);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetGamma(GlfwMonitorPtr monitor, float gamma);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GLFWgammaramp* glfwGetGammaRamp(GlfwMonitorPtr monitor);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetGammaRamp(GlfwMonitorPtr monitor, ref GLFWgammaramp ramp);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwDefaultWindowHints();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwWindowPtr glfwCreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title, GlfwMonitorPtr monitor, GlfwWindowPtr share);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwDestroyWindow(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern bool glfwWindowShouldClose(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowShouldClose(GlfwWindowPtr window, bool value);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowTitle(GlfwWindowPtr window, [MarshalAs(UnmanagedType.LPStr)] string title);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowIcon(GlfwWindowPtr window, int count, GlfwImage* images);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwGetWindowPos(GlfwWindowPtr window, out int xpos, out int ypos);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowPos(GlfwWindowPtr window, int xpos, int ypos);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwGetWindowSize(GlfwWindowPtr window, out int width, out int height);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowSizeLimits(GlfwWindowPtr window, int minwidth, int minheight, int maxwidth, int maxheight);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowAspectRatio(GlfwWindowPtr window, int numer, int denom);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowSize(GlfwWindowPtr window, int width, int height);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwGetFramebufferSize(GlfwWindowPtr window, out int width, out int height);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwGetWindowFrameSize(GlfwWindowPtr window, out int left, out int top, out int right, out int bottom);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwIconifyWindow(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwRestoreWindow(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwMaximizeWindow(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwShowWindow(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwHideWindow(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwFocusWindow(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwMonitorPtr glfwGetWindowMonitor(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowMonitor(GlfwWindowPtr window, GlfwMonitorPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern bool glfwGetWindowAttrib(GlfwWindowPtr window, GlfwWindowAttrib attrib);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetWindowUserPointer(GlfwWindowPtr window, IntPtr pointer);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr glfwGetWindowUserPointer(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwWindowPosFun glfwSetWindowPosCallback(GlfwWindowPtr window, GlfwWindowPosFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwWindowSizeFun glfwSetWindowSizeCallback(GlfwWindowPtr window, GlfwWindowSizeFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwWindowCloseFun glfwSetWindowCloseCallback(GlfwWindowPtr window, GlfwWindowCloseFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwWindowRefreshFun glfwSetWindowRefreshCallback(GlfwWindowPtr window, GlfwWindowRefreshFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwWindowFocusFun glfwSetWindowFocusCallback(GlfwWindowPtr window, GlfwWindowFocusFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwWindowIconifyFun glfwSetWindowIconifyCallback(GlfwWindowPtr window, GlfwWindowIconifyFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwFramebufferSizeFun glfwSetFramebufferSizeCallback(GlfwWindowPtr window, GlfwFramebufferSizeFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwPollEvents();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwWaitEvents();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwWaitEventsTimeout(double timeout);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwPostEmptyEvent();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern int glfwGetInputMode(GlfwWindowPtr window, GlfwInputMode mode);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetInputMode(GlfwWindowPtr window, GlfwInputMode mode, int value);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal static extern string glfwGetKeyName(GlfwKey key, int scancode);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwKeyState glfwGetKey(GlfwWindowPtr window, GlfwKey key);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwButtonState glfwGetMouseButton(GlfwWindowPtr window, GlfwMouseButton button);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwGetCursorPos(GlfwWindowPtr window, out double xpos, out double ypos);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetCursorPos(GlfwWindowPtr window, double xpos, double ypos);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwCursorPtr glfwCreateCursor(ref GLFWimage image, int xhot, int yhot);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwCursorPtr glfwCreateStandardCursor(GlfwCursorShape shape);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwDestroyCursor(GlfwCursorPtr cursor);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetCursor(GlfwWindowPtr window, GlfwCursorPtr cursor);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwKeyFun glfwSetKeyCallback(GlfwWindowPtr window, GlfwKeyFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwCharFun glfwSetCharCallback(GlfwWindowPtr window, GlfwCharFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwCharModsFun glfwSetCharModsCallback(GlfwWindowPtr window, GlfwCharModsFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwMouseButtonFun glfwSetMouseButtonCallback(GlfwWindowPtr window, GlfwMouseButtonFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwCursorPosFun glfwSetCursorPosCallback(GlfwWindowPtr window, GlfwCursorPosFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwCursorEnterFun glfwSetCursorEnterCallback(GlfwWindowPtr window, GlfwCursorEnterFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwScrollFun glfwSetScrollCallback(GlfwWindowPtr window, GlfwScrollFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GLFWdropfun glfwSetDropCallback(GlfwWindowPtr window, GLFWdropfun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern bool glfwJoystickPresent(GlfwJoystick joy);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern float* glfwGetJoystickAxes(GlfwJoystick joy, out int count);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern byte* glfwGetJoystickButtons(GlfwJoystick joy, out int count);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal static extern string glfwGetJoystickName(GlfwJoystick joy);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwJoystickFun glfwSetJoystickCallback(GlfwJoystickFun cbfun);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetClipboardString(GlfwWindowPtr window, [MarshalAs(UnmanagedType.LPStr)] string @string);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal static extern string glfwGetClipboardString(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern double glfwGetTime();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSetTime(double time);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern ulong glfwGetTimerValue();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern ulong glfwGetTimerFrequency();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwMakeContextCurrent(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern GlfwWindowPtr glfwGetCurrentContext();
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSwapBuffers(GlfwWindowPtr window);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern void glfwSwapInterval(int interval);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
		[DllImport(lib), SuppressUnmanagedCodeSecurity]
		internal static extern IntPtr glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);
	}
}
