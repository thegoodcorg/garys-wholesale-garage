namespace Garage
{
    public class Zero :Vehicle, IElectrics // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage {get; set;} = 50;

        public void ChargeBattery()
        {
            this.CurrentChargePercentage = 100;
        }
    }
}