
Func<string, string, Predicate<string>> GetPredicate = (filter, value) =>
{
    if(filter == "Starts with")
    {
        return p => p.StartsWith(value);
    }

    if (filter == "Ends with")
    {
        return p => p.EndsWith(value);
    }

    if (filter == "Length")
    {
        return p => p.Length == int.Parse(value);
    }

    if (filter == "Contains")
    {
        return p => p.Contains(value);
    }

    return default;
};

List<string> persons = Console.ReadLine()
                              .Split(" ", StringSplitOptions
                              .RemoveEmptyEntries)
                              .ToList();

Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();

string input = String.Empty;

while((input = Console.ReadLine()) != "Print")
{
    string[] command = input.Split(";", StringSplitOptions.RemoveEmptyEntries);

    string action = command[0];
    string filter = command[1];
    string value = command[2];

    if(action == "Add filter")
    {
        filters.Add(filter + value, GetPredicate(filter, value));
    }

    if(action == "Remove filter")
    {
        filters.Remove(filter + value);
    }
}

foreach(var filter in filters)
{
    persons.RemoveAll(filter.Value);
}

Console.WriteLine(String.Join(" ", persons));