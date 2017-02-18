using System;
using System.Linq;

namespace _01.Last_3_Consecutive_Equal_Strings
{
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string answer = "";

            for (int i = 2; i < words.Length; i++)
            {
                if (words[i] == words[i - 1] && words[i] == words[i - 2])
                {
                    answer = words[i];
                }
            }

            Console.WriteLine($"{answer} {answer} {answer}");
        }
    }
}
