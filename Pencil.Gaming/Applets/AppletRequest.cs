using System;

namespace Pencil.Gaming {
	public class AppletRequest {
		public Browsers CurrentBrowser { get; internal set; }
		public int Width { get; internal set; }
		public int Height { get; internal set; }
		public string[] CmdArgs { get; internal set; }
		public string WebsiteUri { get; internal set; }
	}
}
