using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Count_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var counters = new List<int>();
            int count = 1;
            numbers.Sort();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else if (numbers[i] != numbers[i + 1])
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                    count = 1;
                }
                if (i == numbers.Count - 2)
                {
                    Console.WriteLine($"{numbers[i + 1]} -> {count}");
                    count = 1;
                }
            }

            if (numbers.Count == 1)
            {
                Console.WriteLine($"{numbers[0]} -> {count}");
            }
        }
    }
}
