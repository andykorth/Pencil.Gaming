using System;

namespace Pencil.Gaming {
    public static class Al {
        internal static void Enable(int capability) {
            AlDelegates.alEnable(capability);
        }
        internal static void Disable(int capability) {
            AlDelegates.alDisable(capability);
        } 
        internal static bool IsEnabled(int capability) {
            return AlDelegates.alIsEnabled(capability);
        } 
        internal static unsafe string GetString(int param) {
            sbyte * bptr = AlDelegates.alGetString(param);
            return new string(bptr);
        }
        internal static void GetBooleanv(int param, bool[] data) {
            AlDelegates.alGetBooleanv(param, data);
        }
        internal static void GetIntegerv(int param, int[] data) {
            AlDelegates.alGetIntegerv(param, data);
        }
        internal static void GetFloatv(int param, float[] data) {
            AlDelegates.alGetFloatv(param, data);
        }
        internal static void GetDoublev(int param, double[] data) {
            AlDelegates.alGetDoublev(param, data);
        }
        internal static bool GetBoolean(int param) {
            return AlDelegates.alGetBoolean(param);
        }
        internal static int GetInteger(int param) {
            return AlDelegates.alGetInteger(param);
        }
        internal static float GetFloat(int param) {
            return AlDelegates.alGetFloat(param);
        }
        internal static double GetDouble(int param) {
            return AlDelegates.alGetDouble(param);
        }
        internal static int GetError() {
            return AlDelegates.alGetError();
        }
        /*internal static bool IsExtensionPresent(string extname) {
        }
        internal static IntPtr GetProcAddress(string fname) {
        }
        internal static int GetEnumValue(string ename) {
        }
        internal static void Listenerf(int param, float @value) {
        }
        internal static void Listener3f(int param, float value1, float value2, float value3) {
        }
        internal static void Listenerfv(int param, float[] values) {
        } 
        internal static void Listeneri(int param, int @value) {
        }
        internal static void Listener3i(int param, int value1, int value2, int value3) {
        }
        internal static void Listeneriv(int param, int[] values) {
        }
        internal static void GetListenerf(int param, float[] @value) {
        }
        internal static void GetListener3f(int param, float[]value1, float[]value2, float[]value3) {
        }
        internal static void GetListenerfv(int param, float[] values) {
        }
        internal static void GetListeneri(int param, int[] @value) {
        }
        internal static void GetListener3i(int param, int[]value1, int[]value2, int[]value3) {
        }
        internal static void GetListeneriv(int param, int[] values) {
        }
        internal static void GenSources(int n, uint[] sources) {
        } 
        internal static void DeleteSources(int n, uint[] sources) {
        }
        internal static bool IsSource(uint sid) {
        } 
        internal static void Sourcef(uint sid, int param, float @value) {
        } 
        internal static void Source3f(uint sid, int param, float value1, float value2, float value3) {
        }
        internal static void Sourcefv(uint sid, int param, float[] values) {
        } 
        internal static void Sourcei(uint sid, int param, int @value) {
        } 
        internal static void Source3i(uint sid, int param, int value1, int value2, int value3) {
        }
        internal static void Sourceiv(uint sid, int param, int[] values) {
        }
        internal static void GetSourcef(uint sid, int param, float[] @value) {
        }
        internal static void GetSource3f(uint sid, int param, float[] value1, float[] value2, float[] value3) {
        }
        internal static void GetSourcefv(uint sid, int param, float[] values) {
        }
        internal static void GetSourcei(uint sid, int param, int[] @value) {
        }
        internal static void GetSource3i(uint sid, int param, int[] value1, int[] value2, int[] value3) {
        }
        internal static void GetSourceiv(uint sid, int param, int[] values) {
        }
        internal static void SourcePlayv(int ns, uint[]sids) {
        }
        internal static void SourceStopv(int ns, uint[]sids) {
        }
        internal static void SourceRewindv(int ns, uint[]sids) {
        }
        internal static void SourcePausev(int ns, uint[]sids) {
        }
        internal static void SourcePlay(uint sid) {
        }
        internal static void SourceStop(uint sid) {
        }
        internal static void SourceRewind(uint sid) {
        }
        internal static void SourcePause(uint sid) {
        }
        internal static void SourceQueueBuffers(uint sid, int numEntries, uint[]bids) {
        }
        internal static void SourceUnqueueBuffers(uint sid, int numEntries, uint[]bids) {
        }
        internal static void GenBuffers(int n, uint[] buffers) {
        }
        internal static void DeleteBuffers(int n, uint[] buffers) {
        }
        internal static bool IsBuffer(uint bid) {
        }
        internal static void BufferData(uint bid, int format, IntPtr data, int size, int freq) {
        }
        internal static void Bufferf(uint bid, int param, float @value) {
        }
        internal static void Buffer3f(uint bid, int param, float value1, float value2, float value3) {
        }
        internal static void Bufferfv(uint bid, int param, float[] values) {
        }
        internal static void Bufferi(uint bid, int param, int @value) {
        }
        internal static void Buffer3i(uint bid, int param, int value1, int value2, int value3) {
        }
        internal static void Bufferiv(uint bid, int param, int[] values) {
        }
        internal static void GetBufferf(uint bid, int param, float[] @value) {
        }
        internal static void GetBuffer3f(uint bid, int param, float[] value1, float[] value2, float[] value3) {
        }
        internal static void GetBufferfv(uint bid, int param, float[] values) {
        }
        internal static void GetBufferi(uint bid, int param, int[] @value) {
        }
        internal static void GetBuffer3i(uint bid, int param, int[] value1, int[] value2, int[] value3) {
        }
        internal static void GetBufferiv(uint bid, int param, int[] values) {
        }
        internal static void DopplerFactor(float @value) {
        }
        internal static void DopplerVelocity(float @value) {
        }
        internal static void SpeedOfSound(float @value) {
        }
        internal static void DistanceModel(int distanceModel) {
        }*/
    }
}

