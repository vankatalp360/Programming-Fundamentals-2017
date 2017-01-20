using System;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main()
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int time = hours * 3600 + minutes * 60 + seconds;

            double metersPerSec = (double)meters / time;
            double kilometersPerHour = ((double)meters / 1000) / ((double)time / 3600);
            double milesPerHour = ((double)meters / 1609) / ((double)time / 3600);

            Console.WriteLine("{0:F6}", metersPerSec);
            Console.WriteLine("{0:F6}", kilometersPerHour);
            Console.WriteLine("{0:F6}", milesPerHour);
        }
    }
}
