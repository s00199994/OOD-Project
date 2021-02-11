using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOD_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Team> allTeams = new List<Team>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Creating teams

            Team t1 = new Team("Mercedes", 2010, 9);
            Team t2 = new Team("Ferrari", 1950, 16);
            Team t3 = new Team("Red Bull", 2005, 4);
            Team t4 = new Team("McLaren", 1966, 8);
            Team t5 = new Team("Aston Martin", 2021, 0);
            Team t6 = new Team("Alpha Tauri", 2020, 0);
            Team t7 = new Team("Alfa Romeo", 2019, 0);
            Team t8 = new Team("HAAS", 2016, 0);
            Team t9 = new Team("Williams", 1977, 9);
            Team t10 = new Team("Alpine", 1977, 2);

            // Creating driver objects

            Drivers d1 = new Drivers("Lewis Hamilton", 266, 165, true);
            Drivers d2 = new Drivers("Valtteri Bottas", 157, 56, false);
            Drivers d3 = new Drivers("Charles LeClerc", 59, 12, false);
            Drivers d4 = new Drivers("Carlos Sainz", 119, 2, false);
            Drivers d5 = new Drivers("Max Verstappen", 119, 42, false);
            Drivers d6 = new Drivers("Sergio Perez", 195, 10, false);
            Drivers d7 = new Drivers("Daniel Ricciardo", 188, 31, false);
            Drivers d8 = new Drivers("Lando Norris", 38, 1, false);
            Drivers d9 = new Drivers("Sebastian Vettel", 258, 121, true);
            Drivers d10 = new Drivers("Lance Stroll", 79, 3, false);
            Drivers d11 = new Drivers("Pierre Gasly", 64, 2, false);
            Drivers d12 = new Drivers("Yuki Tsunoda", 0, 0, false);
            Drivers d13 = new Drivers("Kimi Raikkonen", 332, 103, true);
            Drivers d14 = new Drivers("Anotnio Giovinazzi", 40, 0, false);
            Drivers d15 = new Drivers("Mick Schumacher", 0, 0, false);
            Drivers d16 = new Drivers("Nikita Mazepin", 0, 0, false);
            Drivers d17 = new Drivers("George Russell", 38, 0, false);
            Drivers d18 = new Drivers("Nicholas Latifi", 17, 0, false);
            Drivers d19 = new Drivers("Fernando Alonso", 314, 97, true);
            Drivers d20 = new Drivers("Esteban Ocon", 67, 1, false);

            // Mercedes Drivers
            t1.DriversList.Add(d1);
            t1.DriversList.Add(d2);
            //Ferrari Drivers
            t2.DriversList.Add(d3);
            t2.DriversList.Add(d4);
            // Red Bull Drivers
            t3.DriversList.Add(d5);
            t3.DriversList.Add(d6);
            // McLaren Drivers
            t4.DriversList.Add(d7);
            t4.DriversList.Add(d8);
            // Aston Martin Drivers
            t5.DriversList.Add(d9);
            t5.DriversList.Add(d10);
            //Alpha Tauri Drivers
            t6.DriversList.Add(d11);
            t6.DriversList.Add(d12);
            // Alfa Romeo Drivers
            t7.DriversList.Add(d13);
            t7.DriversList.Add(d14);
            // HAAS Drivers
            t8.DriversList.Add(d15);
            t8.DriversList.Add(d16);
            // Williams Drivers
            t9.DriversList.Add(d17);
            t9.DriversList.Add(d18);
            // Alpine Drivers
            t10.DriversList.Add(d19);
            t10.DriversList.Add(d20);

            // Adding all teams to a list
            allTeams.Add(t1);
            allTeams.Add(t2);
            allTeams.Add(t3);
            allTeams.Add(t4);
            allTeams.Add(t5);
            allTeams.Add(t6);
            allTeams.Add(t7);
            allTeams.Add(t8);
            allTeams.Add(t9);
            allTeams.Add(t10);

            // Using the list to populate the text box
            lbxTeams.ItemsSource = allTeams;
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Team selectedTeam = lbxTeams.SelectedItem as Team;

            if (selectedTeam != null)
            {
                lbxDrivers.ItemsSource = selectedTeam.DriversList;

                tblkTeamInfo.Text = string.Format($"Year of first race: {selectedTeam.FirstRace}" + $"\nConstructors championships won: {selectedTeam.ChampionshipsWon}");
            }
        }

        private void btnStart_TouchDown(object sender, TouchEventArgs e)
        {
            
        }
    }
}
