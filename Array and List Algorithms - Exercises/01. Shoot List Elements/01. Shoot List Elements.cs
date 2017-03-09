using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Shoot_List_Elements
{
    public class Program
    {
        public static void Main()
        {
            var numbers = new List<int>();
            var comand = "";
            var smallerThanAverage = int.MinValue;
            var average = 0.0;

            do
            {
                comand = Console.ReadLine();
                if (comand != "bang" && comand != "stop")
                {
                    numbers.Insert(0, int.Parse(comand));
                }
                else if (comand == "bang")
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {smallerThanAverage}");
                        return;
                    }
                    else
                    {
                        average = numbers.Average();

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] <= average)
                            {
                                smallerThanAverage = numbers[i];
                                numbers.Remove(smallerThanAverage);
                                break;
                            }
                        }
                        Console.WriteLine($"shot {smallerThanAverage}");

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            numbers[i] -= 1;
                        }
                    }
                }
                else if (comand == "stop")
                {
                    break;
                }
            } while (comand != "stop");

            if (numbers.Count > 0)
            {
                Console.WriteLine($"survivors: {string.Join(" ", numbers)}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {smallerThanAverage}");
            }

        }
    }
}
