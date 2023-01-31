



Action<string, string> print = (name, title) => Console.WriteLine($"{name} {title}");

string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (string name in names)
{
    print("Sir", name);
}







