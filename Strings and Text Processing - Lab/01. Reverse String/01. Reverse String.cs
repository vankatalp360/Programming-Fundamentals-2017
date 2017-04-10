using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Reverse_String
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }

            Console.WriteLine(result);
        }
    }
}
