using System.Reflection;

namespace RowData
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();

            int count = int.Parse(Console.ReadLine());

            for(int i=0; i<count; i++)
            {
                string[] input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(input[0],
                                  int.Parse(input[1]),
                                  int.Parse(input[2]),
                                  int.Parse(input[3]),
                                  input[4],
                                  double.Parse(input[5]),
                                  int.Parse(input[6]),
                                  double.Parse(input[7]),
                                  int.Parse(input[8]),
                                  double.Parse(input[9]),
                                  int.Parse(input[10]),
                                  double.Parse(input[11]),
                                  int.Parse(input[12])
                                 );

                cars.Add(car);
            }

            string command = Console.ReadLine();

            string[] filter;

            if(command == "fragile")
            {
                filter = cars.Where(x=>x.Cargo.Type == "fragile" && x.Tyres.Any(z=>z.Pressure < 1)).Select(y=>y.Model).ToArray();
            }
            else
            {
                filter = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).Select(y => y.Model).ToArray();
            }

            Console.WriteLine(String.Join(Environment.NewLine, filter));
        }
    }
}