using System;

namespace Calculator
{
    public class ComputeAnswer
    {
        public int ComputeResult(string[] input)
        {
            var result = 0;
            for(var i=0; i < input.Length; i++)
            {
                int value;
                int.TryParse(input[i], out value);
                Console.WriteLine($"value: {value}");
                result += value;
            }
            return result;
        }
    }
}