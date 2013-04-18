using System;

namespace Pencil.Gaming {
	[Flags]
	public enum Browsers {
		Firefox = 0x01,
		Chrome = 0x02,
		Opera = 0x04,
		Safari = 0x08,
		InternetExplorer = 0xF0,
		All = Browsers.Firefox | Browsers.Chrome | Browsers.Opera | Browsers.Safari | Browsers.InternetExplorer,
	}
}

