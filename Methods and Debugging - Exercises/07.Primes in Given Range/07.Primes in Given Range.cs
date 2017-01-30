using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    public class Program
    {
        public static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            var PrimesInRange = FindPrimesInRange(firstNumber, secondNumber);

            Console.WriteLine(string.Join(", ", PrimesInRange));
        }

        public static List<int> FindPrimesInRange(int startNumber, int endNumer)
        {
            var primes = new List<int>();
            for (int current = startNumber; current <= endNumer; current++)
            {
                if (IsPrime(current))
                {
                    primes.Add(current);
                }
            }
            return primes;
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
