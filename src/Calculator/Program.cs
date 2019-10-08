using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please input the numbers you wish to Add");
            var input = Console.ReadLine();
            var userInput = new UserInput();
            var finalInput = userInput.FormatInput(input);
            var compute = new ComputeAnswer();
            var result = compute.ComputeResult(finalInput);
            Console.WriteLine($"total:{result}");
        }
    }
}
