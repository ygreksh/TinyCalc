using System;

namespace TinyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение:");
            string inputString = Console.ReadLine();
            int result = CalcParser.Calculate(inputString);
            Console.Write(result);
        }
    }
}