using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Kata.StringCalculator
{
    public class StringCalculator
    {
        List<char> separators = new List<char>();
        List<int> negativeNumbers = new List<int>();

        public int add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers))
            {
                return default(int);
            }

            this.InitializeSeparators(numbers);

            String[] arrayString = numbers.Split(separators.ToArray());

            int totalizer = 0;
            int number;
            foreach (String stringNumber in arrayString)
            {
                number = 0;
                int.TryParse(stringNumber, out number);
                totalizer += number;

                this.SaveIfNegative(number);
            }

            this.CheckNegativeNumbers();

            return totalizer;
        }

        private void CheckNegativeNumbers()
        {
            if (this.negativeNumbers.Count > 0)
            {
                string n = string.Empty;
                this.negativeNumbers.ForEach(x => n += x.ToString() + ",");
                n = n.TrimEnd(',');
                throw new Exception(string.Format("negatives not allowed: {0}", n));
            }
        }

        private void SaveIfNegative(int number)
        {
            if (number < 0)
                negativeNumbers.Add(number);
        }

        private void InitializeSeparators(string numbers)
        {
            separators.Add(',');
            separators.Add('\n');

            if (numbers.Contains("//"))
            {
                separators.Add(numbers.ToCharArray()[2]);
            }
        }
    }
}