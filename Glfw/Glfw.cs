// License: ../LICENSE.TXT

using System;
using System.Runtime.InteropServices;
using Pencil.Gaming.Graphics;

namespace Pencil.Gaming {
    public static partial class Glfw {
        public const double Infinity = 100000.0;
        public const int True = 1;
        public const int False = 0;
        public const int VersionMajor = 2;
        public const int VersionMinor = 7;
        public const int VersionRevision = 2;

        public static int Init() {
            return GlfwDelegates.glfwInit();
        }
        public static void Terminate() {
            GlfwDelegates.glfwTerminate();
        }
        public static void GetVersion(out int major, out int minor, out int rev) {
            GlfwDelegates.glfwGetVersion(out major, out minor, out rev);
        }

        public static int OpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, WindowMode mode) {
            Glfw.Utils.widthBackup = width;
            Glfw.Utils.heightBackup = height;
            Glfw.Utils.redBitsBackup = redbits;
            Glfw.Utils.greenBitsBackup = greenbits;
            Glfw.Utils.blueBitsBackup = bluebits;
            Glfw.Utils.alphaBitsBackup = alphabits;
            Glfw.Utils.depthBitsBackup = depthbits;
            Glfw.Utils.stencilBitsBackup = stencilbits;
            Glfw.Utils.isFullscreen = (mode == WindowMode.FullScreen);
            return GlfwDelegates.glfwOpenWindow(width, height, redbits, greenbits, bluebits, alphabits, depthbits, stencilbits, (int) mode);
        }
        public static void OpenWindowHint(OpenWindowHint target, int hint) {
            GlfwDelegates.glfwOpenWindowHint((int) target, hint);
        }
        public static void CloseWindow() {
            GlfwDelegates.glfwCloseWindow();
        }
        public static void SetWindowTitle(string title) {
            GlfwDelegates.glfwSetWindowTitle(title);
        }
        public static void GetWindowSize(out int width, out int height) {
            GlfwDelegates.glfwGetWindowSize(out width, out height);
        }
        public static void SetWindowSize(int width, int height) {
            GlfwDelegates.glfwSetWindowSize(width, height);
        }
        public static void SetWindowPos(int x, int y) {
            GlfwDelegates.glfwSetWindowPos(x, y);
        }
        public static void IconifyWindow() {
            GlfwDelegates.glfwIconifyWindow();
        }
        public static void RestoreWindow() {
            GlfwDelegates.glfwRestoreWindow();
        }
        public static void SwapBuffers() {
            GlfwDelegates.glfwSwapBuffers();
        }
        public static void SwapInterval(bool interval) {
            GlfwDelegates.glfwSwapInterval(interval ? 1 : 0);
        }
        public static int GetWindowParam(WindowParam param) {
            return GlfwDelegates.glfwGetWindowParam((int) param);
        }
//        public static void SetWindowSizeCallback(/*windowsizefun*/IntPtr cbfun) {
//            GlfwDelegates.glfwSetWindowSizeCallback(cbfun);
//        }
//        public static void SetWindowCloseCallback(/*windowclosefun*/IntPtr cbfun) {
//            GlfwDelegates.glfwSetWindowCloseCallback(cbfun);
//        }
//        public static void SetWindowRefreshCallback(/*windowrefreshfun*/IntPtr cbfun) {
//            GlfwDelegates.glfwSetWindowRefreshCallback(cbfun);
//        }

        public static int GetVideoModes(GlfwVidMode[] list, int maxcount) {
            return GlfwDelegates.glfwGetVideoModes(list, maxcount);
        }
        public static void GetDesktopMode(out GlfwVidMode mode) {
            GlfwDelegates.glfwGetDesktopMode(out mode);
        }

        public static void PollEvents() {
            GlfwDelegates.glfwPollEvents();
        }
        public static void WaitEvents() {
            GlfwDelegates.glfwWaitEvents();
        }
        public static bool GetKey(Key key) {
            return GlfwDelegates.glfwGetKey((int) key) == 1;
        }
        public static bool GetKey(char key) {
            return GlfwDelegates.glfwGetKey((int) key) == 1;
        }
        public static int GetMouseButton(MouseButton button) {
            return GlfwDelegates.glfwGetMouseButton((int) button);
        }
        public static void GetMousePos(out int xpos, out int ypos) {
            GlfwDelegates.glfwGetMousePos(out xpos, out ypos);
        }
        public static void SetMousePos(int xpos, int ypos) {
            GlfwDelegates.glfwSetMousePos(xpos, ypos);
        }
        
        public static int GetMouseWheel() {
            return GlfwDelegates.glfwGetMouseWheel();
        }
        public static void SetMouseWheel(int pos) {
            GlfwDelegates.glfwSetMouseWheel(pos);
        }
//        public static void SetKeyCallback(/*keyfun*/IntPtr cbfun) {
//            GlfwDelegates.glfwSetKeyCallback(cbfun);
//        }
//        public static void SetCharCallback(/*charfun*/IntPtr cbfun) {
//            GlfwDelegates.glfwSetCharCallback(cbfun);
//        }
//        public static void SetMouseButtonCallback(/*mousebuttonfun*/IntPtr cbfun) {
//            GlfwDelegates.glfwSetMouseButtonCallback(cbfun);
//        }
//        public static void SetMousePosCallback(/*mouseposfun*/IntPtr cbfun) {
//            GlfwDelegates.glfwSetMousePosCallback(cbfun);
//        }
//        public static void SetMouseWheelCallback(/*mousewheelfun*/IntPtr cbfun) {
//            GlfwDelegates.glfwSetMouseWheelCallback(cbfun);
//        }

