using System;
using System.Collections.Generic;

namespace _6._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> songs = new Queue<string>(Console.ReadLine()
                                                           .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while(true)
            {

                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Play")
                {
                    if(songs.Count>0)
                    {
                        songs.Dequeue();
                    }
                }

                if (command[0] == "Add")
                {
                    string song = command[1];

                    for(int i=2; i<command.Length; i++)
                    {
                        song += " " + command[i];
                    }

                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }

                if (command[0] == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }

                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
            }

        }
    }
}
