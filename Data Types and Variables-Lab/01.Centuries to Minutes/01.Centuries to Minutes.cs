using System;

namespace _01.Centuries_to_Minutes
{
    class Program
    {
        static void Main()
        {
            Console.Write("Centuries = ");
            int Centuries = int.Parse(Console.ReadLine());
            int years = Centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{Centuries} centures = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}
