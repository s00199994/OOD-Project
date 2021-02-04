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

            Team t1 = new Team("Mercedes", 2013, 7);
            Team t2 = new Team("Ferrari", 1950, 16);
            Team t3 = new Team("Red Bull", 2005, 4);
            Team t4 = new Team("McLaren", 1966, 8);
            Team t5 = new Team("Racing Point", 2019, 0);
            Team t6 = new Team("Alpha Tauri", 2020, 0);
            Team t7 = new Team("Alfa Romeo", 2019, 0);
            Team t8 = new Team("HAAS", 2016, 0);
            Team t9 = new Team("Williams", 1977, 9);
            Team t10 = new Team("Renault", 1977, 2);

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
    }
}
