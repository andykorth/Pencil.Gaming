using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace Pencil.Gaming.Audio {
    internal sealed class AlcManager {
        private static IntPtr alcDeviceHandle;
        private static IntPtr alcContextHandle;

        private delegate bool CloseDevice(IntPtr hndl);
        private delegate IntPtr OpenDevice(string str);
        private delegate bool IsExtensionPresent(IntPtr hndl,string extnsn);
        private delegate void GetIntegerv(IntPtr hndl,int @int,int count,int[] @out);
        private delegate IntPtr CreateContext(IntPtr hndl,int[] attribs);
        private delegate bool MakeContextCurrent(IntPtr hndl);

        public AlcManager() {
#if DEBUG
            Stopwatch sw = new Stopwatch();
            sw.Start();
#endif
            CloseDevice alcCloseDevice = null;
            OpenDevice alcOpenDevice = null;
            IsExtensionPresent alcIsExtensionPresent = null;
            GetIntegerv alcGetIntegerv = null;
            CreateContext alcCreateContext = null;
            MakeContextCurrent alcMakeContextCurrent = null;

            if (IntPtr.Size == 8) {
                alcCloseDevice = Alc64.alcCloseDevice;
                alcOpenDevice = Alc64.alcOpenDevice;
                alcIsExtensionPresent = Alc64.alcIsExtensionPresent;
                alcGetIntegerv = Alc64.alcGetIntegerv;
                alcCreateContext = Alc64.alcCreateContext;
                alcMakeContextCurrent = Alc64.alcMakeContextCurrent;
            } else {
                alcCloseDevice = Alc32.alcCloseDevice;
                alcOpenDevice = Alc32.alcOpenDevice;
                alcIsExtensionPresent = Alc32.alcIsExtensionPresent;
                alcGetIntegerv = Alc32.alcGetIntegerv;
                alcCreateContext = Alc32.alcCreateContext;
                alcMakeContextCurrent = Alc32.alcMakeContextCurrent;
            }

            alcDeviceHandle = alcOpenDevice(null);
            if (alcDeviceHandle == IntPtr.Zero) {
                // TODO: Named devices
                throw new Exception("Could not find audio device.");
            }

            List<int> attributes = new List<int> { 4105, 0, };
            if (alcIsExtensionPresent(alcDeviceHandle, "ALC_EXT_EFX")) {
                int[] alcInteger = new int[1];
                alcGetIntegerv(alcDeviceHandle, 131065, 1, alcInteger);
                attributes.Add(131065);
                attributes.Add(alcInteger[0]);
            }
            attributes.Add(0);

            alcContextHandle = alcCreateContext(alcDeviceHandle, attributes.ToArray());

            if (alcContextHandle == IntPtr.Zero) {
                alcCloseDevice(alcDeviceHandle);
                throw new Exception("Failed to create ALC context.");
            }

            alcMakeContextCurrent(alcContextHandle);

#if DEBUG
            sw.Stop();
            Console.WriteLine("Initializing ALC took {0} milliseconds.", sw.ElapsedMilliseconds);
#endif
        }

        ~AlcManager() {
            if (IntPtr.Size == 8) {
                Alc64.alcCloseDevice(alcDeviceHandle);
            } else {
                Alc32.alcCloseDevice(alcDeviceHandle);
            }
        }
    }
}

