
namespace PlanitSpec.Pages
{
    public class OminiSSOPage : WebPage
    {
        public override void registerPaths()
        {
            XPath("UserNameInput", "//*[@id='userNameInput']");
            XPath("PasswordInput", "//*[@id='passwordInput']");
            XPath("SignInButton", "//*[@id='submitButton']");
        }
    }
}
