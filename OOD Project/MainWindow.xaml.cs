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
        TeamDataEntities db = new TeamDataEntities();

        Questions currentQuestion;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // LINQ Query to populate the teams listbox
            var query = from t in db.Teams
                        select t;

            lbxTeams.ItemsSource = query.ToList();
        }

        private void lbxTeams_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Changing the content of the team info and current drivers to fit with the selected team
            Team selectedTeam = lbxTeams.SelectedItem as Team;

            int TeamID = selectedTeam.TeamID;

            if (selectedTeam != null)
            {
                // LINQ Query to match the drivers to their team via the TeamID
                var query2 = from d in db.Drivers
                             where d.TeamID == TeamID
                             select d.Name;

                lbxDrivers.ItemsSource = query2.ToList();

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
            {
                index = 0;
            }

            if (btnB.IsChecked.Value == true)
            {
                index = 1;
            }

            if (btnC.IsChecked.Value == true)
            {
                index = 2;
            }

            //get question object
            Answers userChoice = currentQuestion.allAnswers[index];

            //compare ans
            if (userChoice == currentQuestion.CorrectAnswer)
            {
                //then user has chosen the correct answer
                MessageBox.Show("Correct");
            }
            else
            {
                //user is incorrect
                MessageBox.Show("Incorrect");
            }
        }
    }
}
