Feature: OminiLogin

User is trying to login to omini site

@OminiLogin
Scenario: User is trying to login to omini site
    Given User opens "Chrome" browser
    When User goes to url "https://qaomni.annalect.com/login"
    Then User RightClick on "LoginTextBox"
    Then User waits for 3 seconds
    Then User Click on "LoginTextBox"
    Then User types text "qa" in the "Login Text Box"
    Then User enter text "." in the "login textbox"
    Then User enter "test" in the "LoginText  Box"
    Then User Click on "SignInButton"
    Then User types text "Welcome@123" in the "PasswordTextBox"
    Then User Click on "SignInButton"
    Then User waits for 5 seconds
    Then User close the browser
