using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double fuelConsumptionAdditional = 0;
        public Bus(double fuelQuantity, double tankCapacity, double fuelConsumption) 
            : base(fuelQuantity, tankCapacity, fuelConsumption, fuelConsumptionAdditional)
        {
        }
    }
}
