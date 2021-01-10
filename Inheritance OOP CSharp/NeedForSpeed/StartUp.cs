using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle(350,150);
            car.Drive(150);
            
            RaceMotorcycle car1 = new RaceMotorcycle(350, 150);
            car1.Drive(150);
        }
    }
}
