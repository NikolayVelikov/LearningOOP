using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {

        private const double defaultFuelConsumption = 3;
        public Car(int horesePower, double fuel) : base(horesePower, fuel)
        {

        }

        public override double FuelConsumption
        {
            get
            {
                return defaultFuelConsumption;
            }
            set
            {
                base.FuelConsumption = defaultFuelConsumption;
            }
        }
        public override void Drive(double kilometer)
        {
            this.Fuel -= kilometer * this.FuelConsumption;
        }
    }
}
