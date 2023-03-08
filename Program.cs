using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.MainColor = "Neon Pink";
            modelS.MainColor = "Burgundy";
            mx410.MainColor = "Magenta";

            fxs.Drive("fxs", "VVVrrrooooooooommm");
            modelS.Drive("ModelS", "*electric car noises*");
            mx410.Drive("mx410", "BBBBBBBRRRRRRRRRRRRRR");
        }
    }
}