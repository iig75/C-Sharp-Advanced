using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> cars = new Queue<string>();

            int n = int.Parse(Console.ReadLine());

            int count = 0;

            while(true)
            {
                string command = Console.ReadLine();

                if((command != "end") && (command != "green"))
                {
                    cars.Enqueue(command);
                }


                if(command == "green")
                {                    
                    for(int i=0; i<n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                    }
                }

                if(command == "end") 
                {
                    break;
                }

            }

            Console.WriteLine($"{count} cars passed the crossroads.");

        }
    }
}
