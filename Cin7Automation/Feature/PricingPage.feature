Feature: Pricing Page price display

As a customer
I want to access Cin7 pricing page
So that I can see all cin7 pricing options

Acceptance Criteria
* User can enter Cin7 website through url
* User have access to all pricing information

@Regressiontest
@Browser: Chrome
Background: 
Given I visit Cinseven website
And I can see Cinseven main logo

@Regressiontest
@Browser: Chrome
Scenario:  Verify pricing page prices

When I click on pricing page button
Then All pricing options are shown