using System;
using System.IO;
using Pencil.Gaming;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;

namespace Pencil.Quick2D {
    public class SpriteSheet : IDisposable {
        public Image Image { get; private set; }

        private Rectanglei[][] sprites;

        public SpriteSheet(Image img, Rectanglei[][] images) {
            sprites = images;
            Image = img;
            ++img.Instances;
        }

        public SpriteSheet(Image img, int gridColumnCount, int gridRowCount) {
            sprites = new Rectanglei[gridColumnCount][];
            for (int i = 0; i < sprites.Length; ++i) {
                sprites[i] = new Rectanglei[gridRowCount];
            }

            int pixelsPerColumn = img.Width / gridColumnCount;
            int pixelsPerRow = img.Height / gridRowCount;
            for (int x = 0; x < sprites.Length; ++x) {
                for (int y = 0; y < sprites[x].Length; ++y) {
                    sprites[x][y] = new Rectanglei(x * pixelsPerColumn, y * pixelsPerRow, pixelsPerColumn, pixelsPerRow);
                }
            }

            Image = img;
        }
    
        public Rectanglei GetSubImage(int x, int y) {
            return sprites[x][y];
        }

        public Sprite GetSubSprite(int x, int y) {
            Rectanglei rect = GetSubImage(x, y);
            return new Sprite(Image, Vector2.Zero, rect.Width, rect.Height, new Rectangle(rect.X, rect.Y, rect.Width, rect.Height));
        }

        public void Dispose() {
            --Image.Instances;
            if (Image.Instances == 0) {
                Image.Dispose();
            }
        }
    }
}

