using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<string> expression = new Stack<string>(Console.ReadLine()
                                                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                                 .ToArray().Reverse()
                                                                 );

            int sum = int.Parse(expression.Pop());
            int i = 0;

            while (expression.Count > 0)
            {
                if(i % 2 != 0)
                {
                    if(expression.Pop()=="+")
                    {
                        sum += int.Parse(expression.Pop());
                    }
                    else
                    {
                        sum -= int.Parse(expression.Pop());
                    }
                }

                i++;                   
            }

            Console.WriteLine(sum);

        }
    }
}
