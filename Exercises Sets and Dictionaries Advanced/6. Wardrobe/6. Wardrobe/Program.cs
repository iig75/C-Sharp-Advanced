using System;
using System.Collections.Generic;

namespace _6._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> ClothesByColor = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries );

                if (!ClothesByColor.ContainsKey(input[0]))
                {
                    ClothesByColor.Add(input[0], new Dictionary<string, int>());
                }

                for(int j=1; j<input.Length; j++)
                {
                    if (!ClothesByColor[input[0]].ContainsKey(input[j]))
                    {
                        ClothesByColor[input[0]].Add(input[j], 0);
                    }

                    ClothesByColor[input[0]][input[j]]++;
                }
            }

            string[] findTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach(var color in ClothesByColor)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach(var cloth in color.Value)
                {
                    if((color.Key == findTokens[0]) && (cloth.Key == findTokens[1]))
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");
                    }
                }
            }
        }
    }
}
