namespace STAF.Pages
{

    public class MreLoginPage : Page
	{
		public MreLoginPage(string pageName): base(pageName)
		{
			base["EmailTextBox"] = new XPath("//*[@id='userNameInput']");
			base["PasswordTextBox"] = new XPath("//*[@id='passwordInput']");
			base["SignInButton"] = new XPath("//*[@id='submitButton']");
		}
	}
}
