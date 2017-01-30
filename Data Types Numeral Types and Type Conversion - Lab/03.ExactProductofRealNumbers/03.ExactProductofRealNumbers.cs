using System;

namespace _03.ExactProductofRealNumbers
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal sum = 1m;

            for (int counter = 1; counter <= n; counter++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum *= number;
            }

            Console.WriteLine(sum);
        }
    }
}
