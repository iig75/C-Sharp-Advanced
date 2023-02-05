namespace CarManufacturer

{

    class Car

    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set;}

        public void Drive(double distance)
        {
            if((this.fuelQuantity - (this.fuelConsumption * distance)) > 0)
            {
                this.fuelQuantity -= distance * this.fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {this.Make}\r\nModel: {this.Model}\r\nYear: {this.Year}\r\nFuel: {this.FuelQuantity:F2}";
        }
    }

}