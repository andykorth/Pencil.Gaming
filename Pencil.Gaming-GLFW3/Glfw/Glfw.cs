using System;

namespace Pencil.Gaming {
    public static unsafe class Glfw {
        public static bool Init() {
            return GlfwDelegates.glfwInit() == 1;
        }
        public static void Terminate() {
            GlfwDelegates.glfwTerminate();
        }
        public static void GetVersion(out int major, out int minor, out int rev) {
            GlfwDelegates.glfwGetVersion(out major, out minor, out rev);
        }
        public static string GetVersionString() {
            return new string(GlfwDelegates.glfwGetVersionString());
        }
        public static void SetErrorCallback(GlfwErrorFun cbfun) {
            GlfwDelegates.glfwSetErrorCallback(cbfun);
        }
        public static unsafe GlfwMonitorPtr[] GetMonitors(out int count) {
            GlfwMonitorPtr * array = GlfwDelegates.glfwGetMonitors(out count);
            GlfwMonitorPtr[] result = new GlfwMonitorPtr[count];
            for (int i = 0; i < count; ++i) {
                result[i] = array[i];
            }
            return result;
        }
        public static GlfwMonitorPtr GetPrimaryMonitor() {
            return GlfwDelegates.glfwGetPrimaryMonitor();
        }
        public static void GetMonitorPos(GlfwMonitorPtr monitor, out int xpos, out int ypos) {
            GlfwDelegates.glfwGetMonitorPos(monitor, out xpos, out ypos);
        }
        public static void GetMonitorPhysicalSize(GlfwMonitorPtr monitor, out int width, out int height) {
            GlfwDelegates.glfwGetMonitorPhysicalSize(monitor, out width, out height);
        }
        public static string GetMonitorName(GlfwMonitorPtr monitor) {
            return new string(GlfwDelegates.glfwGetMonitorName(monitor));
        }
        public static void SetMonitorCallback(GlfwMonitorFun cbfun) {
            GlfwDelegates.glfwSetMonitorCallback(cbfun);
        }
        public static GlfwVidMode[] GetVideoModes(GlfwMonitorPtr monitor, out int count) {
            GlfwVidMode * array = GlfwDelegates.glfwGetVideoModes(monitor, out count);
            GlfwVidMode[] result = new GlfwVidMode[count];
            for (int i = 0; i < count; ++i) {
                result[i] = array[i];
            }
            return result;
        }
        public static GlfwVidMode GetVideoMode(GlfwMonitorPtr monitor) {
            return GlfwDelegates.glfwGetVideoMode(monitor);
        }
        public static void SetGamma(GlfwMonitorPtr monitor, float gamma) {
            GlfwDelegates.glfwSetGamma(monitor, gamma);
        }
        public static void GetGammaRamp(GlfwMonitorPtr monitor, out GlfwGammaRamp ramp) {
            GlfwDelegates.glfwGetGammaRamp(monitor, out ramp);
        }
        public static void SetGammaRamp(GlfwMonitorPtr monitor, ref GlfwGammaRamp ramp) {
            GlfwDelegates.glfwSetGammaRamp(monitor, ref ramp);
        }
        public static void DefaultWindowHints() {
            GlfwDelegates.glfwDefaultWindowHints();
        }
        public static void WindowHint(WindowHint target, int hint) {
            GlfwDelegates.glfwWindowHint(target, hint);
        }
        public static GlfwWindowPtr CreateWindow(int width, int height, string title, GlfwMonitorPtr monitor, GlfwWindowPtr share) {
            return GlfwDelegates.glfwCreateWindow(width, height, title, monitor, share);
        }
        public static void DestroyWindow(GlfwWindowPtr window) {
            GlfwDelegates.glfwDestroyWindow(window);
        }
        public static bool WindowShouldClose(GlfwWindowPtr window) {
            return GlfwDelegates.glfwWindowShouldClose(window) == 1;
        }
        public static void SetWindowShouldClose(GlfwWindowPtr window, bool value) {
            GlfwDelegates.glfwSetWindowShouldClose(window, value ? 1 : 0);
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
        public static void SetWindowSize(GlfwWindowPtr window, int width, int height) {
            GlfwDelegates.glfwSetWindowSize(window, width, height);
        }
        public static void IconifyWindow(GlfwWindowPtr window) {
            GlfwDelegates.glfwIconifyWindow(window);
        }
        public static void RestoreWindow(GlfwWindowPtr window) {
            GlfwDelegates.glfwRestoreWindow(window);
        }
        public static void ShowWindow(GlfwWindowPtr window) {
            GlfwDelegates.glfwShowWindow(window);
        }
        public static void HideWindow(GlfwWindowPtr window) {
            GlfwDelegates.glfwHideWindow(window);
        }
        public static GlfwMonitorPtr GetWindowMonitor(GlfwWindowPtr window) {
            return GlfwDelegates.glfwGetWindowMonitor(window);
        }
        public static int GetWindowParam(GlfwWindowPtr window, WindowParam param) {
            return GlfwDelegates.glfwGetWindowParam(window, (int)param);
        }
        public static int GetWindowParam(GlfwWindowPtr window, WindowHint param) {
            return GlfwDelegates.glfwGetWindowParam(window, (int)param);
        }
        public static void SetWindowUserPointer(GlfwWindowPtr window, IntPtr pointer) {
            GlfwDelegates.glfwSetWindowUserPointer(window, pointer);
        }
        public static IntPtr GetWindowUserPointer(GlfwWindowPtr window) {
            return GlfwDelegates.glfwGetWindowUserPointer(window);
        }
        public static void SetWindowPosCallback(GlfwWindowPtr window, GlfwWindowPosFun cbfun) {
            GlfwDelegates.glfwSetWindowPosCallback(window, cbfun);
        }
        public static void SetWindowSizeCallback(GlfwWindowPtr window, GlfwWindowSizeFun cbfun) {
            GlfwDelegates.glfwSetWindowSizeCallback(window, cbfun);
        }
        public static void SetWindowCloseCallback(GlfwWindowPtr window, GlfwWindowCloseFun cbfun) {
            GlfwDelegates.glfwSetWindowCloseCallback(window, cbfun);
        }
        public static void SetWindowRefreshCallback(GlfwWindowPtr window, GlfwWindowRefreshFun cbfun) {
            GlfwDelegates.glfwSetWindowRefreshCallback(window, cbfun);
        }
        public static void SetWindowFocusCallback(GlfwWindowPtr window, GlfwWindowFocusFun cbfun) {
            GlfwDelegates.glfwSetWindowFocusCallback(window, cbfun);
        }
        public static void SetWindowIconifyCallback(GlfwWindowPtr window, GlfwWindowIconifyFun cbfun) {
            GlfwDelegates.glfwSetWindowIconifyCallback(window, cbfun);
        }
        public static void PollEvents() {
            GlfwDelegates.glfwPollEvents();
        }
        public static void WaitEvents() {
            GlfwDelegates.glfwWaitEvents();
        }
        public static int GetInputMode(GlfwWindowPtr window, InputMode mode) {
            return GlfwDelegates.glfwGetInputMode(window, mode);
        }
        public static void SetInputMode(GlfwWindowPtr window, InputMode mode, CursorMode value) {
            GlfwDelegates.glfwSetInputMode(window, mode, value);
        }
        public static bool GetKey(GlfwWindowPtr window, Key key) {
            return GlfwDelegates.glfwGetKey(window, key) != 0;
        }
        public static bool GetMouseButton(GlfwWindowPtr window, MouseButton button) {
            return GlfwDelegates.glfwGetMouseButton(window, button) != 0;
        }
        public static void GetCursorPos(GlfwWindowPtr window, out int xpos, out int ypos) {
            GlfwDelegates.glfwGetCursorPos(window, out xpos, out ypos);
        }
        public static void SetCursorPos(GlfwWindowPtr window, int xpos, int ypos) {
            GlfwDelegates.glfwSetCursorPos(window, xpos, ypos);
        }
        public static void SetKeyCallback(GlfwWindowPtr window, GlfwKeyFun cbfun) {
            GlfwDelegates.glfwSetKeyCallback(window, cbfun);
        }
        public static void SetCharCallback(GlfwWindowPtr window, GlfwCharFun cbfun) {
            GlfwDelegates.glfwSetCharCallback(window, cbfun);
        }
        public static void SetMouseButtonCallback(GlfwWindowPtr window, GlfwMouseButtonFun cbfun) {
            GlfwDelegates.glfwSetMouseButtonCallback(window, cbfun);
        }
        public static void SetCursorPosCallback(GlfwWindowPtr window, GlfwCursorPosFun cbfun) {
            GlfwDelegates.glfwSetCursorPosCallback(window, cbfun);
        }
        public static void SetCursorEnterCallback(GlfwWindowPtr window, GlfwCursorEnterFun cbfun) {
            GlfwDelegates.glfwSetCursorEnterCallback(window, cbfun);
        }
        public static void SetScrollCallback(GlfwWindowPtr window, GlfwScrollFun cbfun) {
            GlfwDelegates.glfwSetScrollCallback(window, cbfun);
        }
        public static int GetJoystickParam(Joystick joy, JoystickParam param) {
            return GlfwDelegates.glfwGetJoystickParam(joy, param);
        }
        public static int GetJoystickAxes(Joystick joy, float[] axes, int numaxes) {
            return GlfwDelegates.glfwGetJoystickAxes(joy, axes, numaxes);
        }
        public static int GetJoystickButtons(Joystick joy, byte[] buttons, int numbuttons) {
            return GlfwDelegates.glfwGetJoystickButtons(joy, buttons, numbuttons);
        }
        public static string GetJoystickName(Joystick joy) {
            return new string(GlfwDelegates.glfwGetJoystickName(joy));
        }
        public static void SetClipboardString(GlfwWindowPtr window, string @string) {
            GlfwDelegates.glfwSetClipboardString(window,  @string);
        }
        public static string GetClipboardString(GlfwWindowPtr window) {
            return new string(GlfwDelegates.glfwGetClipboardString(window));
        }
        public static double GetTime() {
            return GlfwDelegates.glfwGetTime();
        }
        public static void SetTime(double time) {
            GlfwDelegates.glfwSetTime(time);
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
        public static void SwapInterval(bool interval) {
            GlfwDelegates.glfwSwapInterval(interval ? 1 : 0);
        }
        public static bool ExtensionSupported(string extension) {
            return GlfwDelegates.glfwExtensionSupported(extension) == 1;
        }
        public static IntPtr GetProcAddress(string procname) {
            return GlfwDelegates.glfwGetProcAddress(procname);
        }
    }
}

