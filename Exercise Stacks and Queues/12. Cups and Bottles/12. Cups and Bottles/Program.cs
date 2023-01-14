using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<int> cups= new Queue<int>(Console.ReadLine()
                                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                   .Select(int.Parse));

            Stack<int> bottles = new Stack<int>(Console.ReadLine()
                                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                      .Select(int.Parse));

            int currentBottle = 0;
            int currentCup = 0;
            int wasteWater = 0;

            currentBottle = bottles.Peek();
            currentCup = cups.Peek();

            while ((bottles.Count>0) && (cups.Count>0))
            {
                if (currentBottle>=currentCup)
                {
                    wasteWater += currentBottle - currentCup;

                    bottles.Pop();
                    cups.Dequeue();

                    if(bottles.Count>0)
                        currentBottle = bottles.Peek();

                    if(cups.Count>0)
                        currentCup = cups.Peek();
                }
                else                    
                {
                    currentCup -= currentBottle;
                        
                    bottles.Pop();

                    if(bottles.Count>0)
                        currentBottle = bottles.Peek();
                }
            }

            if(bottles.Count>0)
            {
                Console.WriteLine("Bottles: " + String.Join(" ", bottles));
            }

            if(cups.Count>0)
            {
                Console.WriteLine("Cups: " + String.Join(" ", cups));
            }

            Console.WriteLine($"Wasted litters of water: {wasteWater}");

        }
    }
}
