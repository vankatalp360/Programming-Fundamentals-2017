using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Default_Values
{
    public class Program
    {
        public static void Main()
        {
            var defaultValues = new Dictionary<string, string>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var token = line.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var key = token[0];
                var value = token[1];
                defaultValues[key] = value;

                line = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

            var unChangeDictionary = defaultValues
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            var changeDictionary = defaultValues
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);

            foreach (var unChange in unChangeDictionary)
            {
                Console.WriteLine($"{unChange.Key} <-> {unChange.Value}");
            }

            foreach (var change in changeDictionary)
            {
                Console.WriteLine($"{change.Key} <-> {change.Value}");
            }
        }
    }
}
