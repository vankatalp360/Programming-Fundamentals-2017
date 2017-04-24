using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Winning_Ticket
{

    public class Program
    {
        public class Reward
        {
            public string Ticket { get; set; }
            public int MatchLenght { get; set; }
            public string MatchSymbol { get; set; }
            public string Jackpot { get; set; }
            public string NoMatch { get; set; }
            public string InvalidTicket { get; set; }
        }
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var regex = new Regex(@"([$#^@])\1{5,}");
            var allTickets = new List<Reward>();

            foreach (var ticket in tickets)
            {
                if (ticket.Length == 20)
                {
                    var firstPart = ticket.Substring(0, ticket.Length / 2);
                    var secondPart = ticket.Substring(ticket.Length / 2);
                    var firstMatch = regex.Match(firstPart);
                    var secondMatch = regex.Match(secondPart);
                    var match = firstMatch;
                    var matchLength = Math.Min(firstMatch.Length, secondMatch.Length);

                    if (firstMatch.Success && secondMatch.Success)
                    {
                        if (matchLength >= 6 && matchLength <= 9)
                        {
                            var currentReward = new Reward
                            {
                                Ticket = ticket,
                                MatchLenght = matchLength,
                                MatchSymbol = match.ToString()[0] + ""
                            };
                            allTickets.Add(currentReward);
                        }
                        else if (matchLength == 10)
                        {
                            var currentReward = new Reward
                            {
                                Ticket = ticket,
                                MatchLenght = matchLength,
                                MatchSymbol = match.ToString()[0] + "",
                                Jackpot = "Jackpot!"
                            };
                            allTickets.Add(currentReward);
                        }
                    }

                    else
                    {
                        var currentTicket = new Reward
                        {
                            Ticket = ticket,
                            NoMatch = "no match"
                        };
                        allTickets.Add(currentTicket);
                    }
                }
                else
                {
                    var currentTicket = new Reward
                    {
                        InvalidTicket = "invalid ticket"
                    };
                    allTickets.Add(currentTicket);
                }
                
            }

            foreach (var ticket in allTickets)
            {
                if (ticket.Jackpot == null && ticket.NoMatch == null && ticket.InvalidTicket == null)
                {
                    Console.WriteLine($"ticket \"{ticket.Ticket}\" - {ticket.MatchLenght}{ticket.MatchSymbol}");
                }
                else if (ticket.Jackpot != null)
                {
                    Console.WriteLine($"ticket \"{ticket.Ticket}\" - {ticket.MatchLenght}{ticket.MatchSymbol} Jackpot!");
                }
                else if (ticket.InvalidTicket != null)
                {
                    Console.WriteLine("invalid ticket");
                }
                else if (ticket.NoMatch != null)
                {
                    Console.WriteLine($"ticket \"{ticket.Ticket}\" - no match");
                }
            }
        }
    }
}
