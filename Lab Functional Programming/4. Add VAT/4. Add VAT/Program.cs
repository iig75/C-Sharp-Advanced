

double[] nums = Console.ReadLine()
                       .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                       .Select(s => (double.Parse(s) *1.2))
                       .ToArray();

foreach (double num in nums)
{
    Console.WriteLine($"{num:f2}");
}



