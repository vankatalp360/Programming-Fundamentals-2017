using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Flip_List_Sides
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var oldNumber = 0;

            if (numbers.Count % 2 == 0)
            {
                for (int i = 1; i < numbers.Count / 2; i++)
                {
                    oldNumber = numbers[numbers.Count - i - 1];
                    numbers[numbers.Count - i - 1] = numbers[i];
                    numbers[i] = oldNumber;
                }
            }
            else
            {
                for (int i = 1; i < numbers.Count / 2 + 1; i++)
                {
                    oldNumber = numbers[numbers.Count - i - 1];
                    numbers[numbers.Count - i - 1] = numbers[i];
                    numbers[i] = oldNumber;
                }
            }


            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
