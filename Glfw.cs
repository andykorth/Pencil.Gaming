using System;
using System.Runtime.InteropServices;
using Pencil.Gaming.Graphics;

namespace Pencil.Gaming {
    public static class Glfw {
        public const double Infinity = 100000.0;
        public const int True = 1;
        public const int False = 0;

        [DllImport("glfw")]
        private static extern int glfwInit();
        [DllImport("glfw")]
        private static extern void glfwTerminate();
        [DllImport("glfw")]
        private static extern void glfwGetVersion(out int major, out int minor, out int rev);

        [DllImport("glfw")]
        private static extern int glfwOpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, int mode);
        [DllImport("glfw")]
        private static extern void glfwOpenWindowHint(int target, int hint);
        [DllImport("glfw")]
        private static extern void glfwCloseWindow();
        [DllImport("glfw")]
        private static extern void glfwSetWindowTitle([MarshalAs(UnmanagedType.LPStr)] string title);
        [DllImport("glfw")]
        private static extern void glfwGetWindowSize(out int width, out int height);
        [DllImport("glfw")]
        private static extern void glfwSetWindowSize(int width, int height);
        [DllImport("glfw")]
        private static extern void glfwSetWindowPos(int x, int y);
        [DllImport("glfw")]
        private static extern void glfwIconifyWindow();
        [DllImport("glfw")]
        private static extern void glfwRestoreWindow();
        [DllImport("glfw")]
        private static extern void glfwSwapBuffers();
        [DllImport("glfw")]
        private static extern void glfwSwapInterval(int interval);
        [DllImport("glfw")]
        private static extern int glfwGetWindowParam(int param);
        [DllImport("glfw")]
        private static extern void glfwSetWindowSizeCallback(/*GLFWwindowsizefun*/IntPtr cbfun);
        [DllImport("glfw")]
        private static extern void glfwSetWindowCloseCallback(/*GLFWwindowclosefun*/IntPtr cbfun);
        [DllImport("glfw")]
        private static extern void glfwSetWindowRefreshCallback(/*GLFWwindowrefreshfun*/IntPtr cbfun);

        [DllImport("glfw")]
        private static extern int glfwGetVideoModes(/*GLFWvidmode **/IntPtr list, int maxcount);
        [DllImport("glfw")]
        private static extern void glfwGetDesktopMode(/*GLFWvidmode **/IntPtr mode);

        [DllImport("glfw")]
        private static extern void glfwPollEvents();
        [DllImport("glfw")]
        private static extern void glfwWaitEvents();
        [DllImport("glfw")]
        private static extern int glfwGetKey(int key);
        [DllImport("glfw")]
        private static extern int glfwGetMouseButton(int button);
        [DllImport("glfw")]
        private static extern void glfwGetMousePos(out int xpos, out int ypos);
        [DllImport("glfw")]
        private static extern void glfwSetMousePos(int xpos, int ypos);
        [DllImport("glfw")]
        private static extern int glfwGetMouseWheel();
        [DllImport("glfw")]
        private static extern void glfwSetMouseWheel(int pos);
        [DllImport("glfw")]
        private static extern void glfwSetKeyCallback(/*GLFWkeyfun*/IntPtr cbfun);
        [DllImport("glfw")]
        private static extern void glfwSetCharCallback(/*GLFWcharfun*/IntPtr cbfun);
        [DllImport("glfw")]
        private static extern void glfwSetMouseButtonCallback(/*GLFWmousebuttonfun*/IntPtr cbfun);
        [DllImport("glfw")]
        private static extern void glfwSetMousePosCallback(/*GLFWmouseposfun*/IntPtr cbfun);
        [DllImport("glfw")]
        private static extern void glfwSetMouseWheelCallback(/*GLFWmousewheelfun*/IntPtr cbfun);

        [DllImport("glfw")]
        private static extern int glfwGetJoystickParam(int joy, int param);
        [DllImport("glfw")]
        private static extern int glfwGetJoystickPos(int joy, float[] pos, int numaxes);
        [DllImport("glfw")]
        private static extern int glfwGetJoystickButtons(int joy, byte[] buttons, int numbuttons);

        [DllImport("glfw")]
        private static extern double glfwGetTime();
        [DllImport("glfw")]
        private static extern void glfwSetTime(double time);
        [DllImport("glfw")]
        private static extern void glfwSleep(double time);

