Feature: LogonInfo
	

@mytag
Scenario: crete correctly a user and a password by the rules 
	Given the user name is  "Anastasiia" 
	And the password is "11AAaaa"
	When the password is validated
	Then it returns true 