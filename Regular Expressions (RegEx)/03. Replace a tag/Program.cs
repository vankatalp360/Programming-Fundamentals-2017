using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Replace_a_tag
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            while (text != "end")
            {
                string pattern =
                         @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, pattern,
                                                           replace);
                Console.WriteLine(replaced);

                text = Console.ReadLine();
            }

        }
    }
}
