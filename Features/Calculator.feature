Feature: Calculator related functions
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
This scenario explains about adding 2 numbers from the calculator
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120
	And Console should print 120

@mytag
Scenario: Substract two numbers
This scenario explains about substracted 2 numbers from the calculator
	Given the first number is 70
	And the second number is 50
	When the two numbers are substracted
	Then the result should be 20
	And Console should print 20

@mytag
Scenario: Multiply two numbers
This scenario explains about multiplied 2 numbers from the calculator
	Given the first number is 10
	And the second number is 30
	When the two numbers are multiplied
	Then the result should be 300
	And Console should print 300

@mytag
Scenario Outline: Divide two numbers
This scenario explains about divided 2 numbers from the calculator
	Given the first number is 100
	And the second number is 2
	When the two numbers are divided
	Then the result should be 50
	And Console should print 50