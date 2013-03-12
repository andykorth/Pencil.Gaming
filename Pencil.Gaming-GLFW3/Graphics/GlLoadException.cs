using System;

namespace Pencil.Gaming.Graphics {
    public class GlLoadException : Exception {
        public GlLoadException() : base("Failed to load OpenGL functions: no current context. " + 
                                        "A window should be created and a call to Glfw.MakeContextCurrent must be made " + 
                                        "prior to any use of OpenGL functions.") {
        }
    }
}

