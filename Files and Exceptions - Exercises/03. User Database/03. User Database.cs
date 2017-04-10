using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace _03.User_Database
{
    public class Program
    {
        public static void Main()
        {
            var profils = new Dictionary<string, UserDatabase>();
            var loginedUser = string.Empty;
            var fileData = new StringBuilder();

            string[] users = File.ReadAllLines("../../users.txt");
            foreach (var user in users)
            {
                var token = user.Split(' ');
                var name = token[0];
                var password = token[1];
                profils[name] = new UserDatabase
                {
                    Username = name,
                    Password = password
                };
            }

            var line = Console.ReadLine();

            while (line != "exit")
            {
                var token = line.Split(' ');
                var command = token[0];

                if (command == "register")
                {
                    var name = token[1];
                    var password = token[2];
                    var confirmPassword = token[3];
                    if (profils.ContainsKey(name))
                    {
                        Console.WriteLine("The given username already exists.");
                    }
                    else
                    {
                        if (password == confirmPassword)
                        {
                            UserDatabase user = new UserDatabase
                            {
                                Username = name,
                                Password = password
                            };
                            profils[name] = user;
                        }
                        else
                        {
                            Console.WriteLine("The two passwords must match.");
                        }
                    }

                }

                if (command == "login")
                {
                    var name = token[1];
                    var password = token[2];
                    if (loginedUser != string.Empty)
                    {
                        Console.WriteLine("There is already a logged in user.");
                    }
                    else
                    {
                        if (!profils.ContainsKey(name))
                        {
                            Console.WriteLine("There is no user with the given username.");
                        }
                        else
                        {
                            if (password != profils[name].Password)
                            {
                                Console.WriteLine("The password you entered is incorrect.");
                            }
                            else
                            {
                                loginedUser = name;
                            }
                        }
                    }
                }

                if (command == "logout")
                {
                    if (loginedUser != string.Empty)
                    {
                        loginedUser = string.Empty;
                    }
                    else
                    {
                        Console.WriteLine("There is no currently logged in user.");
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var profil in profils)
            {
                fileData.AppendLine($"{profil.Value.Username} {profil.Value.Password}");
            }

            File.WriteAllText("../../users.txt", fileData.ToString().Trim());
        }
    }
}
