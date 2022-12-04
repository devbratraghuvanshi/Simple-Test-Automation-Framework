
namespace OminiSpec.Pages
{
	public class OminiLoginPage : WebPage
	{
        public override void registerPaths()
        {
			this["LoginTextBox"] = new ShadowPath("#portal-login > portal-login", "#username");
			this["SignInButton"] = new ShadowPath("#portal-login > portal-login", "#eid-login-btn");
			this["PasswordTextBox"] = new ShadowPath("#portal-login > portal-login", "#password");
		}
    }
}
