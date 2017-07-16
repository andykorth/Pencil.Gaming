Pencil.Gaming
=============
Pencil.Gaming is a gaming library for C#, providing support for OpenGL, GLFW, OpenAL and Lua. It's a stable, cross-platform, open-source (some prefer the term "free") alternative to libraries like XNA, which has pretty much died now, OpenTK, which hasn't been updated for about a year, and SharpDX, which is not cross-platform. A feature that Pencil.Gaming has over most other C# gaming libraries, is that users **do not need to install any redistributables besides Mono/.NET!** 

The OpenGL implementation is based on the OpenTK source code.

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
| Windows 32-bit | Stable          | Stable            | Presumed Stable | Stable    |
| Mac OS X       | Stable          | Stable            | Stable*          | Stable    |

*Both 32 and 64-bit versions provided for Mac OS X, but mono is realistically only available for 32-bit, so those are recommended.

Fixing the `DllNotFoundException`
===============================
When running a Pencil.Gaming application, it's unfortunately required that you set your .NET working directory to the directory of the application. Not doing so will result in a `DllNotFoundException`. This should probably be the first thing in your main function:

```C#
 Environment.CurrentDirectory = Path.GetDirectoryName(typeof(Program).Assembly.Location);
 ```
 
 When using Mono, it's also quite important that you **have the Pencil.Gaming.dll.config file in the same directory as Pencil.Gaming.dll**.

Callback Example
----------------
For a quick example of the callbacks, such as the input, see:
[https://gist.github.com/andykorth/b6abf59895c8f6a67964](https://gist.github.com/andykorth/b6abf59895c8f6a67964)


Image loading utility
---------------------
```C#
int image = GL.Utils.LoadImage("myfile.png"); // Works with multiple file formats
GL.BindTexture(TextureTarget.Texture2D, image);

GL.Begin(BeginMode.TriangleStrip);
  GL.TexCoord2(0f, 1f);
  GL.Vertex2(0.1f, 0.9f);
  GL.TexCoord2(0f, 0f);
  GL.Vertex2(0.1f, 0.1f);
  GL.TexCoord2(1f, 1f);
  GL.Vertex2(0.9f, 0.9f);
  GL.TexCoord2(1f, 0f);
  GL.Vertex2(0.9f, 0.1f);
GL.End();

GL.DeleteTextures(1, ref image);
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
GL.Enable(EnapleCap.DepthTest);

Vector4[] vertices;
Vector3[] normals;
Vector2[] texCoords;
int[] indices;
GL.Utils.LoadModel("model.obj", out vertices, out normals, out texCoords, out indices, false);

numberOfIndices = indices.Length;

GL.GenBuffers(1, out modelVbo);
GL.BindBuffer(BufferTarget.ArrayBuffer, modelVbo);
GL.BufferData(BufferTarget.ArrayBuffer, new IntPtr(vertices.Length * 4 * sizeof(float)), vertices, BufferUsageHint.StaticDraw);
GL.BindBuffer(BufferTarget.ArrayBuffer, 0);

GL.GenBuffers(1, out indexVbo);
GL.BindBuffer(BufferTarget.ElementArrayBuffer, indexVbo);
GL.BufferData(BufferTarget.ElementArrayBuffer, new IntPtr(indices.Length * sizeof(int)), indices, BufferUsageHint.StaticDraw);
GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);
```

#### In the draw function
```C#
// NOTE: This uses legacy OpenGL, just to fit in the readme...
GL.EnableClientState(ArrayCap.VertexArray);

GL.BindBuffer(BufferTarget.ArrayBuffer, modelVbo);
GL.BindBuffer(BufferTarget.ElementArrayBuffer, indexVbo);

GL.VertexPointer(4, VertexPointerType.Float, 4 * sizeof(float), 0);
GL.DrawElements(BeginMode.Triangles, numberOfIndices, DrawElementsType.UnsignedInt, 0);

GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
GL.BindBuffer(BufferTarget.ElementArrayBuffer, 0);

GL.DisableClientState(ArrayCap.VertexArray);
```

#### During cleanup
```C#
GL.DeleteBuffers(1, ref modelVbo);
GL.DeleteBuffers(1, ref indexVbo);
```

Lua
===
Lua is a light-weight scripting language, perfectly suitable for use in game development.

Pencil.Gaming provides support for Lua, using the default C# `PascalCased` identifiers, making it integrate seamlessly with other C# code.

Whereas a C-api function call might be `lua_pcall(L, 0, LUA_MULTRET, 0)`, the Pencil.Gaming C# API call would be `Lua.PCall(L, 0, Lua.MultRet, 0)`.

For more information on using these lua bindings, see the [Lua C api docs](http://www.lua.org/pil/contents.html#24).

Sample usage (OpenAL)
=====================
Another utility is the `AL.Utils.BufferFromWav` utility, which is able to load wave files into an OpenAL buffer. Similarly, there's the `AL.Utils.BufferFromOgg` utility, allowing Ogg/Vorbis file loading.

```C#
uint buffer = AL.Utils.BufferFromWav("MyWaveFile.wav");
uint source;
AL.GenSources(1, out source);

AL.Source(source, ALSourcei.Buffer, (int) buffer);
AL.Source(source, ALSourceb.Looping, true);

AL.SourcePlay(source);

// ...
// ...

// When cleaning up:
AL.DeleteSources(1, ref source);
AL.DeleteBuffers(1, ref buffer);
```

Other Resources
===============

* [Collada Importer](http://sourceforge.net/projects/csharpcollada/)
