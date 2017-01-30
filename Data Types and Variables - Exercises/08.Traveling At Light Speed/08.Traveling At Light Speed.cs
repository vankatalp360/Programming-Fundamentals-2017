using System;

namespace _08.Traveling_At_Light_Speed
{
    public class Program
    {
        public static void Main()
        {
            decimal lightYears = decimal.Parse(Console.ReadLine());

            decimal total = lightYears * (9450000000000 / 300000);

            decimal weeks = total / 60 / 60 / 24 / 7;
            decimal days = total / 60 / 60 / 24 % 7;
            decimal hours = total / 60 / 60 % 24;
            decimal minutes = total / 60 % 60;
            decimal seconds = total % 60;

            Console.WriteLine("{0} weeks", Math.Floor(weeks));
            Console.WriteLine("{0} days", Math.Floor(days));
            Console.WriteLine("{0} hours", Math.Floor(hours));
            Console.WriteLine("{0} minutes", Math.Floor(minutes));
            Console.WriteLine("{0} seconds", Math.Floor(seconds));
        }
    }
}
