using System;
using Bitmap = System.Drawing.Bitmap;
using Brush = System.Drawing.Brush;
using SolidBrush = System.Drawing.SolidBrush;
using Color = System.Drawing.Color;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;

namespace Pencil.Quick2D {
    public sealed class SystemFont : Font {
        private static char[][] charsInFont = new [] {
            new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', },
            new char[] { 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', },
            new char[] { 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', },
            new char[] { 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', },
            new char[] { 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '0', '1', '2', },
            new char[] { '3', '4', '5', '6', '7', '8', '9', '.', ',', '!', '?', },
            new char[] { '¡', '¿', ':', ';', '\'', '"', '(', ')', '[', ']', '{', },
            new char[] { '}', '@', '#', '$', '%', '€', '^', '&', '*', '/', '\\', },
            new char[] { '|', '`', '~',  '-', '_', '+', '=', ' ', },
        };

        private Rectanglei[][] rects;

        private int lineHeight;
        public override int LineHeight {
            get {
                return lineHeight;
            }
        }

        private int whitespaceWidth;
        public override int WhitespaceWidth {
            get {
                return whitespaceWidth;
            }
        }

        public SystemFont(string name, float emSize, Color4 color) {
            using (System.Drawing.Font font = new System.Drawing.Font(name, emSize)) {
                int totalWidth;
                int totalHeight;
                GetDimensions(font, out totalWidth, out totalHeight, out rects);
                using (Bitmap bmp = new Bitmap(totalWidth, totalHeight)) {
                    using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp)) {
                        Color c = Color.FromArgb((int)(color.A * 255), (int)(color.R * 255), (int)(color.G * 255), (int)(color.B * 255));
                        using (Brush brush = new SolidBrush(c)) {
                            for (int i = 0; i < charsInFont.Length; ++i) {
                                for (int j = 0; j < charsInFont[i].Length; ++j) {
                                    int currentY = rects[i][j].Y;
                                    int currentX = rects[i][j].X;

                                    string str = new string(charsInFont[i][j], 1);
                                    g.DrawString(str, font, brush, new System.Drawing.PointF(currentX, currentY));
                                }
                            }
                        }
                    }

                    Image = new Image(bmp);
                }
            }
        }

        private void GetDimensions(System.Drawing.Font font, out int totalWidth, out int totalHeight, out Rectanglei[][] _rects) {
            totalWidth = 0;
            totalHeight = 0;
            _rects = new Rectanglei[charsInFont.Length][];
            for (int i = 0; i < charsInFont.Length; ++i) {
                _rects[i] = new Rectanglei[charsInFont[i].Length];
            }
            using (Bitmap bmp = new Bitmap(1, 1)) {
                using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bmp)) {
                    for (int i = 0; i < charsInFont.Length; ++i) {
                        int height = 0;
                        int width = 0;

                        for (int j = 0; j < charsInFont[i].Length; ++j) {
                            string str = new string(charsInFont[i][j], 1);
                            System.Drawing.SizeF size = g.MeasureString(str, font);

                            int charWidth = (int)(size.Width + .5f);
                            int charHeight = (int)(size.Height + .5f);

                            if (charsInFont[i][j] == ' ') {
                                whitespaceWidth = charWidth;
                            }

                            _rects[i][j] = new Rectanglei(width, totalHeight, charWidth, charHeight);

                            height = Math.Max(height, charHeight);
                            width += charWidth;
                        }

                        totalWidth = Math.Max(totalWidth, width);
                        totalHeight += height;
                    }

                    lineHeight = totalHeight / charsInFont.Length;
                }
            }
        }

        public override Rectanglei GetCharRectangle(char ch) {
            for (int i = 0; i < charsInFont.Length; ++i) {
                for (int j = 0; j < charsInFont[i].Length; ++j) {
                    if (charsInFont[i][j] == ch) {
                        return rects[i][j];
                    }
                }
            }

            throw new NotSupportedException("Character not supported by this font");
        }

        public override void Dispose() {
            Image.Dispose();
        }
    }
}

