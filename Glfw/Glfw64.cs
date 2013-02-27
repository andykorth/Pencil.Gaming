using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    internal static class Glfw64 {
        private const string lib = "glfw64";
        private const CallingConvention cconv = CallingConvention.FastCall;

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwInit();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwTerminate();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwGetVersion(out int major, out int minor, out int rev);

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwOpenWindow(int width, int height, int redbits, int greenbits, int bluebits, int alphabits, int depthbits, int stencilbits, int mode);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwOpenWindowHint(int target, int hint);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwCloseWindow();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSetWindowTitle([MarshalAs(UnmanagedType.LPStr)] string title);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwGetWindowSize(out int width, out int height);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSetWindowSize(int width, int height);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSetWindowPos(int x, int y);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwIconifyWindow();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwRestoreWindow();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSwapBuffers();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSwapInterval(int interval);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetWindowParam(int param);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSetWindowSizeCallback(/*GLFWwindowsizefun*/IntPtr cbfun);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSetWindowCloseCallback(/*GLFWwindowclosefun*/IntPtr cbfun);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSetWindowRefreshCallback(/*GLFWwindowrefreshfun*/IntPtr cbfun);

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetVideoModes([MarshalAs(UnmanagedType.LPArray)] GlfwVidMode[] list, int maxcount);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwGetDesktopMode(out GlfwVidMode mode);

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwPollEvents();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwWaitEvents();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetKey(int key);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetMouseButton(int button);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwGetMousePos(out int xpos, out int ypos);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSetMousePos(int xpos, int ypos);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetMouseWheel();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSetMouseWheel(int pos);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSetKeyCallback(/*GLFWkeyfun*/IntPtr cbfun);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSetCharCallback(/*GLFWcharfun*/IntPtr cbfun);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSetMouseButtonCallback(/*GLFWmousebuttonfun*/IntPtr cbfun);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSetMousePosCallback(/*GLFWmouseposfun*/IntPtr cbfun);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSetMouseWheelCallback(/*GLFWmousewheelfun*/IntPtr cbfun);

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetJoystickParam(int joy, int param);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetJoystickPos(int joy, [MarshalAs(UnmanagedType.LPArray)] float[] pos, int numaxes);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetJoystickButtons(int joy, [MarshalAs(UnmanagedType.LPArray)] byte[] buttons, int numbuttons);

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern double glfwGetTime();
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSetTime(double time);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwSleep(double time);

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern IntPtr glfwGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwGetGLVersion(out int major, out int minor, out int rev);

        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern /*GLFWthread*/IntPtr glfwCreateThread(/*GLFWthreadfun*/IntPtr fun, IntPtr arg);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwDestroyThread(/*GLFWthread*/IntPtr ID);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern int glfwWaitThread(/*GLFWthread*/IntPtr ID, int waitmode);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern /*GLFWthread*/IntPtr glfwGetThreadID();
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern /*GLFWmutex*/IntPtr glfwCreateMutex();
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwDestroyMutex(/*GLFWmutex*/IntPtr mutex);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwLockMutex(/*GLFWmutex*/IntPtr mutex);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwUnlockMutex(/*GLFWmutex*/IntPtr mutex);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern /*GLFWcond*/IntPtr glfwCreateCond();
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwDestroyCond(/*GLFWcond*/IntPtr cond);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwWaitCond(/*GLFWcond*/IntPtr cond, /*GLFWmutex*/IntPtr mutex, double timeout);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwSignalCond(/*GLFWcond*/IntPtr cond);
        //[DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        //internal static extern void glfwBroadcastCond(/*GLFWcond*/IntPtr cond);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwGetNumberOfProcessors();

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwEnable(int token);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwDisable(int token);

        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwReadImage([MarshalAs(UnmanagedType.LPStr)] string name, out GlfwImage img, int flags);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwReadMemoryImage(IntPtr data, long size, ref GlfwImage img, int flags);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern void glfwFreeImage(ref GlfwImage img);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwLoadTexture2D([MarshalAs(UnmanagedType.LPStr)] string name, int flags);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwLoadMemoryTexture2D(IntPtr data, long size, int flags);
        [DllImport(Glfw64.lib, CallingConvention = Glfw64.cconv)]
        internal static extern int glfwLoadTextureImage2D(ref GlfwImage img, int flags);
    }
}

