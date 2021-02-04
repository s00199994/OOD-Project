using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    class Team
    {
        public string TeamName { get; set; }

        public int YearFormed { get; set; }

        public int ChampionshipsWon { get; set; }

        public Team(string teamName, int yearFormed, int championshipsWon)
        {
            TeamName = teamName;
            YearFormed = yearFormed;
            ChampionshipsWon = championshipsWon;
        }

        public Team()
        {

        }

        public override string ToString()
        {
            return TeamName;
        }

    }
}
