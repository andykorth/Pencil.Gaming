#if USE_GLFW3
using System;
using System.Collections.Generic;

namespace Pencil.Gaming {
    public sealed class KeyboardState {
        private Dictionary<Key, bool> keys = new Dictionary<Key, bool>(52);
        private static Key[] allKeys;

        static KeyboardState() {
            Array allKeysa = Enum.GetValues(typeof(Key));
            allKeys = new Key[allKeysa.Length];
            for (int i = 0; i < allKeysa.Length; ++i) {
                allKeys[i] = (Key)allKeysa.GetValue(i);
            }
        }

        private KeyboardState() {
        }

        public static KeyboardState GetState(GlfwWindowPtr window) {
            KeyboardState result = new KeyboardState();

            for (int i = 0; i < allKeys.Length; ++i) {
                Key k = allKeys[i];
                result.keys[k] = Glfw.GetKey(window, k);
            }

            return result;
        }

        public bool this[Key k] {
            get {
                return keys[k];
            }
        }
    }
}
#endif
