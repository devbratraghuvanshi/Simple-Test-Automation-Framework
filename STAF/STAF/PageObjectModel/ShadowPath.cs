using OpenQA.Selenium;

namespace STAF.PageObjectModel
{
    public class ShadowPath : IPath
	{
		public List<string> Selectors = new List<string>();

		public ShadowPath(params string[] args)
		{
			foreach (string item in args)
			{
				Selectors.Add(item);
			}
		}

		public IWebElement GetElement()
		{
			IWebElement result = null;
			ISearchContext shadowRoot = null;
			for (int i = 0; i < Selectors.Count; i++)
			{
				if (i == 0)
				{
					shadowRoot = GetShadowRoot(Selectors[0]);
					continue;
				}
				if (Selectors.Count - 1 == i)
				{
					result = GetElement(shadowRoot, Selectors[i]);
					break;
				}
				shadowRoot = GetChildShadowRoot(shadowRoot, Selectors[i]);
			}
			return result;
		}

		private static ISearchContext GetShadowRoot(string selector)
		{
			IWebElement val = Driver.FindElement(By.CssSelector(selector), 10);
			return val.GetShadowRoot();
		}

		private static ISearchContext GetChildShadowRoot(ISearchContext shadowRoot, string selector)
		{
			IWebElement val = shadowRoot.FindElement(By.CssSelector(selector));
			return val.GetShadowRoot();
		}

		private static IWebElement GetElement(ISearchContext shadowRoot, string selector)
		{
			return shadowRoot.FindElement(By.CssSelector(selector));
		}

        public IWebElement GetElementByUpdatedPath(string replaceToken, string valueToReplace)
        {
			// do the replace logic
			return GetElement();

		}
    }
}
