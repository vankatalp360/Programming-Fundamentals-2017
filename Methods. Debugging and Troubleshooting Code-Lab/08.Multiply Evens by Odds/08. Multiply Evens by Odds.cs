using System;

namespace _08.Multiply_Evens_by_Odds
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int result = GetSumOfEvenAndOddDigits(n);
            Console.WriteLine(result);
        }

        public static int GetSumOfOddDigits(int number)
        {
            int result = 0;
            foreach (var simbol in number.ToString())
            {
                var digit = simbol - '0';
                if (digit % 2 == 1)
                {
                    result += digit;
                }
            }

            return result;
        }

        public static int GetSumOfEvenDigits(int number)
        {
            int result = 0;
            foreach (var simbol in number.ToString())
            {
                var digit = simbol - '0';
                if (digit % 2 == 0)
                {
                    result += digit;
                }
            }

            return result;
        }

        public static int GetSumOfEvenAndOddDigits(int number)
        {
            int result = Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
            return result;
        }
    }
}
