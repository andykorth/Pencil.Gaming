using System;

namespace Pencil.Gaming.Graphics {
    public class GlLoadException : Exception {
        public GlLoadException() : base("Cannot load OpenGL functions, no current context." +
                                        "Please open a window before loading/using any OpenGL functions.") {
        }
    }
}
