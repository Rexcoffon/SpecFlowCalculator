using TechTalk.SpecFlow;
using FluentAssertions;
using System.Collections.Generic;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();

        private string _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.Operands.Add(number);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.Operands.Add(number);
        }

        [Given(@"add operand (.*)")]
        public void GivenAddOperand(int? number)
        {
            if (number.HasValue)
            {
                _calculator.Operands.Add(number.Value);
            }            
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
            _calculator.Operands = new List<int>();
            int value = 0;
            if (int.TryParse(_result, out value))
            {
                _calculator.Operands.Add(value);
            }
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumberAreSubtracted()
        {
            _result = _calculator.Sub();
            _calculator.Operands = new List<int>();
            int value = 0;
            if (int.TryParse(_result, out value))
            {
                _calculator.Operands.Add(value);
            }
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multi();
            _calculator.Operands = new List<int>();
            int value = 0;
            if(int.TryParse(_result, out value))
            {
                _calculator.Operands.Add(value);
            }           
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _calculator.Div();
            _calculator.Operands = new List<int>();
            int value = 0;
            if (int.TryParse(_result, out value))
            {
                _calculator.Operands.Add(value);
            }
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            _result.Should().Be(result);
        }
    }
}
