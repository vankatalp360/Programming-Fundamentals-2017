using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _01.Day_of_Week
{
    public class Program
    {
        public static void Main()
        {
            var dateTime = Console.ReadLine();
            var data = DateTime.ParseExact(dateTime, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(data.DayOfWeek);
        }
    }
}
