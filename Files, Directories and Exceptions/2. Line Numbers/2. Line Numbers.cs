using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _2.Line_Numbers
{
    public class Program
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("../../../Resources/02. Line Numbers/Input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("../../../Resources/02. Line Numbers/Input1.txt", i + 1 + "." + " "  + text[i] + "\r\n");
            }
        }
    }
}
