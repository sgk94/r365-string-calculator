using System;
using System.Collections.Generic;

namespace Calculator
{
    public class ComputeAnswer
    {
        public int ComputeResult(List<string> input)
       {
            var negString = new String("");
            var result = 0;
        
            for(var i=0; i < input.Count; i++)
            {
                int value;
                int.TryParse(input[i], out value);
                try
                {
                    if (value < 0)
                    {
                        negString += value + " ";
                        value = 0;
                        throw new Exception($"No negative numbers. Denied numbers: {negString}");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                result += value;
            }
            return result;
        }
    }
}