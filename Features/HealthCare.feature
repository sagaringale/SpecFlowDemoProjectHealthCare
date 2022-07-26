Feature: Health Care
	


Scenario Outline: Verify Login Functionality
		Given I open the Health Care home page
		When Enter username the '<username>' element
		And Enter the '<password>' element
		And I click on sign in button
		
		Examples:
		| username        | passward |
		| admin@gmail.com | admin123 |


Scenario: Verify Search Member Functionality
		Given I click on Search Member Tab
		When I enter the Account Number
		And I Click on Search Button
		And I Verify Member List Details
		#And I Click on View Icon 
		#Then Verify Personal Details 
		#And Verify Address Details








