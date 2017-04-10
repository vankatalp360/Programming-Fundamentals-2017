using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _05.Folder_Size
{
    public class Program
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles("../../../Resources/05. Folder Size/TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                sum += fileinfo.Length;
            }

            sum = sum / 1024 / 1024;
            File.AppendAllText("../../../Resources/05. Folder Size/TestFolder1.txt", sum.ToString());
        }
    }
}
