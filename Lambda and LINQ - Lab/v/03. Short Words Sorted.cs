using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Short_Words_Sorted
{
    public class Program
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(new char[]
                {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '}
                ,StringSplitOptions.RemoveEmptyEntries)
                .ToList<string>();

            var result = words
                .Where(w => w.Length < 5)
                .Distinct()
                .OrderBy(x => x)
                .ToList<string>();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
