using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Serialize_String
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var chars = new HashSet<char>();
            foreach (var symbol in line)
            {
                chars.Add(symbol);
            }

            var index = new List<int>();
            foreach (var charr in chars)
            {
                var counter = -1;
                index = new List<int>();
                foreach (var letter in line)
                {
                    counter++;
                    if (letter == charr)
                    {
                        index.Add(counter);
                    }
                }
                Console.Write($"{charr}:");
                Console.WriteLine(string.Join("/", index));
            }
        }
    }
}
