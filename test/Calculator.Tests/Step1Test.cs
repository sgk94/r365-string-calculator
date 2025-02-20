using System;
using Xunit;

namespace Calculator.Tests
{
    public class Step1Test
    {
        [Fact]
        public void TestReturn20()
        {
            // arrange
            var input = "20";
            var userInput = new UserInput();
            var compute = new ComputeAnswer();
            // act
            var testInput = userInput.FormatInput(input);
            var result = compute.ComputeResult(testInput);
            // assert
            Assert.Equal(20, result);
        }
        [Fact]
        public void TestReturn5001()
        {
            // arrange
            var input = "1,5000";
            var userInput = new UserInput();
            var compute = new ComputeAnswer();
            // act
            var testInput = userInput.FormatInput(input);
            var result = compute.ComputeResult(testInput);
            // assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void TestReturn1()
        {
            // arrange
            var input = "4,-3";
            var userInput = new UserInput();
            var compute = new ComputeAnswer();
            // act
            var testInput = userInput.FormatInput(input);
            var result = compute.ComputeResult(testInput);
            // assert
            Assert.Equal(4, result);
        }
        [Fact]
        public void TestReturnEmptyInputOrMissingNumAs0()
        {
            // arrange
            var input = "";
            var userInput = new UserInput();
            var compute = new ComputeAnswer();
            // act
            var testInput = userInput.FormatInput(input);
            var result = compute.ComputeResult(testInput);
            // assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void TestInvalidNumbersConvertedTo0()
        {
            // arrange
            var input = "5,tytyt";
            var userInput = new UserInput();
            var compute = new ComputeAnswer();
            // act
            var testInput = userInput.FormatInput(input);
            var result = compute.ComputeResult(testInput);
            // assert
            Assert.Equal(5, result);
        }
    }
}
