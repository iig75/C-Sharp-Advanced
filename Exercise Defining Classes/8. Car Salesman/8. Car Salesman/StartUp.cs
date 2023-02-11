


namespace CarSalesman
{
    public class StartUp
    {
        static void Main()
        {
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();



            int countEngines = int.Parse(Console.ReadLine());

            for(int i=0; i<countEngines; i++)
            {
                string[] engineProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                engines.Add(InstantEngine(engineProperties));
            }



            int countCars = int.Parse(Console.ReadLine());

            for(int i=0; i<countCars; i++)
            {
                string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                cars.Add(InstantCar(carProperties, engines));
            }



            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }            
        }



        private static Car InstantCar(string[] carProperties, List<Engine> engines)
        {
            Engine engine = engines.Find(x => x.Model == carProperties[1]);

            Car car = new Car(carProperties[0], engine);

            if (carProperties.Length == 3)
            {
                int weight = 0;

                if (int.TryParse(carProperties[2], out weight))
                {
                    car.Weight = weight;
                }
                else
                {
                    car.Color = carProperties[2];
                }
            }

            if (carProperties.Length == 4)
            {
                car.Weight = int.Parse(carProperties[2]);
                car.Color = carProperties[3];
            }

            return car;
        }

        private static Engine InstantEngine(string[] engineProperties)
        {
            Engine engine = new Engine(engineProperties[0], int.Parse(engineProperties[1]));

            if (engineProperties.Length == 3)
            {
                int displacement = 0;

                if (int.TryParse(engineProperties[2], out displacement))
                {
                    engine.Displacement = displacement;
                }
                else
                {
                    engine.Efficiency = engineProperties[2];
                }
            }

            if (engineProperties.Length == 4)
            {
                engine.Displacement = int.Parse(engineProperties[2]);
                engine.Efficiency = engineProperties[3];
            }

            return engine;
        }




    }
}