using System;
using System.Collections.Generic;
using System.Numerics;

namespace _5._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Dictionary<string, Dictionary<string, List<string>>> countinents = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                string[] input= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string countinent = input[0];
                string country = input[1];
                string city = input[2];

                if (!countinents.ContainsKey(countinent))
                {
                    countinents.Add(countinent, new Dictionary<string, List<string>>());
                    countinents[countinent].Add(country, new List<string>());
                    countinents[countinent][country].Add(city);
                }
                else
                {
                    if (!countinents[countinent].ContainsKey(country))
                    {
                        countinents[countinent].Add(country, new List<string>());
                        countinents[countinent][country].Add(city);
                    }
                    else
                    {
                        countinents[countinent][country].Add(city);
                    }
                }
            }

            foreach(var countinent in countinents)
            {
                Console.WriteLine($"{countinent.Key}:");

                foreach(var country in countinent.Value)
                {
                    Console.Write($"  {country.Key} -> ");

                    Console.Write(String.Join(", ", country.Value));

                    Console.WriteLine();
                }
            }

        }
    }
}
