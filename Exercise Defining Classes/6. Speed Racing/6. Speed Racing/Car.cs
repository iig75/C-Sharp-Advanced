namespace SpeedRacing
{

    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer, double tarvelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = tarvelledDistance;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }
        
        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }



        public void Drive(double distance)
        {
            if(this.FuelAmount >= this.FuelConsumptionPerKilometer*distance)
            {
                this.FuelAmount -= (this.FuelConsumptionPerKilometer * distance);
                this.TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }

    }
}