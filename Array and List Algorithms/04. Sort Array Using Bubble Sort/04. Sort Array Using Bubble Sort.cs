using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Sort_Array_Using_Bubble_Sort
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var isSort = false;

            do
            {
                isSort = false;
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        isSort = true;
                    }
                }
            } while (isSort);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
