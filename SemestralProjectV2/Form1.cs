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


        private void generateQuestionBtn_Click(object sender, EventArgs e)
        {
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

            int rando = new Random().Next(0, selectedQuestions.Count);

            textBoxAnswer.Text = selectedQuestions[rando].question;
        }

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
