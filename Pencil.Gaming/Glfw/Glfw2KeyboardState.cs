#if USE_GLFW2
using System;
using System.Collections.Generic;

namespace Pencil.Gaming {
    public sealed class KeyboardState {
        private Dictionary<char, bool> chars = new Dictionary<char, bool>(52);
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

        public static KeyboardState GetState() {
            KeyboardState result = new KeyboardState();

            for (char ch = '0'; ch <= '9'; ++ch) {
                result.chars[ch] = Glfw.GetKey(ch);
            }
            for (char ch = 'A'; ch <= 'z'; ++ch) {
                result.chars[ch] = Glfw.GetKey(ch);
            }
            for (int i = 0; i < allKeys.Length; ++i) {
                Key k = allKeys[i];
                result.keys[k] = Glfw.GetKey(k);
            }

            return result;
        }

        public bool this[char ch] {
            get {
                return chars[ch];
            }
        }

        public bool this[Key k] {
            get {
                return keys[k];
            }
        }
    }
}
#endif
