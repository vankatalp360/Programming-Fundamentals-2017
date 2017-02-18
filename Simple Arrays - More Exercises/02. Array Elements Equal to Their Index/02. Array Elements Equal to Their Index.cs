using System;
using System.Linq;

namespace _02.Array_Elements_Equal_to_Their_Index
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i && i < numbers.Length)
                {
                    Console.Write($"{i} ");
                }
                else if (numbers[i] == i && i == numbers.Length)
                {
                    Console.Write($"{i}");
                }
            }
            Console.WriteLine();
        }
    }
}
