using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Basic_Stack_Operations
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

            Stack<int> nums = new Stack<int>(Console.ReadLine()
                                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse));

            if(nums.Count>=S)
            {
                for(int i=1; i<=S; i++)
                {
                    nums.Pop();
                }
            }

            if((nums.Contains(X)) && (nums.Count>0))
            {
                Console.WriteLine("true");
            }

            if ((!nums.Contains(X)) && (nums.Count > 0))
            {
                Console.WriteLine(nums.Min());
            }

            if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }

        }
    }
}
