using System;

namespace _05.Fibonacci_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int answer = FibonacciNumber(number);
            Console.WriteLine(answer);
        }

        public static int FibonacciNumber(int number)
        {
            int answer = 1;
            int previous = 1;
            int current = 0;

            if (number < 2)
            {
                return 1;
            }
            else
            {
                for (int F = 0; F < number; F++)
                {
                    current = previous;
                    previous = answer + previous;
                    answer = current;
                }
                return answer;
            }
        }
    }
}
