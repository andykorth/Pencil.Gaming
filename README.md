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
