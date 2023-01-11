using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> kids = new Queue<string>(Console.ReadLine()
                                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                          .ToArray());

            int count = int.Parse(Console.ReadLine());

            int i = 1;

            while(kids.Count>1)
            {
                if(i==count)
                {
                    Console.WriteLine($"Removed {kids.Dequeue()}");

                    i = 1;
                }
                else
                {
                    kids.Enqueue(kids.Dequeue());
                    i++;
                }
            }

            Console.WriteLine($"Last is {kids.Peek()}");

        }
    }
}
