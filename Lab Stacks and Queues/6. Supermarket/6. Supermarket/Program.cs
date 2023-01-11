using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> names = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if((command!="Paid")&&(command!="End"))
                {
                    names.Enqueue(command);
                }

                if(command=="Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }

                if(command=="End")
                {
                    Console.WriteLine($"{names.Count} people remaining.");
                    break;
                }
            }

        }
    }
}
