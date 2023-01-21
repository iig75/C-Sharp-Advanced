using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            List<int> nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            int count = 0;

            nums = nums.OrderByDescending(x => x).ToList();

            count = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write($"{nums[i]} ");

                count++;

                if (count == 3)
                    break;
            }
        }
    }
}
