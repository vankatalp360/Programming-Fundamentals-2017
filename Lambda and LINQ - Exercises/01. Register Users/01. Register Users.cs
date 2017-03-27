using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _01.Register_Users
{
    public class Program
    {
        public static void Main()
        {
            var registerUser = new Dictionary<string, DateTime>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var token = line
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var username = token[0];
                DateTime date = DateTime.ParseExact(token[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                registerUser[username] = date;


                line = Console.ReadLine();
            }

            var result = registerUser
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var user in result)
            {
                Console.WriteLine(user.Key);
            }
        }
    }
}
