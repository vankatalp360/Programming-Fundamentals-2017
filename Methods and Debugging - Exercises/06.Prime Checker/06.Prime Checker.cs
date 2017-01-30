using System;

namespace _06.Prime_Checker
{
    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            bool answer = IsPrime(number);
            Console.WriteLine(answer);
        }

        public static bool IsPrime(long number)
        {
            double Sqrt = Math.Sqrt(number);

            if (number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Sqrt; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
