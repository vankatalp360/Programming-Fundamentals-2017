using System;

namespace _05.Integer_to_Base
{
    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            string answer = IntegerToBase(number, toBase);
            Console.WriteLine(answer);
        }

        public static string IntegerToBase(long number, int toBase)
        {
            var result = string.Empty;
            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }
            return result;
        }
    }
}
