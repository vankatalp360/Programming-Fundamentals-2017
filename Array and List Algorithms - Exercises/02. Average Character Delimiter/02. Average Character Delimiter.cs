using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Average_Character_Delimiter
{
    public class Program
    {
        public static void Main()
        {
            var strings = Console.ReadLine().Split(' ').ToArray();
            var fullString = "";
            var sum = 0;
            var average = 0;

            foreach (var item in strings)
            {
                fullString += item;
            }

            foreach (var symbol in fullString)
            {
                sum += symbol;
            }

            average = sum / fullString.Length;
            var delimenter = (char)((int)average);

            Console.WriteLine(string.Join(("" + delimenter).ToUpper(), strings));
        }
    }
}
