using OpenQA.Selenium;

namespace STAF.Pages
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

		public IWebElement getElement()
		{
			IWebElement result = null;
			ISearchContext shadowRoot = null;
			for (int i = 0; i < Selectors.Count; i++)
			{
				if (i == 0)
				{
					shadowRoot = getShadowRoot(Selectors[0]);
					continue;
				}
				if (Selectors.Count - 1 == i)
				{
					result = GetElement(shadowRoot, Selectors[i]);
					break;
				}
				shadowRoot = getChildShadowRoot(shadowRoot, Selectors[i]);
			}
			return result;
		}

		public ISearchContext getShadowRoot(string selector)
		{
			IWebElement val = Driver.FindElement(By.CssSelector(selector), 10);
			return val.GetShadowRoot();
		}

		public ISearchContext getChildShadowRoot(ISearchContext shadowRoot, string selector)
		{
			IWebElement val = shadowRoot.FindElement(By.CssSelector(selector));
			return val.GetShadowRoot();
		}

		public IWebElement GetElement(ISearchContext shadowRoot, string selector)
		{
			return shadowRoot.FindElement(By.CssSelector(selector));
		}
	}
}
