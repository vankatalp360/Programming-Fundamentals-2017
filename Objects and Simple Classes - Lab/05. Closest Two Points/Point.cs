﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        
        public string Print()
        {
            return $"({X}, {Y})";
        }
    }
}
