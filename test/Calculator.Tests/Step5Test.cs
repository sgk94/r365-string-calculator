using System;
using Xunit;

namespace Calculator.Tests
{
    public class Step5Test
    {
        [Fact]
        public void TestNewlineCharacterDelimiter()
        {
            // arrange
            // Console.WriteLine("Input 1\\n2,3");
            var input = "2,10001,6";
            var userInput = new UserInput();
            var compute = new ComputeAnswer();
            // act
            var testInput = userInput.FormatInput(input);
            var result = compute.ComputeResult(testInput);
            // assert
            Assert.Equal(8, result);
        }
    }
}
