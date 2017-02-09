using System;
using System.Linq;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Math.Abs(numbers[i]);
                if (numbers[i] % 2 != 0)
                {
                    counter += 1;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
