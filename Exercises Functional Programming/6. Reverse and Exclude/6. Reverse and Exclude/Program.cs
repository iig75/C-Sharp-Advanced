


Action<List<int>> print = nums => Console.WriteLine(String.Join(" ", nums)); 



Func<List<int>, int, string> divider = (nums, z) =>
{
    for(int i=0; i<nums.Count; i++)
    {
        if (nums[i] % z == 0)
        {
            nums.RemoveAt(i);
            i--;
        }
    }

    nums.Reverse();

    return null;
};



List<int> nums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();

int n = int.Parse(Console.ReadLine());

divider(nums, n);
print(nums);







