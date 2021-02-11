using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    class Team :IComparable
    {
        public string TeamName { get; set; }

        public int FirstRace { get; set; }

        public int ChampionshipsWon { get; set; }

        public List<Drivers> DriversList { get; set; }

        public Team(string teamName, int firstRace, int championshipsWon)
        {
            TeamName = teamName;
            FirstRace = firstRace;
            ChampionshipsWon = championshipsWon;

            DriversList = new List<Drivers>();
        }

        public Team()
        {

        }

        public override string ToString()
        {
            return TeamName;
        }

        public int CompareTo(object obj)
        {
            Team otherTeam = obj as Team;

            return this.TeamName.CompareTo(otherTeam.TeamName);
        }

    }
}
