using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    public class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottumRight { get; set; }

        public int Width
        {
            get
            {
                return Point.CalculateDistance(UpperLeft, UpperRight);
            }
        }

        public int Height
        {
            get
            {
                return Point.CalculateDistance(UpperLeft, BottomLeft);
            }
        }

        public int Perimeter
        {
            get
            {
                return (2 * Width + 2 * Height);
            }
        }
        public int Area
        {
            get
            {
                return (Width * Height);
            }
        }
    }
}
