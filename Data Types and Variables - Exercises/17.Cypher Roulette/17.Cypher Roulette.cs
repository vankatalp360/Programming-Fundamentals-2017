using System;

namespace _17.Cypher_Roulette
{
    public class Program
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string answer = "";
            string oldWord = "";
            long spinCount = 0;

            for (long counter = 1; counter <= number; counter++)
            {
                string word = Console.ReadLine();
                if (word == "spin")
                {
                    counter--;
                    spinCount += 1;
                }
                else if (spinCount % 2 == 0)
                {
                    answer = answer + word;
                }
                else
                {
                    answer = word + answer;
                }
                if (oldWord == word)
                {
                    answer = "";
                }
                oldWord = word;
            }

            Console.WriteLine(answer);
        }
    }
}
