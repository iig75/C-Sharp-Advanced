using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Dictionary<double, int> nums = new Dictionary<double, int>();

            for(int i=0; i<input.Length; i++)
            {
                if (!nums.ContainsKey(input[i]))
                {
                    nums.Add(input[i], 0);
                }

                nums[input[i]]++;
            }
                


            foreach(var num in nums)
            {
                //-2.5 - 3 times
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
