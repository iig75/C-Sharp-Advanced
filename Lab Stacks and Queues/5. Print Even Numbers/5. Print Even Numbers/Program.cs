using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<int> nums = new Queue<int>(Console.ReadLine()
                                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse)
                                                    .ToArray());

            Queue<int> result = new Queue<int>();

            int even = 0;

          
            while(nums.Count>0)
            {
                even = nums.Dequeue();

                if (even % 2 == 0)
                {
                    result.Enqueue(even);
                }
            }

            Console.WriteLine(String.Join(", ", result));

        }
    }
}
