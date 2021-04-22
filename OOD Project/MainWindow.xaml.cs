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
        Questions currentQuestion;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

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
            Drivers d14 = new Drivers("Antonio Giovinazzi", 40, 0, false);
            Drivers d15 = new Drivers("Mick Schumacher", 0, 0, false);
            Drivers d16 = new Drivers("Nikita Mazepin", 0, 0, false);
            Drivers d17 = new Drivers("George Russell", 38, 0, false);
            Drivers d18 = new Drivers("Nicholas Latifi", 17, 0, false);
            Drivers d19 = new Drivers("Fernando Alonso", 314, 97, true);
            Drivers d20 = new Drivers("Esteban Ocon", 67, 1, false);

            //// Mercedes Drivers
            //t1.DriversList.Add(d1);
            //t1.DriversList.Add(d2);
            ////Ferrari Drivers
            //t2.DriversList.Add(d3);
            //t2.DriversList.Add(d4);
            //// Red Bull Drivers
            //t3.DriversList.Add(d5);
            //t3.DriversList.Add(d6);
            //// McLaren Drivers
            //t4.DriversList.Add(d7);
            //t4.DriversList.Add(d8);
            //// Aston Martin Drivers
            //t5.DriversList.Add(d9);
            //t5.DriversList.Add(d10);
            ////Alpha Tauri Drivers
            //t6.DriversList.Add(d11);
            //t6.DriversList.Add(d12);
            //// Alfa Romeo Drivers
            //t7.DriversList.Add(d13);
            //t7.DriversList.Add(d14);
            //// HAAS Drivers
            //t8.DriversList.Add(d15);
            //t8.DriversList.Add(d16);
            //// Williams Drivers
            //t9.DriversList.Add(d17);
            //t9.DriversList.Add(d18);
            //// Alpine Drivers
            //t10.DriversList.Add(d19);
            //t10.DriversList.Add(d20);

            //// Adding all teams to a list
            //allTeams.Add(t1);
            //allTeams.Add(t2);
            //allTeams.Add(t3);
            //allTeams.Add(t4);
            //allTeams.Add(t5);
            //allTeams.Add(t6);
            //allTeams.Add(t7);
            //allTeams.Add(t8);
            //allTeams.Add(t9);
            //allTeams.Add(t10);

            //// Using the list to populate the text box
            //lbxTeams.ItemsSource = allTeams;
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Changing the content of the team info and current drivers to fit with the selected team
            Team selectedTeam = lbxTeams.SelectedItem as Team;

            if (selectedTeam != null)
            {
                lbxDrivers.ItemsSource = selectedTeam.DriversList;

                // Formatting the content of the team info box
                tblkTeamInfo.Text = string.Format($"Year of first race: {selectedTeam.FirstRace}" + $"\nConstructors championships won: {selectedTeam.ChampionshipsWon}");
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            // Declaring a random number to use later in my switch statement
            Random rand = new Random();
            // Creating a list of questions
            List<Questions> allQuestions = new List<Questions>();

            // Creating the questions
            Questions q1 = new Questions("How many Constructors Championships has Ferrari won?");
            Questions q2 = new Questions("Who is the most successful Formula 1 Driver ever?");
            Questions q3 = new Questions("Which driver currently holds the record for most race starts?");

            // Creating the answers
            Answers q1a = new Answers("10");
            Answers q1b = new Answers("16");
            Answers q1c = new Answers("14");
            Answers q2a = new Answers("Michael Schumacher");
            Answers q2b = new Answers("Ayrton Senna");
            Answers q2c = new Answers("Lewis Hamilton");
            Answers q3a = new Answers("Kimi Raikkonen");
            Answers q3b = new Answers("Rubens Barrichello");
            Answers q3c = new Answers("Fernando Alonso");

            // Adding all the answers to the list that is held within the Questions class
            q1.allAnswers.Add(q1a);
            q1.allAnswers.Add(q1b);
            q1.allAnswers.Add(q1c);
            q1.CorrectAnswer = q1b;

            q2.allAnswers.Add(q2a);
            q2.allAnswers.Add(q2b);
            q2.allAnswers.Add(q2c);
            q2.CorrectAnswer = q2c;

            q3.allAnswers.Add(q3a);
            q3.allAnswers.Add(q3b);
            q3.allAnswers.Add(q3c);
            q3.CorrectAnswer = q3a;

            // Adding the questions to the questions list
            allQuestions.Add(q1);
            allQuestions.Add(q2);
            allQuestions.Add(q3);

            // Getting my random number to select a question
            int questionNum = rand.Next(1, 3);

            Questions selectedQuestion = q1;

            // Using a switch statement to change what the question and answers will be based on the result from the random number
            switch (questionNum)
            {
                case 1:
                    selectedQuestion = q1;
                    tblkQuestion.Text = selectedQuestion.Question;

                    btnA.Content = selectedQuestion.allAnswers[0].Answer;
                    btnB.Content = selectedQuestion.allAnswers[1].Answer;
                    btnC.Content = selectedQuestion.allAnswers[2].Answer;

                    break;
                case 2:
                    selectedQuestion = q2;
                    tblkQuestion.Text = selectedQuestion.Question;

                    btnA.Content = selectedQuestion.allAnswers[0].Answer;
                    btnB.Content = selectedQuestion.allAnswers[1].Answer;
                    btnC.Content = selectedQuestion.allAnswers[2].Answer;

                    break;
                case 3:
                    selectedQuestion = q3;
                    tblkQuestion.Text = selectedQuestion.Question;

                    btnA.Content = selectedQuestion.allAnswers[0].Answer;
                    btnB.Content = selectedQuestion.allAnswers[1].Answer;
                    btnC.Content = selectedQuestion.allAnswers[2].Answer;

                    break;
            }

            currentQuestion = selectedQuestion;

        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            int index = -1;
            //get user selectiong - radio button they clicked
            if (btnA.IsChecked.Value == true)
                index = 0;

            //get question object
            Answers userChoice = currentQuestion.allAnswers[index];

            //compare ans
            if (userChoice == currentQuestion.CorrectAnswer)
                //then user has chosen the correct answer
                MessageBox.Show("Correct");
            else
                //user is incorrect
                MessageBox.Show("Incorrect");
        }
    }
}
