using System;
using Pencil.Gaming;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;

namespace Pencil.Quick2D {
    public class Sprite : IDisposable {
        private Vector2 positionField;
        public Vector2 Position {
            get {
                return positionField;
            }
            set {
                positionField = value;
            }
        }
        public float X {
            get {
                return positionField.X;
            }
            set {
                positionField.X = value;
            }
        }
        public float Y {
            get {
                return positionField.Y;
            }
            set {
                positionField.Y = value;
            }
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public Vector2i Size {
            get {
                return new Vector2i(Width, Height);
            }
            set {
                Width = value.X;
                Height = value.Y;
            }
        }
        public Vector2 Center {
            get {
                return Position + (new Vector2(Size) / 2f);
            }
            set {
                Position = value - (new Vector2(Size) / 2f);
            }
        }
        public Rectangle TextureArea { get; private set; }
        public Image Image { get; private set; }
        public Rectangle PositionSize {
            get {
                return new Rectangle(Position, new Vector2(Size));
            }
            set {
                Position = value.Position;
                Width = (int)value.Width;
                Height = (int)value.Height;
            }
        }

        public Sprite(Image img, Vector2 position, int width, int height, Rectangle texArea) {
            Image = img;
            ++Image.Instances;

            Width = width;
            if (Width == -1) {
                Width = img.Width;
            }
            Height = height;
            if (Height == -1) {
                Height = img.Height;
            }

            if (texArea.Width == -1) {
                texArea.Width = img.Width;
            }
            if (texArea.Height == -1) {
                texArea.Height = img.Height;
            }
            TextureArea = texArea;
            positionField = position;
        }
        public Sprite(Image img, Vector2 position, int height, int width) : this (img, position, width, height, new Rectangle(0, 0, -1, -1)) {
        }
        public Sprite(Image img, Vector2 position) : this (img, position, -1, -1) {
        }
        public Sprite(Image img) : this(img, Vector2.Zero) {
        }

        public void Dispose() {
            if (--Image.Instances == 0) {
                Image.Dispose();
            }
        }
    }
}
