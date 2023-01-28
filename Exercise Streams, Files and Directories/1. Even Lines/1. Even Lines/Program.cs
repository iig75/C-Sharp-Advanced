using System;

namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            var reader = new StreamReader(inputFilePath);

            int i = 0;

            while (!reader.EndOfStream)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(ProcessLines(reader.ReadLine()));
                }
                else
                {
                    reader.ReadLine();
                }

                i++;
            }
            
        }

        public static string ProcessLines(string str)
        {
            Random rand = new Random();

            StringBuilder sb = new StringBuilder();

            sb.Append(str);

            sb.Replace("-", "@");
            sb.Replace(",", "@");
            sb.Replace(".", "@");
            sb.Replace("!", "@");
            sb.Replace("?", "@");

            List<string> line = sb.ToString().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            sb = new StringBuilder();

            while (line.Count > 0)
            {
                int x = rand.Next(0, line.Count);
                sb.Append(line[x]+" ");
                line.RemoveAt(x);
            }

            return sb.ToString();
        }



    }
}
