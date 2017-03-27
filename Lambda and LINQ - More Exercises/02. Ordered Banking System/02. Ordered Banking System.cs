using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Ordered_Banking_System
{
    public class Program
    {
        public static void Main()
        {
            var bankSystem = new Dictionary<string, Dictionary<string, decimal>>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var token = line.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var bank = token[0];
                var account = token[1];
                var balance = decimal.Parse(token[2]);

                if (!bankSystem.ContainsKey(bank))
                {
                    bankSystem[bank] = new Dictionary<string, decimal>();
                }
                if (!bankSystem[bank].ContainsKey(account))
                {
                    bankSystem[bank][account] = 0;
                }

                bankSystem[bank][account] = bankSystem[bank][account] + balance;

                line = Console.ReadLine();
            }

            bankSystem = bankSystem
                .OrderByDescending(bank => bank.Value.Sum(accounts => accounts.Value))
                .ThenByDescending(bank => bank.Value.Max(accounts => accounts.Value))
                .ToDictionary(bank => bank.Key, bank => bank.Value);

            foreach (var bank in bankSystem)
            {
                foreach (var account in bank.Value.OrderByDescending(accounts => accounts.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            }

        }
    }
}
