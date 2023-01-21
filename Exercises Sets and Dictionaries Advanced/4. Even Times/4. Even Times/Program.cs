using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Even_Times
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> nums= new Dictionary<int, int>();

            int n= int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if(!nums.ContainsKey(x))
                {
                    nums.Add(x, 0);
                }
                nums[x]++;
            }

            Console.WriteLine(nums.Single(x => x.Value % 2 == 0).Key);
        }
    }
}
