using System;
using System.IO;
using System.Text;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream stream = new FileStream(sourceFilePath, FileMode.Open))
            {
                if (stream.Length % 2 == 0)
                {
                    using (FileStream partStream = new FileStream(partOneFilePath, FileMode.OpenOrCreate))
                    {
                        byte[] buffer = new byte[stream.Length / 2];
                        stream.Read(buffer, 0, (int)stream.Length / 2);

                        partStream.Write(buffer, 0, buffer.Length);
                    }

                    using (FileStream partStream = new FileStream(partTwoFilePath, FileMode.OpenOrCreate))
                    {
                        byte[] buffer = new byte[stream.Length / 2];
                        stream.Read(buffer, 0, (int)stream.Length / 2);

                        partStream.Write(buffer, 0, buffer.Length);
                    }
                }
                else
                {
                    using (FileStream partStream = new FileStream(partOneFilePath, FileMode.OpenOrCreate))
                    {
                        byte[] buffer = new byte[(stream.Length / 2) + 1];
                        stream.Read(buffer, 0, (int)(stream.Length / 2) + 1);

                        partStream.Write(buffer, 0, buffer.Length);
                    }

                    using (FileStream partStream = new FileStream(partTwoFilePath, FileMode.OpenOrCreate))
                    {
                        byte[] buffer = new byte[stream.Length / 2];
                        stream.Read(buffer, 0, (int)stream.Length / 2);

                        partStream.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }



        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream partStream = new FileStream(joinedFilePath, FileMode.OpenOrCreate))
            {
                using (FileStream stream = new FileStream(partOneFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);

                    partStream.Write(buffer, 0, buffer.Length);
                }

                using (FileStream stream = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, (int)stream.Length);

                    partStream.Write(buffer, 0, buffer.Length);
                }
            }

        }
    }
}

