using System;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int first = 2; first <= number; first++)
            {
                bool answer = true;
                for (int second = 2; second <= Math.Sqrt(first); second++)
                {
                    if (first % second == 0)
                    {
                        answer = false;
                        break;
                    }
                }
                Console.WriteLine($"{first} -> {answer}");
            }

        }
    }
}
