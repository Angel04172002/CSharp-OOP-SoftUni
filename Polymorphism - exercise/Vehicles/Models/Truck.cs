using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double fuelConsumptionAdditional = 1.6;
        public Truck(double fuelQuantity, double tankCapacity, double fuelConsumption) 
            : base(fuelQuantity, tankCapacity, fuelConsumption, fuelConsumptionAdditional)
        {
        }
    }
}
