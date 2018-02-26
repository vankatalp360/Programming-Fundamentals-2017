using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var forward = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 0)
                {
                    forward++;
                    continue;
                }
                else
                {
                    var oldIndex = i;
                    i = numbers[i] - 1;
                    numbers[oldIndex] = 0;
                }
            }

            Console.WriteLine(forward);
        }
    }
}
