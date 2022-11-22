Feature: MRELogin

User is trying to login to MRE site

@MRELogin
Scenario: User is trying to login to MRE site
	Given User open "Chrome" browser
	When User goes to url "https://staging.onerollup.com/OMG/SelectClient.aspx?selectedClient="
	Then User types text "global\devbrat.raghuvanshi" in the "EmailTextBox"
	Then User types text "Password" in the "PasswordTextBox"
	Then User Click on "SignInButton"
	Then User waits for 10 seconds
	Then User close the browser