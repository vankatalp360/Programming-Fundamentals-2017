using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Shellbound
{
    public class Program
    {
        public static void Main()
        {
            var crapShells = new Dictionary<string, HashSet<int>>();
            var line = Console.ReadLine();

            while (line != "Aggregate")
            {
                var token = line.Split(' ');
                var regionName = token[0];
                var shellSize = int.Parse(token[1]);

                if (!crapShells.ContainsKey(regionName))
                {
                    crapShells[regionName] = new HashSet<int>();
                }

                crapShells[regionName].Add(shellSize);

                line = Console.ReadLine();
            }

            foreach (var kvp in crapShells)
            {
                var regionName = kvp.Key;
                var shells = kvp.Value;
                var giantShell = 0;
                var sumOfShells = 0;

                foreach (var shell in shells)
                {
                    sumOfShells += shell;
                }

                giantShell = sumOfShells - (sumOfShells / shells.Count);

                Console.WriteLine($"{regionName} -> {string.Join(", ", shells)} ({giantShell})");
            }
        }
    }
}
