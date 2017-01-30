using System;

namespace _09.Longer_Line
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            double line1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double line2 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));

            if (line1 >= line2)
            {
                bool first = true;
                if (Math.Sqrt(x1 * x1 + y1 * y1) > Math.Sqrt(x2 * x2 + y2 * y2))
                    first = false;
                if (first)
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                bool first = true;
                if (Math.Sqrt(x3 * x3 + y3 * y3) > Math.Sqrt(x4 * x4 + y4 * y4))
                    first = false;
                if (first)
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                else Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }

        }
    }
}
