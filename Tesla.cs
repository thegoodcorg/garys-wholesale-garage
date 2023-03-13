namespace Garage
{
    public class Tesla :Vehicle, IElectrics // Electric car
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage {get; set;} = 50;

        public void ChargeBattery()
        {
            this.CurrentChargePercentage = 100;
        }
    }
}