namespace STAF.Pages
{
    public abstract class Page
	{
		internal Dictionary<string, IPath> _xPaths;

		public string PageName;

		public IPath this[string key]
		{
			get
			{
				if (_xPaths.ContainsKey(key))
				{
					return _xPaths[key];
				}
				throw new Exception("no such element exist on the page");
			}
			set
			{
				_xPaths[key] = value;
			}
		}

		public Page(string pageName)
		{
			PageName = pageName;
			_xPaths = new Dictionary<string, IPath>();
		}
	}
}
