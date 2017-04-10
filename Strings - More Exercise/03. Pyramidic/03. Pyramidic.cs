using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Pyramidic
{
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            pyramids(lines);
        }

        public static void pyramids(string[] lines)
        {
            var pyramids = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                var currentLine = lines[i];

                for (int j = 0; j < currentLine.Length; j++)
                {
                    var currentChar = currentLine[j];
                    var layer = 1;
                    var currentPiramid = "";

                    for (int k = i; k < lines.Length; k++)
                    {
                        var currentLayer = new string(currentChar, layer);

                        if (lines[k].Contains(currentLayer))
                        {
                            currentPiramid += currentLayer + "\r\n";
                        }
                        else
                        {
                            break;
                        }

                        layer += 2;
                    }
                    pyramids.Add(currentPiramid.Trim());
                }
            }
            Console.WriteLine(pyramids.OrderByDescending(x => x.Length).First());
        }
    }
}
