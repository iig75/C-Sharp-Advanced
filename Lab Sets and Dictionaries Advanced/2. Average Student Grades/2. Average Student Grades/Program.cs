using System;
using System.Collections.Generic;

namespace _2._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> list = new Dictionary<string, List<decimal>>();

            for (int i=0; i<n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!list.ContainsKey(input[0]))
                {
                    list.Add(input[0], new List<decimal>() {decimal.Parse(input[1])});
                }
                else
                {
                    list[input[0]].Add(decimal.Parse(input[1]));
                }
            }

            foreach(var name in list)
            {
                Console.Write($"{name.Key} -> ");

                decimal sum = 0;
                int count = 0;

                foreach (decimal val in name.Value)
                {
                    Console.Write($"{val:f2} ");
                    sum += val;
                    count++;
                }

                Console.Write($"(avg: {(sum/count):f2})");

                Console.WriteLine();
            }
        }
    }
}
