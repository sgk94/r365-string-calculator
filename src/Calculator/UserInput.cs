using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
      public class UserInput
    {
        public List<string> FormatInput(string input)
        {
            var newInput = input.Replace("\\n", ",");
            var formatted = newInput.Split(',').ToList();
            
            return formatted;
        }
    }
}