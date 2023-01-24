using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.__SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> stat = new Dictionary<string, int>();

            while (true)
            {
                string[] command = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "exam finished")
                    break;

                if (command[1] == "banned")
                {
                    if (results.ContainsKey(command[0]))
                    {
                        results.Remove(command[0]);
                    }
                }

                if (command.Length == 3)
                {
                    string lang = command[1];
                    string name = command[0];
                    int points = int.Parse(command[2]);

                    if (!stat.ContainsKey(lang))
                    {
                        stat.Add(lang, 1);
                    }
                    else
                    {
                        stat[lang]++;
                    }

                    if (!results.ContainsKey(name))
                    {
                        results.Add(name, points);
                    }
                    else
                    {
                        foreach (var res in results)
                        {
                            if ((res.Key == name) && (res.Value < points))
                            {
                                results[name] = points;
                                break;
                            }
                        }
                    }

                }
            }

            Console.WriteLine("Results:");

            foreach (var res in results.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{res.Key} | {res.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var st in stat.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{st.Key} - {st.Value}");
            }

        }
    }
}
