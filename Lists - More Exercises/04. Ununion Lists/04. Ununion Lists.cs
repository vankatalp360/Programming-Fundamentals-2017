using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Ununion_Lists
{
    public class Program
    {
        public static void Main()
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var number = int.Parse(Console.ReadLine());
            var lists = new List<int>();

            for (int a = 0; a < number; a++)
            {
                lists = Console.ReadLine().Split().Select(int.Parse).ToList();

                for (int b = 0; b < lists.Count; b++)
                {
                    if (!primalList.Contains(lists[b]))
                    {
                        primalList.Add(lists[b]);
                    }
                    else
                    {
                        for (int c = 0; c < primalList.Count; c++)
                        {
                            if (primalList[c] == lists[b])
                            {
                                primalList.RemoveAll(item => item == lists[b]);
                                c--;
                            }
                        }
                    }
                }
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ",primalList));
            
        }
    }
}
