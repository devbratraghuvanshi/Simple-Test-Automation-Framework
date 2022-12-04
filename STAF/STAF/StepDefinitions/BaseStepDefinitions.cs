using OpenQA.Selenium;
using STAF.PageObjectModel;

namespace STAF.StepDefinitions
{
    public partial class BaseStepDefinitions
	{
		public readonly ScenarioContext _scenarioContext;

		public IWebPage page;

		public BaseStepDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[When("User/user Open {string} browser")]
		public void WhenUserOpenBrowser(string type)
		{
			if (type == Browser.Chrome.ToString())
			{
				Driver.Initialize(Browser.Chrome);
			}
		}

		[Given("User/user open(s) {string} browser")]
		public void GivenUserOpensBrowser(string type)
		{
			if (type.ToLower() == Browser.Chrome.ToString().ToLower())
			{
				Driver.Initialize(Browser.Chrome);
			}
		}

		[Then("User/user (goes to)/(navigates/navigate to)/open(s) url/site {string}( in the browser)")]
		[When("User/user (goes to)/(navigates/navigate to)/open(s) url/site {string}( in the browser)")]
		public void ThenUserGoesToUrl(string url)
		{
			Driver.GoToUrl(url);
		}

		[Then("User/user waits for {int} second(s)")]
		public void ThenUserWaitsForSeconds(int sec)
		{
			//Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(secoonds);
			//Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(sec);
			//WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
			//Thread.Sleep(5);
			Driver.Wait(sec);
		}

		[Then("User/user close(s) the browser")]
		public void ThenUserCloseTheBrowser()
		{
			Driver.Close();
		}

		[Then("User/user {UserAction} on {string}")]
		public void ThenUserOn(UserAction action, string element)
		{
			IPath path = page[element];
			var webEle= path.GetElement();
            switch (action)
            {
                case UserAction.Click:
					webEle.Click();
					break;
                case UserAction.RightClick:
					Driver.RightClick(webEle);
					break;
                case UserAction.ScrollDown:
                    break;
                case UserAction.ScrollUp:
                    break;
                case UserAction.DoubleClick:
                    break;
                default:
                    break;
            }
		}

		[Then("User/user {UserAction} {int} px")]
		public void ThenUserScrollDownPx(UserAction action, int scrollPixel)
		{
            switch (action)
            {
                case UserAction.ScrollDown:
					//Driver.Scroll(0, scrollPixel);
                    break;
                case UserAction.ScrollUp:
					//Driver.Scroll(0, -1*scrollPixel);
					break;
                default:
                    break;
            }
		}

		[Then("User/user {UserAction} to the {string}")]
		public void ThenUserScrollDownTo(UserAction action, string element)
		{
			
		}


		[Then("User/user {UserAction} to the {PageDirection} of Page")]
		public void ThenUserScrollToTheTopOfPage(UserAction action, PageDirection direction)
		{
			if(action == UserAction.Scroll)
            {
                if (direction == PageDirection.Top)
                {

                }
				if (direction == PageDirection.Bottom)
				{

				}

			}
		}


		[Then("User/user Click on {string} of {string} page")]
		public void ThenUserClickOnOf(string element, string page)
		{
		}

		[Then("User/user Right click on {string}")]
		public void ThenUserRightClickOn(string element)
		{
		}

		[Then("User/user scroll to bottom of the page")]
		public void ThenUserScrollToBottomOfThePage()
		{
		}

		[Then("User/user scroll to {string} of the page")]
		public void ThenUserScrollToOfThePage(string element)
		{
		}

		[Then("User/user Scroll(s) {string} by {int} px")]
		public void ThenUserScrollSPx(string up, int px)
		{

		}

		[Then("User/user clears the {string}")]
		public void ThenUserClearsThe(string element)
		{
		}

		
		public void ThenUserSetTextToThe(string textToset, string element)
		{
		}

		[Then("User/user set(s)/type(s)/enter(s) text {string} in/(into) the {string}")]
		public void ThenUserTypesTextInTheTextBox(string textToType, string element)
		{
			IWebElement element2 = page[element].GetElement();
			if (element2 != null)
			{
				element2.SendKeys(textToType);
			}
		}

		[Then("User/user selects {int} st/nd/rd/th item of the {string}")]
		public void ThenUserSelectsStItemOfThe(int itemNumber, string element)
		{
		}

		[Then("User/user validate(s)/confirm(s)/verify/verifie(s) text {string} exist on the Page")]
		public void ThenUserValidateTextExistOnThePage(string validationString)
		{
			//to Complete
		}

		[Then("User/user validate(s)/confirm(s)/verify/verifie(s) text {string} exist on/in the {string}")]
		public void ThenUserValidateTextExistOnThePage(string textToVerify, string elementName )
		{
			//to Complete
		}


		[Then("User/user press {string} Key")]
		public void ThenUserPressKey(string keyname)
		{
			Driver.ActionsInstance.SendKeys(Keys.Enter);
		}
	}
}
