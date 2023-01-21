using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> elements = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();

                foreach(string st in str)
                {
                    elements.Add(st);
                }
            }

            elements = elements.OrderBy(x => x).ToHashSet();

            Console.WriteLine(String.Join(" ", elements));
        }
    }
}
