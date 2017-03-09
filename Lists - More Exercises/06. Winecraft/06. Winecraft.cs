using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Winecraft
{
    public class Program
    {
        public static void Main()
        {
            var grapes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var days = int.Parse(Console.ReadLine());
            

            for (int k = 0; k < days; k++)
            {
                for (int i = 0; i < grapes.Count; i++)
                {
                    grapes[i]++;
                }
                for (int i = 0; i < grapes.Count; i++)
                {

                    if (i > 0 & i < grapes.Count - 1)
                    {
                        if (grapes[i] > grapes[i - 1] && grapes[i] > grapes[i + 1])
                        {
                            if (grapes[i - 1] == 1)
                            {
                                grapes[i - 1] = 0;
                                grapes[i + 1] -= 2;
                            }
                            else if (grapes[i + 1] == 1)
                            {
                                grapes[i + 1] = 0;
                                grapes[i - 1] -= 2;
                            }
                            else
                            {
                                grapes[i] += 1;
                                grapes[i - 1] -= 2;
                                grapes[i + 1] -= 2;
                            }
                        }
                    }
                }
                if (k == days - 1)
                {
                    for (int i = 0; i < grapes.Count; i++)
                    {
                        if (grapes[i] <= days)
                        {
                            grapes.Remove(grapes[i]);
                            i--;
                        }
                    }
                }
                if (k == days - 1 && grapes.Count >= days)
                {
                    k = -1;
                }
            }

            Console.WriteLine(string.Join(" ", grapes));

        }
    }
}
