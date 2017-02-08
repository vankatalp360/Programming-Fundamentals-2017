using System;

namespace _01.Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var answer = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(answer);
        }

        private static long GetMultipleOfEvensAndOdds(int number)
        {
            number = Math.Abs(number);
            return GetEvensNumbers(number) * GetOddsNumbers(number);
        }

        private static long GetOddsNumbers(int number)
        {
            var oddsSum = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 != 0)
                {
                    oddsSum += digit;
                }
            }
            return oddsSum;
        }

        private static long GetEvensNumbers(int number)
        {
            var evensSum = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 0)
                {
                    evensSum += digit;
                }
            }
            return evensSum;
        }
    }
}
