using System;

namespace Garage
{
    public interface IElectrics
    {
        int CurrentChargePercentage {get; set;}

        void ChargeBattery();

    }
}