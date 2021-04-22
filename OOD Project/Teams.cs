using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OOD_Project
{
    public class Team : IComparable
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }

        public int FirstRace { get; set; }

        public int ChampionshipsWon { get; set; }

        public virtual List<Drivers> DriversList { get; set; }
        public Team() {}
        public Team(string teamName, int firstRace, int championshipsWon)
        {
            TeamName = teamName;
            FirstRace = firstRace;
            ChampionshipsWon = championshipsWon;

            DriversList = new List<Drivers>();
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
    public class TeamData : DbContext
    {
        public TeamData() : base("TeamData") { } // Giving database it's name

        public DbSet<Drivers> Driver { get; set; } // Creating a table called Driver

        public DbSet<Team> Teams { get; set; } // Creating a table called Teams
    }
}
