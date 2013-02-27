using System;

namespace Pencil.Gaming {
    public static class Al {
        public static void Enable(int capability) {
            AlDelegates.alEnable(capability);
        }
        public static void Disable(int capability) {
            AlDelegates.alDisable(capability);
        } 
        public static bool IsEnabled(int capability) {
            return AlDelegates.alIsEnabled(capability);
        } 
        public static unsafe string GetString(int param) {
            sbyte * bptr = AlDelegates.alGetString(param);
            return new string(bptr);
        }
        public static void GetBooleanv(int param, bool[] data) {
            AlDelegates.alGetBooleanv(param, data);
        }
        public static void GetIntegerv(int param, int[] data) {
            AlDelegates.alGetIntegerv(param, data);
        }
        public static void GetFloatv(int param, float[] data) {
            AlDelegates.alGetFloatv(param, data);
        }
        public static void GetDoublev(int param, double[] data) {
            AlDelegates.alGetDoublev(param, data);
        }
        public static bool GetBoolean(int param) {
            return AlDelegates.alGetBoolean(param);
        }
        public static int GetInteger(int param) {
            return AlDelegates.alGetInteger(param);
        }
        public static float GetFloat(int param) {
            return AlDelegates.alGetFloat(param);
        }
        public static double GetDouble(int param) {
            return AlDelegates.alGetDouble(param);
        }
        public static int GetError() {
            return AlDelegates.alGetError();
        }
        public static bool IsExtensionPresent(string extname) {
            return AlDelegates.alIsExtensionPresent(extname);
        }
        public static IntPtr GetProcAddress(string fname) {
            return AlDelegates.alGetProcAddress(fname);
        }
        public static int GetEnumValue(string ename) {
            return AlDelegates.alGetEnumValue(ename);
        }
        public static void Listenerf(int param, float value) {
            AlDelegates.alListenerf(param, value);
        }
        public static void Listener3f(int param, float value1, float value2, float value3) {
            AlDelegates.alListener3f(param, value1, value2, value3);
        }
        public static void Listenerfv(int param, float[] values) {
            AlDelegates.alListenerfv(param, values);
        } 
        public static void Listeneri(int param, int value) {
            AlDelegates.alListeneri(param, value);
        }
        public static void Listener3i(int param, int value1, int value2, int value3) {
            AlDelegates.alListener3i(param, value1, value2, value3);
        }
        public static void Listeneriv(int param, int[] values) {
            AlDelegates.alListeneriv(param, values);
        }
        public static void GetListenerf(int param, out float value) {
            AlDelegates.alGetListenerf(param, out value);
        }
        public static void GetListener3f(int param, out float value1, out float value2, out float value3) {
            AlDelegates.alGetListener3f(param, out value1, out value2, out value3);
        }
        public static void GetListenerfv(int param, float[] values) {
            AlDelegates.alGetListenerfv(param, values);
        }
        public static void GetListeneri(int param, out int value) {
            AlDelegates.alGetListeneri(param, out value);
        }
        public static void GetListener3i(int param, out int value1, out int value2, out int value3) {
            AlDelegates.alGetListener3i(param, out value1, out value2, out value3);
        }
        public static void GetListeneriv(int param, int[] values) {
            AlDelegates.alGetListeneriv(param, values);
        }
        public static void GenSources(int n, uint[] sources) {
            AlDelegates.alGenSources(n, sources);
        } 
        public static void DeleteSources(int n, uint[] sources) {
            AlDelegates.alDeleteSources(n, sources);
        }
        public static bool IsSource(uint sid) {
            return AlDelegates.alIsSource(sid);
        } 
        public static void Sourcef(uint sid, int param, float value) {
            AlDelegates.alSourcef(sid, param, value);
        } 
        public static void Source3f(uint sid, int param, float value1, float value2, float value3) {
            AlDelegates.alSource3f(sid, param, value1, value2, value3);
        }
        public static void Sourcefv(uint sid, int param, float[] values) {
            AlDelegates.alSourcefv(sid, param, values);
        } 
        public static void Sourcei(uint sid, int param, int value) {
            AlDelegates.alSourcei(sid, param, value);
        } 
        public static void Source3i(uint sid, int param, int value1, int value2, int value3) {
            AlDelegates.alSource3i(sid, param, value1, value2, value3);
        }
        public static void Sourceiv(uint sid, int param, int[] values) {
            AlDelegates.alSourceiv(sid, param, values);
        }
        public static void GetSourcef(uint sid, int param, out float value) {
            AlDelegates.alGetSourcef(sid, param, out value);
        }
        public static void GetSource3f(uint sid, int param, out float value1, out float value2, out float value3) {
            AlDelegates.alGetSource3f(sid, param, out value1, out value2, out value3);
        }
        public static void GetSourcefv(uint sid, int param, float[] values) {
            AlDelegates.alGetSourcefv(sid, param, values);
        }
        public static void GetSourcei(uint sid, int param, out int value) {
            AlDelegates.alGetSourcei(sid, param, out value);
        }
        public static void GetSource3i(uint sid, int param, out int value1, out int value2, out int value3) {
            AlDelegates.alGetSource3i(sid, param, out value1, out value2, out value3);
        }
        public static void GetSourceiv(uint sid, int param, int[] values) {
            AlDelegates.alGetSourceiv(sid, param, values);
        }
        public static void SourcePlayv(int ns, uint[]sids) {
            AlDelegates.alSourcePlayv(ns, sids);
        }
        public static void SourceStopv(int ns, uint[]sids) {
            AlDelegates.alSourceStopv(ns, sids);
        }
        public static void SourceRewindv(int ns, uint[]sids) {
            AlDelegates.alSourceRewindv(ns, sids);
        }
        public static void SourcePausev(int ns, uint[]sids) {
            AlDelegates.alSourcePausev(ns, sids);
        }
        public static void SourcePlay(uint sid) {
            AlDelegates.alSourcePlay(sid);
        }
        public static void SourceStop(uint sid) {
            AlDelegates.alSourceStop(sid);
        }
        public static void SourceRewind(uint sid) {
            AlDelegates.alSourceRewind(sid);
        }
        public static void SourcePause(uint sid) {
            AlDelegates.alSourcePause(sid);
        }
        public static void SourceQueueBuffers(uint sid, int numEntries, uint[]bids) {
            AlDelegates.alSourceQueueBuffers(sid, numEntries, bids);
        }
        public static void SourceUnqueueBuffers(uint sid, int numEntries, uint[]bids) {
            AlDelegates.alSourceUnqueueBuffers(sid, numEntries, bids);
        }
        public static void GenBuffers(int n, uint[] buffers) {
            AlDelegates.alGenBuffers(n, buffers);
        }
        public static void DeleteBuffers(int n, uint[] buffers) {
            AlDelegates.alDeleteBuffers(n, buffers);
        }
        public static bool IsBuffer(uint bid) {
            return AlDelegates.alIsBuffer(bid);
        }
        public static void BufferData(uint bid, int format, IntPtr data, int size, int freq) {
            AlDelegates.alBufferData(bid, format, data, size, freq);
        }
        public static void Bufferf(uint bid, int param, float value) {
            AlDelegates.alBufferf(bid, param, value);
        }
        public static void Buffer3f(uint bid, int param, float value1, float value2, float value3) {
            AlDelegates.alBuffer3f(bid, param, value1, value2, value3);
        }
        public static void Bufferfv(uint bid, int param, float[] values) {
            AlDelegates.alBufferfv(bid, param, values);
        }
        public static void Bufferi(uint bid, int param, int value) {
            AlDelegates.alBufferi(bid, param, value);
        }
        public static void Buffer3i(uint bid, int param, int value1, int value2, int value3) {
            AlDelegates.alBuffer3i(bid, param, value1, value2, value3);
        }
        public static void Bufferiv(uint bid, int param, int[] values) {
            AlDelegates.alBufferiv(bid, param, values);
        }
        public static void GetBufferf(uint bid, int param, out float value) {
            AlDelegates.alGetBufferf(bid, param, out value);
        }
        public static void GetBuffer3f(uint bid, int param, out float value1, out float value2, out float value3) {
            AlDelegates.alGetBuffer3f(bid, param, out value1, out value2, out value3);
        }
        public static void GetBufferfv(uint bid, int param, float[] values) {
            AlDelegates.alGetBufferfv(bid, param, values);
        }
        public static void GetBufferi(uint bid, int param, out int value) {
            AlDelegates.alGetBufferi(bid, param, out value);
        }
        public static void GetBuffer3i(uint bid, int param, out int value1, out int value2, out int value3) {
            AlDelegates.alGetBuffer3i(bid, param, out value1, out value2, out value3);
        }
        public static void GetBufferiv(uint bid, int param, int[] values) {
            AlDelegates.alGetBufferiv(bid, param, values);
        }
        public static void DopplerFactor(float value) {
            AlDelegates.alDopplerFactor(value);
        }
        public static void DopplerVelocity(float value) {
            AlDelegates.alDopplerVelocity(value);
        }
        public static void SpeedOfSound(float value) {
            AlDelegates.alSpeedOfSound(value);
        }
        public static void DistanceModel(int distanceModel) {
            AlDelegates.alDistanceModel(distanceModel);
        }
    }
}

