using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int greenLite = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            int cars = 0;
            bool bump = false;
            string currentCar = String.Empty;
            char hit = '0';

            Queue<string> queue= new Queue<string>();

            while(true)
            {
                string command = Console.ReadLine();

                if ((command == "END") || (bump))
                {
                    if (!bump)
                    {
                        Console.WriteLine("Everyone is safe.");
                        Console.WriteLine($"{cars} total cars passed the crossroads.");
                    }
                    else
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {hit}.");

                    }

                    break;
                }
                    

                if(command=="green")
                {
                    int time = greenLite;
                    
                    while(time>0)
                    {
                        if(queue.Count > 0)
                        {
                            currentCar = queue.Dequeue();
                            time -= currentCar.Length;

                            cars++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    time += freeWindow;

                    if(time>=0)
                    {
                        bump = false;
                    }
                    else
                    {
                        hit = currentCar[currentCar.Length - Math.Abs(time)];
                        bump = true;
                    }
                }

                if(command!="green")
                {
                    queue.Enqueue(command);
                }

            }

        }
    }
}
