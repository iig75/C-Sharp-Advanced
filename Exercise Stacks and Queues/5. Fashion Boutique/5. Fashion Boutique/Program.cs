using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                       .Select(int.Parse));

            int rackSize = int.Parse(Console.ReadLine());

            int racks = 1;
            int sum = 0;

            while(clothes.Count>0)
            {
                if(rackSize-sum>=clothes.Peek())
                {
                    sum += clothes.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }
            }

            Console.WriteLine(racks);

        }
    }
}
