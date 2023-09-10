Feature: Add an item to cart and checkout
	
Scenario: 1. Successful login with valid credentials
	Given I am on the Sauce Demo login page
	When I enter login credentials with
	| Username      | Password     |
	| standard_user | secret_sauce |
	And I click on the login button
	Then I should be redirected to the inventory page
	
Scenario: 2. Add an item to cart
	Given I am on the inventory page
	When I add 'Sauce Labs Backpack' to cart
	And I go to the cart page 
	Then I can see 'Sauce Labs Backpack' item

Scenario: 3. Proceed to checkout step one
	Given I am on the cart page
	When I click on the checkout button
	Then I got navigated to the checkout step one page
	
Scenario: 4. Proceed to checkout step two
	Given I am on the checkout step one page
	When I fill the checkout information form with
	| First Name | Last Name | Zip Code |
	| Thinh      | Luu       | 70       |
 	And I click on the continue button
 	Then I got navigated to the checkout step two page

 Scenario: 5. Complete checkout	
 	Given I am on the checkout step two page
 	When I click on the finish button
	Then I got navigated to the checkout complete page
	And I can see the 'Thank you for your order!' text