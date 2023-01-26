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

            int i = 0;

            using(reader)
            {
                

                while(!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (i % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }

                    i++;
                }
            }



        }
    }
}

