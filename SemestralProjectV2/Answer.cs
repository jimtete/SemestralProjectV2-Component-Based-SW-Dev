using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProjectV2
{
    class Answer
    {
        public String text { get; set; }
        public String backupText { get; set; }

        public int points { get; set; }

        public Answer(string text, string backupText,int points)
        {
            this.text = text;
            this.backupText = backupText;
            this.points = points;
        }
        
        
    }
}
