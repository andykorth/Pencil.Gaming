using System;

using Pencil.Gaming;
using Pencil.Gaming.Audio;
using Pencil.Gaming.Graphics;
using Pencil.Gaming.MathUtils;
using Pencil.Gaming.Scripting;

namespace Pencil.Gaming.Applets {
	public abstract class PApplet : IDisposable {
		protected PApplet(AppletRequest aReq) {
			
		}

		[SupportedBrowsers(Browsers.All)]
		public abstract void Init();
		[SupportedBrowsers(Browsers.All)]
		public abstract void Dispose();
		[SupportedBrowsers(Browsers.All)]
		public abstract void Update(float time);
		[SupportedBrowsers(Browsers.All)]
		public abstract void Draw();
		[SupportedBrowsers(Browsers.All)]
		public abstract void Resize(int width, int height);

		[SupportedBrowsers(Browsers.All)]
		public void SwapBuffers() {
			throw new NotImplementedException();
		}

		[SupportedBrowsers(Browsers.All)]
		public Vector2i Size { get; set; }
		[SupportedBrowsers(Browsers.All)]
		public string PageTitle { get; set; }
		[SupportedBrowsers(Browsers.All)]
		public bool VSync { get; set; }
		[SupportedBrowsers(Browsers.All)]
		public Browsers CurrentBrowser { get; set; }
	}
}

