using System;
using System.IO;
using Pencil.Gaming.Audio;

namespace Pencil.Gaming.Audio {
    public class Sound : IDisposable {
        protected uint BufferHandle;
        protected uint SourceHandle;
        private float lengthSeconds;

        public Sound(string file) {
            Load(File.ReadAllBytes(file));
        }

        public Sound(Stream file) {
            using (MemoryStream ms = new MemoryStream()) {
                if (!file.CanRead) {
                    throw new NotSupportedException("This stream does not support reading");
                }
                byte[] buffer = new byte[16 * 1024];
                int nread;
                while ((nread = file.Read(buffer, 0, 16 * 1024)) != 0) {
                    ms.Write(buffer, 0, nread);
                }

                Load(ms.ToArray());
            }
        }

        private unsafe void Load(byte[] wave) {
            Al.GenBuffers(1, out BufferHandle);

            byte[] data;
            AlFormat format;
            uint chunkSize, sampleRate, avgBytesPerSec;
            short bytesPerSample, bitsPerSample;
            Al.Utils.LoadWavExt(wave, out data, out chunkSize, out format, out sampleRate, out avgBytesPerSec, out bytesPerSample, out bitsPerSample);

            lengthSeconds = data.Length / (float)avgBytesPerSec;

            fixed (byte * dataPtr = &data[0]) {
                IntPtr dataIntPtr = new IntPtr(dataPtr);
                Al.BufferData(BufferHandle, format, dataIntPtr, data.Length, (int)sampleRate);
            }

            Al.GenSources(1, out SourceHandle);
            Al.Source(SourceHandle, AlSourcei.Buffer, (int)BufferHandle);
            Al.Source(SourceHandle, AlSourceb.Looping, false);
        }

        public void Play() {
            Al.SourcePlay(SourceHandle);
        }

        public void Stop() {
            Al.SourceStop(SourceHandle);
        }

        public void Pause() {
            Al.SourcePause(SourceHandle);
        }

        public void Dispose() {
            Al.DeleteBuffers(1, ref BufferHandle);
            Al.DeleteSources(1, ref SourceHandle);
        }

        public TimeSpan Length {
            get {
                return new TimeSpan(0, 0, 0, (int)lengthSeconds);
            }
        }
        public bool Looping { 
            get {
                bool result;
                Al.GetSource(SourceHandle, AlSourceb.Looping, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourceb.Looping, value);
            }
        }
    }
}
