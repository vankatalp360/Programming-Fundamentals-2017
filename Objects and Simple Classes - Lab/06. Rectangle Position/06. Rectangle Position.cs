using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Rectangle_Position
{
    public class Program
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();
            var result = isInside(firstRectangle, secondRectangle);
            var printResult = result ? "Inside" : "Not inside";

            Console.WriteLine(printResult);
        }
        public static Rectangle ReadRectangle()
        {
            var Rectangle = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Rectangle
            {
                Left = Rectangle[0],
                Top = Rectangle[1],
                Width = Rectangle[2],
                Height = Rectangle[3]
            };
        }

        public static bool isInside(Rectangle first, Rectangle second)
        {
            var isTopInside = first.Top <= second.Top;
            var isLeftInside = first.Left >= second.Left;
            var isRightInside = first.Right <= second.Right;
            var isBottomInside = first.Bottom >= second.Bottom;

            return isTopInside && isLeftInside && isRightInside && isBottomInside;
        }
    }
}
