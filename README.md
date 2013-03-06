Pencil.Gaming
=============
Pencil.Gaming is a gaming library for C#, providing support for OpenGL, GLFW and OpenAL. It's a stable, cross-platform, open-source (some prefer the term "free") alternative to libraries like XNA, which has pretty much died now, OpenTK, which hasn't been updated for about a year, and SharpDX, which is not cross-platform. A feature that Pencil.Gaming has over most other C# gaming libraries, is that users **do not need to install any redistributables!** 

The OpenGL implementation is based on the OpenTK source code.

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
Pencil.Gaming differs from OpenTK, mainly in that it uses GLFW as it's windowing system, whereas OpenTK implements its own windowing system, making it pretty buggy. For more information on the GLFW windowing library, you can visit www.glfw.org.

Here is an example covering the basics of GLFW (although it doesn't show input).

```C#
using Pencil.Gaming;
using Pencil.Gaming.Audio;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.Math;

class Program {
    private static void Resize(int width, int height) {
        Gl.Viewport(0, 0, width, height);

        Gl.MatrixMode(MatrixMode.Projection);
        Gl.LoadIdentity();
        Gl.Ortho(0.0, 1.0, 1.0, 0.0, 0.0, 1.0);
        Gl.MatrixMode(MatrixMode.Modelview);
    }

    private static void Main(string[] args) {
        try {
            Glfw.Init();
            
            try {
                Glfw.OpenWindow(800, 600, 8, 8, 8, 8, 24, 0, WindowMode.Window);
                Glfw.SetWindowTitle("Sample application");
                Glfw.SwapInterval(false);

                Glfw.SetWindowSizeCallback(Resize);

                Glfw.SetTime(0.0);
                do {
                    float deltaTime = (float) Glfw.GetTime();
                    Glfw.SetTime(0.0);
                    
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
Apart from implementing GLFW, Pencil.Gaming also has a few utilities to make your life bearable. On of the more notable of these is the `Al.Utils.BufferFromWav` utility, which is able to load wave files into an OpenAL buffer.

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
