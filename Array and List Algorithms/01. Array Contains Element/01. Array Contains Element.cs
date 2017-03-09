using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Array_Contains_Element
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var number = int.Parse(Console.ReadLine());
            var isFound = false;

            foreach (var symbol in numbers)
            {
                if (symbol == number)
                {
                    isFound = true;
                    break;
                }
            }

            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
