using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    class Questions
    {
        public string Question { get; set; }

        public List<Answers> allAnswers = new List<Answers>();

        public Questions(string question)
        {
            Question = question;

            allAnswers = new List<Answers>();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
