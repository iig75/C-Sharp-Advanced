﻿using System;
using System.Collections.Generic;

namespace _6._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            int n = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for(int i=0; i<n; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
