using System;
using Pencil.Gaming.MathUtils;
using Pencil.Gaming.Graphics;

namespace Pencil.Quick2D {
    public class Camera {
        protected internal Vector2 focusVirt;
        protected internal virtual Vector2 FocusVirt {
            get {
                return focusVirt;
            }
            set {
                focusVirt = value;
            }
        }
        public Vector2 Focus {
            get {
                return FocusVirt;
            }
            set {
                FocusVirt = value;
            }
        }
        public float PixelsPerUnit { get; set; }

        public Camera(Vector2 focus, float pixelsPerUnit) {
            focusVirt = focus;
            PixelsPerUnit = pixelsPerUnit;
        }
        public Camera(Vector2 focus) : this(focus, 1f) {
        }
        public Camera() : this(Vector2.Zero) {
        }

        public Vector2 GetAbsoluteFocus(Game game) {
            return (game.Center + Focus);
        }
        public static Camera CreateFollower(Sprite toBeFollowed) {
            return new CameraFollower(toBeFollowed);
        }

        internal virtual void Update(Game game) {
        }

        internal void ApplyTransformations(Game game) {
            Gl.Translate(-Focus.X, -Focus.Y, 0f);
            float scale = 1f / PixelsPerUnit;
            Gl.Scale(scale, scale, scale);
        }

        public static Camera Default {
            get {
                return new Camera();
            }
        }
    }
}

