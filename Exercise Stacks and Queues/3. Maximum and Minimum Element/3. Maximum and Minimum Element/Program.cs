using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> nums = new Stack<int>();

            int N = int.Parse(Console.ReadLine());

            for(int i=1; i<=N; i++)
            {
                int[] input = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();

                if ((input[0] >= 1) && (input[0] <= 4))
                {
                    if (input[0] == 1)
                    {
                        nums.Push(input[1]);
                    }

                    if (input[0] == 2)
                    {
                        nums.Pop();
                    }

                    if (input[0] == 3)
                    {
                        if(nums.Count()>0)
                        {
                            Console.WriteLine(nums.Max());
                        }
                    }

                    if (input[0] == 4)
                    {
                        if (nums.Count() > 0)
                        {
                            Console.WriteLine(nums.Min());
                        }
                    }
                }

            }

            Console.WriteLine(String.Join(", ", nums));

        }
    }
}
