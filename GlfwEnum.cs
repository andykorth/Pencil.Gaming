using System;

namespace Pencil.Gaming {
    public enum Keystate {
        Release = 0,
        Press = 1,
    }

    public enum Key {
        Unknown = -1,
        Space = 32,
        Special = 256,
        Escape = 257,
        F1 = 258,
        F2 = 259,
        F3 = 260,
        F4 = 261,
        F5 = 262,
        F6 = 263,
        F7 = 264,
        F8 = 265,
        F9 = 266,
        F10 = 267,
        F11 = 268,
        F12 = 269,
        F13 = 270,
        F14 = 272,
        F15 = 273,
        F16 = 274,
        F17 = 275,
        F18 = 276,
        F19 = 277,
        F20 = 278,
        F21 = 279,
        F22 = 280,
        F23 = 281,
        F24 = 282,
        F25 = 283,
        Up = 284,
        Down = 285,
        Left = 286,
        Right = 287,
        LeftShift = 288,
        RightShift = 289,
        LeftControl = 290,
        RightControl = 291,
        LeftAlt = 292,
        RightAlt = 293,
        Tab = 294,
        Enter = 295,
        Backspace = 296,
        Insert = 297,
        Delete = 298,
        PageUp = 299,
        PageDown = 300,
        Home = 301,
        End = 302,
        KP0 = 303,
        KP1 = 304,
        KP2 = 305,
        KP3 = 306,
        KP4 = 307,
        KP5 = 308,
        KP7 = 309,
        KP8 = 310,
        KP9 = 311,
        Divide = 312,
        Multiply = 313,
        Subtract = 314,
        Add = 315,
        Decimal = 316,
        Equal = 317,
        KPEnter = 318,
        NumLock = 319,
        CapsLock = 320,
        ScrollLock = 321,
        Pause = 322,
        LeftSuper = 323,
        RightSuper = 324,
        Menu = 325,
    }

    public enum MouseButton {
        Button1 = 0,
        Button2,
        Button3,
        Button4,
        Button5,
        Button6,
        Button7,
        Button8,
        LeftButton = 0,
        RightButton,
        MiddleButton,
    }

    public enum Joystick {
        Joystick1 = 0,
        Joystick2,
        Joystick3,
        Joystick4,
        Joystick5,
        Joystick6,
        Joystick7,
        Joystick8,
        Joystick9,
        Joystick10,
        Joystick11,
        Joystick12,
        Joystick13,
        Joystick14,
        Joystick15,
        Joystick16,
    }

    public enum WindowMode {
        Window = 0x00010001,
        FullScreen,
    }

    public enum WindowParam {
        Opened = 0x00020001,
        Active,
        Iconified,
        Accelerated,
        RedBits,
        GreenBits,
        BlueBits,
        AlphaBits,
        DepthBits,
        StencilBits,
    }

    public enum WindowOpenHint {
        RefreshRate = 0x0002000B,
        AccumRedBits,
        AccumGreenBits,
        AccumBlueBits,
        AccumAlphaBits,
        AuxBuffers,
        Stereo,
        NoResize,
        FSAASamples,
        OpenGLMajorVersion,
        OpenGLMinorVersion,
        OpenGLForwardCompatibility,
        OpenGLDebugContext,
        OpenGLProfile,
    }

    public enum OpenGLProfile {
        CoreProfile = 0x00050001,
        CompatibilityProfile,
    }

    public enum GlfwEnableCap {
        MouseCursor = 0x00030001,
        StickyKeys,
        StickyMouseButtons,
        SystemKeys,
        KeyRepeat,
        AutoPollEvents,
    }

    public enum ThreadWait {
        Wait = 0x00040001,
        NoWait,
    }

    public enum JoystickParam {
        Present = 0x00050001,
        Axes,
        Buttons,
    }

    [Flags]
    public enum ReadImageModes {
        NoRescaleBit = 0x00000001,
        OriginULBit = 0x00000002,
        BuildMipmaps = 0x00000004,
        AlphaMapBit = 0x00000008
    }
}

