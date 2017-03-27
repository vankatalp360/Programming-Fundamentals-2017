using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public static int CalculateDistance(Point first, Point second)
        {
            var squareX = Math.Pow(first.X - second.X, 2);
            var squareY = Math.Pow(first.Y - second.Y, 2);
            return (int)Math.Sqrt(squareX + squareY);
        }
    }
}
