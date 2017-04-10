using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Word_Encounter
{
    public class Program
    {
        public static void Main()
        {
            var filter = Console.ReadLine();
            var line = Console.ReadLine();
            Regex firstRegex = new Regex(@"\w+");
            var charFilter = filter[0];
            var numberfilter = int.Parse(filter[1].ToString());
            var result = new List<string>();
            Regex secondRegex = new Regex("[A-Z].+[.!?]");

            while (line != "end")
            {
                var first = secondRegex.Match(line).ToString();
                
                if (first == line)
                {
                    MatchCollection words = firstRegex.Matches(line);

                    foreach (Match word in words)
                    {
                        var counter = 0;
                        foreach (var symbol in word.ToString())
                        {
                            if (symbol == charFilter)
                            {
                                counter++;
                            }
                        }
                        if (counter >= numberfilter)
                        {
                            result.Add(word.ToString());
                        }
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
