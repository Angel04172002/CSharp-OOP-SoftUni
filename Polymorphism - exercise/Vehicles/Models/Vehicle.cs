using Vehicles.Models.Interfaces;
using System;
using Vehicles.Exceptions;
using System.Buffers;

namespace Vehicles.Models
{

    public class Vehicle : IVehicle
    {
        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public double TankCapacity { get; private set; }

        public Vehicle(double fuelQuantity, double tankCapacity, double fuelConsumption, double fuelConsumptionAdditional)
        {
            this.FuelQuantity = fuelQuantity;
            this.TankCapacity = tankCapacity;
            this.FuelConsumption = fuelConsumption + fuelConsumptionAdditional;
        }   

        public string Drive(double distance, bool isEmpty = false)
        {
            double neededFuel = 0;

            if(this.GetType().Name == "Bus" && isEmpty == false)
            {
                neededFuel = (1.4 + this.FuelConsumption) * distance;
            }
            else
            {
                neededFuel = this.FuelConsumption * distance;   
            }

            if(this.FuelQuantity - neededFuel < 0)
            {
                throw new InsufficientFuelException($"{this.GetType().Name} needs refueling");
            }

            this.FuelQuantity -= neededFuel;
            return $"{this.GetType().Name} travelled {distance} km";
        }

        public void Refuel(double fuel)
        {
            var neededFuel = fuel;

            if(neededFuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }

            if (this.TankCapacity < neededFuel)
            {
                Console.WriteLine($"Cannot fit {neededFuel} fuel in the tank");
                return;
            }

            if (this.GetType().Name == "Truck")
            {
                neededFuel *= 0.95;
            }

            this.FuelQuantity += neededFuel;  
        }
    }
}
