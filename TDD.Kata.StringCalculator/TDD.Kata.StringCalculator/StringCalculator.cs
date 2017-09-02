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

            List<string> stringList = new List<string>();
            int number;
            string numberString = string.Empty;

            //Separo los numeros del string
            numbers = numbers.Trim();
            foreach (char c in numbers)
            {
                try
                {
                    number = int.Parse(c.ToString());
                    numberString += number;
                }
                catch
                {
                    stringList.Add(numberString);
                    numberString = string.Empty;
                }
            }
            if (!string.IsNullOrEmpty(numberString)) stringList.Add(numberString);

            //Totaliza
            int totalizer = 0;
            foreach (String stringNumber in stringList)
            {
                number = 0;
                int.TryParse(stringNumber, out number);
                totalizer += number;
            }

            return totalizer;
        }
    }
}
