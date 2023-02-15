using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    internal class Parking
    {

        private Dictionary<string, Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            cars = new Dictionary<string, Car>();
            this.capacity = capacity;
        }

        public int Count { get { return cars.Count; } }

        public string AddCar(Car car)
        { 
            if(cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if(cars.Count()==capacity)
            {
                return "Parking is full!";
            }

            this.cars.Add(car.RegistrationNumber, car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string RegistrationNumber)
        {
            if(!cars.ContainsKey(RegistrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }

            cars.Remove(RegistrationNumber);

            return $"Successfully removed {RegistrationNumber}";
        }

        public Car GetCar(string RegistrationNumber)
        {
            return cars[RegistrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach(var registrationNumber in RegistrationNumbers)
            {
                RemoveCar(registrationNumber);
            }
        }

    }
}
