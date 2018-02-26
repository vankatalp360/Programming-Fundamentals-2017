using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Cubic_Messages
{
    public class Program
    {
        public static void Main()
        {
            var patern = @"^(?<firstPart>\d+)(?<message>[a-zA-Z]+)(?<secondPart>[^a-zA-Z]+)?$";
            var regex = new Regex(patern);


            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Over!")
                {
                    break;
                }

                var number = int.Parse(Console.ReadLine());
                var match = regex.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                var message = match.Groups["message"].Value;
                var firstPart = match.Groups["firstPart"].Value;
                var secondPart = match.Groups["secondPart"].Value;

                if (message.Count() != number)
                {
                    continue;
                }

                var verificationCode = string.Empty;


                foreach (var digit in firstPart)
                {
                    var index = int.Parse(digit.ToString());
                    if (index >= message.Count() || message.Count() < 0)
                    {
                        verificationCode += " ";
                    }
                    else
                    {
                        verificationCode += message[index];
                    }
                }

                foreach (var symbol in secondPart)
                {
                    var index = 0;
                    var iSIndex = int.TryParse(symbol.ToString(), out index);

                    if (index >= message.Count() || message.Count() < 0 || !iSIndex)
                    {
                        verificationCode += " ";
                    }
                    else
                    {
                        verificationCode += message[index];
                    }
                }

                Console.WriteLine($"{message} == {verificationCode}");
            }
        }
    }
}
