using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            var result = 0;
            System.Console.WriteLine("Please input the numbers you wish to Add");
            input = Console.ReadLine();
            Console.WriteLine($"user input {input}");

            var numbers = input.Split(',').ToList();

            for (var i = 0; i < numbers.Count; i++) 
            {
                int parsedResult;
                int.TryParse(numbers[i], out parsedResult);
                Console.WriteLine(parsedResult);

                result += parsedResult;
                
                Console.WriteLine($"total is {result}");
            }
        }
    }
}
