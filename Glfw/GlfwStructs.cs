using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct GlfwVidMode {
        [FieldOffsetAttribute(0)]
        public int
            Width;
        [FieldOffsetAttribute(4)]
        public int
            Height;
        [FieldOffsetAttribute(8)]
        public int
            RedBits;
        [FieldOffsetAttribute(12)]
        public int
            BlueBits;
        [FieldOffsetAttribute(16)]
        public int
            GreenBits;
    }

    // Can't specify size, don't know whether I'm using 32 or 64 bit pointers.
    [StructLayout(LayoutKind.Explicit)]
    public struct GlfwImage {
        [FieldOffsetAttribute(0)]
        public int
            Width;
        [FieldOffsetAttribute(4)]
        public int
            Height;
        [FieldOffsetAttribute(8)]
        public int
            Format;
        [FieldOffsetAttribute(12)]
        public int
            BytesPerPixel;
        [FieldOffsetAttribute(14)]
        public IntPtr
            Data;
    }
}
