using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            var reader1 = new StreamReader(wordsFilePath);
            var reader2 = new StreamReader(textFilePath);
            var writer = new StreamWriter(outputFilePath);

            Dictionary<string, int> wordsCount= new Dictionary<string, int>();

            HashSet<string> keyWords = new HashSet<string>();

            using (reader1)
            {
                keyWords = reader1.ReadToEnd()
                                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                  .ToHashSet();
            }



            using (reader2)
            {
                string text = reader2.ReadToEnd();

                string pattern = @"(?<words>[A-za-z']*)";

                Regex regex = new Regex(pattern);

                foreach (Match match in regex.Matches(text))
                {
                    if (match.Success)
                    {

                        if ((match.Groups["words"].Value != "") && (keyWords.Contains(match.Groups["words"].Value.ToLower())))
                        {
                            if (!wordsCount.ContainsKey(match.Groups["words"].Value.ToLower()))
                            {
                                wordsCount.Add(match.Groups["words"].Value.ToLower(), 0);
                            }

                            wordsCount[match.Groups["words"].Value.ToLower()]++;
                        }



                    }

                }



                using (writer)
                {
                    foreach (var x in wordsCount.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{x.Key} - {x.Value}");
                    }
                }



            }



        }
    }
}

