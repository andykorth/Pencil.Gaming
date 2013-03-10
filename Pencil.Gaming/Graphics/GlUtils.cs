using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Pencil.Gaming.Graphics {
    public static partial class Gl {
        public static class Utils {
            public static int LoadImage(string path) {
                using (Bitmap bmp = new Bitmap(path)) {
                    return LoadImage(bmp);
                }
            }

            public static int LoadImage(string path, TextureMinFilter tmin, TextureMagFilter tmag) {
                using (Bitmap bmp = new Bitmap(path)) {
                    return LoadImage(bmp, tmin, tmag);
                }
            }

            public static int LoadImage(Stream file) {
                using (Bitmap bmp = new Bitmap(file)) {
                    return LoadImage(bmp);
                }
            }

            public static int LoadImage(Stream file, TextureMinFilter tmin, TextureMagFilter tmag) {
                using (Bitmap bmp = new Bitmap(file)) {
                    return LoadImage(bmp, tmin, tmag);
                }
            }

            public static int LoadImage(Bitmap bmp) {
                return LoadImage(bmp, TextureMinFilter.Nearest, TextureMagFilter.Nearest);
            }

            public static int LoadImage(Bitmap bmp, TextureMinFilter tmin, TextureMagFilter tmag) {
                BitmapData bmpData = bmp.LockBits(
                    new Rectangle(Point.Empty, bmp.Size), 
                    ImageLockMode.ReadOnly, 
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb
                );
                
                int result;


                try {
                    Gl.GenTextures(1, out result);
                    Gl.BindTexture(TextureTarget.Texture2D, result);
                    Gl.TexImage2D(
                        TextureTarget.Texture2D, 
                        0, 
                        PixelInternalFormat.Rgba,
                        bmp.Width,
                        bmp.Height,
                        0,
                        Pencil.Gaming.Graphics.PixelFormat.Bgra,
                        PixelType.UnsignedByte,
                        bmpData.Scan0
                    );
                    Gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)tmag);
                    Gl.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)tmin);
                    Gl.BindTexture(TextureTarget.Texture2D, 0);
                } finally {
                    bmp.UnlockBits(bmpData);
                }

                return result;
            }

            // TODO: Add .obj loading utility
        }
    }
}

