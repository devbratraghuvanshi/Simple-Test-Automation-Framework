using STAF.PageObjectModel;

namespace STAF.StepDefinitions
{
	public partial class BaseStepDefinitions
	{
        [Then(@"User selects dropdown {string} {string} from {string}")]
        public void ThenUserSelectsFromDropdown(string replaceToken, string optionValue, string optionElement)
        {
            IPath path = page[optionElement];
            var webEle = path.GetElementByUpdatedPath(replaceToken, optionValue);
            webEle.Click();
        }

        [Then(@"User selects dropdown {string} {int} from {string}")]
        public void ThenUserSelectsStItemFrom(string replaceToken, int optionIndex, string optionElement)
        {
            IPath path = page[optionElement];
            var webEle = path.GetElementByUpdatedPath(replaceToken, optionIndex.ToString());
            webEle.Click();
        }

        [Then(@"User selects {int} st/nd/rd/th dropdown {string} from {string}")]
        public void ThenUserSelectsThDropdownFrom(int optionIndex, string replaceToken, string optionElement)
        {
            IPath path = page[optionElement];
            var webEle = path.GetElementByUpdatedPath(replaceToken, optionIndex.ToString());
            webEle.Click();
        }


    }



}
