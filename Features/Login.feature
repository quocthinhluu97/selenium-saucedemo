Feature: Login to Sauce Demo

Scenario: Successful login with valid credentials
	Given I am on the Sauce Demo login page
	When I enter login credentials with
	| Username      | Password     |
	| standard_user | secret_sauce |
	And I click on the login button
	Then I should be redirected to the inventory page