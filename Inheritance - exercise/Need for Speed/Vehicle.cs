using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private double fuelConsumption;
        public Vehicle(int horsePower, double fuel, double fuelConsumption = 1.25)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
        }

        public double DefaultFuelConsumption { get; set; }

        public virtual double FuelConsumption 
        {
            get
            {
                return this.fuelConsumption;
            }
            set
            {
                this.fuelConsumption = value;
            }
        }

        public double Fuel { get; set; }

        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= this.FuelConsumption * kilometers; 
        }
    }
}
