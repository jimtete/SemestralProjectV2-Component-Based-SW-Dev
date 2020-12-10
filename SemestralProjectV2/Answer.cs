using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProjectV2
{
    class Answer
    {

        //It contains the string with the answer
        public String text { get; set; }

        //Some answers can be referenced by two words (e.g.: United States, USA) That's why when
        //it is not the first one it checks the second one
        public String backupText { get; set; }

        //The points that the answer is granting to the player
        public int points { get; set; }

        //Constructor
        public Answer(string text, string backupText,int points)
        {
            this.text = text;
            this.backupText = backupText;
            this.points = points;
        }
        
        
    }
}
