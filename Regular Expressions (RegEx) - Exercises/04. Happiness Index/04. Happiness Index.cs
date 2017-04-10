using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Happiness_Index
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var happy = new Regex(@"([:;][)D*\]}]|[c(*\[{][:;])");
            var sad = new Regex(@"([:;][c(\[{]|[)D\]}][:;])");
            var happyCount = 0;
            var sadCount = 0;
            decimal happinessIndex = 0;
            var finalEmoticon = "";

            MatchCollection happyEmoticon = happy.Matches(input);
            MatchCollection sadEmoticon = sad.Matches(input);
            happyCount = happyEmoticon.Count;
            sadCount = sadEmoticon.Count;
            happinessIndex = (decimal)happyCount / sadCount;
            if (happinessIndex >= 2)
            {
                finalEmoticon = ":D";
            }
            else if (happinessIndex > 1 && happinessIndex < 2)
            {
                finalEmoticon = ":)";
            }
            else if (happinessIndex == 1)
            {
                finalEmoticon = ":|";
            }
            else if (happinessIndex < 1)
            {
                finalEmoticon = ":(";
            }

            Console.WriteLine($"Happiness index: {happinessIndex:F2} {finalEmoticon}");
            Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");

        }
    }
}
