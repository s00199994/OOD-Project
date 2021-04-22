using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Project;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TeamData db = new TeamData();

            using (db)
            {
                // Creating team objects
                Team t1 = new Team() { TeamID = 1, TeamName = "Mercedes", FirstRace = 2010, ChampionshipsWon = 9 };
                Team t2 = new Team() { TeamID = 2, TeamName = "Ferrari", FirstRace = 1950, ChampionshipsWon = 16 };
                Team t3 = new Team() { TeamID = 3, TeamName = "Red Bull", FirstRace = 2005, ChampionshipsWon = 4 };
                Team t4 = new Team() { TeamID = 4, TeamName = "McLaren", FirstRace = 1966, ChampionshipsWon = 8 };
                Team t5 = new Team() { TeamID = 5, TeamName = "Aston Martin", FirstRace = 2021, ChampionshipsWon = 0 };
                Team t6 = new Team() { TeamID = 6, TeamName = "Alpha Tauri", FirstRace = 2020, ChampionshipsWon = 0 };
                Team t7 = new Team() { TeamID = 7, TeamName = "Alfa Romeo", FirstRace = 2019, ChampionshipsWon = 0 };
                Team t8 = new Team() { TeamID = 8, TeamName = "HAAS", FirstRace = 2016, ChampionshipsWon = 0 };
                Team t9 = new Team() { TeamID = 9, TeamName = "Williams", FirstRace = 1977, ChampionshipsWon = 9 };
                Team t10 = new Team() { TeamID = 10, TeamName = "Alpine", FirstRace = 1977, ChampionshipsWon = 2 };

                // Creating driver objects
                Drivers d1 = new Drivers() { Name = "Lewis Hamilton", RacesEntered = 266, Podiums = 165, Champion = true };
                Drivers d2 = new Drivers() { Name = "Valtteri Bottas", RacesEntered = 157, Podiums = 56, Champion = false };
                Drivers d3 = new Drivers() { Name = "Charles LeClerc", RacesEntered = 59, Podiums = 12, Champion = false };
                Drivers d4 = new Drivers() { Name = "Carlos Sainz", RacesEntered = 119, Podiums = 2, Champion = false };
                Drivers d5 = new Drivers() { Name = "Max Verstappen", RacesEntered = 119, Podiums = 42, Champion = false };
                Drivers d6 = new Drivers() { Name = "Sergio Perez", RacesEntered = 195, Podiums = 10, Champion = false };
                Drivers d7 = new Drivers() { Name = "Daniel Ricciardo", RacesEntered = 188, Podiums = 31, Champion = false };
                Drivers d8 = new Drivers() { Name = "Lando Norris", RacesEntered = 38, Podiums = 1, Champion = false };
                Drivers d9 = new Drivers() { Name = "Sebastian Vettel", RacesEntered = 258, Podiums = 121, Champion = true };
                Drivers d10 = new Drivers() { Name = "Lance Stroll", RacesEntered = 79, Podiums = 3, Champion = false };
                Drivers d11 = new Drivers() { Name = "Pierre Gasly", RacesEntered = 64, Podiums = 2, Champion = false };
                Drivers d12 = new Drivers() { Name = "Yuki Tsunoda", RacesEntered = 2, Podiums = 0, Champion = false };
                Drivers d13 = new Drivers() { Name = "Kimi Raikkonen", RacesEntered = 332, Podiums = 103, Champion = true };
                Drivers d14 = new Drivers() { Name = "Antonio Giovinazzi", RacesEntered = 40, Podiums = 0, Champion = false };
                Drivers d15 = new Drivers() { Name = "Mick Schumacher", RacesEntered = 2, Podiums = 0, Champion = false };
                Drivers d16 = new Drivers() { Name = "Nikita Mazepin", RacesEntered = 2, Podiums = 0, Champion = false };
                Drivers d17 = new Drivers() { Name = "George Russell", RacesEntered = 38, Podiums = 0, Champion = false };
                Drivers d18 = new Drivers() { Name = "Nicholas Latifi", RacesEntered = 17, Podiums = 0, Champion = false };
                Drivers d19 = new Drivers() { Name = "Fernando Alonso", RacesEntered = 314, Podiums = 97, Champion = true };
                Drivers d20 = new Drivers() { Name = "Esteban Ocon", RacesEntered = 67, Podiums = 1,Champion = false };

                Console.WriteLine("Adding to database...");

                // Adding all team objects to the db
                db.Teams.Add(t1);
                db.Teams.Add(t2);
                db.Teams.Add(t3);
                db.Teams.Add(t4);
                db.Teams.Add(t5);
                db.Teams.Add(t6);
                db.Teams.Add(t7);
                db.Teams.Add(t8);
                db.Teams.Add(t9);
                db.Teams.Add(t10);
                Console.WriteLine("Successfully added teams.");

                // Adding all driver objects to db
                db.Driver.Add(d1);
                db.Driver.Add(d2);
                db.Driver.Add(d3);
                db.Driver.Add(d4);
                db.Driver.Add(d5);
                db.Driver.Add(d6);
                db.Driver.Add(d7);
                db.Driver.Add(d8);
                db.Driver.Add(d9);
                db.Driver.Add(d10);
                db.Driver.Add(d11);
                db.Driver.Add(d12);
                db.Driver.Add(d13);
                db.Driver.Add(d14);
                db.Driver.Add(d15);
                db.Driver.Add(d16);
                db.Driver.Add(d17);
                db.Driver.Add(d18);
                db.Driver.Add(d19);
                db.Driver.Add(d20);
                Console.WriteLine("Successfully added drivers.");

                // Saving changes made
                db.SaveChanges();
                Console.WriteLine("Changes Saved.");

            }
        }
    }
}
