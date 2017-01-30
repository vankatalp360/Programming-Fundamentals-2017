using System;

namespace _11.Geometry_Calculator
{
    public class Program
    {
        public static void Main()
        {
            string figure = Console.ReadLine();
            double answer = Math.Round(InPut(figure), 2);
            Console.WriteLine("{0:F2}", answer);

        }

        public static double InPut(string figure)
        {
            double side = 0;
            double height = 0;
            double width = 0;
            double radius = 0;

            switch (figure)
            {
                case "triangle": side = double.Parse(Console.ReadLine());
                                 height = double.Parse(Console.ReadLine()); break;
                case "square": side = double.Parse(Console.ReadLine()); break;
                case "rectangle": width = double.Parse(Console.ReadLine());
                                  height = double.Parse(Console.ReadLine()); break;
                case "circle": radius = double.Parse(Console.ReadLine()); break;     
            }

            double result = Calculate(figure, side, height, width, radius);
            return result;
        }

        public static double Calculate(string figure, double side, double height, double width, double radius)
        {
            if (figure == "triangle")
            {
                return ((side * height) / 2);
            }
            else if (figure == "square")
            {
                return side * side;
            }
            else if (figure == "rectangle")
            {
                return width * height;
            }
            else if (figure == "circle")
            {
                return Math.PI * radius * radius;
            }
            return 0;
        }
    }
}
