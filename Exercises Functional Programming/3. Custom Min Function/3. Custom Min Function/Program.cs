


Console.WriteLine(String.Join(" ",
                    Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray()
                           .OrderBy(x => x)
                           .First()
                           )
                 );


