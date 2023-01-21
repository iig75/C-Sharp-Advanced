using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace _5._Count_Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letters= new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (!letters.ContainsKey(input[i]))
                {
                    letters.Add(input[i], 0);
                }

                letters[input[i]]++;    
            }

            foreach (var letter in letters.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value))
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }            
        }
    }
}
