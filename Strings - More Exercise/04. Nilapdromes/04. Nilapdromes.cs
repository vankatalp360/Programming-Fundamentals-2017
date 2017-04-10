using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Nilapdromes
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();

            while (line != "end")
            {
                var borderFirst = line.Substring(0, line.Length / 2);
                var borderSecond = string.Empty;
                var border = string.Empty;
                var core = string.Empty;

                if (line.Length % 2 == 0)
                {
                    borderSecond = line.Substring(borderFirst.Length, line.Length - borderFirst.Length);
                }
                else
                {
                    borderSecond = line.Substring(borderFirst.Length + 1, line.Length - borderFirst.Length - 1);
                }

                while (true)
                {
                    if (borderFirst == borderSecond)
                    {
                        border = borderFirst;
                        break;
                    }
                    else if (borderFirst != borderSecond)
                    {
                        borderFirst = borderFirst.Substring(0, borderFirst.Length - 1);
                        borderSecond = borderSecond.Substring(1, borderSecond.Length - 1);
                    }

                    if (borderFirst.Length == 0 && borderSecond.Length == 0)
                    {
                        break;
                    }
                }

                if (border.Length != 0)
                {
                    core = line.Remove(line.Length - border.Length, border.Length).Trim();
                    core = core.Remove(0, border.Length).Trim();
                    if (core != "")
                    {
                        PrintNewWord(line, core, border);
                    }
                }
                line = Console.ReadLine();
            }


        }

        public static void PrintNewWord(string line, string core, string border)
        {
            core = line.Remove(0, border.Length);
            core = core.Remove(core.Length - border.Length, border.Length);
            line = core + border + core;
            Console.WriteLine(line);
        }
    }
}