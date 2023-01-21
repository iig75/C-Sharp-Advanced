using System;
using System.Collections.Generic;

namespace _7._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> regNumber = new HashSet<string>();

            while(true)
            {
                string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "END")
                    break;

                if (command[0]=="IN")
                {
                    regNumber.Add(command[1]);
                }

                if (command[0]=="OUT")
                {
                    regNumber.Remove(command[1]);
                }
            }

            if(regNumber.Count>0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, regNumber));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
