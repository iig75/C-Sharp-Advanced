using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            Queue<int> orders = new Queue<int>(Console.ReadLine()
                                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                      .Select(int.Parse));

            Console.WriteLine(orders.Max());

            while(true)
            {
                if(n >= orders.Peek())
                {
                    n-=orders.Peek();
                    orders.Dequeue();
                }

                if(orders.Count==0)
                {
                    Console.WriteLine("Orders complete");
                    break;
                }

                if(n<orders.Peek())
                {
                    Console.WriteLine("Orders left: " + String.Join(" ", orders));
                    break;
                }

            }

        }
    }
}
