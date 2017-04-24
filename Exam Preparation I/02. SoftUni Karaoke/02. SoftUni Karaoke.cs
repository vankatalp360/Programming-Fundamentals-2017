using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();
            var availableSong = Console.ReadLine()
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();
            var stagePerformance = Console.ReadLine();
            var namesAndAwards = new Dictionary<string, HashSet<string>>();

            while (stagePerformance != "dawn")
            {
                var token = stagePerformance
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToArray();
                var name = token[0];
                var song = token[1];
                var award = token[2];
                if (names.Contains(name) && availableSong.Contains(song))
                {
                    if (!namesAndAwards.ContainsKey(name))
                    {
                        namesAndAwards[name] = new HashSet<string>();
                    }
                    namesAndAwards[name].Add(award);
                }
                
                stagePerformance = Console.ReadLine();
            }

            if (namesAndAwards.Count > 0)
            {
                foreach (var name in namesAndAwards
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(y => y.Key))
                {
                    Console.WriteLine($"{name.Key}: {name.Value.Count} awards");
                    foreach (var award in name
                        .Value
                        .OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
