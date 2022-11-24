using STAF.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAF.StepDefinitions
{
    [Binding]
    [Scope(Feature = "OminiLoginCheck")]
    public class OminiLoginCheck : BaseStepDefinitions
    {
        public OminiLoginCheck(ScenarioContext scenarioContext) : base(scenarioContext)
        {
            page = new OminiLoginPage("OminiLogin");
        }
    }
}
