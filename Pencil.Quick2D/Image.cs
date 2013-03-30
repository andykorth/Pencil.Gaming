using System;
using System.IO;
using System.Drawing;
using Pencil.Gaming.Graphics;

namespace Pencil.Quick2D {
    public class Image : IDisposable {
        public int Width { get; private set; }
        public int Height { get; private set; }

        internal int TextureHandle;
        internal int Instances = 0;

        public Image(string file) {
            using (Bitmap bmp = new Bitmap(file)) {
                Load(bmp);
            }
        }
        public Image(Stream file) {
            using (Bitmap bmp = new Bitmap(file)) {
                Load(bmp);
            }
        }
        public Image(Bitmap bmp) {
            Load(bmp);
        }

        private void Load(Bitmap bmp) {
            TextureHandle = Gl.Utils.LoadImage(bmp, false);

            Width = bmp.Width;
            Height = bmp.Height;

            bmp.Save("asdf.png");
        }

        public void Dispose() {
            Gl.DeleteTexture(TextureHandle);
        }
    }
}

