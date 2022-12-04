namespace STAF.PageObjectModel
{
    public interface IWebPage
    {
		public void registerPaths();
        public IPath this[string elementName] { get; set;}
    }
}
