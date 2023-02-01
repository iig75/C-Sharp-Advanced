
Predicate<int[]> checkDivision = z => (z[0] % z[1] == 0);

Action<List<int>> print = prn => Console.WriteLine(String.Join(" ", prn));

int n = int.Parse(Console.ReadLine());

int[] array = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

List<int> results = new List<int>(0); 

for(int i=1; i<=n; i++)
{
    bool isValid = true;
    
    for(int j=0; j<array.Length; j++)
    {
        int[] nums = new int[2] {i, array[j] };
        
        if(!checkDivision(nums))
        {
            isValid= false;
            break;
        }
    }

    if(isValid)
    {
        results.Add(i);
    }
}

print(results);
