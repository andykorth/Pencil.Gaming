// License: ../LICENSE.TXT

using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming.Audio {
    internal static class Alc32 {
        private const string lib = "natives32/openal32.dll";

        [DllImport(Alc32.lib)]
        internal static extern /*ALCcontext **/ IntPtr alcCreateContext(/*ref ALCdevice*/IntPtr device, [MarshalAs(UnmanagedType.LPArray)] int[] attrlist);
        [DllImport(Alc32.lib)]
        internal static extern bool alcMakeContextCurrent(/*ref ALCcontext*/IntPtr context);
        [DllImport(Alc32.lib)]
        internal static extern void alcProcessContext(/*ref ALCcontext*/IntPtr context);
        [DllImport(Alc32.lib)]
        internal static extern void alcSuspendContext(/*ref ALCcontext*/IntPtr context);
        [DllImport(Alc32.lib)]
        internal static extern void alcDestroyContext(/*ref ALCcontext*/IntPtr context);
        [DllImport(Alc32.lib)]
        internal static extern /*ALCcontext **/ IntPtr alcGetCurrentContext();
        [DllImport(Alc32.lib)]
        internal static extern /*ALCdevice **/ IntPtr alcGetContextsDevice(/*ref ALCcontext*/IntPtr context);
        [DllImport(Alc32.lib)]
        internal static extern /*ALCdevice **/ IntPtr alcOpenDevice([MarshalAs(UnmanagedType.LPStr)] string devicename);
        [DllImport(Alc32.lib)]
        internal static extern bool alcCloseDevice(/*ref ALCdevice*/IntPtr device);
        [DllImport(Alc32.lib)]
        internal static extern int alcGetError(/*ref ALCdevice*/IntPtr device);
        [DllImport(Alc32.lib)]
        internal static extern bool alcIsExtensionPresent(/*ref ALCdevice*/IntPtr device, [MarshalAs(UnmanagedType.LPStr)] string extname);
        [DllImport(Alc32.lib)]
        internal static extern IntPtr alcGetProcAddress(/*ref ALCdevice*/IntPtr device, [MarshalAs(UnmanagedType.LPStr)] string funcname);
        [DllImport(Alc32.lib)]
        internal static extern int alcGetEnumValue(/*ref ALCdevice*/IntPtr device, [MarshalAs(UnmanagedType.LPStr)] string enumname);
        [DllImport(Alc32.lib)]
        internal static extern string alcGetString(/*ref ALCdevice*/IntPtr device, int param);
        [DllImport(Alc32.lib)]
        internal static extern void alcGetIntegerv(/*ref ALCdevice*/IntPtr device, int param, int size, [MarshalAs(UnmanagedType.LPArray)] int[] data);
        [DllImport(Alc32.lib)]
        internal static extern /*ALCdevice **/ IntPtr alcCaptureOpenDevice([MarshalAs(UnmanagedType.LPStr)] string devicename, uint frequency, int format, int buffersize);
        [DllImport(Alc32.lib)]
        internal static extern bool alcCaptureCloseDevice(/*ref ALCdevice*/IntPtr device);
        [DllImport(Alc32.lib)]
        internal static extern void alcCaptureStart(/*ref ALCdevice*/IntPtr device);
        [DllImport(Alc32.lib)]
        internal static extern void alcCaptureStop(/*ref ALCdevice*/IntPtr device);
        [DllImport(Alc32.lib)]
        internal static extern void alcCaptureSamples(/*ref ALCdevice*/IntPtr device, IntPtr buffer, int samples);
    }
}

