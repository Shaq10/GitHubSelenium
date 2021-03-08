Feature: GH_Home
	In order to use GitHub
	As a user or potential user
	I want to be able to navigate to the correct page

@Home
Scenario: Sign In link takes me to sign in page
	Given I am on the home page
	When I click the sign in link 
	Then I should land on the page which contains the title "Sign in to GitHub"

	@Home
Scenario: Sign Up link takes me to sign up page
	Given I am on the home page
	When I click the sign up link 
	Then I should land on the page which contains the title "Join GitHub"

	@Home
Scenario: Green Sign Up button takes me to sign up page
	Given I am on the home page
	When I click the sign up button
	Then I should land on the page which contains the title "Join GitHub"

	@Home
Scenario: Search bar dropdown contains items related to term
	Given I am on the home page
	When I enter the term <input1> in the search bar
	Then The DropDown should contain term <result>
	Examples:
	| input1  | result  |
	| Shaq10  | Shaq10  |
	| nishman | nishman |

@Home
Scenario: Results of search displayed on results page
	Given I am on the home page
	When I search for the term 'Shaq10'
	And Click the drop down
	Then I should land on the results page with the URL "https://github.com/search?q=Shaq10"