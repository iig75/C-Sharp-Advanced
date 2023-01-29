using System;
using System.IO;

namespace CopyDirectory
{
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath = @"C:\Users\iig\Desktop\Test\";         //@$"{Console.ReadLine()}";
            string outputPath = @"C:\Users\iig\Desktop\Test - Copy\"; //@$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }



        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if(Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }

            Directory.CreateDirectory(outputPath);

            string[] files = Directory.GetFiles(inputPath); 

            foreach(string file in files)
            {
                string filename = Path.GetFileName(file);
                
                string destination = Path.Combine(outputPath, filename);

                File.Copy(file, destination);
            }
        }

    }
}

