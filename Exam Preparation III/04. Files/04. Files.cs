using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();
            var filesByExtension = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var file = Console.ReadLine().Split('\\');
                var root = file[0];
                var fileParams = file[file.Length - 1].Split(';');
                var filenNameWithExtension = fileParams[0];
                var fileSize = long.Parse(fileParams[1]);
                var fileName = filenNameWithExtension;
                var fileExtension = fileName.Split('.')[fileName.Split('.').Length - 1];

                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot[root] = new Dictionary<string, long>();
                }
                filesByRoot[root][fileName] = fileSize;
                filesByExtension[fileName] = fileExtension;

            }

            var queryParams = Console.ReadLine().Split(' ');
            var queryExtension = queryParams[0];
            var queryRoot = queryParams[2];

            var extractedFiles = new Dictionary<string, long>();

            if (filesByRoot.ContainsKey(queryRoot))
            {
                foreach (var file in filesByRoot[queryRoot])
                {
                    if (filesByExtension[file.Key] == queryExtension)
                    {
                        extractedFiles[file.Key] = file.Value;
                    }
                }
            }

            if (extractedFiles.Count > 0)
            {
                foreach (var file in extractedFiles.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
