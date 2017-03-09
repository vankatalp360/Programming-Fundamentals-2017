using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Sort_Array_Using_Insertion_Sort
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        var temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }

                    j--;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
