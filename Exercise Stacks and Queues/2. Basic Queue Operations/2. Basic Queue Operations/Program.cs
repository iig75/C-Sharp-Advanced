using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int N = input[0];
            int S = input[1];
            int X = input[2];

            Queue<int> nums = new Queue<int>(Console.ReadLine()
                                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse));

            if(nums.Count>=S)
            {
                for(int i=1; i<=S; i++)
                {
                    nums.Dequeue();
                }
            }

            if ((nums.Count > 0) && (nums.Contains(X)))
            {
                Console.WriteLine("true");
            }

            if ((nums.Count > 0) && (!nums.Contains(X)))
            {
                Console.WriteLine($"{nums.Min()}");
            }

            if (nums.Count == 0)
            {
                Console.WriteLine($"0");
            }

        }
    }
}
