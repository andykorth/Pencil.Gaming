using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    internal static class Al64 {
        [DllImport("openal64")]
        internal static extern void alEnable(int capability);
        [DllImport("openal64")]
        internal static extern void alDisable(int capability); 
        [DllImport("openal64")]
        internal static extern bool alIsEnabled(int capability); 
        [DllImport("openal64")]
        internal static extern unsafe sbyte *alGetString(int param);
        [DllImport("openal64")]
        internal static extern void alGetBooleanv(int param, [MarshalAs(UnmanagedType.LPArray)] bool[] data);
        [DllImport("openal64")]
        internal static extern void alGetIntegerv(int param, [MarshalAs(UnmanagedType.LPArray)] int[] data);
        [DllImport("openal64")]
        internal static extern void alGetFloatv(int param, [MarshalAs(UnmanagedType.LPArray)] float[] data);
        [DllImport("openal64")]
        internal static extern void alGetDoublev(int param, [MarshalAs(UnmanagedType.LPArray)] double[] data);
        [DllImport("openal64")]
        internal static extern bool alGetBoolean(int param);
        [DllImport("openal64")]
        internal static extern int alGetInteger(int param);
        [DllImport("openal64")]
        internal static extern float alGetFloat(int param);
        [DllImport("openal64")]
        internal static extern double alGetDouble(int param);
        [DllImport("openal64")]
        internal static extern int alGetError();
        [DllImport("openal64")]
        internal static extern bool alIsExtensionPresent([MarshalAs(UnmanagedType.LPStr)] string extname);
        [DllImport("openal64")]
        internal static extern IntPtr alGetProcAddress([MarshalAs(UnmanagedType.LPStr)] string fname);
        [DllImport("openal64")]
        internal static extern int alGetEnumValue([MarshalAs(UnmanagedType.LPStr)] string ename);
        [DllImport("openal64")]
        internal static extern void alListenerf(int param, float @value);
        [DllImport("openal64")]
        internal static extern void alListener3f(int param, float value1, float value2, float value3);
        [DllImport("openal64")]
        internal static extern void alListenerfv(int param, [MarshalAs(UnmanagedType.LPArray)] float[] values); 
        [DllImport("openal64")]
        internal static extern void alListeneri(int param, int @value);
        [DllImport("openal64")]
        internal static extern void alListener3i(int param, int value1, int value2, int value3);
        [DllImport("openal64")]
        internal static extern void alListeneriv(int param, [MarshalAs(UnmanagedType.LPArray)] int[] values);
        [DllImport("openal64")]
        internal static extern void alGetListenerf(int param, [MarshalAs(UnmanagedType.LPArray)] float[] @value);
        [DllImport("openal64")]
        internal static extern void alGetListener3f(int param, [MarshalAs(UnmanagedType.LPArray)] float[]value1, [MarshalAs(UnmanagedType.LPArray)] float[]value2, [MarshalAs(UnmanagedType.LPArray)] float[]value3);
        [DllImport("openal64")]
        internal static extern void alGetListenerfv(int param, [MarshalAs(UnmanagedType.LPArray)] float[] values);
        [DllImport("openal64")]
        internal static extern void alGetListeneri(int param, [MarshalAs(UnmanagedType.LPArray)] int[] @value);
        [DllImport("openal64")]
        internal static extern void alGetListener3i(int param, [MarshalAs(UnmanagedType.LPArray)] int[]value1, [MarshalAs(UnmanagedType.LPArray)] int[]value2, [MarshalAs(UnmanagedType.LPArray)] int[]value3);
        [DllImport("openal64")]
        internal static extern void alGetListeneriv(int param, [MarshalAs(UnmanagedType.LPArray)] int[] values);
        [DllImport("openal64")]
        internal static extern void alGenSources(int n, [MarshalAs(UnmanagedType.LPArray)] uint[] sources); 
        [DllImport("openal64")]
        internal static extern void alDeleteSources(int n, [MarshalAs(UnmanagedType.LPArray)] uint[] sources);
        [DllImport("openal64")]
        internal static extern bool alIsSource(uint sid); 
        [DllImport("openal64")]
        internal static extern void alSourcef(uint sid, int param, float @value); 
        [DllImport("openal64")]
        internal static extern void alSource3f(uint sid, int param, float value1, float value2, float value3);
        [DllImport("openal64")]
        internal static extern void alSourcefv(uint sid, int param, [MarshalAs(UnmanagedType.LPArray)] float[] values); 
        [DllImport("openal64")]
        internal static extern void alSourcei(uint sid, int param, int @value); 
        [DllImport("openal64")]
        internal static extern void alSource3i(uint sid, int param, int value1, int value2, int value3);
        [DllImport("openal64")]
        internal static extern void alSourceiv(uint sid, int param, [MarshalAs(UnmanagedType.LPArray)] int[] values);
        [DllImport("openal64")]
        internal static extern void alGetSourcef(uint sid, int param, [MarshalAs(UnmanagedType.LPArray)] float[] @value);
        [DllImport("openal64")]
        internal static extern void alGetSource3f(uint sid, int param, [MarshalAs(UnmanagedType.LPArray)] float[] value1, [MarshalAs(UnmanagedType.LPArray)] float[] value2, [MarshalAs(UnmanagedType.LPArray)] float[] value3);
        [DllImport("openal64")]
        internal static extern void alGetSourcefv(uint sid, int param, [MarshalAs(UnmanagedType.LPArray)] float[] values);
        [DllImport("openal64")]
        internal static extern void alGetSourcei(uint sid, int param, [MarshalAs(UnmanagedType.LPArray)] int[] @value);
        [DllImport("openal64")]
        internal static extern void alGetSource3i(uint sid, int param, [MarshalAs(UnmanagedType.LPArray)] int[] value1, [MarshalAs(UnmanagedType.LPArray)] int[] value2, [MarshalAs(UnmanagedType.LPArray)] int[] value3);
        [DllImport("openal64")]
        internal static extern void alGetSourceiv(uint sid, int param, [MarshalAs(UnmanagedType.LPArray)] int[] values);
        [DllImport("openal64")]
        internal static extern void alSourcePlayv(int ns, [MarshalAs(UnmanagedType.LPArray)] uint[]sids);
        [DllImport("openal64")]
        internal static extern void alSourceStopv(int ns, [MarshalAs(UnmanagedType.LPArray)] uint[]sids);
        [DllImport("openal64")]
        internal static extern void alSourceRewindv(int ns, [MarshalAs(UnmanagedType.LPArray)] uint[]sids);
        [DllImport("openal64")]
        internal static extern void alSourcePausev(int ns, [MarshalAs(UnmanagedType.LPArray)] uint[]sids);
        [DllImport("openal64")]
        internal static extern void alSourcePlay(uint sid);
        [DllImport("openal64")]
        internal static extern void alSourceStop(uint sid);
        [DllImport("openal64")]
        internal static extern void alSourceRewind(uint sid);
        [DllImport("openal64")]
        internal static extern void alSourcePause(uint sid);
        [DllImport("openal64")]
        internal static extern void alSourceQueueBuffers(uint sid, int numEntries, [MarshalAs(UnmanagedType.LPArray)] uint[]bids);
        [DllImport("openal64")]
        internal static extern void alSourceUnqueueBuffers(uint sid, int numEntries, [MarshalAs(UnmanagedType.LPArray)] uint[]bids);
        [DllImport("openal64")]
        internal static extern void alGenBuffers(int n, [MarshalAs(UnmanagedType.LPArray)] uint[] buffers);
        [DllImport("openal64")]
        internal static extern void alDeleteBuffers(int n, [MarshalAs(UnmanagedType.LPArray)] uint[] buffers);
        [DllImport("openal64")]
        internal static extern bool alIsBuffer(uint bid);
        [DllImport("openal64")]
        internal static extern void alBufferData(uint bid, int format, IntPtr data, int size, int freq);
        [DllImport("openal64")]
        internal static extern void alBufferf(uint bid, int param, float @value);
        [DllImport("openal64")]
        internal static extern void alBuffer3f(uint bid, int param, float value1, float value2, float value3);
        [DllImport("openal64")]
        internal static extern void alBufferfv(uint bid, int param, [MarshalAs(UnmanagedType.LPArray)] float[] values);
        [DllImport("openal64")]
        internal static extern void alBufferi(uint bid, int param, int @value);
        [DllImport("openal64")]
        internal static extern void alBuffer3i(uint bid, int param, int value1, int value2, int value3);
        [DllImport("openal64")]
        internal static extern void alBufferiv(uint bid, int param, [MarshalAs(UnmanagedType.LPArray)] int[] values);
        [DllImport("openal64")]
        internal static extern void alGetBufferf(uint bid, int param, [MarshalAs(UnmanagedType.LPArray)] float[] @value);
        [DllImport("openal64")]
        internal static extern void alGetBuffer3f(uint bid, int param, [MarshalAs(UnmanagedType.LPArray)] float[] value1, [MarshalAs(UnmanagedType.LPArray)] float[] value2, [MarshalAs(UnmanagedType.LPArray)] float[] value3);
        [DllImport("openal64")]
        internal static extern void alGetBufferfv(uint bid, int param, [MarshalAs(UnmanagedType.LPArray)] float[] values);
        [DllImport("openal64")]
        internal static extern void alGetBufferi(uint bid, int param, [MarshalAs(UnmanagedType.LPArray)] int[] @value);
        [DllImport("openal64")]
        internal static extern void alGetBuffer3i(uint bid, int param, [MarshalAs(UnmanagedType.LPArray)] int[] value1, [MarshalAs(UnmanagedType.LPArray)] int[] value2, [MarshalAs(UnmanagedType.LPArray)] int[] value3);
        [DllImport("openal64")]
        internal static extern void alGetBufferiv(uint bid, int param, [MarshalAs(UnmanagedType.LPArray)] int[] values);
        [DllImport("openal64")]
        internal static extern void alDopplerFactor(float @value);
        [DllImport("openal64")]
        internal static extern void alDopplerVelocity(float @value);
        [DllImport("openal64")]
        internal static extern void alSpeedOfSound(float @value);
        [DllImport("openal64")]
        internal static extern void alDistanceModel(int distanceModel);
    }
}

