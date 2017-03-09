using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var result = new Dictionary<string, int>();
            var answer = new List<string>();

            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }

                result[word]++;
            }

            foreach (var kvp in result)
            {
                if (kvp.Value % 2 != 0)
                {
                    answer.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", answer));
        }
    }
}
