using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    class Quiz
    {
        public string Question { get; set; }

        public string Answer { get; set; }

        public Quiz (string answer, string question)
        {
            Question = question;
            Answer = answer;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
