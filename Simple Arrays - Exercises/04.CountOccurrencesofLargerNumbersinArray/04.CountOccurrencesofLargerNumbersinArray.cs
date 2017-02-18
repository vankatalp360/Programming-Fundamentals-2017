using System;
using System.Linq;

namespace _04.CountOccurrencesofLargerNumbersinArray
{
    public class Program
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double number = double.Parse(Console.ReadLine());
            int biggerThanNumberCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > number)
                {
                    biggerThanNumberCount += 1;
                }
            }

            Console.WriteLine(biggerThanNumberCount);
        }
    }
}
