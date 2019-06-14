using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.ConsoleApp
{
    public class Calculate
    {
        public int Calc(int start, int end)
        {
            var lstNumber = Enumerable.Range(start, end - start + 1);
            return lstNumber.SelectMany(it => lstNumber, (a, b) => Math.Pow(a, b)).Distinct().Count();
        }
    }
}