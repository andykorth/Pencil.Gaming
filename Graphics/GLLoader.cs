using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Pencil.Gaming.Graphics {
    internal static class GLLoader {
        /*internal delegate Delegate FunctionLoader(string name,Type @delegate);
        internal static FunctionLoader FunctionLoaderInstance;

        internal static Delegate DelegateFromIntPtr(IntPtr ptr, Type t) {
            if (ptr == IntPtr.Zero) {
                return null;
            }

            return Marshal.GetDelegateForFunctionPointer(ptr, t);
        }

        [DllImport("opengl32.dll")]
        internal static extern IntPtr wglGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string lpszProc);
        internal static Delegate LoadWindowsGlDelegate(string name, Type @delegate) {
            return DelegateFromIntPtr(wglGetProcAddress(name),  @delegate);
        }

        [DllImport("libGL.so.1")]
        internal static extern IntPtr glXGetProcAddress([MarshalAs(UnmanagedType.LPTStr)] string procName);
        internal static Delegate LoadXGlDelegate(string name, Type @delegate) {
            return DelegateFromIntPtr(glXGetProcAddress(name),  @delegate);
        }

        [DllImport("libdl.dylib", EntryPoint = "NSIsSymbolNameDefined")]
        private static extern bool NSIsSymbolNameDefined(string s);
        [DllImport("libdl.dylib", EntryPoint = "NSLookupAndBindSymbol")]
        private static extern IntPtr NSLookupAndBindSymbol(string s);
        [DllImport("libdl.dylib", EntryPoint = "NSAddressOfSymbol")]
        private static extern IntPtr NSAddressOfSymbol(IntPtr symbol);
        internal static Delegate LoadAppleDelegate(string name, Type @delegate) {
            IntPtr function = IntPtr.Zero;

            string fname = "_" + name;
            if (NSIsSymbolNameDefined(fname)) {
                function = NSLookupAndBindSymbol(fname);
                if (function != IntPtr.Zero) {
                    function = NSAddressOfSymbol(function);
                }
            }

            return DelegateFromIntPtr(function,  @delegate);
        }*/

        internal static void LoadAll() {
            /*switch (Environment.OSVersion.Platform) {
            case PlatformID.Win32S:
            case PlatformID.Win32Windows:
            case PlatformID.Win32NT:
                FunctionLoaderInstance = LoadWindowsGlDelegate;
                break;
            case PlatformID.Unix:
                FunctionLoaderInstance = LoadXGlDelegate;
                break;
            case PlatformID.MacOSX:
                FunctionLoaderInstance = LoadAppleDelegate;
                break;
            default:
                throw new PlatformNotSupportedException("The platform you are using is outdated or not supported by the Pencil gaming library.");
            }*/

            FieldInfo[] fields = typeof(GL.Delegates).GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
            foreach (FieldInfo field in fields) {
                //Delegate function = FunctionLoaderInstance(field.Name, field.FieldType);
                IntPtr procAddress = Glfw.GetProcAddress(field.Name);
                if (procAddress != IntPtr.Zero) {
                    Delegate function = Marshal.GetDelegateForFunctionPointer(procAddress, field.FieldType);
                    field.SetValue(null, function);
                }
            }
        }
    }
}

