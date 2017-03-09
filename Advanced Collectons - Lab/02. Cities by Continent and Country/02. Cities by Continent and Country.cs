using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Cities_by_Continent_and_Country
{
    public class Program
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, List<string>>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split(' ');
                var continent = token[0];
                var country = token[1];
                var city = token[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new Dictionary<string, List<string>>();
                }

                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new List<string>(); 
                }

                data[continent][country].Add(city);
            }

            foreach (var kvp in data)
            {
                var continent = kvp.Key;
                Console.WriteLine($"{continent}:");

                foreach (var coutriesAndCities in kvp.Value)
                {
                    var coutry = coutriesAndCities.Key;
                    Console.Write($"  {coutry} -> {string.Join(", ", coutriesAndCities.Value)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
