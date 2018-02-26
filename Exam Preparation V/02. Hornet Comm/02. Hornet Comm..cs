using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    public class Program
    {
        public static void Main()
        {
            var broadcasts = new List<string>();
            var messages = new List<string>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Hornet is Green")
                {
                    break;
                }

                var parts = line.Split(new[] { " <-> ",},StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                {
                    continue;
                }

                var firstPart = parts[0];
                var secondPart = parts[1];

                if (firstPart.All(char.IsDigit) && secondPart.All(char.IsLetterOrDigit))
                {
                    messages.Add($"{new string(firstPart.Reverse().ToArray())} -> {secondPart}");
                }
                else if (firstPart.All(s => !char.IsDigit(s)) && secondPart.All(char.IsLetterOrDigit))
                {
                    var frequency = new StringBuilder();

                    foreach (var symbol in secondPart)
                    {
                        if (char.IsLower(symbol))
                        {
                            frequency.Append(symbol.ToString().ToUpper());
                        }
                        else if (char.IsUpper(symbol))
                        {
                            frequency.Append(symbol.ToString().ToLower());
                        }
                        else
                        {
                            frequency.Append(symbol);
                        }
                    }

                    broadcasts.Add($"{frequency} -> {firstPart}");
                }

            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcasts.Any()
                ? string.Join(Environment.NewLine, broadcasts)
                : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Any()
                ? string.Join(Environment.NewLine, messages)
                : "None");
            
        }
    }
}
