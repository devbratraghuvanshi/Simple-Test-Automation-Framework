namespace STAF.StepDefinitions
{
	[Binding]
	[Scope(Feature = "STAFExample")]
	public class STAFExample : BaseStepDefinitions
	{
		public STAFExample(ScenarioContext scenarioContext)
			: base(scenarioContext)
		{
		}

		[Given("User is Frankenstein and he wants to create the creature")]
		public void GivenUserIsFrankensteinAndHeWantsToCreateTheCreature()
		{
		}
	}
}
