Feature: SpecFlowFeature5
	

@mytag
Scenario: is not a triangle
	Given the  sides are 10 10 -1
	When as the triangle side can not be a negative
	Then it ist a triangle