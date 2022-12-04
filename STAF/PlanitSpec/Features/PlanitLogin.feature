Feature: PlanitLogin

A short summary of the feature

@PlanitLogin
Scenario: User is trying to login into Planit
	Given User open "chrome" browser
	When User opens url "https://staging.onerollup.com/MRE.Client.QA"
	Then User waits for 5 seconds
	Then User is redirected to "OminiSSOPage" page
	Then User validate that current domain is "omgsso.oneomg.com"
	Then User validate that current url is "https://omgsso.oneomg.com/adfs/ls/IdpInitiatedSignon.aspx?LoginToRp=brandfxstaging"
	Then User is on "OminiSSOPage" page
	Then User types text "global\devbrat.raghuvanshi" in the "UserNameInput"
	Then User waits for 1 seconds
	Then User types text "P@ssw0rd" in the "PasswordInput"
	Then User waits for 1 seconds
	Then User Click on "SignInButton"
	Then User waits for 1 seconds
	Then User is redirected to "ChooseClientPage" page
	Then User validate that current domain is "staging.onerollup.com"
	Then User validate that current url contains "https://staging.onerollup.com"
	Then User Click on "ClientDropdown"
	#Then User selects dropdown "OptionValue" "AliExpress" from "ClientOptionByValue"
	Then User selects 2 st dropdown "OptionNumber" from "ClientOptionByIndex"
	#Then User selects dropdown "OptionNumber" 2 from "ClientOptionByIndex"
	Then User waits for 10 seconds
	Then User closes the browser
