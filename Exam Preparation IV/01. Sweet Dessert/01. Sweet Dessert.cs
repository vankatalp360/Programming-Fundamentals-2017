using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    public class Program
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = long.Parse(Console.ReadLine());
            var bananasPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());
            int setsOfPortions = (int)Math.Ceiling((decimal)guests / 6);
            var neededBanans = setsOfPortions * 2;
            var neededEggs = setsOfPortions * 4;
            var neededBerries = setsOfPortions * 0.2;

            var neededMoney = (neededBanans * bananasPrice) + (neededEggs * eggsPrice) + ((decimal)neededBerries * berriesPrice);

            if (cash >= neededMoney)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(neededMoney - cash):f2}lv more.");
            }
        }
    }
}