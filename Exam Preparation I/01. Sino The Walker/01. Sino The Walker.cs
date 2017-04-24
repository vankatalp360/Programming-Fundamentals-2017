using System;
using System.Numerics;

namespace _01.Sino_The_Walker
{
    public class Program
    {
        public static void Main()
        {
            var leavTime = Console.ReadLine();
            var steps = int.Parse(Console.ReadLine());
            var stepTime = int.Parse(Console.ReadLine());
            var secondInDay = 60 * 60 * 24;
            var needTime = (int)(((double)steps * stepTime) % secondInDay);

            var time = DateTime.Parse(leavTime);
            var arrivalTime = time.AddSeconds(needTime);
            var format = "HH:mm:ss";
            var result = arrivalTime.ToString(format);

            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
