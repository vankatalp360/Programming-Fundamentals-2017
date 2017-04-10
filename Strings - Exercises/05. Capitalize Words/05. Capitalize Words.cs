using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.Capitalize_Words
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var chars = new Char[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' };
            
            while (line != "end")
            {
                var token = line.Split(chars,StringSplitOptions.RemoveEmptyEntries);
                var result = Capitalize_Words(token);
                Console.WriteLine(string.Join(", ", result));
                
                line = Console.ReadLine();
            }
            
        }

        public static string[] Capitalize_Words(string[] token)
        {
            for (int i = 0; i < token.Length; i++)
            {
                var word = string.Empty;
                var currentWord = token[i].ToLower();
                var chars = new Char[currentWord.Length];
                chars = currentWord.ToCharArray();
                var furstChar = chars[0].ToString().ToUpper();
                chars[0] = char.Parse(furstChar);
                foreach (var symbol in chars)
                {
                    word += symbol;
                }
                token[i] = word;
            }

            return token;
        }
    }
}
