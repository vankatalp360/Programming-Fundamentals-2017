using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _1.Odd_Lines
{
    public class Program
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("../../../Resources/01. OddLines/Input.txt");

            for (int i = 1; i < text.Length; i+=2)
            {
                File.AppendAllText("../../../Resources/01. OddLines/Input1.txt", text[i] + "\r\n");
            }
        }
    }
}
