using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Largest_N_Elements
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var number = int.Parse(Console.ReadLine());
            var result = new List<int>();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < number; i++)
            {
                result.Add(numbers[i]); 
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
