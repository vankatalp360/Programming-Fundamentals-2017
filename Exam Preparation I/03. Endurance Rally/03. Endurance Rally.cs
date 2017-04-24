using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(' ')
                .Select(x => x.Trim())
                .ToArray();
            var zones = Console.ReadLine()
                .Split(' ')
                .Select(x => x.Trim())
                .Select(double.Parse)
                .ToArray();
            var checkpoints = Console.ReadLine()
                .Split(' ')
                .Select(x => x.Trim())
                .Select(double.Parse)
                .ToArray();

            foreach (var name in names)
            {
                var fuel = (double)(name[0]);
                var reachedZone = 0;

                for (int i = 0; i < zones.Length; i++)
                {
                    if (fuel > 0)
                    {
                        if (checkpoints.Contains(i))
                        {
                            fuel += zones[i];
                        }
                        else
                        {
                            fuel -= zones[i];
                        }
                        reachedZone = i;
                    }
                }

                if (fuel > 0)
                {
                    Console.WriteLine($"{name} - fuel left {fuel:F2}");
                }
                else
                {
                    Console.WriteLine($"{name} - reached {reachedZone}");
                }
            }
        }
    }
}
