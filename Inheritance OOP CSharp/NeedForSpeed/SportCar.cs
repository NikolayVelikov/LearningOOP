using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double defaultFuelConsumption = 10;
        public SportCar(int horesePower, double fuel) : base(horesePower, fuel)
        {
        }

        public override double FuelConsumption { get => defaultFuelConsumption; set => base.FuelConsumption = defaultFuelConsumption; }
    }
}
