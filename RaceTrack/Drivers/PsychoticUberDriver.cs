using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

// Larry the psychotic, soccer loving uber driver.
// A class by Sam Kaiser
namespace RaceTrack.RaceTrack.Drivers
{
    public class PsychoticUberDriver : Driver
    {
        public PsychoticUberDriver(RaceCar car) : base(car)
        {
            // We've all been scared of our Uber before
            Name = "Larry the psychotic Uber Man";
            
            // Larry the angry Uber Man is a total BEAST MODE, max level driver
            SkillLevel = 9;

        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
