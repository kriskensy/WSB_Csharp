using System;
using System.Collections.Generic;

namespace Lab_03_homework_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Audi", "A4", 0);

            car.addFuel(643, 48);
            car.addFuel(1198, 42);
            car.addFuel(1426, 18);
            car.addFuel(1987, 39);
            car.addFuel(2683, 52);

            Console.WriteLine($"Average fuel consumption: {car.averageFuelConsumption:F2} l/100km.");
        }
    }

    public class Car
    {
        private string brand;
        private string model;
        private double mileage;
        private List<double> refuelingHistory;
        private List<double> mileageHistory;

        public Car(string brand, string model, double mileage)
        {
            this.brand = brand;
            this.model = model;
            this.mileage = mileage;
            refuelingHistory = new List<double>();
            mileageHistory = new List<double>();
        }

        public void addFuel(double newMileage, double fuel)
        {
            double kmTraveled = newMileage - mileage;
            mileage = newMileage;
            mileageHistory.Add(kmTraveled);
            refuelingHistory.Add(fuel);
            Console.WriteLine($"Refueling: mileage = {newMileage}km, fuel = {fuel}l.");
        }

        public double averageFuelConsumption
        {
            get
            {
                double totalMileage = 0;
                double totalFuelAmount = 0;

                for (int i = 0; i < mileageHistory.Count; i++)
                {
                    totalMileage += mileageHistory[i];
                    totalFuelAmount += refuelingHistory[i];
                }

                if (totalMileage == 0)
                    return 0;
                return (totalFuelAmount / totalMileage) * 100;
            }
        }
    }
}