namespace Garage
{
    public class Ram :Vehicle, IGas // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public int CurrentTankPercentage {get; set;} = 40;
        public void RefuelTank()
        {
            this.CurrentTankPercentage = 100;
        }
    }
}