#region License
// Copyright (c) 2013 Antonie Blom
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

#if USE_GLFW3
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

	#pragma warning disable 0414

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
			inner_ptr = ptr;
		}

		[FieldOffsetAttribute(0)]
		private IntPtr
			inner_ptr;

		public readonly static GlfwWindowPtr Null = new GlfwWindowPtr(IntPtr.Zero);
	}

	#pragma warning restore 0414
}

#endif