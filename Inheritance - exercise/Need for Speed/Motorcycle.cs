using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(int horsePower, double fuel, double fuelConsumption = 1.25)
            : base(horsePower, fuel, fuelConsumption)
        {
        }
    }
}
