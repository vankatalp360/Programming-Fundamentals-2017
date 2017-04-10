using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _01.Filter_Extensions
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
             
            string[] files = Directory.GetFiles("../../../Exercises-Resource/01. Filter-Extensions/input");
            
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo filesinfo = new FileInfo(files[i]);
                var filename = filesinfo.Name;
                var filenNameParts = filename.Split('.');
                var name = filenNameParts[0];
                var extension = filenNameParts[filenNameParts.Length - 1];

                if (name == input || extension == input)
                {
                    Console.WriteLine(filename);
                }
            }
        }
    }
}
