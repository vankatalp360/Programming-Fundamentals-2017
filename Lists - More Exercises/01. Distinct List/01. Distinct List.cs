using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Distinct_List
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                for (int k = 0; k < numbers.Count; k++)
                {
                    if (i != k)
                    {
                        if (numbers[i] == numbers[k])
                        {
                            numbers.RemoveAt(k);
                            k--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
