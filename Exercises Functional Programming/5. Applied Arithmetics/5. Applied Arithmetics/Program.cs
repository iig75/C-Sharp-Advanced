
Action<int[]> add = nums =>
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] += 1;
    }
};

Action<int[]> multiply = nums =>
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] *= 2;
    }
};

Action<int[]> subtract = nums =>
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] -= 1;
    }
};

Action<int[]> print = nums => Console.WriteLine(String.Join(" ", nums));



int[] nums = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

string command = String.Empty;

while((command = Console.ReadLine()) != "end")
{
    switch(command)
    {
        case "add":
            add(nums);
            break;

        case "multiply":
            multiply(nums);
            break;

        case "subtract":
            subtract(nums);
            break;

        case "print":
            print(nums);
            break;
    }
}