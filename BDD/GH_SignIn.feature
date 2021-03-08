Feature: GH_SignIn
	In order to utilise GitHub tools
	As a registered user of the GitHub website
	I want to be able to sign in to my account

@Login
Scenario: Invalid password - wrong password
	Given I am on the sign in
	And I have entered the login 'Shaq10'
	And I have entered the password 'wrongpassword'
	When I click the sign in button
	Then I should land on the page "https://github.com/session" where an error message is displayed

	@Login
Scenario: Forgot password
	Given I am on the sign in
	When I click the forgot password link
	Then I end up on the page containing the title "Forgot your password?"