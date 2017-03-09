using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.User_Logins
{
    public class Program
    {
        public static void Main()
        {
            var userInformation = new Dictionary<string, string>();

            var line = Console.ReadLine();
            var counter = 0;

            while (line != "login")
            {
                var tokens = line.Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                var username = tokens[0];
                var password = tokens[1];
                userInformation[username] = password;
                line = Console.ReadLine();

            }

            line = Console.ReadLine();
            while (line != "end")
            {
                var tokens = line.Split(" -> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
                var username = tokens[0];
                var password = tokens[1];

                if (userInformation.ContainsKey(username))
                {
                    if (password == userInformation[username])
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{username}: login failed");
                        counter++;
                    }
                }
                else
                {
                    Console.WriteLine($"{username}: login failed");
                    counter++;
                }
                line = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {counter}");
        }
    }
}
