using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.ConsoleApp
{
    public class Calculate
    {
        public bool IsPrimeNumber(double factors)
        {
            for (int i = 2; i < factors; i++)
            {
                if (factors % i == 0) return false;
            }
            return true;
        }

        public double[] Primefactors(double number)
        {
            var primefactors = new List<double>();
            for (int i = 2; i < number / 2; i++)
            {
                if (number % i == 0 && IsPrimeNumber(i)) primefactors.Add(i);
            }
            return primefactors.ToArray();
        }

        public double TheLargestPF(double number)
        {
            return Primefactors(number).Max();
        }

        public double Calc(double number)
        {
            var theLargestPF = number;
            var end = Math.Sqrt(number);
            for (int i = 2; i < end; i++)
            {
                while (theLargestPF % i == 0 && theLargestPF != i)
                {
                    theLargestPF /= i;
                }
            }
            return theLargestPF;
        }
    }
}