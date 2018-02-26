using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Worm Ipsum")
                {
                    break;
                }

                var token = line.Split(new[] { '.' },StringSplitOptions.RemoveEmptyEntries);

                if (token.Length > 1)
                {
                    continue;
                }

                var isHas2orMore = false;
                var word = "";
                var tokenParts = token[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < tokenParts.Length; i++)
                {
                    word = "";
                    isHas2orMore = false;

                    var wordCharecters = new Dictionary<char, long>();
                    foreach (var symbol in tokenParts[i])
                    {
                        if (!wordCharecters.ContainsKey(symbol))
                        {
                            wordCharecters[symbol] = 0;
                        }
                        wordCharecters[symbol]++;
                    }
                    long theBigNumber = 0;
                    var theBigSymbol = ' ';
                    foreach (var num in wordCharecters)
                    {
                        if (num.Value >= 2)
                        {
                            isHas2orMore = true;
                            if (num.Value > theBigNumber)
                            {
                                theBigNumber = num.Value;
                                theBigSymbol = num.Key;
                            }
                        }
                    }
                    for (int k = 0; k < tokenParts[i].Length; k++)
                    {
                        if (tokenParts[i].Contains(",") && k == tokenParts[i].Length - 1)
                        {
                            k++;
                            word += ',';
                        }
                        else
                        {
                            word += theBigSymbol;
                        }
                    }
                    if (isHas2orMore)
                    {
                        tokenParts[i] = word;
                    }
                }

                if (token.Length == 1)
                {
                    Console.WriteLine($"{string.Join(" ", tokenParts)}.");
                }

                
            }
        }
    }
}
