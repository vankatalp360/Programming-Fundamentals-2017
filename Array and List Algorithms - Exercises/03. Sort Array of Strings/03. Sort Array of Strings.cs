using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Sort_Array_of_Strings
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToList();
            words.Sort();

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
