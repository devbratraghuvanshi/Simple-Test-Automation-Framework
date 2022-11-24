using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using STAF.Pages;

namespace STAF.StepDefinitions
{
    public class BaseStepDefinitions
	{
		public readonly ScenarioContext _scenarioContext;

		public Page page;

		public BaseStepDefinitions(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[When("User Open {string} browser")]
		public void WhenUserOpenBrowser(string type)
		{
			if (type == Browser.Chrome.ToString())
			{
				Driver.Initialize(Browser.Chrome);
			}
		}

		[Given("User open(s) {string} browser")]
		public void GivenUserOpensBrowser(string type)
		{
			if (type == Browser.Chrome.ToString())
			{
				Driver.Initialize(Browser.Chrome);
			}
		}

		[Then("User goes to url {string}")]
		public void ThenUserGoesToUrl(string url)
		{
			url.GoToUrl();
		}

		[When("User goes to url {string}")]
		public void WhenUserGoesToUrl(string url)
		{
			url.GoToUrl();
		}

		[Then("User Validate that current url is {string}")]
		public void ThenUserValidateThatCurrentUrlIs(string urlToMatch)
		{
			var cUrl = Driver.getCurrentUre();
			Assert.AreEqual(cUrl, urlToMatch);
		}


		[Then("User waits for {int} second(s)")]
		public void ThenUserWaitsForSeconds(int sec)
		{
			//Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(secoonds);
			//Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(sec);
			//WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
			//Thread.Sleep(5);
			Driver.Wait(sec);
		}

		[Then("User close(s) the browser")]
		public void ThenUserCloseTheBrowser()
		{
			Driver.Close();
		}

		//[Then("User Click on {string}")]
		//public void ThenUserClickOn(string element)
		//{
		//	IPath path = page[element];
		//	path.getElement().Click();
		//}
		[Then("User {UserAction} on {string}")]
		public void ThenUserOn(UserAction action, string element)
		{
			IPath path = page[element];
			var webEle= path.getElement();
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

		[Then("User {UserAction} {int} px")]
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

		[Then("User {UserAction} to {string}")]
		public void ThenUserScrollDownTo(UserAction action, string element)
		{
			
		}


		[Then("User {UserAction} to the {PageDirection} of Page")]
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


		[Then("User Click on {string} of {string} page")]
		public void ThenUserClickOnOf(string element, string page)
		{
		}

		[Then("User Right click on {string}")]
		public void ThenUserRightClickOn(string element)
		{
		}

		[Then("User scroll to bottom of the page")]
		public void ThenUserScrollToBottomOfThePage()
		{
		}

		[Then("User scroll to {string} of the page")]
		public void ThenUserScrollToOfThePage(string element)
		{
		}

		[Then("User Scroll(s) {string} by {int} px")]
		public void ThenUserScrollSPx(string up, int px)
		{

		}

		[Then("User clears the {string}")]
		public void ThenUserClearsThe(string element)
		{
		}

		[Then("User set(s) text {string} to the {string}")]
		public void ThenUserSetTextToThe(string textToset, string element)
		{
		}

		[Then("User enter(s) {string} in the {string}")]
		[Then("User enter(s) text {string} in the {string}")]
		[Then("User type(s) text {string} in the {string}")]
		public void ThenUserTypesTextInThe(string textToType, string element)
		{
			IWebElement element2 = page[element].getElement();
			if (element2 != null)
			{
				element2.SendKeys(textToType);
			}
		}

		[Then("User selects {int} st/nd/rd/th item of the {string}")]
		public void ThenUserSelectsStItemOfThe(int itemNumber, string element)
		{
		}

		[Then("User Validate(s)/validate(s)/Confirm(s)/confirm(s)/Verify/verify/Verifie(s)/verifie(s) text {string} exist on the Page")]
		public void ThenUserValidateTextExistOnThePage(string asd)
		{
			//to Complete
		}

		[Then("User Validate(s)/validate(s)/Confirm(s)/confirm(s)/Verify/verify/Verifie(s)/verifie(s) text {string} exist on/in the {string}")]
		public void ThenUserValidateTextExistOnThePage(string textToVerify, string elementName )
		{
			//to Complete
		}


		[Then("User press {string} Key")]
		public void ThenUserPressKey(string keyname)
		{
			Driver.ActionsInstance.SendKeys(Keys.Enter);
		}
	}
}
