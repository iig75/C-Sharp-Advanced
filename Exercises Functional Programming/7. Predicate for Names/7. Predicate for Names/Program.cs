
Predicate<int[]> even = z => (z[0] <= z[1]);

Action<string> print = name => Console.WriteLine(name);

Action<string[], int> counter = (names, n) =>
{
    foreach (var name in names)
    {
        int[] x = new int[2] { name.Length, n};

        if (even(x))
        {
            print(name);
        }
    }
};


int n = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

counter(names, n);