
List<int> result = new List<int>();

Predicate<int> match = x => x % 2 == 0;

Action<List<int>> print = n => Console.WriteLine(String.Join(" ", n));

while (true)
{
    int[] range = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                         .Select(int.Parse)
                         .ToArray();

    string command = Console.ReadLine();    

    if (command == "odd")
    {
        for (int i = range[0]; i <= range[1]; i++)
        {
            if(!match(i))
            {
                result.Add(i);
            }
        }
    }

    if (command == "even")
    {
        for (int i = range[0]; i <= range[1]; i++)
        {
            if (match(i))
            {
                result.Add(i);
            }
        }
    }

    break;
}

print(result);