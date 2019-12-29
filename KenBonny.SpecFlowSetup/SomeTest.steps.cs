using TechTalk.SpecFlow;
using Xunit;

namespace KenBonny.SpecFlowSetup
{
    [Binding]
    [Scope(Feature = "Some test")]
    public class SomeTestSteps
    {
        private int _first;
        private int _second;
        private int _result;

        [Given(@"I have a number (.*)")]
        public void GivenIHaveANumber(int first) => _first = first;

        [Given(@"I have another number (.*)")]
        public void GivenIHaveAnotherNumber(int second) => _second = second;

        [When(@"I add them up")]
        public void WhenIAddThemUp() => _result = Sum();

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected) => Assert.Equal(expected, _result);

        private int Sum() => _first + _second;
    }
}