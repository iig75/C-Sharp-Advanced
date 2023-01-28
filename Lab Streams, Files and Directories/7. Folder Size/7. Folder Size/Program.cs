using System;
using System.Drawing;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }



        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long size = GetFolderSize(folderPath);

            File.WriteAllText(outputFilePath, $"{size / 1024} KB");
        }



        public static long GetFolderSize(string path)
        {
            string[] filePaths = Directory.GetFiles(path);

            long size = 0;

            foreach (var filePath in filePaths)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                size += fileInfo.Length;
            }

            foreach(var dirPaths in Directory.GetDirectories(path))
            {
                size += GetFolderSize(dirPaths);
            }    

            return size;
        }
    }
}

