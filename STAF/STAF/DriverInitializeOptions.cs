using OpenQA.Selenium;
using System.Drawing;

namespace STAF
{
    public class DriverInitializeOptions
	{
		public Browser BrowserType { get; set; }

		public Size? WindowSize { get; set; }

		public DriverOptions BrowserOptions { get; set; }
	}
}
