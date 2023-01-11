using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string expression = Console.ReadLine();

            Stack<int> openBrackets = new Stack<int>();

            for(int i=0; i<expression.Length; i++)
            {

                if (expression[i].ToString()=="(")
                {
                    openBrackets.Push(i);
                }

                if (expression[i].ToString()==")")
                {
                    string str=String.Empty;

                    for(int h=openBrackets.Pop(); h<=i; h++)
                    {
                        str += expression[h];                        
                    }

                    Console.WriteLine($"{str}");
                }
            }

        }
    }
}
