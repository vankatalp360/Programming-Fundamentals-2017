using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Palindromes
{
    public class Program
    {
        public static void Main()
        {
            char[] split = { ' ', ',', '.', '?', '!' };
            string[] words = Console.ReadLine().Split(split,StringSplitOptions.RemoveEmptyEntries);
            var result = new List<string>();

            foreach (var word in words)
            {
                if (isPalindrome(word))
                {
                    result.Add(word);
                }
            }

            result.Sort();
            result = result.Distinct().ToList();
            Console.WriteLine(string.Join(", ", result));
        }
        public static bool isPalindrome (string word)
        {
            var secondWord = string.Empty;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                secondWord += word[i];
            }

            return secondWord == word;
        }
    }
}
