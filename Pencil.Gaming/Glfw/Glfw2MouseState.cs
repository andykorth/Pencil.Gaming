#if USE_GLFW2
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

        public static MouseState GetMouseState() {
            MouseState result = new MouseState();

            result.LeftButton = Glfw.GetMouseButton(MouseButton.LeftButton);
            result.MiddleButton = Glfw.GetMouseButton(MouseButton.MiddleButton);
            result.RightButton = Glfw.GetMouseButton(MouseButton.RightButton);
            result.ScrollWheel = Glfw.GetMouseWheel();
            int x, y;
            Glfw.GetMousePos(out x, out y);
            result.X = x;
            result.Y = y;

            return result;
        }
    }
}
#endif
