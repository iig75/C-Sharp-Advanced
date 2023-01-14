using System;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();

            Stack<char> brackets= new Stack<char>();

            bool succeed = true;

            for (int i = 0; i < input.Length; i++)
            {
                if ((input[i].ToString()=="{") || (input[i].ToString()=="[") || (input[i].ToString()=="("))
                {
                    brackets.Push(input[i]);
                }

                if (brackets.Count > 0)
                {
                    if ((input[i].ToString() == "}") && (brackets.Pop().ToString()!="{"))
                    {
                        Console.WriteLine("NO");
                        succeed = false;
                        break;
                    }

                    if ((input[i].ToString() == "]") && (brackets.Pop().ToString() != "["))
                    {
                        Console.WriteLine("NO");
                        succeed = false;
                        break;
                    }

                    if ((input[i].ToString() == ")") && (brackets.Pop().ToString() != "("))
                    {
                        Console.WriteLine("NO");
                        succeed = false;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                    succeed = false;
                    break;
                }
            }

            if(succeed) 
            {
                Console.WriteLine("YES");
            }

        }
    }
}
