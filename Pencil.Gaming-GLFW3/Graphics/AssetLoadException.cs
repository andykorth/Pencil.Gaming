using System;

namespace Pencil.Gaming.Graphics {
    public class AssetLoadException : Exception {
        public AssetLoadException(string asset, string reason) : base("Failed to load asset: " + asset.ToString() + ". Reason: " + reason + ".") {
        }
    }
}

