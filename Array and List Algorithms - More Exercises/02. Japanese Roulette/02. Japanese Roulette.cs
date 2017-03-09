using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Japanese_Roulette
{
    public class Program
    {
        public static void Main()
        {
            var revolver = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var players = Console.ReadLine().Split(' ').ToList();
            string left = "Left";
            string right = "Right";
            var bullet = 0; ;
            var position = 2;
            var playerNumber = -1;
            foreach (var bulletHole in revolver)
                if (bulletHole > 0)
                    bullet = bulletHole;
            for (int i = 0; i < players.Count; i++)
            {
                var player = players[i].Split(',').ToArray();
                var spins = int.Parse(player[0]);
                var direction = player[1];
                if (direction == left)
                {
                    while (spins > 0)
                    {
                        position++;
                        spins--;
                        if (position > revolver.Count - 1)
                            position = 0;
                    }
                }
                else if (direction == right)
                {
                    while (spins > 0)
                    {
                        position--;
                        spins--;
                        if (position < 0)
                            position = revolver.Count - 1;
                    }
                }
                if (revolver[position] == bullet)
                {
                    playerNumber = i;
                    break;
                }
                position--;
                if (position < 0)
                    position = revolver.Count - 1;
            }
            if (playerNumber < 0)
                Console.WriteLine("Everybody got lucky!");
            else
            {
                Console.WriteLine("Game over! Player {0} is dead.", playerNumber);
            }
        }
    }
}
