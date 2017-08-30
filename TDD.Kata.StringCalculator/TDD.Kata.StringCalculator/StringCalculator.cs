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
            else
            {
                String[] arrayString = numbers.Split(',');

                int totalizador = default(int);

                for (int i = 0; i < arrayString.Length; i++)
                {
                    int n = default(int);
                    if (int.TryParse(arrayString[i], out n))
                    {
                        totalizador += n;
                    }
                }

                return totalizador;

            }

        }
    }
}
