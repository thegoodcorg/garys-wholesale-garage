using System;

namespace Garage
{
    public interface IGas
    {
        int CurrentTankPercentage {get; set;}

        void RefuelTank();

    }
}