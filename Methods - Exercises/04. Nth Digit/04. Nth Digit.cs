using System;

namespace _04.Nth_Digit
{
    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            long answer = FindNthDigit(number, index);
            Console.WriteLine(answer);
        }

        public static long FindNthDigit(long number, int index)
        {
            long digit = 0;
            int count = 0;
            while (number != 0)
            {
                count++;
                digit = number % 10;
                number /= 10;
                if (count == index)
                {
                    return digit;
                }
            }
            return 0;
        }
    }
}
