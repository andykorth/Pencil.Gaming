using System;

namespace Pencil.Gaming.Audio {
    public enum AlCapability {
        Invalid = -1,
    }
    public enum AlListenerf {
        Gain = 0x100A,
        EfxMetersPerUnit = 0x20004,
    }
    public enum AlListener3f {
        Position = 0x1004,
        Velocity = 0x1006,
    }
    public enum AlListenerfv {
        Orientation = 0x100F,
    }
    public enum AlSourcef {
        ReferenceDistance = 0x1020,
        MaxDistance = 0x1023,
        RolloffFactor = 0x1021,
        Pitch = 0x1003,
        Gain = 0x100A,
        MinGain = 0x100D,
        MaxGain = 0x100E,
        ConeInnerAngle = 0x1001,
        ConeOuterAngle = 0x1002,
        ConeOuterGain = 0x1022,
        SecOffset = 0x1024, // Al_EXT_OFFSET extension.
        EfxAirAbsorptionFactor = 0x20007,
        EfxRoomRolloffFactor = 0x20008,
        EfxConeOuterGainHighFrequency = 0x20009,
    }
    public enum AlSource3f {
        Position = 0x1004,
        Velocity = 0x1006,
        Direction = 0x1005,
    }
    public enum AlSourceb {
        SourceRelative = 0x202,
        Looping = 0x1007,
        EfxDirectFilterGainHighFrequencyAuto = 0x2000A,
        EfxAuxiliarySendFilterGainAuto = 0x2000B,
        EfxAuxiliarySendFilterGainHighFrequencyAuto = 0x2000C,
    }
    public enum AlSourcei {
        ByteOffset = 0x1026,  // Al_EXT_OFFSET extension.
        SampleOffset = 0x1025, // Al_EXT_OFFSET extension.
        Buffer = 0x1009,
        SourceType = 0x1027,
        EfxDirectFilter = 0x20005,
    }
    public enum AlSource3i {
        EfxAuxiliarySendFilter = 0x20006,
    }
    public enum AlGetSourcei {
        ByteOffset = 0x1026,
        SampleOffset = 0x1025,
        Buffer = 0x1009,
        SourceState = 0x1010,
        BuffersQueued = 0x1015,
        BuffersProcessed = 0x1016,
        SourceType = 0x1027,
    }
    public enum AlSourceState {
        Initial = 0x1011,
        Playing = 0x1012,
        Paused = 0x1013,
        Stopped = 0x1014,
    }
    public enum AlSourceType {
        Static = 0x1028,
        Streaming = 0x1029,
        Undetermined = 0x1030,
    }
    public enum AlFormat {
        Mono8 = 0x1100,
        Mono16 = 0x1101,
        Stereo8 = 0x1102,
        Stereo16 = 0x1103,
        MonoAlawExt = 0x10016,
        StereoAlawExt = 0x10017,
        MonoMuLawExt = 0x10014,
        StereoMuLawExt = 0x10015,
        VorbisExt = 0x10003,
        Mp3Ext = 0x10020,
        MonoIma4Ext = 0x1300,
        StereoIma4Ext = 0x1301,
        MonoFloat32Ext = 0x10010,
        StereoFloat32Ext = 0x10011,
        MonoDoubleExt = 0x10012,
        StereoDoubleExt = 0x10013,
        Multi51Chn16Ext = 0x120B,
        Multi51Chn32Ext = 0x120C,
        Multi51Chn8Ext = 0x120A,
        Multi61Chn16Ext = 0x120E,
        Multi61Chn32Ext = 0x120F,
        Multi61Chn8Ext = 0x120D,
        Multi71Chn16Ext = 0x1211,
        Multi71Chn32Ext = 0x1212,
        Multi71Chn8Ext = 0x1210,
        MultiQuad16Ext = 0x1205,
        MultiQuad32Ext = 0x1206,
        MultiQuad8Ext = 0x1204,
        MultiRear16Ext = 0x1208,
        MultiRear32Ext = 0x1209,
        MultiRear8Ext = 0x1207,
    }
    public enum AlGetBufferi {
        Frequency = 0x2001,
        Bits = 0x2002,
        Channels = 0x2003,
        Size = 0x2004,
    }
    public enum AlBufferState {
        Unused = 0x2010,
        Pending = 0x2011,
        Processed = 0x2012,
    }
    public enum AlError {
        NoError = 0,
        InvalidName = 0xA001,
        IllegalEnum = 0xA002,
        InvalidEnum = 0xA002,
        InvalidValue = 0xA003,
        IllegalCommand = 0xA004,
        InvalidOperation = 0xA004,
        OutOfMemory = 0xA005,
    }
    public enum AlGetString {
        Vendor = 0xB001,
        Version = 0xB002,
        Renderer = 0xB003,
        Extensions = 0xB004,
    }
    public enum AlGetFloat {
        DopplerFactor = 0xC000,
        DopplerVelocity = 0xC001,
        SpeedOfSound = 0xC003,
    }
    public enum AlGetInteger {
        DistanceModel = 0xD000,
    }
    public enum AlDistanceModel {
        None = 0,
        InverseDistance = 0xD001,
        InverseDistanceClamped = 0xD002,
        LinearDistance = 0xD003,
        LinearDistanceClamped = 0xD004,
        ExponentDistance = 0xD005,
        ExponentDistanceClamped = 0xD006,
    }
}
