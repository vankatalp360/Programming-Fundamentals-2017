using System;

namespace _05.Calculate_Triangle_Area
{
    public class Program
    {
        public static void Main()
        {
            double weidth = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleAre(weidth, height);
            Console.WriteLine(area);
        }

        public static double GetTriangleAre(double weidth, double height)
        {
            return weidth * height / 2;
        }
    }
}
