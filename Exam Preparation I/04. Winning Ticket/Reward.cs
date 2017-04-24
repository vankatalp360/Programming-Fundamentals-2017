using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
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
}
