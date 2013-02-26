using System;
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

            public static void LoadGLFunctions() {
                FieldInfo[] fields = typeof(Gl.Delegates).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
                foreach (FieldInfo field in fields) {
                    //Delegate function = FunctionLoaderInstance(field.Name, field.FieldType);
                    IntPtr procAddress = Glfw.GetProcAddress(field.Name);
                    if (procAddress != IntPtr.Zero) {
                        Delegate function = Marshal.GetDelegateForFunctionPointer(procAddress, field.FieldType);
                        field.SetValue(null, function);
                    }
                }
            }

            public static void ToggleFullscreen() {
                isFullscreen = !isFullscreen;
                SetFullscreenState(isFullscreen);
            }

            public static void SetFullscreenState(bool state) {
                Glfw.CloseWindow();
                WindowMode mode = state ? WindowMode.FullScreen : WindowMode.Window;
                Glfw.OpenWindow(
                        widthBackup, 
                        heightBackup, 
                        redBitsBackup, 
                        greenBitsBackup, 
                        blueBitsBackup, 
                        alphaBitsBackup, 
                        depthBitsBackup, 
                        stencilBitsBackup, 
                        mode
                );
            }
        }
    }
}

