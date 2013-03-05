Pencil.Gaming
=============

A minimcalistic gaming library for C# based on OpenTK. It wraps OpenGL, GLFW and OpenAL.

Functionality and stability
===========================

| Platform       | OpenGL core     | OpenGL extensions | GLFW            | OpenAL    |
| --------------:|:---------------:|:-----------------:|:---------------:|:---------:|
| Linux 64-bit   | Stable          | Stable            | Stable          | Stable    |
| Linux 32-bit   | Stable          | Stable            | Stable          | Stable    |
| Windows 64-bit | Stable          | Stable            | Stable          | Stable    |
| Windows 32-bit | Stable          | Stable            | Stable          | Stable    |
| Mac OS X       | Stable          | Stable            | Stable          | Stable    |

Sample usage (OpenGL & GLFW)
============================
```C#
using Pencil.Gaming;
using Pencil.Gaming.Audio;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.Math;

class Program {
    private static void Main(string[] args) {
        try {
            Glfw.Init();
            
            try {
                Glfw.OpenWindow(800, 600, 8, 8, 8, 8, 24, 0, WindowMode.Window);
                Glfw.SetWindowTitle("Sample application");
                Glfw.SwapInterval(false);

                Glfw.SetTime(0.0);
                do {
                    float deltaTime = (float) Glfw.GetTime();
                    Glfw.SetTime(0.0);

                    int width, height;
                    if (Glfw.Utils.HasWindowSizeChanged(out width, out height)) {
                        Gl.Viewport(0, 0, width, height);

                        Gl.MatrixMode(MatrixMode.Projection);
                        Gl.LoadIdentity();
                        Gl.Ortho(0.0, 1.0, 1.0, 0.0, 0.0, 1.0);
                        Gl.MatrixMode(MatrixMode.Modelview);
                    }

                    
                    Gl.ClearColor(Color4.White);
                    Gl.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

                    Gl.Begin(BeginMode.Triangles);
                      Gl.Color4(Color4.Red);
                      Gl.Vertex2(0.1f, 0.1f);
                      Gl.Color4(Color4.Green);
                      Gl.Vertex2(0.1f, 0.9f);
                      Gl.Color4(Color4.Blue);
                      Gl.Vertex2(0.9f, 0.9f);
                    Gl.End();

                    Glfw.SwapBuffers();
                    Glfw.PollEvents();
                } while (Glfw.GetWindowParam(WindowParam.Opened) == Glfw.True);
            } finally {
                Glfw.CloseWindow();
            }
        } finally {
            Glfw.Terminate();
        }
    }
}
```

Sample usage (OpenAL)
=====================

```C#
uint buffer = Al.Utils.BufferFromWav("MyWaveFile.wav");
uint source;
Al.GenSources(1, out source);

Al.Source(source, AlSourcei.Buffer, (int) buffer);
Al.Source(source, AlSourceb.Looping, true);

Al.SourcePlay(source);

// ...
// ...

// When cleaning up:
Al.DeleteSources(1, ref source);
Al.DeleteBuffers(1, ref buffer);
```
