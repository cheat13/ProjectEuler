using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculate();
            var result = calc.Calc(2, 100);
            Console.WriteLine(result);
        }
    }
}
