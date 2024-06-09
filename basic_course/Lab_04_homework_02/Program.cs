using System;
using System.Collections.Generic;

namespace Lab_04_homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Trip trip = new Trip();
            
            Car car = new Car();
            Bus bus = new Bus();
            Plane plane = new Plane();
            
            trip.Vehicles.Add(car);
            trip.Vehicles.Add(bus);
            trip.Vehicles.Add(plane);

            trip.DisplayAllVehicles();
        }
    }
    
    public abstract class Vehicle
    {
        public abstract int MaxSpeed { get; }
        public abstract int MaxPassengers { get; }
    }
    
    public class Car : Vehicle
    {
        public override int MaxSpeed => 260;
        public override int MaxPassengers => 5;
    }
    
    public class Bus : Vehicle
    {
        public override int MaxSpeed => 110;
        public override int MaxPassengers => 46;
    }
    
    public class Plane : Vehicle
    {
        public override int MaxSpeed => 980;
        public override int MaxPassengers => 340;
    }
    
    public class Trip
    {
        public List<Vehicle> Vehicles { get; } = new List<Vehicle>();
        
        public void DisplayAllVehicles()
        {
            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"Type: {vehicle.GetType().Name}");
                Console.WriteLine($"Max Speed: {vehicle.MaxSpeed} km/h");
                Console.WriteLine($"Max Passengers: {vehicle.MaxPassengers}");
                Console.WriteLine();
            }
        }
    }
}