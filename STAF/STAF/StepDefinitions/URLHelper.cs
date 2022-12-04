using NUnit.Framework;

namespace STAF.StepDefinitions
{
    public partial class BaseStepDefinitions
    {
		[Then("User/user validate(s)/confirm(s)/verify/verifie(s) (that current url is)/(url to be)/(current url to be) {string}")]
		public void ThenUserValidateThatCurrentUrlIs(string urlToMatch)
		{
			var cUrl = Driver.getCurrentUrl();
			Assert.AreEqual(cUrl, urlToMatch);
		}

		[Then("User/user validate(s)/confirm(s)/verify/verifie(s) that current url contain(s) {string}")]
		public void ThenUserValidateThatCurrentUrlContains(string urlPartMatch)
		{
			var cUrl = Driver.getCurrentUrl();
			Assert.That(cUrl, Does.Contain(urlPartMatch));
		}


		[Then("User/user validate(s)/confirm(s)/verify/verifie(s) (that current domain is)/(domain to be)/(current domain to be) {string}")]
		public void ThenUserValidateThatCurrentDomainIs(string domainNameToMatch)
		{
			var cDomainName = Driver.getCurrentDomain();
			Assert.AreEqual(cDomainName, domainNameToMatch);
		}


	}

}
