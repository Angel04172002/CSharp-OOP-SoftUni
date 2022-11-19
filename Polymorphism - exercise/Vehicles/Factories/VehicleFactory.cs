using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Factories.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle BuildVehicleUsingFactory(string typeVehicle, double fuelQuantity, double litersPerKm, double tankCapacity)
        {
            IVehicle vehicle;

            if(typeVehicle == "Car")
            {
                vehicle = new Car(fuelQuantity, tankCapacity, litersPerKm);
            }
            else if(typeVehicle == "Truck")
            {
                vehicle = new Truck(fuelQuantity, tankCapacity, litersPerKm);
            }
            else if(typeVehicle == "Bus")
            {
                vehicle = new Bus(fuelQuantity, tankCapacity, litersPerKm);
            }
            else
            {
                throw new ArgumentException();
            }

            return vehicle;
        }
    }
}
