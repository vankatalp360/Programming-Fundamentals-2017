using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Dict_Ref
{
    public class Program
    {
        public static void Main()
        {
            var input = new List<string>();
            var result = new Dictionary<string, int>();
            do
            {
                input = Console.ReadLine().Split(' ').ToList();

                if (input[0] != "end")
                {
                    int n;
                    bool isNumeric = int.TryParse(input[2], out n);
                    if (isNumeric)
                    {
                        result[input[0]] = int.Parse(input[2]);
                    }
                    else
                    {
                        if (result.ContainsKey(input[2]))
                        {
                            result[input[0]] = result[input[2]];
                        }
                    }
                }
            } while (input[0] != "end");

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
