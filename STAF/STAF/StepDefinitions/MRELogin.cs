using STAF.Pages;

namespace STAF.StepDefinitions
{
    [Binding]
	[Scope(Feature = "MRELogin")]
	public class MRELogin : BaseStepDefinitions
	{
		public MRELogin(ScenarioContext scenarioContext): base(scenarioContext)
		{
			page = new MreLoginPage("MRELogin");
		}
	}
}
