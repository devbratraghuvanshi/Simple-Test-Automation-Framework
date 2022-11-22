namespace STAF.Pages
{
    public class OminiLoginPage : Page
	{
		public OminiLoginPage(string pageName)
			: base(pageName)
		{
			base["LoginTextBox"] = new ShadowPath("#portal-login > portal-login", "#username");
			base["SignInButton"] = new ShadowPath("#portal-login > portal-login", "#eid-login-btn");
			base["PasswordTextBox"] = new ShadowPath("#portal-login > portal-login", "#password");
		}
	}
}
