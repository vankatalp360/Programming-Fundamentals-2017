using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Websites
{
    public class Program
    {
        public static void Main()
        {
            var websiteList = new List<Website>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var token = line.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var host = token[0];
                var domain = token[1];
                var queryList = new List<string>();
                if (token.Length > 2)
                {
                    for (int i = 2; i < token.Length; i++)
                    {
                        queryList.Add(token[i]);
                    }
                }
                var website = new Website
                {
                    Host = host,
                    Domain = domain,
                    Queries = queryList
                };
                websiteList.Add(website);

                line = Console.ReadLine();
            }

            foreach (var website in websiteList)
            {
                if (website.Queries.Count > 0)
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}/query?=");
                    for (int i = 0; i < website.Queries.Count; i++)
                    {
                        Console.Write($"[{website.Queries[i]}]");
                        if (i < website.Queries.Count - 1)
                        {
                            Console.Write("&");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
                Console.WriteLine();
            }
        }
    }
}
