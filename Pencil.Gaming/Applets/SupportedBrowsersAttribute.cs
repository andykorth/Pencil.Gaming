using System;

namespace Pencil.Gaming {
	[AttributeUsage(AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Property)]
	public class SupportedBrowsersAttribute : Attribute {
		public Browsers SupportedBrowsers { get; set; }

		public SupportedBrowsersAttribute(Browsers supBrow) {
			SupportedBrowsers = supBrow;
		}
	}
}

