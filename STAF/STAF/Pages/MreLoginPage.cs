using STAF.PageObjectModel;

namespace STAF.Pages
{

    public class MreLoginPage : WebPage
	{
        public override void registerPaths()
        {
			XPath("EmailTextBox", "//*[@id='userNameInput']");
			XPath("PasswordTextBox", "//*[@id='passwordInput']");
			XPath("SignInButton", "//*[@id='submitButton']");
		}
    }
}
