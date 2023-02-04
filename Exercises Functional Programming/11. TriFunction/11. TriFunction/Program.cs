


Func<string, int, bool> CheckNameSum = (name, limit) => name.Sum(ch => ch) >= limit;



Func<string[], int, Func<string, int, bool>, string> CheckNames = (names, limit, match) => names.FirstOrDefault(name => match(name, limit));



int n = int.Parse(Console.ReadLine());

string[] persons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);



Console.WriteLine(CheckNames(persons, n, CheckNameSum));


/*
foreach(string person in persons)
{
    int sum = 0;

    for(int i=0; i<person.Length; i++)
    {
        sum += person[i];
    }

    if(sum >= n)
    {
        Console.WriteLine(person);
        break;
    }
}
*/




