using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Optimized_Banking_System
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var listBankAccounts = new List<BankAccount>();

            while (line != "end")
            {
                var token = line.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var bank = token[0];
                var accountName = token[1];
                decimal accountBalance = decimal.Parse(token[2]);

                var account = new BankAccount
                {
                    Bank = bank,
                    AccountName = accountName,
                    Balance = accountBalance
                };

                listBankAccounts.Add(account);

                line = Console.ReadLine();
            }

            foreach (var bank in listBankAccounts
                .OrderByDescending(x => x.Balance)
                .ThenBy(y => y.Bank.Length))
            {
                Console.WriteLine($"{bank.AccountName} -> {bank.Balance} ({bank.Bank})");
            }
        }
    }
}
