using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Append_Lists
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split('|').ToList();
            var result = new List<string>();
            input.Reverse();

            foreach (var item in input)
            {
                List<string> numbers = item.Split(' ').ToList();
                foreach (var number in numbers)
                {
                    if (number != "")
                    {
                        result.Add(number);
                    }
                }
            }
            

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
