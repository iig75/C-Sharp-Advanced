

string[] items = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Where(x => x[0] == char.ToUpper(x[0]) && char.IsLetter(x[0]))
                        .ToArray();

foreach(var item in items)
{
    Console.WriteLine($"{item}");
}