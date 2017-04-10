using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _04.Merge_Files
{
    public class Program
    {
        public static void Main()
        {
            string[] oneNumbers = File.ReadAllLines("../../../Resources/04. Merge Files/FileOne.txt");
            string[] twoNumbers = File.ReadAllLines("../../../Resources/04. Merge Files/FileTwo.txt");

            var numbers1 = oneNumbers.Select(int.Parse).ToList();
            var numbers2 = twoNumbers.Select(int.Parse).ToList();
            numbers1.AddRange(numbers2);
            
            numbers1.Sort();

            foreach (var number in numbers1)
            {
                File.AppendAllText("../../../Resources/04. Merge Files/FileThree.txt", number + "\r\n");
            }
        }
    }
}
