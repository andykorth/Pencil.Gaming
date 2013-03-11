Pencil.Gaming
=============
Pencil.Gaming is a gaming library for C#, providing support for OpenGL, GLFW and OpenAL. It's a stable, cross-platform, open-source (some prefer the term "free") alternative to libraries like XNA, which has pretty much died now, OpenTK, which hasn't been updated for about a year, and SharpDX, which is not cross-platform. A feature that Pencil.Gaming has over most other C# gaming libraries, is that users **do not need to install any redistributables!** 

The OpenGL implementation is based on the OpenTK source code.

A quick overview of the samples:
- [OpenAL utilities] (https://github.com/antonijn/Pencil.Gaming#sample-usage-openal)
- [OpenGL utilities] (https://github.com/antonijn/Pencil.Gaming#sample-usage-glutils)

Functionality and stability
===========================
GLFW2
-----
| Platform       | OpenGL core     | OpenGL extensions | GLFW            | OpenAL    |
| --------------:|:---------------:|:-----------------:|:---------------:|:---------:|
| Linux 64-bit   | Stable          | Stable            | Stable          | Stable    |
| Linux 32-bit   | Stable          | Stable            | Stable          | Stable    |
| Windows 64-bit | Stable          | Stable            | Stable          | Stable    |
| Windows 32-bit | Stable          | Stable            | Stable          | Stable    |
| Mac OS X       | Stable          | Stable            | Stable          | Stable    |

GLFW3
-----
| Platform       | OpenGL core     | OpenGL extensions | GLFW            | OpenAL    |
| --------------:|:---------------:|:-----------------:|:---------------:|:---------:|
| Linux 64-bit   | Stable          | Stable            | Stable          | Stable    |
| Linux 32-bit   | Stable          | Stable            | **Broken**      | Stable    |
| Windows 64-bit | Stable          | Stable            | Stable          | Stable    |
| Windows 32-bit | Stable          | Stable            | Untested        | Stable    |
| Mac OS X       | Stable          | Stable            | Not Implemented | Stable    |

Sample usage (OpenGL & GLFW)
============================
This section has been removed. Please refer to the [wiki] (https://github.com/antonijn/Pencil.Gaming/wiki) for GLFW2/3 examples.

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

Sample Usage (Gl.Utils)
=======================
`Gl.Utils` is another utility class provided by Pencil.Gaming. It provides support for cross-platform texture loading, and **will** feature a model loading utility (obj files only).

This is how you use the image loading utility:
```C#
int image = Gl.Utils.LoadImage("myfile.png"); // Works with multiple file formats
Gl.BindTexture(TextureTarget.Texture2D, image);

Gl.Begin(BeginMode.TriangleStrip);
  Gl.TexCoord2(0f, 1f);
  Gl.Vertex2(0.1f, 0.9f);
  Gl.TexCoord2(0f, 0f);
  Gl.Vertex2(0.1f, 0.1f);
  Gl.TexCoord2(1f, 1f);
  Gl.Vertex2(0.9f, 0.9f);
  Gl.TexCoord2(1f, 0f);
  Gl.Vertex2(0.9f, 0.1f);
Gl.End();
```
