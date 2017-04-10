using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Fish_Statistics
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var allFishes = new List<string>();
            var result = new List<FishInformation>();

            Regex regex = new Regex("[>]*[<][(]+['x-][>]");

            MatchCollection fishes = regex.Matches(input);

            foreach (Match fish in fishes)
            {
                allFishes.Add(fish.Value);
            }

            foreach (var fish in allFishes)
            {
                var tailInCm = 0;
                var bodylInCm = 0;
                var status = "";
                foreach (var symbol in fish)
                {
                    if (symbol == '>')
                    {
                        tailInCm++;
                    }
                    else if (symbol == '(')
                    {
                        bodylInCm++;
                    }
                    else if (symbol == '\'')
                    {
                        status = "Awake";
                    }
                    else if (symbol == '-')
                    {
                        status = "Asleep";
                    }
                    else if (symbol == 'x')
                    {
                        status = "Dead";
                    }
                }

                tailInCm--;
                var tail = "";
                var body = "";

                if (tailInCm > 5)
                {
                    tail = "Long";
                }
                else if (tailInCm > 1 && tailInCm <= 5)
                {
                    tail = "Medium";
                }
                else if (tailInCm == 1)
                {
                    tail = "Short";
                }
                else if (tailInCm == 0)
                {
                    tail = "None";
                }

                if (bodylInCm > 10)
                {
                    body = "Long";
                }
                else if (bodylInCm > 5 && bodylInCm <= 10)
                {
                    body = "Medium";
                }
                else
                {
                    body = "Short";
                }

                tailInCm *= 2;
                bodylInCm *= 2;

                var currentFish = new FishInformation
                {
                    Fish = fish,
                    TailInCm = tailInCm,
                    Tail = tail,
                    BodyInCm = bodylInCm,
                    Body = body,
                    Status = status
                };
                result.Add(currentFish);
            }

            if (result.Count > 0)
            {
                var counter = 0;
                foreach (var fish in result)
                {
                    counter++;
                    Console.WriteLine($"Fish {counter}: {fish.Fish}");
                    if (fish.TailInCm == 0)
                    {
                        Console.WriteLine($"  Tail type: None");
                    }
                    else
                    {
                        Console.WriteLine($"  Tail type: {fish.Tail} ({fish.TailInCm} cm)");
                    }
                    Console.WriteLine($"  Body type: {fish.Body} ({fish.BodyInCm} cm)");
                    Console.WriteLine($"  Status: {fish.Status}");
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }

        }
    }
}
