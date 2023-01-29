using System;

namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> filesExtensions = new SortedDictionary<string, List<FileInfo>>();

            StringBuilder sb = new StringBuilder();

            string[] files = Directory.GetFiles(inputFolderPath);  

            foreach(string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                if(!filesExtensions.ContainsKey(fileInfo.Extension))
                {
                    filesExtensions.Add(fileInfo.Extension, new List<FileInfo>());
                }

                filesExtensions[fileInfo.Extension].Add(fileInfo);
            }

            foreach(var fileExtension in filesExtensions.OrderByDescending(x=>x.Value.Count))
            {
                sb.AppendLine(fileExtension.Key);

                foreach(var file in fileExtension.Value.OrderBy(x=>x.Length))
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length / 1024 :f3}kb");                    
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(filePath, textContent);
        }
    }
}

