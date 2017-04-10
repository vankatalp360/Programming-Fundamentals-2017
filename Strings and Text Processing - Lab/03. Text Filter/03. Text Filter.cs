using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Text_Filter
{
    public class Program
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new[] { ' ', ','}
            ,StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, new string('*'
                        ,bannedWord.Length));
                }
            }

            Console.WriteLine(text);

        }
    }
}
