using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1= new HashSet<int>();
            HashSet<int> set2= new HashSet<int>();

            int[] nums = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            for(int i=0; i < nums[0]; i++)
            {
                set1.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < nums[1]; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }

            set1.IntersectWith(set2);

            Console.WriteLine(String.Join(" ", set1));
        }
    }
}
