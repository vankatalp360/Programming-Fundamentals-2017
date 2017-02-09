using System;
using System.Linq;

namespace _05.Count_of_Odd_Numbers_in_Array
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if ((numbers[i] % 2 != 0) && (i % 2 != 0))
                {
                    Console.WriteLine($"Index {i} -> {numbers[i]}");
                }
            }
        }
    }
}
