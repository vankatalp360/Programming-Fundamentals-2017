using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Count_Substring_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var counter = 0;
            var index = text.IndexOf(pattern);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
