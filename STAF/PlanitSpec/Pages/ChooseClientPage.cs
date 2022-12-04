
namespace PlanitSpec.Pages
{
    public class ChooseClientPage : WebPage
    {
        public override void registerPaths()
        {
            XPath("ClientDropdown", "//ng-select");
            XPath("ClientOptionByIndex", "//ng-select//div[contains(@class,'ng-option')][OptionNumber]");
            XPath("ClientOptionByValue", "//ng-select//div[contains(@class,'ng-option')]//span[text()='OptionValue']");

        }
    }
}
