using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dict_Ref_Advanced
{
    public class Program
    {
        public static void Main()
        {
            var data = new Dictionary<string, List<int>>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var token = line.Split(new[] { ' ', '-', '>', ','}, StringSplitOptions.RemoveEmptyEntries);
                var name = token[0];
                int number = -1;
                var isInt = int.TryParse(token[1], out number);


                if (isInt)
                {
                    if (!data.ContainsKey(name))
                    {
                        data[name] = new List<int>();
                    }
                    for (int i = 1; i < token.Length; i++)
                    {
                        data[name].Add(int.Parse(token[i]));
                    }
                }
                else
                {
                    string otherKey = token[1];
                    if (data.ContainsKey(otherKey))
                    {
                        data[name] = new List<int>(data[otherKey]);
                    }
                }

                line = Console.ReadLine();
            }

            
            foreach (var kvp in data)
            {
                var name = kvp.Key;
                Console.WriteLine($"{name} === {string.Join(", ", kvp.Value)}");
            }

        }
    }
}
