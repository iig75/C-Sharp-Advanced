using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.__ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedSet<string>> sideUsers = new SortedDictionary<string, SortedSet<string>>();

            string str = String.Empty;

            while ((str = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] command = str.Split(new string[] { " | ", " -> " }, StringSplitOptions.RemoveEmptyEntries);

                if (str.Contains(" | "))
                {
                    string side = command[0];
                    string user = command[1];

                    if(!sideUsers.Values.Any(x=>x.Contains(user)))
                    {
                        if (!sideUsers.ContainsKey(side))
                        {
                            sideUsers.Add(side, new SortedSet<string>());                            
                        }

                        sideUsers[side].Add(user);
                    }
                }


                if (str.Contains(" -> "))
                {
                    string side = command[1];
                    string user = command[0];

                    foreach (var u in sideUsers)
                    {
                        if (u.Value.Contains(user))
                        {
                            u.Value.Remove(user);
                            break;
                        }
                    }

                    if (!sideUsers.ContainsKey(side))
                    {
                        sideUsers.Add(side, new SortedSet<string>());
                        sideUsers[side].Add(user);
                    }
                    else
                    {
                        if (!sideUsers[side].Contains(user))
                        {
                            sideUsers[side].Add(user);
                        }
                    }

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }



            Dictionary<string, SortedSet<string>> orderedSidesUsers = sideUsers
                .OrderByDescending(s => s.Value.Count)
                .ToDictionary(s => s.Key, s => s.Value);

            foreach (var sideUser in orderedSidesUsers)
            {
                if (sideUser.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {sideUser.Key}, Members: {sideUser.Value.Count}");

                    foreach (var user in sideUser.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }

            }

        }
    }
}
