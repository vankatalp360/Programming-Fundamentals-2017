﻿using System;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = (double)(2 * width + 2 * height);
            double area = (double)(width * height);
            double diagonal = (Math.Sqrt(width * width + height * height));
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
