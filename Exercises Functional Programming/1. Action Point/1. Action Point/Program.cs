
Action<string> print = name => Console.WriteLine(name);

string[] users = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (string user in users)
{
    print(user);
}













