using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Lambada_Expressions
{
    public class Program
    {
        public static void Main()
        {
            var lambada = new Dictionary<string, Dictionary<string, string>>();
            var line = Console.ReadLine();

            while (line != "lambada")
            {
                var token = line.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (token.Length > 1)
                {
                    var selector = token[0];
                    var objectt = token[1];
                    var property = token[2];
                    if (!lambada.ContainsKey(selector))
                    {
                        lambada[selector] = new Dictionary<string, string>();
                    }
                    lambada[selector][objectt] = property;
                }
                else
                {
                    lambada = lambada.ToDictionary(selector => selector.Key, selector => selector.Value
                    .ToDictionary(objectt => objectt.Key, objectt => objectt.Key + "." + objectt.Value));
                }

                line = Console.ReadLine();
            }

            foreach (var selector in lambada)
            {
                foreach (var objectt in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {objectt.Key}.{objectt.Value}");
                }
            }
        }
    }
}
