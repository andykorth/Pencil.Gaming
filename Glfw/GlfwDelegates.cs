using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    internal static class GlfwDelegates {
        static GlfwDelegates() {
#if DEBUG
            Stopwatch sw = new Stopwatch();
            sw.Start();
#endif
            Type glfwInterop = Environment.Is64BitProcess ? typeof(Glfw64) : typeof(Glfw32);
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

