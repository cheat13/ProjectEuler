using System;

namespace ProjectEuler.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number : ");
            var number = double.Parse(Console.ReadLine());
            var calculate = new Calculate();
            var result = calculate.Calc(number);
            Console.Write($"Result = {result}");
        }
    }
}
