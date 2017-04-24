using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms
{
    public class Program
    {
        public static void Main()
        {
            var demos = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var numberRegex = new Regex(@"-?\d+\.?\d*");
            var symbolRegex = new Regex(@"[\*\/]");

            foreach (var demon in demos.OrderBy(x => x))
            {
                var healthSymbols = demon
                    .Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.').ToList();
                var damageNumbers = numberRegex.Matches(demon);
                var symbols = symbolRegex.Matches(demon);
                var health = 0;
                var damage = 0.0;
                foreach (var symbol in healthSymbols)
                {
                    health += (int)symbol;
                }
                foreach (var number in damageNumbers)
                {
                    damage += double.Parse(number.ToString());
                }
                foreach (var symbol in symbols)
                {
                    if (symbol.ToString() == "*")
                    {
                        damage *= 2;
                    }
                    else if (symbol.ToString() == "/")
                    {
                        damage /= 2;
                    }
                }
                Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");
            }
        }
    }
}
