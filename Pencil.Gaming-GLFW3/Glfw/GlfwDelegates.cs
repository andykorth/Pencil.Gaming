using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    internal static unsafe class GlfwDelegates {
        static GlfwDelegates() {
#if DEBUG
            Stopwatch sw = new Stopwatch();
            sw.Start();
#endif
            Type glfwInterop = Environment.Is64BitProcess ? typeof(Glfw64) : typeof(Glfw32);
#if DEBUG
            Console.WriteLine("GLFW interop: {0}", glfwInterop.Name);
#endif
            FieldInfo[] fields = typeof(GlfwDelegates).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (FieldInfo fi in fields) {
                MethodInfo mi = glfwInterop.GetMethod(fi.Name, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                Delegate function = Delegate.CreateDelegate(fi.FieldType, mi);
                fi.SetValue(null, function);
            }
#if DEBUG
            sw.Stop();
            Console.WriteLine("Copying GLFW delegates took {0} milliseconds.", sw.ElapsedMilliseconds);
#endif
        }

#pragma warning disable 0649

        internal delegate int Init();
        internal delegate void Terminate();
        internal delegate void GetVersion(out int major,out int minor,out int rev);
        internal delegate sbyte * GetVersionString();
        internal delegate void SetErrorCallback(GlfwErrorFun cbfun);
        internal delegate GlfwMonitorPtr * GetMonitors(out int count);
        internal delegate GlfwMonitorPtr GetPrimaryMonitor();
        internal delegate void GetMonitorPos(GlfwMonitorPtr monitor,out int xpos,out int ypos);
        internal delegate void GetMonitorPhysicalSize(GlfwMonitorPtr monitor,out int width,out int height);
        internal delegate sbyte * GetMonitorName(GlfwMonitorPtr monitor);
        internal delegate void SetMonitorCallback(GlfwMonitorFun cbfun);
        internal delegate GlfwVidMode * GetVideoModes(GlfwMonitorPtr monitor,out int count);
        internal delegate GlfwVidMode GetVideoMode(GlfwMonitorPtr monitor);
        internal delegate void SetGamma(GlfwMonitorPtr monitor,float gamma);
        internal delegate void GetGammaRamp(GlfwMonitorPtr monitor,out GlfwGammaRamp ramp);
        internal delegate void SetGammaRamp(GlfwMonitorPtr monitor,ref GlfwGammaRamp ramp);
        internal delegate void DefaultWindowHints();
        internal delegate void WindowHint(Pencil.Gaming.WindowHint target,int hint);
        internal delegate GlfwWindowPtr CreateWindow(int width,int height,[MarshalAs(UnmanagedType.LPStr)] string title,GlfwMonitorPtr monitor,GlfwWindowPtr share);
        internal delegate void DestroyWindow(GlfwWindowPtr window);
        internal delegate int WindowShouldClose(GlfwWindowPtr window);
        internal delegate void SetWindowShouldClose(GlfwWindowPtr window,int value);
        internal delegate void SetWindowTitle(GlfwWindowPtr window,[MarshalAs(UnmanagedType.LPStr)] string title);
        internal delegate void GetWindowPos(GlfwWindowPtr window,out int xpos,out int ypos);
        internal delegate void SetWindowPos(GlfwWindowPtr window,int xpos,int ypos);
        internal delegate void GetWindowSize(GlfwWindowPtr window,out int width,out int height);
        internal delegate void SetWindowSize(GlfwWindowPtr window,int width,int height);
        internal delegate void IconifyWindow(GlfwWindowPtr window);
        internal delegate void RestoreWindow(GlfwWindowPtr window);
        internal delegate void ShowWindow(GlfwWindowPtr window);
        internal delegate void HideWindow(GlfwWindowPtr window);
        internal delegate GlfwMonitorPtr GetWindowMonitor(GlfwWindowPtr window);
        internal delegate int GetWindowParam(GlfwWindowPtr window,int param);
        internal delegate void SetWindowUserPointer(GlfwWindowPtr window,IntPtr pointer);
        internal delegate IntPtr GetWindowUserPointer(GlfwWindowPtr window);
        internal delegate void SetWindowPosCallback(GlfwWindowPtr window,GlfwWindowPosFun cbfun);
        internal delegate void SetWindowSizeCallback(GlfwWindowPtr window,GlfwWindowSizeFun cbfun);
        internal delegate void SetWindowCloseCallback(GlfwWindowPtr window,GlfwWindowCloseFun cbfun);
        internal delegate void SetWindowRefreshCallback(GlfwWindowPtr window,GlfwWindowRefreshFun cbfun);
        internal delegate void SetWindowFocusCallback(GlfwWindowPtr window,GlfwWindowFocusFun cbfun);
        internal delegate void SetWindowIconifyCallback(GlfwWindowPtr window,GlfwWindowIconifyFun cbfun);
        internal delegate void PollEvents();
        internal delegate void WaitEvents();
        internal delegate int GetInputMode(GlfwWindowPtr window,InputMode mode);
        internal delegate void SetInputMode(GlfwWindowPtr window,InputMode mode,CursorMode value);
        internal delegate int GetKey(GlfwWindowPtr window,Key key);
        internal delegate int GetMouseButton(GlfwWindowPtr window,MouseButton button);
        internal delegate void GetCursorPos(GlfwWindowPtr window,out int xpos,out int ypos);
        internal delegate void SetCursorPos(GlfwWindowPtr window,int xpos,int ypos);
        internal delegate void SetKeyCallback(GlfwWindowPtr window,GlfwKeyFun cbfun);
        internal delegate void SetCharCallback(GlfwWindowPtr window,GlfwCharFun cbfun);
        internal delegate void SetMouseButtonCallback(GlfwWindowPtr window,GlfwMouseButtonFun cbfun);
        internal delegate void SetCursorPosCallback(GlfwWindowPtr window,GlfwCursorPosFun cbfun);
        internal delegate void SetCursorEnterCallback(GlfwWindowPtr window,GlfwCursorEnterFun cbfun);
        internal delegate void SetScrollCallback(GlfwWindowPtr window,GlfwScrollFun cbfun);
        internal delegate int GetJoystickParam(Joystick joy,JoystickParam param);
        internal delegate int GetJoystickAxes(Joystick joy,[MarshalAs(UnmanagedType.LPArray)] float[] axes,int numaxes);
        internal delegate int GetJoystickButtons(Joystick joy,[MarshalAs(UnmanagedType.LPArray)] byte[] buttons,int numbuttons);
        internal delegate sbyte * GetJoystickName(Joystick joy);
        internal delegate void SetClipboardString(GlfwWindowPtr window,[MarshalAs(UnmanagedType.LPStr)] string @string);
        internal delegate sbyte * GetClipboardString(GlfwWindowPtr window);
        internal delegate double GetTime();
        internal delegate void SetTime(double time);
        internal delegate void MakeContextCurrent(GlfwWindowPtr window);
        internal delegate GlfwWindowPtr GetCurrentContext();
        internal delegate void SwapBuffers(GlfwWindowPtr window);
        internal delegate void SwapInterval(int interval);
        internal delegate int ExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
        internal delegate IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);

        internal static Init glfwInit;
        internal static Terminate glfwTerminate;
        internal static GetVersion glfwGetVersion;
        internal static GetVersionString glfwGetVersionString;
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
        internal static WindowHint glfwWindowHint;
        internal static CreateWindow glfwCreateWindow;
        internal static DestroyWindow glfwDestroyWindow;
        internal static WindowShouldClose glfwWindowShouldClose;
        internal static SetWindowShouldClose glfwSetWindowShouldClose;
        internal static SetWindowTitle glfwSetWindowTitle;
        internal static GetWindowPos glfwGetWindowPos;
        internal static SetWindowPos glfwSetWindowPos;
        internal static GetWindowSize glfwGetWindowSize;
        internal static SetWindowSize glfwSetWindowSize;
        internal static IconifyWindow glfwIconifyWindow;
        internal static RestoreWindow glfwRestoreWindow;
        internal static ShowWindow glfwShowWindow;
        internal static HideWindow glfwHideWindow;
        internal static GetWindowMonitor glfwGetWindowMonitor;
        internal static GetWindowParam glfwGetWindowParam;
        internal static SetWindowUserPointer glfwSetWindowUserPointer;
        internal static GetWindowUserPointer glfwGetWindowUserPointer;
        internal static SetWindowPosCallback glfwSetWindowPosCallback;
        internal static SetWindowSizeCallback glfwSetWindowSizeCallback;
        internal static SetWindowCloseCallback glfwSetWindowCloseCallback;
        internal static SetWindowRefreshCallback glfwSetWindowRefreshCallback;
        internal static SetWindowFocusCallback glfwSetWindowFocusCallback;
        internal static SetWindowIconifyCallback glfwSetWindowIconifyCallback;
        internal static PollEvents glfwPollEvents;
        internal static WaitEvents glfwWaitEvents;
        internal static GetInputMode glfwGetInputMode;
        internal static SetInputMode glfwSetInputMode;
        internal static GetKey glfwGetKey;
        internal static GetMouseButton glfwGetMouseButton;
        internal static GetCursorPos glfwGetCursorPos;
        internal static SetCursorPos glfwSetCursorPos;
        internal static SetKeyCallback glfwSetKeyCallback;
        internal static SetCharCallback glfwSetCharCallback;
        internal static SetMouseButtonCallback glfwSetMouseButtonCallback;
        internal static SetCursorPosCallback glfwSetCursorPosCallback;
        internal static SetCursorEnterCallback glfwSetCursorEnterCallback;
        internal static SetScrollCallback glfwSetScrollCallback;
        internal static GetJoystickParam glfwGetJoystickParam;
        internal static GetJoystickAxes glfwGetJoystickAxes;
        internal static GetJoystickButtons glfwGetJoystickButtons;
        internal static GetJoystickName glfwGetJoystickName;
        internal static SetClipboardString glfwSetClipboardString;
        internal static GetClipboardString glfwGetClipboardString;
        internal static GetTime glfwGetTime;
        internal static SetTime glfwSetTime;
        internal static MakeContextCurrent glfwMakeContextCurrent;
        internal static GetCurrentContext glfwGetCurrentContext;
        internal static SwapBuffers glfwSwapBuffers;
        internal static SwapInterval glfwSwapInterval;
        internal static ExtensionSupported glfwExtensionSupported;
        internal static GetProcAddress glfwGetProcAddress;
    }
}

