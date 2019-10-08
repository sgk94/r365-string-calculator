using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
      public class UserInput
    {
        public string[] FormatInput(string input)
        {
            var formatted = input.Split(",");
            return formatted;
        }
    }
}