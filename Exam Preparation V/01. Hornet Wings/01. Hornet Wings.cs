using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    public class Program
    {
        public static void Main()
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distance = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var finalDistance = (wingFlaps / 1000) * distance;
            var time = wingFlaps / 100;
            var totalTime = ((wingFlaps / endurance) * 5) + time;

            Console.WriteLine($"{finalDistance:F2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
