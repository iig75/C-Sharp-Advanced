using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {

            var reader1 = new StreamReader(bytesFilePath);
            var reader2 = new StreamReader(binaryFilePath);            
            var writer = new StreamWriter(outputPath);

            List<string> bytesList= new List<string>();



            using(reader1)
            {
                while(!reader1.EndOfStream)
                {
                    bytesList.Add(reader1.ReadLine());
                }
            }



            byte[] binFile = File.ReadAllBytes(binaryFilePath);

            
            StringBuilder sb = new StringBuilder();

            foreach (byte b in binFile)
            {
                if (bytesList.Contains(b.ToString()))
                {
                    sb.Append(b.ToString()+" ");
                }
            }



            using (writer)
            {
                writer.WriteLine(sb);
            }


        }
    }
}

