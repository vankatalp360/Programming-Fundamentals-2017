using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var pricePerCapsule = 0M;
            var orderTime = new DateTime();
            var capsulesCount = 0;
            var price = 0M;
            var daysInMonth = 0;
            var totalPrice = 0M;

            for (int i = 0; i < n; i++)
            {
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                orderTime = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                capsulesCount = int.Parse(Console.ReadLine());
                daysInMonth = DateTime.DaysInMonth(orderTime.Year, orderTime.Month);
                price = (((long)daysInMonth * capsulesCount) * pricePerCapsule);
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
