using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RaceTrack.RaceTrack.Cars
{
    public class VwGTI : RaceCar
    {
        public VwGTI()
        {
            Name = "Volkswagen GTI";
            TopSpeed = 155;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts and the whole world ceases to exist.  There is no hope, only the roar of German engineering.");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} screeches to a hault after what was likely another successful victory for German engineering");
        }
    }
}
