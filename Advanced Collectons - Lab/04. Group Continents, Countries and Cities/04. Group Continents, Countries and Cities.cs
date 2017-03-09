using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Group_Continents__Countries_and_Cities
{
    public class Program
    {
        public static void Main()
        {
            var data = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split(' ');
                var continent = token[0];
                var country = token[1];
                var city = token[2];

                if (!data.ContainsKey(continent))
                {
                    data[continent] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!data[continent].ContainsKey(country))
                {
                    data[continent][country] = new SortedSet<string>();
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
