using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Sales_Report
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var SalesReport = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentSale = Town();

                if (!SalesReport.ContainsKey(currentSale.Town))
                {
                    SalesReport[currentSale.Town] = 0;
                }

                SalesReport[currentSale.Town] += currentSale.Sale;
            }

            foreach (var sale in SalesReport)
            {
                Console.WriteLine($"{sale.Key} -> {sale.Value:f2}");
            }
        }

        public static Sales Town()
        {
            var currentTown = Console.ReadLine().Split(' ').ToArray();

            return new Sales
            {
                Town = currentTown[0],
                Product = currentTown[1],
                Price = decimal.Parse(currentTown[2]),
                Quantity = decimal.Parse(currentTown[3])
            };
        }
    }
}
