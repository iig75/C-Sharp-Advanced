using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> members = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while(true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Statistics")
                    break;

                if (command[1] == "joined")
                {
                    if(!members.ContainsKey(command[0]))
                    {
                        members.Add(command[0], new Dictionary<string, HashSet<string>>());

                        members[command[0]].Add("follower", new HashSet<string>());
                        members[command[0]].Add("following", new HashSet<string>());
                    }
                }

                if (command[1] == "followed")
                {
                    if ((members.ContainsKey(command[0])) && (members.ContainsKey(command[2])) && (command[0] != command[2]))
                    {
                        if (!members[command[2]]["follower"].Contains(command[0]))
                        {
                            members[command[2]]["follower"].Add(command[0]);
                        }

                        if (!members[command[0]]["following"].Contains(command[2]))
                        {
                            members[command[0]]["following"].Add(command[2]);
                        }
                    }
                }
            }

            int x = 1;

            Console.WriteLine($"The V-Logger has a total of {members.Count} vloggers in its logs.");

            foreach(var member in members.OrderByDescending(x => x.Value["follower"].Count).ThenBy(x => x.Value["following"].Count))
            {
                Console.WriteLine($"{x}. {member.Key} : {member.Value["follower"].Count} followers, {member.Value["following"].Count} following");

                if (x==1)
                {
                    foreach(var name in member.Value["follower"].OrderBy(x => x))
                    Console.WriteLine($"*  {name}");
                }

                x++;
            }
        }
    }
}
