using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(\D+)(\d+)");
            var couple = regex.Matches(input);
            var result = new StringBuilder();

            foreach (Match match in couple)
            {
                var word = match.Groups[1].Value.ToUpper();
                var times = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < times; i++)
                {
                    result.Append(word);
                }
                
            }

            int count = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }
    }
}
