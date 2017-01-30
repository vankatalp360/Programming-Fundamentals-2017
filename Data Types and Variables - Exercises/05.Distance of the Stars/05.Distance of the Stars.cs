using System;

namespace _05.Distance_of_the_Stars
{
    public class Program
    {
        public static void Main()
        {
            decimal Earth = 9450000000000m * 4.22m;
            decimal centerOfGalaxy = 9450000000000m * 26000m;
            decimal milkyWay = 9450000000000m * 100000m;
            decimal edge = 9450000000000m * 46500000000m;
            Console.WriteLine(Earth.ToString("e2"));
            Console.WriteLine(centerOfGalaxy.ToString("e2"));
            Console.WriteLine(milkyWay.ToString("e2"));
            Console.WriteLine(edge.ToString("e2"));
        }
    }
}
