using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LINQuistics
{
    public class Program
    {
        public static void Main()
        {
            var linquistics = new Dictionary<string, HashSet<string>>();
            var line = Console.ReadLine();

            while (line != "exit")
            {
                var token = line.Split(new[] { ' ', '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var collection = token[0];
                var number = 0;
                var isNumber = int.TryParse(token[0], out number);

                if (token.Length > 1)
                {
                    if (!linquistics.ContainsKey(collection))
                    {
                        linquistics[collection] = new HashSet<string>();
                    }

                    for (int i = 1; i < token.Length; i++)
                    {
                        linquistics[collection].Add(token[i]);
                    }
                }
                else if (token.Length == 1 && isNumber == false)
                {
                    if (linquistics.ContainsKey(collection))
                    {
                        foreach (var method in linquistics[collection]
                            .OrderByDescending(x => x.Length)
                            .ThenByDescending(x => x.Distinct()
                            .Count()))
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                }
                else if (isNumber == true)
                {
                    var theMostMethods = int.MinValue;
                    var collectionMostMethod = "";
                    foreach (var collect in linquistics)
                    {
                        if (theMostMethods < collect.Value.Count())
                        {
                            theMostMethods = collect.Value.Count();
                            collectionMostMethod = collect.Key;
                        }
                    }
                    var counter = 0;
                    foreach (var method in linquistics[collectionMostMethod]
                            .OrderBy(x => x.Length)
                            .ThenBy(x => x.Distinct()
                            .Count()))
                    {
                        if (counter == number)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"* {method}");
                        }
                        counter++;
                    }
                }

                line = Console.ReadLine();
            }
            line = Console.ReadLine();
            
            var token1 = line.Split(' ').ToArray();
            var givenMethod = token1[0];
            var selection = token1[1];
            var collectionsContainsMethod = new Dictionary<string, HashSet<string>>();
            foreach (var collection in linquistics)
            {
                if (collection.Value.Contains(givenMethod))
                {
                    collectionsContainsMethod[collection.Key] = new HashSet<string>();
                    collectionsContainsMethod[collection.Key] = collection.Value;
                }
            }

            if (selection == "all")
            {
                foreach (var collection in collectionsContainsMethod
                    .OrderByDescending(x => x.Value.Count()))
                {
                    Console.WriteLine(collection.Key);

                    foreach (var item in collection.Value
                        .OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($"* {item}");
                    }
                }
            }
            else
            {
                foreach (var collection in collectionsContainsMethod
                    .OrderByDescending(x => x.Key))
                {
                    Console.WriteLine(collection.Key);
                }
            }
        }
    }
}
