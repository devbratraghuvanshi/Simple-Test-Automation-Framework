using PlanitSpec.Pages;

namespace PlanitSpec.StepDefinitions
{
    [Binding]
    [Scope(Feature = "PlanitLogin")]
    public class PlanitLoginStepDefinition : BaseStepDefinitions
    {
        public PlanitLoginStepDefinition(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            page = new OminiSSOPage();
        }
    }
}
