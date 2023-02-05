namespace CarManufacturer
{

    public class Tire
    {
        private int year;
        private int pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }

        public int Year {get; set;}
        public double Pressure { get; set;}
    }





}