using OpenQA.Selenium;

namespace STAF.Pages
{
    public class XPath : IPath
	{
		private string _Path { get; }

		public XPath(string path)
		{
			_Path = path;
		}

		public IWebElement getElement()
		{
			return Driver.FindElement(By.XPath(_Path), 10);
		}
	}
}
