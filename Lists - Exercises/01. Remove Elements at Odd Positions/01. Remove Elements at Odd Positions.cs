using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Remove_Elements_at_Odd_Positions
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToList();
            var answer = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                if (i % 2 != 0)
                {
                    answer.Add(words[i]);
                }
            }

            Console.WriteLine(string.Join("", answer));
        }
    }
}
