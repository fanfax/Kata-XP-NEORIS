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

            int totalizer = 0;
            String[] arrayString = numbers.Split(',');
            int number;

            foreach (String stringNumber in arrayString)
            {
                number = 0;
                int.TryParse(stringNumber, out number);
                totalizer += number;
            }

            return totalizer;
        }
    }
}
