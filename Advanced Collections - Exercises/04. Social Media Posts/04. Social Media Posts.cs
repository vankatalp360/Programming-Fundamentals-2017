using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Social_Media_Posts
{
    public class Program
    {
        public static void Main()
        {
            var SocialPost = new Dictionary<string, Dictionary<string, List<string>>>();
            var line = Console.ReadLine();

            while (line != "drop the media")
            {
                var token = line.Split(' ');
                var command = token[0];

                switch (command)
                {
                    case "post":
                        var name = token[1];
                        SocialPost[name] = new Dictionary<string, List<string>>();
                        if (!SocialPost[name].ContainsKey("Likes:"))
                        {
                            SocialPost[name]["Likes:"] = new List<string>();
                        }
                        if (!SocialPost[name].ContainsKey("Dislikes:"))
                        {
                            SocialPost[name]["Dislikes:"] = new List<string>();
                        }
                        if (!SocialPost[name].ContainsKey("Comments:"))
                        {
                            SocialPost[name]["Comments:"] = new List<string>();
                        }
                        break;
                    case "like":
                        name = token[1];
                        SocialPost[name]["Likes:"].Add("Like");
                        break;
                    case "dislike":
                        name = token[1];
                        SocialPost[name]["Dislikes:"].Add("Dislike");
                        break;
                    case "comment":
                        name = token[1];
                        var comment = "";
                        for (int i = 3; i < token.Length; i++)
                        {
                            if (i == 3)
                            {
                                comment = "*" + "  " + token[2] + ":" + " " + token[i];
                            }
                            else
                            {
                                comment = comment + " " + token[i];
                            }
                        }
                        SocialPost[name]["Comments:"].Add(comment);
                        break;
                }
                line = Console.ReadLine();
            }

            foreach (var post in SocialPost)
            {
                Console.WriteLine($"Post: {post.Key} | Likes: {post.Value["Likes:"].Count} | Dislikes: {post.Value["Dislikes:"].Count}");
                Console.WriteLine("Comments:");
                if (post.Value["Comments:"].Count == 0)
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var comment in post.Value["Comments:"])
                    {
                        Console.WriteLine(comment);
                    }
                }
            }
        }
    }
}
