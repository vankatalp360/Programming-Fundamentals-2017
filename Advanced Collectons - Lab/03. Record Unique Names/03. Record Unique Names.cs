using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Record_Unique_Names
{
    public class Program
    {
        public static void Main()
        {
            var uniqueNames = new HashSet<string>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine();
                uniqueNames.Add(line);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
