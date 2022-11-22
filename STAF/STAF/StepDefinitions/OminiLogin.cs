using STAF.Pages;

namespace STAF.StepDefinitions
{
    [Binding]
	[Scope(Feature = "OminiLogin")]
	public class OminiLogin : BaseStepDefinitions
	{
		public OminiLogin(ScenarioContext scenarioContext)
			: base(scenarioContext)
		{
			page = new OminiLoginPage("OminiLogin");
		}
	}
}
