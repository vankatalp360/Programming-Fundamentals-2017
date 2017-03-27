using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Boxes
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var boxes = new List<Box>();

            while (line != "end")
            {
                var token = line.Split(new[] { ' ', '|' }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();
                var upperL = token[0].Split(':').Select(int.Parse).ToArray();
                var upperR = token[1].Split(':').Select(int.Parse).ToArray();
                var bottomL = token[2].Split(':').Select(int.Parse).ToArray();
                var bottomR = token[3].Split(':').Select(int.Parse).ToArray();
                Point upperLeft = new Point
                {
                    X = upperL[0],
                    Y = upperL[1]
                };
                Point upperRight = new Point
                {
                    X = upperR[0],
                    Y = upperR[1]
                };
                Point bottomLeft = new Point
                {
                    X = bottomL[0],
                    Y = bottomL[1]
                };
                Point bottomRight = new Point
                {
                    X = bottomR[0],
                    Y = bottomR[1]
                };

                var currentBox = new Box
                {
                    UpperLeft = upperLeft,
                    UpperRight = upperRight,
                    BottomLeft = bottomLeft,
                    BottumRight = bottomRight
                };

                boxes.Add(currentBox);

                line = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                Console.WriteLine($"Box: {box.Width}, {box.Height}");
                Console.WriteLine($"Perimeter: {box.Perimeter}");
                Console.WriteLine($"Area: {box.Area}");


            }
        }
    }
}
