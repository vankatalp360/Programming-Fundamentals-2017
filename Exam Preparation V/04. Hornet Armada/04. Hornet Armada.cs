using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var legions = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ', '=', '-', '>', ':' },StringSplitOptions.RemoveEmptyEntries);
                var lastActivity = int.Parse(line[0]);
                var legionName = line[1];
                var soldierType = line[2];
                var soldierCount = long.Parse(Console.ReadLine());
                
                if (legions.ContainsKey(legionName))
                {
                    if (legions[legionName].ContainsKey(soldierType))
                    {
                        legions[legionName][soldierType]
                    }
                }

            }
        }
    }
}
