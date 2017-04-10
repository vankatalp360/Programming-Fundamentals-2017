using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Placeholders
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();


            while (line != "end")
            {
                var token = line.Split(new[] { '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                var sentence = token[0].Trim();
                var vales = token[1].Trim().Split(new[] { ',', ' ' }
                , StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < vales.Length; i++)
                {
                    string currentPlacholder = "{" + i + "}";
                    sentence = sentence.Replace(currentPlacholder, vales[i]);
                }

                Console.WriteLine(sentence);

                line = Console.ReadLine();
            }
        }
    }
}
