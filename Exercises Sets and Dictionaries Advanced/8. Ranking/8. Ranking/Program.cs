using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace _8._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> exams = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> ranking = new Dictionary<string, Dictionary<string, int>>();

            while(true)
            {
                string[] command = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "end of contests")
                    break;

                if (!exams.ContainsKey(command[0]))
                {
                    exams.Add(command[0], command[1]);
                }
                else
                {
                    exams[command[0]] = command[1];
                }
            }

            while(true)
            {
                string[] command = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "end of submissions")
                    break;

                bool valid = false;

                foreach (var exam in exams)
                {
                    if ((exam.Key == command[0]) && (exam.Value == command[1]))
                    {
                        valid=true;
                    }
                }

                if(valid)
                {
                    if (!ranking.ContainsKey(command[2]))
                    {
                        ranking.Add(command[2], new Dictionary<string, int>());
                        ranking[command[2]].Add(command[0], int.Parse(command[3]));
                    }
                    else
                    {
                        if (!ranking[command[2]].ContainsKey(command[0]))
                        {
                            ranking[command[2]].Add(command[0], int.Parse(command[3]));
                        }
                        else
                        {
                            foreach(var rank in ranking)
                            {
                                if (rank.Key == command[2])
                                {
                                    foreach(var exam in rank.Value)
                                    {
                                        if((exam.Key == command[0]) && (exam.Value < int.Parse(command[3])))
                                        {
                                            ranking[command[2]][command[0]] = int.Parse(command[3]);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            int maxsum = 0;
            string name = String.Empty;

            foreach(var rank in ranking)
            {
                int sum = 0;                

                foreach(var exam in rank.Value)
                {
                    sum += exam.Value;
                }

                if(sum>maxsum)
                {
                    maxsum = sum;
                    name = rank.Key;
                }
            }

            Console.WriteLine($"Best candidate is {name} with total {maxsum} points.");

            Console.WriteLine("Ranking:");

            foreach(var rank in ranking.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{rank.Key}");

                foreach(var exam in rank.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {exam.Key} -> {exam.Value}");
                }
            }
        }
    }
}
