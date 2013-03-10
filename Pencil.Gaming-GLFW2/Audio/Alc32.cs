// License: ../LICENSE.TXT

using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming.Audio {
    internal static class Alc32 {
        private const string lib = "natives32/openal32.dll";

        [DllImport(Alc32.lib)]
        internal static extern bool alcCloseDevice(IntPtr device);
        [DllImport(Alc32.lib)]
        internal static extern IntPtr alcOpenDevice([MarshalAs(UnmanagedType.LPStr)] string devicename);
        [DllImport(Alc32.lib)]
        internal static extern bool alcIsExtensionPresent(IntPtr device, [MarshalAs(UnmanagedType.LPStr)] string extname);
        [DllImport(Alc32.lib)]
        internal static extern void alcGetIntegerv(IntPtr device, int param, int size, [MarshalAs(UnmanagedType.LPArray)] int[] data);
        [DllImport(Alc32.lib)]
        internal static extern IntPtr alcCreateContext(IntPtr device, [MarshalAs(UnmanagedType.LPArray)] int[] attrlist);
        [DllImport(Alc32.lib)]
        internal static extern bool alcMakeContextCurrent(IntPtr context);
    }
}

