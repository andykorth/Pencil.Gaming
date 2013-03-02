using System;
using System.Diagnostics;
using System.IO;

namespace Pencil.Gaming.Audio {
    public static partial class Al {
        public static class Utils {
            public static void LoadWav(
                string file,
                out byte[] data,
                out AlFormat format,
                out uint sampleRate) {

                uint dummyui;
                short dummys;
                LoadWavExt(file, out data, out dummyui, out format, out sampleRate, out dummyui, out dummys, out dummys);
            }

            public static unsafe void LoadWavExt(
                    string file, 
                    out byte[] data,
                    out uint chunkSize,
                    out AlFormat format,
                    out uint sampleRate,
                    out uint avgBytesPerSec,
                    out short bytesPerSample,
                    out short bitsPerSample) {

#if DEBUG
                Stopwatch sw = new Stopwatch();
                sw.Start();
#endif

                byte[] sound = File.ReadAllBytes(file);

                short channels;

                int ptrOffset = 4;
                if (sound[0] != 'R' || sound[1] != 'I' || sound[2] != 'F' || sound[3] != 'F') {
                    throw new Exception("Invalid file format.");
                }
                //size = ((uint)sound[3 + ptrOffset] << 24) | ((uint)sound[2 + ptrOffset] << 16) | ((uint)sound[1 + ptrOffset] << 8) | ((uint)sound[ptrOffset]);
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
                int dataSize = ((int)sound[3 + ptrOffset] << 24) | ((int)sound[2 + ptrOffset] << 16) | ((int)sound[1 + ptrOffset] << 8) | ((int)sound[ptrOffset]);

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

#if DEBUG
                sw.Stop();
                Console.WriteLine("Loading audio file \"{0}\" took {1} milliseconds.", file, sw.ElapsedMilliseconds);
#endif
            }
        }
    }
}

