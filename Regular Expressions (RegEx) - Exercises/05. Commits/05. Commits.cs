using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05.Commits
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var nameRegex = new Regex();

            while (line != "git push")
            {
                var token = line.Split(new[] { ',', '/', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                var name = token[2];
                var repo = token[3];
                var hash = token[5];
                var message = token[6];
                var additions = int.Parse(token[7]);
                var deletions = int.Parse(token[8]);



                line = Console.ReadLine();
            }


        }
    }
}
