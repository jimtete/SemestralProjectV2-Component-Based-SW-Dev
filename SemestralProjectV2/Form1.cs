using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemestralProjectV2
{
    public partial class Form1 : Form
    {

        
        BindingList<Question> selectedQuestions = new BindingList<Question>();
        
        public Form1()
        {
            InitializeComponent();
            generateQuestionBtn.Enabled = false;
            
            


        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            String answer = textBoxAns.Text.ToString();
            if (Equals(answer,"NA")) return;
            bool found = false;
            int savedI = -1;
            for (int i = 0; i < j; i++)
            {
                found = CheckAnswer(answer.ToLower(), selectedQuestions[rando].Answers[i]);
                if (found) savedI = i;
            }

            Console.WriteLine(found);
            if (savedI==-1) return;

            points += selectedQuestions[rando].Answers[savedI].points;
            rightAnswers.Add(selectedQuestions[rando].Answers[savedI]);
            rightAnswersDGV.DataSource = rightAnswers;
            selectedQuestions[rando].Answers.RemoveAt(savedI);
            j--;
            
            
        }
        int points;
        int j;
        bool CheckAnswer(String key, Answer answer)
        {

            
            if (Equals(key, answer.text.ToLower())) return true;
            if (Equals(key, answer.backupText.ToLower())) return true;
            return false;
        }

        BindingList<Answer> rightAnswers;
        private void generateQuestionBtn_Click(object sender, EventArgs e)
        {
            points = 0;
            j = 10;
            rightAnswersDGV.DataSource = null;
            rightAnswers = new BindingList<Answer>();
            selectedQuestions.Clear();
            if (checkBoxGeography.Checked)
            {
                addQuestion(0, 4);

            }
            if (checkBoxFilms.Checked)
            {
                addQuestion(5, 9);
            }
            if (checkBoxEveryday.Checked)
            {
                addQuestion(10, 14);
            }
            if (checkBoxHistory.Checked)
            {
                addQuestion(15, 19);
            }
            if (checkBoxTechnology.Checked)
            {
                addQuestion(20, 24);
            }

            rando = new Random().Next(0, selectedQuestions.Count);

            textBoxAnswer.Text = selectedQuestions[rando].question;
        }

        int rando;

        public void addQuestion(int a,int b)
        {
            for (int i = a; i <= b; i++)
            {
                selectedQuestions.Add(Database.Questions[i]);
            }
        }

        bool geoChecked = false;
        private void checkBoxGeography_CheckedChanged(object sender, EventArgs e)
        {
            geoChecked = !geoChecked;
            buttonEnabler();
        }

        bool filmChecked = false;
        private void checkBoxFilms_CheckedChanged(object sender, EventArgs e)
        {
            filmChecked = !filmChecked;
            buttonEnabler();
        }

        bool everyChecked = false;
        private void checkBoxEveryday_CheckedChanged(object sender, EventArgs e)
        {
            everyChecked = !everyChecked;
            buttonEnabler();
        }

        bool historyChecked = false;
        private void checkBoxHistory_CheckedChanged(object sender, EventArgs e)
        {
            historyChecked = !historyChecked;
            buttonEnabler();
        }

        bool techChecked = false;
        private void checkBoxTechnology_CheckedChanged(object sender, EventArgs e)
        {
            techChecked = !techChecked;
            buttonEnabler();
        }

        private void buttonEnabler()
        {
            if (geoChecked || techChecked || historyChecked || everyChecked || filmChecked)
            {
                generateQuestionBtn.Enabled = true;
            }
            else
            {
                generateQuestionBtn.Enabled = false;
            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