        [DllImport("glfw")]
        private static extern int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
        [DllImport("glfw")]
        private static extern IntPtr glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);
        [DllImport("glfw")]
        private static extern void glfwGetGLVersion(out int major, out int minor, out int rev);

        [DllImport("glfw")]
        private static extern /*GLFWthread*/IntPtr glfwCreateThread(/*GLFWthreadfun*/IntPtr fun, IntPtr arg);
        [DllImport("glfw")]
        private static extern void glfwDestroyThread(/*GLFWthread*/IntPtr ID);
        [DllImport("glfw")]
        private static extern int glfwWaitThread(/*GLFWthread*/IntPtr ID, int waitmode);
        [DllImport("glfw")]
        private static extern /*GLFWthread*/IntPtr glfwGetThreadID();
        [DllImport("glfw")]
        private static extern /*GLFWmutex*/IntPtr glfwCreateMutex();
        [DllImport("glfw")]
        private static extern void glfwDestroyMutex(/*GLFWmutex*/IntPtr mutex);
        [DllImport("glfw")]
        private static extern void glfwLockMutex(/*GLFWmutex*/IntPtr mutex);
        [DllImport("glfw")]
        private static extern void glfwUnlockMutex(/*GLFWmutex*/IntPtr mutex);
        [DllImport("glfw")]
        private static extern /*GLFWcond*/IntPtr glfwCreateCond();
        [DllImport("glfw")]
        private static extern void glfwDestroyCond(/*GLFWcond*/IntPtr cond);
        [DllImport("glfw")]
        private static extern void glfwWaitCond(/*GLFWcond*/IntPtr cond, /*GLFWmutex*/IntPtr mutex, double timeout);
        [DllImport("glfw")]
        private static extern void glfwSignalCond(/*GLFWcond*/IntPtr cond);
        [DllImport("glfw")]
        private static extern void glfwBroadcastCond(/*GLFWcond*/IntPtr cond);
        [DllImport("glfw")]
        private static extern int glfwGetNumberOfProcessors();

        [DllImport("glfw")]
        private static extern void glfwEnable(int token);
        [DllImport("glfw")]
        private static extern void glfwDisable(int token);

        [DllImport("glfw")]
        private static extern int glfwReadImage([MarshalAs(UnmanagedType.LPStr)] string name, /*GLFWimage **/IntPtr img, int flags);
        [DllImport("glfw")]
        private static extern int glfwReadMemoryImage([MarshalAs(UnmanagedType.LPStr)] string data, long size, /*GLFWimage **/IntPtr img, int flags);
        [DllImport("glfw")]
        private static extern void glfwFreeImage(/*GLFWimage **/IntPtr img);
        [DllImport("glfw")]
        private static extern int glfwLoadTexture2D([MarshalAs(UnmanagedType.LPStr)] string name, int flags);
        [DllImport("glfw")]
        private static extern int glfwLoadMemoryTexture2D(IntPtr data, long size, int flags);
        [DllImport("glfw")]
        private static extern int glfwLoadTextureImage2D(/*GLFWimage **/IntPtr img, int flags);







        public static int Init() {
            return glfwInit();
        }
        public static void Terminate() {
            glfwTerminate();
        }
        public static void GetVersion(out int major, out int minor, out int rev) {
            glfwGetVersion(out major, out minor, out rev);
        }

        public static int OpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, WindowMode mode) {
            int result = glfwOpenWindow(width, height, redbits, greenbits, bluebits, alphabits, depthbits, stencilbits, (int)mode);
            // Now is an appropriate time time load up OpenGL
            GLLoader.LoadAll();

            return result;
        }
        public static void OpenWindowHint(int target, WindowOpenHint hint) {
            glfwOpenWindowHint(target, (int)hint);
        }
        public static void CloseWindow() {
            glfwCloseWindow();
        }
        public static void SetWindowTitle(string title) {
            glfwSetWindowTitle(title);
        }
        public static void GetWindowSize(out int width, out int height) {
            glfwGetWindowSize(out width, out height);
        }
        public static void SetWindowSize(int width, int height) {
            glfwSetWindowSize(width, height);
        }
        public static void SetWindowPos(int x, int y) {
            glfwSetWindowPos(x, y);
        }
        public static void IconifyWindow() {
            glfwIconifyWindow();
        }
        public static void RestoreWindow() {
            glfwRestoreWindow();
        }
        public static void SwapBuffers() {
            glfwSwapBuffers();
        }
        public static void SwapInterval(bool interval) {
            glfwSwapInterval(interval ? 1 : 0);
        }
        public static int GetWindowParam(WindowParam param) {
            return glfwGetWindowParam((int)param);
        }
        public static void SetWindowSizeCallback(/*windowsizefun*/IntPtr cbfun) {
            glfwSetWindowSizeCallback(cbfun);
        }
        public static void SetWindowCloseCallback(/*windowclosefun*/IntPtr cbfun) {
            glfwSetWindowCloseCallback(cbfun);
        }
        public static void SetWindowRefreshCallback(/*windowrefreshfun*/IntPtr cbfun) {
            glfwSetWindowRefreshCallback(cbfun);
        }

        public static int GetVideoModes(/*vidmode **/IntPtr list, int maxcount) {
            return glfwGetVideoModes(list, maxcount);
        }
        public static void GetDesktopMode(/*vidmode **/IntPtr mode) {
            glfwGetDesktopMode(mode);
        }

        public static void PollEvents() {
            glfwPollEvents();
        }
        public static void WaitEvents() {
            glfwWaitEvents();
        }
        public static bool GetKey(Key key) {
            return glfwGetKey((int)key) == 1;
        }
        public static bool GetKey(char key) {
            return glfwGetKey((int)key) == 1;
        }
        public static int GetMouseButton(MouseButton button) {
            return glfwGetMouseButton((int)button);
        }
        public static void GetMousePos(out int xpos, out int ypos) {
            glfwGetMousePos(out xpos, out ypos);
        }
        public static void SetMousePos(int xpos, int ypos) {
            glfwSetMousePos(xpos, ypos);
        }
        public static int GetMouseWheel() {
            return glfwGetMouseWheel();
        }
        public static void SetMouseWheel(int pos) {
            glfwSetMouseWheel(pos);
        }
        public static void SetKeyCallback(/*keyfun*/IntPtr cbfun) {
            glfwSetKeyCallback(cbfun);
        }
        public static void SetCharCallback(/*charfun*/IntPtr cbfun) {
            glfwSetCharCallback(cbfun);
        }
        public static void SetMouseButtonCallback(/*mousebuttonfun*/IntPtr cbfun) {
            glfwSetMouseButtonCallback(cbfun);
        }
        public static void SetMousePosCallback(/*mouseposfun*/IntPtr cbfun) {
            glfwSetMousePosCallback(cbfun);
        }
        public static void SetMouseWheelCallback(/*mousewheelfun*/IntPtr cbfun) {
            glfwSetMouseWheelCallback(cbfun);
        }

        public static int GetJoystickParam(Joystick joy, int param) {
            return glfwGetJoystickParam((int)joy, param);
        }
        public static int GetJoystickPos(Joystick joy, float[] pos, int numaxes) {
            return glfwGetJoystickPos((int)joy, pos, numaxes);
        }
        public static int GetJoystickButtons(Joystick joy, byte[] buttons, int numbuttons) {
            return glfwGetJoystickButtons((int)joy, buttons, numbuttons);
        }

        public static double GetTime() {
            return glfwGetTime();
        }
        public static void SetTime(double time) {
            glfwSetTime(time);
        }

        // Couldn't you just use Thread.Sleep()?
        public static void Sleep(double time) {
            glfwSleep(time);
        }

        public static int ExtensionSupported(string extension) {
            return glfwExtensionSupported(extension);
        }
        public static IntPtr GetProcAddress(string procname) {
            return glfwGetProcAddress(procname);
        }
        public static void GetGLVersion(out int major, out int minor, out int rev) {
            glfwGetGLVersion(out major, out minor, out rev);
        }

        #region Threadin
        // What?
        // This is C# ladies and gentlemen, no need for 3rd party threading libraries!!!


        public static /*thread*/IntPtr CreateThread(/*threadfun*/IntPtr fun, IntPtr arg) {
            return glfwCreateThread(fun, arg);
        }
        public static void DestroyThread(/*thread*/IntPtr ID) {
            glfwDestroyThread(ID);
        }
        public static int WaitThread(/*thread*/IntPtr ID, int waitmode) {
            return glfwWaitThread(ID, waitmode);
        }
        public static /*thread*/IntPtr GetThreadID() {
            return glfwGetThreadID();
        }
        public static /*mutex*/IntPtr CreateMutex() {
            return glfwCreateMutex();
        }
        public static void DestroyMutex(/*mutex*/IntPtr mutex) {
            glfwDestroyMutex(mutex);
        }
        public static void LockMutex(/*mutex*/IntPtr mutex) {
            glfwLockMutex(mutex);
        }
        public static void UnlockMutex(/*mutex*/IntPtr mutex) {
            glfwUnlockMutex(mutex);
        }
        public static /*cond*/IntPtr CreateCond() {
            return glfwCreateCond();
        }
        public static void DestroyCond(/*cond*/IntPtr cond) {
            glfwDestroyCond(cond);
        }
        public static void WaitCond(/*cond*/IntPtr cond, /*mutex*/IntPtr mutex, double timeout) {
            glfwWaitCond(cond, mutex, timeout);
        }
        public static void SignalCond(/*cond*/IntPtr cond) {
            glfwSignalCond(cond);
        }
        public static void BroadcastCond(/*cond*/IntPtr cond) {
            glfwBroadcastCond(cond);
        }

        #endregion

        public static int GetNumberOfProcessors() {
            return glfwGetNumberOfProcessors();
        }

        public static void Enable(int token) {
            glfwEnable(token);
        }
        public static void Disable(int token) {
            glfwDisable(token);
        }

        public static int ReadImage(string name, /*image **/IntPtr img, int flags) {
            return glfwReadImage(name, img, flags);
        }
        public static int ReadMemoryImage(string data, long size, /*image **/IntPtr img, int flags) {
            return glfwReadMemoryImage(data, size, img, flags);
        }
        public static void FreeImage(/*image **/IntPtr img) {
            glfwFreeImage(img);
        }
        public static int LoadTexture2D(string name, int flags) {
            return glfwLoadTexture2D(name, flags);
        }
        public static int LoadMemoryTexture2D(IntPtr data, long size, int flags) {
            return glfwLoadMemoryTexture2D(data, size, flags);
        }
        public static int LoadTextureImage2D(/*image **/IntPtr img, int flags) {
            return glfwLoadTextureImage2D(img, flags);
        }
    }
}

