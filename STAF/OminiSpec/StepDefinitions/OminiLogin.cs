
namespace OminiSpec.StepDefinitions
{
	[Binding]
	[Scope(Feature = "OminiLogin")]
	public class OminiLogin : BaseStepDefinitions
	{
		public OminiLogin(ScenarioContext scenarioContext)
			: base(scenarioContext)
		{
			page = new OminiLoginPage();
		}
	}
}
