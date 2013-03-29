using System;
using Pencil.Gaming.Audio;
using Pencil.Gaming.MathUtils;

namespace Pencil.Gaming.Audio {
    public class Listener {
        private static Listener current = null;

        public Listener(Vector3 orientation, Vector3 position, Vector3 velocity, float efxMetersPerUnit, float gain) {
            Orientation = orientation;
            Position = position;
            Velocity = velocity;
            EfxMetersPerUnit = efxMetersPerUnit;
            Gain = gain;
        }

        public Vector3 Orientation;
        public Vector3 Position;
        public Vector3 Velocity;
        public float EfxMetersPerUnit;
        public float Gain;

        public virtual void MakeCurrent() {
            if (current != this) {
                Al.Listener(AlListener3f.Position, Position.X, Position.Y, Position.Z);
                Al.Listener(AlListener3f.Velocity, Velocity.X, Velocity.Y, Velocity.Z);
                Al.Listener(AlListenerf.EfxMetersPerUnit, EfxMetersPerUnit);
                Al.Listener(AlListenerf.Gain, Gain);
                Al.Listener(AlListenerfv.Orientation, new float[] { Orientation.X, Orientation.Y, Orientation.Z });
                current = this;
            }
        }
    }
}

