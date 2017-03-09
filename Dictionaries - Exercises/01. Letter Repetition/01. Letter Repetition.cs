using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Letter_Repetition
{
    public class Program
    {
        public static void Main()
        {
            var chars = Console.ReadLine();
            var result = new Dictionary<char, int>();

            foreach (var symbol in chars)
            {
                if (!result.ContainsKey(symbol))
                {
                    result[symbol] = 0;
                }

                result[symbol]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
