using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Camels_Back
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var camelBackSize = int.Parse(Console.ReadLine());
            var rounds = 0;

            var city = numbers.Count;
            for (int i = ((numbers.Count - camelBackSize) / 2) - 1; i >= 0; i--)
            {
                numbers.RemoveAt(numbers.Count - i - 1);
                numbers.RemoveAt(i);
                rounds++;
            }

            if (city <= camelBackSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ", numbers)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", numbers)}");
            }
        }
    }
}
