using OpenQA.Selenium;

namespace STAF.PageObjectModel
{
    public interface IPath
	{
		IWebElement GetElement();

		IWebElement GetElementByUpdatedPath(string replaceToken, string valueToReplace);
	}
}
