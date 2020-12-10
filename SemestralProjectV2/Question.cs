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

        //The question
        public String question { get; set; }

        //The list of answers
        public BindingList<Answer> Answers { get; set; } = new BindingList<Answer>();
        
        //The type of the question
        public int type { get; set; }
        /* 1 for geography, 2 for films and tv, 3 for everyday
         * 4 for history and 5 for technology*/

        //Constructor
        public Question(string question, int type)
        {
            this.question = question;
            this.type = type;
        }

        
    }
}
