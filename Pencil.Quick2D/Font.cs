using System;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;

namespace Pencil.Quick2D {
    public abstract class Font : IDisposable {
        public static Font Load(string name, float emSize, Color4 color) {
            return new SystemFont(name, emSize, color);
        }

        public abstract int LineHeight { get; }
        public abstract int WhitespaceWidth { get; }
        internal Image Image;

        public abstract Rectanglei GetCharRectangle(char ch);

        public abstract void Dispose();
    }
}

