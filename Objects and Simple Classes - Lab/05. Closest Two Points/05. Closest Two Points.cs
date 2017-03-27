using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Closest_Two_Points
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            var minimumDistance = double.MaxValue;
            Point firstPointResult = null;
            Point secondPointResult = null;

            for (int i = 0; i < n; i++)
            {
                var currentPoint = ReadPoint();
                points.Add(currentPoint);
            }

            for (int first = 0; first < points.Count; first++)
            {
                for (int second = first + 1; second < points.Count; second++)
                {
                    var firstPoint = points[first];
                    var secondPoint = points[second];

                    var currentDistance = Distance(firstPoint, secondPoint);

                    if (currentDistance < minimumDistance)
                    {
                        minimumDistance = currentDistance;
                        firstPointResult = firstPoint;
                        secondPointResult = secondPoint;
                    }
                }
            }

            Console.WriteLine($"{minimumDistance:f3}");
            Console.WriteLine(firstPointResult.Print());
            Console.WriteLine(secondPointResult.Print());
        }

        public static double Distance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);
            return Math.Sqrt(squareX + squareY);
        }
        public static Point ReadPoint()
        {
            var pointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
        }
    }
}
