using GalacticaOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticaOOP
{
    //Inheritance

    class Planet : SpaceObject
    {
        public float DiameterInMeters { get; set; }
        public float RotationPeriodInHours { get; set; }
        public float RevolutionPeriodInDays { get; set; }
        public PlanetType Type { get; set; }
        public virtual float Distance => Methods.Distance(this);
        public List<Moon> Moons { get; set; }

        public Planet()
        {
            Moons = new List<Moon>();
        }
    }

    enum PlanetType
    {
        Terrestial,
        Giant,
        Dwarf,
        Gas_Giant
    }
}
