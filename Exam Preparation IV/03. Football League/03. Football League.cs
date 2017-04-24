using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Football_League
{
    public class Program
    {
        public class Score
        {
            public int Goals { get; set; }
            public int Points { get; set; }
        }
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());
            var patern = $@"^.*(?:{key})(?<team1>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<team2>[a-zA-Z]+[a-zA-Z]*)(?:{key}).* (?<team1score>\d+):(?<team2score>\d+).*$";
            var regex = new Regex(patern);
            var teamScore = new Dictionary<string, Score>();
            var line = Console.ReadLine();

            while (line != "final")
            {
                var match = regex.Match(line);

                if (!match.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }
                var team1 = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var team2 = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var team1score = int.Parse(match.Groups["team1score"].Value);
                var team2score = int.Parse(match.Groups["team2score"].Value);

                if (!teamScore.ContainsKey(team1))
                {
                    teamScore[team1] = new Score();
                }
                if (!teamScore.ContainsKey(team2))
                {
                    teamScore[team2] = new Score();
                }

                if (team1score > team2score)
                {
                    teamScore[team1].Points += 3;
                    teamScore[team1].Goals += team1score;
                    teamScore[team2].Goals += team2score;
                }
                else if (team2score > team1score)
                {
                    teamScore[team2].Points += 3;
                    teamScore[team2].Goals += team2score;
                    teamScore[team1].Goals += team1score;
                }
                else
                {
                    teamScore[team1].Points++;
                    teamScore[team2].Points++;
                    teamScore[team1].Goals += team1score;
                    teamScore[team2].Goals += team2score;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine($"League standings:");
            var point = 0;
            foreach (var team in teamScore.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key))
            {
                point++;
                Console.WriteLine($"{point}. {team.Key} {team.Value.Points}");
            }

            Console.WriteLine($"Top 3 scored goals:");
            foreach (var team in teamScore.OrderByDescending(x => x.Value.Goals).ThenBy(x => x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
            }
        }
    }
}
