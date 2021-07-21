Feature: CustomReplacer


@notEmpty
Scenario: Replace a selected letter by a number
	Given the char string "Hello World"
	And the letter that will be replaced is "o"
	When the letter o will be replaced in every word 
	Then it returns "Hell1 W2rld"


	

