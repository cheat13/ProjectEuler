using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.ConsoleApp
{
    public class Calculate
    {
        public double Calc(int number)
        {
            var listAbundant = FindListAbundant(number);
            var theNumbers = new List<double>();
            var IsStop = false;
            for (int i = 0; i < number; i++)
            {
                IsStop = false;
                for (int j = 0; j < listAbundant.Length; j++)
                {
                    if (IsStop) break;
                    for (int k = 0; k < listAbundant.Length; k++)
                    {
                        if (listAbundant[j] + listAbundant[k] == i)
                        {
                            IsStop = true;
                            break;
                        }
                        else if (j == listAbundant.Length - 1 && k == listAbundant.Length - 1)
                        {
                            theNumbers.Add(i);
                        }
                    }
                }
            }
            var result = theNumbers.ToArray().Sum();
            return result;
        }

        public int[] FindDivisors(int number)
        {
            var divisors = new List<int>();
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) divisors.Add(i);
            }
            return divisors.ToArray();
        }

        public bool IsAbundant(int number)
        {
            return (FindDivisors(number).Sum() > number) ? true : false;
        }

        public int[] FindListAbundant(int number)
        {
            var listAbundant = new List<int>();
            for (int i = 1; i < number; i++)
            {
                if (IsAbundant(i)) listAbundant.Add(i);
            }
            return listAbundant.ToArray();
        }
    }
}