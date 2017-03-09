using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Smallest_Element_in_Array
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var smallestnumber = int.MaxValue;

            foreach (var number in numbers)
            {
                if (number < smallestnumber)
                {
                    smallestnumber = number;
                }
            }

            Console.WriteLine(smallestnumber);
        }
    }
}
