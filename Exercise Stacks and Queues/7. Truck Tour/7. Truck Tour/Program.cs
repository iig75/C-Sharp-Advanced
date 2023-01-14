using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _7._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Queue <int[]> queue = new Queue<int[]>();

            for(int i=0; i<n; i++)
            {
                queue.Enqueue(Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray());
            }

            for(int i=0; i<n; i++)
            {

                bool complete = true;
                int fuel = 0;
                int distance = 0;

                foreach (var item in queue)
                {
                    fuel += item[0];
                    distance = item[1];

                    if (fuel - distance < 0)
                    {
                        int[] temp = new int[2];

                        queue.Enqueue(queue.Dequeue());
                        
                        complete = false;

                        break;
                    }
                    else
                    {
                        fuel-= distance;
                    }
                }

                if(complete)
                {
                    Console.WriteLine($"{i}");
                    break;
                }

            }
        }
    }
}
