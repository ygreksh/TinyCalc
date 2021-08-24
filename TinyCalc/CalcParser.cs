using System;
using System.Linq;

namespace TinyCalc
{
    public static class CalcParser
    {
        public static int Calculate(string input)
        {
            int result;
            char[] opSigns = new[] { '+', '-', '*', '/' };
            string[] args = input.Split(opSigns);
            int a = Int32.Parse(args[0]);
            int b = Int32.Parse(args[1]);
            if (input.Contains('+'))
            {
                result = Sum(a,b);
            }
            else if (input.Contains('-'))
            {
                result = Substr(a,b);
            }
            else if (input.Contains('*'))
            {
                result = Multi(a,b);
            }else if (input.Contains('/'))
            {
                result = Divide(a,b);
            }
            else
            {
                result = 0;
                Console.WriteLine("Неверный сивол операции");
            }
            return result;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Substr(int a, int b)
        {
            return a - b;
        }
        public static int Multi(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            int result;
            try
            {
                result = a / b;
                return result;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("На 0 делить нельзя");
                throw;
            }
        }
    }
}