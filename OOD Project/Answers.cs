using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    class Answers
    {
        public string Answer { get; set; }
        public string Answer2 { get; set; }

        public Answers(string answer)
        {
            Answer = answer;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
