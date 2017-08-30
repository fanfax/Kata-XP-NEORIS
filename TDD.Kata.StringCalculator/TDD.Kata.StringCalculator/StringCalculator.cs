using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Kata.StringCalculator
{
   public class StringCalculator
    {
        public int add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                return default(int);
            }
            return int.Parse(numbers);
        }
    }
}
