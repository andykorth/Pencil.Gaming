// License: ../LICENSE.TXT

using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming.Audio {
    internal static class Alc64 {
        private const string lib = "natives64/openal32.dll";

        [DllImport(Alc64.lib)]
        internal static extern bool alcCloseDevice(IntPtr device);
        [DllImport(Alc64.lib)]
        internal static extern IntPtr alcOpenDevice([MarshalAs(UnmanagedType.LPStr)] string devicename);
        [DllImport(Alc64.lib)]
        internal static extern bool alcIsExtensionPresent(IntPtr device, [MarshalAs(UnmanagedType.LPStr)] string extname);
        [DllImport(Alc64.lib)]
        internal static extern void alcGetIntegerv(IntPtr device, int param, int size, [MarshalAs(UnmanagedType.LPArray)] int[] data);
        [DllImport(Alc64.lib)]
        internal static extern IntPtr alcCreateContext(IntPtr device, [MarshalAs(UnmanagedType.LPArray)] int[] attrlist);
        [DllImport(Alc64.lib)]
        internal static extern bool alcMakeContextCurrent(IntPtr context);
    }
}

