using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemestralProjectV2
{
    class Answer
    {
        private String _text { get; set; }
        private String _backupText { get; set; }

        private int _points { get; set; }

        public Answer(string text, string backupText,int points)
        {
            _text = text;
            _backupText = backupText;
            _points = points;
        }
        
    }
}
