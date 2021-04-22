using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Drivers
    {
        [Key]
        public int DriverID { get; set; }
        public string Name { get; set; }
        public int RacesEntered { get; set; }
        public int Podiums { get; set; }
        public bool Champion { get; set; }

        public virtual int TeamID { get; set; }

        public virtual Team Team { get; set; }

        public Drivers() {}

        public Drivers(string name, int racesEntered, int podiums, bool champion)
        {
            Name = name;
            RacesEntered = racesEntered;
            Podiums = podiums;
            Champion = champion;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
