using System;
using Xunit;

namespace Calculator.Tests
{
    public class StepThreeTest
    {
        [Fact]
        public void TestNewlineCharacterDelimiter()
        {
            // arrange
            var input = "1\\n2,3";
            var userInput = new UserInput();
            var compute = new ComputeAnswer();
            // act
            var testInput = userInput.FormatInput(input);
            var result = compute.ComputeResult(testInput);
            // assert
            Assert.Equal(6, result);
        }
    }
}
