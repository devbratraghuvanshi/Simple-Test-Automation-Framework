using OpenQA.Selenium;
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

		[Then("User waits for {int} second(s)")]
		public void ThenUserWaitsForSeconds(int secoonds)
		{
			Thread.Sleep(secoonds);
		}

		[Then("User close(s) the browser")]
		public void ThenUserCloseTheBrowser()
		{
			Driver.Close();
		}

		[Then("User Click on {string}")]
		public void ThenUserClickOn(string element)
		{
			IPath path = page[element];
			path.getElement().Click();
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

		[Then("User press {string} Key")]
		public void ThenUserPressKey(string keyname)
		{
			Driver.ActionsInstance.SendKeys(Keys.Enter);
		}
	}
}
