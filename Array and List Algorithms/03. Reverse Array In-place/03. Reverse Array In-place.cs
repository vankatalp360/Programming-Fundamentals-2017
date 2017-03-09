using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Reverse_Array_In_place
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Count - i - 1];
                numbers[numbers.Count - i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
