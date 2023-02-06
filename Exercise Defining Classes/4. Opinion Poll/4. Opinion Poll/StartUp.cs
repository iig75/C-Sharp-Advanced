
namespace DefiningClasses
{

    public class StartUp
    {

        static void Main()
        {
            List<Person> persons = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(input[0], int.Parse(input[1]));

                persons.Add(person);
            }



            foreach(var person in persons.Where(x=>x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}





