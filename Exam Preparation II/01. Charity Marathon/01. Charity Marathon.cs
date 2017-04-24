using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    public class Program
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            var runnerLaps = int.Parse(Console.ReadLine());
            var truckLenght = int.Parse(Console.ReadLine());
            long truckCpacity = long.Parse(Console.ReadLine());
            var moneyPerKilometer = double.Parse(Console.ReadLine());

            truckCpacity = truckCpacity * days;
            runners = Math.Min(truckCpacity, runners);
            long totalMeters = runners * runnerLaps * truckLenght;
            long totalKilometers = totalMeters / 1000;
            var risedMoney = moneyPerKilometer * totalKilometers;

            Console.WriteLine($"Money raised: {risedMoney:f2}");


        }
    }
}