        public static int GetJoystickParam(Joystick joy, int param) {
            return GlfwDelegates.glfwGetJoystickParam((int) joy, param);
        }
        public static int GetJoystickPos(Joystick joy, float[] pos, int numaxes) {
            return GlfwDelegates.glfwGetJoystickPos((int) joy, pos, numaxes);
        }
        public static int GetJoystickButtons(Joystick joy, byte[] buttons, int numbuttons) {
            return GlfwDelegates.glfwGetJoystickButtons((int) joy, buttons, numbuttons);
        }

        public static double GetTime() {
            return GlfwDelegates.glfwGetTime();
        }
        public static void SetTime(double time) {
            GlfwDelegates.glfwSetTime(time);
        }

        // Couldn't you just use Thread.Sleep()?
        public static void Sleep(double time) {
            GlfwDelegates.glfwSleep(time);
        }

        public static int ExtensionSupported(string extension) {
            return GlfwDelegates.glfwExtensionSupported(extension);
        }
        public static IntPtr GetProcAddress(string procname) {
            return GlfwDelegates.glfwGetProcAddress(procname);
        }
        public static void GetGLVersion(out int major, out int minor, out int rev) {
            GlfwDelegates.glfwGetGLVersion(out major, out minor, out rev);
        }

        #region Threadin
        // What?
        // This is C# ladies and gentlemen, no need for 3rd party threading libraries!!!


//        public static /*thread*/IntPtr CreateThread(/*threadfun*/IntPtr fun, IntPtr arg) {
//            return GlfwDelegates.glfwCreateThread(fun, arg);
//        }
//        public static void DestroyThread(/*thread*/IntPtr ID) {
//            GlfwDelegates.glfwDestroyThread(ID);
//        }
//        public static int WaitThread(/*thread*/IntPtr ID, int waitmode) {
//            return GlfwDelegates.glfwWaitThread(ID, waitmode);
//        }
//        public static /*thread*/IntPtr GetThreadID() {
//            return GlfwDelegates.glfwGetThreadID();
//        }
//        public static /*mutex*/IntPtr CreateMutex() {
//            return GlfwDelegates.glfwCreateMutex();
//        }
//        public static void DestroyMutex(/*mutex*/IntPtr mutex) {
//            GlfwDelegates.glfwDestroyMutex(mutex);
//        }
//        public static void LockMutex(/*mutex*/IntPtr mutex) {
//            GlfwDelegates.glfwLockMutex(mutex);
//        }
//        public static void UnlockMutex(/*mutex*/IntPtr mutex) {
//            GlfwDelegates.glfwUnlockMutex(mutex);
//        }
//        public static /*cond*/IntPtr CreateCond() {
//            return GlfwDelegates.glfwCreateCond();
//        }
//        public static void DestroyCond(/*cond*/IntPtr cond) {
//            GlfwDelegates.glfwDestroyCond(cond);
//        }
//        public static void WaitCond(/*cond*/IntPtr cond, /*mutex*/IntPtr mutex, double timeout) {
//            GlfwDelegates.glfwWaitCond(cond, mutex, timeout);
//        }
//        public static void SignalCond(/*cond*/IntPtr cond) {
//            GlfwDelegates.glfwSignalCond(cond);
//        }
//        public static void BroadcastCond(/*cond*/IntPtr cond) {
//            GlfwDelegates.glfwBroadcastCond(cond);
//        }

        #endregion

        public static int GetNumberOfProcessors() {
            return GlfwDelegates.glfwGetNumberOfProcessors();
        }

        public static void Enable(GlfwEnableCap token) {
            GlfwDelegates.glfwEnable((int) token);
        }
        public static void Disable(GlfwEnableCap token) {
            GlfwDelegates.glfwDisable((int) token);
        }

        public static int ReadImage(string name, out GlfwImage img, ReadImageModes flags) {
            return GlfwDelegates.glfwReadImage(name, out img, (int) flags);
        }
        public static int ReadMemoryImage(IntPtr data, long size, ref GlfwImage img, ReadImageModes flags) {
            return GlfwDelegates.glfwReadMemoryImage(data, size, ref img, (int) flags);
        }
        public static void FreeImage(ref GlfwImage img) {
            GlfwDelegates.glfwFreeImage(ref img);
        }
        public static int LoadTexture2D(string name, ReadImageModes flags) {
            return GlfwDelegates.glfwLoadTexture2D(name, (int) flags);
        }
        public static int LoadMemoryTexture2D(IntPtr data, long size, ReadImageModes flags) {
            return GlfwDelegates.glfwLoadMemoryTexture2D(data, size, (int) flags);
        }
        public static int LoadTextureImage2D(ref GlfwImage img, ReadImageModes flags) {
            return GlfwDelegates.glfwLoadTextureImage2D(ref img, (int) flags);
        }
    }
}

