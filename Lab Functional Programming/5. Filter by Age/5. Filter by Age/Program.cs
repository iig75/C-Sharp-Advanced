
int n = int.Parse(Console.ReadLine());

List<Person> persons = new List<Person>();

for(int i=0; i<n; i++)
{
    string[] input = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries);

    Person person = new Person(input[0], int.Parse(input[1]));

    persons.Add(person);
}

string filterType =  Console.ReadLine();
int filterValue = int.Parse(Console.ReadLine());
string formatType = Console.ReadLine();



Func<Person, int, bool> filter = GetFilter(filterType);

persons = persons.Where(p => filter(p, filterValue)).ToList();

Action<Person> formatter = GetFormatter(formatType);




foreach (var person in persons)
{
   formatter(person);
}






Action<Person> GetFormatter(string formatType)
{
    if (formatType == "name age")
    {
        return p => Console.WriteLine($"{p.Name} - {p.Age}");
    }
    if (formatType == "name")
    {
        return p => Console.WriteLine($"{p.Name}");
    }
    if (formatType == "age")
    {
        return p => Console.WriteLine($"{p.Age}");
    }
    return null;
}




Func<Person, int, bool> GetFilter(string filterType)
{
    if (filterType == "younger")
    {
        return (p, value) => p.Age < value;
    }
    else
    {
        return (Person p, int value) => p.Age >= value;
    }
}




public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}