using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Distance_between_Points
{
    public class Program
    {

        public static void Main()
        {
            var p1 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var p2 = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var firstPoint = new Pont
            {
                X = p1[0],

                Y = p1[1]
            };

            var secondPoint = new Pont
            {
                X = p2[0],

                Y = p2[1]
            };

            var squareX = Math.Pow(firstPoint.X - secondPoint.X, 2);
            var squareY = Math.Pow(firstPoint.Y - secondPoint.Y, 2);
            var distance = Math.Sqrt(squareX +squareY);

            Console.WriteLine($"{distance:F3}");
        }
    }
}
