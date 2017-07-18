using System;
using System.Security;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
	internal static unsafe class GlfwDelegates {
		static GlfwDelegates() {
			var glfwInterop = (IntPtr.Size == 8) ? typeof(Glfw64) : typeof(Glfw32);
			var fields = typeof(GlfwDelegates).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
			foreach (var fi in fields) {
				var method = glfwInterop.GetMethod(fi.Name, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
				var function = Delegate.CreateDelegate(fi.FieldType, method);
				fi.SetValue(null, function);
			}
		}

		[SuppressUnmanagedCodeSecurity]
		internal delegate bool Init();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void Terminate();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetVersion(out int major, out int minor, out int rev);
		[SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal delegate string GetVersionString();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void WindowHintDelegate(WindowHint hint, int value);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwErrorFun SetErrorCallback(GlfwErrorFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwMonitorPtr* GetMonitors(out int count);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwMonitorPtr GetPrimaryMonitor();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetMonitorPos(GlfwMonitorPtr monitor, out int xpos, out int ypos);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetMonitorPhysicalSize(GlfwMonitorPtr monitor, out int widthMM, out int heightMM);
		[SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal delegate string GetMonitorName(GlfwMonitorPtr monitor);
		[SuppressUnmanagedCodeSecurity]
		internal delegate IntPtr SetMonitorCallback([MarshalAs(UnmanagedType.FunctionPtr)] GlfwMonitorFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwVidMode* GetVideoModes(GlfwMonitorPtr monitor, out int count);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwVidMode* GetVideoMode(GlfwMonitorPtr monitor);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetGamma(GlfwMonitorPtr monitor, float gamma);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GLFWgammaramp* GetGammaRamp(GlfwMonitorPtr monitor);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetGammaRamp(GlfwMonitorPtr monitor, ref GLFWgammaramp ramp);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void DefaultWindowHints();
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwWindowPtr CreateWindow(int width, int height, [MarshalAs(UnmanagedType.LPStr)] string title, GlfwMonitorPtr monitor, GlfwWindowPtr share);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void DestroyWindow(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate bool WindowShouldClose(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowShouldClose(GlfwWindowPtr window, bool value);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowTitle(GlfwWindowPtr window, [MarshalAs(UnmanagedType.LPStr)] string title);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowIcon(GlfwWindowPtr window, int count, GlfwImage* images);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetWindowPos(GlfwWindowPtr window, out int xpos, out int ypos);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowPos(GlfwWindowPtr window, int xpos, int ypos);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetWindowSize(GlfwWindowPtr window, out int width, out int height);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowSizeLimits(GlfwWindowPtr window, int minwidth, int minheight, int maxwidth, int maxheight);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowAspectRatio(GlfwWindowPtr window, int numer, int denom);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowSize(GlfwWindowPtr window, int width, int height);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetFramebufferSize(GlfwWindowPtr window, out int width, out int height);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetWindowFrameSize(GlfwWindowPtr window, out int left, out int top, out int right, out int bottom);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void IconifyWindow(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void RestoreWindow(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void MaximizeWindow(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void ShowWindow(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void HideWindow(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void FocusWindow(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwMonitorPtr GetWindowMonitor(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowMonitor(GlfwWindowPtr window, GlfwMonitorPtr monitor, int xpos, int ypos, int width, int height, int refreshRate);
		[SuppressUnmanagedCodeSecurity]
		internal delegate bool GetWindowAttrib(GlfwWindowPtr window, WindowAttrib attrib);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetWindowUserPointer(GlfwWindowPtr window, IntPtr pointer);
		[SuppressUnmanagedCodeSecurity]
		internal delegate IntPtr GetWindowUserPointer(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwWindowPosFun SetWindowPosCallback(GlfwWindowPtr window, GlfwWindowPosFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwWindowSizeFun SetWindowSizeCallback(GlfwWindowPtr window, GlfwWindowSizeFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwWindowCloseFun SetWindowCloseCallback(GlfwWindowPtr window, GlfwWindowCloseFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwWindowRefreshFun SetWindowRefreshCallback(GlfwWindowPtr window, GlfwWindowRefreshFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwWindowFocusFun SetWindowFocusCallback(GlfwWindowPtr window, GlfwWindowFocusFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwWindowIconifyFun SetWindowIconifyCallback(GlfwWindowPtr window, GlfwWindowIconifyFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwFramebufferSizeFun SetFramebufferSizeCallback(GlfwWindowPtr window, GlfwFramebufferSizeFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void PollEvents();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void WaitEvents();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void WaitEventsTimeout(double timeout);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void PostEmptyEvent();
		[SuppressUnmanagedCodeSecurity]
		internal delegate int GetInputMode(GlfwWindowPtr window, InputMode mode);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetInputMode(GlfwWindowPtr window, InputMode mode, int value);
		[SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal delegate string GetKeyName(Key key, int scancode);
		[SuppressUnmanagedCodeSecurity]
		internal delegate KeyState GetKey(GlfwWindowPtr window, Key key);
		[SuppressUnmanagedCodeSecurity]
		internal delegate ButtonState GetMouseButton(GlfwWindowPtr window, MouseButton button);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void GetCursorPos(GlfwWindowPtr window, out double xpos, out double ypos);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetCursorPos(GlfwWindowPtr window, double xpos, double ypos);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwCursorPtr CreateCursor(ref GLFWimage image, int xhot, int yhot);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwCursorPtr CreateStandardCursor(CursorShape shape);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void DestroyCursor(GlfwCursorPtr cursor);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetCursor(GlfwWindowPtr window, GlfwCursorPtr cursor);
		[SuppressUnmanagedCodeSecurity]
		internal delegate KeyFun SetKeyCallback(GlfwWindowPtr window, KeyFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwCharFun SetCharCallback(GlfwWindowPtr window, GlfwCharFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwCharModsFun SetCharModsCallback(GlfwWindowPtr window, GlfwCharModsFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwMouseButtonFun SetMouseButtonCallback(GlfwWindowPtr window, GlfwMouseButtonFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwCursorPosFun SetCursorPosCallback(GlfwWindowPtr window, GlfwCursorPosFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwCursorEnterFun SetCursorEnterCallback(GlfwWindowPtr window, GlfwCursorEnterFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwScrollFun SetScrollCallback(GlfwWindowPtr window, GlfwScrollFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GLFWdropfun SetDropCallback(GlfwWindowPtr window, GLFWdropfun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate bool JoystickPresent(Joystick joy);
		[SuppressUnmanagedCodeSecurity]
		internal delegate float* GetJoystickAxes(Joystick joy, out int count);
		[SuppressUnmanagedCodeSecurity]
		internal delegate byte* GetJoystickButtons(Joystick joy, out int count);
		[SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal delegate string GetJoystickName(Joystick joy);
		[SuppressUnmanagedCodeSecurity]
		internal delegate JoystickFun SetJoystickCallback(JoystickFun cbfun);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetClipboardString(GlfwWindowPtr window, [MarshalAs(UnmanagedType.LPStr)] string @string);
		[SuppressUnmanagedCodeSecurity]
		[return: MarshalAs(UnmanagedType.LPStr)]
		internal delegate string GetClipboardString(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate double GetTime();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SetTime(double time);
		[SuppressUnmanagedCodeSecurity]
		internal delegate ulong GetTimerValue();
		[SuppressUnmanagedCodeSecurity]
		internal delegate ulong GetTimerFrequency();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void MakeContextCurrent(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate GlfwWindowPtr GetCurrentContext();
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SwapBuffers(GlfwWindowPtr window);
		[SuppressUnmanagedCodeSecurity]
		internal delegate void SwapInterval(int interval);
		[SuppressUnmanagedCodeSecurity]
		internal delegate int ExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
		[SuppressUnmanagedCodeSecurity]
		internal delegate IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);

#pragma warning disable 0649

		internal static Init glfwInit;
		internal static Terminate glfwTerminate;
		internal static GetVersion glfwGetVersion;
		internal static GetVersionString glfwGetVersionString;
		internal static WindowHintDelegate glfwWindowHint;
		internal static SetErrorCallback glfwSetErrorCallback;
		internal static GetMonitors glfwGetMonitors;
		internal static GetPrimaryMonitor glfwGetPrimaryMonitor;
		internal static GetMonitorPos glfwGetMonitorPos;
		internal static GetMonitorPhysicalSize glfwGetMonitorPhysicalSize;
		internal static GetMonitorName glfwGetMonitorName;
		internal static SetMonitorCallback glfwSetMonitorCallback;
		internal static GetVideoModes glfwGetVideoModes;
		internal static GetVideoMode glfwGetVideoMode;
		internal static SetGamma glfwSetGamma;
		internal static GetGammaRamp glfwGetGammaRamp;
		internal static SetGammaRamp glfwSetGammaRamp;
		internal static DefaultWindowHints glfwDefaultWindowHints;
		internal static CreateWindow glfwCreateWindow;
		internal static DestroyWindow glfwDestroyWindow;
		internal static WindowShouldClose glfwWindowShouldClose;
		internal static SetWindowShouldClose glfwSetWindowShouldClose;
		internal static SetWindowTitle glfwSetWindowTitle;
		internal static SetWindowIcon glfwSetWindowIcon;
		internal static GetWindowPos glfwGetWindowPos;
		internal static SetWindowPos glfwSetWindowPos;
		internal static GetWindowSize glfwGetWindowSize;
		internal static SetWindowSizeLimits glfwSetWindowSizeLimits;
		internal static SetWindowAspectRatio glfwSetWindowAspectRatio;
		internal static SetWindowSize glfwSetWindowSize;
		internal static GetFramebufferSize glfwGetFramebufferSize;
		internal static GetWindowFrameSize glfwGetWindowFrameSize;
		internal static IconifyWindow glfwIconifyWindow;
		internal static RestoreWindow glfwRestoreWindow;
		internal static MaximizeWindow glfwMaximizeWindow;
		internal static ShowWindow glfwShowWindow;
		internal static HideWindow glfwHideWindow;
		internal static FocusWindow glfwFocusWindow;
		internal static GetWindowMonitor glfwGetWindowMonitor;
		internal static SetWindowMonitor glfwSetWindowMonitor;
		internal static GetWindowAttrib glfwGetWindowAttrib;
		internal static SetWindowUserPointer glfwSetWindowUserPointer;
		internal static GetWindowUserPointer glfwGetWindowUserPointer;
		internal static SetWindowPosCallback glfwSetWindowPosCallback;
		internal static SetWindowSizeCallback glfwSetWindowSizeCallback;
		internal static SetWindowCloseCallback glfwSetWindowCloseCallback;
		internal static SetWindowRefreshCallback glfwSetWindowRefreshCallback;
		internal static SetWindowFocusCallback glfwSetWindowFocusCallback;
		internal static SetWindowIconifyCallback glfwSetWindowIconifyCallback;
		internal static SetFramebufferSizeCallback glfwSetFramebufferSizeCallback;
		internal static PollEvents glfwPollEvents;
		internal static WaitEvents glfwWaitEvents;
		internal static WaitEventsTimeout glfwWaitEventsTimeout;
		internal static PostEmptyEvent glfwPostEmptyEvent;
		internal static GetInputMode glfwGetInputMode;
		internal static SetInputMode glfwSetInputMode;
		internal static GetKeyName glfwGetKeyName;
		internal static GetKey glfwGetKey;
		internal static GetMouseButton glfwGetMouseButton;
		internal static GetCursorPos glfwGetCursorPos;
		internal static SetCursorPos glfwSetCursorPos;
		internal static CreateCursor glfwCreateCursor;
		internal static CreateStandardCursor glfwCreateStandardCursor;
		internal static DestroyCursor glfwDestroyCursor;
		internal static SetCursor glfwSetCursor;
		internal static SetKeyCallback glfwSetKeyCallback;
		internal static SetCharCallback glfwSetCharCallback;
		internal static SetCharModsCallback glfwSetCharModsCallback;
		internal static SetMouseButtonCallback glfwSetMouseButtonCallback;
		internal static SetCursorPosCallback glfwSetCursorPosCallback;
		internal static SetCursorEnterCallback glfwSetCursorEnterCallback;
		internal static SetScrollCallback glfwSetScrollCallback;
		internal static SetDropCallback glfwSetDropCallback;
		internal static JoystickPresent glfwJoystickPresent;
		internal static GetJoystickAxes glfwGetJoystickAxes;
		internal static GetJoystickButtons glfwGetJoystickButtons;
		internal static GetJoystickName glfwGetJoystickName;
		internal static SetJoystickCallback glfwSetJoystickCallback;
		internal static SetClipboardString glfwSetClipboardString;
		internal static GetClipboardString glfwGetClipboardString;
		internal static GetTime glfwGetTime;
		internal static SetTime glfwSetTime;
		internal static GetTimerValue glfwGetTimerValue;
		internal static GetTimerFrequency glfwGetTimerFrequency;
		internal static MakeContextCurrent glfwMakeContextCurrent;
		internal static GetCurrentContext glfwGetCurrentContext;
		internal static SwapBuffers glfwSwapBuffers;
		internal static SwapInterval glfwSwapInterval;
		internal static ExtensionSupported glfwExtensionSupported;
		internal static GetProcAddress glfwGetProcAddress;
	}
}
