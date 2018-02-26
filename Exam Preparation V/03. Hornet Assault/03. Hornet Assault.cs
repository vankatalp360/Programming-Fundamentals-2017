using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    public class Program
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

            long power = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (beehives[i] < power)
                {
                    beehives.RemoveAt(i);
                    i--;
                }
                else if (beehives[i] == power)
                {
                    beehives.RemoveAt(i);
                    i--;
                    power -= hornets[0];
                    hornets.RemoveAt(0);
                }
                else
                {
                    beehives[i] -= power;
                    power -= hornets[0];
                    hornets.RemoveAt(0);
                }

                if (!hornets.Any() || !beehives.Any())
                {
                    break;
                }
            }

            Console.WriteLine(beehives.Any()
                ? string.Join(" ", beehives)
                : string.Join(" ", hornets));

        }
    }
}
