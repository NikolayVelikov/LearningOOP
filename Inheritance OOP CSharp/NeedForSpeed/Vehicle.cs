using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horesePower,double fuel)
        {
            this.HorsePower = horesePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double FuelConsumption  { get; set; } = DefaultFuelConsumption;
        
        public virtual void Drive(double kilometer)
        {
            this.Fuel -= kilometer * this.FuelConsumption;
        }
    }
}
