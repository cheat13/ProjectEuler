using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.ConsoleApp
{
    public class Calculate
    {
        public double Calc(int min, int max, int pow)
        {
            var lstNum = Enumerable.Range(min, max - min + 1);
            return lstNum.Where(num => num == Sum(num, pow)).Sum();
        }

        public double Sum(int num, int pow)
        {
            return num.ToString().Select(it => Math.Pow(int.Parse(it.ToString()), pow)).Sum();
        }
    }
}