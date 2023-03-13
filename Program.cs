using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main (string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectrics> electricVehicles = new List<IElectrics>()
            {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach(IElectrics ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach(IElectrics ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach(IElectrics ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram ();
            Cessna cessna150 = new Cessna ();

            List<IGas> gasVehicles = new List<IGas>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach(IGas gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach(IGas gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}