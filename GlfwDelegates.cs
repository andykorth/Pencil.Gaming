using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    internal static class GlfwDelegates {
        static GlfwDelegates() {
            if (Environment.Is64BitOperatingSystem) {
                glfwInit = Glfw64.glfwInit;
                glfwTerminate = Glfw64.glfwTerminate;
                glfwGetVersion = Glfw64.glfwGetVersion;
                glfwOpenWindow = Glfw64.glfwOpenWindow;
                glfwOpenWindowHint = Glfw64.glfwOpenWindowHint;
                glfwCloseWindow = Glfw64.glfwCloseWindow;
                glfwSetWindowTitle = Glfw64.glfwSetWindowTitle;
                glfwGetWindowSize = Glfw64.glfwGetWindowSize;
                glfwSetWindowSize = Glfw64.glfwSetWindowSize;
                glfwSetWindowPos = Glfw64.glfwSetWindowPos;
                glfwIconifyWindow = Glfw64.glfwIconifyWindow;
                glfwRestoreWindow = Glfw64.glfwRestoreWindow;
                glfwSwapBuffers = Glfw64.glfwSwapBuffers;
                glfwSwapInterval = Glfw64.glfwSwapInterval;
                glfwGetWindowParam = Glfw64.glfwGetWindowParam;
                glfwGetVideoModes = Glfw64.glfwGetVideoModes;
                glfwGetDesktopMode = Glfw64.glfwGetDesktopMode;
                glfwPollEvents = Glfw64.glfwPollEvents;
                glfwWaitEvents = Glfw64.glfwWaitEvents;
                glfwGetKey = Glfw64.glfwGetKey;
                glfwGetMouseButton = Glfw64.glfwGetMouseButton;
                glfwGetMousePos = Glfw64.glfwGetMousePos;
                glfwSetMousePos = Glfw64.glfwSetMousePos;
                glfwGetMouseWheel = Glfw64.glfwGetMouseWheel;
                glfwSetMouseWheel = Glfw64.glfwSetMouseWheel;
                glfwGetJoystickParam = Glfw64.glfwGetJoystickParam;
                glfwGetJoystickPos = Glfw64.glfwGetJoystickPos;
                glfwGetJoystickButtons = Glfw64.glfwGetJoystickButtons;
                glfwGetTime = Glfw64.glfwGetTime;
                glfwSetTime = Glfw64.glfwSetTime;
                glfwSleep = Glfw64.glfwSleep;
                glfwExtensionSupported = Glfw64.glfwExtensionSupported;
                glfwGetProcAddress = Glfw64.glfwGetProcAddress;
                glfwGetGLVersion = Glfw64.glfwGetGLVersion;
                glfwGetNumberOfProcessors = Glfw64.glfwGetNumberOfProcessors;
                glfwEnable = Glfw64.glfwEnable;
                glfwDisable = Glfw64.glfwDisable;
                glfwReadImage = Glfw64.glfwReadImage;
                glfwReadMemoryImage = Glfw64.glfwReadMemoryImage;
                glfwFreeImage = Glfw64.glfwFreeImage;
                glfwLoadTexture2D = Glfw64.glfwLoadTexture2D;
                glfwLoadMemoryTexture2D = Glfw64.glfwLoadMemoryTexture2D;
                glfwLoadTextureImage2D = Glfw64.glfwLoadTextureImage2D;
            } else {
                glfwInit = Glfw32.glfwInit;
                glfwTerminate = Glfw32.glfwTerminate;
                glfwGetVersion = Glfw32.glfwGetVersion;
                glfwOpenWindow = Glfw32.glfwOpenWindow;
                glfwOpenWindowHint = Glfw32.glfwOpenWindowHint;
                glfwCloseWindow = Glfw32.glfwCloseWindow;
                glfwSetWindowTitle = Glfw32.glfwSetWindowTitle;
                glfwGetWindowSize = Glfw32.glfwGetWindowSize;
                glfwSetWindowSize = Glfw32.glfwSetWindowSize;
                glfwSetWindowPos = Glfw32.glfwSetWindowPos;
                glfwIconifyWindow = Glfw32.glfwIconifyWindow;
                glfwRestoreWindow = Glfw32.glfwRestoreWindow;
                glfwSwapBuffers = Glfw32.glfwSwapBuffers;
                glfwSwapInterval = Glfw32.glfwSwapInterval;
                glfwGetWindowParam = Glfw32.glfwGetWindowParam;
                glfwGetVideoModes = Glfw32.glfwGetVideoModes;
                glfwGetDesktopMode = Glfw32.glfwGetDesktopMode;
                glfwPollEvents = Glfw32.glfwPollEvents;
                glfwWaitEvents = Glfw32.glfwWaitEvents;
                glfwGetKey = Glfw32.glfwGetKey;
                glfwGetMouseButton = Glfw32.glfwGetMouseButton;
                glfwGetMousePos = Glfw32.glfwGetMousePos;
                glfwSetMousePos = Glfw32.glfwSetMousePos;
                glfwGetMouseWheel = Glfw32.glfwGetMouseWheel;
                glfwSetMouseWheel = Glfw32.glfwSetMouseWheel;
                glfwGetJoystickParam = Glfw32.glfwGetJoystickParam;
                glfwGetJoystickPos = Glfw32.glfwGetJoystickPos;
                glfwGetJoystickButtons = Glfw32.glfwGetJoystickButtons;
                glfwGetTime = Glfw32.glfwGetTime;
                glfwSetTime = Glfw32.glfwSetTime;
                glfwSleep = Glfw32.glfwSleep;
                glfwExtensionSupported = Glfw32.glfwExtensionSupported;
                glfwGetProcAddress = Glfw32.glfwGetProcAddress;
                glfwGetGLVersion = Glfw32.glfwGetGLVersion;
                glfwGetNumberOfProcessors = Glfw32.glfwGetNumberOfProcessors;
                glfwEnable = Glfw32.glfwEnable;
                glfwDisable = Glfw32.glfwDisable;
                glfwReadImage = Glfw32.glfwReadImage;
                glfwReadMemoryImage = Glfw32.glfwReadMemoryImage;
                glfwFreeImage = Glfw32.glfwFreeImage;
                glfwLoadTexture2D = Glfw32.glfwLoadTexture2D;
                glfwLoadMemoryTexture2D = Glfw32.glfwLoadMemoryTexture2D;
                glfwLoadTextureImage2D = Glfw32.glfwLoadTextureImage2D;
            }
        }

        internal delegate int Init();
        internal static Init glfwInit;
        internal delegate void Terminate();
        internal static Terminate glfwTerminate;
        internal delegate void GetVersion(out int major,out int minor,out int rev);
        internal static GetVersion glfwGetVersion;

        internal delegate int OpenWindow(int width,int height,int redbits,int greenbits,int bluebits,int alphabits,int depthbits,int stencilbits,int mode);
        internal static OpenWindow glfwOpenWindow;
        internal delegate void OpenWindowHint(int target,int hint);
        internal static OpenWindowHint glfwOpenWindowHint;
        internal delegate void CloseWindow();
        internal static CloseWindow glfwCloseWindow;
        internal delegate void SetWindowTitle([MarshalAs(UnmanagedType.LPStr)] string title);
        internal static SetWindowTitle glfwSetWindowTitle;
        internal delegate void GetWindowSize(out int width,out int height);
        internal static GetWindowSize glfwGetWindowSize;
        internal delegate void SetWindowSize(int width,int height);
        internal static SetWindowSize glfwSetWindowSize;
        internal delegate void SetWindowPos(int x,int y);
        internal static SetWindowPos glfwSetWindowPos;
        internal delegate void IconifyWindow();
        internal static IconifyWindow glfwIconifyWindow;
        internal delegate void RestoreWindow();
        internal static RestoreWindow glfwRestoreWindow;
        internal delegate void SwapBuffers();
        internal static SwapBuffers glfwSwapBuffers;
        internal delegate void SwapInterval(int interval);
        internal static SwapInterval glfwSwapInterval;
        internal delegate int GetWindowParam(int param);
        internal static GetWindowParam glfwGetWindowParam;

        internal delegate int GetVideoModes([MarshalAs(UnmanagedType.LPArray)] GlfwVidMode[] list,int maxcount);
        internal static GetVideoModes glfwGetVideoModes;
        internal delegate void GetDesktopMode(out GlfwVidMode mode);
        internal static GetDesktopMode glfwGetDesktopMode;

        internal delegate void PollEvents();
        internal static PollEvents glfwPollEvents;
        internal delegate void WaitEvents();
        internal static WaitEvents glfwWaitEvents;
        internal delegate int GetKey(int key);
        internal static GetKey glfwGetKey;
        internal delegate int GetMouseButton(int button);
        internal static GetMouseButton glfwGetMouseButton;
        internal delegate void GetMousePos(out int xpos,out int ypos);
        internal static GetMousePos glfwGetMousePos;
        internal delegate void SetMousePos(int xpos,int ypos);
        internal static SetMousePos glfwSetMousePos;
        internal delegate int GetMouseWheel();
        internal static GetMouseWheel glfwGetMouseWheel;
        internal delegate void SetMouseWheel(int pos);
        internal static SetMouseWheel glfwSetMouseWheel;

        internal delegate int GetJoystickParam(int joy,int param);
        internal static GetJoystickParam glfwGetJoystickParam;
        internal delegate int GetJoystickPos(int joy,[MarshalAs(UnmanagedType.LPArray)] float[] pos,int numaxes);
        internal static GetJoystickPos glfwGetJoystickPos;
        internal delegate int GetJoystickButtons(int joy,[MarshalAs(UnmanagedType.LPArray)] byte[] buttons,int numbuttons);
        internal static GetJoystickButtons glfwGetJoystickButtons;

        internal delegate double GetTime();
        internal static GetTime glfwGetTime;
        internal delegate void SetTime(double time);
        internal static SetTime glfwSetTime;
        internal delegate void Sleep(double time);
        internal static Sleep glfwSleep;

        internal delegate int ExtensionSupported([MarshalAs(UnmanagedType.LPStr)] string extension);
        internal static ExtensionSupported glfwExtensionSupported;
        internal delegate IntPtr GetProcAddress([MarshalAs(UnmanagedType.LPStr)] string procname);
        internal static GetProcAddress glfwGetProcAddress;
        internal delegate void GetGLVersion(out int major,out int minor,out int rev);
        internal static GetGLVersion glfwGetGLVersion;

        internal delegate int GetNumberOfProcessors();
        internal static GetNumberOfProcessors glfwGetNumberOfProcessors;

        internal delegate void Enable(int token);
        internal static Enable glfwEnable;
        internal delegate void Disable(int token);
        internal static Disable glfwDisable;

        internal delegate int ReadImage([MarshalAs(UnmanagedType.LPStr)] string name,out GlfwImage img,int flags);
        internal static ReadImage glfwReadImage;
        internal delegate int ReadMemoryImage(IntPtr data,long size,ref GlfwImage img,int flags);
        internal static ReadMemoryImage glfwReadMemoryImage;
        internal delegate void FreeImage(ref GlfwImage img);
        internal static FreeImage glfwFreeImage;
        internal delegate int LoadTexture2D([MarshalAs(UnmanagedType.LPStr)] string name,int flags);
        internal static LoadTexture2D glfwLoadTexture2D;
        internal delegate int LoadMemoryTexture2D(IntPtr data,long size,int flags);
        internal static LoadMemoryTexture2D glfwLoadMemoryTexture2D;
        internal delegate int LoadTextureImage2D(ref GlfwImage img,int flags);
        internal static LoadTextureImage2D glfwLoadTextureImage2D;
    }
}

