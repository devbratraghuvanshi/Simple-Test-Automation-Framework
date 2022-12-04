using OpenQA.Selenium;

namespace STAF.PageObjectModel
{
    public class XPath : IPath
	{
		private string _Path { get; set; }

		public XPath(string path)
		{
			_Path = path;
		}

		public IWebElement GetElement()
		{
			return Driver.FindElement(By.XPath(_Path), 10);
		}

		public IWebElement WaitForElementToAppear(int Sec)
		{
			return Driver.FindElement(By.XPath(_Path), Sec);
		}

		public IWebElement GetElementByUpdatedPath(string replaceToken, string valueToReplace)
        {
			_Path = _Path.Replace(replaceToken, valueToReplace);
			return GetElement();
		}
    }
}
