using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double defaultFuelConsumption = 8;
        public RaceMotorcycle(int horesePower, double fuel) : base(horesePower, fuel)
        {

        }

        public override double FuelConsumption { get => defaultFuelConsumption; set => base.FuelConsumption = defaultFuelConsumption; }
    }
}
