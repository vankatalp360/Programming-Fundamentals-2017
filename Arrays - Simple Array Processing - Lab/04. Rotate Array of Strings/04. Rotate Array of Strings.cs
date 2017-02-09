using System;
using System.Linq;

namespace _04.Rotate_Array_of_Strings
{
    public class Program
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            string lastWord = words[words.Length - 1];

            for (int i = words.Length - 1; i > 0; i--)
            {
                words[i] = words[i - 1];
            }

            words[0] = lastWord;
            var answer = string.Join(" ", words);

            Console.WriteLine(answer);
        }
    }
}
