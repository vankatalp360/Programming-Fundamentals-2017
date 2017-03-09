using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Forum_Topics
{
    public class Program
    {
        public static void Main()
        {
            var forumTopics = new Dictionary<string, List<string>>();
            var line = Console.ReadLine();

            while (line != "filter")
            {
                var token = line.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var topic = token[0];

                if (!forumTopics.ContainsKey(topic))
                {
                    forumTopics[topic] = new List<string>();
                }

                for (int i = 1; i < token.Length; i++)
                {
                    if (!forumTopics[topic].Contains(token[i]))
                    {
                        forumTopics[topic].Add(token[i]);
                    }
                }
                line = Console.ReadLine();
            }

            line = Console.ReadLine();
            var tags = line.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var kvp in forumTopics)
            {
                var topic = kvp.Key;
                var counter = 0;

                foreach (var resulttag in tags)
                {
                    foreach (var tag in kvp.Value)
                    {
                        if (resulttag == tag)
                        {
                            counter++;
                        }
                    }
                }
                if (counter == tags.Length)
                {
                    for (int i = 0; i < kvp.Value.Count; i++)
                    {
                        kvp.Value[i] = "#" + kvp.Value[i];
                    }
                    Console.WriteLine($"{topic} | {string.Join(", ", kvp.Value)}");
                }
                
            }
        }
    }
}
