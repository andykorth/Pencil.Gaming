#if USE_GLFW3
using System;

namespace Pencil.Gaming {
    public sealed class MouseState {
        public bool LeftButton { get; private set; }
        public bool MiddleButton { get; private set; }
        public bool RightButton { get; private set; }
        public int ScrollWheel { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        private MouseState() {
        }

        public static MouseState GetMouseState(GlfwWindowPtr window) {
            MouseState result = new MouseState();

            result.LeftButton = Glfw.GetMouseButton(window, MouseButton.LeftButton);
            result.MiddleButton = Glfw.GetMouseButton(window, MouseButton.MiddleButton);
            result.RightButton = Glfw.GetMouseButton(window, MouseButton.RightButton);
            int x, y;
            Glfw.GetCursorPos(window, out x, out y);
            result.X = x;
            result.Y = y;

            return result;
        }
    }
}
#endif
