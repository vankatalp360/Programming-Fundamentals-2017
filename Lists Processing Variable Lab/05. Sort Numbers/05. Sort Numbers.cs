using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Sort_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            numbers.Sort();

            Console.WriteLine(string.Join(" <= ", numbers));

        }
    }
}
