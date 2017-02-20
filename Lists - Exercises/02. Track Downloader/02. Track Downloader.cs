using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Track_Downloader
{
    public class Program
    {
        public static void Main()
        {
            var blackList = Console.ReadLine().Split(' ').ToList();
            var fileNames = new List<string>();
            var download = new List<string>();
            bool stop = true;
            int count = 0;
            string input = "";

            while (stop)
            {
                fileNames.Add(input);
                input = Console.ReadLine();
                if (input == "end")
                {
                    stop = false;
                }
            }

            fileNames.RemoveAt(0);

            for (int i = 0; i < fileNames.Count; i++)
            {
                count = 0;
                for (int k = 0; k < blackList.Count; k++)
                {
                    if (fileNames[i].Contains(blackList[k]))
                    {
                    }
                    else
                    {
                        count++;
                    }
                    if (!fileNames[i].Contains(blackList[k]) && count == blackList.Count)
                    {
                        download.Add(fileNames[i]);
                    }
                }
            }

            download.Sort();
            Console.WriteLine(string.Join("\r\n", download));
        }
    }
}
