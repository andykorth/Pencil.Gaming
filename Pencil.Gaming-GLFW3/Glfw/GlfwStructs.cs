using System;
using System.Runtime.InteropServices;

namespace Pencil.Gaming {
    [StructLayout(LayoutKind.Explicit, Size = sizeof(int) * 5)]
    public struct GlfwVidMode {
        [FieldOffset(sizeof(int) * 0)]
        public int
            Width;
        [FieldOffset(sizeof(int) * 1)]
        public int
            Height;
        [FieldOffset(sizeof(int) * 2)]
        public int
            RedBits;
        [FieldOffset(sizeof(int) * 3)]
        public int
            BlueBits;
        [FieldOffset(sizeof(int) * 4)]
        public int
            GreenBits;
    }

    [StructLayout(LayoutKind.Explicit, Size = sizeof(ushort) * 256 * 3)]
    public struct GlfwGammaRamp {
        [MarshalAsAttribute(UnmanagedType.ByValArray)]
        [FieldOffset(sizeof(int) * 256 * 0)]
        public ushort[]
            Red;
        [MarshalAsAttribute(UnmanagedType.ByValArray)]
        [FieldOffset(sizeof(int) * 256 * 1)]
        public ushort[]
            Green;
        [MarshalAsAttribute(UnmanagedType.ByValArray)]
        [FieldOffset(sizeof(int) * 256 * 2)]
        public ushort[]
            Blue;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GlfwMonitorPtr {
        private GlfwMonitorPtr(IntPtr ptr) {
            inner_ptr = ptr;
        }

        [FieldOffsetAttribute(0)]
        private IntPtr
            inner_ptr;

        public readonly static GlfwMonitorPtr Null = new GlfwMonitorPtr(IntPtr.Zero);
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GlfwWindowPtr {
        private GlfwWindowPtr(IntPtr ptr) {
            innter_ptr = ptr;
        }

        [FieldOffsetAttribute(0)]
        private IntPtr
            innter_ptr;

        public readonly static GlfwWindowPtr Null = new GlfwWindowPtr(IntPtr.Zero);
    }
}

