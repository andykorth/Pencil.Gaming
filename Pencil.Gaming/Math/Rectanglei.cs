using System;
using Pencil.Gaming.MathUtils;

namespace Pencil.Gaming.MathUtils {
	public struct Rectanglei {
		public int X, Y, Width, Height;
		public Vector2i Position {
			get {
				return new Vector2i(X, Y);
			}
			set {
				X = value.X;
				Y = value.Y;
			}
		}
		public Vector2i Size {
			get {
				return new Vector2i(Width, Height);
			}
			set {
				Width = value.X;
				Height = value.Y;
			}
		}

		public Rectanglei(int x, int y, int width, int height) {
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}
		public Rectanglei(Vector2i pos, int width, int height) : this(pos.X, pos.Y, width, height) {
		}
		public Rectanglei(Vector2i pos, Vector2i size) : this(pos, size.X, size.Y) {
		}
	}
}

