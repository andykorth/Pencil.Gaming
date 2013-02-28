using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Pencil.Gaming.Graphics;

namespace Pencil.Gaming {
    public static partial class Glfw {
        public static class Utils {
            internal static bool isFullscreen;
            internal static int widthBackup;
            internal static int heightBackup;
            internal static int redBitsBackup;
            internal static int greenBitsBackup;
            internal static int blueBitsBackup;
            internal static int alphaBitsBackup;
            internal static int depthBitsBackup;
            internal static int stencilBitsBackup;
            private static int prevWndWidth = -1;
            private static int prevWndHeight = -1;

            public delegate void Resize(int width,int height);

            // TODO: Add proper implementation through events
            public static bool HasWindowSizeChanged(out int width, out int height) {
                Glfw.GetWindowSize(out width, out height);
                bool result = (width != prevWndWidth || height != prevWndHeight);
                prevWndWidth = width;
                prevWndHeight = height;
                return result;
            }

            // TODO: Add PROPER implementation through events
            public static void RunIfWindowSizeChanged(Resize rsEvent) {
                int width, height;
                if (HasWindowSizeChanged(out width, out height)) {
                    rsEvent(width, height);
                }
            }

            public static void LoadGLFunctions() {
                FieldInfo[] fields = typeof(Gl.Delegates).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                bool isWindows = (Environment.OSVersion.Platform != PlatformID.Unix && Environment.OSVersion.Platform != PlatformID.MacOSX);
                foreach (FieldInfo field in fields) {
                    IntPtr procAddress = Glfw.GetProcAddress(field.Name);
                    if (procAddress != IntPtr.Zero) {
                        Delegate function = Marshal.GetDelegateForFunctionPointer(procAddress, field.FieldType);
                        field.SetValue(null, function);
                    } else {
                        // This is necessary for windows
                        // wglGetProcAddress doesn't load core functions
                        MethodInfo minfo = typeof(GlCore).GetMethod(field.Name, BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                        if (minfo != null) {
                            Delegate function = Delegate.CreateDelegate(field.FieldType, minfo);
                            field.SetValue(null, function);
                        }
                    }
                }
            }

            public static void ToggleFullscreen() {
                SetFullscreenState(!isFullscreen);
            }

            public static void SetFullscreenState(bool state) {
                Glfw.CloseWindow();
                isFullscreen = state;
                if (state) {
                    GlfwVidMode desktop; 
                    Glfw.GetDesktopMode(out desktop);
                    Glfw.OpenWindow(
                        desktop.Width, 
                        desktop.Height, 
                        redBitsBackup, 
                        greenBitsBackup, 
                        blueBitsBackup, 
                        alphaBitsBackup, 
                        depthBitsBackup, 
                        stencilBitsBackup,
                        WindowMode.FullScreen
                    );
                } else {
                    Glfw.OpenWindow(
                        widthBackup, 
                        heightBackup, 
                        redBitsBackup, 
                        greenBitsBackup, 
                        blueBitsBackup, 
                        alphaBitsBackup, 
                        depthBitsBackup, 
                        stencilBitsBackup, 
                        WindowMode.Window
                    );
                }
            }
        }
    }
}

