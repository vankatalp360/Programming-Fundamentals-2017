using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Randomize_Words
{
    public class Program
    {
        public static void Main()
        {
            var listOfWords = Console.ReadLine().Split(' ').ToList();
            var rnd = new Random();

            for (int pos1 = 0; pos1 < listOfWords.Count; pos1++)
            {
                var randomPosition = rnd.Next(0, listOfWords.Count);
                var currentWord = listOfWords[pos1];
                var temp = listOfWords[randomPosition];
                listOfWords[randomPosition] = currentWord;
                listOfWords[pos1] = temp;
            }

            foreach (var word in listOfWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
