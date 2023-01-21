using System;
using System.Collections.Generic;

namespace _8._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> nums1 = new HashSet<string>();

            HashSet<string> nums2 = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "PARTY")
                {
                    break;
                }
                else
                {
                    if (Char.IsDigit(input[0]))
                    {
                        nums2.Add(input);
                    }
                    else
                    {
                        nums1.Add(input);
                    }
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }
                else
                {
                    if (Char.IsDigit(input[0]))
                    {
                        nums2.Remove(input);
                    }
                    else
                    {
                        nums1.Remove(input);
                    }
                }
            }

            Console.WriteLine($"{nums1.Count+nums2.Count}");

            foreach(string num in nums2)
            {
                Console.WriteLine(num);
            }

            foreach (string num in nums1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
