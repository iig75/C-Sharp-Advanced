using System;
using System.Collections;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            string str = Console.ReadLine();

            Stack<string> stack = new Stack<string>();

            for(int i=0; i<str.Length; i++)
            {
                stack.Push(str[i].ToString());
            }

            for(int i=stack.Count; i>0;  i--)
            {
                Console.Write($"{stack.Pop()}");
            }
        }
    }
}
