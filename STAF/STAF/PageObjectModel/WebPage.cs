using System.Text.RegularExpressions;

namespace STAF.PageObjectModel
{
    public abstract class WebPage: IWebPage
	{
		internal Dictionary<string, IPath> _xPaths = new Dictionary<string, IPath>();

		public string PageName;

		public IPath this[string elementName]
		{
			get
			{
				string pathKaey = this.getPathKey(elementName);
				if (_xPaths.ContainsKey(pathKaey))
				{
					return _xPaths[pathKaey];
                }
                else
                {
					throw new Exception("no such element exist on the page");
                }
			}
			set
			{
				string pathKaey = this.getPathKey(elementName);

				if (!_xPaths.ContainsKey(pathKaey))
				{
					_xPaths[pathKaey] = value;

                }else{
					throw new Exception($"an element with name {elementName} already added on the page please provide unique name");
                }
			}
		}

		public WebPage()
		{
			PageName = this.GetType().UnderlyingSystemType.Name;
			registerPaths();
		}

		private string getPathKey(string elementName)
        {
			return Regex.Replace(elementName, @"\s+", String.Empty).ToLower();
		}

		protected internal void XPath(string elementName, string xPath)
        {
			this[elementName] = new XPath(xPath);
        }

		protected internal void ShadowPath(string elementName, string xPath)
		{
			this[elementName] = new ShadowPath(xPath);
		}

		public abstract void registerPaths();
    }
}
