using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive(string VehicleModel, string VehicleSound)
        {
            Console.WriteLine($"The {MainColor} {VehicleModel} drives by you, {VehicleSound}");
        }
    }
}