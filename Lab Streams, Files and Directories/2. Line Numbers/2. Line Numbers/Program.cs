using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            var writer = new StreamWriter(outputFilePath);

            using (reader)
            {
                using (writer)
                {
                    int i = 1;
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        line = $"{i}. " + line;

                        writer.WriteLine(line);

                        i++;
                    }




                }




            }


        }
    }
}

