
Func<string, string, Predicate<string>> getPredicate = (filter, value) =>
{
    if (filter == "StartsWith")
    {
        return p => p.StartsWith(value);
    }

    if (filter == "EndsWith")
    {
        return p => p.EndsWith(value);
    }

    if (filter == "Length")
    {
        return p => p.Length == int.Parse(value);
    }

    return default;
};



List<string> persons = Console.ReadLine()
                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                              .ToList();

string input = string.Empty;

while ((input = Console.ReadLine()) != "Party!")
{

    string[] validCommand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string command = validCommand[0];
    string filterType = validCommand[1];
    string filterValue = validCommand[2];

    if(command == "Remove")
    {
        persons.RemoveAll(getPredicate(filterType, filterValue));
    }

    if (command == "Double")
    {
        List<string> personToDouble = persons.FindAll(getPredicate(filterType, filterValue));

        foreach(var person in personToDouble)
        {
            int index = persons.FindIndex(p => p == person);

            persons.Insert(index, person);
        }
    }
}



if(persons.Any())
{
    Console.WriteLine($"{String.Join(", ", persons)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}
