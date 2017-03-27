using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int Bottom
        {
            get
            {
                return Top - Height;
            }
        }
    }
}
