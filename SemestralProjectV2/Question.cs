using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProjectV2
{
    class Question
    {
        public String question { get; set; }

        public BindingList<Answer> Answers { get; set; } = new BindingList<Answer>();

        public int type { get; set; }
        /* 1 for geography, 2 for films and tv, 3 for everyday
         * 4 for history and 5 for technology*/

        public Question(string question, int type)
        {
            this.question = question;
            this.type = type;
        }

        
    }
}
