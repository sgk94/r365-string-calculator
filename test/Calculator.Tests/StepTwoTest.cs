using System;
using Xunit;

namespace Calculator.Tests
{
    public class StepTwoTest
    {
        [Fact]
        public void TestRemoveMaxConstraintForNums()
        {
            // arrange
            var input = "1,2,3,4,5,6,7,8,9,10,11,12";
            var userInput = new UserInput();
            var compute = new ComputeAnswer();
            // act
            var testInput = userInput.FormatInput(input);
            var result = compute.ComputeResult(testInput);
            // assert
            AssemblyLoadEventArgs.Equals(78, result);
        }
    }
}
