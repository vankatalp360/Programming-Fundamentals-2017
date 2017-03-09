using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Array_Histogram
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var foundWords = new List<string>();
            var wordCount = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {

                if (foundWords.Contains(words[i]))
                {
                    int wordIndex = foundWords.IndexOf(words[i]);
                    wordCount[wordIndex]++;
                }
                else if (!foundWords.Contains(words[i]))
                {
                    foundWords.Add(words[i]);
                    wordCount.Add(1);
                }
            }

            var hasSwapped = true;

            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < wordCount.Count - 1; i++)
                {
                    if (wordCount[i] < wordCount[i + 1])
                    {
                        int temp = wordCount[i];
                        wordCount[i] = wordCount[i + 1];
                        wordCount[i + 1] = temp;

                        string tempWord = foundWords[i];
                        foundWords[i] = foundWords[i + 1];
                        foundWords[i + 1] = tempWord;

                        hasSwapped = true;
                    }
                }
            }
            

            for (int i = 0; i < foundWords.Count; i++)
            {
                var percentage = wordCount[i] * 100.0 / words.Length;
                Console.WriteLine($"{foundWords[i]} -> {wordCount[i]} times ({percentage:F2}%)");
            }
        }
    }
}
