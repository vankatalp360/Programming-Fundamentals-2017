using System;
using System.Linq;

namespace _08.Array_Symmetry
{
    public class Program
    {
        public static void Main()
        {
            string[] Words = Console.ReadLine().Split(' ').ToArray();
            bool isSymetric = true;

            for (int i = 0; i <= Words.Length / 2; i++)
            {
                string firstWord = Words[i];
                string secondWord = Words[Words.Length - 1 - i];

                if (firstWord != secondWord)
                {
                    isSymetric = false;
                    break;
                }
            }

            if (isSymetric)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
