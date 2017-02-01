using System;

namespace _03.String_Repeater
{
    public class Program
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string answer = RepeatString(word, number);
            Console.WriteLine(answer);
        }

        public static string RepeatString(string word, int number)
        {
            string RepeatString = "";

            for (int counter = 0; counter < number; counter++)
            {
                RepeatString = RepeatString + word;
            }

            return RepeatString;
        }
    }
}
