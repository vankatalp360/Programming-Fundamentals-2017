using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace _02.HTML_Contents
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var head = string.Empty;
            var builder = new StringBuilder();
            var result = new StringBuilder();
            var headTag = string.Empty;

            while (line != "exit")
            {
                var token = line.Split(' ');
                var tag = token[0];
                var content = token[1];
                if (tag == "title")
                {
                    head = content;
                }
                else
                {
                    builder.AppendLine($"\t<{tag}>{content}</{tag}>");
                }

                line = Console.ReadLine();
            }
            result.AppendLine("<!DOCTYPE html>");
            result.AppendLine("<html>");
            result.AppendLine("<head>");
            if (head != string.Empty)
            {
                result.AppendLine($"\t<{headTag}>{head}</{headTag}>");
            }
            result.AppendLine("</head>");
            result.AppendLine("<body>");
            result.AppendLine(string
                .Join(Environment.NewLine, builder).Trim());
            result.AppendLine("</body>");
            result.AppendLine("</html>");

            File.WriteAllText("../../index.html", result.ToString().Trim());
        }
    }
}
