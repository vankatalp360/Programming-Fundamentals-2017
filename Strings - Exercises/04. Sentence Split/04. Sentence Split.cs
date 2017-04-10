using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Sentence_Split
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var delimiters = Console.ReadLine();
            var delemiter = delimiters.ToCharArray();
            line = line.Replace($"{delimiters}", "9");

            var sentence = line.Split('9');
            Console.Write("[");
            Console.Write(string.Join(", ", sentence));
            Console.WriteLine("]");
        }
    }
}
