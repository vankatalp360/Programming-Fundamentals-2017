using System;

namespace _04.Numbers_in_Reversed_Order
{
    public class Program
    {
        public static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            string answer = ReversedOrder(number);
            Console.WriteLine(answer);
        }

        public static string ReversedOrder(decimal number)
        {
            string answer = "";
            foreach (var symbol in number.ToString())
            {
                answer = symbol + answer;
            }
            return answer;
        }
    }
}
