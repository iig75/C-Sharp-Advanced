using System;
using System.Collections.Generic;

namespace _9._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string str = String.Empty;

            Stack<string> state = new Stack<string>();

            state.Push(str);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "1")
                {
                    state.Push(str);

                    str += command[1];
                }

                if (command[0] == "2")
                {
                    state.Push(str);

                    str = str.Remove(str.Length - int.Parse(command[1]));
                }

                if (command[0] == "3")
                {
                    Console.WriteLine(str[int.Parse(command[1])-1]);
                }

                if (command[0] == "4")
                {
                    str = state.Pop();
                }
            }

        }
    }
}
