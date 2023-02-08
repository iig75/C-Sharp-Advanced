namespace RowData
{
    public class Car
    {

        public Car(string model, 
                      int speed, 
                      int power, 
                      int weight, 
                      string type,
                      double tyre1Pressure,
                      int tyre1Age,
                      double tyre2Pressure,
                      int tyre2Age,
                      double tyre3Pressure,
                      int tyre3Age,
                      double tyre4Pressure,
                      int tyre4Age
            )

        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
            Tyres = new Tyre[4];
            Tyres[0] = new Tyre(tyre1Pressure, tyre1Age);
            Tyres[1] = new Tyre(tyre2Pressure, tyre2Age);
            Tyres[2] = new Tyre(tyre3Pressure, tyre3Age);
            Tyres[3] = new Tyre(tyre4Pressure, tyre4Age);
        }

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tyre[] Tyres { get; set; }

    }
}
