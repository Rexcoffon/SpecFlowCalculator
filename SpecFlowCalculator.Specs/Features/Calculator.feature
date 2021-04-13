Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers
Link to a feature: [Calculator](SpecFlowCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@add
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@sub
Scenario: Subtract two numbers
	Given the first number is 120
	And the second number is 70
	When the two numbers are subtracted
	Then the result should be 50

@multi
Scenario: Multiply two numbers
	Given the first number is 60
	And the second number is 2
	When the two numbers are multiplied
	Then the result should be 120

@div
Scenario: Divide two numbers
	Given the first number is <first>
	And the second number is <second>
	When the two numbers are divided
	Then the result should be <result>

	Examples:
		| first | second | result                      |
		| 120   | 2      | 60                          |
		| 120   | 0      | Impossible de diviser par 0 |

@multi N
Scenario: Multiply N numbers
	Given add operand <1>
	* add operand <2>
	* add operand <3>
	* add operand <4>
	* add operand <5>
	When the two numbers are multiplied
	Then the result should be <result>

	Examples:
		| 1   | 2  | 3 | 4  | 5 | result   |
		| 120 | 2  |   |    |   | 240      |
		| 2   | 4  | 5 | 10 |   | 400      |
		| 120 | -6 | 6 | 71 | 4 | -1226880 |