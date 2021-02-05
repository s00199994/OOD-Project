using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    class Drivers
    {
        public string Name { get; set; }
        public int RacesEntered { get; set; }
        public int Podiums { get; set; }
        public bool Champion { get; set; }

        public Drivers(string name, int racesEntered, int podiums, bool champion)
        {
            Name = name;
            RacesEntered = racesEntered;
            Podiums = podiums;
            Champion = champion;
        }

        public Drivers()
        {

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
