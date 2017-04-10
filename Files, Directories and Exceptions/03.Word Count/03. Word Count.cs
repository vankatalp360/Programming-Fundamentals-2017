using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _03.Word_Count
{
    public class Program
    {
        public static void Main()
        {
            string words = File.ReadAllText("../../../Resources/03. Word Count/words.txt");
            string text = File.ReadAllText("../../../Resources/03. Word Count/text.txt").ToLower();

            var word = words.Split(' ').ToList();
            var output = new Dictionary<string, int>();
            var wordsInText = text.Split(new[] { ' ', ',', '-', '\r', '\n', '.', '?', '!' }
            , StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < word.Count; i++)
            {
                if (!output.ContainsKey(word[i]))
                {
                    output[word[i]] = 0;
                }
                foreach (var wordInText in wordsInText)
                {
                    if (wordInText == word[i])
                    {
                        output[word[i]] += 1;
                    }
                }
            }

            foreach (var wordOutput in output.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("../../../Resources/03. Word Count/output.txt", wordOutput.Key + "-" + wordOutput.Value + "\r\n");
            }
        }
    }
}
