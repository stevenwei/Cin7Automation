Feature: Login

As a customer
I want to login to cin7 website
So that I can access my account information

Acceptance Criteria
* User entering correct password can login
* User entering wrong password cannot login

@Regressiontest
@Browser: Chrome
Scenario Outline:  Verify login functionality

Given I visit Cin7 website
And I go to login page
When I enter my <username> and <password>
And I click login button
Then I can successfully login

Examples: 
| username | password |
| abc      | 123      |
| test     | test     |