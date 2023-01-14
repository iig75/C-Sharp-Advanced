using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int priceOfBullets = int.Parse(Console.ReadLine());

            int gunBarrel = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(Console.ReadLine()
                                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                       .Select(int.Parse));

            Queue<int> locks = new Queue<int>(Console.ReadLine()
                                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                     .Select(int.Parse));

            int intelligence = int.Parse(Console.ReadLine());

            int usedBullets = 0;

            while(true)
            {

                if (locks.Count == 0)
                {
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${(intelligence - (usedBullets * priceOfBullets))}");
                    break;
                }

                if (bullets.Count==0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }

                if (bullets.Pop() > locks.Peek())
                {
                    usedBullets++;
                    Console.WriteLine("Ping!");
                }
                else
                {
                    usedBullets++;
                    Console.WriteLine("Bang!");

                    if (locks.Count > 0)
                    {
                        locks.Dequeue();
                    }
                }

                if ((usedBullets % gunBarrel == 0) && (bullets.Count>0))
                {
                    Console.WriteLine("Reloading!");
                }
            }

        }
    }
}
