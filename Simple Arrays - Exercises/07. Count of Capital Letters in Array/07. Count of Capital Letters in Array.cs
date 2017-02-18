using System;
using System.Linq;

namespace _07.Count_of_Capital_Letters_in_Array
{
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int capitalEnglishLetters = 0;

            for (int i = 0; i < words.Length; i++)
            {
                for (char k = 'A'; k <= 'Z'; k++)
                {
                    string letter = "" + k;
                    if (words[i] == letter)
                    {
                        capitalEnglishLetters += 1;
                    }
                }
            }

            Console.WriteLine(capitalEnglishLetters);
        }
    }
}
