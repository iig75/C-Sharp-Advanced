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

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            var reader = new StreamReader(inputFilePath);

            int count = 0;

            string line = String.Empty;
            string reversedWords = String.Empty;

            while (line != null)
            {
                line = reader.ReadLine();

                if (count % 2 == 0)
                {                    
                    sb.AppendLine(reversedWords = ReversedWords(ReplaceSymbols(line)));
                }

                count++;
            }

            return sb.ToString();
        }



        public static string ReplaceSymbols(string str)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(str);

            char[] symbols = new char[] { '-', ',', '.', '!', '?' };

            foreach (char c in symbols)
            {
                sb.Replace((char)c, '@');
            }

            return sb.ToString();
        }



        public static string ReversedWords(string str)
        {
            string[] array = str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Reverse()
                                .ToArray();

            return String.Join(" ", array);
        }
    }
}
