Feature: Health Care
	


Scenario Outline: 1 Verify Login Functionality
		Given I open the Health Care home page
		When Enter username the '<username>' element
		And Enter the '<password>' element
		And I click on sign in button
		
		Examples:
		| username        | passward |
		| admin@gmail.com | admin123 |


Scenario: 2 Search enrolled member and verify enrollment information
		Given I Login Application 
		Given I click on Search Member Tab
		And I Enter First Name which in enrolled for the given Account Number
		And I Enter Last Name which in enrolled for the given Account Number
		And I Enter contact no which in enrolled for the given Account Number
		And I Click on Search button



Scenario: 3 Search member and that is not enrolled.
		Given I Login Application
		#When I Enter Enrolled No which in not Account Number
		And I Enter First Name which in not enrolled for the given Account Number
		And I Enter Last Name which in not enrolled for the given Account Number
		And I Enter contact no which in not enrolled for the given Account Number
		And I Click on Search Validate button


Scenario: 4 Enroll new member in healthcare plan
		Given I Login Application
		Given I Navigate to the member registration page
		When I Fill all fields in Personal Details
		And I Fill all fields in contact details
		#And I Fill all  fields in Address details
		#And I Click on register button



Scenario: 5 Amend demographic details for the enrolled member
	   Given I Login Application
	   Given I click on Search Member Tab
	   When I Enter the valid details to search a member
	   And I Click on search button
	   And I Click on edit icon in member  search result grid under Action column




