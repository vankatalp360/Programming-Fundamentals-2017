using System;

namespace _08.Center_Point
{
    public class Program
    {
        public static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            if (ClosestPodouble(x1, y1, x2, y2) == x1)
            {
                Console.WriteLine($"({x1}, {y1})");
            }

            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        public static double ClosestPodouble(double x1, double y1, double x2, double y2)
        {
            if (Math.Sqrt(x1 * x1 + y1 * y1) < Math.Sqrt(x2 * x2 + y2 * y2))
            {
                return x1;
                
            }

            else 
            {
                return x2;
            }
        }
    }
}
