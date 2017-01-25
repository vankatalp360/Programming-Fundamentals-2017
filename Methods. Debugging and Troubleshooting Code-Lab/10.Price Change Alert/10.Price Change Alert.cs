using System;

namespace _10.Price_Change_Alert
{
    public class PriceChangeAlert
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double significance = double.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            for (int prices = 0; prices < n - 1; prices++)
            {
                double nextPrice = double.Parse(Console.ReadLine());
                double differencePercent = Percent(price, nextPrice);
                bool isSignificantDifference = isDifference(differencePercent, significance);
                string message = Get(nextPrice, price, differencePercent, isSignificantDifference);

                Console.WriteLine(message);

                price = nextPrice;
            }
        }

        private static string Get(double nextPrice, double price, double difference, bool isSignificantDifference)
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", nextPrice);
            }
            else if (!isSignificantDifference)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", price, nextPrice, difference * 100);
            }

            return message;
        }

        private static bool isDifference(double difference, double significance)
        {
            if (Math.Abs(difference) >= significance)
            {
                return true;
            }

            return false;
        }

        private static double Percent(double price, double nextPrice)
        {
            double difference = (nextPrice - price) / price;
            return difference;
        }
    }
}
