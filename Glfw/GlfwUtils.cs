// License: ../LICENSE.TXT

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
