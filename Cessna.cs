using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage {get; set;} = 40;
        public void RefuelTank()
        {
           this.CurrentTankPercentage = 100;
        }
    }
}