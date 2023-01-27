using System;

using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {

            var reader = new StreamReader(inputFilePath);
            var writer = new StreamWriter(outputFilePath);

            int i = 0;

            using (reader)
            {
                using (writer)
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (i % 2 != 0)
                        {
                            writer.WriteLine(line);
                        }

                        i++;
                    }

                }
            }



        }
    }
}
