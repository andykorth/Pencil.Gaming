using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Pencil.Gaming.Audio {
    public static partial class Al {
        public static class Utils {
            public abstract class Sound : IDisposable {
                public abstract void Play();
                public abstract void Pause();
                public abstract void Stop();
                public abstract void Dispose();
            }

            public sealed class SimpleSound : Sound {
                public static unsafe void LoadWav(
                    string file, 
                    out byte[] data,
                    out uint size, 
                    out uint chunkSize,
                    out AlFormat format,
                    out uint sampleRate,
                    out uint avgBytesPerSec,
                    out short bytesPerSample,
                    out short bitsPerSample,
                    out int dataSize) {

                    byte[] sound = File.ReadAllBytes("sound.wav");

                    short channels;

                    int ptrOffset = 4;
                    if (sound[0] != 'R' || sound[1] != 'I' || sound[2] != 'F' || sound[3] != 'F') {
                        throw new Exception("Invalid file format.");
                    }
                    size = ((uint)sound[3 + ptrOffset] << 24) | ((uint)sound[2 + ptrOffset] << 16) | ((uint)sound[1 + ptrOffset] << 8) | ((uint)sound[ptrOffset]);
                    if (sound[8] != 'W' || sound[9] != 'A' || sound[10] != 'V' || sound[11] != 'E') {
                        throw new Exception("Invalid file format.");
                    }
                    if (sound[12] != 'f' || sound[13] != 'm' || sound[14] != 't' || sound[15] != ' ') {
                        throw new Exception("Invalid file format.");
                    }
                    ptrOffset = 16;
                    chunkSize = ((uint)sound[3 + ptrOffset] << 24) | ((uint)sound[2 + ptrOffset] << 16) | ((uint)sound[1 + ptrOffset] << 8) | ((uint)sound[ptrOffset]);
                    //ptrOffset = 20;
                    //formatType = ((short)(((short)sound[1 + ptrOffset] << 8) | ((short)sound[0 + ptrOffset])));
                    ptrOffset = 22;
                    channels = (short)(((short)sound[1 + ptrOffset] << 8) | ((short)sound[0 + ptrOffset]));
                    ptrOffset = 24;
                    sampleRate = ((uint)sound[3 + ptrOffset] << 24) | ((uint)sound[2 + ptrOffset] << 16) | ((uint)sound[1 + ptrOffset] << 8) | ((uint)sound[ptrOffset]);
                    ptrOffset = 28;
                    avgBytesPerSec = ((uint)sound[3 + ptrOffset] << 24) | ((uint)sound[2 + ptrOffset] << 16) | ((uint)sound[1 + ptrOffset] << 8) | ((uint)sound[ptrOffset]);
                    ptrOffset = 32;
                    bytesPerSample = (short)(((short)sound[1 + ptrOffset] << 8) | ((short)sound[0 + ptrOffset]));
                    ptrOffset = 34;
                    bitsPerSample = (short)(((short)sound[1 + ptrOffset] << 8) | ((short)sound[0 + ptrOffset]));
                    if (sound[36] != 'd' || sound[37] != 'a' || sound[38] != 't' || sound[39] != 'a') {
                        throw new Exception("Invalid file format.");
                    }
                    ptrOffset = 40;
                    dataSize = ((int)sound[3 + ptrOffset] << 24) | ((int)sound[2 + ptrOffset] << 16) | ((int)sound[1 + ptrOffset] << 8) | ((int)sound[ptrOffset]);

                    format = (AlFormat)0;
                    if (bitsPerSample == 8) {
                        if (channels == 1)
                            format = AlFormat.Mono8;
                        else if (channels == 2)
                            format = AlFormat.Stereo8;
                    } else if (bitsPerSample == 16) {
                        if (channels == 1)
                            format = AlFormat.Mono16;
                        else if (channels == 2)
                            format = AlFormat.Stereo16;
                    }

                    data = new byte[dataSize];
                    Array.Copy(sound, 44, data, 0, dataSize);
                }

                private uint source = 0;
                private uint buffer = 0;

                public SimpleSound(IntPtr data, int dataSize, AlFormat format, int frequency, bool looping) {
                    uint[] dummy = new uint[1];
                    Al.GenBuffers(1, dummy);
                    buffer = dummy[0];
                    Al.GenSources(1, dummy);
                    source = dummy[0];

                    Al.BufferData(buffer, format, data, dataSize, frequency);
                    Al.Source(source, AlSourcei.Buffer, (int)buffer);
                    Al.Source(source, AlSourceb.Looping, looping);
                }

                public override void Play() {
                    Al.SourcePlay(source);
                }
                public override void Pause() {
                    Al.SourcePause(source);
                }
                public override void Stop() {
                    Al.SourceStop(source);
                }

                public override void Dispose() {
                    Al.DeleteBuffers(1, ref buffer);
                    Al.DeleteSources(1, ref source);
                }
            }
        }
    }
}

