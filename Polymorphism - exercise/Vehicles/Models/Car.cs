using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double fuelConsumptionAdditional = 0.9;
        public Car(double fuelQuantity, double tankCapacity, double fuelConsumption) 
            : base(fuelQuantity, tankCapacity, fuelConsumption, fuelConsumptionAdditional)
        {
        }
    }
}
