using System.Reflection;

namespace SpeedRacing
{

    public class StartUp
    {

        static void Main()
        {         
            List<Car> cars = new List<Car>();

            int n= int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Car car = new Car(command[0], double.Parse(command[1]), double.Parse(command[2]), 0);

                cars.Add(car);
            }



            string input = String.Empty;

            while((input = Console.ReadLine()) != "End")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach(Car car in cars)
                {
                    if(car.Model == command[1])
                    {
                        car.Drive(double.Parse(command[2]));
                        break;
                    }
                }
            }



            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        
        } 
    }
}