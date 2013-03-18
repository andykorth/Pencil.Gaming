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

Sample Usage (Gl.Utils)
=======================
Apart from implementing GLFW, Pencil.Gaming also has a few utilities to make your life bearable. `Gl.Utils` is one of these utility classes provided by Pencil.Gaming. It provides support for cross-platform texture loading, and features a model loading utility (obj files only).

Image loading utility
---------------------
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

Gl.DeleteTextures(1, ref image);
```

Model loading utility
----------------------

#### Fields
```C#
int modelVbo;
int indexVbo;
int numberOfIndices;
```

#### During program initialization
```C#
Gl.Enable(EnapleCap.DepthTest);

Vector4[] vertices;
Vector3[] normals;
Vector2[] texCoords;
int[] indices;
Gl.Utils.LoadModel("model.obj", out vertices, out normals, out texCoords, out indices, false);

numberOfIndices = indices.Length;

Gl.GenBuffers(1, out modelVbo);
Gl.BindBuffer(BufferTarget.ArrayBuffer, modelVbo);
Gl.BufferData(BufferTarget.ArrayBuffer, new IntPtr(vertices.Length * 4 * sizeof(float)), vertices, BufferUsageHint.StaticDraw);
Gl.BindBuffer(BufferTarget.ArrayBuffer, 0);

Gl.GenBuffers(1, out indexVbo);
Gl.BindBuffer(BufferTarget.ElementArrayBuffer, indexVbo);
Gl.BufferData(BufferTarget.ElementArrayBuffer, new IntPtr(indices.Length * sizeof(int)), indices, BufferUsageHint.StaticDraw);
Gl.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
```

#### In the draw function
```C#
// NOTE: This uses legacy OpenGL, just to fit in the readme...
Gl.EnableClientState(ArrayCap.VertexArray);

Gl.BindBuffer(BufferTarget.ArrayBuffer, modelVbo);
Gl.BindBuffer(BufferTarget.ElementArrayBuffer, indexVbo);

Gl.VertexPointer(4, VertexPointerType.Float, 4 * sizeof(float), 0);
Gl.DrawElements(BeginMode.Triangles, numberOfIndices, DrawElementsType.UnsignedInt, 0);

Gl.BindBuffer(BufferTarget.ArrayBuffer, 0);
Gl.BindBuffer(BufferTarget.ElementArrayBuffer, 0);

Gl.DisableClientState(ArrayCap.VertexArray);
```

#### During cleanup
```C#
Gl.DeleteBuffers(1, ref modelVbo);
Gl.DeleteBuffers(1, ref indexVbo);
```

Sample usage (OpenAL)
=====================
Another utility is the `Al.Utils.BufferFromWav` utility, which is able to load wave files into an OpenAL buffer.

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
