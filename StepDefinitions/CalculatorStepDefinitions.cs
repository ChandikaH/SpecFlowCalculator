using System.ComponentModel;
using FluentAssertions;
using NUnit.Framework;

namespace SpecFlowCalculator.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private int _result = 0;
        private readonly Calculator _calculator = new Calculator();

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When(@"the two numbers are substracted")]
        public void WhenTheTwoNumbersAreSubstracted()
        {
            _result = _calculator.Substract();
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiplication();
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _calculator.Division();
        }


        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
            Assert.That(_result.Equals(result));
        }

        [Then(@"Console should print (.*)")]
        public void ThenConsoleShouldPrint(int result)
        {
            Console.WriteLine("Expected: " + result + " vs Actual: " + _result);
        }

    }
}
