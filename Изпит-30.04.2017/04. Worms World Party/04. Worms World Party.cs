using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    public class Worm
    {
        public string Name { get; set; }
        public string Team { get; set; }
        public long Score { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var allWorms = new Dictionary<string, Worm>();
            var teams = new Dictionary<string, List<long>>();
            var warmsInTeam = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "quit")
                {
                    break;
                }

                var token = line.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                var wormName = token[0].Trim();
                var teamName = token[1].Trim();
                var wormScore = long.Parse(token[2].Trim());

                if (allWorms.ContainsKey(wormName))
                {
                    continue;
                }

                var currentWorm = new Worm
                {
                    Name = wormName,
                    Team = teamName,
                    Score = wormScore
                };

                allWorms[wormName] = currentWorm;
            }

            foreach (var worm in allWorms)
            {
                if (!teams.ContainsKey(worm.Value.Team))
                {
                    teams[worm.Value.Team] = new List<long>();
                    teams[worm.Value.Team].Add(0);
                    teams[worm.Value.Team].Add(0);
                }
                teams[worm.Value.Team][0] += worm.Value.Score;
                teams[worm.Value.Team][1] += 1;

                if (!warmsInTeam.ContainsKey(worm.Value.Team))
                {
                    warmsInTeam[worm.Value.Team] = new Dictionary<string, long>();
                }
                warmsInTeam[worm.Value.Team][worm.Value.Name] = worm.Value.Score;
            }

            var counter = 0;
            foreach (var team in teams.OrderByDescending(t => t.Value[0])
                .ThenBy(t => t.Value[1]))
            {
                counter++;
                Console.WriteLine($"{counter}. Team: {team.Key} - {team.Value[0]}");
                foreach (var worm in warmsInTeam[team.Key].OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }

            }
        }
    }
}
