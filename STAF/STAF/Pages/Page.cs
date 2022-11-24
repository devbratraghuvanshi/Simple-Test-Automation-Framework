using System.Text.RegularExpressions;

namespace STAF.Pages
{
    public abstract class Page
	{
		internal Dictionary<string, IPath> _xPaths;

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

		public Page(string pageName)
		{
			PageName = pageName;
			_xPaths = new Dictionary<string, IPath>();
		}

		private string getPathKey(string elementName)
        {
			return Regex.Replace(elementName, @"\s+", String.Empty).ToLower();
		}
	}
}
