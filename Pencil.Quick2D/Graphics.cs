using System;
using Pencil.Gaming;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;

namespace Pencil.Quick2D {
    public abstract class Graphics {
        protected Graphics(Game container) {
            Container = container;
        }

        public float TimeDelta { get; internal set; }
        public Game Container { get; private set; }
        public Camera CurrentCamera {
            get {
                return Container.Camera;
            }
            set {
                Container.Camera = value;
            }
        }

        public abstract void SwapBuffers();
        public abstract void Clear(Color4 background);

        public abstract void Resize(int width, int height);

        public void DrawSprite(Sprite sprite) {
            DrawImage(sprite.Image, sprite.PositionSize, sprite.TextureArea);
        }
        public void DrawImage(Image img, Vector2 position) {
            DrawImage(img, new Rectangle(position.X, position.Y, img.Width, img.Height), new Rectangle(0f, 0f, img.Width, img.Height));
        }
        public void DrawImage(Image img, Vector2 position, Rectangle texArea) {
            DrawImage(img, new Rectangle(position.X, position.Y, img.Width, img.Height), texArea);
        }
        public abstract void DrawImage(Image img, Rectangle posSize, Rectangle texArea);
        public void DrawString(Font font, string text, Vector2 position) {
            int currentY = (int)position.X;
            int currentX = (int)position.Y;
            foreach (char ch in text) {
                if (ch == '\n') {
                    currentY += font.LineHeight;
                }
                if (ch == ' ') {
                    currentX += font.WhitespaceWidth;
                }
                if (ch == '\r') {
                    break;
                }

                int deltaX;
                DrawChar(font, ch, new Vector2(currentX, currentY), out deltaX);
                currentX += deltaX;
            }
        }
        public void DrawChar(Font font, char ch, Vector2 position) {
            int dummy;
            DrawChar(font, ch, position, out dummy);
        }
        private void DrawChar(Font font, char ch, Vector2 position, out int deltaX) {
            Rectanglei rect = font.GetCharRectangle(ch);
            DrawImage(font.Image, new Rectangle(position.X, position.Y, rect.Width, rect.Height), new Rectangle(rect));
            deltaX = rect.Width;
        }
    }
}

