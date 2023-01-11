using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> nums = new Stack<int>(Console.ReadLine()
                                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                    .Select(int.Parse)
                                                    .ToArray());

            while(true)
            {

                string[] command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                if (command[0].ToLower() == "end")
                    break;

                if (command[0].ToLower() == "add")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        nums.Push(int.Parse(command[i]));
                    }
                }

                if (command[0].ToLower() =="remove")
                {
                    if(nums.Count >= int.Parse(command[1]))
                    {
                        for (int i = 1; i <= int.Parse(command[1]); i++)
                        {
                            nums.Pop();
                        }
                    }
                }

            }

            int sum = 0;

            while (nums.Count!=0)
            {                
                sum+= nums.Pop();
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
