Feature: Login

check if Login functionality works

@tag1
Scenario: Login User as Administrator
	Given I navigate to the Application
	And I click on the Login link 
	And I enter username and password
	| UserName | Password |
	| admin    | password |
	When I click Login
	Then I should see User logged in the application
