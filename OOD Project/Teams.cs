using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    class Teams
    {
        public string TeamName { get; set; }

        public int YearFormed { get; set; }

        public string Principal { get; set; }

        public Teams(string teamName, int yearFormed, string principal)
        {
            TeamName = teamName;
            YearFormed = yearFormed;
            Principal = principal;
        }

        public override string ToString()
        {
            return TeamName;
        }

    }
}
