using System;

namespace Pencil.Quick2D {
    internal class CameraFollower : Camera {
        private Sprite toBeFollowed;

        protected internal override Pencil.Gaming.MathUtils.Vector2 FocusVirt {
            get {
                return focusVirt;
            }
            set {
                throw new InvalidOperationException("Cannot change focus of follower camera");
            }
        }

        public CameraFollower(Sprite spriteToFollow) {
            toBeFollowed = spriteToFollow;
        }

        internal override void Update(Game game) {
            focusVirt = toBeFollowed.Center / PixelsPerUnit - game.Center;
        }
    }
}

