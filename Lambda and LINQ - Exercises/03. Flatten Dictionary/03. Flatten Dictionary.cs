using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Flatten_Dictionary
{
    public class Program
    {
        public static void Main()
        {
            var flattenDictionary = new Dictionary<string, Dictionary<string, string>>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var token = line.Split(' ').ToArray();
                if (token[0] != "flatten")
                {
                    var key = token[0];
                    var innerKey = token[1];
                    var innerValue = token[2];
                    if (!flattenDictionary.ContainsKey(key))
                    {
                        flattenDictionary[key] = new Dictionary<string, string>();
                    }
                    flattenDictionary[key][innerKey] = innerValue;
                }
                else
                {
                    var key = token[1];
                    flattenDictionary[key] = flattenDictionary[key]
                        .ToDictionary(x => x.Key + x.Value, x => "flattened");
                }
                

                line = Console.ReadLine();
            }

            var dictionary = flattenDictionary.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);

            foreach (var keyAndValue in dictionary)
            {
                var innerDict = keyAndValue.Value
                    .Where(x => x.Value != "flattened")
                    .OrderBy(x => x.Key.Length)
                    .ToDictionary(x => x.Key, x => x.Value);
                var flattenedValues = keyAndValue.Value
                    .Where(x => x.Value == "flattened")
                    .ToDictionary(x => x.Key, x => x.Value);
                var n = 1;
                Console.WriteLine(keyAndValue.Key);

                foreach (var innerKeyAndValue in innerDict)
                {
                    Console.WriteLine($"{n}. {innerKeyAndValue.Key} - {innerKeyAndValue.Value}");
                    n++;
                }
                foreach (var flattenKvp in flattenedValues)
                {
                    Console.WriteLine($"{n}. {flattenKvp.Key}");
                    n++;
                }
            }
        }
    }
}
