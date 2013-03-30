using System;
using System.IO;
using Pencil.Gaming.Audio;
using Pencil.Gaming.MathUtils;

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
        public Vector3 Direction {
            get {
                Vector3 result = new Vector3();
                Al.GetSource(SourceHandle, AlSource3f.Direction, out result.X, out result.Y, out result.Z);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSource3f.Direction, value.X, value.Y, value.Z);
            }
        }
        public Vector3 Position {
            get {
                Vector3 result = new Vector3();
                Al.GetSource(SourceHandle, AlSource3f.Position, out result.X, out result.Y, out result.Z);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSource3f.Position, value.X, value.Y, value.Z);
            }
        }
        public Vector3 Velocity {
            get {
                Vector3 result = new Vector3();
                Al.GetSource(SourceHandle, AlSource3f.Velocity, out result.X, out result.Y, out result.Z);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSource3f.Velocity, value.X, value.Y, value.Z);
            }
        }
        public Vector3i EfxAuxiliarySendFilter {
            get {
                Vector3i result = new Vector3i();
                Al.GetSource(SourceHandle, AlSource3i.EfxAuxiliarySendFilter, out result.X, out result.Y, out result.Z);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSource3i.EfxAuxiliarySendFilter, value.X, value.Y, value.Z);
            }
        }
        public bool EfxAuxiliarySendFilterGainAuto {
            get {
                bool result;
                Al.GetSource(SourceHandle, AlSourceb.EfxAuxiliarySendFilterGainAuto, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourceb.EfxAuxiliarySendFilterGainAuto, value);
            }
        }
        public bool EfxAuxiliarySendFilterGainHighFrequencyAuto {
            get {
                bool result;
                Al.GetSource(SourceHandle, AlSourceb.EfxAuxiliarySendFilterGainAuto, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourceb.EfxAuxiliarySendFilterGainAuto, value);
            }
        }
        public bool EfxDirectFilterGainHighFrequencyAuto {
            get {
                bool result;
                Al.GetSource(SourceHandle, AlSourceb.EfxDirectFilterGainHighFrequencyAuto, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourceb.EfxDirectFilterGainHighFrequencyAuto, value);
            }
        }
        public bool SourceRelative {
            get {
                bool result;
                Al.GetSource(SourceHandle, AlSourceb.SourceRelative, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourceb.SourceRelative, value);
            }
        }
        public float ConeInnerAngle {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.ConeInnerAngle, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.ConeInnerAngle, value);
            }
        }
        public float ConeOuterAngle {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.ConeOuterAngle, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.ConeOuterAngle, value);
            }
        }
        public float ConeOuterGain {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.ConeOuterGain, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.ConeOuterGain, value);
            }
        }
        public float EfxAirAbsorptionFactor {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.EfxAirAbsorptionFactor, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.EfxAirAbsorptionFactor, value);
            }
        }
        public float EfxConeOuterGainHighFrequency {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.EfxConeOuterGainHighFrequency, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.EfxConeOuterGainHighFrequency, value);
            }
        }
        public float EfxRoomRolloffFactor {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.EfxRoomRolloffFactor, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.EfxRoomRolloffFactor, value);
            }
        }
        public float Gain {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.Gain, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.Gain, value);
            }
        }
        public float MaxDistance {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.MaxDistance, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.MaxDistance, value);
            }
        }
        public float MaxGain {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.MaxGain, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.MaxGain, value);
            }
        }
        public float MinGain {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.MinGain, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.MinGain, value);
            }
        }
        public float Pitch {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.Pitch, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.Pitch, value);
            }
        }
        public float ReferenceDistance {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.ReferenceDistance, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.ReferenceDistance, value);
            }
        }
        public float RolloffFactor {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.RolloffFactor, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.RolloffFactor, value);
            }
        }
        public float SecOffset {
            get {
                float result;
                Al.GetSource(SourceHandle, AlSourcef.SecOffset, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcef.SecOffset, value);
            }
        }
        public int Buffer {
            get {
                int result;
                Al.GetSource(SourceHandle, AlSourcei.Buffer, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcei.Buffer, value);
            }
        }
        public int ByteOffset {
            get {
                int result;
                Al.GetSource(SourceHandle, AlSourcei.ByteOffset, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcei.ByteOffset, value);
            }
        }
        public int EfxDirectFilter {
            get {
                int result;
                Al.GetSource(SourceHandle, AlSourcei.EfxDirectFilter, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcei.EfxDirectFilter, value);
            }
        }
        public int SampleOffset {
            get {
                int result;
                Al.GetSource(SourceHandle, AlSourcei.SampleOffset, out result);
                return result;
            }
            set {
                Al.Source(SourceHandle, AlSourcei.SampleOffset, value);
            }
        }
        public AlSourceType SourceType {
            get {
                int result;
                Al.GetSource(SourceHandle, AlSourcei.SourceType, out result);
                return (AlSourceType)result;
            }
            set {
                Al.Source(SourceHandle, AlSourcei.SourceType, (int)value);
            }
        }
    }
}
