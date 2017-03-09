using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Batteries
{
    public class Program
    {
        public static void Main()
        {
            var capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var usage = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var hours = double.Parse(Console.ReadLine());
            var batteryStatus = 0.0;
            var percentage = 0.0;
            var dieTime = 0;

            for (int i = 0; i < usage.Length; i++)
            {
                batteryStatus = capacities[i] - (usage[i] * hours);

                if (batteryStatus >= 0)
                {
                    percentage = (batteryStatus / capacities[i]) * 100;
                    percentage = Math.Round(percentage, 2);

                    Console.WriteLine($"Battery {i + 1}: {batteryStatus:F2} mAh ({percentage:F2})%");
                }
                else
                {
                    for (int k = 1; k < hours; k++)
                    {
                        dieTime = (int)(k * usage[i]);
                        if (dieTime > capacities[i])
                        {
                            dieTime /= (int)(usage[i]);
                            break;
                        }
                    }
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {dieTime} hours)");
                }
            }
        }
    }
}
