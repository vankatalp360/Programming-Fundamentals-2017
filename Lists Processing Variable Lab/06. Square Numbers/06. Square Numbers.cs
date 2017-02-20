using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Square_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            var answer = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    answer.Insert(0, numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
