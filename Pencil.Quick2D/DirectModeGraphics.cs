using System;
using Pencil.Gaming;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;

namespace Pencil.Quick2D {
    public class DirectModeGraphics : Graphics {
        public DirectModeGraphics(Game container) : base(container) {
        }

        public override void SwapBuffers() {
            Glfw.SwapBuffers();
        }

        public override void Clear(Color4 background) {
            Gl.ClearColor(background);
            Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
        }

        public override void DrawImage(Image img, Rectangle posSize, Rectangle texArea) {
            Gl.BindTexture(TextureTarget.TextureRectangle, img.TextureHandle);
            
            Gl.PushMatrix();
            {
                CurrentCamera.ApplyTransformations(Container);

                Gl.Begin(BeginMode.TriangleStrip);
                {
                    Gl.TexCoord2(texArea.X, texArea.Y);
                    Gl.Vertex2(posSize.X, posSize.Y);

                    Gl.TexCoord2(texArea.X, texArea.Y + texArea.Height);
                    Gl.Vertex2(posSize.X, posSize.Y + posSize.Height);

                    Gl.TexCoord2(texArea.X + texArea.Width, texArea.Y);
                    Gl.Vertex2(posSize.X + posSize.Width, posSize.Y);

                    Gl.TexCoord2(texArea.X + texArea.Width, texArea.Y + texArea.Height);
                    Gl.Vertex2(posSize.X + posSize.Width, posSize.Y + posSize.Height);
                }
                Gl.End();
            }
            Gl.PopMatrix();

            Gl.BindTexture(TextureTarget.TextureRectangle, 0);
        }

        public override void Resize(int width, int height) {
            Gl.Viewport(0, 0, width, height);
            Gl.MatrixMode(MatrixMode.Projection);
            Gl.LoadIdentity();
            Gl.Ortho(0d, width, height, 0d, 0d, 1d);
            Gl.MatrixMode(MatrixMode.Modelview);
        }
    }
}
