using System;

namespace _01.Day_of_Week
{
    public class Program
    {
        public static void Main()
        {
            string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int Day = int.Parse(Console.ReadLine());

            if (Day > 7 || Day <= 0)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(Days[Day - 1]);
            }
        }
    }
}
